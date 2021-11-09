using System;
using System.Collections.Generic;
using System.Text;

namespace BugTracker_TPI.Entidades
{
    class Avance
    {
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public int Porcentaje { get; set; }
        public bool Verificado {get; set;}
    }
}
