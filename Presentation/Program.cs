using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
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
            Control.Contenedor = new fContainerRequest();
            Control.Acceso = new fLogin();
            Control.Registro = new fRegRequest();
            Control.Lista = new fListRequest();
            var contenedor = Control.Contenedor;
            Control.asignar();
            Application.Run(contenedor);
        }
    }
}
