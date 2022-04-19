using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico.Clases
{
    [System.ComponentModel.DesignerCategory("")]
    class Grid01 : DataGridView
    {
        public DataTable tabla { get; set; }

        /// <summary>
        /// Método para formatear la grilla que responde al formato "tituloColumna1, anchoColumna1; ..."
        /// </summary>
        /// <param name="formato"></param string>
        public void Formatear(string formato)
        {
            string[] columnas;
            columnas = formato.Split(';');
            this.ColumnCount = columnas.Length;
            for (int i = 0; i < this.ColumnCount; i++)
            {
                string[] valores = columnas[i].Split(',');
                this.Columns[i].HeaderText = valores[0].ToString();
                this.Columns[i].Width = int.Parse(valores[1].ToString());
            }
        }
    }
}
