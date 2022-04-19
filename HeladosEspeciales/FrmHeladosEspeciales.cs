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
using Practico.Formularios.Abm.HeladosEspeciales;
using Practico.Negocios;

namespace Practico.Formularios.Abm.HeladosEspeciales
{
    public partial class FrmHeladosEspeciales : Form
    {
        Negocios.HeladosEspeciales heladosEspeciales = new Negocios.HeladosEspeciales();
        public FrmHeladosEspeciales()
        {
            InitializeComponent();
        }

        private void FrmHeladosEspeciales_Load(object sender, EventArgs e)
        {
            lblNombre.TabStop = false;
            lblHeladosEspeciales.TabStop = false;
            grdHeladoEspecial.TabStop = false;
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked)  // busca todos los helados especiales
            {
                DataTable tabla = heladosEspeciales.TodosLosHeladosEspeciales();
                CargarGrilla(tabla);
            }
            else  //buscar por nombre del helado especiales
            {
                TratamientosEspeciales tratamiento = new TratamientosEspeciales();

                // valida que haya texto en el textbox
                if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
                {
                    DataTable tabla = heladosEspeciales.BuscarHeladosEspeciales(txtHeladosEspeciales.Text);
                    CargarGrilla(tabla);
                }
            }

            txtHeladosEspeciales.Focus();
        }

        private void CargarGrilla(DataTable tabla)
        {
            grdHeladoEspecial.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdHeladoEspecial.Rows.Add();
                grdHeladoEspecial.Rows[i].Cells[0].Value = tabla.Rows[i]["idHeladoEspecial"].ToString();
                grdHeladoEspecial.Rows[i].Cells[1].Value = tabla.Rows[i]["nombreProducto"].ToString();
                grdHeladoEspecial.Rows[i].Cells[2].Value = tabla.Rows[i]["precio"].ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaHeladosEspeciales altaHeladoEspecial = new FrmAltaHeladosEspeciales();
            altaHeladoEspecial.ShowDialog();

            DataTable tabla = heladosEspeciales.TodosLosHeladosEspeciales();
            CargarGrilla(tabla);
            altaHeladoEspecial.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdHeladoEspecial.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdHeladoEspecial.SelectedRows[0].Index;
                    string idHeladoEspecial = grdHeladoEspecial[0, indiceFilaSeleccionada].Value.ToString();

                    FrmModificarHeladosEspeciales modificarHeladosEspeciales = new FrmModificarHeladosEspeciales();
                    modificarHeladosEspeciales.idHeladoEspecial = idHeladoEspecial;
                    modificarHeladosEspeciales.ShowDialog();

                    DataTable tabla = heladosEspeciales.TodosLosHeladosEspeciales();
                    CargarGrilla(tabla);
                    modificarHeladosEspeciales.Close();
                }
                else
                {
                    return;
                }

            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdHeladoEspecial.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdHeladoEspecial.SelectedRows[0].Index;
                    string idHeladoEspecial = grdHeladoEspecial[0, indiceFilaSeleccionada].Value.ToString();

                    FrmEliminarHeladosEspeciales eliminarHeladoEspeciales = new FrmEliminarHeladosEspeciales();
                    eliminarHeladoEspeciales.idHeladoEspecial = idHeladoEspecial;

                    eliminarHeladoEspeciales.ShowDialog();

                    DataTable tabla = heladosEspeciales.TodosLosHeladosEspeciales(); //actualiza la grilla
                    CargarGrilla(tabla);
                    eliminarHeladoEspeciales.Close();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (grdHeladoEspecial.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdHeladoEspecial.SelectedRows[0].Index;
                    string idHeladoEspecial = grdHeladoEspecial[0, indiceFilaSeleccionada].Value.ToString();

                    FrmConsultarHeladosEspeciales consultarHeladoEspecial = new FrmConsultarHeladosEspeciales();
                    consultarHeladoEspecial.idHeladoEspecial = idHeladoEspecial;

                    consultarHeladoEspecial.ShowDialog();
                    consultarHeladoEspecial.Close();
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
                txtHeladosEspeciales.Enabled = false;
                LimpiarCampos();
            }
            else
            {
                txtHeladosEspeciales.Enabled = true;
                txtHeladosEspeciales.Focus();
            }
        }

        private void LimpiarCampos()
        {
            txtHeladosEspeciales.Text = "";
        }
    }
}
