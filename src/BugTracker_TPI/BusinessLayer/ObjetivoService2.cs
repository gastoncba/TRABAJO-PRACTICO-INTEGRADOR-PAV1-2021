using System;
using System.Collections.Generic;
using System.Text;
using BugTracker_TPI.AccesoBD;
using BugTracker_TPI.Entidades;

namespace BugTracker_TPI.BusinessLayer
{
    class ObjetivoService2
    {
        public ObjetivoDao2 objetivoDao2;

        public ObjetivoService2()
        {
            objetivoDao2 = new ObjetivoDao2();
        }

        public IList<Objetivo2> obtenerTodas()
        {
            return objetivoDao2.obtenerObjetivos();
        }

        
    }
}
