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
    public partial class FrmModificarHelados : Form
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string precio { get; set; }
        public string cantidad { get; set; }


        public FrmModificarHelados()
        {
            InitializeComponent();
        }

        private void FrmModificarHelados_Load(object sender, EventArgs e)
        {
            lblNombre.TabStop = false;
            lblPrecio.TabStop = false;
            lblCantidad.TabStop = false;
            lblNuevo.TabStop = false;
            lblId.TabStop = false;
            CargarCampos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.Helados helados = new Negocios.Helados();
                if (helados.ModificarHelado(Int32.Parse(id), txtNombre.Text, float.Parse(txtPrecio.Text.Replace(',', '.'), CultureInfo.InvariantCulture), Int32.Parse(txtCantidad.Text)) ==
                    Negocios.Helados.Respuesta.validacionCorrecta)
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
            Negocios.Helados helados = new Negocios.Helados();
            DataTable tabla = helados.RecuperarHelado(Int32.Parse(id));
            id = tabla.Rows[0]["idHelado"].ToString();
            nombre = tabla.Rows[0]["nombre"].ToString();
            precio = tabla.Rows[0]["precio"].ToString();
            cantidad = tabla.Rows[0]["cantidadStock"].ToString();

            txtId.Text = id;
            txtNombre.Text = nombre;
            txtPrecio.Text = precio;
            txtCantidad.Text = cantidad;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCantidad_Click(object sender, EventArgs e)
        {
            txtCantidad.Select(0,0);
        }
    }
}
