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

namespace Practico.Formularios.Abm.TipoDocumento
{
    public partial class FrmAltaTipoDocumento : Form
    {
        public FrmAltaTipoDocumento()
        {
            InitializeComponent();
        }

        private void FrmAltaTipoDocumento_Load(object sender, EventArgs e)
        {
            lblNombre.TabStop = false;
            lblNuevo.TabStop = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.TipoDocumento tipoDocumento = new Negocios.TipoDocumento();
                if (tipoDocumento.IngresarTipoDocumento(txtNombre.Text) ==
                    Negocios.TipoDocumento.Respuesta.validacionCorrecta)
                {
                    MessageBox.Show("Tipo de documento ingresado correctamente", "Informacion",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Tipo de documento repetido", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
