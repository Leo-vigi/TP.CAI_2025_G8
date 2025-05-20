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
            this.btnpersona.Location = new System.Drawing.Point(12, 349);
            this.btnpersona.Name = "btnpersona";
            this.btnpersona.Size = new System.Drawing.Size(277, 29);
            this.btnpersona.TabIndex = 0;
            this.btnpersona.Text = "Aprobar modificaciones persona";
            this.btnpersona.UseVisualStyleBackColor = true;
            // 
            // btncredenciales
            // 
            this.btncredenciales.Location = new System.Drawing.Point(482, 349);
            this.btncredenciales.Name = "btncredenciales";
            this.btncredenciales.Size = new System.Drawing.Size(292, 29);
            this.btncredenciales.TabIndex = 1;
            this.btncredenciales.Text = "Aprobar modificaciones credenciales";
            this.btncredenciales.UseVisualStyleBackColor = true;
            // 
            // listBoxpersona
            // 
            this.listBoxpersona.FormattingEnabled = true;
            this.listBoxpersona.ItemHeight = 20;
            this.listBoxpersona.Location = new System.Drawing.Point(44, 40);
            this.listBoxpersona.Name = "listBoxpersona";
            this.listBoxpersona.Size = new System.Drawing.Size(244, 184);
            this.listBoxpersona.TabIndex = 2;
            // 
            // listBoxcredenciales
            // 
            this.listBoxcredenciales.FormattingEnabled = true;
            this.listBoxcredenciales.ItemHeight = 20;
            this.listBoxcredenciales.Location = new System.Drawing.Point(500, 40);
            this.listBoxcredenciales.Name = "listBoxcredenciales";
            this.listBoxcredenciales.Size = new System.Drawing.Size(244, 184);
            this.listBoxcredenciales.TabIndex = 3;
            // 
            // btncancelarpersona
            // 
            this.btncancelarpersona.Location = new System.Drawing.Point(26, 399);
            this.btncancelarpersona.Name = "btncancelarpersona";
            this.btncancelarpersona.Size = new System.Drawing.Size(262, 29);
            this.btncancelarpersona.TabIndex = 4;
            this.btncancelarpersona.Text = "Cancelar cambios persona";
            this.btncancelarpersona.UseVisualStyleBackColor = true;
            // 
            // btncancelarcredenciales
            // 
            this.btncancelarcredenciales.Location = new System.Drawing.Point(482, 399);
            this.btncancelarcredenciales.Name = "btncancelarcredenciales";
            this.btncancelarcredenciales.Size = new System.Drawing.Size(262, 29);
            this.btncancelarcredenciales.TabIndex = 5;
            this.btncancelarcredenciales.Text = "Cancelar cambios credenciales";
            this.btncancelarcredenciales.UseVisualStyleBackColor = true;
            // 
            // btncargarpersonas
            // 
            this.btncargarpersonas.Location = new System.Drawing.Point(65, 252);
            this.btncargarpersonas.Name = "btncargarpersonas";
            this.btncargarpersonas.Size = new System.Drawing.Size(209, 40);
            this.btncargarpersonas.TabIndex = 6;
            this.btncargarpersonas.Text = "Cargar solicitudes";
            this.btncargarpersonas.UseVisualStyleBackColor = true;
            // 
            // btncargarcredenciales
            // 
            this.btncargarcredenciales.Location = new System.Drawing.Point(535, 252);
            this.btncargarcredenciales.Name = "btncargarcredenciales";
            this.btncargarcredenciales.Size = new System.Drawing.Size(209, 40);
            this.btncargarcredenciales.TabIndex = 7;
            this.btncargarcredenciales.Text = "Cargar solicitudes";
            this.btncargarcredenciales.UseVisualStyleBackColor = true;
            // 
            // FormAutorizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncargarcredenciales);
            this.Controls.Add(this.btncargarpersonas);
            this.Controls.Add(this.btncancelarcredenciales);
            this.Controls.Add(this.btncancelarpersona);
            this.Controls.Add(this.listBoxcredenciales);
            this.Controls.Add(this.listBoxpersona);
            this.Controls.Add(this.btncredenciales);
            this.Controls.Add(this.btnpersona);
            this.Name = "FormAutorizaciones";
            this.Text = "FormAutorizaciones";
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