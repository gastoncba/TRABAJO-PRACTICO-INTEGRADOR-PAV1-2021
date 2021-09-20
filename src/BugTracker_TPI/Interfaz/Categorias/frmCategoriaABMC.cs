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
        private FormMode formMode = FormMode.nuevo;

        private readonly CategoriaService oCategoriaService;
        private Categoria categoriaSelected;
        public frmCategoriaABMC()
        {
            InitializeComponent();
            oCategoriaService = new CategoriaService();
            categoriaSelected = new Categoria();
        }

        private void frmCategoriaABMC_Load(object sender, EventArgs e)
        {
            LlenarCombo(cmbCategorias, oCategoriaService.obtenerTodas(), "nombre", "id_categoria");
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
                        cmbCategorias.Enabled = true;
                        lblDescripcion.Enabled = true;
                        break;
                    }

                case FormMode.eliminar:
                    {
                        MostrarDatos();
                        this.Text = "Habilitar/Deshabilitar Usuario";
                        cmbCategorias.Enabled = false;
                        lblDescripcion.Enabled = false;
                        break;
                    }
            }
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }
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
                cmbCategorias.Text = categoriaSelected.nombre;
                lblDescripcion.Text = categoriaSelected.descripcion;
            }
        }
    }
}
