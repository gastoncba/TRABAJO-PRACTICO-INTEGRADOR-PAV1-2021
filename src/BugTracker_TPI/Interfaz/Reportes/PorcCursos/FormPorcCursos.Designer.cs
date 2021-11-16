
namespace BugTracker_TPI.Interfaz.Reportes.PorcCursos
{
    partial class FormPorcCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPorcCursos));
            this.rpvPorcCurso = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtDesde = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarPorcCursos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpvPorcCurso
            // 
            this.rpvPorcCurso.AutoSize = true;
            this.rpvPorcCurso.LocalReport.ReportEmbeddedResource = "BugTracker_TPI.Interfaz.Reportes.PorcCursos.ReportePorcCursos.rdlc";
            this.rpvPorcCurso.Location = new System.Drawing.Point(0, 75);
            this.rpvPorcCurso.Name = "rpvPorcCurso";
            this.rpvPorcCurso.ServerReport.BearerToken = null;
            this.rpvPorcCurso.Size = new System.Drawing.Size(815, 460);
            this.rpvPorcCurso.TabIndex = 0;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(56, 23);
            this.txtDesde.Mask = "00/00/0000";
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(150, 25);
            this.txtDesde.TabIndex = 1;
            this.txtDesde.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta:";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(286, 22);
            this.txtHasta.Mask = "00/00/0000";
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(150, 25);
            this.txtHasta.TabIndex = 4;
            this.txtHasta.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Desde:";
            // 
            // btnGenerarPorcCursos
            // 
            this.btnGenerarPorcCursos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGenerarPorcCursos.Location = new System.Drawing.Point(665, 19);
            this.btnGenerarPorcCursos.Name = "btnGenerarPorcCursos";
            this.btnGenerarPorcCursos.Size = new System.Drawing.Size(79, 31);
            this.btnGenerarPorcCursos.TabIndex = 6;
            this.btnGenerarPorcCursos.Text = "Generar";
            this.btnGenerarPorcCursos.UseVisualStyleBackColor = true;
            this.btnGenerarPorcCursos.Click += new System.EventHandler(this.btnGenerarPorcCursos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDesde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHasta);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(160, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 66);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodo de vigencia";
            // 
            // FormPorcCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerarPorcCursos);
            this.Controls.Add(this.rpvPorcCurso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPorcCursos";
            this.Text = "Cursos Finalizados";
            this.Load += new System.EventHandler(this.PorcCursos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvPorcCurso;
        private System.Windows.Forms.MaskedTextBox txtDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarPorcCursos;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}