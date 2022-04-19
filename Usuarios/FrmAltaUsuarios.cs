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

namespace Practico.Formularios.Abm.Usuarios
{
    public partial class FrmAltaUsuarios : Form
    {
        public FrmAltaUsuarios()
        {
            InitializeComponent();
        }

        private void FrmAltaUsuarios_Load(object sender, EventArgs e)
        {
            lblNombre.TabStop = false;
            lblContraseña.TabStop = false;
            lblRepetir.TabStop = false;
            lblNuevo.TabStop = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e) //es boton aceptar
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                if (txtContraseña.Text == txtRepetir.Text)
                {
                    Negocios.Usuarios usuario = new Negocios.Usuarios();
                    if (usuario.IngresarUsuario(txtNombre.Text, txtContraseña.Text) ==
                        Negocios.Usuarios.Respuesta.validacionCorrecta)
                    {
                        MessageBox.Show("Ingresado correctamente!", "Informacion",
                            buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Usuario repetido", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimpiarCampos();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarContraseñas();
                    txtContraseña.Focus();
                }
            }
        }

        // limpiar textbox
        private void LimpiarContraseñas()
        {
            txtContraseña.Text = "";
            txtRepetir.Text = "";
            txtContraseña.Focus();
        }

        private void LimpiarCampos()
        {
            LimpiarContraseñas();
            txtNombre.Text = "";
            txtNombre.Focus();
        }


        // ENTER funciona como TAB
        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtRepetir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
