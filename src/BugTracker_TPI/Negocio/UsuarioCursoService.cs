using System;
using System.Collections.Generic;
using System.Text;
using BugTracker_TPI.AccesoBD;
using BugTracker_TPI.Entidades;

namespace BugTracker_TPI.Negocio
{
    class UsuarioCursoService
    {

        private UsuarioCursoDao usuarioCursoDao;

        public UsuarioCursoService()
        {
            usuarioCursoDao = new UsuarioCursoDao();
        }

        public IList<UsuarioCurso> filtrar(Dictionary<string, object> parametros)
        {
            return usuarioCursoDao.filter(parametros);
        }

        public bool agregar(UsuarioCurso usuarioCurso)
        {
            return usuarioCursoDao.add(usuarioCurso);
        }

        public bool actualizar(UsuarioCurso usuarioCurso, object[] oldKeys, IList<Avance> eliminados)
        {
            return usuarioCursoDao.update(usuarioCurso, oldKeys, eliminados);
        }
    }
}
