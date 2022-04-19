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

namespace Practico.Formularios.Listados.Helados
{
    public partial class FrmListadoHeladosProveedor : Form
    {
        public FrmListadoHeladosProveedor()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            cmbProveedores.Cargar();
            cargarListado();

        }

        private void FrmListadoHelados_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void cargarListado()
        {
            DataTable tabla = new DataTable();
            Negocios.Helados helados = new Negocios.Helados();
            tabla = helados.ListadoHeladosProveedor(cmbProveedores.SelectedValue.ToString());

            ReportDataSource data = new ReportDataSource("DatosHelados", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(data);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbProveedores.SelectedIndex != -1)
            {
                cargarListado();
            }

        }
    }
}
