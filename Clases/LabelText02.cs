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
    public partial class LabelText02 : UserControl
    {
        public enum TipoDato { texto, numero, fecha }

        public string PpEtiqueta
        {
            get { return lblEtiqueta.Text; }
            set { lblEtiqueta.Text = value; }
        }

        public bool PpValidable { get; set; }
        public string PpNombreCampo { get; set; }
        public string PpNombreTabla { get; set; }
        public string PpMensajeError { get; set; }
        public int PpAncho { get; set; } = 10;
        public int PpDecimales { get; set; } = 2;


        public bool PpMaskFull => TxtDato.MaskFull;
        private TipoDato TipoD = TipoDato.texto;

        public TipoDato PpTipoDato
        {
            get { return TipoD; }
            set
            {
                TipoD = value;
                string mascara = "";
                switch (TipoD)
                {
                    case TipoDato.texto:
                        TxtDato.Mask = mascara.PadLeft(PpAncho, ' ');
                        break;
                    case TipoDato.numero:
                        mascara = mascara.PadLeft(PpAncho - PpDecimales - 1, '9') + ".";
                        if (PpDecimales >= 1)
                        {
                            mascara = mascara.PadRight(PpAncho, '9');
                        }

                        TxtDato.Mask = mascara;
                        break;
                    case TipoDato.fecha:
                        TxtDato.Mask = "00/00/0000";
                        break;
                    default:
                        break;
                }
            }
        }

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

        public LabelText02()
        {
            InitializeComponent();
        }

        private void TxtDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(".") || e.KeyChar == Convert.ToChar(","))
            {
                if (this.PpTipoDato == TipoDato.numero)
                {
                    int blanco = TxtDato.Text.IndexOf(' ');
                    int entero = PpAncho - PpDecimales - 1;
                    if (blanco < -blanco && blanco != -1)
                    {
                        for (int i = 0; i < entero - blanco; i++)
                        {
                            TxtDato.Text = " " + TxtDato.Text;
                        }
                    }

                    TxtDato.SelectionStart = TxtDato.Text.Length;
                }
            }
        }
    }
}
