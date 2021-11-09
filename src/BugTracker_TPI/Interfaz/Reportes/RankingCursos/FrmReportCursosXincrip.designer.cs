
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
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "Cursos";
            // 
            // rpv_cursos
            // 
            this.rpv_cursos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cursosBindingSource;
            this.rpv_cursos.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_cursos.LocalReport.ReportEmbeddedResource = "BugTracker_TPI.Interfaz.Reportes.RankingCursos.Report_CantInscpCursos.rdlc";
            this.rpv_cursos.Location = new System.Drawing.Point(0, 0);
            this.rpv_cursos.Name = "rpv_cursos";
            this.rpv_cursos.ServerReport.BearerToken = null;
            this.rpv_cursos.Size = new System.Drawing.Size(647, 368);
            this.rpv_cursos.TabIndex = 0;
            this.rpv_cursos.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // FrmReportCursosXincrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 368);
            this.Controls.Add(this.rpv_cursos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportCursosXincrip";
            this.Text = "Inscripciones por curso";
            this.Load += new System.EventHandler(this.FrmReportCursosXincrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_cursos;
        private DSReportes DSReportes;
        private DSReportes dSReportes1;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private DSReportesTableAdapters.CursosTableAdapter cursosTableAdapter;
    }
}