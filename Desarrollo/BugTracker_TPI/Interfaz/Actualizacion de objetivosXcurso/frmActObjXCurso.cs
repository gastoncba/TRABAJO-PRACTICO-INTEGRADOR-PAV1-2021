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
using BugTracker_TPI.AccesoBD;

namespace BugTracker_TPI.Interfaz.Actualizacion_de_objetivosXcurso
{
    public partial class frmActObjXCurso : Form
    {
        private FormMode formMode = FormMode.nuevo;
        //private readonly Curso curso;
        //private readonly Objetivo2 objetivo;

        private readonly ObjetivoService objetivoService;
        private readonly CursoService cursoService;
        private readonly ObjetivosCursos objetivosCursos;
        private readonly BindingList<ObjetivosCursos> listaObjetivosCursos;
        private readonly ObjetivosCursosService objetivosCursosService;
        int selectedVal;
        
       
        public frmActObjXCurso(int value)
        {
            
            InitializeComponent();
            grdObjCurso.AutoGenerateColumns = false;
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
            eliminar,
            modificar
        }
        
        private void frmActObjXCurso_Load(object sender, EventArgs e)
        {
            InicializarForm();
            
            LlenarCombo(cmbCursos, cursoService.obtenerTodas(), "NombreCurso", "IdCurso");
            LlenarCombo(cmbObjetivos, objetivoService.obtenerTodas(), "nombre_corto", "id_objetivo");
            this.cmbCursos.SelectedValue = selectedVal;

            switch (formMode)
            {
                case FormMode.nuevo:
                {

                        cmbCursos.Enabled = false;
                        //int asd = cmbCursos.SelectedIndex;
                        //MessageBox.Show("valor"+ asd);
                        break;
                }
            }
            grdObjCurso.DataSource = listaObjetivosCursos;
            grdObjCurso.AutoResizeColumns(DataGridViewAutoSizeColumnsMo‌​de.AllCells);
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void InicializarForm()
        {
            agregarObjetivoCurso.Enabled = false;
            grdObjCurso.DataSource = null;
            btnQuitar.Enabled = false;


        }

        private void agregarObjGrid_Click(object sender, EventArgs e)
        {
            
            var curso = (Curso)cmbCursos.SelectedItem;
            var objetivo = (Objetivo2)cmbObjetivos.SelectedItem;
            
            if (cmbCursos.SelectedIndex.Equals(-1) || cmbObjetivos.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Por favor, seleccione un curso y/o un objetivo para el mismo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!existeCursoEnGrd(cmbObjetivos.Text))
                {
                    listaObjetivosCursos.Add(new ObjetivosCursos()
                    {
                        Cursos = curso,
                        Objetivos = objetivo
                    }) ;
                    btnQuitar.Enabled = true;
                    agregarObjetivoCurso.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El objetivo elegido ya se encuentra en la lista, por favor, seleccione otro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private bool existeCursoEnGrd(string text)
        {
            foreach (DataGridViewRow fila in grdObjCurso.Rows)
            {
                Objetivo2 obj = (Objetivo2) fila.Cells["nombre_corto"].Value;
                //if (fila.Cells["nombre_corto"].Value.Equals(text))
                if(obj.nombre_corto == text)
                    return true;
            }
            return false;
        }

     
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            
           if (grdObjCurso.CurrentRow != null)
            {
                var detalleSeleccionado = (ObjetivosCursos)grdObjCurso.CurrentRow.DataBoundItem;
                listaObjetivosCursos.Remove(detalleSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un item del listado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if(grdObjCurso.Rows.Count == 0)
            {
                agregarObjetivoCurso.Enabled = false;
            }
        }

        private void agregarObjetivoCurso_Click(object sender, EventArgs e)
        {
            rellenarLista();

            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        try
                        {
                            Objetivo2 valor = null;
                            if (objetivosCursos.objCursos.Count != 0)
                            {
                                for (int fila = 0; fila < grdObjCurso.Rows.Count ; fila++)
                                {
                                    for (int col = 0; col < grdObjCurso.Rows[fila].Cells.Count; col++)
                                    {
                                         valor = (Objetivo2)grdObjCurso.Rows[fila].Cells[col].Value;


                                        var objetivoCursos = new ObjetivosCursos
                                        {
                                            Cursos = (Curso)cmbCursos.SelectedItem,
                                            Objetivos = valor,
                                        };

                                        objetivosCursosService.guardar(objetivoCursos);
                                    }
                                }

                            }
                            MessageBox.Show("Se guardó correctamente la actualización del objetivo del curso "+cmbCursos.SelectedItem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //grdObjCurso.Refresh();
                            //grdObjCurso.Rows.Clear();
                            this.Close();
                        
                        }
                        

                        catch (Exception)
                        {
                            MessageBox.Show("Uno o varios de los objetivos seleccionados para el curso " + cmbCursos.SelectedItem + " ya existe, por favor, seleccione otro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            grdObjCurso.Refresh();
                            grdObjCurso.Rows.Clear();
                        }
                        break;
                    }

            }
            
        }
        public void rellenarLista()
        {

            foreach (var item in listaObjetivosCursos)
            {
                objetivosCursos.objCursos.Add(item);
            }
        }

        

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            cmbCursos.SelectedIndex = -1;
            cmbObjetivos.SelectedIndex = -1;
        }

        

        private void btnCerrarFormA_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnEliminarTodo_Click_1(object sender, EventArgs e)
        {
            grdObjCurso.Rows.Clear();
            agregarObjetivoCurso.Enabled = false;
        }
    }

    
}
