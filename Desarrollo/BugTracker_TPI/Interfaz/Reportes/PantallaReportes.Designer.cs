
namespace BugTracker_TPI.Interfaz.Reportes
{
    partial class PantallaReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaReportes));
            this.btnReportePorcentajeCursos = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportePorcentajeCursos
            // 
            this.btnReportePorcentajeCursos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReportePorcentajeCursos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportePorcentajeCursos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReportePorcentajeCursos.Image = ((System.Drawing.Image)(resources.GetObject("btnReportePorcentajeCursos.Image")));
            this.btnReportePorcentajeCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportePorcentajeCursos.Location = new System.Drawing.Point(102, 138);
            this.btnReportePorcentajeCursos.Name = "btnReportePorcentajeCursos";
            this.btnReportePorcentajeCursos.Size = new System.Drawing.Size(362, 45);
            this.btnReportePorcentajeCursos.TabIndex = 0;
            this.btnReportePorcentajeCursos.Text = "Porcentaje de Cursos Finalizados ";
            this.btnReportePorcentajeCursos.UseVisualStyleBackColor = false;
            this.btnReportePorcentajeCursos.Click += new System.EventHandler(this.btnReportePorcentajeCursos_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRanking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRanking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRanking.Image = ((System.Drawing.Image)(resources.GetObject("btnRanking.Image")));
            this.btnRanking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRanking.Location = new System.Drawing.Point(102, 87);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(362, 45);
            this.btnRanking.TabIndex = 2;
            this.btnRanking.Text = "Ranking de Cursos con mas Inscriptos";
            this.btnRanking.UseVisualStyleBackColor = false;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnReportePorcentajeCursos);
            this.panel1.Controls.Add(this.btnRanking);
            this.panel1.Location = new System.Drawing.Point(12, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 232);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 68);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(167, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reportes de Bug Tracking System";
            // 
            // PantallaReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(575, 243);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Reportes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportePorcentajeCursos;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}