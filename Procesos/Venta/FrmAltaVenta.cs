using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Clases;
using Practico.Formularios.Abm.Helados;
using Practico.Formularios.Abm.HeladosEspeciales;
using Practico.Negocios;

namespace Practico.Formularios.Procesos
{
    public partial class FrmAltaVenta : Form
    {
        private int nroItem = 0;

        Helados helados = new Helados();
        HeladosEspeciales heladosEspeciales = new HeladosEspeciales();
        Ventas ventas = new Ventas();
        

        public string idUsuario { get; set; }
        Empleados empleados = new Empleados();

        public FrmAltaVenta()
        {
            InitializeComponent();
        }

        private float CalcularTotalVenta()
        {
            if (grdDetalleHelado.Rows.Count == 0)
            {
                return 0;
            }

            float precioTotal = 0;
            float cantidad = 0;
            float precio = 0;

            for (int i = 0; i < grdDetalleHelado.Rows.Count; i++)
            {
                cantidad = float.Parse(grdDetalleHelado.Rows[i].Cells[4].Value.ToString());
                precio = float.Parse(grdDetalleHelado.Rows[i].Cells[3].Value.ToString());
                precioTotal += cantidad * precio;
            }

            return precioTotal;
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            cmbHelado.Cargar();
            cmbEspecial.Cargar();
            RecuperarEmpleado();
            grdDetalleHelado.Formatear("Item,45;Id,45;Helado,170;Precio,80;Cantidad,80;Unidad,65;Especial,0");
            grdDetalleHelado.Columns[6].Visible = false;
            actualizarPrecio();
        }

        private void RecuperarEmpleado()
        {
            DataTable tabla = empleados.RecuperarEmpleadoPorUsuario(idUsuario);

            empleados.tipoDoc = tabla.Rows[0]["tipoDoc"].ToString();
            empleados.nroDoc = tabla.Rows[0]["nroDoc"].ToString();
            empleados.nombre = tabla.Rows[0]["nombre"].ToString();
            empleados.apellido = tabla.Rows[0]["apellido"].ToString();
            empleados.calle = tabla.Rows[0]["calle"].ToString();
            empleados.nroCalle = tabla.Rows[0]["nroCalle"].ToString();
            empleados.barrio = tabla.Rows[0]["idBarrio"].ToString();
            empleados.fechaNacimiento = tabla.Rows[0]["fechaNacimiento"].ToString();
            empleados.fechaIngreso = tabla.Rows[0]["fechaIngreso"].ToString();
            empleados.usuario = tabla.Rows[0]["idUsuario"].ToString();
            empleados.turno = tabla.Rows[0]["idTurno"].ToString();

        }

        private void btnHelado_Click(object sender, EventArgs e)
        {
            pnlEspecial.SendToBack();
            pnlHelados.BringToFront();
            pnlEspecial.Visible = false;
            pnlHelados.Visible = true;
        }


        private void btnEspecial_Click(object sender, EventArgs e)
        {
            pnlHelados.Visible = false;
            pnlHelados.SendToBack();
            pnlEspecial.BringToFront();
            pnlEspecial.Visible = true;
        }

        private void actualizarPrecio()
        {
            string precioTotal = CalcularTotalVenta().ToString();
            lblTotal.Text = precioTotal;
        }

        private bool verificarExistencia(string nombreHelado)
        {
            for (int i = 0; i < grdDetalleHelado.Rows.Count; i++)
            {
                if (grdDetalleHelado.Rows[i].Cells[2].Value.ToString() == nombreHelado)
                {
                    return false;
                }
            }

            return true;
        }

        private void btnConfirmarEspecial_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();

            if (tratamientos.Validar(pnlEspecial.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                if (verificarExistencia(cmbEspecial.Text))
                {
                    int nroItem = grdDetalleHelado.Rows.Count;
                    nroItem += 1;

                    grdDetalleHelado.Rows.Add();
                    int ind = grdDetalleHelado.Rows.Count - 1;

                    if (ind > 4)
                    {
                        grdDetalleHelado.Height = grdDetalleHelado.Height + 20;
                    }

                    grdDetalleHelado.Rows[ind].Cells[0].Value = nroItem;
                    grdDetalleHelado.Rows[ind].Cells[1].Value = cmbEspecial.SelectedValue;
                    grdDetalleHelado.Rows[ind].Cells[2].Value = cmbEspecial.Text;
                    grdDetalleHelado.Rows[ind].Cells[3].Value = txtPrecioEspecial.Text;
                    grdDetalleHelado.Rows[ind].Cells[4].Value = txtEspecial.Text.Replace(',', '.');
                    grdDetalleHelado.Rows[ind].Cells[5].Value = "uni.";
                    grdDetalleHelado.Rows[ind].Cells[6].Value = "true";

                    actualizarPrecio();
                }
                
            }
            
        }


        private void btnConfirmarHelado_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();
            if (tratamientos.Validar(pnlHelados.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                if (verificarExistencia(cmbHelado.Text))
                {
                    nroItem += 1;

                    grdDetalleHelado.Rows.Add();
                    int ind = grdDetalleHelado.Rows.Count - 1;

                    if (ind > 4)
                    {
                        grdDetalleHelado.Height = grdDetalleHelado.Height + 20;
                    }

                    grdDetalleHelado.Rows[ind].Cells[0].Value = nroItem;
                    grdDetalleHelado.Rows[ind].Cells[1].Value = cmbHelado.SelectedValue;
                    grdDetalleHelado.Rows[ind].Cells[2].Value = cmbHelado.Text;
                    grdDetalleHelado.Rows[ind].Cells[3].Value = txtPrecioHelado.Text;
                    grdDetalleHelado.Rows[ind].Cells[4].Value = txtHelado.Text.Replace(',', '.');
                    grdDetalleHelado.Rows[ind].Cells[5].Value = "kg";
                    grdDetalleHelado.Rows[ind].Cells[6].Value = "false";

                    actualizarPrecio();
                }
                
            }
            
        }

        private void cmbHelado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = helados.RecuperarHelado(Int32.Parse(cmbHelado.SelectedValue.ToString()));
            txtPrecioHelado.Text = tabla.Rows[0]["precio"].ToString();
            txtHelado.Text = "1";
            txtHelado.Focus();
            txtHelado.Select();
        }

        private void cmbEspecial_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = heladosEspeciales.RecuperarHeladosEspeciales(cmbEspecial.SelectedValue.ToString());
            txtPrecioEspecial.Text = tabla.Rows[0]["precio"].ToString();
            txtEspecial.Text = "1";
            txtEspecial.Focus();
            txtEspecial.Select();
            
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (grdDetalleHelado.Rows.Count > 0)
                {
                    ventas.InsertarVenta(empleados.tipoDoc, empleados.nroDoc, grdDetalleHelado);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No hay datos en la grilla!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDetalleHelado.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    grdDetalleHelado.Rows.Remove(grdDetalleHelado.CurrentRow);
                    actualizarPrecio();
                }
            }
        }

        private void LimpiarCampos()
        {
            cmbEspecial.SelectedIndex = -1;
            cmbHelado.SelectedIndex = -1;

            txtPrecioHelado.Text = "";
            txtPrecioEspecial.Text = "";

            txtEspecial.Text = "";
            txtHelado.Text = "";

            grdDetalleHelado.Rows.Clear();

            actualizarPrecio();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button1_Click(object sender, EventArgs e) //MODIFICAR
        {
            if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (grdDetalleHelado.Rows.Count > 0)
                {
                    grdDetalleHelado_KeyDown(sender, new KeyEventArgs(Keys.Enter));
                }
                else
                {
                    MessageBox.Show("No hay datos en la grilla!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grdDetalleHelado_KeyDown(object sender, KeyEventArgs e)
        {
            grdDetalleHelado.ReadOnly = false;
            grdDetalleHelado.Columns[0].ReadOnly = true;
            grdDetalleHelado.Columns[1].ReadOnly = true;
            grdDetalleHelado.Columns[2].ReadOnly = true;
            grdDetalleHelado.Columns[3].ReadOnly = true;
            grdDetalleHelado.Columns[5].ReadOnly = true;
            grdDetalleHelado.CurrentCell = grdDetalleHelado.CurrentRow.Cells[4];
            grdDetalleHelado.BeginEdit(true);
        }


        private void grdDetalleHelado_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            actualizarPrecio();
        }

        
        private string previousInput = "";

        private void txtEspecial_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^-{0,1}\d+\.{0,1}\d*$"); // Expresion regular
            Match m = r.Match(txtEspecial.Text);
            if (m.Success)
            {
                previousInput = txtEspecial.Text;
            }
            else
            {
                txtEspecial.Text = previousInput;
            }
        }


        private void txtHelado_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^-{0,1}\d+\.{0,1}\d*$"); // Expresion regular
            Match m = r.Match(txtHelado.Text);
            if (m.Success)
            {
                previousInput = txtHelado.Text;
            }
            else
            {
                txtHelado.Text = previousInput;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarHelado_Click(object sender, EventArgs e)
        {
            FrmAltaHeladosEspeciales altaHeladosEspeciales = new FrmAltaHeladosEspeciales();
            altaHeladosEspeciales.ShowDialog();
            cmbEspecial.Cargar();

        }

        private void btnAgregarEspecial_Click(object sender, EventArgs e)
        {
            FrmAltaHelados altaHelados = new FrmAltaHelados();
            altaHelados.ShowDialog();
            cmbHelado.Cargar();
        }
    }
}
