namespace TemplateTPCorto
{
    partial class FormAutorizaciones
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
            this.btnpersona = new System.Windows.Forms.Button();
            this.btncredenciales = new System.Windows.Forms.Button();
            this.listBoxpersona = new System.Windows.Forms.ListBox();
            this.listBoxcredenciales = new System.Windows.Forms.ListBox();
            this.btncancelarpersona = new System.Windows.Forms.Button();
            this.btncancelarcredenciales = new System.Windows.Forms.Button();
            this.btncargarpersonas = new System.Windows.Forms.Button();
            this.btncargarcredenciales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpersona
            // 
            this.btnpersona.Location = new System.Drawing.Point(8, 227);
            this.btnpersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnpersona.Name = "btnpersona";
            this.btnpersona.Size = new System.Drawing.Size(185, 19);
            this.btnpersona.TabIndex = 0;
            this.btnpersona.Text = "Aprobar modificaciones persona";
            this.btnpersona.UseVisualStyleBackColor = true;
            // 
            // btncredenciales
            // 
            this.btncredenciales.Location = new System.Drawing.Point(321, 227);
            this.btncredenciales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncredenciales.Name = "btncredenciales";
            this.btncredenciales.Size = new System.Drawing.Size(195, 19);
            this.btncredenciales.TabIndex = 1;
            this.btncredenciales.Text = "Aprobar modificaciones credenciales";
            this.btncredenciales.UseVisualStyleBackColor = true;
            // 
            // listBoxpersona
            // 
            this.listBoxpersona.FormattingEnabled = true;
            this.listBoxpersona.Location = new System.Drawing.Point(29, 26);
            this.listBoxpersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxpersona.Name = "listBoxpersona";
            this.listBoxpersona.Size = new System.Drawing.Size(164, 121);
            this.listBoxpersona.TabIndex = 2;
            // 
            // listBoxcredenciales
            // 
            this.listBoxcredenciales.FormattingEnabled = true;
            this.listBoxcredenciales.Location = new System.Drawing.Point(333, 26);
            this.listBoxcredenciales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxcredenciales.Name = "listBoxcredenciales";
            this.listBoxcredenciales.Size = new System.Drawing.Size(164, 121);
            this.listBoxcredenciales.TabIndex = 3;
            // 
            // btncancelarpersona
            // 
            this.btncancelarpersona.Location = new System.Drawing.Point(17, 259);
            this.btncancelarpersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncancelarpersona.Name = "btncancelarpersona";
            this.btncancelarpersona.Size = new System.Drawing.Size(175, 19);
            this.btncancelarpersona.TabIndex = 4;
            this.btncancelarpersona.Text = "Cancelar cambios persona";
            this.btncancelarpersona.UseVisualStyleBackColor = true;
            // 
            // btncancelarcredenciales
            // 
            this.btncancelarcredenciales.Location = new System.Drawing.Point(321, 259);
            this.btncancelarcredenciales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncancelarcredenciales.Name = "btncancelarcredenciales";
            this.btncancelarcredenciales.Size = new System.Drawing.Size(175, 19);
            this.btncancelarcredenciales.TabIndex = 5;
            this.btncancelarcredenciales.Text = "Cancelar cambios credenciales";
            this.btncancelarcredenciales.UseVisualStyleBackColor = true;
            // 
            // btncargarpersonas
            // 
            this.btncargarpersonas.Location = new System.Drawing.Point(43, 164);
            this.btncargarpersonas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncargarpersonas.Name = "btncargarpersonas";
            this.btncargarpersonas.Size = new System.Drawing.Size(139, 26);
            this.btncargarpersonas.TabIndex = 6;
            this.btncargarpersonas.Text = "Cargar solicitudes";
            this.btncargarpersonas.UseVisualStyleBackColor = true;
            // 
            // btncargarcredenciales
            // 
            this.btncargarcredenciales.Location = new System.Drawing.Point(357, 164);
            this.btncargarcredenciales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncargarcredenciales.Name = "btncargarcredenciales";
            this.btncargarcredenciales.Size = new System.Drawing.Size(139, 26);
            this.btncargarcredenciales.TabIndex = 7;
            this.btncargarcredenciales.Text = "Cargar solicitudes";
            this.btncargarcredenciales.UseVisualStyleBackColor = true;
            // 
            // FormAutorizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btncargarcredenciales);
            this.Controls.Add(this.btncargarpersonas);
            this.Controls.Add(this.btncancelarcredenciales);
            this.Controls.Add(this.btncancelarpersona);
            this.Controls.Add(this.listBoxcredenciales);
            this.Controls.Add(this.listBoxpersona);
            this.Controls.Add(this.btncredenciales);
            this.Controls.Add(this.btnpersona);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAutorizaciones";
            this.Text = "FormAutorizaciones";
            this.Load += new System.EventHandler(this.FormAutorizaciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpersona;
        private System.Windows.Forms.Button btncredenciales;
        private System.Windows.Forms.ListBox listBoxpersona;
        private System.Windows.Forms.ListBox listBoxcredenciales;
        private System.Windows.Forms.Button btncancelarpersona;
        private System.Windows.Forms.Button btncancelarcredenciales;
        private System.Windows.Forms.Button btncargarpersonas;
        private System.Windows.Forms.Button btncargarcredenciales;
    }
}