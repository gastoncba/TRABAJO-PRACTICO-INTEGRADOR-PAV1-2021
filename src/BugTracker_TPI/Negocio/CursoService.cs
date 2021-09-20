using System;
using System.Collections.Generic;
using System.Text;
using BugTracker_TPI.AccesoBD;
using BugTracker_TPI.Entidades;

namespace BugTracker_TPI.Negocio
{
    class CursoService
    {
        private CursoDao cursoDao;

        public CursoService()
        {
            cursoDao = new CursoDao();
        }

        public IList<Curso> obtenerTodos()
        {
            return cursoDao.getAll();
        }

        public IList<Curso> filtrar(Dictionary<string, object> parametros)
        {
            return cursoDao.filter(parametros);
        }
    }

}
