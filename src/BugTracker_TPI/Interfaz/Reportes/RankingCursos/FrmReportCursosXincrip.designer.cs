
namespace BugTracker_TPI.Interfaz.Reportes.RankingCursos
{
    partial class FrmReportCursosXincrip
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportCursosXincrip));
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpv_cursos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbTop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "Cursos";
            // 
            // rpv_cursos
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cursosBindingSource;
            this.rpv_cursos.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_cursos.LocalReport.ReportEmbeddedResource = "BugTracker_TPI.Interfaz.Reportes.RankingCursos.Report_CantInscpCursos.rdlc";
            this.rpv_cursos.Location = new System.Drawing.Point(0, 39);
            this.rpv_cursos.Name = "rpv_cursos";
            this.rpv_cursos.ServerReport.BearerToken = null;
            this.rpv_cursos.Size = new System.Drawing.Size(647, 329);
            this.rpv_cursos.TabIndex = 0;
            this.rpv_cursos.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // cmbTop
            // 
            this.cmbTop.FormattingEnabled = true;
            this.cmbTop.Items.AddRange(new object[] {
            "Top 3",
            "Top 5",
            "Top 10"});
            this.cmbTop.Location = new System.Drawing.Point(514, 12);
            this.cmbTop.Name = "cmbTop";
            this.cmbTop.Size = new System.Drawing.Size(121, 21);
            this.cmbTop.TabIndex = 1;
            this.cmbTop.SelectedIndexChanged += new System.EventHandler(this.cmbTop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ver:";
            // 
            // FrmReportCursosXincrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(647, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTop);
            this.Controls.Add(this.rpv_cursos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportCursosXincrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inscripciones por curso";
            this.Load += new System.EventHandler(this.FrmReportCursosXincrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_cursos;
        private DSReportes DSReportes;
        private DSReportes dSReportes1;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private DSReportesTableAdapters.CursosTableAdapter cursosTableAdapter;
        private System.Windows.Forms.ComboBox cmbTop;
        private System.Windows.Forms.Label label1;
    }
}