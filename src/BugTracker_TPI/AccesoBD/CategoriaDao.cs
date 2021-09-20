using System;
using System.Collections.Generic;
using System.Text;
using BugTracker_TPI.Entidades;
using System.Data;

namespace BugTracker_TPI.AccesoBD
{
    class CategoriaDao
    {
        //este metodo nos devuelve todas las categorias de la base de datos
        public IList<Categoria> getAll()
        {
            //armamos la lista de las categorias vacia 
            List<Categoria> listadoCategorias = new List<Categoria>();

            //se arma la consulta
            var consulta = "SELECT id_categoria, nombre from Categorias";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(consulta);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoCategorias.Add(ObjectMapping(row));
            }

            return listadoCategorias;
        }

        //este metodo realiza la conversión de una fila de una tabla a un objeto
        private Categoria ObjectMapping(DataRow row)
        {
            Categoria oCategoria = new Categoria
            {
                IdCategoria = Convert.ToInt32(row["id_categoria"].ToString()),
                NombreCategoria = row["nombre"].ToString()
            };

            return oCategoria;
        }

    }
}
