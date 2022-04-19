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
using Practico.Formularios.Abm.Proveedores;

namespace Practico.Formularios.Abm.TelefonosEmpleados
{
    public partial class FrmAltaTelefonosEmpleados : Form
    {
        public FrmAltaTelefonosEmpleados()
        {
            InitializeComponent();
        }

        private void FrmAltaTelefonosEmpleados_Load(object sender, EventArgs e)
        {
            lblTipo.TabStop = false;
            lblTelefono.TabStop = false;
            lblDocumento.TabStop = false;
            CargarComboNombre();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.TelefonosEmpleados telefonosEmpleados = new Negocios.TelefonosEmpleados();
                if (telefonosEmpleados.InsertarTelefono(long.Parse(txtTelefono.Text), Int32.Parse(cmbTipo.SelectedValue.ToString()),
                    cmbDocumento.SelectedValue.ToString())
                    == Negocios.TelefonosEmpleados.Respuesta.validacionCorrecta)
                {
                    MessageBox.Show("Ingresado correctamente!", "Informacion",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error...", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void LimpiarCampos()
        {
            txtTelefono.Text = "";
            cmbDocumento.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            cmbNombre.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarComboTipo() 
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT DISTINCT TD.* FROM Empleados E JOIN TiposDocumento TD ON (E.tipoDoc = TD.tipoDocumento)"
                         + "WHERE nombre LIKE '%" + cmbNombre.SelectedValue + "%'";
            cmbTipo.DisplayMember = "descripcion";
            cmbTipo.ValueMember = "tipoDocumento";
            cmbTipo.DataSource = baseDatos.Consulta(sql);
        }

        public void CargarComboDocumento() 
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT E.* FROM Empleados E WHERE tipoDoc LIKE '%" + cmbTipo.SelectedValue + "%'"
                         + "AND nombre LIKE '%" + cmbNombre.SelectedValue + "%'";
            cmbDocumento.ValueMember = "nroDoc";
            cmbDocumento.DisplayMember = "nroDoc";
            cmbDocumento.DataSource = baseDatos.Consulta(sql);
        }



        private void CargarComboNombre()
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT DISTINCT E.nombre FROM Empleados E ";
            cmbNombre.ValueMember = "nombre";
            cmbNombre.DisplayMember = "nombre";
            cmbNombre.DataSource = baseDatos.Consulta(sql);
        }

        private void cmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarComboDocumento();
        }


        private void cmbNombre_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarComboTipo();
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            txtTelefono.Select(0,0);
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FrmAltaProveedores altaProveedores = new FrmAltaProveedores();
            altaProveedores.ShowDialog();
            CargarComboNombre();
        }
    }
}
