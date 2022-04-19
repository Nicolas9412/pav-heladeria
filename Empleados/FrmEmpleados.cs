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

namespace Practico.Formularios.Abm.Empleados
{
    public partial class FrmEmpleados : Form
    {
        Negocios.Empleados empleados = new Negocios.Empleados();
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                cmbTurno.Enabled = false;
                cmbBarrio.Enabled = false;
                LimpiarCampos();
            }
            else
            {
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                cmbTurno.Enabled = true;
                cmbBarrio.Enabled = true;
                txtNombre.Focus();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbBarrio.SelectedIndex = -1;
            cmbTurno.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked) // busca todos los usuarios
            {
                DataTable tabla = empleados.TodosLosEmpleados();
                CargarGrilla(tabla);
            }
            else //buscar por nombre
            {
                TratamientosEspeciales tratamiento = new TratamientosEspeciales();

                // valida que haya texto en el textbox
                if (tratamiento.ValidarAlMenosUno(pnlBuscar.Controls) == TratamientosEspeciales.Validacion.correcta)
                {
                    string comboTurno = "(0,1,2,3,4,5,6,7,8,9,10)";
                    if (cmbTurno.SelectedIndex > -1)
                    {
                        comboTurno = "(" + cmbTurno.SelectedValue.ToString() + ")";
                    }
                    string comboBarrio = "(0,1,2,3,4,5,6,7,8,9,10)";
                    if (cmbBarrio.SelectedIndex > -1)
                    {
                        comboBarrio = "(" + cmbBarrio.SelectedValue.ToString() + ")" ;
                    }
                    DataTable tabla = empleados.BuscarEmpleado(txtNombre.Text, txtApellido.Text,
                        comboTurno, comboBarrio);
                    CargarGrilla(tabla);
                }
            }
        }

        private void CargarGrilla(DataTable tabla)
        {
            grdEmpleados.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdEmpleados.Rows.Add();
                grdEmpleados.Rows[i].Cells[0].Value = tabla.Rows[i]["descripcion"].ToString();
                grdEmpleados.Rows[i].Cells[1].Value = tabla.Rows[i]["nroDoc"].ToString();
                grdEmpleados.Rows[i].Cells[2].Value = tabla.Rows[i]["nombre"].ToString();
                grdEmpleados.Rows[i].Cells[3].Value = tabla.Rows[i]["apellido"].ToString();
                grdEmpleados.Rows[i].Cells[4].Value = tabla.Rows[i]["nombreTurno"].ToString();
                grdEmpleados.Rows[i].Cells[5].Value = tabla.Rows[i]["nombreBarrio"].ToString();
            }
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            lblNombre.TabStop = false;
            lblEmpleados.TabStop = false;
            grdEmpleados.TabStop = false;
            cmbTurno.Cargar();
            cmbBarrio.Cargar();
            LimpiarCampos();
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaEmpleados altaEmpleados = new FrmAltaEmpleados();
            altaEmpleados.ShowDialog();

            DataTable tabla = empleados.TodosLosEmpleados();
            CargarGrilla(tabla);
            altaEmpleados.Close();
        }

        private void btnLimpiarBarrio_Click(object sender, EventArgs e)
        {
            cmbBarrio.SelectedIndex = -1;
        }

        private void btnLimpiarTurno_Click(object sender, EventArgs e)
        {
            cmbTurno.SelectedIndex = -1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdEmpleados.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdEmpleados.SelectedRows[0].Index;
                    string tipoDoc = grdEmpleados[0, indiceFilaSeleccionada].Value.ToString();
                    string nroDoc = grdEmpleados[1, indiceFilaSeleccionada].Value.ToString();

                    FrmModificarEmpleados modificarEmpleados = new FrmModificarEmpleados();
                    modificarEmpleados.tipoDoc = tipoDoc;  // tipoDoc es literalmente el texto del tipo, NO el codigo
                    modificarEmpleados.nroDoc = nroDoc;
                    modificarEmpleados.ShowDialog();

                    DataTable tabla = empleados.TodosLosEmpleados();
                    CargarGrilla(tabla);
                    modificarEmpleados.Close();
                }
                else
                {
                    return;
                }

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (grdEmpleados.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdEmpleados.SelectedRows[0].Index;
                    string tipoDoc = grdEmpleados[0, indiceFilaSeleccionada].Value.ToString();
                    string nroDoc = grdEmpleados[1, indiceFilaSeleccionada].Value.ToString();

                    FrmConsultarEmpleados consultarEmpleados = new FrmConsultarEmpleados();
                    consultarEmpleados.tipoDoc = tipoDoc; // tipoDoc es literalmente el texto del tipo, NO el codigo
                    consultarEmpleados.nroDoc = nroDoc;

                    consultarEmpleados.ShowDialog();
                    consultarEmpleados.Close();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdEmpleados.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdEmpleados.SelectedRows[0].Index;
                    string tipoDoc = grdEmpleados[0, indiceFilaSeleccionada].Value.ToString();
                    string nroDoc = grdEmpleados[1, indiceFilaSeleccionada].Value.ToString();

                    FrmEliminarEmpleados eliminarEmpleados = new FrmEliminarEmpleados();
                    eliminarEmpleados.tipoDoc = tipoDoc;  // tipoDoc es literalmente el texto del tipo, NO el codigo
                    eliminarEmpleados.nroDoc = nroDoc;

                    eliminarEmpleados.ShowDialog();

                    DataTable tabla = empleados.TodosLosEmpleados(); //actualiza la grilla
                    CargarGrilla(tabla);
                    eliminarEmpleados.Close();
                }
                else
                {
                    return;
                }

            }
        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
