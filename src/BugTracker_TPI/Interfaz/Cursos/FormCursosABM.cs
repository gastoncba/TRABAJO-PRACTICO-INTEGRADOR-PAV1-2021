using BugTracker_TPI.Negocio;
using BugTracker_TPI.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker_TPI.Interfaz.Cursos
{
    public partial class FormCursosABM : Form
    {
        private FormMode formMode = FormMode.nuevo;

        private readonly CategoriaService oCategoriaService;
        private readonly CursoService oCursoService;
        private Curso oCursoSeleccionado;

        public FormCursosABM()
        {
            InitializeComponent();
            oCategoriaService = new CategoriaService();
            oCursoService = new CursoService();
        }

        public enum FormMode
        {
            nuevo,          
            eliminar,  
            modificar       
        }

        private void FormCursosABM_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboCategorias, oCategoriaService.obtenerTodos(), "NombreCategoria", "IdCategoria");

            switch(formMode)
            {
                case FormMode.nuevo:
                    {
                        this.Text = "Nuevo Curso";
                        break;
                    }
                case FormMode.modificar:
                    {
                        this.Text = "Modificar Curso";

                        //se recuperan los datos de curso que se selecciono 
                        getDatosCursoSelect();
                        //se habilitan los campos para que se pueda modificar
                        txtNombre.Enabled = true;
                        txtDescripcion.Enabled = true;
                        txtVigencia.Enabled = true;
                        cboCategorias.Enabled = true;
                        break;
                    }
                case FormMode.eliminar:
                    {
                        this.Text = "Eliminar Curso";

                        //se recuperan los datos de curso que se selecciono 
                        getDatosCursoSelect();
                        //se deshabilita los campos de los datos del curso
                        //el usuario aca solo puede aceptar o no aceptar
                        txtNombre.Enabled = false;
                        txtDescripcion.Enabled = false;
                        txtVigencia.Enabled = false;
                        cboCategorias.Enabled = false;
                        break;
                    }
            }
        }

        private void getDatosCursoSelect()
        {
            if(oCursoSeleccionado != null)
            {
                txtNombre.Text = oCursoSeleccionado.NombreCurso;
                txtDescripcion.Text = oCursoSeleccionado.Descripcion;
                txtVigencia.Text = oCursoSeleccionado.FechaVigencia.ToString("dd/MM/yyyy");
                cboCategorias.Text = oCursoSeleccionado.Categoria.NombreCategoria;
            }
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        public void InicializarFormulario(FormMode op, Object cursoSelected)
        {
            formMode = op;
            oCursoSeleccionado = (Curso) cursoSelected;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch(formMode)
            {
                case FormMode.nuevo:
                    {
                        //verificamos si exite un curso con ese nombre
                        if(!existeCurso(txtNombre.Text))
                        {
                            //validamos los campos
                            if(validarCampos())
                            {
                                var oCurso = new Curso();
                                oCurso.NombreCurso = txtNombre.Text;
                                oCurso.Descripcion = txtDescripcion.Text;
                                oCurso.FechaVigencia = Convert.ToDateTime(txtVigencia.Text);
                                oCurso.Categoria = new Categoria();
                                oCurso.Categoria.IdCategoria = (int) cboCategorias.SelectedValue;

                                if (oCursoService.crearCurso(oCurso))
                                {
                                    MessageBox.Show("Nuevo curso registrado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                } else
                                {
                                    MessageBox.Show("Error al registrar el curso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            } 
                        }

                        break;
                    }
                case FormMode.modificar:
                    {
                        if(validarCampos())
                        {
                            oCursoSeleccionado.NombreCurso = txtNombre.Text;
                            oCursoSeleccionado.Descripcion = txtDescripcion.Text;
                            oCursoSeleccionado.FechaVigencia = Convert.ToDateTime(txtVigencia.Text);
                            oCursoSeleccionado.Categoria.IdCategoria = (int) cboCategorias.SelectedValue;

                            if(oCursoService.actualizarCurso(oCursoSeleccionado))
                            {
                                MessageBox.Show("Se actualizo un curso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            } else
                            {
                                MessageBox.Show("Error al actualizar el curso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;
                    }

                case FormMode.eliminar:
                    {
                        if (MessageBox.Show("Seguro que desea eliminar el curso seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            if (oCursoService.eliminarCurso(oCursoSeleccionado))
                            {
                                MessageBox.Show("Curso Eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al eliminar el curso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
            }
        }

        private bool existeCurso(String cursoNombre)
        {
            return oCursoService.existeCurso(cursoNombre);
        }

        private bool validarCampos()
        {
            if(string.IsNullOrEmpty(txtNombre.Text) || txtNombre.Text.Length > 15)
            {
                txtNombre.Focus();
                MessageBox.Show("Ingrese un nombre para el curso, no mas de 15 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text) || txtDescripcion.Text.Length > 50)
            {
                txtNombre.Focus();
                MessageBox.Show("Ingrese una descripción para el curso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!DateTime.TryParse(txtVigencia.Text, out DateTime fechaVigencia))
            {
                txtNombre.Focus();
                MessageBox.Show("Ingrese una fecha para el curso, dd/MM/YYYY", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(cboCategorias.Text))
            {
                txtNombre.Focus();
                MessageBox.Show("Seleccione una categoria para el curso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
