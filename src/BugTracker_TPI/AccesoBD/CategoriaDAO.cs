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

        internal IList<Categoria> obtenerCatFilt( Dictionary<string,object> filtro)
        {
            List<Categoria> categoriaFilt = new List<Categoria>();

            string strSql = string.Concat("SELECT c.id_categoria, c.nombre, c.descripcion FROM Categorias c WHERE borrado = 0");

            if(filtro.ContainsKey("id_categoria"))
            {
                strSql += "AND (c.id_categoria = @id_categoria)";
            }

            var resultado = DataManager.GetInstance().ConsultaSQL(strSql, filtro);

            foreach (DataRow row in resultado.Rows)
            {
                categoriaFilt.Add(MappingCategoria(row));
            }

            return categoriaFilt;

        }


        private Categoria MappingCategoria(DataRow row)
        {
            Categoria oCategoria = new Categoria
            {
                id_categoria = Convert.ToInt32(row["id_categoria"].ToString()),
                nombre = row["nombre"].ToString(),
                descripcion = row["descripcion"].ToString(),

            };
            return oCategoria;
        }






    }
}
