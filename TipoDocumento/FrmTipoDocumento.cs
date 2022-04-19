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
using Practico.Formularios.Abm.TipoDocumento;
using Practico.Negocios;

namespace Practico.Formularios.Abm.Localidades
{
    public partial class FrmTipoDocumento : Form
    {
        Negocios.TipoDocumento tipoDocumento = new Negocios.TipoDocumento();

        public FrmTipoDocumento()
        {
            InitializeComponent();
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTipoDocumento_Load(object sender, EventArgs e)
        {
            lblTipoDoc.TabStop = false;
            lblTipoDocumento.TabStop = false;
            grdTipoDoc.TabStop = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (chkTodos.Checked)  // busca todos las localidades
            {
                DataTable tabla = tipoDocumento.TodosLosTipoDocumento();
                CargarGrilla(tabla);
            }
            else  //buscar por nombre
            {
                TratamientosEspeciales tratamiento = new TratamientosEspeciales();

                // valida que haya texto en el textbox
                if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
                {
                    DataTable tabla = tipoDocumento.BuscarTipoDocumento(txtNombre.Text);
                    CargarGrilla(tabla);
                }
            }

            txtNombre.Focus();
        }

        private void CargarGrilla(DataTable tabla)
        {
            grdTipoDoc.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdTipoDoc.Rows.Add();
                grdTipoDoc.Rows[i].Cells[0].Value = tabla.Rows[i]["tipoDocumento"].ToString();
                grdTipoDoc.Rows[i].Cells[1].Value = tabla.Rows[i]["descripcion"].ToString();
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)  // bloquea y desbloquea el textbox
        {
            if (chkTodos.Checked)
            {
                txtNombre.Enabled = false;
                txtNombre.BackColor = Color.SlateGray;
                LimpiarCampos();
            }
            else
            {
                txtNombre.Enabled = true;
                txtNombre.BackColor = Color.White;
                txtNombre.Focus();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaTipoDocumento altaTipoDocumento = new FrmAltaTipoDocumento();
            altaTipoDocumento.ShowDialog();

            DataTable tabla = tipoDocumento.TodosLosTipoDocumento();
            CargarGrilla(tabla);
            altaTipoDocumento.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdTipoDoc.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdTipoDoc.SelectedRows[0].Index;
                    int id = Convert.ToInt32(grdTipoDoc[0, indiceFilaSeleccionada].Value);

                    if (tipoDocumento.EliminarTipoDocumento(id) == Negocios.TipoDocumento.Respuesta.validacionCorrecta)
                    {
                        MessageBox.Show("Tipo de documento eliminado correctamente", "Informacion",
                            buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

                        DataTable tabla = tipoDocumento.TodosLosTipoDocumento();
                        CargarGrilla(tabla);
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdTipoDoc.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdTipoDoc.SelectedRows[0].Index;
                    string id = grdTipoDoc[0, indiceFilaSeleccionada].Value.ToString();

                    FrmModificarTipoDocumento modificarTipoDocumento = new FrmModificarTipoDocumento();
                    modificarTipoDocumento.id = id;
                    modificarTipoDocumento.ShowDialog();

                    DataTable tabla = tipoDocumento.TodosLosTipoDocumento();
                    CargarGrilla(tabla);
                    modificarTipoDocumento.Close();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
