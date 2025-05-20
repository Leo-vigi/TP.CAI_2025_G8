namespace TemplateTPCorto
{
    partial class FormDesbloquearcredencial
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
            this.btncambiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlegajo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnueva = new System.Windows.Forms.TextBox();
            this.txtvieja = new System.Windows.Forms.TextBox();
            this.btncargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncambiar
            // 
            this.btncambiar.Location = new System.Drawing.Point(192, 221);
            this.btncambiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(91, 22);
            this.btncambiar.TabIndex = 0;
            this.btncambiar.Text = "Cambiar";
            this.btncambiar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Legajo:";
            // 
            // txtlegajo
            // 
            this.txtlegajo.Location = new System.Drawing.Point(101, 32);
            this.txtlegajo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtlegajo.Name = "txtlegajo";
            this.txtlegajo.Size = new System.Drawing.Size(85, 20);
            this.txtlegajo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nueva contraseña:";
            // 
            // txtnueva
            // 
            this.txtnueva.Location = new System.Drawing.Point(162, 133);
            this.txtnueva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnueva.Name = "txtnueva";
            this.txtnueva.Size = new System.Drawing.Size(85, 20);
            this.txtnueva.TabIndex = 5;
            // 
            // txtvieja
            // 
            this.txtvieja.Location = new System.Drawing.Point(162, 99);
            this.txtvieja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtvieja.Name = "txtvieja";
            this.txtvieja.Size = new System.Drawing.Size(85, 20);
            this.txtvieja.TabIndex = 6;
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(253, 32);
            this.btncargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(86, 21);
            this.btncargar.TabIndex = 7;
            this.btncargar.Text = "Cargar datos";
            this.btncargar.UseVisualStyleBackColor = true;
            // 
            // FormDesbloquearcredencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.txtvieja);
            this.Controls.Add(this.txtnueva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlegajo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncambiar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDesbloquearcredencial";
            this.Text = "FormDesbloquearcredencial";
            this.Load += new System.EventHandler(this.FormDesbloquearcredencial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncambiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlegajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnueva;
        private System.Windows.Forms.TextBox txtvieja;
        private System.Windows.Forms.Button btncargar;
    }
}