
namespace BugTracker_TPI.Interfaz.Cursos
{
    partial class FormCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCursos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVigenciaHasta = new System.Windows.Forms.MaskedTextBox();
            this.txtVigenciaDesde = new System.Windows.Forms.MaskedTextBox();
            this.lblTotalCursos = new System.Windows.Forms.Label();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.checkDadosDeBaja = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(96, 34);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 25);
            this.txtNombre.TabIndex = 3;
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(19, 175);
            this.dgvCursos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.RowHeadersWidth = 51;
            this.dgvCursos.RowTemplate.Height = 25;
            this.dgvCursos.Size = new System.Drawing.Size(546, 182);
            this.dgvCursos.TabIndex = 6;
            this.dgvCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblTotalCursos);
            this.groupBox1.Controls.Add(this.cboCategorias);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.checkDadosDeBaja);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvCursos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(583, 465);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtVigenciaHasta);
            this.groupBox2.Controls.Add(this.txtVigenciaDesde);
            this.groupBox2.Location = new System.Drawing.Point(326, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 98);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vigencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Desde:";
            // 
            // txtVigenciaHasta
            // 
            this.txtVigenciaHasta.Location = new System.Drawing.Point(60, 60);
            this.txtVigenciaHasta.Mask = "00/00/0000";
            this.txtVigenciaHasta.Name = "txtVigenciaHasta";
            this.txtVigenciaHasta.Size = new System.Drawing.Size(163, 25);
            this.txtVigenciaHasta.TabIndex = 13;
            this.txtVigenciaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // txtVigenciaDesde
            // 
            this.txtVigenciaDesde.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtVigenciaDesde.Location = new System.Drawing.Point(60, 20);
            this.txtVigenciaDesde.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVigenciaDesde.Mask = "00/00/0000";
            this.txtVigenciaDesde.Name = "txtVigenciaDesde";
            this.txtVigenciaDesde.Size = new System.Drawing.Size(163, 25);
            this.txtVigenciaDesde.TabIndex = 12;
            // 
            // lblTotalCursos
            // 
            this.lblTotalCursos.AutoSize = true;
            this.lblTotalCursos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalCursos.Location = new System.Drawing.Point(19, 370);
            this.lblTotalCursos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCursos.Name = "lblTotalCursos";
            this.lblTotalCursos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalCursos.Size = new System.Drawing.Size(38, 19);
            this.lblTotalCursos.TabIndex = 14;
            this.lblTotalCursos.Text = "Total";
            this.lblTotalCursos.Visible = false;
            // 
            // cboCategorias
            // 
            this.cboCategorias.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(96, 72);
            this.cboCategorias.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(163, 25);
            this.cboCategorias.TabIndex = 13;
            this.cboCategorias.SelectedIndexChanged += new System.EventHandler(this.cboCategorias_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::BugTracker_TPI.Properties.Resources.borrar;
            this.btnEliminar.Location = new System.Drawing.Point(517, 387);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 60);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Image = global::BugTracker_TPI.Properties.Resources.editar;
            this.btnModificar.Location = new System.Drawing.Point(449, 387);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(64, 60);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::BugTracker_TPI.Properties.Resources.agregar_archivo;
            this.btnNuevo.Location = new System.Drawing.Point(381, 387);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(64, 60);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = " ";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnConsultar.Location = new System.Drawing.Point(478, 126);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(87, 31);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // checkDadosDeBaja
            // 
            this.checkDadosDeBaja.AutoSize = true;
            this.checkDadosDeBaja.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkDadosDeBaja.Location = new System.Drawing.Point(19, 134);
            this.checkDadosDeBaja.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkDadosDeBaja.Name = "checkDadosDeBaja";
            this.checkDadosDeBaja.Size = new System.Drawing.Size(154, 23);
            this.checkDadosDeBaja.TabIndex = 7;
            this.checkDadosDeBaja.Text = "Incluir dados de baja";
            this.checkDadosDeBaja.UseVisualStyleBackColor = true;
            this.checkDadosDeBaja.CheckedChanged += new System.EventHandler(this.checkBaja_CheckedChanged);
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(608, 480);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormCursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.FormCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.CheckBox checkDadosDeBaja;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.MaskedTextBox txtVigenciaDesde;
        private System.Windows.Forms.ComboBox cboCategorias;
        private System.Windows.Forms.Label lblTotalCursos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtVigenciaHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}