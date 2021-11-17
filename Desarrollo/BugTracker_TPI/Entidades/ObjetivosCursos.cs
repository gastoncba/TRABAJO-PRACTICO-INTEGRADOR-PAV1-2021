using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BugTracker_TPI.Entidades
{
    
   public class ObjetivosCursos
    {

        public int puntos { get; set; }
        public bool borrado { get; set; }

        public Curso Cursos { get; set; }
        public Objetivo2 Objetivos { get; set; }

        public List<ObjetivosCursos> objCursos;

        public ObjetivosCursos()
        {
            objCursos = new List<ObjetivosCursos>();
        }

        //public string nombreCurso
        //{
        //    get
        //    {
        //        return Cursos.NombreCurso;
        //    }
        //}

        //public string nombreObjetivo
        //{
        //    get
        //    {
        //        return Objetivos.nombre_corto;
        //    }
        //}

        public bool validarDatos()
        {
            if (objCursos.Count == 0)
            {
                throw new Exception("Debe ingresar al menos un item de objetivo de curso.");
            }
            return true;
        }
    }
}
