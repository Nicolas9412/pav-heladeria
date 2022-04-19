﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Practico.Clases;
using Practico.Negocios;

namespace Practico.Formularios.Estadisticas.VentasPorHeladosPeriodo
{
    public partial class FrmEstadisticaVentasPorHeladosPeriodo : Form
    {
        Ventas ventas = new Ventas();
        DataTable tabla = new DataTable();
        private string restriccion = "";

        public FrmEstadisticaVentasPorHeladosPeriodo()
        {
            InitializeComponent();
        }

        private void FrmVentasPorHeladosPeriodo_Load(object sender, EventArgs e)
        {
            CargarFecha();
            this.rpvw.RefreshReport();
            this.rpvw.RefreshReport();
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

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                chkTodos.Checked = false;
            }
            else
            {
                chkTodos.Checked = true;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

           
            if (chkTodos.Checked)
            {
                tabla = ventas.EstadisticaTotalesHelados();
                restriccion = "Sin restricción";
                ArmarReporte();
            }
            else
            {
                if (pckDesde.Value <= pckHasta.Value)
                {
                    tabla = ventas.EstadisticaTotalesHeladosPeriodo(pckDesde.Value, pckHasta.Value);
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


        private void ArmarReporte()
        {
            //El nombre de ReportDataSource debe coincidir con el nombre del DataSet de informe
            // en este caso en el informe se llama DataSet1
            ReportDataSource Datos = new ReportDataSource("DatosTotalesHelados", tabla);
            // Se asigna el nombre y ubicación del reporte que se desea mostrar en el ReportViewer
            if (chkTodos.Checked == true)
                //Rv01.LocalReport.ReportEmbeddedResource = "Clase12.Formularios.Reportes.ReporteSueldos.rdlc";
                rpvw.LocalReport.ReportEmbeddedResource = "Practico.Formularios.Estadisticas.VentasPorHeladosPeriodo.EstadisticaTotalesPorHelados.rdlc";
            else
                rpvw.LocalReport.ReportEmbeddedResource = "Practico.Formularios.Estadisticas.VentasPorHeladosPeriodo.EstadisticaTotalesPorHelados.rdlc";

            // Se construye el objeto de parametros para ser enviada al reporte que se mostará
            ReportParameter[] parametros = new ReportParameter[2];
            // se asigan el parametro al objeto parametros
            parametros[0] = new ReportParameter("restriccion", "Restringido por: " + restriccion);
            parametros[1] = new ReportParameter("fecha", DateTime.Now.ToShortDateString());
            // se le comunica al reporte local dentro del ReportViewer el SetParameters
            rpvw.LocalReport.SetParameters(parametros);
            // se linpia el recurso de datos del reporte local 
            // esto es necesario en caso de emitir varias veces el mismo reporte
            rpvw.LocalReport.DataSources.Clear();
            // se asigna el recurso de datos al reporte local con información del ultimo calculo
            rpvw.LocalReport.DataSources.Add(Datos);
            rpvw.RefreshReport();

        }
    }
}
