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

namespace Practico.Formularios.Estadisticas.CantidadEmpleadosBarrio
{
    public partial class FrmEstadisticaCantidadEmpleadosBarrio : Form
    {
        public FrmEstadisticaCantidadEmpleadosBarrio()
        {
            InitializeComponent();
        }

        private void FrmEstadisticaCantidadEmpleadosBarrio_Load(object sender, EventArgs e)
        {

            this.reportViewerEmpleadosBarrio.RefreshReport();
        }

        private void reportViewerEmpleadosBarrio_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            Negocios.Empleados empleados = new Negocios.Empleados();
            tabla = empleados.EstadisticaEmpleadosXBarrio();

            ReportDataSource datos = new ReportDataSource("DatosEmpleadosBarrio", tabla);
            reportViewerEmpleadosBarrio.LocalReport.DataSources.Clear();
            reportViewerEmpleadosBarrio.LocalReport.DataSources.Add(datos);
            reportViewerEmpleadosBarrio.LocalReport.Refresh();
        }
    }
}
