using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Formularios.Estadisticas.CantidadVentasEmpleados;
using Practico.Formularios.Estadisticas.ProveedoresXLocalidad;
using Practico.Formularios.Estadisticas.VentasPorHeladosPeriodo;
using Practico.Formularios.Estadisticas.VentasXTurno;
using Practico.Formularios.Estadisticas.CantidadComprasProveedores;
using Practico.Formularios.Estadisticas.EmpleadosPorTurno;
using Practico.Formularios.Estadisticas.CantidadBarriosLocalidad;
using Practico.Formularios.Estadisticas.CantidadEmpleadosBarrio;
using Practico.Formularios.Estadisticas.PrecioHelados;
using Practico.Formularios.Estadisticas.StockHeladosEspeciales;

namespace Practico.Formularios.Presentacion
{
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void abrirFormulario(Form formulario) // usar para abrir CUALQUIER FORMULARIO
        {
            Panel esteFormulario = this.Parent as Panel;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.TopLevel = false;
            formulario.AutoScroll = true;
            esteFormulario.Controls.Add(formulario);
            formulario.Show();
            this.Close();

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmEstadisticaVentasPorHeladosPeriodo());
        }

        private void btnVentasPorEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmEstadisticaCantidadVentasEmpleados());
        }

        private void btn_ProveedoresLocalidad_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmEstadisticaProveedoresLocalidad());
        }

        private void btn_VentasTurno_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmEstadisticaVentasTurno());
        }

        private void btnComprasProveedorPeriodo_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmCantidadComprasProveedores());
        }

        private void btnEmpleadosPorTurno_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmEmpleadosPorTurno());
        }

        private void btnBarrioLocalidad_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmEstadisticaCantidadBarriosLocalidad());
        }

        private void btnEmpleadosXBarrio_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmEstadisticaCantidadEmpleadosBarrio());
        }

        private void btnPreciosHelados_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmEstadisticasPreciosHelados());
        }

        private void btnStockHeladosEspeciales_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmEstadisticasStockHeladosEspeciales());
        }
    }
}
