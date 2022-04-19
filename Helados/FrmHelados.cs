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

namespace Practico.Formularios.Abm.Helados
{
    public partial class FrmHelados : Form
    {

        Negocios.Helados helados = new Negocios.Helados();

        public FrmHelados()
        {
            InitializeComponent();
        }

        private void lblUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtNombre.Enabled = false;
                LimpiarCampos();
            }
            else
            {
                txtNombre.Enabled = true;
                txtNombre.Focus();
            }
        }
        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmHelados_Load(object sender, EventArgs e)
        {
            lblNombre.TabStop = false;
            lblHelados.TabStop = false;
            grdHelados.TabStop = false;
        }


        private void LimpiarCampos()
        {
            txtNombre.Text = "";
        }

        private void btnEscritorio_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CargarGrilla(DataTable tabla)
        {
            grdHelados.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdHelados.Rows.Add();
                grdHelados.Rows[i].Cells[0].Value = tabla.Rows[i]["idHelado"].ToString();
                grdHelados.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grdHelados.Rows[i].Cells[2].Value = tabla.Rows[i]["precio"].ToString();
                grdHelados.Rows[i].Cells[3].Value = tabla.Rows[i]["cantidadStock"].ToString();
            }
        }

        private void chkTodos_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtNombre.Enabled = false;
                LimpiarCampos();
            }
            else
            {
                txtNombre.Enabled = true;
                txtNombre.Focus();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked)  // busca todos los usuarios
            {
                DataTable tabla = helados.TodosLosHelados();
                CargarGrilla(tabla);
            }
            else  //buscar por nombre
            {
                TratamientosEspeciales tratamiento = new TratamientosEspeciales();

                // valida que haya texto en el textbox
                if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
                {
                    DataTable tabla = helados.BuscarHelado(txtNombre.Text);
                    CargarGrilla(tabla);
                }
            }

            txtNombre.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaHelados altaHelados = new FrmAltaHelados();
            altaHelados.ShowDialog();

            DataTable tabla = helados.TodosLosHelados();
            CargarGrilla(tabla);
            altaHelados.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdHelados.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdHelados.SelectedRows[0].Index;
                    string id = grdHelados[0, indiceFilaSeleccionada].Value.ToString();

                    FrmEliminarHelados eliminarHelados = new FrmEliminarHelados();
                    eliminarHelados.id = id;
                    eliminarHelados.ShowDialog();

                    DataTable tabla = helados.TodosLosHelados(); //actualiza la grilla
                    CargarGrilla(tabla);
                    eliminarHelados.Close();
                }
                else
                {
                    return;
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdHelados.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdHelados.SelectedRows[0].Index;
                    string id = grdHelados[0, indiceFilaSeleccionada].Value.ToString();

                    FrmModificarHelados modificarHelados = new FrmModificarHelados();
                    modificarHelados.id = id;
                    modificarHelados.ShowDialog();

                    DataTable tabla = helados.TodosLosHelados();
                    CargarGrilla(tabla);
                    modificarHelados.Close();
                }
                else
                {
                    return;
                }

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (grdHelados.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdHelados.SelectedRows[0].Index;
                    string id = grdHelados[0, indiceFilaSeleccionada].Value.ToString();

                    FrmConsultarHelados consultarHelados = new FrmConsultarHelados();
                    consultarHelados.id = id;
                    consultarHelados.ShowDialog();
                    consultarHelados.Close();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
