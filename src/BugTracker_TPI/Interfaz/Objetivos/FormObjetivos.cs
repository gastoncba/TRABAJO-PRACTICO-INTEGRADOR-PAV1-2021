using BugTracker_TPI.Entidades;
using BugTracker_TPI.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BugTracker_TPI.Interfaz.Objetivos
{
    public partial class FormObjetivos : Form
    {
        private readonly ObjetivoService objetivoService;

        public FormObjetivos()
        {
            InitializeComponent();

            //inicializamos las clases de servicio o gestoras
            objetivoService = new ObjetivoService();

            //inicializamos tambien la dataGridView con valor determinados que nos van a servir
            cargarDataGridView();
        }

        private void cargarDataGridView()
        {
            // declaramos la cant de columnas de la tabla.
            //4 columnas ya que de los cursos vamos a mostrar id, nombre corto, nombre largo y borrado
            dgvObjetivos.ColumnCount = 4;
            dgvObjetivos.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvObjetivos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvObjetivos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            //tener en cuenta que el nombre de DataPropertyName tiene que ser el mismo de la clase Curso que se 
            //encuentra en la capa "Entidad"
            dgvObjetivos.Columns[0].Name = "Id";
            dgvObjetivos.Columns[0].DataPropertyName = "IdObjetivo";

            dgvObjetivos.Columns[1].Name = "Nombre Corto";
            dgvObjetivos.Columns[1].DataPropertyName = "NombreCorto";

            dgvObjetivos.Columns[2].Name = "Nombre Largo";
            dgvObjetivos.Columns[2].DataPropertyName = "NombreLargo";

            dgvObjetivos.Columns[3].Name = "Disponible";
            dgvObjetivos.Columns[3].DataPropertyName = "Borrado";

            // Se cambia el tamaño de la altura de los encabezados de columna.
            dgvObjetivos.AutoResizeColumnHeadersHeight();

            dgvObjetivos.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void FormObjetivos_Load(object sender, EventArgs e)
        {

        }

        private bool hayDatos()
        {
            return dgvObjetivos.Rows.Count != 0;
        }

        private void dgvObjetivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Objetivo cursoSele = (Objetivo)dgvObjetivos.CurrentRow.DataBoundItem;
            if (cursoSele.Borrado == "no")
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
            btnModificar.Enabled = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(txtId.Text))
            {
                parametros.Add("idObjetivo", txtId.Text);
            }

            if (!string.IsNullOrEmpty(txtNC.Text))
            {
                parametros.Add("nombreCorto", txtNC.Text);
            }

            if (!string.IsNullOrEmpty(txtNL.Text))
            {
                parametros.Add("nombreLargo", txtNL.Text);
            }

            if (cbIncluirBajas.Checked)
            {
                IList<Objetivo> objetivosData = objetivoService.filtrar(parametros, true);
                dgvObjetivos.DataSource = objetivosData;
            }
            else
            {
                IList<Objetivo> objetivosData = objetivoService.filtrar(parametros);
                dgvObjetivos.DataSource = objetivosData;
            }

            lblTotalObj.Visible = true;
            lblTotalObj.Text = "Total de objetivos encontrados: " + dgvObjetivos.Rows.Count + " Objetivo/s";

            if (!hayDatos())
            {
                MessageBox.Show("No encontraron objetivos", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormObjetivosABM formABM = new FormObjetivosABM();
            formABM.ShowDialog();

            //se actualiza la grilla
            btnConsultar_Click(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormObjetivosABM formABM = new FormObjetivosABM();
            Objetivo objetivoSelected = (Objetivo)dgvObjetivos.CurrentRow.DataBoundItem;
            formABM.InicializarFormulario(FormObjetivosABM.FormMode.modificar, objetivoSelected);
            formABM.ShowDialog();

            btnConsultar_Click(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormObjetivosABM formABM = new FormObjetivosABM();
            Objetivo objetivoSelected = (Objetivo)dgvObjetivos.CurrentRow.DataBoundItem;
            formABM.InicializarFormulario(FormObjetivosABM.FormMode.eliminar, objetivoSelected);
            formABM.ShowDialog();

            btnConsultar_Click(sender, e);
        }
    }
}
