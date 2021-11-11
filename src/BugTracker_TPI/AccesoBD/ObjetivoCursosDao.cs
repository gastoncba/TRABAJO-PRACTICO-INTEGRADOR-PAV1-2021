using BugTracker_TPI.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace BugTracker_TPI.AccesoBD
{
    class ObjetivoCursosDao
    {
        public bool Create(ObjetivosCursos objetivosCursos)
        {
            var string_conexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=BugTracker;Integrated Security=true;";

            //Se utiliza para sentencias SQL del tipo “Insert / Update / Delete”
            SqlConnection dbConnection = new SqlConnection();
            SqlTransaction dbTransaction = null;
            try
            {
                dbConnection.ConnectionString = string_conexion;
                dbConnection.Open();
                //Genero la transacción
                dbTransaction = dbConnection.BeginTransaction();

                //INSERT ObjetivoCurso
                SqlCommand insertObjetivoCurso = new SqlCommand();
                insertObjetivoCurso.Connection = dbConnection;
                insertObjetivoCurso.CommandType = CommandType.Text;
                insertObjetivoCurso.Transaction = dbTransaction;
               // Establece la instrucción a ejecutar
                insertObjetivoCurso.CommandText = string.Concat("INSERT INTO [dbo].[ObjetivosCursos] ",
                                            "           ([id_objetivo]   ",
                                            "           ,[id_curso]         ",
                                            "           ,[puntos]       ",
                                            "           ,[borrado])      ",
                                            "     VALUES                 ",
                                            "           (@id_objetivo   ",
                                            "           ,@id_curso          ",
                                            "           ,@puntos        ",
                                            "           ,@borrado)    ");



                //Agregamos los parametros
                insertObjetivoCurso.Parameters.AddWithValue("id_objetivo", objetivosCursos.Objetivos.id_objetivo);
                insertObjetivoCurso.Parameters.AddWithValue("id_curso", objetivosCursos.Cursos.IdCurso);
                insertObjetivoCurso.Parameters.AddWithValue("puntos", objetivosCursos.puntos);
                
                insertObjetivoCurso.Parameters.AddWithValue("borrado", false);

                insertObjetivoCurso.ExecuteNonQuery();

               
                

                dbTransaction.Commit();
            }
            catch (Exception ex)
            {
                dbTransaction.Rollback();
                throw ex;
            }
            return true;
        }

        public bool actualizarObjCur(ObjetivosCursos objCursoSel)
        {

            SqlTransaction transaccion = null;
            SqlConnection cnn = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = BugTracker; Integrated Security = True");
            bool flag = true;

            try
            {
                cnn.Open();
                transaccion = cnn.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand("UPDATE ObjetivosCursos" +
                    " SET id_objetivo = @id_objetivo WHERE id_curso = @id_curso ", cnn, transaccion);
                cmdMaestro.Parameters.AddWithValue("@id_objetivo", objCursoSel.Objetivos.id_objetivo);
                cmdMaestro.Parameters.AddWithValue("@id_curso", objCursoSel.Cursos.IdCurso);
               // cmdMaestro.Parameters.AddWithValue("@puntos", objCursoSel.puntos);
               // cmdMaestro.Parameters.AddWithValue("@borrado", true);
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

        public bool eliminarObjCur(ObjetivosCursos objCursoSel)
        {
            SqlTransaction transaccion = null;
            SqlConnection cnn = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = BugTracker; Integrated Security = True");


            bool flag = true;

            try
            {
                cnn.Open();
                transaccion = cnn.BeginTransaction();


                //despues eliminamos la cursada
                SqlCommand cmdMaestro = new SqlCommand("DELETE FROM ObjetivosCursos WHERE id_objetivo = @id_objetivo and id_curso = @id_curso", cnn, transaccion);
                cmdMaestro.Parameters.AddWithValue("@id_objetivo", objCursoSel.Objetivos.id_objetivo);
                cmdMaestro.Parameters.AddWithValue("@id_curso", objCursoSel.Cursos.IdCurso);
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
    
        public IList<ObjetivosCursos> filter(Dictionary<string, object> parametros)
        {
            //armamos una lista vacia
            List<ObjetivosCursos> listadoUsuarioCurso = new List<ObjetivosCursos>();

            String consulta = string.Concat("SELECT obj.id_objetivo,cur.id_curso,cur.nombre as nombre_curso, obj.nombre_corto as nombre_objetivo FROM ObjetivosCursos" +
                " JOIN Cursos cur on ObjetivosCursos.id_curso = cur.id_curso" +
                                    " JOIN Objetivos obj on ObjetivosCursos.id_objetivo = obj.id_objetivo ");

            if (parametros.ContainsKey("idCurso"))
            {
                consulta += " AND (cur.id_curso = @idCurso)";
            }

            var cursados = DataManager.GetInstance().ConsultaSQL(consulta, parametros);

            foreach (DataRow row in cursados.Rows)
            {
                listadoUsuarioCurso.Add(MappingObjsCurso(row));
            }

            return listadoUsuarioCurso;
        }
        private ObjetivosCursos MappingObjsCurso(DataRow row)
        {
            //definimos un diccionario
            Dictionary<string, object> datosCurso = new Dictionary<string, object>();
            ObjetivosCursos oObjCurso = new ObjetivosCursos
            {

                Cursos = new Curso
                {
                    IdCurso = Convert.ToInt32(row["id_curso"].ToString()),
                    NombreCurso = row["nombre_curso"].ToString(),
                    // Descripcion = row["descripcion"].ToString(),
                    // FechaVigencia = Convert.ToDateTime(row["fecha_vigencia"].ToString()),
                    //Categoria = new Categoria
                    //{
                    //    id_categoria = Convert.ToInt32(row["id_categoria"].ToString()),
                    //    nombre = row["nombre_categoria"].ToString(),
                    //    descripcion = row["desc_cat"].ToString()
                    //},
                    // Disponible = "si",
                },
                Objetivos = new Objetivo2
                {
                    id_objetivo = Convert.ToInt32(row["id_objetivo"].ToString()),
                    nombre_corto = row["nombre_objetivo"].ToString(),
                },

            };
            //metemos los datos en el diccionario
            datosCurso.Add("IdCurso", oObjCurso.Cursos.IdCurso);
            datosCurso.Add("id_objetivo", oObjCurso.Objetivos.id_objetivo);
            datosCurso.Add("nombre_corto", oObjCurso.Objetivos.nombre_corto.ToString());

            return oObjCurso;
        }

    }
}

       


