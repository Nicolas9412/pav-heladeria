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

namespace Practico.Formularios.Abm.Turnos
{
    public partial class FrmConsultarTurnos : Form
    {
        public string idTurno { get; set; }
        public string nombre { get; set; }
        public string horaInicio { get; set; }
        public string horaFin { get; set; }
        public string nroDoc { get; set; }

        public string tipoDoc { get; set; }
        public string nombreJefe { get; set; }

        public FrmConsultarTurnos()
        {
            InitializeComponent();
        }

        private void FrmConsultarTurnos_Load(object sender, EventArgs e)
        {
            lblId.TabStop = false;
            lblHoraFin.TabStop = false;
            lblHoraInicio.TabStop = false;
            lblNombre.TabStop = false;
            lblNuevo.TabStop = false;
            lblNumeroD.TabStop = false;
            lblTipo.TabStop = false;
            CargarComboNombre();
            CargarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCampos()
        {
            Negocios.Turnos turnos = new Negocios.Turnos();
            DataTable tabla = turnos.RecuperarTurno(Int32.Parse(idTurno));

            idTurno = tabla.Rows[0]["idTurno"].ToString();
            nombre = tabla.Rows[0]["nombre"].ToString();
            horaInicio = tabla.Rows[0]["horaInicio"].ToString();
            horaFin = tabla.Rows[0]["horaFin"].ToString();
            nroDoc = tabla.Rows[0]["nroDocSupervisor"].ToString();
            tipoDoc = tabla.Rows[0]["tipoDocSupervisor"].ToString();
            nombreJefe = tabla.Rows[0]["nombreJefe"].ToString();

            txtId.Text = idTurno;
            txtNombre.Text = nombre;
            pckHoraInicio.Value = DateTime.Parse(horaInicio);
            pckHoraFin.Value = DateTime.Parse(horaFin);

            if (nroDoc != "")
            {
                cmbNombre.SelectedValue = nombreJefe;
                cmbTipo.SelectedValue = tipoDoc;
                cmbDocumento.SelectedValue = nroDoc;
            }

        }

        private void cmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarComboDocumento();
        }


        private void cmbNombre_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarComboTipo();
        }


        public void CargarComboTipo()
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT DISTINCT TD.* FROM Empleados E JOIN TiposDocumento TD ON (E.tipoDoc = TD.tipoDocumento)"
                         + "WHERE nombre LIKE '%" + cmbNombre.SelectedValue + "%'";
            cmbTipo.DisplayMember = "descripcion";
            cmbTipo.ValueMember = "tipoDocumento";
            cmbTipo.DataSource = baseDatos.Consulta(sql);
        }

        public void CargarComboDocumento()
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT E.* FROM Empleados E WHERE tipoDoc LIKE '%" + cmbTipo.SelectedValue + "%'"
                         + "AND nombre LIKE '%" + cmbNombre.SelectedValue + "%'";
            cmbDocumento.ValueMember = "nroDoc";
            cmbDocumento.DisplayMember = "nroDoc";
            cmbDocumento.DataSource = baseDatos.Consulta(sql);
        }
        private void CargarComboNombre()
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT DISTINCT E.nombre FROM Empleados E ";
            cmbNombre.ValueMember = "nombre";
            cmbNombre.DisplayMember = "nombre";
            cmbNombre.DataSource = baseDatos.Consulta(sql);
        }
    }
}
