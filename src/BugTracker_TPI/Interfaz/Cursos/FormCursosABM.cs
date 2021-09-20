using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BugTracker_TPI.Negocio;

namespace BugTracker_TPI.Interfaz.Cursos
{
    public partial class FormCursosABM : Form
    {
        private readonly CategoriaService categoriaService;
        private readonly CursoService cursoService;
        public FormCursosABM()
        {
            InitializeComponent();
            categoriaService = new CategoriaService();
            cursoService = new CursoService();
        }
    }
}
