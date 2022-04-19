using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Clases;
using Microsoft.Reporting.WinForms;
using Practico.Negocios;

namespace Practico.Formularios.Estadisticas.CantidadComprasProveedores
{
    public partial class FrmCantidadComprasProveedores : Form
    {
        Compras compras = new Compras();
        DataTable tabla = new DataTable();
        private string restriccion = "";

        public FrmCantidadComprasProveedores()
        {
            InitializeComponent();
        }

        private void FrmCantidadComprasProveedores_Load(object sender, EventArgs e)
        {
            CargarFecha();
        }

        private void CargarFecha()
        {
            BaseDatos baseDatos = new BaseDatos();
            string fecha = baseDatos.Fecha();

            pckHasta.MaxDate = DateTime.Parse(fecha);
            pckDesde.MaxDate = DateTime.Parse(fecha);

            pckDesde.Format = DateTimePickerFormat.Short;
            pckHasta.Format = DateTimePickerFormat.Short;

            pckDesde.Value = DateTime.Parse("01/01/" + DateTime.Now.Year);
            pckHasta.Value = DateTime.Parse(fecha);

            pckDesde.Enabled = true;
            pckHasta.Enabled = true;
        }

        private void ArmarReporte()
        {
            //El nombre de ReportDataSource debe coincidir con el nombre del DataSet de informe
            // en este caso en el informe se llama DataSet1
            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            // Se asigna el nombre y ubicación del reporte que se desea mostrar en el ReportViewer
            if (chkTodos.Checked == true)
                //Rv01.LocalReport.ReportEmbeddedResource = "Clase12.Formularios.Reportes.ReporteSueldos.rdlc";
                rpvw.LocalReport.ReportEmbeddedResource = "Practico.Formularios.Estadisticas.CantidadComprasProveedores.CantidadComprasProveedores.rdlc";
            else
                rpvw.LocalReport.ReportEmbeddedResource = "Practico.Formularios.Estadisticas.CantidadComprasProveedores.CantidadComprasProveedores.rdlc";

            // Se construye el objeto de parametros para ser enviada al reporte que se mostará
            ReportParameter[] parametros = new ReportParameter[2];
            // se asigan el parametro al objeto parametros
            parametros[0] = new ReportParameter("RP01", "Restringido por: " + restriccion);
            parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Now.ToShortDateString());
            // se le comunica al reporte local dentro del ReportViewer el SetParameters
            rpvw.LocalReport.SetParameters(parametros);
            // se linpia el recurso de datos del reporte local 
            // esto es necesario en caso de emitir varias veces el mismo reporte
            rpvw.LocalReport.DataSources.Clear();
            // se asigna el recurso de datos al reporte local con información del ultimo calculo
            rpvw.LocalReport.DataSources.Add(Datos);
            rpvw.RefreshReport();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                tabla = compras.EstadisticaCantidadComprasProveedor();
                restriccion = "Sin restricción";
                ArmarReporte();
            }
            else
            {
                if (pckDesde.Value <= pckHasta.Value)
                {
                    tabla = compras.EstadisticaCantidadComprasProveedorPeriodo(pckDesde.Value, pckHasta.Value);
                    restriccion = "  Fecha desde: " + pckDesde.Value.ToShortDateString() + "  Fecha hasta: " + pckHasta.Value.ToShortDateString();
                    ArmarReporte();
                }
                else
                {
                    MessageBox.Show("Fechas invalidas!", caption: "Atención",
                        icon: MessageBoxIcon.Exclamation, buttons: MessageBoxButtons.OK);
                    return;
                }
            }
        }
    }
}
