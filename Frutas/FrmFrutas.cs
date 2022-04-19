using Practico.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico.Formularios.Abm.Frutas
{
    public partial class FrmFrutas : Form
    {
        Negocios.Frutas frutas = new Negocios.Frutas();
        public FrmFrutas()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked)  // busca todas las frutas
            {
                DataTable tabla = frutas.TodasLasFrutas();
                CargarGrilla(tabla);
            }
            else  //buscar por nombre
            {
                TratamientosEspeciales tratamiento = new TratamientosEspeciales();

                // valida que haya texto en el textbox
                if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
                {
                    DataTable tabla = frutas.BuscarFruta(txtNombre.Text);
                    CargarGrilla(tabla);
                }
            }

            txtNombre.Focus();
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void grdFrutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmFrutas_Load(object sender, EventArgs e)
        {
            lblNombre.TabStop = false;
            lblFrutas.TabStop = false;
            grdFrutas.TabStop = false;
        }

        private void CargarGrilla(DataTable tabla)
        {
            grdFrutas.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdFrutas.Rows.Add();
                grdFrutas.Rows[i].Cells[0].Value = tabla.Rows[i]["idFruta"].ToString();
                grdFrutas.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
            }
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
            FrmAltaFrutas altaFrutas = new FrmAltaFrutas();
            altaFrutas.ShowDialog();

            DataTable tabla = frutas.TodasLasFrutas();
            CargarGrilla(tabla);
            altaFrutas.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (grdFrutas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdFrutas.SelectedRows[0].Index;
                    string id = grdFrutas[0, indiceFilaSeleccionada].Value.ToString();

                    FrmConsultarFrutas consultarFrutas = new FrmConsultarFrutas();
                    consultarFrutas.id = id;
                    consultarFrutas.ShowDialog();
                    consultarFrutas.Close();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdFrutas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdFrutas.SelectedRows[0].Index;
                    string id = grdFrutas[0, indiceFilaSeleccionada].Value.ToString();

                    FrmModificarFrutas modificarFrutas = new FrmModificarFrutas();
                    modificarFrutas.id = id;
                    modificarFrutas.ShowDialog();

                    DataTable tabla = frutas.TodasLasFrutas();
                    CargarGrilla(tabla);
                    modificarFrutas.Close();
                }
                else
                {
                    return;
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdFrutas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdFrutas.SelectedRows[0].Index;
                    string id = grdFrutas[0, indiceFilaSeleccionada].Value.ToString();

                    FrmEliminarFrutas eliminarFrutas = new FrmEliminarFrutas();
                    eliminarFrutas.id = id;
                    eliminarFrutas.ShowDialog();

                    DataTable tabla = frutas.TodasLasFrutas(); //actualiza la grilla
                    CargarGrilla(tabla);
                    eliminarFrutas.Close();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
