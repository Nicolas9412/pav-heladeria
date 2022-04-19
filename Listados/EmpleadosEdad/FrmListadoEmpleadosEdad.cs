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

namespace Practico.Formularios.Listados.EmpleadosEdad
{
    public partial class FrmListadoEmpleadosEdad : Form
    {
        public FrmListadoEmpleadosEdad()
        {
            InitializeComponent();
        }

        
        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void FrmListadoEmpleadosEdad_Load(object sender, EventArgs e)
        {

            this.reportViewer12.RefreshReport();
        }

        private void cargarListado()
        {
            DataTable tabla = new DataTable();
            Negocios.Empleados helados = new Negocios.Empleados();
            tabla = helados.ListadoEmpleadosEdad(txtEdadMaxima.Text);

            ReportDataSource data = new ReportDataSource("DatosEmpleadosEdad", tabla);
            reportViewer12.LocalReport.DataSources.Clear();
            reportViewer12.LocalReport.DataSources.Add(data);
            reportViewer12.LocalReport.Refresh();
            this.reportViewer12.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarListado();

        }
    }
}
