using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BugTracker_TPI.BusinessLayer;
using BugTracker_TPI.AccesoBD;

namespace BugTracker_TPI.Interfaz.Categorias
{
    public partial class frmCategorias : Form

    {
        private CategoriaService oCategoriaService;
        public frmCategorias()
        {
            InitializeComponent();
            InitializeDataGridView();
            oCategoriaService = new CategoriaService();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            LlenarCombo(cmbCategorias, oCategoriaService.obtenerTodas(), "nombre", "id_categoria");
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (ckdCategorias.Checked)
            {
                grdCategorias.DataSource = oCategoriaService.obtenerTodas();
            }


        }
        private void InitializeDataGridView()
        {
            //defino la cantiddad de columnas
            grdCategorias.ColumnCount = 2;
            grdCategorias.ColumnHeadersVisible = true;


            //para qe no se autogeneren las columnas
            grdCategorias.AutoGenerateColumns = false;

            // definicion de los nombres de las columnas y el datapropertyname
            // que se asocia a dataSource


            grdCategorias.Columns[0].Name = "Nombre";
            grdCategorias.Columns[0].DataPropertyName = "nombre";

            grdCategorias.Columns[1].Name = "Descripción";
            grdCategorias.Columns[1].DataPropertyName = "descripcion";

            //Cambia el tamaño de la altura de los ancabezados de columna

            grdCategorias.AutoResizeColumnHeadersHeight();

            // ajustar el contenio de las celdas que no sean encabezado
            // cambia el tamaño de todas las alturas de fila

            grdCategorias.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }
        

        private void ckdCategorias_CheckedChanged(object sender, EventArgs e)
        {
            if ( ckdCategorias.Checked)
            {
                cmbCategorias.Enabled = false;
            }
            else
            {
                cmbCategorias.Enabled = true;
            }
        }
    }
}
