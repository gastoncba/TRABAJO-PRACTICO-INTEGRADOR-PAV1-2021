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

namespace BugTracker_TPI.Interfaz.Cursos
{
    public partial class FormCursos : Form
    {
        private readonly CategoriaService categoriaService;
        private readonly CursoService cursoService;

        public FormCursos()
        {
            InitializeComponent();
            //inicializamos las clases de servicio o gestoras
            categoriaService = new CategoriaService();
            cursoService = new CursoService();

            //inicializamos tambien la dataGridView con valor determinados que nos van a servir
            cargarDataGridView();
        }

        private void cargarDataGridView()
        {
            // declaramos la cant de columnas de la tabla.
            //4 columnas ya que de los cursos vamos a mostrar nombre, descrpción, fecha vigencia y categoria
            dgvCursos.ColumnCount = 4;
            dgvCursos.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvCursos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvCursos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            //tener en cuenta que el nombre de DataPropertyName tiene que ser el mismo de la clase Curso que se 
            //encuentra en la capa "Entidad"
            dgvCursos.Columns[0].Name = "Nombre";
            dgvCursos.Columns[0].DataPropertyName = "NombreCurso";
            
            dgvCursos.Columns[1].Name = "Descripción";
            dgvCursos.Columns[1].DataPropertyName = "Descripcion";

            dgvCursos.Columns[2].Name = "Vigencia";
            dgvCursos.Columns[2].DataPropertyName = "FechaVigencia";

            dgvCursos.Columns[3].Name = "Categoria";
            dgvCursos.Columns[3].DataPropertyName = "Categoria";

            // Se cambia el tamaño de la altura de los encabezados de columna.
            dgvCursos.AutoResizeColumnHeadersHeight();

            dgvCursos.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
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
            DateTime fechaVigencia;


            if (string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(cboCategorias.Text) && !DateTime.TryParse(txtVigencia.Text, out fechaVigencia))
            {
                if(checkDadosDeBaja.Checked)
                {
                    IList<Curso> cursosData = cursoService.obtenerTodos(true);
                    dgvCursos.DataSource = cursosData;
                } else
                {
                    IList<Curso> cursosData = cursoService.obtenerTodos();
                    dgvCursos.DataSource = cursosData;
                }
            }

            else
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();

                if (DateTime.TryParse(txtVigencia.Text, out fechaVigencia))
                {
                    parametros.Add("vigencia", fechaVigencia);
                }

                if (!string.IsNullOrEmpty(cboCategorias.Text))
                {
                    var IDcateogoria = cboCategorias.SelectedValue;
                    parametros.Add("idCategoria", IDcateogoria);
                }

                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    parametros.Add("curso", txtNombre.Text);
                }


                if (checkDadosDeBaja.Checked)
                {
                    parametros.Add("baja", 1);
                }
                else
                {
                    parametros.Add("baja", 0);
                }


                IList<Curso> cursosData = cursoService.filtrar(parametros);
                dgvCursos.DataSource = cursosData;

            }

            lblTotalCursos.Visible = true;
            lblTotalCursos.Text =  "Total de cursos encontrados: " + dgvCursos.Rows.Count + " Cursos";
            
            if (!hayDatos())
            {
                MessageBox.Show("No encontraron cursos", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private bool hayDatos()
        {
            return dgvCursos.Rows.Count != 0;
        }

        private void FormCursos_Load(object sender, EventArgs e)
        {
            //aca cuando se carga la el form de los cursos 
            //se carga la tambien al mismo tiempo el combo de las categorias.
            LlenarCombo(cboCategorias, categoriaService.obtenerTodas(), "nombre", "id_categoria");
            this.CenterToParent();
        }

        private void checkBaja_CheckedChanged(object sender, EventArgs e)
        {
            //
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormCursosABM formABM = new FormCursosABM();
            Curso cursoSelect = (Curso) dgvCursos.CurrentRow.DataBoundItem;
            formABM.InicializarFormulario(FormCursosABM.FormMode.modificar, cursoSelect);
            formABM.ShowDialog();

            //se actualiza la grilla
            btnConsultar_Click(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormCursosABM formABM = new FormCursosABM();
            Curso cursoSelect = (Curso)dgvCursos.CurrentRow.DataBoundItem;
            formABM.InicializarFormulario(FormCursosABM.FormMode.eliminar, cursoSelect);
            formABM.ShowDialog();

            //se actualiza la grilla
            btnConsultar_Click(sender, e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormCursosABM formABM = new FormCursosABM();
            formABM.ShowDialog();

            //se actualiza la grilla
            btnConsultar_Click(sender, e);

            
        }
    }
}
