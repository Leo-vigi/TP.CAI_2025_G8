using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DataBase
{
    public class DataBaseUtils
        
    {
        string archivoCsv = @"G:\CAI\V1\TP.CAI_2025_G8\TemplateTPCorto\Persistencia\DataBase\Tablas\";

        //Método para Buscar Registro
        public List<string> BuscarRegistro(string nombreArchivo)
        {
            string rutaArchivo = Path.Combine(@"G:\CAI\V1\TP.CAI_2025_G8\TemplateTPCorto\Persistencia\DataBase\Tablas\", nombreArchivo);

            Console.WriteLine($"Buscando archivo en: {rutaArchivo}");

            List<string> listado = new List<string>();

            try
            {
                if (!File.Exists(rutaArchivo)) // 🔹 Corrección: Negación en la condición
                {
                    Console.WriteLine($"Archivo no encontrado: {rutaArchivo}");
                    return listado;
                }

                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        Console.WriteLine($"Línea leída: {linea}"); // 🔹 Depuración
                        listado.Add(linea);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al leer el archivo:");
                Console.WriteLine($"Mensaje: {e.Message}");
            }

            return listado;
        }

        // Método para borrar un registro
        public void BorrarRegistro(string id, String nombreArchivo)
        {
            archivoCsv = archivoCsv + nombreArchivo; // Cambia esta ruta al archivo CSV que deseas leer

            String rutaArchivo = Path.GetFullPath(archivoCsv); // Normaliza la ruta

            try
            {
                // Verificar si el archivo existe
                if (!File.Exists(rutaArchivo))
                {
                    Console.WriteLine("El archivo no existe: " + archivoCsv);
                    return;
                }

                // Leer el archivo y obtener las líneas
                List<string> listado = BuscarRegistro(nombreArchivo);

                // Filtrar las líneas que no coinciden con el ID a borrar 
                var registrosRestantes = listado.Where(linea =>
                {
                    var campos = linea.Split(';');
                    return campos[0] != id; // Verifica solo el ID (primera columna)
                }).ToList();

                // Sobrescribir el archivo con las líneas restantes
                File.WriteAllLines(archivoCsv, registrosRestantes);

                Console.WriteLine($"Registro con ID {id} borrado correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al intentar borrar el registro:");
                Console.WriteLine($"Mensaje: {e.Message}");
                Console.WriteLine($"Pila de errores: {e.StackTrace}");
            }
        }

        

        public void AgregarRegistro(string nombreArchivo, string nuevoRegistro)
        {
            string rutaArchivo = Path.Combine(@"G:\CAI\V1\TP.CAI_2025_G8\TemplateTPCorto\Persistencia\DataBase\Tablas\", nombreArchivo);

            try
            {
                Console.WriteLine($" Escribiendo en archivo: {rutaArchivo}");

                // Verificar si el archivo existe; si no, agregar la cabecera
                if (!File.Exists(rutaArchivo))
                {
                    using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                    {
                        sw.WriteLine("legajo"); // Cabecera del archivo
                    }
                }

                // Escribir el nuevo registro
                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    sw.WriteLine(nuevoRegistro);
                }

                Console.WriteLine(" Registro agregado correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine(" Error al intentar agregar el registro:");
                Console.WriteLine($"Mensaje: {e.Message}");
                Console.WriteLine($"Pila de errores: {e.StackTrace}");
            }
        }



    }
}
