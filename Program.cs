using Practico.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Formularios.Abm;
using Practico.Formularios.Abm.Empleados;
using Practico.Formularios.Abm.Helados;
using Practico.Formularios.Abm.Frutas;
using Practico.Formularios.Abm.HeladosHeladosEspeciales;
using Practico.Formularios.Procesos;

namespace Practico
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmEscritorio());
            //Application.Run(new FrmAltaVenta());
        }
    }
}
