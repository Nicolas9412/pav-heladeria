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
    public partial class FrmEliminarUsuarios : Form
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string contraseña { get; set; }


        public FrmEliminarUsuarios()
        {
            InitializeComponent();
        }

        private void FrmEliminarUsuarios_Load(object sender, EventArgs e)
        {
            lblId.TabStop = false;
            lblNombre.TabStop = false;
            lblContraseña.TabStop = false;
            lblNuevo.TabStop = false;
            CargarCampos();

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Negocios.Usuarios usuarios = new Negocios.Usuarios();

            if(usuarios.EliminarUsuario(Int32.Parse(id)) == Negocios.Usuarios.Respuesta.validacionCorrecta)
            {
                MessageBox.Show("Eliminado correctamente!", "Informacion",
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
