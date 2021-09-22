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

        public IList<Curso> filtrar(Dictionary<string, object> parametros, bool incluirBorrados = false)
        {
            if (incluirBorrados)
            {
                return cursoDao.filter(parametros, incluirBorrados);
            }
            else
            {
                return cursoDao.filter(parametros);
            }
        }

        public bool crearCurso(Curso curso)
        {
            return cursoDao.create(curso);
        }

        public bool actualizarCurso(Curso curso)
        {
            return cursoDao.update(curso);
        }

        public bool eliminarCurso(Curso curso)
        {
            return cursoDao.delete(curso);
        }

        public bool existeCurso(String cursoNombre)
        {
            return cursoDao.exist(cursoNombre);
        }
    }

}
