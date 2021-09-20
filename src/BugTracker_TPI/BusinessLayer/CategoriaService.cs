using System;
using System.Collections.Generic;
using System.Text;
using BugTracker_TPI.AccesoBD;
using BugTracker_TPI.Entidades;
namespace BugTracker_TPI.BusinessLayer
{
    class CategoriaService
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
    }
}
