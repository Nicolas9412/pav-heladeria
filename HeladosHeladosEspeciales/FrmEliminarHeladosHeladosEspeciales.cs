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

namespace Practico.Formularios.Abm.HeladosHeladosEspeciales
{
    public partial class FrmEliminarHeladosHeladosEspeciales : Form
    {

        public string heladoEspecial { get; set; }
        public string helado { get; set; }
        public string cantidad { get; set; }

        public FrmEliminarHeladosHeladosEspeciales()
        {
            InitializeComponent();
        }

        private void FrmEliminarHeladosHeladosEspeciales_Load(object sender, EventArgs e)
        {
            cmbHeladoEspecial.Cargar();
            cmbHelado.Cargar();
            CargarCampos();
        }

        private void CargarCampos()
        {
            Negocios.HeladosHeladosEspeciales helados = new Negocios.HeladosHeladosEspeciales();
            DataTable tabla = helados.RecuperarHelado(heladoEspecial, helado);

            cantidad = tabla.Rows[0]["cantBochas"].ToString();

            cmbHeladoEspecial.SelectedValue = tabla.Rows[0]["idHeladoEspecial"].ToString();
            cmbHelado.SelectedValue = tabla.Rows[0]["idHelado"].ToString();
            txtCantidad.Text = cantidad;
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
                Negocios.HeladosHeladosEspeciales helados = new Negocios.HeladosHeladosEspeciales();
                if (helados.EliminarHelado(Int32.Parse(cmbHeladoEspecial.SelectedValue.ToString()),
                                             Int32.Parse(cmbHelado.SelectedValue.ToString()))
                    == Negocios.HeladosHeladosEspeciales.Respuesta.validacionCorrecta)
                {
                    MessageBox.Show("Eliminado correctamente!", "Informacion",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error...", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }
}
