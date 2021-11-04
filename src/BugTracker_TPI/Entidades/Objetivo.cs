using System;
using System.Collections.Generic;
using System.Text;

namespace BugTracker_TPI.Entidades
{
    class Objetivo
    {
        public int IdObjetivo { get; set; }
        public string NombreCorto { get; set; }
        public string NombreLargo { get; set; }
        public string Borrado { get; set; }

        public override string ToString()
        {
            //Aqui tengo que retornar NombreCorto?? 
            return NombreCorto;
        }
    }
}
