
namespace Presentation
{
    partial class fListRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnResuelto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.chkResueltos = new System.Windows.Forms.CheckBox();
            this.chkPendientes = new System.Windows.Forms.CheckBox();
            this.cbxPrioridadRequerimiento = new System.Windows.Forms.ComboBox();
            this.cbxTipoRequerimiento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvRequerimientos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRSeleccion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequerimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResuelto
            // 
            this.btnResuelto.Location = new System.Drawing.Point(12, 552);
            this.btnResuelto.Name = "btnResuelto";
            this.btnResuelto.Size = new System.Drawing.Size(210, 40);
            this.btnResuelto.TabIndex = 6;
            this.btnResuelto.Text = "Marcar como resuelto";
            this.btnResuelto.UseVisualStyleBackColor = true;
            this.btnResuelto.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Prioridad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(218, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lista de Requerimientos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btBuscar);
            this.panel1.Controls.Add(this.chkResueltos);
            this.panel1.Controls.Add(this.chkPendientes);
            this.panel1.Controls.Add(this.cbxPrioridadRequerimiento);
            this.panel1.Controls.Add(this.cbxTipoRequerimiento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 190);
            this.panel1.TabIndex = 14;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 13;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Estado:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(640, 139);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(169, 40);
            this.btBuscar.TabIndex = 4;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // chkResueltos
            // 
            this.chkResueltos.AutoSize = true;
            this.chkResueltos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkResueltos.Location = new System.Drawing.Point(373, 144);
            this.chkResueltos.Name = "chkResueltos";
            this.chkResueltos.Size = new System.Drawing.Size(104, 28);
            this.chkResueltos.TabIndex = 3;
            this.chkResueltos.Text = "Resueltos";
            this.chkResueltos.UseVisualStyleBackColor = true;
            // 
            // chkPendientes
            // 
            this.chkPendientes.AutoSize = true;
            this.chkPendientes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPendientes.Location = new System.Drawing.Point(243, 144);
            this.chkPendientes.Name = "chkPendientes";
            this.chkPendientes.Size = new System.Drawing.Size(113, 28);
            this.chkPendientes.TabIndex = 2;
            this.chkPendientes.Text = "Pendientes";
            this.chkPendientes.UseVisualStyleBackColor = true;
            this.chkPendientes.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbxPrioridadRequerimiento
            // 
            this.cbxPrioridadRequerimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrioridadRequerimiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPrioridadRequerimiento.FormattingEnabled = true;
            this.cbxPrioridadRequerimiento.Location = new System.Drawing.Point(243, 102);
            this.cbxPrioridadRequerimiento.Name = "cbxPrioridadRequerimiento";
            this.cbxPrioridadRequerimiento.Size = new System.Drawing.Size(566, 31);
            this.cbxPrioridadRequerimiento.TabIndex = 1;
            // 
            // cbxTipoRequerimiento
            // 
            this.cbxTipoRequerimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoRequerimiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoRequerimiento.FormattingEnabled = true;
            this.cbxTipoRequerimiento.Location = new System.Drawing.Point(243, 65);
            this.cbxTipoRequerimiento.Name = "cbxTipoRequerimiento";
            this.cbxTipoRequerimiento.Size = new System.Drawing.Size(566, 31);
            this.cbxTipoRequerimiento.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo de Requerimiento:";
            // 
            // dgvRequerimientos
            // 
            this.dgvRequerimientos.AllowUserToAddRows = false;
            this.dgvRequerimientos.AllowUserToDeleteRows = false;
            this.dgvRequerimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequerimientos.Location = new System.Drawing.Point(12, 208);
            this.dgvRequerimientos.Name = "dgvRequerimientos";
            this.dgvRequerimientos.ReadOnly = true;
            this.dgvRequerimientos.RowHeadersWidth = 51;
            this.dgvRequerimientos.RowTemplate.Height = 24;
            this.dgvRequerimientos.Size = new System.Drawing.Size(812, 314);
            this.dgvRequerimientos.TabIndex = 5;
            this.dgvRequerimientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequerimientos_CellClick);
            this.dgvRequerimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequerimientos_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(228, 552);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(210, 40);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(528, 552);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(296, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "Ir a Registrar Requerimientos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Requerimiento seleccionado (ID):";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblRSeleccion
            // 
            this.lblRSeleccion.AutoSize = true;
            this.lblRSeleccion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRSeleccion.ForeColor = System.Drawing.Color.Red;
            this.lblRSeleccion.Location = new System.Drawing.Point(283, 525);
            this.lblRSeleccion.Name = "lblRSeleccion";
            this.lblRSeleccion.Size = new System.Drawing.Size(0, 24);
            this.lblRSeleccion.TabIndex = 15;
            // 
            // fListRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 604);
            this.Controls.Add(this.lblRSeleccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvRequerimientos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnResuelto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fListRequest";
            this.Text = "fListRequest";
            this.Load += new System.EventHandler(this.fListRequest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequerimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResuelto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTipoRequerimiento;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.CheckBox chkResueltos;
        private System.Windows.Forms.CheckBox chkPendientes;
        private System.Windows.Forms.ComboBox cbxPrioridadRequerimiento;
        private System.Windows.Forms.DataGridView dgvRequerimientos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRSeleccion;
    }
}