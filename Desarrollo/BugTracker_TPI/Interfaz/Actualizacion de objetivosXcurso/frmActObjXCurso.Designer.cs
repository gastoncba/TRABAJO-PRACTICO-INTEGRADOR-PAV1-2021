
namespace BugTracker_TPI.Interfaz.Actualizacion_de_objetivosXcurso
{
    partial class frmActObjXCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActObjXCurso));
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.cmbObjetivos = new System.Windows.Forms.ComboBox();
            this.grdObjCurso = new System.Windows.Forms.DataGridView();
            this.nombre_corto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.agregarObjetivoCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.btnCerrarFormA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdObjCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCursos
            // 
            this.cmbCursos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Location = new System.Drawing.Point(161, 25);
            this.cmbCursos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(148, 25);
            this.cmbCursos.TabIndex = 0;
            // 
            // cmbObjetivos
            // 
            this.cmbObjetivos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbObjetivos.FormattingEnabled = true;
            this.cmbObjetivos.Location = new System.Drawing.Point(161, 58);
            this.cmbObjetivos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbObjetivos.Name = "cmbObjetivos";
            this.cmbObjetivos.Size = new System.Drawing.Size(148, 25);
            this.cmbObjetivos.TabIndex = 1;
            // 
            // grdObjCurso
            // 
            this.grdObjCurso.AllowUserToAddRows = false;
            this.grdObjCurso.AllowUserToDeleteRows = false;
            this.grdObjCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdObjCurso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdObjCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdObjCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_corto});
            this.grdObjCurso.Location = new System.Drawing.Point(16, 100);
            this.grdObjCurso.Margin = new System.Windows.Forms.Padding(2);
            this.grdObjCurso.Name = "grdObjCurso";
            this.grdObjCurso.RowHeadersWidth = 51;
            this.grdObjCurso.RowTemplate.Height = 29;
            this.grdObjCurso.Size = new System.Drawing.Size(432, 122);
            this.grdObjCurso.TabIndex = 2;
            // 
            // nombre_corto
            // 
            this.nombre_corto.DataPropertyName = "Objetivos";
            this.nombre_corto.HeaderText = "Nombre del objetivo";
            this.nombre_corto.MinimumWidth = 6;
            this.nombre_corto.Name = "nombre_corto";
            this.nombre_corto.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(332, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 32);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.agregarObjGrid_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.Location = new System.Drawing.Point(373, 34);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(35, 32);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // agregarObjetivoCurso
            // 
            this.agregarObjetivoCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarObjetivoCurso.Image = global::BugTracker_TPI.Properties.Resources.agregar_archivo;
            this.agregarObjetivoCurso.Location = new System.Drawing.Point(16, 226);
            this.agregarObjetivoCurso.Margin = new System.Windows.Forms.Padding(2);
            this.agregarObjetivoCurso.Name = "agregarObjetivoCurso";
            this.agregarObjetivoCurso.Size = new System.Drawing.Size(56, 57);
            this.agregarObjetivoCurso.TabIndex = 6;
            this.agregarObjetivoCurso.UseVisualStyleBackColor = true;
            this.agregarObjetivoCurso.Click += new System.EventHandler(this.agregarObjetivoCurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione un curso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleccione el objetivo:";
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarTodo.Image")));
            this.btnEliminarTodo.Location = new System.Drawing.Point(412, 34);
            this.btnEliminarTodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(36, 32);
            this.btnEliminarTodo.TabIndex = 9;
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click_1);
            // 
            // btnCerrarFormA
            // 
            this.btnCerrarFormA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCerrarFormA.Location = new System.Drawing.Point(378, 249);
            this.btnCerrarFormA.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarFormA.Name = "btnCerrarFormA";
            this.btnCerrarFormA.Size = new System.Drawing.Size(70, 27);
            this.btnCerrarFormA.TabIndex = 10;
            this.btnCerrarFormA.Text = "Cerrar";
            this.btnCerrarFormA.UseVisualStyleBackColor = true;
            this.btnCerrarFormA.Click += new System.EventHandler(this.btnCerrarFormA_Click);
            // 
            // frmActObjXCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(466, 291);
            this.Controls.Add(this.btnCerrarFormA);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agregarObjetivoCurso);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdObjCurso);
            this.Controls.Add(this.cmbObjetivos);
            this.Controls.Add(this.cmbCursos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmActObjXCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar objetivos de curso";
            this.Load += new System.EventHandler(this.frmActObjXCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdObjCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbObjetivos;
        private System.Windows.Forms.DataGridView grdObjCurso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button agregarObjetivoCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarTodo;
        public System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_corto;
        private System.Windows.Forms.Button btnCerrarFormA;
    }
}