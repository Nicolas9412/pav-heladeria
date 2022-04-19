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
using Practico.Clases;

namespace Practico.Formularios.Estadisticas.ProveedoresXLocalidad
{
    public partial class FrmEstadisticaProveedoresLocalidad : Form
    {
        public FrmEstadisticaProveedoresLocalidad()
        {
            InitializeComponent();
        }

        private void FrmEstadisticaProveedoresLocalidad_Load(object sender, EventArgs e)
        {

            this.reportViewerProveedoresLocalidad.RefreshReport();
        }

        private void reportViewerProveedoresLocalidad_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            Negocios.Proveedores proveedores = new Negocios.Proveedores();
            tabla = proveedores.EstadisticaProveedoresXLocalidad();

            ReportDataSource ds = new ReportDataSource("EstadisticaPL", tabla);
            reportViewerProveedoresLocalidad.LocalReport.DataSources.Clear();
            reportViewerProveedoresLocalidad.LocalReport.DataSources.Add(ds);
            reportViewerProveedoresLocalidad.LocalReport.Refresh();
            this.reportViewerProveedoresLocalidad.RefreshReport();
        }
    }
}
