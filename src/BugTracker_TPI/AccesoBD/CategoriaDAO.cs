using System;
using System.Collections.Generic;
using System.Text;
using BugTracker_TPI.Entidades;
using System.Data;

namespace BugTracker_TPI.AccesoBD
{
    class CategoriaDAO
    {
        public IList<Categoria> obtenerCategorias()
        {
            List<Categoria> listadoCategoria = new List<Categoria>();

            var strSql = "SELECT * FROM Categorias where borrado=0";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoCategoria.Add(MappingCategoria(row));
            }

            return listadoCategoria;
        }

        private Categoria MappingCategoria(DataRow row)
        {
            Categoria oCategoria = new Categoria
            {
                id_categoria = Convert.ToChar(row["id_categoria"].ToString()),
                nombre = row["nombre"].ToString(),
                descripcion = row["descripcion"].ToString(),

            };
            return oCategoria;
        }






    }
}
