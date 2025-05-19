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
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(141, 119);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(143, 26);
            this.txtnombre.TabIndex = 14;
            // 
            // txtlegajo
            // 
            this.txtlegajo.Location = new System.Drawing.Point(141, 61);
            this.txtlegajo.Name = "txtlegajo";
            this.txtlegajo.Size = new System.Drawing.Size(143, 26);
            this.txtlegajo.TabIndex = 13;
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(44, 125);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(69, 20);
            this.labelnombre.TabIndex = 12;
            this.labelnombre.Text = "Nombre:";
            // 
            // labellegajo
            // 
            this.labellegajo.AutoSize = true;
            this.labellegajo.Location = new System.Drawing.Point(44, 58);
            this.labellegajo.Name = "labellegajo";
            this.labellegajo.Size = new System.Drawing.Size(61, 20);
            this.labellegajo.TabIndex = 11;
            this.labellegajo.Text = "Legajo:";
            // 
            // labelapellido
            // 
            this.labelapellido.AutoSize = true;
            this.labelapellido.Location = new System.Drawing.Point(44, 185);
            this.labelapellido.Name = "labelapellido";
            this.labelapellido.Size = new System.Drawing.Size(69, 20);
            this.labelapellido.TabIndex = 15;
            this.labelapellido.Text = "Apellido:";
            // 
            // labeldni
            // 
            this.labeldni.AutoSize = true;
            this.labeldni.Location = new System.Drawing.Point(44, 235);
            this.labeldni.Name = "labeldni";
            this.labeldni.Size = new System.Drawing.Size(41, 20);
            this.labeldni.TabIndex = 16;
            this.labeldni.Text = "DNI:";
            // 
            // labelfechaingreso
            // 
            this.labelfechaingreso.AutoSize = true;
            this.labelfechaingreso.Location = new System.Drawing.Point(44, 280);
            this.labelfechaingreso.Name = "labelfechaingreso";
            this.labelfechaingreso.Size = new System.Drawing.Size(114, 20);
            this.labelfechaingreso.TabIndex = 17;
            this.labelfechaingreso.Text = "Fecha ingreso:";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(141, 179);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(143, 26);
            this.txtapellido.TabIndex = 18;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(141, 232);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(143, 26);
            this.txtdni.TabIndex = 19;
            // 
            // txtfechaing
            // 
            this.txtfechaing.Location = new System.Drawing.Point(200, 274);
            this.txtfechaing.Name = "txtfechaing";
            this.txtfechaing.Size = new System.Drawing.Size(143, 26);
            this.txtfechaing.TabIndex = 20;
            // 
            // btncambiar
            // 
            this.btncambiar.Location = new System.Drawing.Point(320, 374);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(141, 39);
            this.btncambiar.TabIndex = 21;
            this.btncambiar.Text = "Cambiar";
            this.btncambiar.UseVisualStyleBackColor = true;
            // 
            // FormModificarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 501);
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
            this.Name = "FormModificarPersona";
            this.Text = "FormModificarPersona";
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
    }
}