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
using Practico.Formularios.Abm.Empleados;

namespace Practico.Formularios.Abm.TelefonosEmpleados
{
    public partial class FrmModificarTelefonosEmpleados : Form
    {
        public string nroTelefono { get; set; }
        public string tipoDoc { get; set; }
        public string nroDoc { get; set; }
        public string nombre { get; set; }


        public FrmModificarTelefonosEmpleados()
        {
            InitializeComponent();
        }

        private void FrmModificarTelefonosEmpleados_Load(object sender, EventArgs e)
        {
            lblTipo.TabStop = false;
            lblTelefono.TabStop = false;
            lblDocumento.TabStop = false;
            CargarComboNombre();
            CargarCampos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.TelefonosEmpleados telefonosEmpleados = new Negocios.TelefonosEmpleados();
                if (telefonosEmpleados.ModificarTelefono(long.Parse(txtTelefono.Text), Int32.Parse(cmbTipo.SelectedValue.ToString()),
                    cmbDocumento.SelectedValue.ToString())
                    == Negocios.TelefonosEmpleados.Respuesta.validacionCorrecta)
                {
                    MessageBox.Show("Modificado correctamente!", "Informacion",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    CargarCampos();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error...", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
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

        private void CargarCampos()
        {
            Negocios.TelefonosEmpleados telefonosEmpleados = new Negocios.TelefonosEmpleados();
            DataTable tabla = telefonosEmpleados.RecuperarTelefono(long.Parse(nroTelefono));

            tipoDoc = tabla.Rows[0]["tipoDocEmpleado"].ToString();
            nroDoc = tabla.Rows[0]["nroDocEmpleado"].ToString();
            nombre = tabla.Rows[0]["nombre"].ToString();

            cmbNombre.SelectedValue = nombre;
            cmbTipo.SelectedValue = tipoDoc;
            cmbDocumento.SelectedValue = nroDoc;
            txtTelefono.Text = nroTelefono;
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            txtTelefono.Select(0,0);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaEmpleados altaEmpleados = new FrmAltaEmpleados();
            altaEmpleados.ShowDialog();
            CargarComboNombre();
        }
    }
}
