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

namespace Practico.Formularios.Abm.FrutasHeladosEspeciales
{
    public partial class FrmEliminarFrutaHeladoEspecial : Form
    {
        public string heladoEspecial { get; set; }
        public string fruta { get; set; }
        public string cantidad { get; set; }
        public FrmEliminarFrutaHeladoEspecial()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.FrutasHeladosEspeciales frutas = new Negocios.FrutasHeladosEspeciales();
                if (frutas.EliminarFruta(Int32.Parse(cmbHeladoEspecial.SelectedValue.ToString()),
                                             Int32.Parse(cmbFruta.SelectedValue.ToString()))
                    == Negocios.FrutasHeladosEspeciales.Respuesta.validacionCorrecta)
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

        private void FrmEliminarFrutaHeladoEspecial_Load(object sender, EventArgs e)
        {
            cmbFruta.Cargar();
            cmbHeladoEspecial.Cargar();
            CargarCampos();
        }


        private void CargarCampos()
        {
            Negocios.FrutasHeladosEspeciales frutas = new Negocios.FrutasHeladosEspeciales();
            DataTable tabla = frutas.RecuperarFruta(heladoEspecial, fruta);

            //heladoEspecial = tabla.Rows[0]["idHeladoEspecial"].ToString();
            //fruta = tabla.Rows[0]["idFruta"].ToString();
            cantidad = tabla.Rows[0]["cantGramos"].ToString();

            cmbHeladoEspecial.SelectedValue = tabla.Rows[0]["idHeladoEspecial"].ToString();
            cmbFruta.SelectedValue = tabla.Rows[0]["idFruta"].ToString();
            txtCantidad.Text = cantidad;
        }
    }
}
