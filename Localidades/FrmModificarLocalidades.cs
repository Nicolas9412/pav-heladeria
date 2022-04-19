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
using Practico.Negocios;

namespace Practico.Formularios.Abm.Localidades
{
    public partial class FrmModificarLocalidades : Form
    {
        public string id { get; set; }
        public string nombre { get; set; }


        public FrmModificarLocalidades()
        {
            InitializeComponent();
        }

        private void FrmModificarLocalidades_Load(object sender, EventArgs e)
        {
            lblId.TabStop = false;
            lblNombre.TabStop = false;
            lblNuevo.TabStop = false;
            CargarCampos();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.Localidades localidades = new Negocios.Localidades();
                localidades.ModificarLocalidad(Int32.Parse(id), txtNombre.Text.Trim());
                MessageBox.Show("Localidad modificada correctamente", "Informacion",
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                CargarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CargarCampos()
        {
            Negocios.Localidades localidad = new Negocios.Localidades();
            DataTable tabla = localidad.RecuperarLocalidad(Int32.Parse(id));
            id = tabla.Rows[0]["idLocalidad"].ToString();
            nombre = tabla.Rows[0]["nombre"].ToString();

            txtId.Text = id;
            txtNombre.Text = nombre;
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
