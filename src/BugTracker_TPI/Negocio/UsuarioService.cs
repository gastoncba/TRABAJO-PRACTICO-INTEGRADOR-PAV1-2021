using System;
using System.Collections.Generic;
using System.Text;
using BugTracker_TPI.AccesoBD;
using BugTracker_TPI.Entidades;

namespace BugTracker_TPI.Negocio
{
    class UsuarioService
    {
        public UsuarioDao oUsuarioDao;
        public UsuarioService()
        {
            oUsuarioDao = new UsuarioDao();
        }

        public Usuario ValidarUsuario(string usuario, string password)
        {
            var usr = oUsuarioDao.GetUser(usuario);

            if (usr != null && usr.Password.Equals(password))
            {
                return usr;
            }

            return null;
        }
    }
}
