﻿namespace TemplateTPCorto
{
    partial class FormVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            this.btnListarProductos = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lablSubTotal = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lstProducto = new System.Windows.Forms.ListBox();
            this.cboCategoriaProductos = new System.Windows.Forms.ComboBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.BackColor = System.Drawing.Color.SlateGray;
            this.btnListarProductos.FlatAppearance.BorderSize = 0;
            this.btnListarProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnListarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarProductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarProductos.ForeColor = System.Drawing.Color.White;
            this.btnListarProductos.Location = new System.Drawing.Point(406, 165);
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Size = new System.Drawing.Size(128, 46);
            this.btnListarProductos.TabIndex = 34;
            this.btnListarProductos.Text = "Listar productos";
            this.btnListarProductos.UseVisualStyleBackColor = false;
            this.btnListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click_1);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.Red;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.Location = new System.Drawing.Point(26, 208);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(104, 80);
            this.btnQuitar.TabIndex = 32;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lablSubTotal
            // 
            this.lablSubTotal.AutoSize = true;
            this.lablSubTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablSubTotal.ForeColor = System.Drawing.Color.White;
            this.lablSubTotal.Location = new System.Drawing.Point(780, 495);
            this.lablSubTotal.Name = "lablSubTotal";
            this.lablSubTotal.Size = new System.Drawing.Size(25, 27);
            this.lablSubTotal.TabIndex = 30;
            this.lablSubTotal.Text = "0";
            this.lablSubTotal.Click += new System.EventHandler(this.lablSubTotal_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(369, 551);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(163, 26);
            this.txtCantidad.TabIndex = 28;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 27);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ingrese cantidad deseada";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(780, 540);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(25, 27);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "0";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Location = new System.Drawing.Point(14, 31);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(112, 29);
            this.lblSubTotal.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(638, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 27);
            this.label4.TabIndex = 25;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(638, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 27);
            this.label3.TabIndex = 24;
            this.label3.Text = "SubTotal";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(644, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(414, 384);
            this.listBox1.TabIndex = 23;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstProducto
            // 
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.ItemHeight = 20;
            this.lstProducto.Location = new System.Drawing.Point(57, 232);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(475, 264);
            this.lstProducto.TabIndex = 22;
            this.lstProducto.SelectedIndexChanged += new System.EventHandler(this.lstProducto_SelectedIndexChanged);
            // 
            // cboCategoriaProductos
            // 
            this.cboCategoriaProductos.FormattingEnabled = true;
            this.cboCategoriaProductos.Location = new System.Drawing.Point(225, 175);
            this.cboCategoriaProductos.Name = "cboCategoriaProductos";
            this.cboCategoriaProductos.Size = new System.Drawing.Size(136, 28);
            this.cboCategoriaProductos.TabIndex = 21;
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(225, 52);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(307, 28);
            this.cmbClientes.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(26, 631);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 35;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 148);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnQuitar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1066, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 692);
            this.panel1.TabIndex = 39;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.SlateGray;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(624, 631);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(435, 42);
            this.btnCargar.TabIndex = 33;
            this.btnCargar.Text = "Cargar Venta";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SlateGray;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(198, 631);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(250, 43);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar a carrito";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(40, 608);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnListarProductos);
            this.Controls.Add(this.lablSubTotal);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lstProducto);
            this.Controls.Add(this.cboCategoriaProductos);
            this.Controls.Add(this.cmbClientes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVentas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarProductos;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lablSubTotal;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lstProducto;
        private System.Windows.Forms.ComboBox cboCategoriaProductos;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}