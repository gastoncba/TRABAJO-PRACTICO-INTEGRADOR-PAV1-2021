using BugTracker_TPI.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BugTracker_TPI.AccesoBD
{
    class ObjetivoDao
    {

        public IList<Objetivo> filter(Dictionary<string, object> parametros, bool incluirBorrados = false)
        {
            List<Objetivo> listaObjetivos = new List<Objetivo>();

            String consulta = string.Concat("SELECT O.id_objetivo, O.nombre_corto, O.nombre_largo, O.borrado FROM Objetivos O ");

            if (incluirBorrados)
            {
                consulta += "WHERE O.borrado = 0 OR O.borrado = 1 ";
            } else
            {
                consulta += "WHERE O.borrado = 0 ";
            }

            if (parametros.ContainsKey("idObjetivo"))
            {
                consulta += "AND O.id_objetivo = @idObjetivo ";
            }
            if (parametros.ContainsKey("nombreCorto"))
            {
                consulta += "AND O.nombre_corto LIKE '%' + @nombreCorto  + '%' ";
            }
            if (parametros.ContainsKey("nombreLargo"))
            {
                consulta += "AND O.nombre_largo LIKE '%' + @nombreLargo  + '%'  ";
            }

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(consulta, parametros);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listaObjetivos.Add(ObjectMapping(row));
            }

            return listaObjetivos;
        }

        public Objetivo ObjectMapping(DataRow row)
        {
            string disponible = "si";

            if (row["borrado"].ToString() == "True")
            {
                disponible = "no";
            }

            Objetivo oObjetivo = new Objetivo
            {
                IdObjetivo = Convert.ToInt32(row["id_objetivo"].ToString()),
                NombreCorto = row["nombre_corto"].ToString(),
                NombreLargo = row["nombre_largo"].ToString(),
                Borrado = disponible
            };

            return oObjetivo;
        }

        public bool create(Objetivo objetivo)
        {
            String sentencia_sql = " INSERT INTO Objetivos (nombre_corto, nombre_largo, borrado) " +
                " VALUES (@nombre_corto, @nombre_largo, 0) ";

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre_corto", objetivo.NombreCorto);
            parametros.Add("nombre_largo", objetivo.NombreLargo);
      

            return (DataManager.GetInstance().EjecutarSQL(sentencia_sql, parametros) == 1);

        }

        
        public bool update(Objetivo objetivo)
        {

            String sentencia_sql = string.Concat("UPDATE Objetivos ",
                                                 "SET ", 
                                                 "nombre_corto = @nombre_corto, ", 
                                                 "nombre_largo = @nombre_largo ",
                                                 "WHERE id_objetivo = @id_objetivo"); 

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_objetivo", objetivo.IdObjetivo);
            parametros.Add("nombre_corto", objetivo.NombreCorto);
            parametros.Add("nombre_largo", objetivo.NombreLargo);

            return (DataManager.GetInstance().EjecutarSQL(sentencia_sql, parametros) == 1);
        }


        public bool delete(Objetivo objetivo)
        {
            String sentencia_sql = " UPDATE Objetivos SET borrado = 1 WHERE id_objetivo = @id_objetivo";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_objetivo", objetivo.IdObjetivo);

            return (DataManager.GetInstance().EjecutarSQL(sentencia_sql, parametros) == 1);
        }

        public IList<Objetivo2> obtenerObjetivos()
        {
            List<Objetivo2> listadoObjetivos = new List<Objetivo2>();

            var strSql = "SELECT * FROM Objetivos where borrado=0";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoObjetivos.Add(ObjectMapping2(row));
            }

            return listadoObjetivos;
        }


        public Objetivo2 ObjectMapping2(DataRow row)
        {


            Objetivo2 oObjetivo = new Objetivo2
            {
                id_objetivo = Convert.ToInt32(row["id_objetivo"].ToString()),
                nombre_corto = row["nombre_corto"].ToString(),


            };
            return oObjetivo;
        }

    }
}
