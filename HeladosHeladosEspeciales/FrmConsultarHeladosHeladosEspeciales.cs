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
    public partial class FrmConsultarHeladosHeladosEspeciales : Form
    {
        
        public string heladoEspecial { get; set; }
        public string helado { get; set; }
        public string cantidad { get; set; }

        public FrmConsultarHeladosHeladosEspeciales()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultarHeladosHeladosEspeciales_Load(object sender, EventArgs e)
        {
            cmbHelado.Cargar();
            cmbHeladoEspecial.Cargar();
            CargarCampos();
        }

        private void CargarCampos()
        {
            Negocios.HeladosHeladosEspeciales helados = new Negocios.HeladosHeladosEspeciales();
            DataTable tabla = helados.RecuperarHelado(heladoEspecial, helado);

            cantidad = tabla.Rows[0]["cantBochas"].ToString();

            cmbHeladoEspecial.SelectedValue = tabla.Rows[0]["idHeladoEspecial"];
            cmbHelado.SelectedValue = tabla.Rows[0]["idHelado"];
            txtCantidad.Text = cantidad;
        }
    }
}
