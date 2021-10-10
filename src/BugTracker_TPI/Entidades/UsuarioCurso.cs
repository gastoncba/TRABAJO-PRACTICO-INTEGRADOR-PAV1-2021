using System;
using System.Collections.Generic;
using System.Text;

namespace BugTracker_TPI.Entidades
{
    class UsuarioCurso
    {
        public Usuario Usuario { get; set; }
        public Curso Curso { get; set; }
        public float Puntuacion { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public List<Avance> avances { get; set; }

        public void agregarAvance(Avance nuevoAvance)
        {
            avances.Add(nuevoAvance);
        }
    }

}

