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
using Practico.Formularios.Abm.Localidades;
using Practico.Negocios;

namespace Practico.Formularios.Abm.Localidades
{
    public partial class FrmLocalidades : Form
    {
        Negocios.Localidades localidades = new Negocios.Localidades();

        public FrmLocalidades()
        {
            InitializeComponent();
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLocalidades_Load(object sender, EventArgs e)
        {
            lblLocalidades.TabStop = false;
            lblNombre.TabStop = false;
            grdLocalidades.TabStop = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (chkTodos.Checked)  // busca todos las localidades
            {
                DataTable tabla = localidades.TodasLasLocalidades();
                CargarGrilla(tabla);
            }
            else  //buscar por nombre
            {
                TratamientosEspeciales tratamiento = new TratamientosEspeciales();

                // valida que haya texto en el textbox
                if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
                {
                    DataTable tabla = localidades.BuscarLocalidad(txtNombre.Text);
                    CargarGrilla(tabla);
                }
            }

            txtNombre.Focus();
        }

        private void CargarGrilla(DataTable tabla)
        {
            grdLocalidades.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdLocalidades.Rows.Add();
                grdLocalidades.Rows[i].Cells[0].Value = tabla.Rows[i]["idLocalidad"].ToString();
                grdLocalidades.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
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
            FrmAltaLocalidades altaUsuarios = new FrmAltaLocalidades();
            altaUsuarios.ShowDialog();

            DataTable tabla = localidades.TodasLasLocalidades();
            CargarGrilla(tabla);
            altaUsuarios.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdLocalidades.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdLocalidades.SelectedRows[0].Index;
                    int id = Convert.ToInt32(grdLocalidades[0, indiceFilaSeleccionada].Value);

                    if (localidades.EliminarLocalidad(id) == Negocios.Localidades.Respuesta.validacionCorrecta)
                    {
                        MessageBox.Show("Localidad eliminada correctamente", "Informacion",
                            buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    DataTable tabla = localidades.TodasLasLocalidades();
                    CargarGrilla(tabla); 
                }
                else
                {
                    return;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdLocalidades.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdLocalidades.SelectedRows[0].Index;
                    string id = grdLocalidades[0, indiceFilaSeleccionada].Value.ToString();

                    FrmModificarLocalidades modificarLocalidades = new FrmModificarLocalidades();
                    modificarLocalidades.id = id;
                    modificarLocalidades.ShowDialog();

                    DataTable tabla = localidades.TodasLasLocalidades();
                    CargarGrilla(tabla);
                    modificarLocalidades.Close();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
