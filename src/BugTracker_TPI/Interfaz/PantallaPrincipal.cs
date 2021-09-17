using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BugTracker_TPI.Interfaz.Cursos;

namespace BugTracker_TPI.Interfaz
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent(); 

        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            FormLogin login = new FormLogin();
            login.ShowDialog();
     
        }

        private void PantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta;
            rpta = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.No)
                e.Cancel = true;
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cuando se hace click en la pestaña de cursos de debe abrir la pantalla de abmc de los cursos
            //para ello se crea una nueva instancia del form de cursos
            FormCursos formCursos = new FormCursos();
            formCursos.ShowDialog();
        }

    }
}
