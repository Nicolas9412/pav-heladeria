using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Formularios.Abm;
using Practico.Formularios.Abm.Barrios;
using Practico.Formularios.Abm.Empleados;
using Practico.Formularios.Abm.Frutas;
using Practico.Formularios.Abm.FrutasHeladosEspeciales;
using Practico.Formularios.Abm.Helados;
using Practico.Formularios.Abm.HeladosEspeciales;
using Practico.Formularios.Abm.HeladosHeladosEspeciales;
using Practico.Formularios.Abm.Localidades;
using Practico.Formularios.Abm.Proveedores;
using Practico.Formularios.Abm.ProveedoresHelados;
using Practico.Formularios.Abm.TelefonosEmpleados;
using Practico.Formularios.Abm.Turnos;

namespace Practico.Formularios
{
    public partial class FrmAdministracion : Form
    {
        public FrmAdministracion()
        {
            InitializeComponent();
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmUsuarios());
        }

        private void btnHelados_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmHelados());
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
            FrmEmpleados empleados = new FrmEmpleados();
            abrirFormulario(empleados);

        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmProveedores());
        }
        private void btnProveedoresHelados_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmProveedoresHelados());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmTelefonosEmpleados());
        }

        private void btnLocalidades_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmLocalidades());
        }

        private void btnTipoDoc_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmTipoDocumento());
        }

        private void btnHeladosEspeciales_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmHeladosEspeciales());
        }

        private void btnFrutas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmFrutas());
        }

        private void btnBarrios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmBarrios());
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmTurnos());
        }

        private void FrmAdministracion_Load(object sender, EventArgs e)
        {

        }

        private void btnFrutasHeladosEspeciales_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmFrutasHeladosEspeciales());
        }

        private void btnHeladosHeladosEspeciales_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmHeladosHeladosEspeciales());
        }
    }
}
