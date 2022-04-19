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
using Practico.Clases;
using Practico.Negocios;

namespace Practico.Formularios.Listados.EmpleadosLocalidad
{
    public partial class FrmListadoEmpleadosLocalidad : Form
    {
        public FrmListadoEmpleadosLocalidad()
        {
            InitializeComponent();
        }

        private void FrmListadoEmpleadosLocalidad_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            cmbLocalidad.Cargar();
            cargarListado();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbLocalidad.SelectedIndex != -1)
            {
                cargarListado();
            }
            else
            {
                MessageBox.Show("Seleccione un item!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarListado()
        {
            DataTable tabla = new DataTable();
            Empleados empleados = new Empleados();
            tabla = empleados.ListadoEmpleadosLocalidad(cmbLocalidad.SelectedValue.ToString());

            ReportDataSource data = new ReportDataSource("DatosEmpleados", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(data);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
