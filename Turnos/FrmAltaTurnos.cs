using Practico.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Formularios.Abm.Empleados;

namespace Practico.Formularios.Abm.Turnos
{
    public partial class FrmAltaTurnos : Form
    {
        public FrmAltaTurnos()
        {
            InitializeComponent();
        }

        private void FrmAltaTurnos_Load(object sender, EventArgs e)
        {
            lblHoraFin.TabStop = false;
            lblHoraInicio.TabStop = false;
            lblNombre.TabStop = false;
            lblNuevo.TabStop = false;
            lblNumeroD.TabStop = false;
            lblTipo.TabStop = false;
            CargarComboNombre();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            cmbDocumento.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
        }


        private void lblNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.Turnos turnos = new Negocios.Turnos();
                if (turnos.InsertarTurno(txtNombre.Text,
                                         pckHoraInicio.Value.ToShortTimeString(),
                                         pckHoraFin.Value.ToShortTimeString(),
                                         cmbDocumento.SelectedValue.ToString(),
                                         Int32.Parse(cmbTipo.SelectedValue.ToString())) ==
                                         Negocios.Turnos.Respuesta.validacionCorrecta)
                {
                    MessageBox.Show("Ingresado correctamente!", "Informacion",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(pckHoraFin.Value.ToString());
                    MessageBox.Show("Ha ocurrido un error...", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarComboDocumento();
        }


        private void cmbNombre_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarComboTipo();
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

        private void btnAgregarJefe_Click(object sender, EventArgs e)
        {
            FrmAltaEmpleados empleados = new FrmAltaEmpleados();
            empleados.ShowDialog();
            CargarComboNombre();
        }
    }
}
