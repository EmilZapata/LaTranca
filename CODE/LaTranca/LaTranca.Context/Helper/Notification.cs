using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTranca.Context.Helper
{
    public enum NotificationType { informacion, error, exito, advertencia }

    public class Notification
    {
        public Notification()
        {
            this.tipo = NotificationType.exito.ToString();
            this.titulo = "Exito";
            this.mensaje = "Los datos se registraron con éxito.";
        }

        public Notification(string tipo, string titulo, string mensaje)
        {
            this.tipo = tipo;
            this.titulo = titulo;
            this.mensaje = mensaje;
        }

        public string tipo { get; set; }
        public string titulo { get; set; }
        public string mensaje { get; set; }
        public string linkTitulo { get; set; }
        public string linkURL { get; set; }
    }
}
