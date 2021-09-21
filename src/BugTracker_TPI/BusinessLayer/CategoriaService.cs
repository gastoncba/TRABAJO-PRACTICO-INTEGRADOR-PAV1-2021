using System;
using System.Collections.Generic;
using System.Text;
using BugTracker_TPI.AccesoBD;
using BugTracker_TPI.Entidades;
namespace BugTracker_TPI.BusinessLayer
{
    public class CategoriaService
    {
        private CategoriaDAO oCategoriaDao;

        public CategoriaService()
        {
            oCategoriaDao = new CategoriaDAO();
        }

        public IList<Categoria> obtenerTodas()
        {
            return oCategoriaDao.obtenerCategorias();
        }

        public IList<Categoria> obtenerConFiltros(Dictionary<string,object> filtro)
        {
            return oCategoriaDao.obtenerCatFilt(filtro);
        }

        public object obtenerCategoria (string categoria)
        {
            return oCategoriaDao.obtenerCategoria(categoria);
        }

        internal bool crearCategoria(Categoria oCategoria)
        {
            return oCategoriaDao.crearCategoria(oCategoria);
        }

        internal bool actualizarCategoria(Categoria categoriaSelected)
        {
            return oCategoriaDao.actualizarCategoria(categoriaSelected);
        }

        internal bool eliminarCategoria(Categoria categoriaSelected)
        {
            return oCategoriaDao.eliminarCategoria(categoriaSelected);
        }
    }
}
