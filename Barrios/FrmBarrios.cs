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


namespace Practico.Formularios.Abm.Barrios
{
    public partial class FrmBarrios : Form
    {
        Negocios.Barrios barrios = new Negocios.Barrios();

        public FrmBarrios()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            cmbLocalidad.SelectedIndex = -1;
        }

        private void FrmBarrios_Load(object sender, EventArgs e)
        {
            lblNombre.TabStop = false;
            lblBarrios.TabStop = false;
            grdBarrios.TabStop = false;
            cmbLocalidad.Cargar();
            LimpiarCampos();
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtNombre.Enabled = false;
                txtNombre.BackColor = Color.SlateGray;
                cmbLocalidad.Enabled = false;
                cmbLocalidad.BackColor = Color.SlateGray;
                LimpiarCampos();
            }
            else
            {
                txtNombre.Enabled = true;
                txtNombre.BackColor = Color.White;
                cmbLocalidad.Enabled = true;
                cmbLocalidad.BackColor = Color.White;
                txtNombre.Focus();
            }
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarLocalidad_Click(object sender, EventArgs e)
        {
            cmbLocalidad.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                DataTable tabla = barrios.TodosLosBarrios();
                CargarGrilla(tabla);
            }
            else
            {
                TratamientosEspeciales tratamiento = new TratamientosEspeciales();

                if (tratamiento.ValidarAlMenosUno(this.Controls) == TratamientosEspeciales.Validacion.correcta)
                {
                    string comboLocalidad = "(0,1,2,3,4)";
                    if (cmbLocalidad.SelectedIndex > -1)
                    {
                        comboLocalidad = "(" + cmbLocalidad.SelectedValue.ToString() + ")";
                    }
                    DataTable tabla = barrios.BuscarBarrio(txtNombre.Text,comboLocalidad);
                    CargarGrilla(tabla);
                }

            }
        }

        private void CargarGrilla(DataTable tabla)
        {
            grdBarrios.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdBarrios.Rows.Add();
                grdBarrios.Rows[i].Cells[0].Value = tabla.Rows[i]["idBarrio"].ToString();
                grdBarrios.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grdBarrios.Rows[i].Cells[2].Value = tabla.Rows[i]["idLocalidad"].ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaBarrios altaBarrios = new FrmAltaBarrios();
            altaBarrios.ShowDialog();

            DataTable tabla = barrios.TodosLosBarrios();
            CargarGrilla(tabla);
            altaBarrios.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdBarrios.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdBarrios.SelectedRows[0].Index;
                    string idBarrio = grdBarrios[0, indiceFilaSeleccionada].Value.ToString();
                 

                    FrmModificarBarrios modificarBarrios = new FrmModificarBarrios();
                    modificarBarrios.idBarrio = idBarrio;
                    modificarBarrios.ShowDialog();

                    DataTable tabla = barrios.TodosLosBarrios();
                    CargarGrilla(tabla);
                    modificarBarrios.Close();
                }
                else
                {
                    return;
                }

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (grdBarrios.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdBarrios.SelectedRows[0].Index;
                    string idBarrio = grdBarrios[0, indiceFilaSeleccionada].Value.ToString();

                    FrmConsultarBarrios consultarBarrios = new FrmConsultarBarrios();
                    consultarBarrios.idBarrio = idBarrio;

                    consultarBarrios.ShowDialog();
                    consultarBarrios.Close();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdBarrios.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdBarrios.SelectedRows[0].Index;
                    string idBarrio = grdBarrios[0, indiceFilaSeleccionada].Value.ToString();

                    FrmEliminarBarrios eliminarBarrios = new FrmEliminarBarrios();
                    eliminarBarrios.idBarrio = idBarrio;
                    
                    eliminarBarrios.ShowDialog();

                    DataTable tabla = barrios.TodosLosBarrios(); //actualiza la grilla
                    CargarGrilla(tabla);
                    eliminarBarrios.Close();
                }
                else
                {
                    return;
                }

            }
        }
    }
}
