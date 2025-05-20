using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Credencial
    {
        private String _legajo;
        private String _nombreUsuario;
        private String _contrasena;
        private DateTime _fechaAlta;
        private DateTime _fechaUltimoLogin;

        public string Legajo { get => _legajo; set => _legajo = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime FechaUltimoLogin { get => _fechaUltimoLogin; set => _fechaUltimoLogin = value; }



        public Credencial(string registro)
        {
            // Separar los campos
            string[] datos = registro.Split(';');

            // Asignar los campos básicos
            this._legajo = datos[0];
            this._nombreUsuario = datos[1];
            this._contrasena = datos[2];

            // Definimos los formatos permitidos: solo fecha o fecha con hora
            string[] formatos = { "d/M/yyyy", "d/M/yyyy HH:mm:ss" };

            // Se parsea la fecha de alta usando los formatos permitidos
            this._fechaAlta = DateTime.ParseExact(datos[3].Trim(), formatos, CultureInfo.InvariantCulture, DateTimeStyles.None);

            // Se parsea la fecha de último login, si existe; de lo contrario, se asigna DateTime.MinValue.
            if (!string.IsNullOrWhiteSpace(datos[4].Trim()))
            {
                this._fechaUltimoLogin = DateTime.ParseExact(datos[4].Trim(), formatos, CultureInfo.InvariantCulture, DateTimeStyles.None);
            }
            else
            {
                this._fechaUltimoLogin = DateTime.MinValue;
            }
        }



        public bool ContrasenaExpirada()
        {
            return (DateTime.Now - _fechaUltimoLogin).TotalDays >= 30;
        }


    }
}
