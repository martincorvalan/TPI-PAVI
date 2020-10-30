using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoPAV.Reporte
{
    public partial class ReporteInforme : Form
    {
        public ReporteInforme()
        {
            InitializeComponent();
        }

        private void ReporteInforme_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            string fechaActual = DateTime.Now.ToString();
            string prfechaVigente = dateTimeVigente.Text;
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("prFechaActual", fechaActual), new ReportParameter("prFechaVigencia", prfechaVigente) });
            DateTime fechaVigente;
            DateTime.TryParse(dateTimeVigente.Text, out fechaVigente);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetCantidadUsuarios", this.cantidadUsuariosCursoBindingSource));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetObjetivosCurso", this.cantidadObjetivosCursoBindingSource));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetPorcentajeAvance", this.porcentajeAvanceBindingSource));
            this.cantidadUsuariosCursoTableAdapter.Fill(this.dataSetReporteInforme.CantidadUsuariosCurso);
            this.cantidadObjetivosCursoTableAdapter.Fill(this.dataSetReporteInforme.CantidadObjetivosCurso, fechaVigente);
            this.porcentajeAvanceTableAdapter.Fill(this.dataSetReporteInforme.PorcentajeAvance);

            reportViewer1.RefreshReport();

        }

        //Metodo para poder mover el formulario sin la barra
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
