using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BugTracker_TPI.Negocio;
using BugTracker_TPI.Entidades;

namespace BugTracker_TPI.Interfaz.CursadoAvances
{
    public partial class frmActualizacionCursado : Form
    {
        private readonly CursoService cursoService;
        private readonly UsuarioCursoService usuarioCursoService;
        public frmActualizacionCursado()
        {
            InitializeComponent();

            //inicializamos las clases de servicio o gestoras
            cursoService = new CursoService();
            usuarioCursoService = new UsuarioCursoService();

            //cargamos la grilla
            cargarDataGridView();
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

        private void frmActualizacionAvances_Load(object sender, EventArgs e)
        {
            //aca cuando se carga la el form
            //se carga la tambien al mismo tiempo el combo de los cursos
            LlenarCombo(cboCursos, cursoService.mostrarTodos(), "NombreCurso", "IdCurso");
            this.CenterToParent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                parametros.Add("nombreUsuario", txtNombre.Text);
            }

            if(!string.IsNullOrEmpty(cboCursos.Text))
            {
                parametros.Add("idCurso", cboCursos.SelectedValue);
            }

            IList<UsuarioCurso> cursosData = usuarioCursoService.filtrar(parametros);
            dgvUsuarioCurso.DataSource = cursosData;
        }

        private void cargarDataGridView()
        {
            // declaramos la cant de columnas de la tabla.
            dgvUsuarioCurso.ColumnCount = 6;
            dgvUsuarioCurso.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvUsuarioCurso.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvUsuarioCurso.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            //tener en cuenta que el nombre de DataPropertyName tiene que ser el mismo de la clase que se 
            //encuentra en la capa "Entidad"
            dgvUsuarioCurso.Columns[0].Name = "Usuario";
            dgvUsuarioCurso.Columns[0].DataPropertyName = "Usuario";

            dgvUsuarioCurso.Columns[1].Name = "Curso";
            dgvUsuarioCurso.Columns[1].DataPropertyName = "Curso";

            dgvUsuarioCurso.Columns[2].Name = "Puntuacion";
            dgvUsuarioCurso.Columns[2].DataPropertyName = "Puntuacion";

            dgvUsuarioCurso.Columns[3].Name = "Observaciones";
            dgvUsuarioCurso.Columns[3].DataPropertyName = "Observaciones";

            dgvUsuarioCurso.Columns[4].Name = "Fecha Inicio";
            dgvUsuarioCurso.Columns[4].DataPropertyName = "FechaInicio";

            dgvUsuarioCurso.Columns[5].Name = "Fecha Fin";
            dgvUsuarioCurso.Columns[5].DataPropertyName = "FechaFin";

            // Se cambia el tamaño de la altura de los encabezados de columna.
            dgvUsuarioCurso.AutoResizeColumnHeadersHeight();

            dgvUsuarioCurso.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void dgvUsuarioCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizarAvance.Enabled = true;
        }

        private void btnActualizarAvance_Click(object sender, EventArgs e)
        {
            frmCursado avances = new frmCursado();
            UsuarioCurso usuarioCursoSelect = (UsuarioCurso) dgvUsuarioCurso.CurrentRow.DataBoundItem;

            avances.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCursado avances = new frmCursado();
            avances.ShowDialog();
        }
    }
}
