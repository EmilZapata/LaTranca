using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTranca.Dominio.DTO.LaTranca
{
    [Table("TR_USUARIO")]
    public class TR_USUARIO
    {
        [Key]
        public int USER_ID { get; set; } 
        public string AspNetUsers_Id { get; set; }
        public string USER_NOMBRES { get; set; }
        public string USER_APE_PATERNO { get; set; }
        public string USER_APE_MATERNO { get; set; }
        public string USER_NUM_DNI { get; set; }
        public string USER_TELEFONO { get; set; }
        public string USER_CELULAR { get; set; }
        public string USER_DIRECCION { get; set; }
        public string USER_CORREO { get; set; }
        public int USER_TIPO_DOCUMENTO { get; set; }
        public int USER_ESTADO { get; set; }
    }
}
