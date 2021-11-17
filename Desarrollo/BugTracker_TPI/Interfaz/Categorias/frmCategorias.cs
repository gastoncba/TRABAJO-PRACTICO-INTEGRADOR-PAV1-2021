using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BugTracker_TPI.BusinessLayer;
using BugTracker_TPI.AccesoBD;
using BugTracker_TPI.Entidades;

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
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
           // LlenarCombo(cmbCategorias, oCategoriaService.obtenerTodas(), "nombre", "id_categoria");
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
            var filtros = new Dictionary<string, object>();
            
            if (!ckdCategorias.Checked) 
            {

                //var filtros = new Dictionary<string, object>();
                
                if (txtCategoria.Text != string.Empty)
                {
                    filtros.Add("nombre", txtCategoria.Text);
                }

                //if (filtros.Count > 0)
                //{
                    grdCategorias.DataSource = oCategoriaService.obtenerConFiltros(filtros);
                    if (grdCategorias.Rows.Count == 0)
                    {
                        MessageBox.Show("No se han encontrado resultados para tu búsqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                lblTotalCat.Visible = true;
                lblTotalCat.Text = "Total de categorias encontradas: " + grdCategorias.Rows.Count + " Categorias";
                //}
            }
            else
            {   
                
                if (txtCategoria.Text != string.Empty)
                {
                    filtros.Add("nombre", txtCategoria.Text);
                }

                //grdCategorias.DataSource = oCategoriaService.obtenerTodas();
                grdCategorias.DataSource = oCategoriaService.obtenerConEliminadas(filtros);
                if (grdCategorias.Rows.Count == 0)
                {
                    MessageBox.Show("No se han encontrado resultados para tu búsqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                lblTotalCat.Visible = true;
                lblTotalCat.Text = "Total de categorias encontradas: " + grdCategorias.Rows.Count + " categorias";
            }


            //if (txtCategoria.Text == "")
            //{
              //  MessageBox.Show("Por favor, ingrese la categoria a buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            

        }
        private void InitializeDataGridView()
        {
            //defino la cantiddad de columnas
            grdCategorias.ColumnCount = 3;
            grdCategorias.ColumnHeadersVisible = true;


            //para qe no se autogeneren las columnas
            grdCategorias.AutoGenerateColumns = false;

            // definicion de los nombres de las columnas y el datapropertyname
            // que se asocia a dataSource


            grdCategorias.Columns[0].Name = "Nombre";
            grdCategorias.Columns[0].DataPropertyName = "nombre";

            grdCategorias.Columns[1].Name = "Descripción";
            grdCategorias.Columns[1].DataPropertyName = "descripcion";

            grdCategorias.Columns[2].Name = "Disponible";
            grdCategorias.Columns[2].DataPropertyName = "disponible";

            //Cambia el tamaño de la altura de los ancabezados de columna

            grdCategorias.AutoResizeColumnHeadersHeight();

            // ajustar el contenio de las celdas que no sean encabezado
            // cambia el tamaño de todas las alturas de fila

            //grdCategorias.AutoResizeRows(
            //    DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
            grdCategorias.AutoResizeColumns(DataGridViewAutoSizeColumnsMo‌​de.AllCells);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCategoriaABMC fmCategoriaAlta = new frmCategoriaABMC();
            fmCategoriaAlta.ShowDialog();

            //forzar para que se actualice la grilla
            btnConsultar_Click(sender, e);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmCategoriaABMC formulario = new frmCategoriaABMC();

            // para obtener la categoria que selecciono en la grilla y modificarla:
            var categoria = (Categoria)grdCategorias.CurrentRow.DataBoundItem;

            //cargar el formulario
            formulario.InitializeForm(frmCategoriaABMC.FormMode.actualizar, categoria);

            //mostrar
            formulario.ShowDialog();

            // esto es para que se actualice la grilla
            btnConsultar_Click(sender, e);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmCategoriaABMC formulario = new frmCategoriaABMC();

            //para obtener la categoria que selecciono en la grilla y modificarla:
            var categoria = (Categoria)grdCategorias.CurrentRow.DataBoundItem;

            //cargar el formulario
            formulario.InitializeForm(frmCategoriaABMC.FormMode.eliminar, categoria);

            //mostrar
            formulario.ShowDialog();

            //esto es para que se actualice la grilla
            btnConsultar_Click(sender, e);

        }

        private void grdCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Categoria catSelec = (Categoria)grdCategorias.CurrentRow.DataBoundItem;
            if(catSelec.disponible == "no")
            {
                btnEliminar.Enabled = false;
            } else
            {
                btnEliminar.Enabled = true;
            }
            btnModificar.Enabled = true;
        }
    }
}
