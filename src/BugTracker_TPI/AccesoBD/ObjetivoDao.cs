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

            String consulta = string.Concat("SELECT O.id_objetivo, O.nombre_corto,O.nombre_largo,O.borrado FROM Objetivos O ");

            if (incluirBorrados)
            {
                consulta += "WHERE O.borrado = 0 OR O.borrado = 1";
            } else
            {
                consulta += "WHERE O.borrado = 0";
            }

            if (parametros.ContainsKey("idObjetivo"))
            {
                consulta += "AND O.id_objetivo = @idObjetivo";
            }
            if (parametros.ContainsKey("nombreCorto"))
            {
                consulta += "AND O.nombre_corto = @nombreCorto";
            }
            if (parametros.ContainsKey("nombreLargo"))
            {
                consulta += "AND O.nombre_largo = @nombreLargo";
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
            

    }
}
