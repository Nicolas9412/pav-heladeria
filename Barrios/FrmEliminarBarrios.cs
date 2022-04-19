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
    public partial class FrmEliminarBarrios : Form
    {
        public string idBarrio { get; set; }
        public string nombre { get; set; }
        public string localidad { get; set; }

        public FrmEliminarBarrios()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEliminarBarrios_Load(object sender, EventArgs e)
        {
            lblId.TabStop = false;
            lblLocalidad.TabStop = false;
            lblNombre.TabStop = false;
            cmbLocalidad.Cargar();
            CargarCampos();
        }

        private void CargarCampos()
        {
            Negocios.Barrios barrios = new Negocios.Barrios();
            DataTable tabla = barrios.RecuperarBarrio(Int32.Parse(idBarrio));
            idBarrio = tabla.Rows[0]["idBarrio"].ToString();
            nombre = tabla.Rows[0]["nombre"].ToString();
            localidad = tabla.Rows[0]["idLocalidad"].ToString();

            txtId.Text = idBarrio;
            txtNombre.Text = nombre;
            cmbLocalidad.SelectedValue = localidad;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Negocios.Barrios barrios = new Negocios.Barrios();

            if (barrios.EliminarBarrio(Int32.Parse(idBarrio)) == Negocios.Barrios.Respuesta.validacionCorrecta)
            {
                MessageBox.Show("Eliminado correctamente!", "Informacion",
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
