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
using Practico.Formularios.Abm.Helados;
using Practico.Formularios.Abm.Proveedores;

namespace Practico.Formularios.Abm.ProveedoresHelados
{
    public partial class FrmAltaProveedoresHelados : Form
    {
        Negocios.TipoDocumento tipoDoc = new Negocios.TipoDocumento();
        Negocios.ProveedoresHelados proveedoresHelados = new Negocios.ProveedoresHelados();
        Negocios.Proveedores proveedores = new Negocios.Proveedores();
        Negocios.Helados helados = new Negocios.Helados();

        public FrmAltaProveedoresHelados()
        {
            InitializeComponent();
        }

        private void FrmAltaProveedoresHelados_Load(object sender, EventArgs e)
        {
            cmbIdHelado.cargar(helados.EstrCombo());
            lblPrecio.TabStop = false;
            CargarComboNombre();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                
                if (proveedoresHelados.Insertar(this.Controls) == Negocios.ProveedoresHelados.Respuesta.validacionCorrecta)
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

        private void LimpiarCampos()
        {
            cmbTipoDoc.SelectedIndex = -1;
            cmbNroDoc.SelectedIndex = -1;
            cmbIdHelado.SelectedIndex = -1;
            cmbNombre.SelectedIndex = -1;
            lblPrecio.Text = "";
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarComboNombre()
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT DISTINCT P.razonSocial FROM Proveedores P";
            cmbNombre.ValueMember = "razonSocial";
            cmbNombre.DisplayMember = "razonSocial";
            cmbNombre.DataSource = baseDatos.Consulta(sql);
        }

        public void CargarComboTipo()
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT DISTINCT TD.* FROM Proveedores P JOIN TiposDocumento TD ON (P.tipoDocumento = TD.tipoDocumento)"
                         + " WHERE razonSocial LIKE '%" + cmbNombre.SelectedValue + "%'";
            cmbTipoDoc.DisplayMember = "descripcion";
            cmbTipoDoc.ValueMember = "tipoDocumento";
            cmbTipoDoc.DataSource = baseDatos.Consulta(sql);
        }

        public void CargarComboDocumento()
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT P.* FROM Proveedores P WHERE P.tipoDocumento LIKE '%" + cmbTipoDoc.SelectedValue + "%'"
                         + " AND P.razonSocial LIKE '%" + cmbNombre.SelectedValue + "%'";
            cmbNroDoc.ValueMember = "nroDocumento";
            cmbNroDoc.DisplayMember = "nroDocumento";
            cmbNroDoc.DataSource = baseDatos.Consulta(sql);
        }

        private void cmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarComboDocumento();
        }


        private void cmbNombre_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarComboTipo();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FrmAltaProveedores proveedores = new FrmAltaProveedores();
            proveedores.ShowDialog();
            CargarComboNombre();
        }

        private void btnAgregarHelado_Click(object sender, EventArgs e)
        {
            FrmAltaHelados altaHelados = new FrmAltaHelados();
            altaHelados.ShowDialog();
            cmbIdHelado.cargar(helados.EstrCombo());
        }
    }
}
