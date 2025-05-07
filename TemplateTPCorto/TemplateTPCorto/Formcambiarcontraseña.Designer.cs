namespace TemplateTPCorto
{
    partial class Formcambiarcontraseña
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttoncambiar = new System.Windows.Forms.Button();
            this.Contraseñaactual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxContraactual = new System.Windows.Forms.TextBox();
            this.textBoxcontranueva = new System.Windows.Forms.TextBox();
            this.textBoxrepetircontra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(252, 395);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(169, 34);
            this.buttonCancelar.TabIndex = 0;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttoncambiar
            // 
            this.buttoncambiar.Location = new System.Drawing.Point(474, 397);
            this.buttoncambiar.Name = "buttoncambiar";
            this.buttoncambiar.Size = new System.Drawing.Size(182, 31);
            this.buttoncambiar.TabIndex = 1;
            this.buttoncambiar.Text = "Cambiar";
            this.buttoncambiar.UseVisualStyleBackColor = true;
            this.buttoncambiar.Click += new System.EventHandler(this.buttoncambiar_Click);
            // 
            // Contraseñaactual
            // 
            this.Contraseñaactual.AutoSize = true;
            this.Contraseñaactual.Location = new System.Drawing.Point(40, 65);
            this.Contraseñaactual.Name = "Contraseñaactual";
            this.Contraseñaactual.Size = new System.Drawing.Size(139, 20);
            this.Contraseñaactual.TabIndex = 2;
            this.Contraseñaactual.Text = "Contraseña actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Introducir nueva contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repetir nueva contraseña";
            // 
            // textBoxContraactual
            // 
            this.textBoxContraactual.Location = new System.Drawing.Point(331, 62);
            this.textBoxContraactual.Name = "textBoxContraactual";
            this.textBoxContraactual.Size = new System.Drawing.Size(207, 26);
            this.textBoxContraactual.TabIndex = 5;
            // 
            // textBoxcontranueva
            // 
            this.textBoxcontranueva.Location = new System.Drawing.Point(331, 111);
            this.textBoxcontranueva.Name = "textBoxcontranueva";
            this.textBoxcontranueva.Size = new System.Drawing.Size(206, 26);
            this.textBoxcontranueva.TabIndex = 6;
            // 
            // textBoxrepetircontra
            // 
            this.textBoxrepetircontra.Location = new System.Drawing.Point(331, 165);
            this.textBoxrepetircontra.Name = "textBoxrepetircontra";
            this.textBoxrepetircontra.Size = new System.Drawing.Size(202, 26);
            this.textBoxrepetircontra.TabIndex = 7;
            // 
            // Formcambiarcontraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 573);
            this.Controls.Add(this.textBoxrepetircontra);
            this.Controls.Add(this.textBoxcontranueva);
            this.Controls.Add(this.textBoxContraactual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Contraseñaactual);
            this.Controls.Add(this.buttoncambiar);
            this.Controls.Add(this.buttonCancelar);
            this.Name = "Formcambiarcontraseña";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttoncambiar;
        private System.Windows.Forms.Label Contraseñaactual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxContraactual;
        private System.Windows.Forms.TextBox textBoxcontranueva;
        private System.Windows.Forms.TextBox textBoxrepetircontra;
    }
}