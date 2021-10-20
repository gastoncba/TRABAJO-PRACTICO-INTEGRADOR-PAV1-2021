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

            if(filtro.ContainsKey("nombre"))
            {
                strSql += "AND (c.nombre LIKE '%' + @nombre + '%')";
            }

            var resultado = DataManager.GetInstance().ConsultaSQL(strSql, filtro);

            foreach (DataRow row in resultado.Rows)
            {
                categoriaFilt.Add(MappingCategoria(row));
            }

            return categoriaFilt;

        }

        internal bool eliminarCategoria(Categoria categoriaSelected)
        {
           string strSql = "UPDATE Categorias SET borrado = 1 WHERE id_categoria = @id_categoria";
            var parametros = new Dictionary<string, object>();
           parametros.Add("id_categoria", categoriaSelected.id_categoria);

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSQL(strSql, parametros) == 1);

        }

        internal bool actualizarCategoria(Categoria categoriaSelected)
        {
            string strSql = "UPDATE Categorias SET nombre = @nombre, descripcion = @descripcion WHERE id_categoria = @id_categoria";
            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", categoriaSelected.nombre);
            parametros.Add("descripcion", categoriaSelected.descripcion);
            parametros.Add("id_categoria", categoriaSelected.id_categoria);

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSQL(strSql, parametros) == 1);

        }

        internal Categoria obtenerCategoria(string nombreCategoria)
        {
            String strSql = string.Concat("SELECT id_categoria, nombre, descripcion FROM Categorias WHERE nombre = @nombre");
            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", nombreCategoria);
            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DataManager.GetInstance().ConsultaSQL(strSql, parametros);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return MappingCategoria(resultado.Rows[0]);
            }

            return null;
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

        internal bool crearCategoria(Categoria categoria)
        {
            string strSql = "INSERT INTO Categorias ( nombre, descripcion, borrado) " +
                            "VALUES (@nombre ,@descripcion, 0)";

            var parametros = new Dictionary<string, object>();
            ;
            parametros.Add("nombre", categoria.nombre);
            parametros.Add("descripcion", categoria.descripcion);

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSQL(strSql, parametros) == 1);

        }






    }
}
