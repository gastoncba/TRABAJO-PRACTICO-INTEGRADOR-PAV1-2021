using System;
using System.Collections.Generic;
using System.Text;

namespace BugTracker_TPI.Entidades
{

    public class Categoria
    {
        public int id_categoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string disponible { get; set; }

        public override string ToString()
        {
            return nombre;
        }

    }
}
