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
        //por default la transacción para agregar una nuevo cursado
        private FormMode formMode = FormMode.nuevo;

        //se define un cursado.
        UsuarioCurso usuarioCurso = new UsuarioCurso();

        private readonly CursoService cursoService;
        private readonly UsuarioService usuarioService;
        private readonly UsuarioCursoService usuarioCursoService;

        //se define el cursado que se selecciono
        private UsuarioCurso cursadoSelect;


        //lista de eliminados
        private List<Avance> eliminados;

        public frmCursado()
        {
            InitializeComponent();

            cursoService = new CursoService();
            usuarioService = new UsuarioService();
            usuarioCursoService = new UsuarioCursoService();

            //inicializamos una lista de avances vacia 
            usuarioCurso.avances = new List<Avance>();

            //inicializamos la lista de eliminados vacia
            eliminados = new List<Avance>();
        }

        public enum FormMode
        {
            nuevo,
            eliminar,
            modificar
        }

        public void inicializarTransaccion(FormMode op, Object cursadoSeleccionado)
        {
            formMode = op;
            cursadoSelect = (UsuarioCurso) cursadoSeleccionado;
        }

        private void frmAvances_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboUsuarios, usuarioService.obtenerTodos(), "NombreUsuario", "IdUsuario");
            LlenarCombo(cboCurso, cursoService.mostrarTodos(), "NombreCurso", "IdCurso");

            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        this.Text = "Nuevo Cursado";
                        lblPrincipal.Text = "Nuevo Cursado";
                        break;
                    }
                case FormMode.modificar:
                    {
                        this.Text = "Modificación de cursado";
                        lblPrincipal.Text = "Modificar Cursado";

                        obtenerDatosCursadoSeleccionado();

                        cboUsuarios.Enabled = true;
                        cboCurso.Enabled = true;
                        txtPuntuacion.Enabled = true;
                        txtObser.Enabled = true;
                        txtFechaInicio.Enabled = true;
                        txtFechaFin.Enabled = true;

                        txtInicioAvance.Enabled = true;
                        txtFinAvance.Enabled = true;
                        txtPorc.Enabled = true;
                        break;
                    }

            }

            this.CenterToParent();

        }

        private void obtenerDatosCursadoSeleccionado()
        {
            if(cursadoSelect != null)
            {
                //aca se setean los datos del cursado seleccionado en los campos 
                cboUsuarios.Text = cursadoSelect.Usuario.NombreUsuario;
                cboCurso.Text = cursadoSelect.Curso.NombreCurso;
                txtPuntuacion.Text = cursadoSelect.Puntuacion.ToString();
                txtObser.Text = cursadoSelect.Observaciones;
                txtFechaInicio.Text = cursadoSelect.FechaInicio.ToString("dd/MM/yyyy");
                txtFechaFin.Text = cursadoSelect.FechaFin.ToString("dd/MM/yyyy");

                //recorremos todos los avances para el cursado seleccionado y los agregamos a la grilla
                foreach(Avance avDetail in cursadoSelect.avances)
                {
                  dgvAvances.Rows.Add(new object[] { avDetail.Inicio, avDetail.Fin, avDetail.Porcentaje });
                }
                //dgvAvances.DataSource = cursadoSelect.avances;
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

        private void btnAgregarAvance_Click(object sender, EventArgs e)
        {

            if(validarCamposAvances())
            {
                Avance avanceDetail = new Avance
                {
                    Inicio = Convert.ToDateTime(txtInicioAvance.Text),
                    Fin = Convert.ToDateTime(txtFinAvance.Text),
                    Porcentaje = Convert.ToInt32(txtPorc.Text)
                };

                //agreamos el avance al objeto usuario curso
                switch (formMode)
                {
                    case FormMode.nuevo:
                        {
                            avanceDetail.Verificado = true;
                            usuarioCurso.agregarAvance(avanceDetail);
                            break;
                        }
                    case FormMode.modificar:
                        {
                            avanceDetail.Verificado = false;
                            cursadoSelect.agregarAvance(avanceDetail);
                            break;
                        }
                }

                //agregamos el avance a la grilla
                dgvAvances.Rows.Add(new object[] { avanceDetail.Inicio, avanceDetail.Fin, avanceDetail.Porcentaje });
            }  
        }

        private void btnSacarAvance_Click(object sender, EventArgs e)
        {
            if(dgvAvances.Rows.Count >= 1)
            {
                DateTime fechaInicioOld = (DateTime)dgvAvances.CurrentRow.Cells["inicio"].Value;
                int Index = dgvAvances.CurrentRow.Index;

                switch (formMode)
                {
                    case FormMode.nuevo:
                        {
                            eliminados.Add(usuarioCurso.sacarAvance(fechaInicioOld));
                            dgvAvances.Rows.RemoveAt(Index);
                            break;
                        }
                    case FormMode.modificar:
                        {
                            eliminados.Add(cursadoSelect.sacarAvance(fechaInicioOld));
                            dgvAvances.Rows.RemoveAt(Index);
                            break;
                        }
                }
            }
        }

        private bool ExisteAvanceEnGrilla(DateTime inicio)
        {
            foreach (DataGridViewRow row in dgvAvances.Rows)
            {
                var value = row.Cells["inicio"].Value;

                if (value.Equals(inicio))
                    return true;
            }
            return false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //la funcionalidad de este boton se divide en tres , dependiendo de la eleción de modificar o agregar un cursado

            switch(formMode)
            {
                case FormMode.nuevo:
                    {
                        agregarCursado();
                        break;
                    }
                case FormMode.modificar:
                    {
                        modificarCursado();
                        break;
                    }
            }
        }

        private void agregarCursado()
        {
            if(validarCampos())
            {
                //completamos los atriutos del objeto usuarioCurso
                usuarioCurso.Usuario = (Usuario)cboUsuarios.SelectedItem;
                usuarioCurso.Curso = (Curso)cboCurso.SelectedItem;
                usuarioCurso.Puntuacion = Convert.ToInt32(txtPuntuacion.Text);
                usuarioCurso.Observaciones = txtObser.Text;
                usuarioCurso.FechaInicio = Convert.ToDateTime(txtFechaInicio.Text);
                usuarioCurso.FechaFin = Convert.ToDateTime(txtFechaFin.Text);

                if (usuarioCursoService.agregar(usuarioCurso))
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

        private void modificarCursado()
        {
            if(validarCampos())
            {
                //se guardan los viejas keys del cursado  asi se pueden buscar
                //ya que tambien vamos a reemplazar las keys 

                Object[] oldKeys = { cursadoSelect.Usuario.IdUsuario, cursadoSelect.Curso.IdCurso};

                //seteamos los atributos el  cursado o "usuariosCurso" seleccionado
                cursadoSelect.Usuario = (Usuario)cboUsuarios.SelectedItem;
                cursadoSelect.Curso = (Curso)cboCurso.SelectedItem;
                cursadoSelect.Puntuacion = Convert.ToInt32(txtPuntuacion.Text);
                cursadoSelect.Observaciones = txtObser.Text;
                cursadoSelect.FechaInicio = Convert.ToDateTime(txtFechaInicio.Text);
                cursadoSelect.FechaFin = Convert.ToDateTime(txtFechaFin.Text);

                if (usuarioCursoService.actualizar(cursadoSelect, oldKeys, eliminados))
                {
                    MessageBox.Show("Cursado de usuario actiualizado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al intentar actualizar el cursado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validarCamposAvances()
        {
            //primero verificamos si los tres parametros fueron ingresador de manera correcta
            DateTime fechaInicioAvance;
            DateTime fechaFinAvance;
            int porc;

            if(validarCampos())
            {
                if (!DateTime.TryParse(txtInicioAvance.Text, out fechaInicioAvance) || !DateTime.TryParse(txtFinAvance.Text, out fechaFinAvance) || string.IsNullOrEmpty(txtPorc.Text))
                {
                    MessageBox.Show("Ingrese todos los campos requeridos para los avances", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (fechaInicioAvance >= fechaFinAvance)
                {
                    MessageBox.Show("La fecha fin del avance debe ser mayor a la fecha de inicio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!int.TryParse(txtPorc.Text, out porc))
                {
                    MessageBox.Show("El porcentaje debe ser un entero", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                DateTime InicialCursado = Convert.ToDateTime(txtFechaInicio.Text);
                DateTime FinalCursado = Convert.ToDateTime(txtFechaFin.Text);

                if(!(fechaInicioAvance>=InicialCursado && fechaFinAvance<=FinalCursado))
                {
                    MessageBox.Show("Fechas de avance fuera de rango", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                //aca verificamos si existe un avance con la fecha de inicio 
                if (ExisteAvanceEnGrilla(Convert.ToDateTime(txtInicioAvance.Text)))
                {
                    MessageBox.Show("Ya hay un avance con esa fecha de inicio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return true;
            }

            return false;
        }

        private bool validarCampos()
        {
            DateTime fechaInicio;
            DateTime fechaFin;
            int puntaje;

            if (string.IsNullOrEmpty(cboUsuarios.Text))
            {
                MessageBox.Show("Debe ingresar un usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(cboCurso.Text))
            {
                MessageBox.Show("Debe ingresar un curso", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(string.IsNullOrEmpty(txtPuntuacion.Text))
            {
                MessageBox.Show("Debe ingresar una puntuación", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtPuntuacion.Text, out puntaje))
            {
                MessageBox.Show("La puntuación debe ser un entero", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtObser.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar una observación", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!DateTime.TryParse(txtFechaInicio.Text, out fechaInicio))
            {
                MessageBox.Show("Debe ingresar una fecha de inicio con formato dd/mm/yyyy", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!DateTime.TryParse(txtFechaFin.Text, out fechaFin))
            {
                MessageBox.Show("Debe ingresar una fecha de fin con formato dd/mm/yyyy", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (fechaInicio >= fechaFin)
            {
                MessageBox.Show("La fecha fin del cursado debe ser mayor a la fecha de inicio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void dgvAvances_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Avance avanceSelect = (Avance)dgvAvances.CurrentRow.DataBoundItem;

            //txtInicioAvance.Text = avanceSelect.Inicio.ToString("dd/MM/yyyy");
            //txtFinAvance.Text = avanceSelect.Fin.ToString("dd/MM/yyyy");
            //txtPorc.Text = avanceSelect.Porcentaje.ToString();

            btnSacarAvance.Enabled = true;

        }
    }
}
