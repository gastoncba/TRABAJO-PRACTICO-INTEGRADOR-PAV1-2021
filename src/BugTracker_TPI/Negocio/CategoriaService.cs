using System;
using System.Collections.Generic;
using System.Text;
using BugTracker_TPI.AccesoBD;
using BugTracker_TPI.Entidades;

namespace BugTracker_TPI.Negocio
{
    class CategoriaService
    {
        private CategoriaDao categoriaDao;

        public CategoriaService()
        {
            categoriaDao = new CategoriaDao();
        }

        public IList<Categoria> obtenerTodos()
        {
            return categoriaDao.getAll();
        }
    }

}
