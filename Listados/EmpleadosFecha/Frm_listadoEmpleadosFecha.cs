using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Practico.Formularios.Listados.EmpleadosFecha
{
    public partial class Frm_listadoEmpleadosFecha : Form
    {
        public Frm_listadoEmpleadosFecha()
        {
            InitializeComponent();
        }

        private void Frm_listadoEmpleadosFecha_Load(object sender, EventArgs e)
        {

            this.reportViewerEmpleadosFecha.RefreshReport();
        }

        private void reportViewerEmpleadosFecha_Load(object sender, EventArgs e)
        {
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day.ToString();
            CargarListadoEmpleadosFecha(year, month, day);
        }

        private void CargarListadoEmpleadosFecha(string year, string month, string day)
        {
            DataTable tabla = new DataTable();
            Negocios.Empleados empleados = new Negocios.Empleados();
            tabla = empleados.ListadoEmpleadosFecha(year, month, day);

            ReportDataSource ds = new ReportDataSource("DatosIngreso", tabla);
            reportViewerEmpleadosFecha.LocalReport.DataSources.Clear();
            reportViewerEmpleadosFecha.LocalReport.DataSources.Add(ds);
            reportViewerEmpleadosFecha.LocalReport.Refresh();
            this.reportViewerEmpleadosFecha.RefreshReport();
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            string year = pckIngreso.Value.Year.ToString();
            string month = pckIngreso.Value.Month.ToString();
            string day = pckIngreso.Value.Day.ToString();
            CargarListadoEmpleadosFecha(year, month, day);
        }
    }
}
