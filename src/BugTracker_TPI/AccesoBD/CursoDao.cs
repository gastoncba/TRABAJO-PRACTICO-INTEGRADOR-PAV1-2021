using System;
using System.Collections.Generic;
using System.Text;
using BugTracker_TPI.Entidades;
using System.Data;

namespace BugTracker_TPI.AccesoBD
{
    class CursoDao
    {
        public IList<Curso> getAll(bool incluirBorrados = false)
        {
            //armamos una lista vacia
            List<Curso> listadoCursos = new List<Curso>();

            String consulta = string.Concat("SELECT C.id_curso, ",
                                            "C.nombre, ",
                                            "C.descripcion, ",
                                            "C.fecha_vigencia, ",
                                            "X.id_categoria, ",
                                            "X.nombre as categoria ",
                                            "FROM Cursos C INNER JOIN Categorias X ON C.id_categoria = X.id_categoria");
            
            if(!incluirBorrados)
            {
                consulta += " WHERE C.borrado = 0";
            }

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(consulta);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoCursos.Add(ObjectMapping(row));
            }

            return listadoCursos;
        }

        public IList<Curso> filter(Dictionary<string, object> parametros)
        {
            //armamos una lista vacia
            List<Curso> listadoCursos = new List<Curso>();

            String consulta = string.Concat("SELECT C.id_curso, ",
                                            "C.nombre, ",
                                            "C.descripcion, ",
                                            "C.fecha_vigencia, ",
                                            "X.id_categoria, ",
                                            "X.nombre as categoria ",
                                            "FROM Cursos C INNER JOIN Categorias X ON C.id_categoria = X.id_categoria ",
                                            "WHERE");


            if (parametros.ContainsKey("baja"))
                consulta += " C.borrado = @baja ";

            if (parametros.ContainsKey("vigencia"))
                consulta += " AND (C.fecha_vigencia >= @vigencia) ";
    
            if (parametros.ContainsKey("idCategoria"))
                consulta += " AND (C.id_categoria = @idCategoria) ";

            if (parametros.ContainsKey("curso"))
                consulta += " AND (C.nombre LIKE '%' + @curso + '%') ";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(consulta, parametros);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoCursos.Add(ObjectMapping(row));
            }

            return listadoCursos;
        }

        public Curso ObjectMapping(DataRow row) 
        {
            Curso oCurso = new Curso
            {
                IdCurso = Convert.ToInt32(row["id_curso"].ToString()),
                NombreCurso = row["nombre"].ToString(),
                Descripcion = row["descripcion"].ToString(),
                FechaVigencia = Convert.ToDateTime(row["fecha_vigencia"].ToString()),
                Categoria = new Categoria()
                {
                    IdCategoria = Convert.ToInt32(row["id_categoria"].ToString()),
                    NombreCategoria = row["categoria"].ToString(),
                }
            };
            return oCurso;
        }

        public bool exist(String cursoNombre)
        {

            String consulta = string.Concat("SELECT * FROM Cursos C WHERE C.nombre = @cursoNombre");

            var parametros = new Dictionary<string, object>();
            parametros.Add("cursoNombre", cursoNombre);

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(consulta, parametros);

            if (resultadoConsulta.Rows.Count != 0)
                return true;
            
            return false;
        }

        public bool create(Curso curso)
        {
            String sentencia_sql = " INSERT INTO Cursos (nombre, descripcion, fecha_vigencia, id_categoria, borrado) " +
                " VALUES (@nombre, @descripcion, @fecha_vigencia, @id_categoria, 0) ";

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", curso.NombreCurso);
            parametros.Add("descripcion", curso.Descripcion);
            parametros.Add("fecha_vigencia", curso.FechaVigencia);
            parametros.Add("id_categoria", curso.Categoria.IdCategoria);

            return (DataManager.GetInstance().EjecutarSQL(sentencia_sql, parametros) == 1);

        }

        public bool update(Curso curso)
        {

            String sentencia_sql = string.Concat("UPDATE Cursos ",
                                                 "SET ", 
                                                 "nombre = @nombre, ", 
                                                 "descripcion = @descripcion, ",
                                                 "fecha_vigencia = @fecha_vigencia, ", 
                                                 "id_categoria = @id_categoria ",
                                                 "WHERE id_curso = @id_curso"); 

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_curso", curso.IdCurso);
            parametros.Add("nombre", curso.NombreCurso);
            parametros.Add("descripcion", curso.Descripcion);
            parametros.Add("fecha_vigencia", curso.FechaVigencia);
            parametros.Add("id_categoria", curso.Categoria.IdCategoria);

            return (DataManager.GetInstance().EjecutarSQL(sentencia_sql, parametros) == 1);
        }

        public bool delete(Curso curso)
        {
            String sentencia_sql = " UPDATE Cursos SET borrado = 1 WHERE id_curso = @id_curso";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_curso", curso.IdCurso);

            return (DataManager.GetInstance().EjecutarSQL(sentencia_sql, parametros) == 1);
        }

    }
}
