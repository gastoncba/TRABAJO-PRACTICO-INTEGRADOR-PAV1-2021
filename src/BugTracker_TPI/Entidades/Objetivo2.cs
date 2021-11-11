using System;
using System.Collections.Generic;
using System.Text;

namespace BugTracker_TPI.Entidades
{
    class Objetivo2
    {

        public int id_objetivo { get; set; }
        public string nombre_corto { get; set; }

        public override string ToString()
        {
            return nombre_corto;
        }



    }
}
