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

namespace Practico.Formularios.Abm.Turnos
{
    public partial class FrmTurnos : Form
    {
        Negocios.Turnos turnos = new Negocios.Turnos();

        public FrmTurnos()
        {
            InitializeComponent();
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtNombre.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                DataTable tabla = turnos.TodosLosTurnos();
                CargarGrilla(tabla);
            }
            else
            {
                TratamientosEspeciales tratamiento = new TratamientosEspeciales();

                if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
                {
                    DataTable tabla = turnos.BuscarTurno(txtNombre.Text);
                    CargarGrilla(tabla);
                }
            }

            txtNombre.Focus();
        }

        private void CargarGrilla(DataTable tabla)
        {
            grdTurnos.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdTurnos.Rows.Add();
                grdTurnos.Rows[i].Cells[0].Value = tabla.Rows[i]["idTurno"].ToString();
                grdTurnos.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grdTurnos.Rows[i].Cells[2].Value = tabla.Rows[i]["horaInicioT"].ToString();
                grdTurnos.Rows[i].Cells[3].Value = tabla.Rows[i]["horaFinT"].ToString();
                grdTurnos.Rows[i].Cells[4].Value = tabla.Rows[i]["tipoDocSupervisor"].ToString();
                grdTurnos.Rows[i].Cells[5].Value = tabla.Rows[i]["nroDocSupervisor"].ToString();
            }
        }

        private void FrmTurnos_Load(object sender, EventArgs e)
        {
            lblNombre.TabStop = false;
            lblTurnos.TabStop = false;
            grdTurnos.TabStop = false;
            LimpiarCampos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaTurnos altaTurnos = new FrmAltaTurnos();
            altaTurnos.ShowDialog();

            DataTable tabla = turnos.TodosLosTurnos();
            CargarGrilla(tabla);
            altaTurnos.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (grdTurnos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdTurnos.SelectedRows[0].Index;
                    string idTurno = grdTurnos[0, indiceFilaSeleccionada].Value.ToString();
                   

                    FrmConsultarTurnos consultarTurnos = new FrmConsultarTurnos();
                    consultarTurnos.idTurno = idTurno;

                    consultarTurnos.ShowDialog();
                    consultarTurnos.Close();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdTurnos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdTurnos.SelectedRows[0].Index;
                    string idTurno = grdTurnos[0, indiceFilaSeleccionada].Value.ToString();
                    

                    FrmEliminarTurnos eliminarTurnos = new FrmEliminarTurnos();
                    eliminarTurnos.idTurno = idTurno;

                    eliminarTurnos.ShowDialog();

                    DataTable tabla = turnos.TodosLosTurnos(); //actualiza la grilla
                    CargarGrilla(tabla);
                    eliminarTurnos.Close();
                }
                else
                {
                    return;
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdTurnos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdTurnos.SelectedRows[0].Index;
                    string idTurno = grdTurnos[0, indiceFilaSeleccionada].Value.ToString();
                   

                    FrmModificarTurnos modificarTurnos = new FrmModificarTurnos();
                    modificarTurnos.idTurno = idTurno;  // tipoDoc es literalmente el texto del tipo, NO el codigo
                    modificarTurnos.ShowDialog();

                    DataTable tabla = turnos.TodosLosTurnos();
                    CargarGrilla(tabla);
                    modificarTurnos.Close();
                }
                else
                {
                    return;
                }

            }
        }
    }
}
