using System;
using System.Collections.Generic;
using System.Text;

namespace BugTracker_TPI.Entidades
{
    class UsuarioCurso
    {
        public Usuario Usuario { get; set; }
        public Curso Curso { get; set; }
        public int Puntuacion { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public IList<Avance> avances { get; set; }

        public void agregarAvance(Avance nuevoAvance)
        {
            avances.Add(nuevoAvance);
        }

        public Avance sacarAvance(DateTime inicio)
        {
            foreach(Avance av in avances)
            {
                if(inicio == av.Inicio)
                {
                    avances.Remove(av);
                    return av;
                }
            }

            return null;
        }
    }

}

