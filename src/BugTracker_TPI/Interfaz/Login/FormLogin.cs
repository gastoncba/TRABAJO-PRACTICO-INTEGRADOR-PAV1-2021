using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracker_TPI.Negocio;
using BugTracker_TPI.Interfaz;


namespace BugTracker_TPI
{
    public partial class FormLogin : Form
    {
        //atributo usuarioService para lo logica de los usuarios
        private readonly UsuarioService usuarioService;
        
        

        //atributo usuario logueado actual 
        public static string UsuarioLogueado { get; internal set; }
       

        public FormLogin()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validamos que se ingrese el nombre de un usuario
            if ((txtUsuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Validamos que se haya ingresado la contraseña 
            if ((txtPassword.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //despues validamos que se haya ingresado usuario y password valida
            var usr = usuarioService.ValidarUsuario(txtUsuario.Text, txtPassword.Text); 
            if (usr != null)
            {
                // Login OK
                UsuarioLogueado = usr.NombreUsuario;

                //si esta todo OK, lo que se hace cerrar el login 
                this.Hide();
                PantallaPrincipal pantalla = new PantallaPrincipal(UsuarioLogueado);

                pantalla.Show();


            }
            else
            {
                //Limpiamos el campo password
                txtPassword.Text = "";
                // Enfocamos el cursor en el campo password para que el usuario complete sus datos.
                txtPassword.Focus();
                //Mostramos un mensaje indicando que el usuario/password es invalido.
                MessageBox.Show("Debe ingresar usuario y/o contraseña válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.CenterToParent(); // para centrar la pantalla del login

        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //aca lo que se hace es basicamente preguntar si se pudo loguear o no
            //if(UsuarioLogueado == null)
            //{
            //    Application.Exit();
            //}
            Application.Exit();


            
        }
    }
}
