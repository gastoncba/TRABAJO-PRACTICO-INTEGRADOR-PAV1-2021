using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BugTracker_TPI.Interfaz.Cursos;
using BugTracker_TPI.Entidades;

namespace BugTracker_TPI.Interfaz
{
    public partial class PantallaPrincipal : Form
    {
       
        public PantallaPrincipal(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario.ToString();

        }

       

        private void PantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.Yes)
            {
                e.Cancel = false;
                
            }
            Application.Exit();
            
            
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cuando se hace click en la pestaña de cursos de debe abrir la pantalla de abmc de los cursos
            //para ello se crea una nueva instancia del form de cursos
            FormCursos formCursos = new FormCursos();
            formCursos.ShowDialog();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            FormCursos formCursos = new FormCursos();
            formCursos.ShowDialog();
        }
    }
}
