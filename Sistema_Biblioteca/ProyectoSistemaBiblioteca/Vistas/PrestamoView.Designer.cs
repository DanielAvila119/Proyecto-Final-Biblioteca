
namespace ProyectoSistemaBiblioteca.Vistas
{
    partial class PrestamoView
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
            this.components = new System.ComponentModel.Container();
            this.PrestamoDataGridView = new System.Windows.Forms.DataGridView();
            this.DevolucionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EntregaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PrestamoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.TxtIdEjemplar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PrestamoDataGridView
            // 
            this.PrestamoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrestamoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrestamoDataGridView.Location = new System.Drawing.Point(-1, 336);
            this.PrestamoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.PrestamoDataGridView.Name = "PrestamoDataGridView";
            this.PrestamoDataGridView.Size = new System.Drawing.Size(536, 128);
            this.PrestamoDataGridView.TabIndex = 80;
            // 
            // DevolucionDateTimePicker
            // 
            this.DevolucionDateTimePicker.Enabled = false;
            this.DevolucionDateTimePicker.Location = new System.Drawing.Point(182, 133);
            this.DevolucionDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DevolucionDateTimePicker.Name = "DevolucionDateTimePicker";
            this.DevolucionDateTimePicker.Size = new System.Drawing.Size(281, 22);
            this.DevolucionDateTimePicker.TabIndex = 74;
            // 
            // EntregaDateTimePicker
            // 
            this.EntregaDateTimePicker.Enabled = false;
            this.EntregaDateTimePicker.Location = new System.Drawing.Point(182, 103);
            this.EntregaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.EntregaDateTimePicker.Name = "EntregaDateTimePicker";
            this.EntregaDateTimePicker.Size = new System.Drawing.Size(281, 22);
            this.EntregaDateTimePicker.TabIndex = 73;
            // 
            // PrestamoDateTimePicker
            // 
            this.PrestamoDateTimePicker.Enabled = false;
            this.PrestamoDateTimePicker.Location = new System.Drawing.Point(182, 73);
            this.PrestamoDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.PrestamoDateTimePicker.Name = "PrestamoDateTimePicker";
            this.PrestamoDateTimePicker.Size = new System.Drawing.Size(281, 22);
            this.PrestamoDateTimePicker.TabIndex = 72;
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(182, 43);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(61, 22);
            this.txt_ID.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(178, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 20);
            this.label8.TabIndex = 69;
            this.label8.Text = "Préstamo de Libros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 67;
            this.label4.Text = "Fecha Devolución:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Fecha Entrega:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Fecha Préstamo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "ID:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(419, 281);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 32);
            this.btn_Cancelar.TabIndex = 85;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(319, 281);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(94, 32);
            this.btn_Eliminar.TabIndex = 84;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.Location = new System.Drawing.Point(219, 281);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(94, 32);
            this.btn_Guardar.TabIndex = 83;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(119, 281);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(94, 32);
            this.btn_Modificar.TabIndex = 82;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(19, 281);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(94, 32);
            this.btn_Nuevo.TabIndex = 81;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // TxtIdEjemplar
            // 
            this.TxtIdEjemplar.Location = new System.Drawing.Point(182, 163);
            this.TxtIdEjemplar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdEjemplar.Name = "TxtIdEjemplar";
            this.TxtIdEjemplar.Size = new System.Drawing.Size(114, 22);
            this.TxtIdEjemplar.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 86;
            this.label6.Text = "Id Ejemplar:";
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(182, 193);
            this.TxtIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(114, 22);
            this.TxtIdCliente.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 88;
            this.label7.Text = "Id Cliente:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PrestamoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(534, 463);
            this.Controls.Add(this.TxtIdCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtIdEjemplar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.PrestamoDataGridView);
            this.Controls.Add(this.DevolucionDateTimePicker);
            this.Controls.Add(this.EntregaDateTimePicker);
            this.Controls.Add(this.PrestamoDateTimePicker);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrestamoView";
            this.Text = "Prestamo de Libros";
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView PrestamoDataGridView;
        public System.Windows.Forms.DateTimePicker DevolucionDateTimePicker;
        public System.Windows.Forms.DateTimePicker EntregaDateTimePicker;
        public System.Windows.Forms.DateTimePicker PrestamoDateTimePicker;
        public System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_Cancelar;
        public System.Windows.Forms.Button btn_Eliminar;
        public System.Windows.Forms.Button btn_Guardar;
        public System.Windows.Forms.Button btn_Modificar;
        public System.Windows.Forms.Button btn_Nuevo;
        public System.Windows.Forms.TextBox TxtIdEjemplar;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}