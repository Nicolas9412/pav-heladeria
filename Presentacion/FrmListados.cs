using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Formularios.Listados;
using Practico.Formularios.Listados.Helados;
using Practico.Formularios.Listados.ProveedoresBarrio;
using Practico.Formularios.Listados.EmpleadosLocalidad;
using Practico.Formularios.Listados.EmpleadosFecha;
using Practico.Formularios.Listados.HeladosEspecialesPrecio;
using Practico.Formularios.Listados.EmpleadosEdad;
using Practico.Formularios.Listados.Ventas;
using Practico.Formularios.Listados.Frutas;

namespace Practico.Formularios.Presentacion
{
    public partial class btnHeladosEspPrecio : Form
    {
        public btnHeladosEspPrecio()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmListadoEmpleados());
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

        private void btnHeladosEspeciales_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmListadoHeladosProveedor());
        }

        private void btnProveedoresBarrio_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmListadoProveedoresBarrio());
        }

        private void btnEmpleadosLocalidad_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmListadoEmpleadosLocalidad());
        }

        private void btn_listadoHelxPrec_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Frm_listadoHeladosPrecio());
        }

        private void btn_EmpleadosFecha_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Frm_listadoEmpleadosFecha());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmListadoHeladosEspecialesPrecio());
        }

        private void btnEmpleadosPorEdad_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmListadoEmpleadosEdad());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmListadoVentasEmpleado());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmListadoFrutas());
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
