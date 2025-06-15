namespace TemplateTPCorto
{
    partial class FormModificarPersona
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtlegajo = new System.Windows.Forms.TextBox();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labellegajo = new System.Windows.Forms.Label();
            this.labelapellido = new System.Windows.Forms.Label();
            this.labeldni = new System.Windows.Forms.Label();
            this.labelfechaingreso = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtfechaing = new System.Windows.Forms.TextBox();
            this.btncambiar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(345, 129);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(119, 20);
            this.txtnombre.TabIndex = 14;
            // 
            // txtlegajo
            // 
            this.txtlegajo.Location = new System.Drawing.Point(367, 33);
            this.txtlegajo.Margin = new System.Windows.Forms.Padding(2);
            this.txtlegajo.Name = "txtlegajo";
            this.txtlegajo.Size = new System.Drawing.Size(97, 20);
            this.txtlegajo.TabIndex = 13;
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.ForeColor = System.Drawing.Color.White;
            this.labelnombre.Location = new System.Drawing.Point(225, 132);
            this.labelnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(68, 20);
            this.labelnombre.TabIndex = 12;
            this.labelnombre.Text = "Nombre";
            // 
            // labellegajo
            // 
            this.labellegajo.AutoSize = true;
            this.labellegajo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellegajo.ForeColor = System.Drawing.Color.White;
            this.labellegajo.Location = new System.Drawing.Point(186, 33);
            this.labellegajo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labellegajo.Name = "labellegajo";
            this.labellegajo.Size = new System.Drawing.Size(160, 20);
            this.labellegajo.TabIndex = 11;
            this.labellegajo.Text = "Introduzca un legajo";
            // 
            // labelapellido
            // 
            this.labelapellido.AutoSize = true;
            this.labelapellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelapellido.ForeColor = System.Drawing.Color.White;
            this.labelapellido.Location = new System.Drawing.Point(225, 171);
            this.labelapellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelapellido.Name = "labelapellido";
            this.labelapellido.Size = new System.Drawing.Size(69, 20);
            this.labelapellido.TabIndex = 15;
            this.labelapellido.Text = "Apellido";
            // 
            // labeldni
            // 
            this.labeldni.AutoSize = true;
            this.labeldni.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldni.ForeColor = System.Drawing.Color.White;
            this.labeldni.Location = new System.Drawing.Point(225, 204);
            this.labeldni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeldni.Name = "labeldni";
            this.labeldni.Size = new System.Drawing.Size(36, 20);
            this.labeldni.TabIndex = 16;
            this.labeldni.Text = "DNI";
            // 
            // labelfechaingreso
            // 
            this.labelfechaingreso.AutoSize = true;
            this.labelfechaingreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfechaingreso.ForeColor = System.Drawing.Color.White;
            this.labelfechaingreso.Location = new System.Drawing.Point(224, 243);
            this.labelfechaingreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfechaingreso.Name = "labelfechaingreso";
            this.labelfechaingreso.Size = new System.Drawing.Size(112, 20);
            this.labelfechaingreso.TabIndex = 17;
            this.labelfechaingreso.Text = "Fecha ingreso";
            this.labelfechaingreso.Click += new System.EventHandler(this.labelfechaingreso_Click);
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(345, 168);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(119, 20);
            this.txtapellido.TabIndex = 18;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(345, 204);
            this.txtdni.Margin = new System.Windows.Forms.Padding(2);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(119, 20);
            this.txtdni.TabIndex = 19;
            // 
            // txtfechaing
            // 
            this.txtfechaing.Location = new System.Drawing.Point(345, 243);
            this.txtfechaing.Margin = new System.Windows.Forms.Padding(2);
            this.txtfechaing.Name = "txtfechaing";
            this.txtfechaing.Size = new System.Drawing.Size(119, 20);
            this.txtfechaing.TabIndex = 20;
            // 
            // btncambiar
            // 
            this.btncambiar.FlatAppearance.BorderSize = 0;
            this.btncambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btncambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncambiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncambiar.ForeColor = System.Drawing.Color.White;
            this.btncambiar.Location = new System.Drawing.Point(203, 289);
            this.btncambiar.Margin = new System.Windows.Forms.Padding(2);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(133, 26);
            this.btncambiar.TabIndex = 21;
            this.btncambiar.Text = "Cambiar";
            this.btncambiar.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(190, 77);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(274, 29);
            this.btnCargar.TabIndex = 22;
            this.btnCargar.Text = "Cargar datos";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(345, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 25);
            this.button1.TabIndex = 23;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormModificarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(637, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btncambiar);
            this.Controls.Add(this.txtfechaing);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.labelfechaingreso);
            this.Controls.Add(this.labeldni);
            this.Controls.Add(this.labelapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtlegajo);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.labellegajo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormModificarPersona";
            this.Text = "Modificar Persona";
            this.Load += new System.EventHandler(this.FormModificarPersona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtlegajo;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labellegajo;
        private System.Windows.Forms.Label labelapellido;
        private System.Windows.Forms.Label labeldni;
        private System.Windows.Forms.Label labelfechaingreso;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtfechaing;
        private System.Windows.Forms.Button btncambiar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button button1;
    }
}