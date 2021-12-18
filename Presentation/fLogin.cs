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
    public partial class fLogin : Form
    {
        public Negocio.Conciliador cn = new Negocio.Conciliador();
        public Negocio.DatosUsuario user = new Negocio.DatosUsuario();
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            tbUser.Select();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b' && !(Convert.ToString(e.KeyChar) == "."))
            {
                e.Handled = true;
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string u = Convert.ToString(tbUser.Text);
                string c = Convert.ToString(tbPassword.Text);
                if (!cn.VerificarUsuario(u))
                {
                    MessageBox.Show("Usuario no registrado");
                }
                else
                {
                    if (!cn.LoginUsuario(u, c))
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                    else
                    {
                        cn.IdentificarUsuario(u);
                        var contenedor = Control.Contenedor;
                        var registro = Control.Registro;
                        contenedor.Width = 600;
                        contenedor.Height = 350;
                        registro.Cargar();
                        registro.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha encontrado un problema, contacte al administrador del sistema\n\nError: " + ex.Message);
            }
            finally
            {
                tbUser.Text = "";
                tbPassword.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
