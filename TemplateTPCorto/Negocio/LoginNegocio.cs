using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class LoginNegocio
    {
        public Credencial login(String usuario, String password)
        {
            UsuarioPersistencia usuarioPersistencia = new UsuarioPersistencia();

            Credencial credencial = usuarioPersistencia.login(usuario);

            if (credencial.Contrasena.Equals(password))
            {
                return credencial;
            }
            return null;
        }


        UsuarioPersistencia usuarioPersistencia = new UsuarioPersistencia();


        public string IntentarLogin(string usuario, string password)
        {
            if (usuarioPersistencia.EstaBloqueado(usuario))
                return " El usuario está bloqueado. No puede ingresar.";

            Credencial credencial = usuarioPersistencia.ObtenerCredencial(usuario);
            if (credencial == null)
                return " Usuario no encontrado.";

            int intentos = usuarioPersistencia.ObtenerIntentos(usuario);
            int intentosRestantes = 3 - intentos;

            if (!credencial.Contrasena.Equals(password))
            {
                usuarioPersistencia.RegistrarIntentoFallido(usuario);
                intentos++; // Incrementamos el contador después de registrar el intento

                if (intentos >= 3)
                {
                    usuarioPersistencia.BloquearUsuario(usuario);
                    return " Usuario bloqueado por demasiados intentos fallidos.";
                }
               
                return $" Credenciales incorrectas. Intentos restantes: {3 - intentos}";
            }
           



            // Si el usuario ingresa correctamente en el tercer intento, limpiamos el registro de intentos fallidos
            usuarioPersistencia.LimpiarIntentos(usuario);
            return " Login exitoso.";
        }
        public string CambiarContraseña(string usuario, string contrasenaActual, string nuevaContrasena)
        {
            Credencial credencial = usuarioPersistencia.ObtenerCredencial(usuario);

            if (credencial == null) return "Usuario no encontrado.";

            if (!credencial.Contrasena.Equals(contrasenaActual)) return "Contraseña actual incorrecta.";

            if (nuevaContrasena.Length < 8) return "La nueva contraseña debe tener al menos 8 caracteres.";

            if (nuevaContrasena.Equals(credencial.Contrasena)) return "La nueva contraseña debe ser diferente a la anterior.";

            usuarioPersistencia.ActualizarContrasena(usuario, nuevaContrasena);

            return "Contraseña actualizada correctamente.";
        }

       
    }
}
