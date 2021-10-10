using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BugTracker_TPI.Entidades;
using BugTracker_TPI.Negocio;

namespace BugTracker_TPI.Interfaz.CursadoAvances
{
    public partial class frmCursado : Form
    {
        UsuarioCurso usuarioCurso = new UsuarioCurso();

        private readonly CursoService cursoService;
        private readonly UsuarioService usuarioService;
        private readonly UsuarioCursoService usuarioCursoService;

        public frmCursado()
        {
            InitializeComponent();

            cursoService = new CursoService();
            usuarioService = new UsuarioService();
            usuarioCursoService = new UsuarioCursoService();
            usuarioCurso.avances = new List<Avance>();
        }

        private void frmAvances_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboUsuarios, usuarioService.obtenerTodos(), "NombreUsuario", "IdUsuario");
            LlenarCombo(cboCurso, cursoService.mostrarTodos(), "NombreCurso", "IdCurso");

            this.CenterToParent();

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

        private void btnAgregarAvance_Click(object sender, EventArgs e)
        {

            //primero verificamos si los tres parametros fueron ingresador de manera correcta
            DateTime fechaInicioAvance;
            DateTime fechaFinAvance;

            if ( !DateTime.TryParse(txtInicioAvance.Text, out fechaInicioAvance) || !DateTime.TryParse(txtFinAvance.Text, out fechaFinAvance) || string.IsNullOrEmpty(txtPorc.Text))
            {
                MessageBox.Show("Ingrese todos los campos requeridos para los avances","Validación",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fechaInicioAvance >= fechaFinAvance)
            {
                MessageBox.Show("La fecha fin del avance debe ser mayor a la fecha de inicio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //aca verificamos si existe un avance con la fecha de inicio 
            if (ExisteAvanceEnGrilla(txtInicioAvance.Text))
            {
                MessageBox.Show("Ya hay un avance con esa fecha de inicio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Avance avanceDetail = new Avance
            {
                Inicio = Convert.ToDateTime(txtInicioAvance.Text),
                Fin = Convert.ToDateTime(txtFinAvance.Text),
                Porcentaje = Convert.ToDouble(txtPorc.Text),
            };

            //agreamos el avance al objeto usuario curso
            usuarioCurso.agregarAvance(avanceDetail);

            //agregamos el avance a la grilla
            dgvAvances.Rows.Add(new object[] {avanceDetail.Inicio, avanceDetail.Fin, avanceDetail.Porcentaje });

        }

        private bool ExisteAvanceEnGrilla(string inicio)
        {
            foreach (DataGridViewRow row in dgvAvances.Rows)
            {
                if (row.Cells["inicio"].Value.Equals(inicio))
                    return true;
            }
            return false;
        }

        private void btnNuevoUsuarioCurso_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio;
            DateTime fechaFin;
            if(string.IsNullOrEmpty(cboUsuarios.Text))
            {
                MessageBox.Show("Debe ingresar un usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(cboCurso.Text))
            {
                MessageBox.Show("Debe ingresar un curso", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(string.IsNullOrEmpty(txtObser.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar una observación", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!DateTime.TryParse(txtFechaInicio.Text, out fechaInicio))
            {
                MessageBox.Show("Debe ingresar una fecha de inicio con formato dd/mm/yyyy", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(txtFechaFin.Text, out fechaFin))
            {
                MessageBox.Show("Debe ingresar una fecha de fin con formato dd/mm/yyyy", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(fechaInicio >= fechaFin)
            {
                MessageBox.Show("La fecha fin del cursado debe ser mayor a la fecha de inicio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //completamos los atriutos del objeto usuarioCurso
            usuarioCurso.Usuario = (Usuario)cboUsuarios.SelectedItem;
            usuarioCurso.Curso = (Curso)cboCurso.SelectedItem;
            usuarioCurso.Puntuacion = (float) Convert.ToDouble(txtPuntuacion.Text);
            usuarioCurso.Observaciones = txtObser.Text;
            usuarioCurso.FechaInicio = fechaInicio;
            usuarioCurso.FechaFin = fechaFin;

            if (usuarioCursoService.grabar(usuarioCurso))
            {
                MessageBox.Show("Cursado de usuario guardado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error al intentar registrar el cursado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
