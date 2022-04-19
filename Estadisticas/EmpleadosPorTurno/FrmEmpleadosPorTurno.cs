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

namespace Practico.Formularios.Estadisticas.EmpleadosPorTurno
{
    public partial class FrmEmpleadosPorTurno : Form
    {
        Empleados empleados = new Empleados();
        DataTable tabla = new DataTable();
        public FrmEmpleadosPorTurno()
        {
            InitializeComponent();
        }

        private void FrmEmpleadosPorTurno_Load(object sender, EventArgs e)
        {
            tabla = empleados.EstadisticaEmpleadosPorTurno();
            ArmarReporte();
        }

        private void ArmarReporte()
        {
            //El nombre de ReportDataSource debe coincidir con el nombre del DataSet de informe
            // en este caso en el informe se llama DataSet1
            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            // Se asigna el nombre y ubicación del reporte que se desea mostrar en el ReportViewer
            //Rv01.LocalReport.ReportEmbeddedResource = "Clase12.Formularios.Reportes.ReporteSueldos.rdlc";
            rpvw.LocalReport.ReportEmbeddedResource = "Practico.Formularios.Estadisticas.EmpleadosPorTurno.EmpleadosPorTurno.rdlc";
            // Se construye el objeto de parametros para ser enviada al reporte que se mostará
            ReportParameter[] parametros = new ReportParameter[1];
            // se asigan el parametro al objeto parametros
            parametros[0] = new ReportParameter("RP01", "Fecha: " + DateTime.Now.ToShortDateString());
            // se le comunica al reporte local dentro del ReportViewer el SetParameters
            rpvw.LocalReport.SetParameters(parametros);
            // se limpia el recurso de datos del reporte local 
            // esto es necesario en caso de emitir varias veces el mismo reporte
            rpvw.LocalReport.DataSources.Clear();
            // se asigna el recurso de datos al reporte local con información del ultimo calculo
            rpvw.LocalReport.DataSources.Add(Datos);
            rpvw.RefreshReport();
        }
    }
}
