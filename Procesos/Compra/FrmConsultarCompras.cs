using Practico.Clases;
using Practico.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico.Formularios.Procesos.Compra
{
    public partial class FrmConsultarCompras : Form
    {
        private int nroItem = 0;
        BaseDatos baseDatos = new BaseDatos();
        Compras compras = new Compras();
        DetallesCompras detallesCompras = new DetallesCompras();

        public string nroComprobante { get; set; }

        public FrmConsultarCompras()
        {
            InitializeComponent();
        }

        private void FrmAltaCompras_Load(object sender, EventArgs e)
        {
            CargarFecha();
            grdDetallesCompras.Formatear("NroItem,60;Id,50;Nombre,180;Precio,100;Kilos,100;SubTotal,100;Estado,0");
            grdDetallesCompras.Columns[6].Visible = false;
            CargarComboRazonSocial();
            CargarGrilla();
            cmbIdHelado.SelectedIndex = -1;
            txtPrecioHelado.Text = "";
            actualizarPrecio();
        }

        private void CargarFecha()
        {
            BaseDatos baseDatos = new BaseDatos();
            string fecha = baseDatos.Fecha();
            pckFechaCompra.MaxDate = DateTime.Parse(fecha);
            pckFechaCompra.Value = DateTime.Parse(fecha);
            pckFechaCompra.Format = DateTimePickerFormat.Short;
        }

        private void CargarComboRazonSocial()
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT DISTINCT P.razonSocial FROM Proveedores P";
            cmbRazonSocial.ValueMember = "razonSocial";
            cmbRazonSocial.DisplayMember = "razonSocial";
            cmbRazonSocial.DataSource = baseDatos.Consulta(sql);
        }

        public void CargarComboTipo()
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT DISTINCT TD.* FROM Proveedores P JOIN TiposDocumento TD ON (P.tipoDocumento = TD.tipoDocumento)"
                         + " WHERE razonSocial LIKE '%" + cmbRazonSocial.SelectedValue + "%'";
            cmbTipoDocProveedor.DisplayMember = "descripcion";
            cmbTipoDocProveedor.ValueMember = "tipoDocumento";
            cmbTipoDocProveedor.DataSource = baseDatos.Consulta(sql);
        }

        public void CargarComboDocumento()
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT P.* FROM Proveedores P WHERE P.tipoDocumento LIKE '%" + cmbTipoDocProveedor.SelectedValue + "%'"
                         + " AND P.razonSocial LIKE '%" + cmbRazonSocial.SelectedValue + "%'";
            cmbNroDocProveedor.ValueMember = "nroDocumento";
            cmbNroDocProveedor.DisplayMember = "nroDocumento";
            cmbNroDocProveedor.DataSource = baseDatos.Consulta(sql);
        }
        public void CargarComboHelado()
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT * FROM ProveedoresHelados PH JOIN Helados H ON (PH.idHelado = H.idHelado) " +
                         " WHERE PH.tipoDocProveedor LIKE '%" + cmbTipoDocProveedor.SelectedValue + "%'"
                         + " AND PH.nroDocProveedor LIKE '%" + cmbNroDocProveedor.SelectedValue + "%'";
            cmbIdHelado.ValueMember = "idHelado";
            cmbIdHelado.DisplayMember = "nombre";
            cmbIdHelado.DataSource = baseDatos.Consulta(sql);

        }

        public string RecuperarPrecioHelado()
        {
            string sql = "SELECT * FROM ProveedoresHelados PH JOIN Helados H ON (PH.idHelado = H.idHelado) " +
                         " WHERE PH.tipoDocProveedor LIKE '%" + cmbTipoDocProveedor.SelectedValue + "%'"
                         + " AND PH.nroDocProveedor LIKE '%" + cmbNroDocProveedor.SelectedValue + "%'"
                         + " AND PH.idHelado LIKE '%" + cmbIdHelado.SelectedValue + "%'";
            DataTable tabla = baseDatos.Consulta(sql);
            return tabla.Rows[0]["precio"].ToString();
        }

        private void btnFechaHoy_Click(object sender, EventArgs e)
        {
            string fecha = baseDatos.Fecha();

            pckFechaCompra.MaxDate = DateTime.Parse(fecha);
            pckFechaCompra.Format = DateTimePickerFormat.Short;
            pckFechaCompra.Value = DateTime.Parse(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
        }

        private void cmbRazonSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboTipo();
        }

        private void cmbTipoDocProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboDocumento();
        }

        private void cmbNroDocProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboHelado();
        }

        private void cmbIdHelado_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecioHelado.Text = RecuperarPrecioHelado();
        }

        private void btnAgregarHelado_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();

            if (tratamientos.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                if (verificarExistencia(cmbIdHelado.Text))
                {
                    pckFechaCompra.Enabled = false;
                    cmbRazonSocial.Enabled = false;
                    cmbNroDocProveedor.Enabled = false;
                    cmbTipoDocProveedor.Enabled = false;

                    nroItem += 1;

                    grdDetallesCompras.Rows.Add();
                    int ind = grdDetallesCompras.Rows.Count - 1;

                    if (ind > 4)
                    {
                        grdDetallesCompras.Height = grdDetallesCompras.Height + 20;
                    }

                    grdDetallesCompras.Rows[ind].Cells[0].Value = nroItem;
                    grdDetallesCompras.Rows[ind].Cells[1].Value = cmbIdHelado.SelectedValue;
                    grdDetallesCompras.Rows[ind].Cells[2].Value = cmbIdHelado.Text;
                    grdDetallesCompras.Rows[ind].Cells[3].Value = txtPrecioHelado.Text;
                    grdDetallesCompras.Rows[ind].Cells[4].Value = lbltxtKilos.PpText;
                    grdDetallesCompras.Rows[ind].Cells[5].Value = calcularSubTotal(int.Parse(txtPrecioHelado.Text), int.Parse(lbltxtKilos.PpText)).ToString();
                    grdDetallesCompras.Rows[ind].Cells[6].Value = "nuevo";
                    actualizarPrecio();
                }

            }
        }

        private float calcularSubTotal(int precio, int kilos)
        {
            float subTotal = precio * kilos;
            return subTotal;
        }

        private bool verificarExistencia(string nombreHelado)
        {
            for (int i = 0; i < grdDetallesCompras.Rows.Count; i++)
            {
                if (grdDetallesCompras.Rows[i].Cells[2].Value.ToString() == nombreHelado)
                {
                    return false;
                }
            }

            return true;
        }

        private void actualizarPrecio()
        {
            string precioTotal = CalcularTotalCompra().ToString();
            lblTotal.Text = precioTotal;
        }

        private float CalcularTotalCompra()
        {
            if (grdDetallesCompras.Rows.Count == 0)
            {
                return 0;
            }

            float precioTotal = 0;
            float cantidad = 0;
            float precio = 0;

            for (int i = 0; i < grdDetallesCompras.Rows.Count; i++)
            {
                precio = float.Parse(grdDetallesCompras.Rows[i].Cells[3].Value.ToString());
                cantidad = float.Parse(grdDetallesCompras.Rows[i].Cells[4].Value.ToString());
                precioTotal += cantidad * precio;
            }

            return precioTotal;
        }

        private void LimpiarCampos()
        {
            pckFechaCompra.Enabled = true;
            cmbRazonSocial.Enabled = true;
            pckFechaCompra.Value = DateTime.Parse(1 + "/" + 1 + "/" + 2020);
            cmbRazonSocial.SelectedIndex = -1;
            cmbTipoDocProveedor.SelectedIndex = -1;
            cmbNroDocProveedor.SelectedIndex = -1;
            cmbIdHelado.SelectedIndex = -1;
            txtPrecioHelado.Text = "";
            lbltxtKilos.PpText = "";

            grdDetallesCompras.Rows.Clear();

            actualizarPrecio();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDetallesCompras.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdDetallesCompras.SelectedRows[0].Index;
                    grdDetallesCompras[6, indiceFilaSeleccionada].Value = "eliminado";
                    grdDetallesCompras.Rows[indiceFilaSeleccionada].Visible = false;
                    actualizarPrecio();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (grdDetallesCompras.Rows.Count > 0)
                {
                    grdDetallesCompras_KeyDown(sender, new KeyEventArgs(Keys.Enter));
                }
                else
                {
                    MessageBox.Show("No hay datos en la grilla!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grdDetallesCompras_KeyDown(object sender, KeyEventArgs e)
        {
            grdDetallesCompras.ReadOnly = false;
            grdDetallesCompras.Columns[0].ReadOnly = true;
            grdDetallesCompras.Columns[1].ReadOnly = true;
            grdDetallesCompras.Columns[2].ReadOnly = true;
            grdDetallesCompras.Columns[3].ReadOnly = true;
            grdDetallesCompras.Columns[5].ReadOnly = true;
            grdDetallesCompras.CurrentCell = grdDetallesCompras.CurrentRow.Cells[4];
            grdDetallesCompras.BeginEdit(true);
        }

        private void CargarGrilla()
        {
            grdDetallesCompras.Rows.Clear();

            string fechaHoy;
            string fecha;
            string razonSocial;
            string tipoDocProvedor;
            string nroDocProveedor;
            string nroItem;
            string id;
            string nombre;
            string cantidad;
            string precio;
            string subTotal;
            string estado = "no modificado";

            DataTable tabla = detallesCompras.RecuperarDetalle(nroComprobante);

            fecha = tabla.Rows[0]["fecha"].ToString();
            razonSocial = tabla.Rows[0]["razonSocial"].ToString();
            tipoDocProvedor = tabla.Rows[0]["tipoDocProveedor"].ToString();
            nroDocProveedor = tabla.Rows[0]["nroDocProveedor"].ToString();
            pckFechaCompra.Text = fecha;
            cmbRazonSocial.Text = razonSocial;
            cmbTipoDocProveedor.Text = nroDocProveedor;
            cmbNroDocProveedor.Text = tipoDocProvedor;
            
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdDetallesCompras.Rows.Add();

                nroItem = tabla.Rows[i]["nroItem"].ToString();
                id = tabla.Rows[i]["idHelado"].ToString();
                nombre = tabla.Rows[i]["nombre"].ToString();
                cantidad = tabla.Rows[i]["cantidad"].ToString();
                precio = tabla.Rows[i]["precio"].ToString();
                subTotal = tabla.Rows[i]["subTotal"].ToString();
                grdDetallesCompras.Rows[i].Cells[0].Value = nroItem;
                grdDetallesCompras.Rows[i].Cells[1].Value = id;
                grdDetallesCompras.Rows[i].Cells[2].Value = nombre;
                grdDetallesCompras.Rows[i].Cells[3].Value = precio;
                grdDetallesCompras.Rows[i].Cells[4].Value = cantidad;
                grdDetallesCompras.Rows[i].Cells[5].Value = subTotal;
                grdDetallesCompras.Rows[i].Cells[6].Value = estado;
            }
        }

        private void grdDetallesCompras_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            actualizarPrecio();
            int indiceFilaSeleccionada = grdDetallesCompras.SelectedRows[0].Index;
            grdDetallesCompras[6, indiceFilaSeleccionada].Value = "modificado";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
