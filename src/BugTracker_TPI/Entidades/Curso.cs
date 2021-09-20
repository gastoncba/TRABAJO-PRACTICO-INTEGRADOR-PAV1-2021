using System;
using System.Collections.Generic;
using System.Text;

namespace BugTracker_TPI.Entidades
{
    class Curso
    {
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaVigencia { get; set; }
        public Categoria Categoria { get; set; }

        public override string ToString()
        {
            return NombreCurso;
        }

    }
}
