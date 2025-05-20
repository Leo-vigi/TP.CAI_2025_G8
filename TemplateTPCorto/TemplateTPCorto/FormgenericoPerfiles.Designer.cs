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
            this.lblPerfil.Location = new System.Drawing.Point(19, 14);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(35, 13);
            this.lblPerfil.TabIndex = 0;
            this.lblPerfil.Text = "label1";
            // 
            // labelperfil
            // 
            this.labelperfil.AutoSize = true;
            this.labelperfil.Location = new System.Drawing.Point(96, 69);
            this.labelperfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelperfil.Name = "labelperfil";
            this.labelperfil.Size = new System.Drawing.Size(33, 13);
            this.labelperfil.TabIndex = 1;
            this.labelperfil.Text = "Perfil:";
            // 
            // txtPerfil
            // 
            this.txtPerfil.Location = new System.Drawing.Point(140, 65);
            this.txtPerfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(111, 20);
            this.txtPerfil.TabIndex = 3;
            // 
            // comboBoxAcciones
            // 
            this.comboBoxAcciones.FormattingEnabled = true;
            this.comboBoxAcciones.Location = new System.Drawing.Point(140, 107);
            this.comboBoxAcciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAcciones.Name = "comboBoxAcciones";
            this.comboBoxAcciones.Size = new System.Drawing.Size(111, 21);
            this.comboBoxAcciones.TabIndex = 4;
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(139, 164);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(110, 20);
            this.btnAcceder.TabIndex = 5;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // FormgenericoPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.comboBoxAcciones);
            this.Controls.Add(this.txtPerfil);
            this.Controls.Add(this.labelperfil);
            this.Controls.Add(this.lblPerfil);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormgenericoPerfiles";
            this.Text = "FormgenericoPerfiles";
            this.Load += new System.EventHandler(this.FormgenericoPerfiles_Load);
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