using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Practico.Clases;

namespace Practico.Clases
{
    [System.ComponentModel.DesignerCategory("")]
    class ComboBox01 : ComboBox
    {
        public string PpTabla { get; set; }
        public string PpDisplay { get; set; }
        public string PpValue { get; set; }

        public bool PpValidable { get; set; }
        public string PpNombreCampo { get; set; }
        public string PpNombreTabla { get; set; }
        public string PpMensajeError { get; set; }


        public void Cargar()  //cargar con consulta SELECT *
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT * FROM " + PpTabla;
            this.DisplayMember = PpDisplay;
            this.ValueMember = PpValue;
            this.DataSource = baseDatos.Consulta(sql);
        }

        public void Cargar(string tabla, string display, string value)
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT * FROM " + tabla;
            this.DisplayMember = display;
            this.ValueMember = value;
            this.DataSource = baseDatos.Consulta(sql);
        }

        public void Cargar(DataTable tabla, string display, string value)
        {
            this.DisplayMember = display;
            this.ValueMember = value;
            this.DataSource = tabla;

        }
        public void cargar(EstructuraComboBox ec)
        {
            this.DisplayMember = ec.Display;
            this.ValueMember = ec.Value;
            this.DataSource = ec.Tabla;
        }

    }
}
