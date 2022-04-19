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

namespace Practico.Formularios.Listados.HeladosEspecialesPrecio
{
    public partial class FrmListadoHeladosEspecialesPrecio : Form
    {
        public FrmListadoHeladosEspecialesPrecio()
        {
            InitializeComponent();
        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FrmListadoHelados_Load(object sender, EventArgs e)
        {

            this.reportViewer11.RefreshReport();
        }

        private void cargarListado()
        {
            DataTable tabla = new DataTable();
            Negocios.HeladosEspeciales helados = new Negocios.HeladosEspeciales();
            tabla = helados.ListadoHeladosEspecialesPrecio(txtPrecioMaximo.Text);

            ReportDataSource data = new ReportDataSource("DatosHelados", tabla);
            reportViewer11.LocalReport.DataSources.Clear();
            reportViewer11.LocalReport.DataSources.Add(data);
            reportViewer11.LocalReport.Refresh();
            this.reportViewer11.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarListado();
        }
    }
}
