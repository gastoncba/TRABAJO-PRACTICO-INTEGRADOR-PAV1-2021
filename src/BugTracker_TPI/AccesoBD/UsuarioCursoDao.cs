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
                                    "INNER JOIN Categorias E on E.id_categoria = B.id_categoria WHERE 1=1 AND B.borrado = 0");


            if (parametros.ContainsKey("nombreUsuario"))
            {
                consulta += " AND (C.usuario LIKE '%' + @nombreUsuario + '%')";
            }

            if (parametros.ContainsKey("idCurso"))
            {
                consulta += " AND (B.id_curso = @idCurso)";
            }

            consulta += " order by fecha_inicio";

            var cursados = DataManager.GetInstance().ConsultaSQL(consulta, parametros);

            foreach (DataRow row in cursados.Rows)
            {
                listadoUsuarioCurso.Add(MappingUsuarioCurso(row));
            }

            return listadoUsuarioCurso;

        }

        private IList<Avance> getAvances(Dictionary<string, object> datos)
        {
            //armamos un lista vacia de los avances 
            List<Avance> listaAvances = new List<Avance>();

            String consulta = string.Concat("SELECT inicio, fin, porc_avance FROM UsuariosCursoAvance WHERE 1=1");

            if(datos.ContainsKey("IdCurso"))
            {
                consulta += " AND id_curso = @IdCurso";
            }

            if(datos.ContainsKey("IdUsuario"))
            {
                consulta += " AND id_usuario = @IdUsuario";
            }
            
            //aca hacemos otra consulta pero nos obtiene los avances de los cursados antes consultados
            var avancesDetails = DataManager.GetInstance().ConsultaSQL(consulta, datos);

            foreach (DataRow row in avancesDetails.Rows)
            {
                listaAvances.Add(MappingAvance(row));
            }

            return listaAvances;
        }

        private Avance MappingAvance(DataRow row)
        {
            Avance avance = new Avance();
            avance.Inicio = Convert.ToDateTime(row["inicio"].ToString());
            avance.Fin = Convert.ToDateTime(row["fin"].ToString());
            avance.Porcentaje = Convert.ToInt32(row["porc_avance"].ToString());

            return avance;
        }

        private UsuarioCurso MappingUsuarioCurso(DataRow row)
        {
            //definimos un diccionario
            Dictionary<string, object> datosCursado = new Dictionary<string, object>();

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
                    },
                    Disponible = "si",
                },

                Puntuacion = Convert.ToInt32(row["puntuacion"].ToString()),
                Observaciones = row["observaciones"].ToString(),
                FechaInicio = Convert.ToDateTime(row["fecha_inicio"].ToString()),
                FechaFin = Convert.ToDateTime(row["fecha_fin"].ToString()),
            };

            //metemos los datos en el diccionario
            datosCursado.Add("IdCurso", oUsuarioCurso.Curso.IdCurso);
            datosCursado.Add("IdUsuario", oUsuarioCurso.Usuario.IdUsuario);

            //metemos los avances obtenidos ven la list de avances
            oUsuarioCurso.avances = getAvances(datosCursado);

            return oUsuarioCurso;
        }

        public bool add(UsuarioCurso usuarioCurso)
        {
            SqlTransaction transaccion = null;
            SqlConnection cnn = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = BugTracker; Integrated Security = True");

            bool flag = true;

            try
            {
                cnn.Open();
                transaccion = cnn.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand("INSERT INTO UsuariosCurso (id_usuario, id_curso, puntuacion, observaciones, fecha_inicio, fecha_fin) VALUES (@id_usuario, @id_curso, @puntuacion, @observaciones, @fecha_inicio, @fecha_fin)", cnn, transaccion);
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

        public bool update(UsuarioCurso usuarioCurso, IList<Avance> eliminados)
        {
            SqlTransaction transaccion = null;
            SqlConnection cnn = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = BugTracker; Integrated Security = True");

            bool flag = true;
            String updateCursada = string.Concat("UPDATE UsuariosCurso SET ",
                                            "puntuacion = @puntuacion, observaciones = @observaciones, ",
                                            "WHERE id_usuario = @id_usuario AND ",
                                            "id_curso = @id_curso");

            try
            {
                cnn.Open();
                transaccion = cnn.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand(updateCursada, cnn, transaccion);

                cmdMaestro.Parameters.AddWithValue("@id_usuario", usuarioCurso.Usuario.IdUsuario);
                cmdMaestro.Parameters.AddWithValue("@id_curso", usuarioCurso.Curso.IdCurso);
                cmdMaestro.Parameters.AddWithValue("@puntuacion", usuarioCurso.Puntuacion);
                cmdMaestro.Parameters.AddWithValue("@observaciones", usuarioCurso.Observaciones);

                foreach(Avance av in usuarioCurso.avances)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM UsuariosCursoAvance where id_usuario = @id_usuario AND id_curso = @id_curso AND inicio = @inicio", cnn, transaccion);
                    cmd.Transaction = transaccion;
                    cmd.Parameters.AddWithValue("@id_usuario", usuarioCurso.Usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@id_curso", usuarioCurso.Curso.IdCurso);
                    cmd.Parameters.AddWithValue("@inicio", av.Inicio);

                    cmd.ExecuteNonQuery();

                    SqlCommand cmd2= new SqlCommand("INSERT INTO UsuariosCursoAvance (id_usuario, id_curso, inicio, fin, porc_avance) VALUES (@id_usuario, @id_curso, @inicio, @fin, @porc_avance)", cnn, transaccion);
                    cmd2.Transaction = transaccion;
                    cmd2.Parameters.AddWithValue("@id_usuario", usuarioCurso.Usuario.IdUsuario);
                    cmd2.Parameters.AddWithValue("@id_curso", usuarioCurso.Curso.IdCurso);
                    cmd2.Parameters.AddWithValue("@inicio", av.Inicio);
                    cmd2.Parameters.AddWithValue("@fin", av.Fin);
                    cmd2.Parameters.AddWithValue("@porc_avance", av.Porcentaje);

                    cmd2.ExecuteNonQuery();
                }

                //verificamos si hay eliminados 
                foreach(Avance del in eliminados)
                {
                    SqlCommand cmd3 = new SqlCommand("DELETE FROM UsuariosCursoAvance WHERE id_usuario = @id_usuario AND id_curso = @id_curso AND inicio = @inicio", cnn, transaccion);
                    cmd3.Transaction = transaccion;
                    cmd3.Parameters.AddWithValue("@id_usuario", usuarioCurso.Usuario.IdUsuario);
                    cmd3.Parameters.AddWithValue("@id_curso", usuarioCurso.Curso.IdCurso);
                    cmd3.Parameters.AddWithValue("@inicio", del.Inicio);

                    cmd3.ExecuteNonQuery();
                }

                transaccion.Commit();

            }
            catch (SqlException e)
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

        public bool delete(UsuarioCurso usuarioCurso)
        {
            SqlTransaction transaccion = null;
            SqlConnection cnn = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = BugTracker; Integrated Security = True");

            bool flag = true;

            try
            {
                cnn.Open();
                transaccion = cnn.BeginTransaction();

                //primero eliminamos los avances
                foreach (Avance av in usuarioCurso.avances)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM UsuariosCursoAvance WHERE id_usuario = @id_usuario AND id_curso = @id_curso AND inicio = @inicio", cnn, transaccion);
                    cmd.Transaction = transaccion;
                    cmd.Parameters.AddWithValue("@id_usuario", usuarioCurso.Usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@id_curso", usuarioCurso.Curso.IdCurso);
                    cmd.Parameters.AddWithValue("@inicio", av.Inicio);
                    cmd.ExecuteNonQuery();
                }

                //despues eliminamos la cursada
                SqlCommand cmdMaestro = new SqlCommand("DELETE FROM UsuariosCurso WHERE id_usuario = @id_usuario and id_curso = @id_curso", cnn, transaccion);
                cmdMaestro.Parameters.AddWithValue("@id_usuario", usuarioCurso.Usuario.IdUsuario);
                cmdMaestro.Parameters.AddWithValue("@id_curso", usuarioCurso.Curso.IdCurso);
                cmdMaestro.ExecuteNonQuery();

                transaccion.Commit();

            }
            catch (SqlException)
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
