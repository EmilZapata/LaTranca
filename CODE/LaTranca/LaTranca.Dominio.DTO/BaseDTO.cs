using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTranca.Dominio.DTO
{
    public class BaseDTO
    {
        public string REGISTRO_USUARIO { get; set; }
        public DateTime? REGISTRO_FECHA { get; set; }
        public string ACTUALIZACION_USUARIO { get; set; }
        public DateTime? ACTUALIZACION_FECHA { get; set; }
        public string ANULACION_MOTIVO { get; set; }
        public string ANULACION_USUARIO { get; set; }
        public DateTime? ANULACION_FECHA { get; set; }

    }
}
