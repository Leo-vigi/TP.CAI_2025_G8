using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.IO;
namespace TemplateTPCorto
{
    partial class Form1
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

        public void ModificarPersona(string usuario, string nuevoNombre, string nuevaFechaAlta)
        {
            Persistencia.DataBase.DataBaseUtils dataBaseUtils = new Persistencia.DataBase.DataBaseUtils();
            List<string> registros = dataBaseUtils.BuscarRegistro("credenciales.csv");

            for (int i = 1; i < registros.Count; i++) // Omitimos cabecera
            {
                string[] campos = registros[i].Split(';');
                if (campos[1].Trim().Equals(usuario.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    // 🔹 Solo permitimos modificar el nombre y la fecha de alta, pero NO el legajo.
                    campos[2] = nuevoNombre;
                    campos[3] = nuevaFechaAlta;

                    registros[i] = string.Join(";", campos);
                    break;
                }
            }

            File.WriteAllLines("credenciales.csv", registros);
            MessageBox.Show("Datos de usuario actualizados correctamente.");
        }
        
    }
}