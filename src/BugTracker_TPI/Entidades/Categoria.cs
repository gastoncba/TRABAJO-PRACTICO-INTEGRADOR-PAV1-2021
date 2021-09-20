using System;
using System.Collections.Generic;
using System.Text;

namespace BugTracker_TPI.Entidades
{
    class Categoria
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }

        //aca sobrescribimos el metodo toString() heredado de Object 
        //para que nos devuelva el nombre de la categoria
        public override string ToString()
        {
            return NombreCategoria;
        }
    }
}
