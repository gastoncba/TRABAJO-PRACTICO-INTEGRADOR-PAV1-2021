using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker_TPI.Interfaz.Reportes.RankingCursos
{
    public partial class FrmReportCursosXincrip : Form
    {
        public FrmReportCursosXincrip()
        {
            InitializeComponent();
        }

        private void FrmReportCursosXincrip_Load(object sender, EventArgs e)
        {
            cargarReporte();

            this.rpv_cursos.RefreshReport();
        }

        private void cargarReporte()
        {
            string sql_string = "select c.id_curso, c.nombre, count(*) as cant_inscriptos " +
                "from Cursos c inner join UsuariosCurso uc on " +
                "c.id_curso = uc.id_curso " +
                "group by c.id_curso, c.nombre " +
                "order by cant_inscriptos desc";

            rpv_cursos.LocalReport.DataSources.Clear();
            rpv_cursos.LocalReport.DataSources.Add(new ReportDataSource("DSReportes",DataManager.GetInstance().ConsultaSQL(sql_string)));
            rpv_cursos.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
