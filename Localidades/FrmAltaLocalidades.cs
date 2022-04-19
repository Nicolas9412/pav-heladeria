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
    public partial class FrmAltaLocalidades : Form
    {
        public FrmAltaLocalidades()
        {
            InitializeComponent();
        }

        private void FrmAltaLocalidades_Load(object sender, EventArgs e)
        {
            lblNombre.TabStop = false;
            lblNuevo.TabStop = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.Localidades localidad = new Negocios.Localidades();
                if (localidad.IngresarLocalidad(txtNombre.Text) ==
                    Negocios.Localidades.Respuesta.validacionCorrecta)
                {
                    MessageBox.Show("Localidad ingresado correctamente", "Informacion",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Localidad repetido", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCampos();
                }
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
