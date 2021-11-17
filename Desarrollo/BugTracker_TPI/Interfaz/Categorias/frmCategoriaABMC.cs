using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BugTracker_TPI.Entidades;
using BugTracker_TPI.BusinessLayer;


namespace BugTracker_TPI.Interfaz.Categorias
{
    public partial class frmCategoriaABMC : Form
    {
        public FormMode formMode = FormMode.nuevo;

        public readonly CategoriaService oCategoriaService;
        public Categoria categoriaSelected;
        public frmCategoriaABMC()
        {
            InitializeComponent();
            oCategoriaService = new CategoriaService();
            categoriaSelected = new Categoria();
        }

        private void frmCategoriaABMC_Load(object sender, EventArgs e)
        {
           // LlenarCombo(txtCatNueva, oCategoriaService.obtenerTodas(), "nombre", "id_categoria");
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        this.Text = "Nueva Categoria";
                        break;
                    }

                case FormMode.actualizar:
                    {
                        this.Text = "Actualizar Categoria";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        txtCatNueva.Enabled = true;
                        txtDescripcion.Enabled = true;
                        break;
                    }

                case FormMode.eliminar:
                    {
                        MostrarDatos();
                        this.Text = "Habilitar/Deshabilitar Usuario";
                        txtCatNueva.Enabled = false;
                        txtDescripcion.Enabled = false;
                        break;
                    }
            }
        }

        //private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        //{
        //    cbo.DataSource = source;
        //    cbo.DisplayMember = display;
        //    cbo.ValueMember = value;
        //    cbo.SelectedIndex = -1;
        //}
        public enum FormMode
        {
            nuevo,
            actualizar,
            eliminar
        }
        private void MostrarDatos()
        {
            if (categoriaSelected != null)
            {
                txtCatNueva.Text = categoriaSelected.nombre;
                txtDescripcion.Text = categoriaSelected.descripcion;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch(formMode)
            {
                case FormMode.nuevo:
                    {
                        if (existeCategoria() == false)
                        {
                            if (ValidarCampos())
                            {
                                var oCategoria = new Categoria();
                                oCategoria.nombre = txtCatNueva.Text;
                                oCategoria.descripcion = txtDescripcion.Text;
                                

                            if (oCategoriaService.crearCategoria(oCategoria))
                                {
                                    MessageBox.Show("Categoria agregada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                } 
                            }

                        }
                        else                       
                            MessageBox.Show("La categoria insertada ya existe, por favor, ingrese otra nuevo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;    
                    }
                case FormMode.actualizar:
                    {
                        if (ValidarCampos())
                        {
                            categoriaSelected.nombre = txtCatNueva.Text;
                            categoriaSelected.descripcion = txtDescripcion.Text;
                            if (oCategoriaService.actualizarCategoria(categoriaSelected))
                            {
                                MessageBox.Show("Categoria actualizada", " Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar la categoria", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.eliminar:
                    {
                        if (MessageBox.Show(" Seguro que desea eliminar/deshabilitar la categoria seleccionada?","Aviso", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (oCategoriaService.eliminarCategoria(categoriaSelected))
                            {
                                MessageBox.Show("Categoria eliminada/deshabilitada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar la categoria indicada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                        break;

            }
        }

        public void InitializeForm(FormMode op, Categoria categoriaSeleccionada)
        {
            formMode = op;
            categoriaSelected = categoriaSeleccionada;
        }

        private bool ValidarCampos()
        {
            if (txtCatNueva.Text == string.Empty)
            {
                txtCatNueva.BackColor = Color.Red;
                txtCatNueva.Focus();
                return false;
            }
            else
            {
                txtCatNueva.BackColor = Color.White;
                
            }
            if (lblDescripcion.Text == string.Empty)
            {
                lblDescripcion.BackColor = Color.Red;
                lblDescripcion.Focus();
                return false;
            }
            else
            {
                lblDescripcion.BackColor = Color.White;
                return true;
            }
                

        }
        private bool existeCategoria()
        {
            return oCategoriaService.obtenerCategoria(txtCatNueva.Text) != null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
