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


namespace Practico.Formularios.Abm.TelefonosEmpleados
{
    public partial class FrmTelefonosEmpleados : Form
    {
        Negocios.TelefonosEmpleados telefonosEmpleados = new Negocios.TelefonosEmpleados();

        public FrmTelefonosEmpleados()
        {
            InitializeComponent();
        }

        private void FrmTelefonosEmpleados_Load(object sender, EventArgs e)
        {
            lblNombre.TabStop = false;
            lblTelefonos.TabStop = false;
            grdTelefonos.TabStop = false;
            cmbTipo.Cargar();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtNumero.Text = "";
            cmbTipo.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = -1;
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {

            if (chkTodos.Checked)
            {
                txtNombre.Enabled = false;
                txtNumero.Enabled = false;
                cmbTipo.Enabled = false;
                LimpiarCampos();
            }
            else
            {
                txtNombre.Enabled = true;
                txtNombre.BackColor = Color.White;
                txtNumero.Enabled = true;
                txtNumero.BackColor = Color.White;
                cmbTipo.Enabled = true;
                txtNombre.Focus();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                DataTable tabla = telefonosEmpleados.TodosLosTelefonos();
                CargarGrilla(tabla);
            }
            else
            {
                TratamientosEspeciales tratamiento = new TratamientosEspeciales();

                // valida que haya texto en el textbox
                if (tratamiento.ValidarAlMenosUno(pnlBuscar.Controls) == TratamientosEspeciales.Validacion.correcta)
                {
                    string comboTipo = "(0,1,2,3,4,5,6,7,8,9,10)";
                    if (cmbTipo.SelectedIndex > -1)
                    {
                        comboTipo = "(" + cmbTipo.SelectedValue.ToString() + ")";
                    }

                    DataTable tabla = telefonosEmpleados.BuscarTelefono(txtNombre.Text, comboTipo, txtNumero.Text);
                    CargarGrilla(tabla);
                }
            }

            txtNombre.Focus();
        }

        private void CargarGrilla(DataTable tabla)
        {
            grdTelefonos.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdTelefonos.Rows.Add();
                grdTelefonos.Rows[i].Cells[0].Value = tabla.Rows[i]["nroTelefono"].ToString();
                grdTelefonos.Rows[i].Cells[1].Value = tabla.Rows[i]["descripcion"].ToString();
                grdTelefonos.Rows[i].Cells[2].Value = tabla.Rows[i]["nroDocEmpleado"].ToString();
                grdTelefonos.Rows[i].Cells[3].Value = tabla.Rows[i]["nombre"].ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaTelefonosEmpleados altaTelefonos = new FrmAltaTelefonosEmpleados();
            altaTelefonos.ShowDialog();

            DataTable tabla = telefonosEmpleados.TodosLosTelefonos();
            CargarGrilla(tabla);
            altaTelefonos.Close();
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    string nroTelefono = grdTelefonos[0, indiceFilaSeleccionada].Value.ToString();
                    string nombre = grdTelefonos[3, indiceFilaSeleccionada].Value.ToString();

                    FrmModificarTelefonosEmpleados modificarTelefonos = new FrmModificarTelefonosEmpleados();
                    modificarTelefonos.nroTelefono = nroTelefono;
                    modificarTelefonos.nombre = nombre;

                    modificarTelefonos.ShowDialog();

                    DataTable tabla = telefonosEmpleados.TodosLosTelefonos();
                    CargarGrilla(tabla);
                    modificarTelefonos.Close();
                }
                else
                {
                    return;
                }

            }
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
                    string nroTelefono = grdTelefonos[0, indiceFilaSeleccionada].Value.ToString();
                    string nombre = grdTelefonos[3, indiceFilaSeleccionada].Value.ToString();

                    FrmConsultarTelefonosEmpleados consultarTelefonos = new FrmConsultarTelefonosEmpleados();
                    consultarTelefonos.nroTelefono = nroTelefono;
                    consultarTelefonos.nombre = nombre;

                    consultarTelefonos.ShowDialog();

                    DataTable tabla = telefonosEmpleados.TodosLosTelefonos();
                    CargarGrilla(tabla);
                    consultarTelefonos.Close();
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
                    string nroTelefono = grdTelefonos[0, indiceFilaSeleccionada].Value.ToString();

                    FrmEliminarTelefonosEmpleados eliminarTelefonos = new FrmEliminarTelefonosEmpleados();
                    eliminarTelefonos.nroTelefono = nroTelefono;

                    eliminarTelefonos.ShowDialog();

                    DataTable tabla = telefonosEmpleados.TodosLosTelefonos(); //actualiza la grilla
                    CargarGrilla(tabla);
                    eliminarTelefonos.Close();
                }
                else
                {
                    return;
                }

            }
        }
    }
}
