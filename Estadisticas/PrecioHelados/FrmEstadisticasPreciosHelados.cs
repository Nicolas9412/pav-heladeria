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

namespace Practico.Formularios.Estadisticas.PrecioHelados
{
    public partial class FrmEstadisticasPreciosHelados : Form
    {
        public FrmEstadisticasPreciosHelados()
        {
            InitializeComponent();
        }

        private void FrmEstadisticasPreciosHelados_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            Negocios.Helados helados = new Negocios.Helados();
            tabla = helados.EstadisticasPreciosHelados();
            ReportDataSource data = new ReportDataSource("DatosEstadisticosPreciosHelados", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(data);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
