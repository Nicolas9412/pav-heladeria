using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Negocios;
using Practico.Clases;

namespace Practico.Formularios.Abm.HeladosEspeciales
{
    public partial class FrmModificarHeladosEspeciales : Form
    {
        Negocios.HeladosEspeciales heladoEspecial = new Negocios.HeladosEspeciales();
        Negocios.Helados helado = new Negocios.Helados();

        public string idHeladoEspecial { get; set; }
        public string nombre { get; set; }
        public string cantBochas { get; set; }
        public string precio { get; set; }
        public string stock { get; set; }


        public FrmModificarHeladosEspeciales()
        {
            InitializeComponent();
        }

        private void FrmModificarHeladosEspeciales_Load(object sender, EventArgs e)
        {
            CargarCampos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.HeladosEspeciales heladoEspecial = new Negocios.HeladosEspeciales();
                if (heladoEspecial.Modificar(idHeladoEspecial, this.Controls) == Negocios.HeladosEspeciales.Respuesta.validacionCorrecta)
                {
                    MessageBox.Show("Modificado correctamente!", "Informacion",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
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
            DataTable tabla = new DataTable();
            tabla = heladoEspecial.RecuperarHeladosEspeciales(idHeladoEspecial);

            //cmbTipoHelado.SelectedIndex = cmbTipoHelado.FindStringExact(idHelado);

            txtNombre.Text = tabla.Rows[0]["nombreProducto"].ToString();
            txtPrecio.Text = tabla.Rows[0]["precio"].ToString();
            txtStock.Text = tabla.Rows[0]["cantidadStock"].ToString();
            txtId.Text = tabla.Rows[0]["idHeladoEspecial"].ToString();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStock_Click(object sender, EventArgs e)
        {
            txtStock.Select(0, 0);
        }
    }
}
