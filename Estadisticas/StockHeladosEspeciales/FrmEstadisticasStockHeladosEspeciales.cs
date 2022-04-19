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

namespace Practico.Formularios.Estadisticas.StockHeladosEspeciales
{
    public partial class FrmEstadisticasStockHeladosEspeciales : Form
    {
        DataTable tabla = new DataTable();

        public FrmEstadisticasStockHeladosEspeciales()
        {
            InitializeComponent();
        }

        private void FrmEstadisticasStockHeladosEspeciales_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
            Negocios.HeladosEspeciales heladosEspeciales = new Negocios.HeladosEspeciales();
            tabla = heladosEspeciales.EstadisticasStockHeladosEspeciales();
            ArmarReporte();            
        }

        private void ArmarReporte()
        {
            //El nombre de ReportDataSource debe coincidir con el nombre del DataSet de informe
            // en este caso en el informe se llama DataSet1
            ReportDataSource Datos = new ReportDataSource("DatosEstadisticosStockHeladosEspeciales", tabla);
            // Se asigna el nombre y ubicación del reporte que se desea mostrar en el ReportViewer
            
                //Rv01.LocalReport.ReportEmbeddedResource = "Clase12.Formularios.Reportes.ReporteSueldos.rdlc";
            reportViewer1.LocalReport.ReportEmbeddedResource = "Practico.Formularios.Estadisticas.StockHeladosEspeciales.EstadisticasStockHeladosEspeciales.rdlc";
            
            

            // Se construye el objeto de parametros para ser enviada al reporte que se mostará
            
            // se asigan el parametro al objeto parametros
      
            // se le comunica al reporte local dentro del ReportViewer el SetParameters
            // se linpia el recurso de datos del reporte local 
            // esto es necesario en caso de emitir varias veces el mismo reporte
            reportViewer1.LocalReport.DataSources.Clear();
            // se asigna el recurso de datos al reporte local con información del ultimo calculo
            reportViewer1.LocalReport.DataSources.Add(Datos);
            reportViewer1.RefreshReport();

        }
    }
        
}
