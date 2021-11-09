using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracker_TPI.Interfaz.Reportes.PorcCursos;
using BugTracker_TPI.Interfaz.Reportes.RankingCursos;

namespace BugTracker_TPI.Interfaz.Reportes
{
    public partial class PantallaReportes : Form
    {
        public PantallaReportes()
        {
            InitializeComponent();
        }

        private void btnReportePorcentajeCursos_Click(object sender, EventArgs e)
        {
            FormPorcCursos frmPorcCursos = new FormPorcCursos();
            frmPorcCursos.ShowDialog();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            FrmReportCursosXincrip frmRanking = new FrmReportCursosXincrip();
            frmRanking.ShowDialog();
        }
    }
}
