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
using Practico.Negocios;
using Practico.Formularios.Abm.Localidades;

namespace Practico.Formularios.Abm.Barrios
{
    public partial class FrmAltaBarrios : Form
    {
        Negocios.Localidades localidad = new Negocios.Localidades();
        public FrmAltaBarrios()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAltaBarrios_Load(object sender, EventArgs e)
        {
            lblLocalidad.TabStop = false;
            lblNombre.TabStop = false;
            lblNuevo.TabStop = false;
            cmbLocalidad.Cargar();
        }
        
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            cmbLocalidad.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.Barrios barrios = new Negocios.Barrios();
                if (barrios.InsertarBarrio(txtNombre.Text,
                    Int32.Parse(cmbLocalidad.SelectedValue.ToString()))
                    == Negocios.Barrios.Respuesta.validacionCorrecta)
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

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            FrmAltaLocalidades localidades = new FrmAltaLocalidades();
            localidades.ShowDialog();
            cmbLocalidad.cargar(localidad.EstrCombo());
        }
    }
}
