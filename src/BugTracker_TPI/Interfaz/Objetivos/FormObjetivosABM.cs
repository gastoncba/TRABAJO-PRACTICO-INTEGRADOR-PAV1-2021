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
    public partial class FormObjetivosABM : Form
    {
        private FormMode formMode = FormMode.nuevo;

        public enum FormMode
        {
            nuevo,
            eliminar,
            modificar
        }

        private readonly ObjetivoService oObjetivoService;
        private Objetivo oObjetivoSeleccionado;

        public FormObjetivosABM()
        {
            InitializeComponent();
            oObjetivoService = new ObjetivoService();
        }

        private void FormObjetivosABM_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        this.Text = "Nuevo Objetivo";

                        //el id lo crea la bd
                        label1.Visible = false;
                        txtId.Visible = false;
                        break;
                    }
                case FormMode.modificar:
                    {
                        this.Text = "Modificar Objetivo";
                        //se recuperan los datos de curso que se selecciono 
                        getDatosObjetivoSelected();
                        break;
                    }
                case FormMode.eliminar:
                    {
                        this.Text = "Eliminar Objetivo";
                        getDatosObjetivoSelected();
                        txtNC.Enabled = false;
                        txtNL.Enabled = false;
                        break;
                    }
            }
        }

        private void getDatosObjetivoSelected()
        {
            if (oObjetivoSeleccionado != null)
            {
                txtId.Text = oObjetivoSeleccionado.IdObjetivo.ToString();
                txtNC.Text = oObjetivoSeleccionado.NombreCorto;
                txtNL.Text = oObjetivoSeleccionado.NombreLargo;
            }
        }

        public void InicializarFormulario(FormMode op, Object objetivoSelected)
        {
            formMode = op;
            oObjetivoSeleccionado = (Objetivo)objetivoSelected;
        }

        private bool validarDatos()
        {
            if (string.IsNullOrEmpty(txtNC.Text) || txtNC.Text.Length > 50)
            {
                MessageBox.Show("Ingrese nombre corto, no mas de 50 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNC.Focus();
                return false;

            }

            if (string.IsNullOrEmpty(txtNL.Text) || txtNL.Text.Length > 50)
            {
                MessageBox.Show("Ingrese nombre largo, no mas de 100 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNL.Focus();
                return false;
            }

            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (validarDatos())
                        {
                            var oObjetivo = new Objetivo();
                            oObjetivo.NombreCorto = txtNC.Text;
                            oObjetivo.NombreLargo = txtNL.Text;

                            if (oObjetivoService.crearObjetivo(oObjetivo))
                            {
                                MessageBox.Show("Nuevo objetivo registrado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            } else
                            {
                                MessageBox.Show("Error al registrar el objetivo!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    }
                case FormMode.modificar:
                    {
                        if (validarDatos())
                        {
                            oObjetivoSeleccionado.NombreCorto = txtNC.Text;
                            oObjetivoSeleccionado.NombreLargo = txtNL.Text;

                            if (oObjetivoService.actualizarObjetivo(oObjetivoSeleccionado))
                            {
                                MessageBox.Show("Se actualizo el objetivo!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            } else
                            {
                                MessageBox.Show("Error al actualizar el objetivo!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    }
                case FormMode.eliminar:
                    {
                        this.Text = "Eliminar Objetivo";
                        getDatosObjetivoSelected();
                        txtNC.Enabled = false;
                        txtNL.Enabled = false;
                        break;
                    }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
