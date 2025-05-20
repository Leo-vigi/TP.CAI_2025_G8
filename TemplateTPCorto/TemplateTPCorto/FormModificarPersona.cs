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

            // Asignamos los eventos de los botones
            btnCargar.Click += new EventHandler(btnCargar_Click);
            btncambiar.Click += new EventHandler(btncambiar_Click);
        }

        // Al salir del TextBox de legajo, se carga la información
        private void txtlegajo_Leave(object sender, EventArgs e)
        {
            CargarDatosPersona();
        }

        // Botón Cargar invoca la carga de datos
        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDatosPersona();
        }

        // Se cargan los datos desde persona.csv a los TextBox
        private void CargarDatosPersona()
        {
            string legajo = txtlegajo.Text.Trim();
            string rutaPersona = @"C:\Users\Usuario\Desktop\Punto 4 final\TP.CAI_2025_G8\TemplateTPCorto\Persistencia\DataBase\Tablas\persona.csv";

            if (!File.Exists(rutaPersona))
            {
                MessageBox.Show("⚠️ Archivo persona.csv no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.WriteLine($"🔎 Buscando legajo {legajo} en {rutaPersona}");

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

                    Console.WriteLine($"✅ Datos cargados: {datos[1]} {datos[2]} {datos[3]} {datos[4]}");
                    return; // Se detiene cuando se encuentra el legajo
                }
            }

            MessageBox.Show("❌ Legajo no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Botón Cambiar: guarda la solicitud en operacion_cambio_persona.csv
        private void btncambiar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("🔎 Ejecutando btncambiar_Click()...");

            string legajoModificado = txtlegajo.Text.Trim();
            // Usamos la ruta donde están los CSV, según la que indicas:
            string rutaOperaciones = @"C:\Users\Usuario\Desktop\Punto 4 final\TP.CAI_2025_G8\TemplateTPCorto\Persistencia\DataBase\Tablas\operacion_cambio_persona.csv";

            if (legajoModificado != legajoActual)
            {
                MessageBox.Show("No se puede cambiar el número de legajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Verificar el directorio
                string directorio = Path.GetDirectoryName(rutaOperaciones);
                if (!Directory.Exists(directorio))
                {
                    Console.WriteLine($"⚠️ Directorio no encontrado: {directorio}. Se creará.");
                    Directory.CreateDirectory(directorio);
                }

                // Si el archivo no existe, lo creamos con el encabezado y un salto de línea garantizado
                if (!File.Exists(rutaOperaciones))
                {
                    Console.WriteLine("⚠️ No se encontró operacion_cambio_persona.csv, creando nuevo archivo con encabezado.");
                    // Usamos "\r\n" para asegurar el salto de línea en Windows.
                    File.WriteAllText(rutaOperaciones, "idOperacion;legajo;nombre;apellido;dni;fecha_ingreso\r\n", Encoding.UTF8);
                }

                // Leer las líneas existentes para calcular el nuevo ID
                string[] lineasExistentes = File.ReadAllLines(rutaOperaciones, Encoding.UTF8);
                // El primer elemento es el encabezado, por lo que la cantidad de líneas ya indica qué ID asignar
                int nuevoId = lineasExistentes.Length;  // Por ejemplo, si solo está el encabezado, nuevoId será 1

                string nuevaOperacion = $"{nuevoId};{legajoActual};{txtnombre.Text};{txtapellido.Text};{txtdni.Text};{txtfechaing.Text}";

                // Usamos StreamWriter en modo Append para agregar la nueva solicitud en un nuevo renglón
                using (StreamWriter sw = new StreamWriter(rutaOperaciones, true, Encoding.UTF8))
                {
                    sw.WriteLine(nuevaOperacion);
                }

                Console.WriteLine($"✅ Solicitud registrada: {nuevaOperacion}");
                MessageBox.Show("✅ Solicitud registrada en operacion_cambio_persona.csv.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la solicitud: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("❌ Error: " + ex.ToString());
            }
        }

        private void FormModificarPersona_Load(object sender, EventArgs e)
        {

        }
    }


}








