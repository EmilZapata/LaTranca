using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTranca.Dominio.DTO.LaTranca
{
    [Table("TR_FERIA")]
    public class TR_FERIA
    {
        [Key]
        public int FER_ID { get; set; }
        public string FER_NOMBRE { get; set; }
        public int FER_UBIGEO { get; set; }
        public string FER_HORARIO { get; set; }
        public DateTime? FER_FECHA { get; set; }
        public int FER_ESTADO { get; set; }
    }
}
