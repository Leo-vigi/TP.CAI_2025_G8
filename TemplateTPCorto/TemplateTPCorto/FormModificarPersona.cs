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
using static Persistencia.DataBase.DataBaseUtils;

namespace TemplateTPCorto
{
    public partial class FormModificarPersona : Form
    {
        private string legajoActual;

        public FormModificarPersona()
        {
            InitializeComponent();

            // Asignamos los eventos de los botones
            btnCargar.Click += new EventHandler(btnCargar_Click);
            btncambiar.Click += new EventHandler(btncambiar_Click);
        }

        private void txtlegajo_Leave(object sender, EventArgs e)
        {
            CargarDatosPersona();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDatosPersona();
        }

        private void CargarDatosPersona()
        {
            string legajo = txtlegajo.Text.Trim();
            string rutaPersona = DatabaseUtils.GetFilePath("persona.csv");

            if (!File.Exists(rutaPersona))
            {
                MessageBox.Show(" Archivo persona.csv no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.WriteLine($" Buscando legajo {legajo} en {rutaPersona}");

            var lineas = File.ReadAllLines(rutaPersona).Skip(1);
            foreach (var linea in lineas)
            {
                var datos = linea.Split(';').Select(d => d.Trim()).ToArray();
                if (datos.Length >= 5 && datos[0] == legajo)
                {
                    legajoActual = legajo;
                    txtnombre.Text = datos[1];
                    txtapellido.Text = datos[2];
                    txtdni.Text = datos[3];
                    txtfechaing.Text = datos[4];

                    Console.WriteLine($" Datos cargados: {datos[1]} {datos[2]} {datos[3]} {datos[4]}");
                    return;
                }
            }

            MessageBox.Show(" Legajo no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(" Ejecutando btncambiar_Click()...");

            string legajoModificado = txtlegajo.Text.Trim();
            string rutaOperaciones = DatabaseUtils.GetFilePath("operacion_cambio_persona.csv");

            if (legajoModificado != legajoActual)
            {
                MessageBox.Show("No se puede cambiar el número de legajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (!File.Exists(rutaOperaciones))
                {
                    Console.WriteLine(" operacion_cambio_persona.csv no existe. Creando nuevo archivo con encabezado.");
                    File.WriteAllText(rutaOperaciones, "idOperacion;legajo;nombre;apellido;dni;fecha_ingreso\r\n", Encoding.UTF8);
                }

                string[] lineasExistentes = File.ReadAllLines(rutaOperaciones, Encoding.UTF8);
                int nuevoId = lineasExistentes.Length;

                string nuevaOperacion = $"{nuevoId};{legajoActual};{txtnombre.Text};{txtapellido.Text};{txtdni.Text};{txtfechaing.Text}";

                using (StreamWriter sw = new StreamWriter(rutaOperaciones, true, Encoding.UTF8))
                {
                    sw.WriteLine(nuevaOperacion);
                }

                Console.WriteLine($" Solicitud registrada: {nuevaOperacion}");
                MessageBox.Show(" Solicitud registrada en operacion_cambio_persona.csv.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la solicitud: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(" Error: " + ex.ToString());
            }
        }

        private void FormModificarPersona_Load(object sender, EventArgs e)
        {
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void labelfechaingreso_Click(object sender, EventArgs e)
        {

        }
    }
}







