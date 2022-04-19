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

namespace Practico.Formularios.Abm.Helados
{
    public partial class FrmAltaHelados : Form
    {
        public FrmAltaHelados()
        {
            InitializeComponent();
        }

        private void FrmAltaHelados_Load(object sender, EventArgs e)
        {
            lblNombre.TabStop = false;
            lblPrecio.TabStop = false;
            lblCantidad.TabStop = false;
            lblNuevo.TabStop = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            { 
                Negocios.Helados helados = new Negocios.Helados();
                if (helados.InsertarHelado(txtNombre.Text, float.Parse(txtPrecio.Text.Replace(',','.'), CultureInfo.InvariantCulture), Int32.Parse(txtCantidad.Text)) ==
                    Negocios.Helados.Respuesta.validacionCorrecta)
                {
                    MessageBox.Show("Ingresado correctamente!", "Informacion",
                            buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error...", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCampos();
                }

            }

            
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtNombre.Focus();
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtCantidad_Click(object sender, EventArgs e)
        {
            txtCantidad.Select(0,0);
        }
    }
}
