
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizacionCursado));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCursos = new System.Windows.Forms.ComboBox();
            this.dgvUsuarioCurso = new System.Windows.Forms.DataGridView();
            this.lblUsuarioCursos = new System.Windows.Forms.Label();
            this.btnActualizarAvance = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTotalCursados = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(189, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(86, 25);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNombreUsuario.Location = new System.Drawing.Point(48, 29);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(135, 19);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre del Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(486, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Curso:";
            // 
            // cboCursos
            // 
            this.cboCursos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCursos.FormattingEnabled = true;
            this.cboCursos.Location = new System.Drawing.Point(540, 23);
            this.cboCursos.Name = "cboCursos";
            this.cboCursos.Size = new System.Drawing.Size(152, 25);
            this.cboCursos.TabIndex = 3;
            // 
            // dgvUsuarioCurso
            // 
            this.dgvUsuarioCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioCurso.Location = new System.Drawing.Point(46, 92);
            this.dgvUsuarioCurso.Name = "dgvUsuarioCurso";
            this.dgvUsuarioCurso.RowTemplate.Height = 25;
            this.dgvUsuarioCurso.Size = new System.Drawing.Size(646, 198);
            this.dgvUsuarioCurso.TabIndex = 4;
            this.dgvUsuarioCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarioCurso_CellClick);
            // 
            // lblUsuarioCursos
            // 
            this.lblUsuarioCursos.AutoSize = true;
            this.lblUsuarioCursos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsuarioCursos.Location = new System.Drawing.Point(48, 69);
            this.lblUsuarioCursos.Name = "lblUsuarioCursos";
            this.lblUsuarioCursos.Size = new System.Drawing.Size(136, 19);
            this.lblUsuarioCursos.TabIndex = 5;
            this.lblUsuarioCursos.Text = "Cursado de Usuarios";
            // 
            // btnActualizarAvance
            // 
            this.btnActualizarAvance.Enabled = false;
            this.btnActualizarAvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarAvance.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarAvance.Image")));
            this.btnActualizarAvance.Location = new System.Drawing.Point(111, 325);
            this.btnActualizarAvance.Name = "btnActualizarAvance";
            this.btnActualizarAvance.Size = new System.Drawing.Size(56, 60);
            this.btnActualizarAvance.TabIndex = 6;
            this.btnActualizarAvance.UseVisualStyleBackColor = true;
            this.btnActualizarAvance.Click += new System.EventHandler(this.btnActualizarAvance_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnConsultar.Location = new System.Drawing.Point(598, 56);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(94, 30);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(46, 325);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 60);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblTotalCursados
            // 
            this.lblTotalCursados.AutoSize = true;
            this.lblTotalCursados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalCursados.Location = new System.Drawing.Point(49, 293);
            this.lblTotalCursados.Name = "lblTotalCursados";
            this.lblTotalCursados.Size = new System.Drawing.Size(32, 15);
            this.lblTotalCursados.TabIndex = 9;
            this.lblTotalCursados.Text = "Total";
            this.lblTotalCursados.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(172, 325);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 60);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmActualizacionCursado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(741, 404);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblTotalCursados);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnActualizarAvance);
            this.Controls.Add(this.lblUsuarioCursos);
            this.Controls.Add(this.dgvUsuarioCurso);
            this.Controls.Add(this.cboCursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.txtNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lblTotalCursados;
        private System.Windows.Forms.Button btnEliminar;
    }
}