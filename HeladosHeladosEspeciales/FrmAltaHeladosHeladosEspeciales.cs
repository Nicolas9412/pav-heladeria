using Practico.Clases;
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
using Practico.Negocios;
using Practico.Formularios.Abm.HeladosEspeciales;
using Practico.Formularios.Abm.Helados;

namespace Practico.Formularios.Abm.HeladosHeladosEspeciales
{
    public partial class FrmAltaHeladosHeladosEspeciales : Form
    {
        Negocios.HeladosEspeciales heladoEspecial = new Negocios.HeladosEspeciales();
        Negocios.Helados helado = new Negocios.Helados();
        public FrmAltaHeladosHeladosEspeciales()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAltaHeladosHeladosEspeciales_Load(object sender, EventArgs e)
        {
            cmbHeladoEspecial.Cargar();
            cmbHelado.Cargar();
        }

        private void LimpiarCampos()
        {
            cmbHeladoEspecial.SelectedIndex = -1;
            cmbHelado.SelectedIndex = -1;
            txtCantidad.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.HeladosHeladosEspeciales helados = new Negocios.HeladosHeladosEspeciales();
                if (helados.InsertarHelado(Int32.Parse(cmbHeladoEspecial.SelectedValue.ToString()),
                                           Int32.Parse(cmbHelado.SelectedValue.ToString()),
                                           Int32.Parse(txtCantidad.Text))
                    == Negocios.HeladosHeladosEspeciales.Respuesta.validacionCorrecta)
                {
                    MessageBox.Show("Ingresado correctamente!", "Informacion",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error...", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void txtCantidad_Click(object sender, EventArgs e)
        {
            txtCantidad.Select(0,0);
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            FrmAltaHeladosEspeciales heladosEspeciales = new FrmAltaHeladosEspeciales();
            heladosEspeciales.ShowDialog();
            cmbHeladoEspecial.cargar(heladoEspecial.EstrCombo());
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            FrmAltaHelados helados = new FrmAltaHelados();
            helados.ShowDialog();
            cmbHelado.cargar(helado.EstrCombo());
        }
    }
}
