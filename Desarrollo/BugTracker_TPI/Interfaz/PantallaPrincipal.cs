using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BugTracker_TPI.Interfaz.Cursos;
using BugTracker_TPI.Entidades;
using BugTracker_TPI.Interfaz.Categorias;
using BugTracker_TPI.Interfaz.CursadoAvances;
using BugTracker_TPI.Interfaz.Objetivos;
using BugTracker_TPI.Interfaz.Reportes;
using BugTracker_TPI.Interfaz.Actualizacion_de_objetivosXcurso;

namespace BugTracker_TPI.Interfaz
{
    public partial class PantallaPrincipal : Form
    {
        public bool exit = false;

        public PantallaPrincipal(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario.ToString();

        }
        public PantallaPrincipal()
        {
            InitializeComponent();

        }

        private void PantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit == false)
            {
                DialogResult rpta = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.Yes)
                {
                    exit = true;
                    e.Cancel = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            
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

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias formCategorias = new frmCategorias();
            formCategorias.ShowDialog();
            
        }

        private void btnObjCurso_Click(object sender, EventArgs e)
        {
            frmObjsCurso objsCurso = new frmObjsCurso();
            objsCurso.ShowDialog();

            

        }

        private void btnActualizacionCursados_Click(object sender, EventArgs e)
        {
            frmActualizacionCursado ofrmActualizacionCursado = new frmActualizacionCursado();
            ofrmActualizacionCursado.ShowDialog();
        }

        private void btnObjetivos_Click(object sender, EventArgs e)
        {
            FormObjetivos formObjetivos = new FormObjetivos();
            formObjetivos.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            PantallaReportes reports = new PantallaReportes();
            reports.ShowDialog();
        }

    }
}
