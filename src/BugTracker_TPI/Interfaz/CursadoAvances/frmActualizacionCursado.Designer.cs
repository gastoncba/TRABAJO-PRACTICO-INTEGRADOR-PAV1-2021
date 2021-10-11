
namespace BugTracker_TPI.Interfaz.CursadoAvances
{
    partial class frmActualizacionCursado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCursos = new System.Windows.Forms.ComboBox();
            this.dgvUsuarioCurso = new System.Windows.Forms.DataGridView();
            this.lblUsuarioCursos = new System.Windows.Forms.Label();
            this.btnActualizarAvance = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(176, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(54, 28);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(116, 15);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre del Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Curso";
            // 
            // cboCursos
            // 
            this.cboCursos.FormattingEnabled = true;
            this.cboCursos.Location = new System.Drawing.Point(501, 24);
            this.cboCursos.Name = "cboCursos";
            this.cboCursos.Size = new System.Drawing.Size(121, 23);
            this.cboCursos.TabIndex = 3;
            // 
            // dgvUsuarioCurso
            // 
            this.dgvUsuarioCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioCurso.Location = new System.Drawing.Point(54, 106);
            this.dgvUsuarioCurso.Name = "dgvUsuarioCurso";
            this.dgvUsuarioCurso.RowTemplate.Height = 25;
            this.dgvUsuarioCurso.Size = new System.Drawing.Size(617, 143);
            this.dgvUsuarioCurso.TabIndex = 4;
            this.dgvUsuarioCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarioCurso_CellClick);
            // 
            // lblUsuarioCursos
            // 
            this.lblUsuarioCursos.AutoSize = true;
            this.lblUsuarioCursos.Location = new System.Drawing.Point(54, 88);
            this.lblUsuarioCursos.Name = "lblUsuarioCursos";
            this.lblUsuarioCursos.Size = new System.Drawing.Size(115, 15);
            this.lblUsuarioCursos.TabIndex = 5;
            this.lblUsuarioCursos.Text = "Cursado de Usuarios";
            // 
            // btnActualizarAvance
            // 
            this.btnActualizarAvance.Enabled = false;
            this.btnActualizarAvance.Location = new System.Drawing.Point(135, 280);
            this.btnActualizarAvance.Name = "btnActualizarAvance";
            this.btnActualizarAvance.Size = new System.Drawing.Size(74, 25);
            this.btnActualizarAvance.TabIndex = 6;
            this.btnActualizarAvance.Text = "actualizar";
            this.btnActualizarAvance.UseVisualStyleBackColor = true;
            this.btnActualizarAvance.Click += new System.EventHandler(this.btnActualizarAvance_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(547, 65);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(54, 280);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmActualizacionCursado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 315);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnActualizarAvance);
            this.Controls.Add(this.lblUsuarioCursos);
            this.Controls.Add(this.dgvUsuarioCurso);
            this.Controls.Add(this.cboCursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmActualizacionCursado";
            this.Text = "Actualización de Cursados";
            this.Load += new System.EventHandler(this.frmActualizacionAvances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCursos;
        private System.Windows.Forms.DataGridView dgvUsuarioCurso;
        private System.Windows.Forms.Label lblUsuarioCursos;
        private System.Windows.Forms.Button btnActualizarAvance;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnNuevo;
    }
}