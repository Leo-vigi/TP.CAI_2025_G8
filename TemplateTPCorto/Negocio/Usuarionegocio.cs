using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Negocio
{
    public class UsuarioNegocio
    {
        public string AutenticarYRedirigir(string nombreUsuario, string password)
        {
            // 🔹 Ruta base asegurada para evitar errores de búsqueda en bin\Debug
            string rutaBase = @"C:\Users\Usuario\Desktop\Punto 4 final\TP.CAI_2025_G8\TemplateTPCorto\Persistencia\DataBase\Tablas";

            string rutaCredenciales = Path.Combine(rutaBase, "credenciales.csv");
            string rutaUsuarioPerfil = Path.Combine(rutaBase, "usuario_perfil.csv");
            string rutaPerfil = Path.Combine(rutaBase, "perfil.csv");

            // 🔹 Verificación de existencia de archivos antes de leer datos
            Console.WriteLine($"🔹 Ruta credenciales.csv: {rutaCredenciales} - Existe: {File.Exists(rutaCredenciales)}");
            Console.WriteLine($"🔹 Ruta usuario_perfil.csv: {rutaUsuarioPerfil} - Existe: {File.Exists(rutaUsuarioPerfil)}");
            Console.WriteLine($"🔹 Ruta perfil.csv: {rutaPerfil} - Existe: {File.Exists(rutaPerfil)}");

            // ❗ Si algún archivo no existe, detener el proceso con un mensaje claro
            if (!File.Exists(rutaCredenciales) || !File.Exists(rutaUsuarioPerfil) || !File.Exists(rutaPerfil))
            {
                return "Error: Uno o más archivos CSV no se encontraron.";
            }

            // 🔎 **Depuración: Mostrar cada línea que se está leyendo de los archivos CSV**
            Console.WriteLine("🔎 Leyendo archivo credenciales.csv...");
            foreach (var linea in File.ReadAllLines(rutaCredenciales).Skip(1))
            {
                Console.WriteLine($"👉 Línea en credenciales.csv: {linea}");
            }

            Console.WriteLine("🔎 Leyendo archivo usuario_perfil.csv...");
            foreach (var linea in File.ReadAllLines(rutaUsuarioPerfil).Skip(1))
            {
                Console.WriteLine($"👉 Línea en usuario_perfil.csv: {linea}");
            }

            Console.WriteLine("🔎 Leyendo archivo perfil.csv...");
            foreach (var linea in File.ReadAllLines(rutaPerfil).Skip(1))
            {
                Console.WriteLine($"👉 Línea en perfil.csv: {linea}");
            }

            // ✅ Validar usuario en credenciales.csv y obtener legajo
            var datosUsuario = File.ReadAllLines(rutaCredenciales).Skip(1)
                .Select(line => line.Split(';'))
                .FirstOrDefault(datos => datos[1].Trim() == nombreUsuario.Trim() && datos[2].Trim() == password.Trim());

            if (datosUsuario == null) return "Usuario o contraseña incorrectos.";
            string legajo = datosUsuario[0].Trim();
            Console.WriteLine($"✅ Legajo obtenido: {legajo}");

            // ✅ Obtener ID de perfil en usuario_perfil.csv
            var datosPerfil = File.ReadAllLines(rutaUsuarioPerfil).Skip(1)
                .Select(line => line.Split(';'))
                .FirstOrDefault(datos => datos[0].Trim() == legajo);

            if (datosPerfil == null || datosPerfil.Length < 2) return "El usuario no tiene un perfil asignado.";
            string idPerfil = datosPerfil[1].Trim();
            Console.WriteLine($"✅ ID de perfil obtenido: {idPerfil}");

            // ✅ Obtener nombre del perfil en perfil.csv
            var perfilEncontrado = File.ReadAllLines(rutaPerfil).Skip(1)
                .Select(line => line.Split(';'))
                .FirstOrDefault(datos => datos[0].Trim() == idPerfil);

            if (perfilEncontrado == null || perfilEncontrado.Length < 2) return "Perfil no encontrado.";
            string nombrePerfil = perfilEncontrado[1].Trim();
            Console.WriteLine($"✅ Nombre de perfil obtenido: {nombrePerfil}");

            return $"Redirigir a FormGenericoperfiles con perfil: {nombrePerfil}";
        }
    }

    }



