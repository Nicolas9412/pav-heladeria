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
using Practico.Formularios.Abm.Usuarios;
using Practico.Negocios;

namespace Practico.Formularios.Abm
{
    public partial class FrmUsuarios : Form
    {
        Negocios.Usuarios usuarios = new Negocios.Usuarios();

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            lblNombre.TabStop = false;
            lblUsuarios.TabStop = false;
            grdUsuarios.TabStop = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (chkTodos.Checked)  // busca todos los usuarios
            {
                DataTable tabla = usuarios.TodosLosUsuarios();
                CargarGrilla(tabla);
            }
            else  //buscar por nombre
            {
                TratamientosEspeciales tratamiento = new TratamientosEspeciales();

                // valida que haya texto en el textbox
                if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
                {
                    DataTable tabla = usuarios.BuscarUsuario(txtNombre.Text);
                    CargarGrilla(tabla);
                }
            }

            txtNombre.Focus();
        }


        private void CargarGrilla(DataTable tabla)
        {
            grdUsuarios.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdUsuarios.Rows.Add();
                grdUsuarios.Rows[i].Cells[0].Value = tabla.Rows[i]["idUsuario"].ToString();
                grdUsuarios.Rows[i].Cells[1].Value = tabla.Rows[i]["nombreUsuario"].ToString();
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)  // bloquea y desbloquea el textbox
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
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }


        // ESTO NO LO DIO EN CLASES  --LUIS
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaUsuarios altaUsuarios = new FrmAltaUsuarios();
            altaUsuarios.ShowDialog();

            DataTable tabla = usuarios.TodosLosUsuarios();
            CargarGrilla(tabla);
            altaUsuarios.Close();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdUsuarios.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else  //IGUAL QUE CONSULTAR
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdUsuarios.SelectedRows[0].Index;
                    string id = grdUsuarios[0, indiceFilaSeleccionada].Value.ToString();

                    FrmEliminarUsuarios eliminarUsuarios = new FrmEliminarUsuarios();
                    eliminarUsuarios.id = id;
                    eliminarUsuarios.ShowDialog();

                    DataTable tabla = usuarios.TodosLosUsuarios(); //actualiza la grilla
                    CargarGrilla(tabla);
                    eliminarUsuarios.Close();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdUsuarios.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdUsuarios.SelectedRows[0].Index;
                    string id = grdUsuarios[0, indiceFilaSeleccionada].Value.ToString();

                    FrmModificarUsuarios modificarUsuarios = new FrmModificarUsuarios();
                    modificarUsuarios.id = id;
                    modificarUsuarios.ShowDialog();

                    DataTable tabla = usuarios.TodosLosUsuarios();
                    CargarGrilla(tabla);
                    modificarUsuarios.Close();
                }
                else
                {
                    return;
                }

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (grdUsuarios.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFilaSeleccionada = grdUsuarios.SelectedRows[0].Index;
                    string id = grdUsuarios[0, indiceFilaSeleccionada].Value.ToString();

                    FrmConsultarUsuarios consultarUsuarios = new FrmConsultarUsuarios();
                    consultarUsuarios.id = id;
                    consultarUsuarios.ShowDialog();
                    consultarUsuarios.Close();
                }
                else
                {
                    return;
                }
            }
        }



    }
}
