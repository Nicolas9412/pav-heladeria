using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico.Clases
{
    [System.ComponentModel.DesignerCategory("")]
    class TextBox02 : MaskedTextBox
    {
        public bool PpValidable { get; set; }
        public string PpNombreCampo { get; set; }
        public string PpNombreTabla { get; set; }
        public string PpMensajeError { get; set; }
    }
}
