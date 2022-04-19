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
    public partial class FrmConsultarHeladosEspeciales : Form
    {
        Negocios.HeladosEspeciales heladoEspecial = new Negocios.HeladosEspeciales();
        Negocios.Helados helado = new Negocios.Helados();

        public string idHeladoEspecial { get; set; }
        public string nombreProducto { get; set; }
        public string cantBochas { get; set; }
        public string precio { get; set; }
        public string cantidadStock { get; set; }

        public FrmConsultarHeladosEspeciales()
        {
            InitializeComponent();
        }

        private void FrmModificarHeladosEspeciales_Load(object sender, EventArgs e)
        {
            CargarCampos();
        } 
        private void CargarCampos()
        {
            DataTable tabla = new DataTable();
            tabla = heladoEspecial.RecuperarHeladosEspeciales(idHeladoEspecial);
            txtNombre.Text = tabla.Rows[0]["nombreProducto"].ToString();
            txtPrecio.Text = tabla.Rows[0]["precio"].ToString();
            txtStock.Text = tabla.Rows[0]["cantidadStock"].ToString();
            txtId.Text = tabla.Rows[0]["idHeladoEspecial"].ToString();

        }


            private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
