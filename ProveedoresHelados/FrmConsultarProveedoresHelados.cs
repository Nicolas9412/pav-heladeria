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

namespace Practico.Formularios.Abm.ProveedoresHelados
{
    public partial class FrmConsultarProveedoresHelados : Form
    {
        Negocios.TipoDocumento tipoDoc = new Negocios.TipoDocumento();
        Negocios.ProveedoresHelados proveedoresHelados = new Negocios.ProveedoresHelados();
        Negocios.Proveedores proveedores = new Negocios.Proveedores();
        Negocios.Helados helados = new Negocios.Helados();

        public string tipoDocumento { get; set; }
        public string nroDocumento { get; set; }
        public string idHelado { get; set; }
        public string razonSocial { get; set; }
       public string precio { get; set; }
        public FrmConsultarProveedoresHelados()
        {
            InitializeComponent();
        }

        private void FrmAltaProveedoresHelados_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.cargar(tipoDoc.EstrCombo());
            cmbNroDoc.cargar(proveedores.EstrCombo());
            cmbIdHelado.cargar(helados.EstrCombo());
            lblPrecio.TabStop = false;
            CargarCampos();
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCampos()
        {
            DataTable tabla = new DataTable();
            tabla = proveedoresHelados.RecuperarProoveedorHelado(tipoDocumento, nroDocumento,idHelado);

            precio = tabla.Rows[0]["precio"].ToString();
            
            cmbTipoDoc.SelectedIndex = cmbTipoDoc.FindStringExact(tipoDocumento);
            cmbNroDoc.SelectedValue = nroDocumento;
            cmbIdHelado.SelectedIndex = cmbIdHelado.FindStringExact(idHelado);
            txtPrecio.Text = precio;
            CargarComboNombre();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarComboNombre()
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT P.razonSocial FROM Proveedores P WHERE P.tipoDocumento = " + cmbTipoDoc.SelectedValue +
                        " AND P.nroDocumento LIKE '" +cmbNroDoc.SelectedValue +"'";
            cmbNombre.ValueMember = "razonSocial";
            cmbNombre.DisplayMember = "razonSocial";
            cmbNombre.DataSource = baseDatos.Consulta(sql);
        }
    }
}
