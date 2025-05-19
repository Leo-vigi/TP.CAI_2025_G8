using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPCorto
{
    public partial class FormModificarPersona : Form
    {
        
            private string legajoActual;

            public FormModificarPersona()
            {
                InitializeComponent();
            }

            private void txtlegajo_Leave(object sender, EventArgs e)
            {
                string legajo = txtlegajo.Text.Trim();
                string rutaPersona = "persona.csv";

                if (!File.Exists(rutaPersona))
                {
                    MessageBox.Show("Archivo persona.csv no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var lineas = File.ReadAllLines(rutaPersona).Skip(1);
                var persona = lineas.Select(line => line.Split(';')).FirstOrDefault(fields => fields[0] == legajo);

                if (persona != null)
                {
                    legajoActual = legajo;
                    txtnombre.Text = persona[1];
                    txtapellido.Text = persona[2];
                    txtdni.Text = persona[3];
                    txtfechaing.Text = persona[4];
                }
                else
                {
                    MessageBox.Show("Legajo no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btncambiar_Click(object sender, EventArgs e)
            {
                string legajoModificado = txtlegajo.Text.Trim();

                if (legajoModificado != legajoActual)
                {
                    MessageBox.Show("No se puede cambiar el número de legajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string rutaOperaciones = "operaciones_cambio_persona.csv";

                if (!File.Exists(rutaOperaciones))
                {
                    File.WriteAllText(rutaOperaciones, "idOperacion;legajo;nombre;apellido;dni;fecha_ingreso\n");
                }

                int nuevoId = File.ReadAllLines(rutaOperaciones).Skip(1).Count() + 1;
                string nuevaOperacion = $"{nuevoId};{legajoActual};{txtnombre.Text};{txtapellido.Text};{txtdni.Text};{txtfechaing.Text}";
                File.AppendAllText(rutaOperaciones, nuevaOperacion + Environment.NewLine);

                MessageBox.Show("Solicitud de cambio registrada. Un administrador debe aprobarla.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
