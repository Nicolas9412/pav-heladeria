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

namespace Practico.Formularios.Procesos.Compra
{
    public partial class FrmCompras : Form
    {
        Compras compras = new Compras();

        public string nroComprobante { get; set; }

        public FrmCompras()
        {
            InitializeComponent();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            grdCompras.Formatear("Comprobante,150;Fecha,180;Razón Social,180;Total,100");
            CargarFecha();
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

        private void cmbRazonSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboTipo();
        }
        private void cmbTipoDocProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboDocumento();
        }
        private void chkBuscarTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscarTodas.Checked)
            {
                chkBuscarPorNroComprobante.Checked = false;
                chkBuscarPorFecha.Checked = false;
                chkBuscarPorProveedor.Checked = false;
            }
            else
            {
                chkBuscarPorNroComprobante.Checked = false;
                chkBuscarPorFecha.Checked = false;
                chkBuscarPorProveedor.Checked = false;
            }
        }

        private void chkBuscarPorNroComprobante_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscarPorNroComprobante.Checked)
            {
                lbltxtNroComprobante.Focus();
                chkBuscarTodas.Checked = false;
            }
            else
            {
                LimpiarNroComprobante();
            }
        }

        private void chkBuscarPorProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscarPorProveedor.Checked)
            {
                CargarComboRazonSocial();
                cmbRazonSocial.Focus();
                chkBuscarTodas.Checked = false;
            }
            else
            {
                LimpiarRazonSocial();
            }
        }

        private void chkBuscarPorFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscarPorFecha.Checked)
            {
                CargarFecha();
                pckDesde.Focus();
                chkBuscarTodas.Checked = false;
            }
            else
            {
                LimpiarFecha();
            }
        }

        private void LimpiarNroComprobante()
        {
            lbltxtNroComprobante.PpText = "";
        }

        private void LimpiarFecha()
        {
            pckDesde.CustomFormat = " ";
            pckDesde.Format = DateTimePickerFormat.Custom;

            pckHasta.CustomFormat = " ";
            pckHasta.Format = DateTimePickerFormat.Custom;

            pckDesde.Enabled = false;
            pckHasta.Enabled = false;
        }

        private void LimpiarRazonSocial()
        {
            cmbRazonSocial.DataSource = null;
            cmbTipoDocProveedor.DataSource = null;
            cmbNroDocProveedor.DataSource = null;
        }

        private void CargarFecha()
        {
            BaseDatos baseDatos = new BaseDatos();
            string fecha = baseDatos.Fecha();

            pckDesde.MaxDate = DateTime.Parse(fecha);
            pckHasta.MaxDate = DateTime.Parse(fecha);
            pckDesde.Format = DateTimePickerFormat.Short;
            pckHasta.Format = DateTimePickerFormat.Short;
            pckDesde.Value = DateTime.Parse("01/01/" + DateTime.Now.Year);
            pckHasta.Value = DateTime.Parse(fecha);


            pckDesde.Enabled = true;
            pckHasta.Enabled = true;
        }

        private void CargarGrilla(DataTable tabla)
        {
            grdCompras.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdCompras.Rows.Add();
                grdCompras.Rows[i].Cells[0].Value = tabla.Rows[i]["nroComprobante"].ToString();
                grdCompras.Rows[i].Cells[1].Value = tabla.Rows[i]["fecha"].ToString();
                grdCompras.Rows[i].Cells[2].Value = tabla.Rows[i]["razonSocial"].ToString();
                grdCompras.Rows[i].Cells[3].Value = tabla.Rows[i]["sumTotal"].ToString();
            }
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (pckDesde.Text.CompareTo(pckHasta.Text) > 0)
            {
                MessageBox.Show("La fecha desde es mayor que la fecha hasta", "Importante"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                pckDesde.Focus();
            }

            DataTable tabla = new DataTable();
            if (chkBuscarPorNroComprobante.Checked || chkBuscarPorFecha.Checked || chkBuscarPorProveedor.Checked)
            {
                if (chkBuscarPorNroComprobante.Checked)
                {
                    tabla = compras.RecuperarCompra(lbltxtNroComprobante.PpText);
                }

                if (chkBuscarPorFecha.Checked)
                {
                    if (pckDesde.Value <= pckHasta.Value)
                    {
                        tabla = compras.RecuperarCompra(pckDesde.Text, pckHasta.Text);
                    }
                    else
                    {
                        MessageBox.Show("Fechas invalidas!", caption: "Atención",
                            icon: MessageBoxIcon.Exclamation, buttons: MessageBoxButtons.OK);
                        return;
                    }
                }

                if(chkBuscarPorProveedor.Checked)
                {
                    tabla = compras.RecuperarCompra(cmbTipoDocProveedor.SelectedValue.ToString(),
                                                    cmbNroDocProveedor.SelectedValue.ToString(),
                                                    cmbRazonSocial.SelectedValue.ToString());
                }

                if (chkBuscarPorNroComprobante.Checked && chkBuscarPorFecha.Checked)
                {
                    if (pckDesde.Value <= pckHasta.Value)
                    {
                        tabla = compras.RecuperarCompra1(lbltxtNroComprobante.PpText, pckDesde.Text, pckHasta.Text);
                    }
                    else
                    {
                        MessageBox.Show("Fechas invalidas!", caption: "Atención",
                            icon: MessageBoxIcon.Exclamation, buttons: MessageBoxButtons.OK);
                        return;
                    }   
                }

                if (chkBuscarPorProveedor.Checked && chkBuscarPorFecha.Checked)
                {
                    if (pckDesde.Value <= pckHasta.Value)
                    {
                        tabla = tabla = compras.RecuperarCompra2(cmbTipoDocProveedor.SelectedValue.ToString(),
                        cmbNroDocProveedor.SelectedValue.ToString(),
                        cmbRazonSocial.SelectedValue.ToString(), pckDesde.Text, pckHasta.Text);
                    }
                    else
                    {
                        MessageBox.Show("Fechas invalidas!", caption: "Atención",
                            icon: MessageBoxIcon.Exclamation, buttons: MessageBoxButtons.OK);
                        return;
                    }  
                }

                if (chkBuscarPorNroComprobante.Checked && chkBuscarPorProveedor.Checked)
                {
                    tabla = compras.RecuperarCompra3(lbltxtNroComprobante.PpText,
                        cmbTipoDocProveedor.SelectedValue.ToString(),
                        cmbNroDocProveedor.SelectedValue.ToString(),
                        cmbRazonSocial.SelectedValue.ToString());
                }

                if (chkBuscarPorNroComprobante.Checked && chkBuscarPorFecha.Checked && chkBuscarPorProveedor.Checked)
                {
                    if (pckDesde.Value <= pckHasta.Value)
                    {
                        tabla = compras.RecuperarCompra4(lbltxtNroComprobante.PpText, pckDesde.Text, pckHasta.Text,
                        cmbTipoDocProveedor.SelectedValue.ToString(),
                        cmbNroDocProveedor.SelectedValue.ToString(),
                        cmbRazonSocial.SelectedValue.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Fechas invalidas!", caption: "Atención",
                            icon: MessageBoxIcon.Exclamation, buttons: MessageBoxButtons.OK);
                        return;
                    }
                }

            }
            else
            {
                if (chkBuscarTodas.Checked)
                {
                    tabla = compras.RecuperarTodasLasCompras();
                }
                else
                {
                    MessageBox.Show("Ingrese un campo de busqueda!", caption: "Atención",
                        icon: MessageBoxIcon.Exclamation, buttons: MessageBoxButtons.OK);
                }

            }

            CargarGrilla(tabla);
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmAltaCompras altaCompra = new FrmAltaCompras();
                altaCompra.ShowDialog();

                DataTable tabla = compras.RecuperarTodasLasCompras(); // ACTUALIZA GRILLA
                CargarGrilla(tabla);
                altaCompra.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdCompras.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdCompras.SelectedRows[0].Index;
                    string nroComprobante = grdCompras[0, indiceFilaSeleccionada].Value.ToString();

                    FrmModificarCompras modificarCompras = new FrmModificarCompras();
                    modificarCompras.nroComprobante = nroComprobante;
                    modificarCompras.ShowDialog();

                    DataTable tabla = compras.RecuperarTodasLasCompras(); // ACTUALIZA GRILLA
                    CargarGrilla(tabla);
                    modificarCompras.Close();
                }
                else
                {
                    return;

                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (grdCompras.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdCompras.SelectedRows[0].Index;
                    string nroComprobante = grdCompras[0, indiceFilaSeleccionada].Value.ToString();

                    FrmConsultarCompras consultar = new FrmConsultarCompras();
                    consultar.nroComprobante = nroComprobante;
                    consultar.ShowDialog();
                    consultar.Close();
                }
                else
                {
                    return;

                }
            }
        }
    }
}
