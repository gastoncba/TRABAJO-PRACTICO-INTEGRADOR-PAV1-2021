
namespace BugTracker_TPI.Interfaz.Actualizacion_de_objetivosXcurso
{
    partial class frmObjCursoME
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_EliminarCurso = new System.Windows.Forms.ComboBox();
            this.cmb_eliminarObj = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.label1.Location = new System.Drawing.Point(69, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.label2.Location = new System.Drawing.Point(58, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Objetivo:";
            // 
            // cmb_EliminarCurso
            // 
            this.cmb_EliminarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_EliminarCurso.FormattingEnabled = true;
            this.cmb_EliminarCurso.Location = new System.Drawing.Point(148, 49);
            this.cmb_EliminarCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_EliminarCurso.Name = "cmb_EliminarCurso";
            this.cmb_EliminarCurso.Size = new System.Drawing.Size(183, 24);
            this.cmb_EliminarCurso.TabIndex = 2;
            // 
            // cmb_eliminarObj
            // 
            this.cmb_eliminarObj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_eliminarObj.FormattingEnabled = true;
            this.cmb_eliminarObj.Location = new System.Drawing.Point(148, 87);
            this.cmb_eliminarObj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_eliminarObj.Name = "cmb_eliminarObj";
            this.cmb_eliminarObj.Size = new System.Drawing.Size(183, 24);
            this.cmb_eliminarObj.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.Location = new System.Drawing.Point(100, 125);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAceptarBM_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button2.Location = new System.Drawing.Point(220, 125);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cerrarFormBM_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.Location = new System.Drawing.Point(58, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // frmObjCursoME
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 177);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_eliminarObj);
            this.Controls.Add(this.cmb_EliminarCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmObjCursoME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmObjCursoME";
            this.Load += new System.EventHandler(this.frmObjCursoME_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_EliminarCurso;
        private System.Windows.Forms.ComboBox cmb_eliminarObj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}