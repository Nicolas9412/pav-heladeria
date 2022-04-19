using Practico.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico.Formularios
{
    public partial class FrmLogin : Form
    {
        private string usuario = "";
        private string password = "";
        private int idUsuario;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    

        public FrmLogin()
        {
            InitializeComponent();
        }


        private void FrmLogin_Load(object sender, EventArgs e)   //carga el formulario
        {
            txtUsuario.Focus();
        }


        private void btnCancelar_Click(object sender, EventArgs e)  // boton cancelar
        {
            this.Close();
        }


        private void btnIngresar_Click(object sender, EventArgs e)  //boton ingresar
        {
            if (txtUsuario.Text == "")   // nombre de usuario vacio
            {
                MessageBox.Show("Ingrese usuario",caption:"Importante",buttons:MessageBoxButtons.OK,icon:MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
                return;
            }

            if (txtPassword.Text == "") // contraseña vacia
            {
                MessageBox.Show("Ingrese contraseña", caption:"Importante", MessageBoxButtons.OK,icon:MessageBoxIcon.Exclamation);  
                txtPassword.Focus();
                return;
            }

            Usuarios user = new Usuarios();  // crea objeto usuario del negocio para validar

            if (user.ValidarUsuario(txtUsuario.Text, txtPassword.Text) == Usuarios.Respuesta.validacionCorrecta)
            {   this.usuario = txtUsuario.Text;  // usuario validado
                this.Password = txtPassword.Text;
                this.Close();
            }
            else   // datos incorrectos
            {
                MessageBox.Show("Datos Incorrectos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUsuario.Focus();
                LimpiarCampos();
            }
        }

        
        private void LimpiarCampos()    // Limpia todos los campos
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }


        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
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
    }
}
