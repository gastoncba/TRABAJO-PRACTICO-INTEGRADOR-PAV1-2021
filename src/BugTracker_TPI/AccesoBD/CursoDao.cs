using System;
using System.Collections.Generic;
using System.Text;
using BugTracker_TPI.Entidades;
using System.Data;

namespace BugTracker_TPI.AccesoBD
{
    class CursoDao
    {
        public IList<Curso> getAll()
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
                                            "WHERE C.borrado = 0");
            
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
                                            "WHERE C.borrado = 0");

            if(parametros.ContainsKey("vigencia"))
                consulta += " AND (C.fecha_vigencia >= @vigencia) ";
    
            if (parametros.ContainsKey("idCategoria"))
                consulta += " AND (C.id_categoria = @idCategoria) ";

            if (parametros.ContainsKey("curso"))
                consulta += " AND (C.nombre = @curso) ";

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
    }
}
