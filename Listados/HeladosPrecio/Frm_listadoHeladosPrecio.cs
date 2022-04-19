using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Practico.Clases;
using Practico.Negocios;

namespace Practico.Formularios.Listados.Helados
{
    public partial class Frm_listadoHeladosPrecio : Form
    {
        string Precio; //variable Global
        public Frm_listadoHeladosPrecio()
        {
            InitializeComponent();
        }

        private void Frm_listadoHeladosPrecio_Load(object sender, EventArgs e)
        {
            this.reportViewerHeladosPrecio.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (textBox011BuscarHelado.Text != "")
            {
                Precio = textBox011BuscarHelado.Text;
                CargarListadoHeladoPrecio();
            }
            else
            {
                
                MessageBox.Show("Ingrese un Precio!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Precio = "100000";
                CargarListadoHeladoPrecio();
            }
        }

        private void reportViewerHeladosPrecio_Load(object sender, EventArgs e)
        {
            Precio = "100000";
            CargarListadoHeladoPrecio();
        }
        
        private void CargarListadoHeladoPrecio()
        {
            DataTable tabla = new DataTable();
            Negocios.Helados helados = new Negocios.Helados();
            tabla = helados.ListadoHeladosPrecio(Precio);

            ReportDataSource ds = new ReportDataSource("DatosHelados", tabla);
            reportViewerHeladosPrecio.LocalReport.DataSources.Clear();
            reportViewerHeladosPrecio.LocalReport.DataSources.Add(ds);
            reportViewerHeladosPrecio.LocalReport.Refresh();
            this.reportViewerHeladosPrecio.RefreshReport();
        }
    }
}
