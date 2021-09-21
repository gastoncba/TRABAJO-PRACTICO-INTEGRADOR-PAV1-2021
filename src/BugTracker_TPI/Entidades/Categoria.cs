using System;
using System.Collections.Generic;
using System.Text;

namespace BugTracker_TPI.Entidades
{
<<<<<<< HEAD
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
=======
    public class Categoria
    {
        public int id_categoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        //public bool borrado { get; set; }

        public override string ToString()
        {
            return nombre;
        }

>>>>>>> 4586e5b99d81652584288ecf9e7af4402dd217a5
    }
}
