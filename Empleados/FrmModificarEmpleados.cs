using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Clases;

namespace Practico.Formularios.Abm.Empleados
{
    public partial class FrmModificarEmpleados : Form
    {
        public string tipoDoc { get; set; }
        public string nroDoc { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string calle { get; set; }
        public string nroCalle { get; set; }
        public string barrio { get; set; }
        public string fechaNacimiento { get; set; }
        public string fechaIngreso { get; set; }
        public string usuario { get; set; }
        public string turno { get; set; }
        public FrmModificarEmpleados()
        {
            InitializeComponent();
        }

        private void FrmModificarEmpleados_Load(object sender, EventArgs e)
        {
            lblTipo.TabStop = false;
            lblNumeroD.TabStop = false;
            lblNombre.TabStop = false;
            lblApellido.TabStop = false;
            lblCalle.TabStop = false;
            lblNumero.TabStop = false;
            lblBarrio.TabStop = false;
            lblFechaNa.TabStop = false;
            lblFechaIn.TabStop = false;
            lblUsuario.TabStop = false;
            lblTurno.TabStop = false;
            cmbTipo.Cargar();
            cmbBarrio.Cargar();
            cmbTurno.Cargar();
            cmbUsuario.Cargar();

            CargarCampos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.Empleados empleados = new Negocios.Empleados();
                if (empleados.ModificarEmpleado(Int32.Parse(cmbTipo.SelectedValue.ToString()),
                        txtNroDoc.Text,
                        txtNombre.Text,
                        txtApellido.Text,
                        txtCalle.Text,
                        Int32.Parse(txtNroCalle.Text),
                        Int32.Parse(cmbBarrio.SelectedValue.ToString()),
                        pckNacimiento.Value,
                        pckIngreso.Value,
                        Int32.Parse(cmbUsuario.SelectedValue.ToString()),
                        Int32.Parse(cmbTurno.SelectedValue.ToString()))
                    == Negocios.Empleados.Respuesta.validacionCorrecta)
                {
                    MessageBox.Show("Modificado correctamente!", "Informacion", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    CargarCampos();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error...", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarCampos();
                }

            }

        }

        private void CargarCampos()
        {
            Negocios.Empleados empleados = new Negocios.Empleados();
            DataTable tabla = empleados.RecuperarEmpleado(tipoDoc, nroDoc);

            //tipoDoc = tabla.Rows[0]["tipoDoc"].ToString();   // no deberia cambiar nunca
            //nroDoc = tabla.Rows[0]["nroDoc"].ToString();

            nombre = tabla.Rows[0]["nombre"].ToString();
            apellido = tabla.Rows[0]["apellido"].ToString();
            calle = tabla.Rows[0]["calle"].ToString();
            nroCalle = tabla.Rows[0]["nroCalle"].ToString();
            barrio = tabla.Rows[0]["idBarrio"].ToString();
            fechaNacimiento = tabla.Rows[0]["fechaNacimiento"].ToString();
            fechaIngreso = tabla.Rows[0]["fechaIngreso"].ToString();
            usuario = tabla.Rows[0]["idUsuario"].ToString();
            turno = tabla.Rows[0]["idTurno"].ToString();

            cmbTipo.SelectedIndex = cmbTipo.FindStringExact(tipoDoc); // para seleccionar el item del combo que coincide con la cadena tipoDoc
            txtNroDoc.Text = nroDoc;

            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtCalle.Text = calle;
            txtNroCalle.Text = nroCalle;
            cmbBarrio.SelectedValue = barrio;
            pckNacimiento.Value = DateTime.Parse(fechaNacimiento);
            pckIngreso.Value = DateTime.Parse(fechaIngreso);
            cmbUsuario.SelectedValue = usuario;
            cmbTurno.SelectedValue = turno;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumero_Click(object sender, EventArgs e)
        {
            txtNroCalle.Select(0,0);
        }
    }
}
