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
    public partial class FrmProveedoresHelados : Form
    {
        Negocios.ProveedoresHelados proveedoresHelados = new Negocios.ProveedoresHelados();
        public FrmProveedoresHelados()
        {
            InitializeComponent();
        }

        private void FrmProveedoresHelados_Load(object sender, EventArgs e)
        {
            lblRazonSocial.TabStop = false;
            lblProveedoresHelados.TabStop = false;
            lblNombreHelado.TabStop = false;
            grdProveedoresHelados.TabStop = false;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtRazonSocial.Text = "";
            txtNombreHelado.Text = "";
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked)  // busca todos los proveedores de helados
            {
                DataTable tabla = proveedoresHelados.TodosLosProveedoresHelados();
                CargarGrilla(tabla);
            }
            else  //buscar por razón social y nombre de helado
            {
                TratamientosEspeciales tratamiento = new TratamientosEspeciales();

                // valida que haya texto en el textbox
                if (tratamiento.ValidarAlMenosUno(pnlBuscar.Controls) == TratamientosEspeciales.Validacion.correcta)
                {
                    DataTable tabla = proveedoresHelados.BuscarProveedorHelado(txtRazonSocial.Text,txtNombreHelado.Text);
                    CargarGrilla(tabla);
                }
            }

            txtRazonSocial.Focus();
        }
        private void CargarGrilla(DataTable tabla)
        {
            grdProveedoresHelados.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdProveedoresHelados.Rows.Add();
                grdProveedoresHelados.Rows[i].Cells[0].Value = tabla.Rows[i]["descripcion"].ToString();
                grdProveedoresHelados.Rows[i].Cells[1].Value = tabla.Rows[i]["nroDocProveedor"].ToString();
                grdProveedoresHelados.Rows[i].Cells[2].Value = tabla.Rows[i]["razonSocial"].ToString();
                grdProveedoresHelados.Rows[i].Cells[3].Value = tabla.Rows[i]["nombre"].ToString();
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtRazonSocial.Enabled = false;
                txtNombreHelado.Enabled = false;
                LimpiarCampos();
            }
            else
            {
                txtRazonSocial.Enabled = true;
                txtNombreHelado.Enabled = true;
                txtRazonSocial.Focus();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaProveedoresHelados altaProveedoresHelados = new FrmAltaProveedoresHelados();
            altaProveedoresHelados.ShowDialog();

            DataTable tabla = proveedoresHelados.TodosLosProveedoresHelados();
            CargarGrilla(tabla);
            altaProveedoresHelados.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (grdProveedoresHelados.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdProveedoresHelados.SelectedRows[0].Index;
                    string tipoDocumento = grdProveedoresHelados[0, indiceFilaSeleccionada].Value.ToString();
                    string nroDocumento = grdProveedoresHelados[1, indiceFilaSeleccionada].Value.ToString();
                    string razonSocial = grdProveedoresHelados[2, indiceFilaSeleccionada].Value.ToString();
                    string idHelado = grdProveedoresHelados[3, indiceFilaSeleccionada].Value.ToString();
                    string precio = grdProveedoresHelados[4, indiceFilaSeleccionada].Value.ToString();

                    FrmConsultarProveedoresHelados consultarProveedoresHelados = new FrmConsultarProveedoresHelados();
                    consultarProveedoresHelados.tipoDocumento = tipoDocumento;
                    consultarProveedoresHelados.nroDocumento = nroDocumento;
                    consultarProveedoresHelados.razonSocial = razonSocial;
                    consultarProveedoresHelados.idHelado = idHelado;
                    consultarProveedoresHelados.precio = precio;
                    consultarProveedoresHelados.ShowDialog();

                    DataTable tabla = proveedoresHelados.TodosLosProveedoresHelados();
                    CargarGrilla(tabla);
                    consultarProveedoresHelados.Close();
                }
                else
                {
                    return;
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(grdProveedoresHelados.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdProveedoresHelados.SelectedRows[0].Index;
                    string tipoDocumento = grdProveedoresHelados[0, indiceFilaSeleccionada].Value.ToString();
                    string nroDocumento = grdProveedoresHelados[1, indiceFilaSeleccionada].Value.ToString();
                    string razonSocial = grdProveedoresHelados[2, indiceFilaSeleccionada].Value.ToString();
                    string idHelado = grdProveedoresHelados[3, indiceFilaSeleccionada].Value.ToString();
                    string precio = grdProveedoresHelados[4, indiceFilaSeleccionada].Value.ToString();

                    FrmEliminarProveedoresHelados eliminarProveedoresHelados = new FrmEliminarProveedoresHelados();
                    eliminarProveedoresHelados.tipoDocumento = tipoDocumento;
                    eliminarProveedoresHelados.nroDocumento = nroDocumento;
                    eliminarProveedoresHelados.razonSocial = razonSocial;
                    eliminarProveedoresHelados.idHelado = idHelado;
                    eliminarProveedoresHelados.precio = precio;
                    eliminarProveedoresHelados.ShowDialog();

                    DataTable tabla = proveedoresHelados.TodosLosProveedoresHelados();
                    CargarGrilla(tabla);
                    eliminarProveedoresHelados.Close();
                }
                else
                {
                    return;
                }

            }
        }


        private void btnModificar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
