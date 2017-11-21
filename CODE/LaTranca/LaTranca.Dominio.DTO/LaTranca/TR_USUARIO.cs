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
        [Display(Name = "Nombres")]
        public string USER_NOMBRES { get; set; }
        [Display(Name ="Apellido Paterno")]
        public string USER_APE_PATERNO { get; set; }
        [Display(Name = "Apellido Materno")]
        public string USER_APE_MATERNO { get; set; }
        [Display(Name = "Tipo de documento")]
        public int? USER_TIPO_DOCUMENTO { get; set; }
        [Display(Name = "Numero de documento")]
        public string USER_NUM_DOCUMENTO { get; set; }
        [Display(Name = "Telefono")]
        public string USER_TELEFONO { get; set; }
        [Display(Name = "Celular")]
        public string USER_CELULAR { get; set; }
        [Display(Name = "Direccion")]
        public string USER_DIRECCION { get; set; }
        [Display(Name = "Correo")]
        public string USER_CORREO { get; set; }
        [Display(Name = "Estado")]
        public int? USER_ESTADO { get; set; }
    }
}
