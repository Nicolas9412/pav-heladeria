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

namespace Practico.Formularios.Abm.FrutasHeladosEspeciales
{
    public partial class FrmFrutasHeladosEspeciales : Form

    {

        Negocios.FrutasHeladosEspeciales frutas = new Negocios.FrutasHeladosEspeciales();
        public FrmFrutasHeladosEspeciales()
        {
            InitializeComponent();
        }

        private void FrmFrutasHeladosEspeciales_Load(object sender, EventArgs e)
        {
            cmbHeladoEspecial.Cargar();
            cmbFruta.Cargar();
        }

        private void btnLimpiarHelado_Click(object sender, EventArgs e)
        {
            cmbHeladoEspecial.SelectedIndex = -1;
        }

        private void btnLimpiarFruta_Click(object sender, EventArgs e)
        {
            cmbFruta.SelectedIndex = -1;
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                
                cmbHeladoEspecial.Enabled = false;
                cmbFruta.Enabled = false;
                LimpiarCampos();
            }
            else
            {
                cmbHeladoEspecial.Enabled = true;
                cmbFruta.Enabled = true;
              
            }
        }
        private void LimpiarCampos()
        {
            cmbFruta.SelectedIndex = -1;
            cmbHeladoEspecial.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                DataTable tabla = frutas.TodosLasFrutas();
                CargarGrilla(tabla);
            }
            else
            {
                TratamientosEspeciales tratamiento = new TratamientosEspeciales();

                // valida que haya texto en el textbox
                if (tratamiento.ValidarAlMenosUno(pnlBuscar.Controls) == TratamientosEspeciales.Validacion.correcta)
                {
                    string comboHelado = "(0,1,2,3,4,5,6,7,8,9,10)";
                    string comboFruta = "(0,1,2,3,4,5,6,7,8,9,10)";
                    if (cmbFruta.SelectedIndex > -1)
                    {
                        comboFruta = "(" + cmbFruta.SelectedValue.ToString() + ")";
                    }
                    if (cmbHeladoEspecial.SelectedIndex > -1)
                    {
                        comboHelado = "(" + cmbHeladoEspecial.SelectedValue.ToString() + ")";
                    }

                    DataTable tabla = frutas.BuscarFruta(comboHelado, comboFruta);
                    CargarGrilla(tabla);
                }
            }

            cmbHeladoEspecial.Focus();
        }

        private void CargarGrilla(DataTable tabla)
        {
            grdTelefonos.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdTelefonos.Rows.Add();
                grdTelefonos.Rows[i].Cells[0].Value = tabla.Rows[i]["nombreProducto"].ToString();
                grdTelefonos.Rows[i].Cells[1].Value = tabla.Rows[i]["nombreFruta"].ToString();
                grdTelefonos.Rows[i].Cells[2].Value = tabla.Rows[i]["cantGramos"].ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaFrutaHeladoEspecial altaTelefonos = new FrmAltaFrutaHeladoEspecial();
            altaTelefonos.ShowDialog();

            DataTable tabla = frutas.TodosLasFrutas();
            CargarGrilla(tabla);
            altaTelefonos.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (grdTelefonos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdTelefonos.SelectedRows[0].Index;
                    string heladoEspecial = grdTelefonos[0, indiceFilaSeleccionada].Value.ToString();
                    string fruta = grdTelefonos[1, indiceFilaSeleccionada].Value.ToString();

                    FrmConsultarFrutaHeladoEspecial consultarFruta = new FrmConsultarFrutaHeladoEspecial();
                    consultarFruta.heladoEspecial = heladoEspecial;
                    consultarFruta.fruta = fruta;

                    consultarFruta.ShowDialog();

                    DataTable tabla = frutas.TodosLasFrutas();
                    CargarGrilla(tabla);
                    consultarFruta.Close();
                }
                else
                {
                    return;
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdTelefonos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdTelefonos.SelectedRows[0].Index;
                    string heladoEspecial = grdTelefonos[0, indiceFilaSeleccionada].Value.ToString();
                    string fruta = grdTelefonos[1, indiceFilaSeleccionada].Value.ToString();

                    FrmModificarFrutaHeladoEspecial modificarFruta = new FrmModificarFrutaHeladoEspecial();
                    modificarFruta.heladoEspecial = heladoEspecial;
                    modificarFruta.fruta = fruta;

                    modificarFruta.ShowDialog();

                    DataTable tabla = frutas.TodosLasFrutas();
                    CargarGrilla(tabla);
                    modificarFruta.Close();
                }
                else
                {
                    return;
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdTelefonos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdTelefonos.SelectedRows[0].Index;
                    string heladoEspecial = grdTelefonos[0, indiceFilaSeleccionada].Value.ToString();
                    string fruta = grdTelefonos[1, indiceFilaSeleccionada].Value.ToString();

                    FrmEliminarFrutaHeladoEspecial eliminarFruta = new FrmEliminarFrutaHeladoEspecial();
                    eliminarFruta.heladoEspecial = heladoEspecial;
                    eliminarFruta.fruta = fruta;

                    eliminarFruta.ShowDialog();

                    DataTable tabla = frutas.TodosLasFrutas();
                    CargarGrilla(tabla);
                    eliminarFruta.Close();
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
