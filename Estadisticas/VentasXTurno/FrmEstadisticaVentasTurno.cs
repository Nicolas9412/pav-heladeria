using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Practico.Formularios.Estadisticas.VentasXTurno
{
    public partial class FrmEstadisticaVentasTurno : Form
    {
        public FrmEstadisticaVentasTurno()
        {
            InitializeComponent();
        }

        private void FrmEstadisticaVentasTurno_Load(object sender, EventArgs e)
        {

            this.reportViewerVentasTurno.RefreshReport();
        }

        private void reportViewerVentasTurno_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            Negocios.Ventas ventas = new Negocios.Ventas();
            tabla = ventas.EstadisticaVentasXTurno();

            ReportDataSource ds = new ReportDataSource("EstadisticaVT", tabla);
            reportViewerVentasTurno.LocalReport.DataSources.Clear();
            reportViewerVentasTurno.LocalReport.DataSources.Add(ds);
            reportViewerVentasTurno.LocalReport.Refresh();
            this.reportViewerVentasTurno.RefreshReport();
        }
    }
}
