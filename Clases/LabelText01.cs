using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico.Clases
{
    public partial class LabelText01 : UserControl
    {

        public string PpEtiqueta
        {
            get { return lblEtiqueta.Text; }
            set { lblEtiqueta.Text = value; }
        }
        public bool PpValidable { get; set; }
        public string PpNombreCampo { get; set; }
        public string PpNombreTabla { get; set; }
        public string PpMensajeError { get; set; }
        public string PpMask
       {
            get { return TxtDato.Mask; }
            set
            {
                TxtDato.Mask = value;
            }
        }
        public string PpText
        {
            get { return TxtDato.Text; }
            set { TxtDato.Text = value; }
        }

        public LabelText01()
        {
            InitializeComponent();
        }
    }
}
