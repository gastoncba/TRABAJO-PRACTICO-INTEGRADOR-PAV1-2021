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

namespace BugTracker_TPI.Interfaz.Reportes.PorcCursos
{
    public partial class FormPorcCursos : Form
    {
        public FormPorcCursos()
        {
            InitializeComponent();
        }

        private void PorcCursos_Load(object sender, EventArgs e)
        {

            this.rpvPorcCurso.RefreshReport();
        }

        private void btnGenerarPorcCursos_Click(object sender, EventArgs e)
        {
            String consGrafico = string.Concat("select c.nombre, count(distinct uca.id_usuario) as cantidad ",
                                            "from Cursos c inner ",
                                            "join UsuariosCursoAvance uca on c.id_curso = uca.id_curso ",
                                            "where c.fecha_vigencia between @fechaDesde and @fechaHasta ",
                                            "group by c.nombre, uca.id_usuario ",
                                            "having sum(uca.porc_avance) = 100");

            String consTabla = string.Concat("select c.nombre as curso, count(distinct uca.id_usuario) as cantidad ", 
                                            "from Cursos c inner ",
                                            "join UsuariosCursoAvance uca on c.id_curso = uca.id_curso ", 
                                            "where (select sum(A.porc_avance) from UsuariosCursoAvance A where A.id_curso = uca.id_curso AND A.id_usuario = uca.id_usuario) = 100 ",
                                            "and c.fecha_vigencia between @fechaDesde and @fechaHasta ",
                                            "group by c.nombre");

            Dictionary<string, object> parametros = new Dictionary<string, object>();

            DateTime fechaDesde;
            DateTime fechaHasta;

            if (DateTime.TryParse(txtDesde.Text, out fechaDesde) &&
                 DateTime.TryParse(txtHasta.Text, out fechaHasta))
            {
                if(fechaDesde >= fechaHasta)
                {
                    MessageBox.Show("La fecha de inicio del periodo debe ser menor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                parametros.Add("fechaDesde", fechaDesde);
                parametros.Add("fechaHasta", fechaHasta);

                rpvPorcCurso.LocalReport.SetParameters(new ReportParameter[] {
                    new ReportParameter("prDesde", fechaDesde.ToString("dd/MM/yyyy")),
                    new ReportParameter("prHasta", fechaHasta.ToString("dd/MM/yyyy"))
                });

                rpvPorcCurso.LocalReport.DataSources.Clear();
                rpvPorcCurso.LocalReport.DataSources.Add(new ReportDataSource("DSReportePorc", DataManager.GetInstance().ConsultaSQL(consGrafico, parametros)));
                rpvPorcCurso.LocalReport.DataSources.Add(new ReportDataSource("DSCursos", DataManager.GetInstance().ConsultaSQL(consTabla, parametros)));
                rpvPorcCurso.RefreshReport();
            }
        }   
    }
}
