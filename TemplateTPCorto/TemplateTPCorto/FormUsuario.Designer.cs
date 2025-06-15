namespace TemplateTPCorto
{
    partial class FormUsuario
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
            this.buttonCambiarcontraenlogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Nocambiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCambiarcontraenlogin
            // 
            this.buttonCambiarcontraenlogin.BackColor = System.Drawing.Color.Navy;
            this.buttonCambiarcontraenlogin.FlatAppearance.BorderSize = 0;
            this.buttonCambiarcontraenlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonCambiarcontraenlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCambiarcontraenlogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCambiarcontraenlogin.ForeColor = System.Drawing.Color.White;
            this.buttonCambiarcontraenlogin.Location = new System.Drawing.Point(265, 169);
            this.buttonCambiarcontraenlogin.Name = "buttonCambiarcontraenlogin";
            this.buttonCambiarcontraenlogin.Size = new System.Drawing.Size(252, 26);
            this.buttonCambiarcontraenlogin.TabIndex = 0;
            this.buttonCambiarcontraenlogin.Text = "Cambiar Contraseña";
            this.buttonCambiarcontraenlogin.UseVisualStyleBackColor = false;
            this.buttonCambiarcontraenlogin.Click += new System.EventHandler(this.buttonCambiarcontraenlogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(571, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "¿Desea cambiar la contraseña?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Nocambiar
            // 
            this.Nocambiar.FlatAppearance.BorderSize = 0;
            this.Nocambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Nocambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nocambiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nocambiar.ForeColor = System.Drawing.Color.White;
            this.Nocambiar.Location = new System.Drawing.Point(237, 242);
            this.Nocambiar.Margin = new System.Windows.Forms.Padding(2);
            this.Nocambiar.Name = "Nocambiar";
            this.Nocambiar.Size = new System.Drawing.Size(318, 27);
            this.Nocambiar.TabIndex = 3;
            this.Nocambiar.Text = "No deseo cambiar la contraseña";
            this.Nocambiar.UseVisualStyleBackColor = true;
            this.Nocambiar.Click += new System.EventHandler(this.Nocambiar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(265, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 99);
            this.panel1.TabIndex = 5;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Nocambiar);
            this.Controls.Add(this.buttonCambiarcontraenlogin);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "FormUsuario";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormUsuario_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCambiarcontraenlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonModificarPersona;
        private System.Windows.Forms.Button buttonDesbloquearCredencial;
        private System.Windows.Forms.Button Nocambiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}