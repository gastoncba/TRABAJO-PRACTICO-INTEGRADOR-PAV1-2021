using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BugTracker_TPI.Interfaz.Cursos
{
    public partial class FormCursos : Form
    {
        public FormCursos()
        {
            InitializeComponent();
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
            dgvCursos.Columns[3].DataPropertyName = "CategoriaCurso";

            // Se cambia el tamaño de la altura de los encabezados de columna.
            dgvCursos.AutoResizeColumnHeadersHeight();

            dgvCursos.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

    }
}
