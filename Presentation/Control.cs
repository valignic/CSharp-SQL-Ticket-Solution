using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public static class Control
    {
        public static fContainerRequest Contenedor { get; set; }
        public static fLogin Acceso { get; set; }
        public static fRegRequest Registro { get; set; }
        public static fListRequest Lista { get; set; }

        public static void asignar()
        {
            Acceso.MdiParent = Contenedor;
            Registro.MdiParent = Contenedor;
            Lista.MdiParent = Contenedor;
            Acceso.Dock = System.Windows.Forms.DockStyle.Fill;
            Registro.Dock = System.Windows.Forms.DockStyle.Fill;
            Lista.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
