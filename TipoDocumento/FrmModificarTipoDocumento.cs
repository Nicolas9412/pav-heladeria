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
    public partial class FrmModificarTipoDocumento : Form
    {
        public string id { get; set; }
        public string nombre { get; set; }


        public FrmModificarTipoDocumento()
        {
            InitializeComponent();
        }

        private void FrmModificarTipoDocumento_Load(object sender, EventArgs e)
        {
            lblId.TabStop = false;
            lblDescripcion.TabStop = false;
            lblNuevo.TabStop = false;
            CargarCampos();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.TipoDocumento tipoDocumento = new Negocios.TipoDocumento();
                tipoDocumento.ModificarTipoDocumento(Int32.Parse(id), txtNombre.Text.Trim());
                MessageBox.Show("Tipo de documento modificado correctamente", "Informacion",
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                CargarCampos();
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

        private void CargarCampos()
        {
            Negocios.TipoDocumento tipoDocumento = new Negocios.TipoDocumento();
            DataTable tabla = tipoDocumento.RecuperarTipoDocumento(Int32.Parse(id));
            id = tabla.Rows[0]["tipoDocumento"].ToString();
            nombre = tabla.Rows[0]["descripcion"].ToString();

            txtId.Text = id;
            txtNombre.Text = nombre;
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
