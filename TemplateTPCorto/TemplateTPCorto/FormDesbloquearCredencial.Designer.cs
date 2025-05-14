using Persistencia.DataBase;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.IO;

namespace TemplateTPCorto
{
    partial class Form2
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
        public void DesbloquearCredencial(string usuario, string nuevaClave)
        {
            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            List<string> registros = dataBaseUtils.BuscarRegistro("credenciales.csv");

            for (int i = 1; i < registros.Count; i++) // Omitimos cabecera
            {
                string[] campos = registros[i].Split(';'); // Ejemplo: "Legajo;Usuario;Clave;FechaÚltimoLogin"
                if (campos[1].Trim().Equals(usuario.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    // 🔹 Solo modificamos la contraseña y dejamos vacía la fecha de último login
                    campos[2] = nuevaClave;
                    campos[3] = "";

                    registros[i] = string.Join(";", campos);
                    break;
                }
            }

            File.WriteAllLines("credenciales.csv", registros);
            MessageBox.Show("Credencial desbloqueada. La nueva contraseña está activa.");
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form2";
        }

        #endregion
    }
}