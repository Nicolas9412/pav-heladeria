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

namespace Practico.Formularios.Abm.Proveedores
{
    public partial class FrmConsultarProveedores : Form
    {
        Negocios.Proveedores proveedor = new Negocios.Proveedores();
        Negocios.TipoDocumento tipoDoc = new Negocios.TipoDocumento();
        Negocios.Barrios barrio = new Negocios.Barrios();

        public string tipoDocumento { get; set; }
        public string nroDocumento { get; set; }
        public string razonSocial { get; set; }
        public string email { get; set; }
        public string telCel { get; set; }
        public string telFijo { get; set; }
        public string calle { get; set; }
        public string nroCalle { get; set; }
        public string idBarrio { get; set; }

        public FrmConsultarProveedores()
        {
            InitializeComponent();
        }

        private void FrmModificarProveedores_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.cargar(tipoDoc.EstrCombo());
            cmbBarrio.cargar(barrio.EstrCombo());
            CargarCampos();
        } 
        private void CargarCampos()
        {
            DataTable tabla = new DataTable();
            tabla = proveedor.RecuperarProoveedor(tipoDocumento, nroDocumento);
            cmbTipoDoc.SelectedValue = int.Parse(tabla.Rows[0]["tipoDocumento"].ToString());
            txtNroDoc.Text = tabla.Rows[0]["nroDocumento"].ToString();
            txtRazónSocial.Text = tabla.Rows[0]["razonSocial"].ToString();
            txtEmail.Text = tabla.Rows[0]["mail"].ToString();
            txtTelCel.Text = tabla.Rows[0]["telCelular"].ToString();
            txtTelFijo.Text = tabla.Rows[0]["telFijo"].ToString();
            txtCalle.Text = tabla.Rows[0]["calle"].ToString();
            txtNroCalle.Text = tabla.Rows[0]["nroCalle"].ToString();
            cmbBarrio.SelectedValue = int.Parse(tabla.Rows[0]["idBarrio"].ToString());

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
