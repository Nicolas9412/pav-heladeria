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

namespace Practico.Formularios.Procesos
{
    public partial class FrmVenta : Form
    {
        public string idUsuario { get; set; }
        Ventas ventas = new Ventas();


        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            chkNombre.Checked = true;
            chkFecha.Checked = true;
            grdVentas.Formatear("Ticket,100;Empleado,180;Fecha,180;Total,100");
        }

        private void CargarFecha()
        {
            BaseDatos baseDatos = new BaseDatos();
            string fecha = baseDatos.Fecha();

            pckHasta.MaxDate = DateTime.Parse(fecha);
            pckDesde.MaxDate = DateTime.Parse(fecha);

            pckDesde.Format = DateTimePickerFormat.Short;
            pckHasta.Format = DateTimePickerFormat.Short;

            pckDesde.Value = DateTime.Parse("01/01/" + DateTime.Now.Year);
            pckHasta.Value = DateTime.Parse(fecha);


            pckDesde.Enabled = true;
            pckHasta.Enabled = true;
        }

        private void CargarComboNombre()
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT DISTINCT E.nombre FROM Empleados E ";
            cmbNombre.ValueMember = "nombre";
            cmbNombre.DisplayMember = "nombre";
            cmbNombre.DataSource = baseDatos.Consulta(sql);

            cmbNombre.Enabled = true;
            cmbTipo.Enabled = false;
            cmbDocumento.Enabled = false;
        }

        private void cmbNombre_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbNombre.DataSource != null)
            {
                BaseDatos baseDatos = new BaseDatos();
                string sql =
                    "SELECT DISTINCT TD.* FROM Empleados E JOIN TiposDocumento TD ON (E.tipoDoc = TD.tipoDocumento)"
                    + "WHERE nombre LIKE '%" + cmbNombre.SelectedValue + "%'";
                cmbTipo.DisplayMember = "descripcion";
                cmbTipo.ValueMember = "tipoDocumento";
                cmbTipo.DataSource = baseDatos.Consulta(sql);

                cmbTipo.Enabled = true;
            }

        }

        private void cmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTipo.DataSource != null)
            {
                BaseDatos baseDatos = new BaseDatos();
                string sql = "SELECT E.* FROM Empleados E WHERE tipoDoc LIKE '%" + cmbTipo.SelectedValue + "%'"
                             + "AND nombre LIKE '%" + cmbNombre.SelectedValue + "%'";
                cmbDocumento.ValueMember = "nroDoc";
                cmbDocumento.DisplayMember = "nroDoc";
                cmbDocumento.DataSource = baseDatos.Consulta(sql);

                cmbDocumento.Enabled = true;
            }

        }

        private void LimpiarNombre()
        {
            cmbNombre.DataSource = null;
            cmbTipo.DataSource = null;
            cmbDocumento.DataSource = null;

            cmbTipo.Enabled = false;
            cmbNombre.Enabled = false;
            cmbDocumento.Enabled = false;

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

        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNombre.Checked)
            {
                CargarComboNombre();
                chkTodos.Checked = false;
            }
            else
            {
                LimpiarNombre();
            }
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFecha.Checked)
            {
                CargarFecha();
                chkTodos.Checked = false;
            }
            else
            {
                LimpiarFecha();
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                chkNombre.Checked = false;
                chkFecha.Checked = false;
            }
            else
            {
                chkNombre.Checked = true;
                chkFecha.Checked = true;
            }

        }


        private void btnConfirmarEspecial_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            if (chkNombre.Checked || chkFecha.Checked)
            {
                if (chkNombre.Checked)
                {
                    tabla = ventas.RecuperarVenta(cmbTipo.SelectedValue.ToString(),
                        cmbDocumento.SelectedValue.ToString(),
                        cmbNombre.SelectedValue.ToString());
                }


                if (chkFecha.Checked)
                {
                    if (pckDesde.Value <= pckHasta.Value)
                    {
                        tabla = ventas.RecuperarVenta(pckDesde.Text, pckHasta.Text);
                    }
                    else
                    {
                        MessageBox.Show("Fechas invalidas!", caption: "Atención",
                            icon: MessageBoxIcon.Exclamation, buttons: MessageBoxButtons.OK);
                        return;
                    }
                }

                if (chkNombre.Checked && chkFecha.Checked)
                {
                    if (pckDesde.Value <= pckHasta.Value)
                    {
                        tabla = ventas.RecuperarVenta(cmbTipo.SelectedValue.ToString(),
                            cmbDocumento.SelectedValue.ToString(),
                            cmbNombre.SelectedValue.ToString(), pckDesde.Text, pckHasta.Text);
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
                if (chkTodos.Checked)
                {
                    tabla = ventas.RecuperarTodasLasVentas();
                }
                else
                {
                    MessageBox.Show("Ingrese un campo de busqueda!", caption: "Atención",
                        icon: MessageBoxIcon.Exclamation, buttons: MessageBoxButtons.OK);
                }

            }

            CargarGrilla(tabla);
        }

        private void CargarGrilla(DataTable tabla)
        {
            grdVentas.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdVentas.Rows.Add();
                grdVentas.Rows[i].Cells[0].Value = tabla.Rows[i]["nroTicket"].ToString();
                grdVentas.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grdVentas.Rows[i].Cells[2].Value = tabla.Rows[i]["fecha"].ToString();
                grdVentas.Rows[i].Cells[3].Value = tabla.Rows[i]["SumTotal"].ToString();
            }
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmAltaVenta altaVenta = new FrmAltaVenta();
                altaVenta.idUsuario = this.idUsuario; // LE PASA EL ID DEL EMPLEADO LOGUEADO
                altaVenta.ShowDialog();

                DataTable tabla = ventas.RecuperarTodasLasVentas(); // ACTUALIZA GRILLA
                CargarGrilla(tabla);
                altaVenta.Close();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdVentas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdVentas.SelectedRows[0].Index;
                    string nroTicket = grdVentas[0, indiceFilaSeleccionada].Value.ToString();

                    FrmModificarVenta modificarVenta = new FrmModificarVenta();
                    modificarVenta.nroTicket = nroTicket;
                    modificarVenta.ShowDialog();

                    DataTable tabla = ventas.RecuperarTodasLasVentas(); // ACTUALIZA GRILLA
                    CargarGrilla(tabla);
                    modificarVenta.Close();
                }
                else
                {
                    return;

                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (grdVentas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdVentas.SelectedRows[0].Index;
                    string nroTicket = grdVentas[0, indiceFilaSeleccionada].Value.ToString();

                    FrmConsultarVenta consultar = new FrmConsultarVenta();
                    consultar.nroTicket = nroTicket;
                    consultar.ShowDialog();
                    consultar.Close();
                }
                else
                {
                    return;

                }
            }
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
