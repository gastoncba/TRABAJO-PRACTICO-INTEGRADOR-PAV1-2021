
namespace BugTracker_TPI.Interfaz.CursadoAvances
{
    partial class frmCursado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCursado));
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.btnAgregarAvance = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSacarAvance = new System.Windows.Forms.Button();
            this.dgvAvances = new System.Windows.Forms.DataGridView();
            this.inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPorc = new System.Windows.Forms.TextBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.txtFinAvance = new System.Windows.Forms.MaskedTextBox();
            this.lblFin = new System.Windows.Forms.Label();
            this.txtInicioAvance = new System.Windows.Forms.MaskedTextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaFin = new System.Windows.Forms.MaskedTextBox();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvances)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrincipal.Location = new System.Drawing.Point(154, 8);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(127, 21);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Nuevo Cursado";
            // 
            // btnAgregarAvance
            // 
            this.btnAgregarAvance.Location = new System.Drawing.Point(175, 54);
            this.btnAgregarAvance.Name = "btnAgregarAvance";
            this.btnAgregarAvance.Size = new System.Drawing.Size(99, 20);
            this.btnAgregarAvance.TabIndex = 2;
            this.btnAgregarAvance.Text = "Agregar Avance";
            this.btnAgregarAvance.UseVisualStyleBackColor = true;
            this.btnAgregarAvance.Click += new System.EventHandler(this.btnAgregarAvance_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(131, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(131, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Curso";
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(195, 71);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(86, 21);
            this.cboCurso.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSacarAvance);
            this.groupBox1.Controls.Add(this.dgvAvances);
            this.groupBox1.Controls.Add(this.txtPorc);
            this.groupBox1.Controls.Add(this.lblPorcentaje);
            this.groupBox1.Controls.Add(this.txtFinAvance);
            this.groupBox1.Controls.Add(this.lblFin);
            this.groupBox1.Controls.Add(this.txtInicioAvance);
            this.groupBox1.Controls.Add(this.lblInicio);
            this.groupBox1.Controls.Add(this.btnAgregarAvance);
            this.groupBox1.Location = new System.Drawing.Point(33, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 253);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avances";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "%";
            // 
            // btnSacarAvance
            // 
            this.btnSacarAvance.Enabled = false;
            this.btnSacarAvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacarAvance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSacarAvance.Image = ((System.Drawing.Image)(resources.GetObject("btnSacarAvance.Image")));
            this.btnSacarAvance.Location = new System.Drawing.Point(272, 214);
            this.btnSacarAvance.Name = "btnSacarAvance";
            this.btnSacarAvance.Size = new System.Drawing.Size(33, 25);
            this.btnSacarAvance.TabIndex = 10;
            this.btnSacarAvance.UseVisualStyleBackColor = true;
            this.btnSacarAvance.Click += new System.EventHandler(this.btnSacarAvance_Click);
            // 
            // dgvAvances
            // 
            this.dgvAvances.AllowUserToAddRows = false;
            this.dgvAvances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inicio,
            this.fin,
            this.porc});
            this.dgvAvances.Location = new System.Drawing.Point(10, 79);
            this.dgvAvances.Name = "dgvAvances";
            this.dgvAvances.RowTemplate.Height = 25;
            this.dgvAvances.Size = new System.Drawing.Size(295, 130);
            this.dgvAvances.TabIndex = 9;
            this.dgvAvances.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvances_CellClick);
            // 
            // inicio
            // 
            this.inicio.DataPropertyName = "Inicio";
            this.inicio.HeaderText = "Inicio";
            this.inicio.Name = "inicio";
            // 
            // fin
            // 
            this.fin.DataPropertyName = "Fin";
            this.fin.HeaderText = "Fin";
            this.fin.Name = "fin";
            // 
            // porc
            // 
            this.porc.DataPropertyName = "Porcentaje";
            this.porc.HeaderText = "Porcentaje";
            this.porc.Name = "porc";
            // 
            // txtPorc
            // 
            this.txtPorc.Location = new System.Drawing.Point(69, 54);
            this.txtPorc.Name = "txtPorc";
            this.txtPorc.Size = new System.Drawing.Size(62, 20);
            this.txtPorc.TabIndex = 8;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(10, 59);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(58, 13);
            this.lblPorcentaje.TabIndex = 7;
            this.lblPorcentaje.Text = "Porcentaje";
            // 
            // txtFinAvance
            // 
            this.txtFinAvance.Location = new System.Drawing.Point(175, 18);
            this.txtFinAvance.Mask = "00/00/0000";
            this.txtFinAvance.Name = "txtFinAvance";
            this.txtFinAvance.Size = new System.Drawing.Size(99, 20);
            this.txtFinAvance.TabIndex = 6;
            this.txtFinAvance.ValidatingType = typeof(System.DateTime);
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(150, 23);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(21, 13);
            this.lblFin.TabIndex = 5;
            this.lblFin.Text = "Fin";
            // 
            // txtInicioAvance
            // 
            this.txtInicioAvance.Location = new System.Drawing.Point(69, 18);
            this.txtInicioAvance.Mask = "00/00/0000";
            this.txtInicioAvance.Name = "txtInicioAvance";
            this.txtInicioAvance.Size = new System.Drawing.Size(62, 20);
            this.txtInicioAvance.TabIndex = 4;
            this.txtInicioAvance.ValidatingType = typeof(System.DateTime);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.ForeColor = System.Drawing.Color.Black;
            this.lblInicio.Location = new System.Drawing.Point(23, 23);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(32, 13);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Inicio";
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAceptar.Location = new System.Drawing.Point(33, 502);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(70, 22);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(118, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Puntuacion";
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Location = new System.Drawing.Point(195, 107);
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(86, 20);
            this.txtPuntuacion.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Observaciones";
            // 
            // txtObser
            // 
            this.txtObser.Location = new System.Drawing.Point(195, 144);
            this.txtObser.Name = "txtObser";
            this.txtObser.Size = new System.Drawing.Size(86, 20);
            this.txtObser.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha Inicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha Fin";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(195, 179);
            this.txtFechaInicio.Mask = "00/00/0000";
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(86, 20);
            this.txtFechaInicio.TabIndex = 15;
            this.txtFechaInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(195, 211);
            this.txtFechaFin.Mask = "00/00/0000";
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(86, 20);
            this.txtFechaFin.TabIndex = 16;
            this.txtFechaFin.ValidatingType = typeof(System.DateTime);
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(195, 39);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(86, 21);
            this.cboUsuarios.TabIndex = 17;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(107, 503);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 21);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCursado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(399, 528);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cboUsuarios);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtObser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPuntuacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCursado";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmAvances_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Button btnAgregarAvance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtFinAvance;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.MaskedTextBox txtInicioAvance;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.TextBox txtPorc;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvAvances;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn porc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPuntuacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtFechaInicio;
        private System.Windows.Forms.MaskedTextBox txtFechaFin;
        private System.Windows.Forms.Button btnSacarAvance;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
    }
}