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
using Practico.Formularios.Abm.Proveedores;
using Practico.Negocios;

namespace Practico.Formularios.Abm.Proveedores
{
    public partial class FrmProveedores : Form
    {
        Negocios.Proveedores proveedores = new Negocios.Proveedores();
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            lblRazónSocial.TabStop = false;
            lblProveedores.TabStop = false;
            grdProveedores.TabStop = false;
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked)  // busca todos los proveedores
            {
                DataTable tabla = proveedores.TodosLosProveedores();
                CargarGrilla(tabla);
            }
            else  //buscar por razón social
            {
                TratamientosEspeciales tratamiento = new TratamientosEspeciales();

                // valida que haya texto en el textbox
                if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
                {
                    DataTable tabla = proveedores.BuscarProveedor(txtRazónSocial.Text);
                    CargarGrilla(tabla);
                }
            }

            txtRazónSocial.Focus();
        }

        private void CargarGrilla(DataTable tabla)
        {
            grdProveedores.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdProveedores.Rows.Add();
                grdProveedores.Rows[i].Cells[0].Value = tabla.Rows[i]["descripcion"].ToString();
                grdProveedores.Rows[i].Cells[1].Value = tabla.Rows[i]["nroDocumento"].ToString();
                grdProveedores.Rows[i].Cells[2].Value = tabla.Rows[i]["razonSocial"].ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaProveedores altaProveedores = new FrmAltaProveedores();
            altaProveedores.ShowDialog();

            DataTable tabla = proveedores.TodosLosProveedores();
            CargarGrilla(tabla);
            altaProveedores.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdProveedores.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdProveedores.SelectedRows[0].Index;
                    string tipoDocumento = grdProveedores[0, indiceFilaSeleccionada].Value.ToString();
                    string nroDocumento = grdProveedores[1, indiceFilaSeleccionada].Value.ToString();

                    FrmModificarProveedores modificarProveedores = new FrmModificarProveedores();
                    modificarProveedores.tipoDocumento = tipoDocumento;
                    modificarProveedores.nroDocumento = nroDocumento;
                    modificarProveedores.ShowDialog();

                    DataTable tabla = proveedores.TodosLosProveedores();
                    CargarGrilla(tabla);
                    modificarProveedores.Close();
                }
                else
                {
                    return;
                }

            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdProveedores.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdProveedores.SelectedRows[0].Index;
                    string tipoDocumento = grdProveedores[0, indiceFilaSeleccionada].Value.ToString();
                    string nroDocumento = grdProveedores[1, indiceFilaSeleccionada].Value.ToString();

                    FrmEliminarProveedores eliminarProveedores = new FrmEliminarProveedores();
                    eliminarProveedores.tipoDocumento = tipoDocumento;
                    eliminarProveedores.nroDocumento = nroDocumento;

                    eliminarProveedores.ShowDialog();

                    DataTable tabla = proveedores.TodosLosProveedores(); //actualiza la grilla
                    CargarGrilla(tabla);
                    eliminarProveedores.Close();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (grdProveedores.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdProveedores.SelectedRows[0].Index;
                    string tipoDocumento = grdProveedores[0, indiceFilaSeleccionada].Value.ToString();
                    string nroDocumento = grdProveedores[1, indiceFilaSeleccionada].Value.ToString();

                    FrmConsultarProveedores consultarProveedores = new FrmConsultarProveedores();
                    consultarProveedores.tipoDocumento = tipoDocumento;
                    consultarProveedores.nroDocumento = nroDocumento;

                    consultarProveedores.ShowDialog();
                    consultarProveedores.Close();
                }
                else
                {
                    return;
                }
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtRazónSocial.Enabled = false;
                txtRazónSocial.BackColor = Color.SlateGray;
                
            }
            else
            {
                txtRazónSocial.Enabled = true;
                txtRazónSocial.BackColor = Color.White;
                txtRazónSocial.Focus();
            }
        }
    }
}
