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
            this.SuspendLayout();
            // 
            // btncambiar
            // 
            this.btncambiar.Location = new System.Drawing.Point(288, 340);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(137, 34);
            this.btncambiar.TabIndex = 0;
            this.btncambiar.Text = "Cambiar";
            this.btncambiar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Legajo:";
            // 
            // txtlegajo
            // 
            this.txtlegajo.Location = new System.Drawing.Point(152, 49);
            this.txtlegajo.Name = "txtlegajo";
            this.txtlegajo.Size = new System.Drawing.Size(125, 26);
            this.txtlegajo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nueva contraseña:";
            // 
            // txtnueva
            // 
            this.txtnueva.Location = new System.Drawing.Point(243, 204);
            this.txtnueva.Name = "txtnueva";
            this.txtnueva.Size = new System.Drawing.Size(125, 26);
            this.txtnueva.TabIndex = 5;
            // 
            // txtvieja
            // 
            this.txtvieja.Location = new System.Drawing.Point(243, 152);
            this.txtvieja.Name = "txtvieja";
            this.txtvieja.Size = new System.Drawing.Size(125, 26);
            this.txtvieja.TabIndex = 6;
            // 
            // FormDesbloquearcredencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtvieja);
            this.Controls.Add(this.txtnueva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlegajo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncambiar);
            this.Name = "FormDesbloquearcredencial";
            this.Text = "FormDesbloquearcredencial";
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
    }
}