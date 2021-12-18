
namespace Presentation
{
    partial class fRegRequest
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbDescripcionReq = new System.Windows.Forms.RichTextBox();
            this.cbxTipoRequerimiento = new System.Windows.Forms.ComboBox();
            this.cbxAsignado = new System.Windows.Forms.ComboBox();
            this.cbxPrioridad = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnListarReq = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.Location = new System.Drawing.Point(7, 333);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(230, 40);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(125, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registro de Requerimientos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo de Requerimiento:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Asignado a:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descripción del Requerimiento:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(3, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Prioridad:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // rtbDescripcionReq
            // 
            this.rtbDescripcionReq.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtbDescripcionReq.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescripcionReq.Location = new System.Drawing.Point(291, 177);
            this.rtbDescripcionReq.Name = "rtbDescripcionReq";
            this.rtbDescripcionReq.Size = new System.Drawing.Size(424, 96);
            this.rtbDescripcionReq.TabIndex = 2;
            this.rtbDescripcionReq.Text = "";
            this.rtbDescripcionReq.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // cbxTipoRequerimiento
            // 
            this.cbxTipoRequerimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxTipoRequerimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoRequerimiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoRequerimiento.FormattingEnabled = true;
            this.cbxTipoRequerimiento.Location = new System.Drawing.Point(291, 69);
            this.cbxTipoRequerimiento.Name = "cbxTipoRequerimiento";
            this.cbxTipoRequerimiento.Size = new System.Drawing.Size(424, 31);
            this.cbxTipoRequerimiento.TabIndex = 0;
            this.cbxTipoRequerimiento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbxAsignado
            // 
            this.cbxAsignado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxAsignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAsignado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAsignado.FormattingEnabled = true;
            this.cbxAsignado.Location = new System.Drawing.Point(291, 123);
            this.cbxAsignado.Name = "cbxAsignado";
            this.cbxAsignado.Size = new System.Drawing.Size(424, 31);
            this.cbxAsignado.TabIndex = 1;
            this.cbxAsignado.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbxPrioridad
            // 
            this.cbxPrioridad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrioridad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPrioridad.FormattingEnabled = true;
            this.cbxPrioridad.Location = new System.Drawing.Point(291, 279);
            this.cbxPrioridad.Name = "cbxPrioridad";
            this.cbxPrioridad.Size = new System.Drawing.Size(424, 31);
            this.cbxPrioridad.TabIndex = 3;
            this.cbxPrioridad.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnListarReq);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.cbxPrioridad);
            this.panel1.Controls.Add(this.cbxAsignado);
            this.panel1.Controls.Add(this.cbxTipoRequerimiento);
            this.panel1.Controls.Add(this.rtbDescripcionReq);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(10, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 381);
            this.panel1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(7, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 253);
            this.panel2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "(Alta, Media Baja)";
            // 
            // btnListarReq
            // 
            this.btnListarReq.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListarReq.Location = new System.Drawing.Point(479, 333);
            this.btnListarReq.Name = "btnListarReq";
            this.btnListarReq.Size = new System.Drawing.Size(236, 40);
            this.btnListarReq.TabIndex = 6;
            this.btnListarReq.Text = "Ir a Listar Requerimientos";
            this.btnListarReq.UseVisualStyleBackColor = true;
            this.btnListarReq.Click += new System.EventHandler(this.btnListarReq_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(392, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "(Este usuario será responsable de resolver el requerimiento)";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.Location = new System.Drawing.Point(243, 333);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(230, 40);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "(Bases de datos, Sistemas, Servidores)";
            // 
            // fRegRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(741, 396);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fRegRequest";
            this.Text = "fRegRequest";
            this.Load += new System.EventHandler(this.fRegRequest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbDescripcionReq;
        private System.Windows.Forms.ComboBox cbxTipoRequerimiento;
        private System.Windows.Forms.ComboBox cbxAsignado;
        private System.Windows.Forms.ComboBox cbxPrioridad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListarReq;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}