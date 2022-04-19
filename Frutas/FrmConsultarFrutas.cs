using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico.Formularios.Abm.Frutas
{
    public partial class FrmConsultarFrutas : Form
    {
        public string id { get; set; }
        public string nombre { get; set; }


        public FrmConsultarFrutas()
        {
            InitializeComponent();
        }

        private void FrmConsultarFrutas_Load(object sender, EventArgs e)
        {
            lblId.TabStop = false;
            lblNombre.TabStop = false;
            lblNuevo.TabStop = false;
            CargarCampos();
        }

        private void CargarCampos()
        {
            Negocios.Frutas fruta = new Negocios.Frutas();
            DataTable tabla = fruta.RecuperarFruta(Int32.Parse(id));
            id = tabla.Rows[0]["idFruta"].ToString();
            nombre = tabla.Rows[0]["nombre"].ToString();
           

            txtId.Text = id;
            txtNombre.Text = nombre;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
