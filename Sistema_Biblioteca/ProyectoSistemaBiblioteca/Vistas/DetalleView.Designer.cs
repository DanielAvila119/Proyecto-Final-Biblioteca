
namespace ProyectoSistemaBiblioteca.Vistas
{
    partial class DetalleView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_BuscarLibro = new System.Windows.Forms.Button();
            this.txt_NombreLibro = new System.Windows.Forms.TextBox();
            this.txt_IdLibro = new System.Windows.Forms.TextBox();
            this.txt_IdPrestamo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.btn_BuscarCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DevoluciondateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.PrestamodateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_Multa = new System.Windows.Forms.TextBox();
            this.txt_Cobro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Del Libro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_BuscarLibro);
            this.groupBox1.Controls.Add(this.txt_NombreLibro);
            this.groupBox1.Controls.Add(this.txt_IdLibro);
            this.groupBox1.Controls.Add(this.txt_IdPrestamo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(809, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prestamo";
            // 
            // btn_BuscarLibro
            // 
            this.btn_BuscarLibro.Location = new System.Drawing.Point(626, 22);
            this.btn_BuscarLibro.Name = "btn_BuscarLibro";
            this.btn_BuscarLibro.Size = new System.Drawing.Size(34, 30);
            this.btn_BuscarLibro.TabIndex = 6;
            this.btn_BuscarLibro.Text = "...";
            this.btn_BuscarLibro.UseVisualStyleBackColor = true;
            // 
            // txt_NombreLibro
            // 
            this.txt_NombreLibro.Location = new System.Drawing.Point(285, 72);
            this.txt_NombreLibro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreLibro.Name = "txt_NombreLibro";
            this.txt_NombreLibro.Size = new System.Drawing.Size(277, 22);
            this.txt_NombreLibro.TabIndex = 5;
            // 
            // txt_IdLibro
            // 
            this.txt_IdLibro.Location = new System.Drawing.Point(416, 26);
            this.txt_IdLibro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IdLibro.Name = "txt_IdLibro";
            this.txt_IdLibro.Size = new System.Drawing.Size(194, 22);
            this.txt_IdLibro.TabIndex = 4;
            // 
            // txt_IdPrestamo
            // 
            this.txt_IdPrestamo.Location = new System.Drawing.Point(117, 34);
            this.txt_IdPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IdPrestamo.Name = "txt_IdPrestamo";
            this.txt_IdPrestamo.Size = new System.Drawing.Size(91, 22);
            this.txt_IdPrestamo.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Nombre);
            this.groupBox2.Controls.Add(this.txt_ID);
            this.groupBox2.Controls.Add(this.btn_BuscarCliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 62);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(368, 22);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(194, 22);
            this.txt_Nombre.TabIndex = 9;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(117, 22);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(91, 22);
            this.txt_ID.TabIndex = 8;
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.Location = new System.Drawing.Point(225, 15);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.Size = new System.Drawing.Size(34, 30);
            this.btn_BuscarCliente.TabIndex = 7;
            this.btn_BuscarCliente.Text = "...";
            this.btn_BuscarCliente.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DevoluciondateTimePicker2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.PrestamodateTimePicker1);
            this.groupBox3.Controls.Add(this.txt_Multa);
            this.groupBox3.Controls.Add(this.txt_Cobro);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(13, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(810, 109);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cobro";
            // 
            // DevoluciondateTimePicker2
            // 
            this.DevoluciondateTimePicker2.Location = new System.Drawing.Point(519, 21);
            this.DevoluciondateTimePicker2.Name = "DevoluciondateTimePicker2";
            this.DevoluciondateTimePicker2.Size = new System.Drawing.Size(274, 22);
            this.DevoluciondateTimePicker2.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Devolucion";
            // 
            // PrestamodateTimePicker1
            // 
            this.PrestamodateTimePicker1.Location = new System.Drawing.Point(107, 21);
            this.PrestamodateTimePicker1.Name = "PrestamodateTimePicker1";
            this.PrestamodateTimePicker1.Size = new System.Drawing.Size(274, 22);
            this.PrestamodateTimePicker1.TabIndex = 7;
            // 
            // txt_Multa
            // 
            this.txt_Multa.Location = new System.Drawing.Point(107, 61);
            this.txt_Multa.Name = "txt_Multa";
            this.txt_Multa.Size = new System.Drawing.Size(109, 22);
            this.txt_Multa.TabIndex = 6;
            // 
            // txt_Cobro
            // 
            this.txt_Cobro.Location = new System.Drawing.Point(519, 64);
            this.txt_Cobro.Name = "txt_Cobro";
            this.txt_Cobro.Size = new System.Drawing.Size(100, 22);
            this.txt_Cobro.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Multa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cobro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Prestamo";
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(2, 361);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.Size = new System.Drawing.Size(833, 153);
            this.DetalledataGridView.TabIndex = 6;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(215, 312);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(98, 43);
            this.btn_Guardar.TabIndex = 7;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(381, 312);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(93, 43);
            this.btn_Cancelar.TabIndex = 8;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // DetalleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(836, 513);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DetalleView";
            this.Text = "Detalle De Prestamo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IdPrestamo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DevoluciondateTimePicker2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker PrestamodateTimePicker1;
        private System.Windows.Forms.TextBox txt_Multa;
        private System.Windows.Forms.TextBox txt_Cobro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView DetalledataGridView;
        public System.Windows.Forms.Button btn_Guardar;
        public System.Windows.Forms.Button btn_Cancelar;
        public System.Windows.Forms.Button btn_BuscarCliente;
        public System.Windows.Forms.TextBox txt_Nombre;
        public System.Windows.Forms.TextBox txt_ID;
        public System.Windows.Forms.Button btn_BuscarLibro;
        public System.Windows.Forms.TextBox txt_NombreLibro;
        public System.Windows.Forms.TextBox txt_IdLibro;
    }
}