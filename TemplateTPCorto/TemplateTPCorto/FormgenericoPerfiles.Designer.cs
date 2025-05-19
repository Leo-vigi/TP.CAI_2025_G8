namespace TemplateTPCorto
{
    partial class FormgenericoPerfiles
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
            this.lblPerfil = new System.Windows.Forms.Label();
            this.labelperfil = new System.Windows.Forms.Label();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.comboBoxAcciones = new System.Windows.Forms.ComboBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(29, 21);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(51, 20);
            this.lblPerfil.TabIndex = 0;
            this.lblPerfil.Text = "label1";
            // 
            // labelperfil
            // 
            this.labelperfil.AutoSize = true;
            this.labelperfil.Location = new System.Drawing.Point(144, 106);
            this.labelperfil.Name = "labelperfil";
            this.labelperfil.Size = new System.Drawing.Size(48, 20);
            this.labelperfil.TabIndex = 1;
            this.labelperfil.Text = "Perfil:";
            // 
            // txtPerfil
            // 
            this.txtPerfil.Location = new System.Drawing.Point(210, 100);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(165, 26);
            this.txtPerfil.TabIndex = 3;
            // 
            // comboBoxAcciones
            // 
            this.comboBoxAcciones.FormattingEnabled = true;
            this.comboBoxAcciones.Location = new System.Drawing.Point(210, 164);
            this.comboBoxAcciones.Name = "comboBoxAcciones";
            this.comboBoxAcciones.Size = new System.Drawing.Size(165, 28);
            this.comboBoxAcciones.TabIndex = 4;
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(209, 252);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(165, 30);
            this.btnAcceder.TabIndex = 5;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // FormgenericoPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.comboBoxAcciones);
            this.Controls.Add(this.txtPerfil);
            this.Controls.Add(this.labelperfil);
            this.Controls.Add(this.lblPerfil);
            this.Name = "FormgenericoPerfiles";
            this.Text = "FormgenericoPerfiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label labelperfil;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.ComboBox comboBoxAcciones;
        private System.Windows.Forms.Button btnAcceder;
    }
}