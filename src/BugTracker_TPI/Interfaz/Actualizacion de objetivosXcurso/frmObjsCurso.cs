using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BugTracker_TPI.Negocio;
using BugTracker_TPI.Entidades;
using BugTracker_TPI.BusinessLayer;

namespace BugTracker_TPI.Interfaz.Actualizacion_de_objetivosXcurso
{
    public partial class frmObjsCurso : Form
    {
        private readonly CursoService cursoService;
        private readonly ObjetivoService objetivoService;
        private readonly ObjetivosCursosService objetivosCursosService;
        
        
    
    

        //cargamos la grilla
        
        public frmObjsCurso()
        {
            InitializeComponent();
            cursoService = new CursoService();
            objetivoService = new ObjetivoService();
            objetivosCursosService = new ObjetivosCursosService();
            cargarDataGridView();

        }
        
        private void frmObjsCurso_Load(object sender, EventArgs e)
        {
            LlenarCombo(cmb_Curso, cursoService.mostrarTodos(), "NombreCurso", "IdCurso");
            grdObjsCurso.Update();
            grdObjsCurso.Refresh();
            

        }
        public void refreshList()
        {
            
            grdObjsCurso.Update();
            grdObjsCurso.Refresh();


        }

        //inicializamos las clases de servicio o gestoras
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
        private void cargarDataGridView()
        {
            // declaramos la cant de columnas de la tabla.
            grdObjsCurso.ColumnCount = 2;
            grdObjsCurso.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            grdObjsCurso.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            grdObjsCurso.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            //tener en cuenta que el nombre de DataPropertyName tiene que ser el mismo de la clase que se 
            //encuentra en la capa "Entidad"

            grdObjsCurso.Columns[0].Name = "Curso";
            grdObjsCurso.Columns[0].DataPropertyName = "Cursos";
            
            grdObjsCurso.Columns[1].Name = "Objetivo del curso";
            grdObjsCurso.Columns[1].DataPropertyName = "Objetivos";

            
            //Cambia el tamaño de la altura de los ancabezados de columna

            grdObjsCurso.AutoResizeColumnHeadersHeight();

            // ajustar el contenio de las celdas que no sean encabezado
            // cambia el tamaño de todas las alturas de fila

            grdObjsCurso.AutoResizeColumns(DataGridViewAutoSizeColumnsMo‌​de.AllCells);
        }

        public void btnConsultar_Click(object sender, EventArgs e)
        {
            var parametros = new Dictionary<string, object>();
            

            if (!string.IsNullOrEmpty(cmb_Curso.Text))
            {
                parametros.Add("idCurso", cmb_Curso.SelectedValue);
            }

            grdObjsCurso.Update();
            grdObjsCurso.Refresh();
            IList<ObjetivosCursos> cursosData = objetivosCursosService.filtrar(parametros);
            grdObjsCurso.DataSource = cursosData;
            //var filtros = new Dictionary<string, object>();

            }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cmb_Curso.Text))
            {
                
                MessageBox.Show("Seleccione un Curso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                
            }
            int sel = (int)cmb_Curso.SelectedValue;
            frmActObjXCurso agregarObjCurso = new frmActObjXCurso(sel);
           // agregarObjCurso.cmbCursos.Text = cmb_Curso.Text;
            agregarObjCurso.ShowDialog();
            btnConsultar_Click(sender, e);
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ObjetivosCursos objetivoCursoSelected = (ObjetivosCursos)grdObjsCurso.CurrentRow.DataBoundItem;

            if (string.IsNullOrEmpty(cmb_Curso.Text))
            {

                MessageBox.Show("Seleccione un Curso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            int sel = (int)cmb_Curso.SelectedValue;
            
            frmObjCursoME eliminarObjCurso = new frmObjCursoME(sel);
            //cargar el formulario
            eliminarObjCurso.InitializeForm(frmObjCursoME.FormMode.eliminar, objetivoCursoSelected);
            eliminarObjCurso.ShowDialog();
            //esto es para que se actualice la grilla
            btnConsultar_Click(sender, e);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
           
            //para obtener la categoria que selecciono en la grilla y modificarla:
            ObjetivosCursos objetivoCursoSelected = (ObjetivosCursos)grdObjsCurso.CurrentRow.DataBoundItem;

            if (string.IsNullOrEmpty(cmb_Curso.Text))
            {

                MessageBox.Show("Seleccione un Curso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            int sel = (int)cmb_Curso.SelectedValue;
            frmObjCursoME eliminarObjCurso = new frmObjCursoME(sel);
            //cargar el formulario
            eliminarObjCurso.InitializeForm(frmObjCursoME.FormMode.actualizar,objetivoCursoSelected);
            

            eliminarObjCurso.ShowDialog();


            //esto es para que se actualice la grilla
            btnConsultar_Click(sender, e);
        }
    }
    }

