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
        public static class DatabaseUtils
        {
            private static readonly string basePath = @"G:\CAI\V7\TP.CAI_2025_G8\TemplateTPCorto\Persistencia\DataBase\Tablas";

            public static string GetFilePath(string fileName)
            {
                return Path.Combine(basePath, fileName);
            }

            public static List<string> BuscarRegistro(string nombreArchivo)
            {
                string rutaArchivo = GetFilePath(nombreArchivo);
                Console.WriteLine($"Buscando archivo en: {rutaArchivo}");

                List<string> listado = new List<string>();
                try
                {
                    if (!File.Exists(rutaArchivo))
                    {
                        Console.WriteLine($"Archivo no encontrado: {rutaArchivo}");
                        return listado;
                    }

                    using (StreamReader sr = new StreamReader(rutaArchivo))
                    {
                        string linea;
                        while ((linea = sr.ReadLine()) != null)
                        {
                            listado.Add(linea);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error al leer el archivo: {e.Message}");
                }

                return listado;
            }

            public static void BorrarRegistro(string id, string nombreArchivo)
            {
                string rutaArchivo = GetFilePath(nombreArchivo);

                try
                {
                    if (!File.Exists(rutaArchivo))
                    {
                        Console.WriteLine($"El archivo no existe: {rutaArchivo}");
                        return;
                    }

                    List<string> listado = BuscarRegistro(nombreArchivo);
                    var registrosRestantes = listado.Where(linea => linea.Split(';')[0] != id).ToList();

                    File.WriteAllLines(rutaArchivo, registrosRestantes);

                    Console.WriteLine($"Registro con ID {id} borrado correctamente.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error al borrar el registro: {e.Message}");
                }
            }

            public static void AgregarRegistro(string nombreArchivo, string nuevoRegistro)
            {
                string rutaArchivo = GetFilePath(nombreArchivo);

                try
                {
                    Console.WriteLine($"Escribiendo en archivo: {rutaArchivo}");

                    if (!File.Exists(rutaArchivo))
                    {
                        using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                        {
                            sw.WriteLine("legajo"); // Cabecera del archivo
                        }
                    }

                    using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                    {
                        sw.WriteLine(nuevoRegistro);
                    }

                    Console.WriteLine("Registro agregado correctamente.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error al agregar el registro: {e.Message}");
                }
            }
        }
    }
}