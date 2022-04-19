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
    public partial class FrmConsultarFrutaHeladoEspecial : Form
    {
        public string heladoEspecial { get; set; }
        public string fruta { get; set; }
        public string cantidad { get; set; }
        public FrmConsultarFrutaHeladoEspecial()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultarFrutaHeladoEspecial_Load(object sender, EventArgs e)
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
