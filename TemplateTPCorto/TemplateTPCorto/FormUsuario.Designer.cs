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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCambiarcontraenlogin
            // 
            this.buttonCambiarcontraenlogin.Location = new System.Drawing.Point(386, 107);
            this.buttonCambiarcontraenlogin.Name = "buttonCambiarcontraenlogin";
            this.buttonCambiarcontraenlogin.Size = new System.Drawing.Size(142, 23);
            this.buttonCambiarcontraenlogin.TabIndex = 0;
            this.buttonCambiarcontraenlogin.Text = "Cambiar Contraseña";
            this.buttonCambiarcontraenlogin.UseVisualStyleBackColor = true;
            this.buttonCambiarcontraenlogin.Click += new System.EventHandler(this.buttonCambiarcontraenlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario autenticado exitosamente y con login de menos de 30 dias";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "¿Desea cambiar la contraseña?";
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCambiarcontraenlogin);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCambiarcontraenlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonModificarPersona;
        private System.Windows.Forms.Button buttonDesbloquearCredencial;

        
    }
}