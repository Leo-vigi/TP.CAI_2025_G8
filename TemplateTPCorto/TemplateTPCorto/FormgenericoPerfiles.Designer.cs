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
            this.labelperfil = new System.Windows.Forms.Label();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.comboBoxAcciones = new System.Windows.Forms.ComboBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelperfil
            // 
            this.labelperfil.AutoSize = true;
            this.labelperfil.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelperfil.ForeColor = System.Drawing.Color.White;
            this.labelperfil.Location = new System.Drawing.Point(241, 9);
            this.labelperfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelperfil.Name = "labelperfil";
            this.labelperfil.Size = new System.Drawing.Size(77, 33);
            this.labelperfil.TabIndex = 1;
            this.labelperfil.Text = "Perfil";
            // 
            // txtPerfil
            // 
            this.txtPerfil.BackColor = System.Drawing.Color.Navy;
            this.txtPerfil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPerfil.Location = new System.Drawing.Point(180, 84);
            this.txtPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(224, 13);
            this.txtPerfil.TabIndex = 3;
            this.txtPerfil.TextChanged += new System.EventHandler(this.txtPerfil_TextChanged);
            // 
            // comboBoxAcciones
            // 
            this.comboBoxAcciones.FormattingEnabled = true;
            this.comboBoxAcciones.Location = new System.Drawing.Point(180, 135);
            this.comboBoxAcciones.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAcciones.Name = "comboBoxAcciones";
            this.comboBoxAcciones.Size = new System.Drawing.Size(224, 21);
            this.comboBoxAcciones.TabIndex = 4;
            // 
            // btnAcceder
            // 
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.Location = new System.Drawing.Point(180, 179);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(224, 25);
            this.btnAcceder.TabIndex = 5;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(180, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.labelperfil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 56);
            this.panel1.TabIndex = 7;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.White;
            this.lblPerfil.Location = new System.Drawing.Point(12, 84);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(60, 20);
            this.lblPerfil.TabIndex = 8;
            this.lblPerfil.Text = "lblPerfil";
            this.lblPerfil.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormgenericoPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.comboBoxAcciones);
            this.Controls.Add(this.txtPerfil);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormgenericoPerfiles";
            this.Text = "Perfil Usuario";
            this.Load += new System.EventHandler(this.FormgenericoPerfiles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelperfil;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.ComboBox comboBoxAcciones;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPerfil;
    }
}