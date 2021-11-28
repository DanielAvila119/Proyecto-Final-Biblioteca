
namespace ProyectoSistemaBiblioteca.Vistas
{
    partial class LibroView
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
            this.LibrosDataGridView = new System.Windows.Forms.DataGridView();
            this.txt_NumEjemplares = new System.Windows.Forms.TextBox();
            this.txt_NumEdicion = new System.Windows.Forms.TextBox();
            this.txt_Editor = new System.Windows.Forms.TextBox();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LibrosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LibrosDataGridView
            // 
            this.LibrosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LibrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibrosDataGridView.Location = new System.Drawing.Point(0, 274);
            this.LibrosDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LibrosDataGridView.Name = "LibrosDataGridView";
            this.LibrosDataGridView.Size = new System.Drawing.Size(591, 154);
            this.LibrosDataGridView.TabIndex = 65;
            // 
            // txt_NumEjemplares
            // 
            this.txt_NumEjemplares.Location = new System.Drawing.Point(172, 194);
            this.txt_NumEjemplares.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NumEjemplares.Name = "txt_NumEjemplares";
            this.txt_NumEjemplares.Size = new System.Drawing.Size(260, 22);
            this.txt_NumEjemplares.TabIndex = 59;
            // 
            // txt_NumEdicion
            // 
            this.txt_NumEdicion.Location = new System.Drawing.Point(173, 164);
            this.txt_NumEdicion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NumEdicion.Name = "txt_NumEdicion";
            this.txt_NumEdicion.Size = new System.Drawing.Size(259, 22);
            this.txt_NumEdicion.TabIndex = 58;
            // 
            // txt_Editor
            // 
            this.txt_Editor.Location = new System.Drawing.Point(173, 134);
            this.txt_Editor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Editor.Name = "txt_Editor";
            this.txt_Editor.Size = new System.Drawing.Size(260, 22);
            this.txt_Editor.TabIndex = 57;
            // 
            // txt_Autor
            // 
            this.txt_Autor.Location = new System.Drawing.Point(173, 104);
            this.txt_Autor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.Size = new System.Drawing.Size(259, 22);
            this.txt_Autor.TabIndex = 56;
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.Location = new System.Drawing.Point(173, 74);
            this.txt_Titulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(259, 22);
            this.txt_Titulo.TabIndex = 55;
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(174, 44);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(110, 22);
            this.txt_ID.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 53;
            this.label7.Text = "Datos del Libro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "No. de Ejemplares:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "No. de Edición:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Editor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Título:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(448, 235);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 32);
            this.btn_Cancelar.TabIndex = 71;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(348, 235);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(94, 32);
            this.btn_Eliminar.TabIndex = 70;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.Location = new System.Drawing.Point(248, 235);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(94, 32);
            this.btn_Guardar.TabIndex = 69;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(148, 235);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(94, 32);
            this.btn_Modificar.TabIndex = 68;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(48, 235);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(94, 32);
            this.btn_Nuevo.TabIndex = 67;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.Location = new System.Drawing.Point(455, 32);
            this.ImagenPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(123, 154);
            this.ImagenPictureBox.TabIndex = 66;
            this.ImagenPictureBox.TabStop = false;
            // 
            // LibroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(591, 428);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.ImagenPictureBox);
            this.Controls.Add(this.LibrosDataGridView);
            this.Controls.Add(this.txt_NumEjemplares);
            this.Controls.Add(this.txt_NumEdicion);
            this.Controls.Add(this.txt_Editor);
            this.Controls.Add(this.txt_Autor);
            this.Controls.Add(this.txt_Titulo);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LibroView";
            this.Text = "Libro";
            ((System.ComponentModel.ISupportInitialize)(this.LibrosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox ImagenPictureBox;
        public System.Windows.Forms.DataGridView LibrosDataGridView;
        public System.Windows.Forms.TextBox txt_NumEjemplares;
        public System.Windows.Forms.TextBox txt_NumEdicion;
        public System.Windows.Forms.TextBox txt_Editor;
        public System.Windows.Forms.TextBox txt_Autor;
        public System.Windows.Forms.TextBox txt_Titulo;
        public System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_Cancelar;
        public System.Windows.Forms.Button btn_Eliminar;
        public System.Windows.Forms.Button btn_Guardar;
        public System.Windows.Forms.Button btn_Modificar;
        public System.Windows.Forms.Button btn_Nuevo;
    }
}