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

namespace Practico.Formularios.Abm.HeladosHeladosEspeciales
{
    public partial class FrmHeladosHeladosEspeciales : Form
    {
        Negocios.HeladosHeladosEspeciales helados = new Negocios.HeladosHeladosEspeciales();
        public FrmHeladosHeladosEspeciales()
        {
            InitializeComponent();
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHeladosHeladosEspeciales_Load(object sender, EventArgs e)
        {
            cmbHeladoEspecial.Cargar();
            cmbHelado.Cargar();
            grdHeladosHeladosEspeciales.TabStop = false;
        }

        private void btnLimpiarHeladoEspecial_Click(object sender, EventArgs e)
        {
            cmbHeladoEspecial.SelectedIndex = -1;
        }

        private void btnLimpiarHelado_Click(object sender, EventArgs e)
        {
            cmbHelado.SelectedIndex = -1;
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                cmbHeladoEspecial.Enabled = false;
                cmbHelado.Enabled = false;
                LimpiarCampos();
            }
            else
            {
                cmbHeladoEspecial.Enabled = true;
                cmbHelado.Enabled = true;
            }
        }

        private void LimpiarCampos()
        {
            cmbHeladoEspecial.SelectedIndex = -1;
            cmbHelado.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                DataTable tabla = helados.todosLosHelados();
                CargarGrilla(tabla);
            }
            else
            {
                TratamientosEspeciales tratamiento = new TratamientosEspeciales();

                if (tratamiento.ValidarAlMenosUno(this.Controls) == TratamientosEspeciales.Validacion.correcta)
                {
                    string comboHeladoEspecial = "(0,1,2,3,4,5,6,7,8,9,10)";
                    string comboHelado = "(0,1,2,3,4,5,6,7,8,9,10)";

                    if (cmbHelado.SelectedIndex > -1)
                    {
                        comboHelado = "(" + cmbHelado.SelectedValue.ToString() + ")";
                    }

                    if (cmbHeladoEspecial.SelectedIndex > -1)
                    {
                        comboHeladoEspecial = "(" + cmbHeladoEspecial.SelectedValue.ToString() + ")";
                    }

                    DataTable tabla = helados.buscarHelado(comboHeladoEspecial, comboHelado);
                    CargarGrilla(tabla);
                }
            }
        }

        private void CargarGrilla(DataTable tabla)
        {
            grdHeladosHeladosEspeciales.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdHeladosHeladosEspeciales.Rows.Add();
                grdHeladosHeladosEspeciales.Rows[i].Cells[0].Value = tabla.Rows[i]["nombreProducto"].ToString();
                grdHeladosHeladosEspeciales.Rows[i].Cells[1].Value = tabla.Rows[i]["nombreHelado"].ToString();
                grdHeladosHeladosEspeciales.Rows[i].Cells[2].Value = tabla.Rows[i]["cantBochas"].ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaHeladosHeladosEspeciales altaHelados = new FrmAltaHeladosHeladosEspeciales();
            altaHelados.ShowDialog();

            DataTable tabla = helados.todosLosHelados();
            CargarGrilla(tabla);
            altaHelados.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdHeladosHeladosEspeciales.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdHeladosHeladosEspeciales.SelectedRows[0].Index;
                    string heladoEspecial = grdHeladosHeladosEspeciales[0, indiceFilaSeleccionada].Value.ToString();
                    string helado = grdHeladosHeladosEspeciales[1, indiceFilaSeleccionada].Value.ToString();

                    FrmModificarHeladosHeladosEspeciales modificarHelado = new FrmModificarHeladosHeladosEspeciales();
                    modificarHelado.heladoEspecial = heladoEspecial;
                    modificarHelado.helado = helado;

                    modificarHelado.ShowDialog();

                    DataTable tabla = helados.todosLosHelados();
                    CargarGrilla(tabla);
                    modificarHelado.Close();
                }
                else
                {
                    return;
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdHeladosHeladosEspeciales.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdHeladosHeladosEspeciales.SelectedRows[0].Index;
                    string heladoEspecial = grdHeladosHeladosEspeciales[0, indiceFilaSeleccionada].Value.ToString();
                    string helado = grdHeladosHeladosEspeciales[1, indiceFilaSeleccionada].Value.ToString();

                    FrmEliminarHeladosHeladosEspeciales eliminarHelado = new FrmEliminarHeladosHeladosEspeciales();
                    eliminarHelado.heladoEspecial = heladoEspecial;
                    eliminarHelado.helado = helado;

                    eliminarHelado.ShowDialog();

                    DataTable tabla = helados.todosLosHelados();
                    CargarGrilla(tabla);
                    eliminarHelado.Close();
                }
                else
                {
                    return;
                }

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (grdHeladosHeladosEspeciales.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdHeladosHeladosEspeciales.SelectedRows[0].Index;
                    string heladoEspecial = grdHeladosHeladosEspeciales[0, indiceFilaSeleccionada].Value.ToString();
                    string helado = grdHeladosHeladosEspeciales[1, indiceFilaSeleccionada].Value.ToString();

                    FrmConsultarHeladosHeladosEspeciales consultarHelado = new FrmConsultarHeladosHeladosEspeciales();
                    consultarHelado.heladoEspecial = heladoEspecial;
                    consultarHelado.helado = helado;

                    consultarHelado.ShowDialog();

                    DataTable tabla = helados.todosLosHelados();
                    CargarGrilla(tabla);
                    consultarHelado.Close();
                }
                else
                {
                    return;
                }

            }
        }
    }
}
