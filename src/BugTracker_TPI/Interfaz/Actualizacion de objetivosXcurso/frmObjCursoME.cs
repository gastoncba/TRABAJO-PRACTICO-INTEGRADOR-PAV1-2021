using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BugTracker_TPI.Entidades;
using BugTracker_TPI.BusinessLayer;
using BugTracker_TPI.Negocio;


namespace BugTracker_TPI.Interfaz.Actualizacion_de_objetivosXcurso
{
    public partial class frmObjCursoME : Form
    {
        public FormMode formMode = FormMode.nuevo;
        private Curso cursoSel;
        private Objetivo2 obj;
        private ObjetivosCursos objCursoSel;

        private readonly ObjetivoService objetivoService;
        private readonly CursoService cursoService;
       
        private readonly ObjetivosCursos objetivosCursos;
        private readonly BindingList<ObjetivosCursos> listaObjetivosCursos;
        private readonly ObjetivosCursosService objetivosCursosService;
        int selectedVal;
        public frmObjCursoME(int value)
        {
            InitializeComponent();
            ObjetivosCursos objCursoSel = new ObjetivosCursos();
            selectedVal = value;
            listaObjetivosCursos = new BindingList<ObjetivosCursos>();
            cursoService = new CursoService();
            objetivoService = new ObjetivoService();
            objetivosCursos = new ObjetivosCursos();
            objetivosCursosService = new ObjetivosCursosService();
        }
        public enum FormMode
        {
            nuevo,
            actualizar,
            eliminar
        }

        public void InitializeForm(FormMode op, ObjetivosCursos objCursoSelected)
        {
            formMode = op;
            objCursoSel = objCursoSelected;
        }

        private void frmObjCursoME_Load(object sender, EventArgs e)
        {
            LlenarCombo(cmb_EliminarCurso, cursoService.obtenerTodas(), "NombreCurso", "IdCurso");
            LlenarCombo(cmb_eliminarObj, objetivoService.obtenerTodas(), "nombre_corto", "id_objetivo");
            this.cmb_EliminarCurso.SelectedValue = selectedVal;
            int index = cmb_eliminarObj.FindStringExact(objCursoSel.Objetivos.nombre_corto.ToString());
            cmb_eliminarObj.SelectedIndex = index;
           
            switch (formMode)
            {
                case FormMode.actualizar:
                    {
                        this.Text = "Modificar objetivo de curso";
                        label3.Text = "Modificar objetivo de curso";
                        cmb_EliminarCurso.Enabled = false;
                        break;
                    }
                case FormMode.eliminar:
                    {
                        this.Text = "Eliminar objetivo de curso";
                        cmb_eliminarObj.Enabled = false;
                        cmb_EliminarCurso.Enabled = false;
                        label3.Text = "Eliminar objetivo de curso";
                        break;
                    }
            }

        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            // Datasource: establece el origen de datos de este objeto.
            cbo.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbo.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cbo.ValueMember = value;
            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbo.SelectedIndex = -1;
        }

        private void btnAceptarBM_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {

                case FormMode.actualizar:
                    {
                        modificarCursado();
                        cerrarFormBM_Click(sender, e);
                        break;
                    }
                case FormMode.eliminar:
                    {
                        eliminarCursado();
                        cerrarFormBM_Click(sender, e);
                        break;
                        
                    }
            }
        }

        private void eliminarCursado()
        {
            objCursoSel.Objetivos = (Objetivo2)cmb_eliminarObj.SelectedItem;
            objCursoSel.Cursos = (Curso)cmb_EliminarCurso.SelectedItem;
            if (objetivosCursosService.eliminarObjCurso(objCursoSel))
            {
                MessageBox.Show("Se ha eliminado el objetivo del curso solicitado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error al intentar eliminar objetivo del curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificarCursado()
        {
            objCursoSel.Objetivos = (Objetivo2)cmb_eliminarObj.SelectedItem;
            objCursoSel.Cursos = (Curso)cmb_EliminarCurso.SelectedItem;
            if (objetivosCursosService.actualizarObjCurso(objCursoSel))
            {
                MessageBox.Show(" Objetivo del curso actualizado con exito", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(" Ya existe un curso asociado al objetivo seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrarFormBM_Click(object sender, EventArgs e)
        {
            frmObjsCurso frmObjsCurso = new frmObjsCurso();
            frmObjsCurso.btnConsultar_Click(sender, e);
            this.Close();

        }
    }
}

