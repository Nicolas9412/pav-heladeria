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

namespace Practico.Formularios.Estadisticas.CantidadBarriosLocalidad
{
    public partial class FrmEstadisticaCantidadBarriosLocalidad : Form
    {
        public FrmEstadisticaCantidadBarriosLocalidad()
        {
            InitializeComponent();
        }

        private void FrmEstadisticaCantidadBarriosLocalidad_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            Negocios.Barrios barrio = new Negocios.Barrios();
            tabla = barrio.EstadisticaBarrioXLocalidad();

            ReportDataSource datos = new ReportDataSource("DatosBarriosLocalidad", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
