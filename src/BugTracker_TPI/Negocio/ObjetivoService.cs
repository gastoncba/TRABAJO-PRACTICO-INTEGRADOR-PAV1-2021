using BugTracker_TPI.AccesoBD;
using BugTracker_TPI.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugTracker_TPI.Negocio
{
    class ObjetivoService
    {
        private ObjetivoDao objetivoDao;
        
        public ObjetivoService()
        {
            objetivoDao = new ObjetivoDao();
        }

        public IList<Objetivo> filtrar(Dictionary<string, object> parametros, bool incluirBorrados = false)
        {
            if (incluirBorrados)
            {
                return objetivoDao.filter(parametros, incluirBorrados);
            }
            else
            {
                return objetivoDao.filter(parametros);
            }
        }
       
    }
}
