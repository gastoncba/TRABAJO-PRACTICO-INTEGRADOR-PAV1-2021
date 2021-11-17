using System;
using System.Collections.Generic;
using System.Text;

namespace BugTracker_TPI.Entidades
{
    class DetalleAvance
    {
        public int id_objetivo { get; set; }
        public int id_curso { get; set; }
        
        


        public Curso Cursos { get; set; }
        public Objetivo2 Objetivos { get; set; }

        public string nombreCurso
        {
            get
            {
                return Cursos.NombreCurso;
            }
        }
        public string nombreObjetivo
        {
            get
            {
                return Objetivos.nombre_corto;
            }
        }
    }
}
