﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BugTracker_TPI.Entidades
{
    class Perfil
    {
        public int IdPerfil { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
