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
    public partial class fRegRequest : Form
    {
        public void Cargar()
        {
            var login = Control.Acceso;
            cbxTipoRequerimiento.Items.Clear();
            cbxTipoRequerimiento.Items.Add("Seleccionar");
            cbxTipoRequerimiento.Items.Add("Base de Datos");
            cbxTipoRequerimiento.Items.Add("Sistemas");
            cbxTipoRequerimiento.Items.Add("Servidores");
            cbxTipoRequerimiento.SelectedIndex = 0;
            cbxAsignado.DataSource = login.cn.ListaEncargados();
            cbxAsignado.ValueMember = "id";
            cbxAsignado.DisplayMember = "nombre";
            cbxAsignado.SelectedIndex = 0;
            cbxPrioridad.Items.Clear();
            cbxPrioridad.Items.Add("Seleccionar");
            cbxPrioridad.Items.Add("Alta");
            cbxPrioridad.Items.Add("Media");
            cbxPrioridad.Items.Add("Baja");
            cbxPrioridad.SelectedIndex = 0;
        }
        public fRegRequest()
        {
            InitializeComponent();
        }

        private void fRegRequest_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var login = Control.Acceso;
                if (cbxTipoRequerimiento.Text == "Seleccionar")
                {
                    MessageBox.Show("Seleccione el tipo de requerimiento");
                }
                else if (Convert.ToInt32(cbxAsignado.SelectedValue) == 0)
                {
                    MessageBox.Show("Asigne al encargado del requerimiento");
                }
                else if (rtbDescripcionReq.Text == "")
                {
                    MessageBox.Show("Añada una descripción para el requerimiento");
                }
                else if (cbxPrioridad.Text == "Seleccionar")
                {
                    MessageBox.Show("Ingrese la prioridad del requerimiento");
                }
                else
                {
                    MessageBox.Show(login.cn.GuardarRequerimiento(Convert.ToInt32(cbxAsignado.SelectedValue), cbxTipoRequerimiento.Text, cbxPrioridad.Text, rtbDescripcionReq.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema, cominíquese con el administrador del sistema\nError: {ex}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnListarReq_Click(object sender, EventArgs e)
        {
            var lista = Control.Lista;
            var contenedor = Control.Contenedor;
            contenedor.Width = 645;
            contenedor.Height = 530;
            lista.Cargar();
            lista.Show();
            this.Hide();
            cbxTipoRequerimiento.SelectedIndex = 0;
            cbxAsignado.SelectedIndex = 0;
            rtbDescripcionReq.Text = "";
            cbxPrioridad.SelectedIndex = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var acceso = Control.Acceso;
            var contenedor = Control.Contenedor;
            contenedor.Width = 350;
            contenedor.Height = 220;
            acceso.Show();
            this.Hide();
            cbxTipoRequerimiento.SelectedIndex = 0;
            cbxAsignado.SelectedIndex = 0;
            rtbDescripcionReq.Text = "";
            cbxPrioridad.SelectedIndex = 0;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbxTipoRequerimiento.SelectedIndex = 0;
            cbxAsignado.SelectedIndex = 0;
            rtbDescripcionReq.Text = "";
            cbxPrioridad.SelectedIndex = 0;
        }
    }
}
