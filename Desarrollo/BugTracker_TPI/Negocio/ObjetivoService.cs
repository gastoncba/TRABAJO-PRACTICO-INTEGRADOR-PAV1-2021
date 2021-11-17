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

        public bool crearObjetivo(Objetivo objetivo)
        {
            return objetivoDao.create(objetivo);
        }

        public bool actualizarObjetivo(Objetivo objetivo)
        {
            return objetivoDao.update(objetivo);
        }

        
        public bool eliminarObjetivo(Objetivo objetivo)
        {
            return objetivoDao.delete(objetivo);
        }

        public IList<Objetivo2> obtenerTodas()
        {
            return objetivoDao.obtenerObjetivos();
        }

        public bool habilitar(Objetivo objetivo)
        {
            return objetivoDao.habilitar(objetivo);
        }
    }
}
