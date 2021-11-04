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

               
                foreach (var item in objetivosCursos.objCursos)
                {
                   // INSERT Detalle
                    SqlCommand insertDetalle = new SqlCommand();
                    insertDetalle.Connection = dbConnection;
                    insertDetalle.CommandType = CommandType.Text;
                    insertDetalle.Transaction = dbTransaction;
                   // Establece la instrucción a ejecutar
                    insertDetalle.CommandText = string.Concat("INSERT INTO [dbo].[ObjetivosCursos] ",
                                            "           ([id_objetivo]   ",
                                            "           ,[id_curso]         ",
                                            "           ,[puntos]       ",
                                            "           ,[borrado])      ",
                                            "     VALUES                 ",
                                            "           (@id_objetivo   ",
                                            "           ,@id_cursp          ",
                                            "           ,@puntos        ",
                                            "           ,@borrado    ");

                    
                    insertDetalle.Parameters.AddWithValue("id_objetivo", objetivosCursos.id_objetivo);
                    insertDetalle.Parameters.AddWithValue("id_curso", objetivosCursos.id_curso);
                   

                    insertDetalle.ExecuteNonQuery();
                }

                dbTransaction.Commit();
            }
            catch (Exception ex)
            {
                dbTransaction.Rollback();
                throw ex;
            }
            return true;
        }
    }
}

