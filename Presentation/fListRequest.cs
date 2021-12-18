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
    public partial class fListRequest : Form
    {
        private int req;
        public void Cargar()
        {
            var login = Control.Acceso;
            cbxTipoRequerimiento.DataSource = login.cn.ListaTipoRequerimiento();
            cbxTipoRequerimiento.Select();
            cbxPrioridadRequerimiento.DataSource = login.cn.ListaPrioridadRequerimiento();
            req = -1;
        }
        public fListRequest()
        {
            InitializeComponent();
        }

        private void fListRequest_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = Control.Acceso;
            DialogResult consulta = MessageBox.Show($"¿Está seguro que desea marcar como 'RESUELTO' el requerimiento {req}?", $"Confimación de actualización de estado de entrada ID: {req}", MessageBoxButtons.YesNo);
            switch (consulta)
            {
                case DialogResult.Yes:
                    MessageBox.Show(login.cn.RequerimientoResuelto(req));
                    break;
                case DialogResult.No:
                    MessageBox.Show("No se ha realizado ningun cambio");
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var login = Control.Acceso;
            DialogResult consulta = MessageBox.Show($"¿Está seguro que desea ELIMINAR el requerimiento {req}?", $"Confimación de borrado de ID: {req}", MessageBoxButtons.YesNo);
            switch (consulta)
            {
                case DialogResult.Yes:
                    MessageBox.Show(login.cn.BorrarRequerimiento(req));
                    break;
                case DialogResult.No:
                    MessageBox.Show("No se ha realizado ningun cambio");
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var contenedor = Control.Contenedor;
            var registro = Control.Registro;
            contenedor.Width = 600;
            contenedor.Height = 350;
            registro.Cargar();
            registro.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var acceso = Control.Acceso;
            var contenedor = Control.Contenedor;
            contenedor.Width = 350;
            contenedor.Height = 210;
            acceso.Show();
            this.Hide();
        }

        private void dgvRequerimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            var login = Control.Acceso;
            string estado;
            string tipo = Convert.ToString(cbxTipoRequerimiento.SelectedItem);
            string prioridad = Convert.ToString(cbxPrioridadRequerimiento.SelectedItem);
            try
            {
                if (!chkPendientes.Checked && !chkResueltos.Checked)
                {
                    MessageBox.Show("Seleccione estado de Requerimiento");
                }
                else
                {
                    if (chkPendientes.Checked && !chkResueltos.Checked)
                    {
                        estado = "Pendiente";
                    }
                    else if (!chkPendientes.Checked && chkResueltos.Checked)
                    {
                        estado = "Resuelto";
                    }
                    else
                    {
                        estado = "%";
                    }
                    tabla = login.cn.ListarRequerimientos(tipo, prioridad, estado);
                    dgvRequerimientos.DataSource = tabla;
                    dgvRequerimientos.AutoResizeColumn(0);
                    dgvRequerimientos.AutoResizeColumn(1);
                    dgvRequerimientos.AutoResizeColumn(2);
                    dgvRequerimientos.Columns[3].Width = 190;
                    dgvRequerimientos.AutoResizeColumn(4);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema, cominíquese con el administrador del sistema\nError: {ex}");
            }
        }

        private void dgvRequerimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                req = Convert.ToInt32(dgvRequerimientos.Rows[e.RowIndex].Cells[0].Value);
                lblRSeleccion.Text = Convert.ToString(req);

            }
        }
    }
}
