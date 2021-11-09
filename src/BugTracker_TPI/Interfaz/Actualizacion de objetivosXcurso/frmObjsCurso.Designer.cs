﻿
namespace BugTracker_TPI.Interfaz.Actualizacion_de_objetivosXcurso
{
    partial class frmObjsCurso
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
            this.cmb_Curso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdObjsCurso = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.Cursos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Objetivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdObjsCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Curso
            // 
            this.cmb_Curso.FormattingEnabled = true;
            this.cmb_Curso.Location = new System.Drawing.Point(220, 46);
            this.cmb_Curso.Name = "cmb_Curso";
            this.cmb_Curso.Size = new System.Drawing.Size(244, 28);
            this.cmb_Curso.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione un curso:";
            // 
            // grdObjsCurso
            // 
            this.grdObjsCurso.AllowUserToAddRows = false;
            this.grdObjsCurso.AllowUserToDeleteRows = false;
            this.grdObjsCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdObjsCurso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdObjsCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdObjsCurso.Location = new System.Drawing.Point(43, 104);
            this.grdObjsCurso.Name = "grdObjsCurso";
            this.grdObjsCurso.RowHeadersWidth = 51;
            this.grdObjsCurso.RowTemplate.Height = 29;
            this.grdObjsCurso.Size = new System.Drawing.Size(531, 188);
            this.grdObjsCurso.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.Location = new System.Drawing.Point(480, 46);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(94, 29);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::BugTracker_TPI.Properties.Resources.agregar_archivo;
            this.btnAgregar.Location = new System.Drawing.Point(50, 323);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 76);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Image = global::BugTracker_TPI.Properties.Resources.editar;
            this.btnModificar.Location = new System.Drawing.Point(172, 322);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 77);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::BugTracker_TPI.Properties.Resources.borrar;
            this.btnEliminar.Location = new System.Drawing.Point(297, 322);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 77);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Cursos
            // 
            this.Cursos.DataPropertyName = "Cursos";
            this.Cursos.HeaderText = "Curso";
            this.Cursos.MinimumWidth = 6;
            this.Cursos.Name = "Cursos";
            this.Cursos.Width = 125;
            // 
            // Objetivos
            // 
            this.Objetivos.DataPropertyName = "Objetivos";
            this.Objetivos.HeaderText = "Objetivo";
            this.Objetivos.MinimumWidth = 6;
            this.Objetivos.Name = "Objetivos";
            this.Objetivos.Width = 125;
            // 
            // frmObjsCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(613, 431);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grdObjsCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Curso);
            this.Name = "frmObjsCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmObjsCurso";
            this.Load += new System.EventHandler(this.frmObjsCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdObjsCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Curso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdObjsCurso;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Objetivos;
    }
}