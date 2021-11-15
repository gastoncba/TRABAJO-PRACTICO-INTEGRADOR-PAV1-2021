
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
            this.groupAvances = new System.Windows.Forms.GroupBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaFin = new System.Windows.Forms.MaskedTextBox();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblReqUser = new System.Windows.Forms.Label();
            this.lblReqCurso = new System.Windows.Forms.Label();
            this.lblReqInicio = new System.Windows.Forms.Label();
            this.lblReqFin = new System.Windows.Forms.Label();
            this.txtObser = new System.Windows.Forms.RichTextBox();
            this.groupAvances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvances)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(154, 9);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(116, 20);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Nuevo Cursado";
            // 
            // btnAgregarAvance
            // 
            this.btnAgregarAvance.Location = new System.Drawing.Point(224, 60);
            this.btnAgregarAvance.Name = "btnAgregarAvance";
            this.btnAgregarAvance.Size = new System.Drawing.Size(111, 27);
            this.btnAgregarAvance.TabIndex = 2;
            this.btnAgregarAvance.Text = "Agregar Avance";
            this.btnAgregarAvance.UseVisualStyleBackColor = true;
            this.btnAgregarAvance.Click += new System.EventHandler(this.btnAgregarAvance_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(88, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(88, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Curso:";
            // 
            // cboCurso
            // 
            this.cboCurso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(198, 78);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(178, 25);
            this.cboCurso.TabIndex = 6;
            // 
            // groupAvances
            // 
            this.groupAvances.Controls.Add(this.label1);
            this.groupAvances.Controls.Add(this.btnSacarAvance);
            this.groupAvances.Controls.Add(this.dgvAvances);
            this.groupAvances.Controls.Add(this.txtPorc);
            this.groupAvances.Controls.Add(this.lblPorcentaje);
            this.groupAvances.Controls.Add(this.txtFinAvance);
            this.groupAvances.Controls.Add(this.lblFin);
            this.groupAvances.Controls.Add(this.txtInicioAvance);
            this.groupAvances.Controls.Add(this.lblInicio);
            this.groupAvances.Controls.Add(this.btnAgregarAvance);
            this.groupAvances.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupAvances.Location = new System.Drawing.Point(33, 299);
            this.groupAvances.Name = "groupAvances";
            this.groupAvances.Size = new System.Drawing.Size(393, 274);
            this.groupAvances.TabIndex = 7;
            this.groupAvances.TabStop = false;
            this.groupAvances.Text = "Avances";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "%";
            // 
            // btnSacarAvance
            // 
            this.btnSacarAvance.Enabled = false;
            this.btnSacarAvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacarAvance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSacarAvance.Image = ((System.Drawing.Image)(resources.GetObject("btnSacarAvance.Image")));
            this.btnSacarAvance.Location = new System.Drawing.Point(329, 243);
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
            this.dgvAvances.Location = new System.Drawing.Point(22, 107);
            this.dgvAvances.Name = "dgvAvances";
            this.dgvAvances.RowTemplate.Height = 25;
            this.dgvAvances.Size = new System.Drawing.Size(340, 130);
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
            this.txtPorc.Location = new System.Drawing.Point(273, 15);
            this.txtPorc.Name = "txtPorc";
            this.txtPorc.Size = new System.Drawing.Size(62, 25);
            this.txtPorc.TabIndex = 8;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(190, 18);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(75, 19);
            this.lblPorcentaje.TabIndex = 7;
            this.lblPorcentaje.Text = "Porcentaje:";
            // 
            // txtFinAvance
            // 
            this.txtFinAvance.Location = new System.Drawing.Point(69, 60);
            this.txtFinAvance.Mask = "00/00/0000";
            this.txtFinAvance.Name = "txtFinAvance";
            this.txtFinAvance.Size = new System.Drawing.Size(78, 25);
            this.txtFinAvance.TabIndex = 6;
            this.txtFinAvance.ValidatingType = typeof(System.DateTime);
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(23, 60);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(30, 19);
            this.lblFin.TabIndex = 5;
            this.lblFin.Text = "Fin:";
            // 
            // txtInicioAvance
            // 
            this.txtInicioAvance.Location = new System.Drawing.Point(69, 18);
            this.txtInicioAvance.Mask = "00/00/0000";
            this.txtInicioAvance.Name = "txtInicioAvance";
            this.txtInicioAvance.Size = new System.Drawing.Size(78, 25);
            this.txtInicioAvance.TabIndex = 4;
            this.txtInicioAvance.ValidatingType = typeof(System.DateTime);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.ForeColor = System.Drawing.Color.Black;
            this.lblInicio.Location = new System.Drawing.Point(23, 23);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(44, 19);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Inicio:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAceptar.Location = new System.Drawing.Point(33, 597);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(101, 32);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(87, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Puntuacion:";
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPuntuacion.Location = new System.Drawing.Point(198, 113);
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(178, 25);
            this.txtPuntuacion.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(87, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Observaciones:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(88, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha Inicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(88, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha Fin:";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFechaInicio.Location = new System.Drawing.Point(198, 223);
            this.txtFechaInicio.Mask = "00/00/0000";
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(178, 25);
            this.txtFechaInicio.TabIndex = 15;
            this.txtFechaInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFechaFin.Location = new System.Drawing.Point(198, 255);
            this.txtFechaFin.Mask = "00/00/0000";
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(178, 25);
            this.txtFechaFin.TabIndex = 16;
            this.txtFechaFin.ValidatingType = typeof(System.DateTime);
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(198, 44);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(178, 25);
            this.cboUsuarios.TabIndex = 17;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.Location = new System.Drawing.Point(147, 597);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 32);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblReqUser
            // 
            this.lblReqUser.AutoSize = true;
            this.lblReqUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReqUser.ForeColor = System.Drawing.Color.Red;
            this.lblReqUser.Location = new System.Drawing.Point(71, 53);
            this.lblReqUser.Name = "lblReqUser";
            this.lblReqUser.Size = new System.Drawing.Size(15, 19);
            this.lblReqUser.TabIndex = 19;
            this.lblReqUser.Text = "*";
            // 
            // lblReqCurso
            // 
            this.lblReqCurso.AutoSize = true;
            this.lblReqCurso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReqCurso.ForeColor = System.Drawing.Color.Red;
            this.lblReqCurso.Location = new System.Drawing.Point(71, 84);
            this.lblReqCurso.Name = "lblReqCurso";
            this.lblReqCurso.Size = new System.Drawing.Size(15, 19);
            this.lblReqCurso.TabIndex = 20;
            this.lblReqCurso.Text = "*";
            // 
            // lblReqInicio
            // 
            this.lblReqInicio.AutoSize = true;
            this.lblReqInicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReqInicio.ForeColor = System.Drawing.Color.Red;
            this.lblReqInicio.Location = new System.Drawing.Point(71, 226);
            this.lblReqInicio.Name = "lblReqInicio";
            this.lblReqInicio.Size = new System.Drawing.Size(15, 19);
            this.lblReqInicio.TabIndex = 23;
            this.lblReqInicio.Text = "*";
            // 
            // lblReqFin
            // 
            this.lblReqFin.AutoSize = true;
            this.lblReqFin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReqFin.ForeColor = System.Drawing.Color.Red;
            this.lblReqFin.Location = new System.Drawing.Point(71, 261);
            this.lblReqFin.Name = "lblReqFin";
            this.lblReqFin.Size = new System.Drawing.Size(15, 19);
            this.lblReqFin.TabIndex = 24;
            this.lblReqFin.Text = "*";
            // 
            // txtObser
            // 
            this.txtObser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtObser.Location = new System.Drawing.Point(198, 152);
            this.txtObser.Name = "txtObser";
            this.txtObser.Size = new System.Drawing.Size(178, 55);
            this.txtObser.TabIndex = 25;
            this.txtObser.Text = "";
            // 
            // frmCursado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(437, 636);
            this.Controls.Add(this.txtObser);
            this.Controls.Add(this.lblReqFin);
            this.Controls.Add(this.lblReqInicio);
            this.Controls.Add(this.lblReqCurso);
            this.Controls.Add(this.lblReqUser);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cboUsuarios);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPuntuacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupAvances);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCursado";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmAvances_Load);
            this.groupAvances.ResumeLayout(false);
            this.groupAvances.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupAvances;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtFechaInicio;
        private System.Windows.Forms.MaskedTextBox txtFechaFin;
        private System.Windows.Forms.Button btnSacarAvance;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblReqUser;
        private System.Windows.Forms.Label lblReqCurso;
        private System.Windows.Forms.Label lblReqInicio;
        private System.Windows.Forms.Label lblReqFin;
        private System.Windows.Forms.RichTextBox txtObser;
    }
}