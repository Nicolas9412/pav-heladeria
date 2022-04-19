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
    public partial class FrmModificarUsuarios : Form
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string contraseña { get; set; }


        public FrmModificarUsuarios()
        {
            InitializeComponent();
        }

        private void FrmModificarUsuarios_Load(object sender, EventArgs e)
        {
            lblId.TabStop = false;
            lblNombre.TabStop = false;
            lblContraseña.TabStop = false;
            lblRepetir.TabStop = false;
            lblNuevo.TabStop = false;
            CargarCampos();
            
        }

        private void btnIngresar_Click(object sender, EventArgs e) //es boton aceptar
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                if (txtContraseña.Text == txtRepetir.Text)
                {
                    Negocios.Usuarios usuarios = new Negocios.Usuarios();
                    usuarios.ModificarUsuario(Int32.Parse(id), txtNombre.Text.Trim(), txtContraseña.Text.Trim());
                    MessageBox.Show("Modificado correctamente!", "Informacion",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    CargarCampos();
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

        private void CargarCampos()
        {
            Negocios.Usuarios usuario = new Negocios.Usuarios();
            DataTable tabla = usuario.RecuperarUsuario(Int32.Parse(id));
            id = tabla.Rows[0]["idUsuario"].ToString();
            nombre = tabla.Rows[0]["nombreUsuario"].ToString();
            contraseña = tabla.Rows[0]["contrasenia"].ToString();

            txtId.Text = id;
            txtNombre.Text = nombre;
            txtContraseña.Text = contraseña;
        }
    }
}
