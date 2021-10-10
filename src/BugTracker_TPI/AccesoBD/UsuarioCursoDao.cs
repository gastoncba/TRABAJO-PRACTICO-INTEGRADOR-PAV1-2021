using System;
using System.Collections.Generic;
using System.Text;
using BugTracker_TPI.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace BugTracker_TPI.AccesoBD
{
    class UsuarioCursoDao
    {
        public IList<UsuarioCurso> filter(Dictionary<string, object> parametros)
        {
            //armamos una lista vacia
            List<UsuarioCurso> listadoUsuarioCurso = new List<UsuarioCurso>();

            String consulta = string.Concat("SELECT C.id_usuario, C.usuario, C.email, C.password, C.id_perfil, D.nombre as nombre_perfil, ",
                                    "B.id_curso, B.nombre as nombre_curso, B.descripcion, B.fecha_vigencia, B.id_categoria, E.nombre as nombre_categoria, E.descripcion as desc_cat, ",
                                    "A.puntuacion, A.observaciones, A.fecha_inicio, A.fecha_fin ",
                                    "FROM UsuariosCurso A INNER JOIN Cursos B on A.id_curso = B.id_curso INNER JOIN Usuarios C on A.id_usuario = C.id_usuario ",
                                    "INNER JOIN Perfiles D on C.id_perfil = D.id_perfil ",
                                    "INNER JOIN Categorias E on E.id_categoria = B.id_categoria WHERE 1=1");


            if (parametros.ContainsKey("nombreUsuario"))
            {
                consulta += "AND (C.usuario LIKE '%' + @nombreUsuario + '%')";
            }

            if (parametros.ContainsKey("idCurso"))
            {
                consulta += "AND (B.id_curso = @idCurso)";
            }

            var resultado = DataManager.GetInstance().ConsultaSQL(consulta, parametros);

            foreach (DataRow row in resultado.Rows)
            {
                listadoUsuarioCurso.Add(MappingUsuarioCurso(row));
            }

            return listadoUsuarioCurso;

        }

        private UsuarioCurso MappingUsuarioCurso(DataRow row)
        {
            UsuarioCurso oUsuarioCurso = new UsuarioCurso
            {
                Usuario = new Usuario
                {
                    IdUsuario = Convert.ToInt32(row["id_usuario"].ToString()),
                    NombreUsuario = row["usuario"].ToString(),
                    Email = row["email"].ToString(),
                    Password = row["password"].ToString(),
                    Perfil = new Perfil
                    {
                        IdPerfil = Convert.ToInt32(row["id_perfil"].ToString()),
                        Nombre = row["nombre_perfil"].ToString(),
                    }
                },
                Curso = new Curso
                {
                    IdCurso = Convert.ToInt32(row["id_curso"].ToString()),
                    NombreCurso = row["nombre_curso"].ToString(),
                    Descripcion = row["descripcion"].ToString(),
                    FechaVigencia = Convert.ToDateTime(row["fecha_vigencia"].ToString()),
                    Categoria = new Categoria
                    {
                        id_categoria = Convert.ToInt32(row["id_categoria"].ToString()),
                        nombre = row["nombre_categoria"].ToString(),
                        descripcion = row["desc_cat"].ToString()
                    }
                },

                Puntuacion = (float)Convert.ToDouble(row["puntuacion"].ToString()),
                Observaciones = row["observaciones"].ToString(),
                FechaInicio = Convert.ToDateTime(row["fecha_inicio"].ToString()),
                FechaFin = Convert.ToDateTime(row["fecha_fin"].ToString()),
                avances = new List<Avance>()
            };

            return oUsuarioCurso;
        }

        public bool save(UsuarioCurso usuarioCurso)
        {
            SqlTransaction transaccion = null;
            SqlConnection cnn = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = BugTracker; Integrated Security = True");

            bool flag = true;

            try
            {
                cnn.Open();
                transaccion = cnn.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand("INSERT INTO UsuariosCurso (id_usuario, id_curso, puntuacion, observaciones, fecha_inicio, fecha_fin) Values(@id_usuario, @id_curso, @puntuacion, @observaciones, @fecha_inicio, @fecha_fin)", cnn, transaccion);
                cmdMaestro.Parameters.AddWithValue("@id_usuario", usuarioCurso.Usuario.IdUsuario);
                cmdMaestro.Parameters.AddWithValue("@id_curso", usuarioCurso.Curso.IdCurso);
                cmdMaestro.Parameters.AddWithValue("@puntuacion", usuarioCurso.Puntuacion);
                cmdMaestro.Parameters.AddWithValue("@observaciones", usuarioCurso.Observaciones);
                cmdMaestro.Parameters.AddWithValue("@fecha_inicio", usuarioCurso.FechaInicio);
                cmdMaestro.Parameters.AddWithValue("@fecha_fin", usuarioCurso.FechaFin);

                cmdMaestro.ExecuteNonQuery();

                foreach (Avance av in usuarioCurso.avances)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO UsuariosCursoAvance (id_usuario, id_curso, inicio, fin, porc_avance) VALUES (@id_usuario, @id_curso, @inicio, @fin, @porc_avance)", cnn, transaccion);

                    cmd.Transaction = transaccion;
                    cmd.Parameters.AddWithValue("@id_usuario", usuarioCurso.Usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@id_curso", usuarioCurso.Curso.IdCurso);
                    cmd.Parameters.AddWithValue("@inicio", av.Inicio);
                    cmd.Parameters.AddWithValue("@fin", av.Fin);
                    cmd.Parameters.AddWithValue("@porc_avance", av.Porcentaje);
                    cmd.ExecuteNonQuery();
                }

                transaccion.Commit();

            }
            catch(SqlException)
            {
                transaccion.Rollback();
                flag = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }

            return flag;
        }
    }
}
