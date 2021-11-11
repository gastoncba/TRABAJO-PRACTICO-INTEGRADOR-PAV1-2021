using System;
using System.Collections.Generic;
using System.Text;
using BugTracker_TPI.Entidades;
using System.Data;

namespace BugTracker_TPI.AccesoBD
{
    class ObjetivoDao2
    {


        public IList<Objetivo2> obtenerObjetivos()
        {
            List<Objetivo2> listadoObjetivos = new List<Objetivo2>();

            var strSql = "SELECT * FROM Objetivos where borrado=0";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoObjetivos.Add(ObjectMapping(row));
            }

            return listadoObjetivos;
        }


        public Objetivo2 ObjectMapping(DataRow row)
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

