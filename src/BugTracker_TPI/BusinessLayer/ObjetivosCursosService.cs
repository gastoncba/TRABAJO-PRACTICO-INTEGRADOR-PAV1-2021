using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BugTracker_TPI.AccesoBD;
using BugTracker_TPI.Entidades;

namespace BugTracker_TPI.BusinessLayer
{
    class ObjetivosCursosService

    {
        private ObjetivoCursosDao objetivoCursosDao;
        public ObjetivosCursosService()
        {
            objetivoCursosDao = new ObjetivoCursosDao();
        }
        

        internal bool guardar(ObjetivosCursos objetivosCursos)
        {
            return objetivoCursosDao.Create(objetivosCursos);
        }
        public IList<ObjetivosCursos> filtrar(Dictionary<string, object> parametros)
        {
            return objetivoCursosDao.filter(parametros);
        }

        public bool eliminarObjCurso (ObjetivosCursos objCurslSel)
        {
            return objetivoCursosDao.eliminarObjCur(objCurslSel);
        }
        internal bool actualizarObjCurso(ObjetivosCursos objCursoSel)
        {
            return objetivoCursosDao.actualizarObjCur(objCursoSel);
        }
    }
}
