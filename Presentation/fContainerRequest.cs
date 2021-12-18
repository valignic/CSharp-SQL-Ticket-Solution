using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class fContainerRequest : Form
    {
        public fContainerRequest()
        {
            InitializeComponent();
        }
        private void fContainerRequest_Load(object sender, EventArgs e)
        {
            var acceso = Control.Acceso;
            acceso.Show();
        }

        private void fContainerRequest_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void fContainerRequest_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void fContainerRequest_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
