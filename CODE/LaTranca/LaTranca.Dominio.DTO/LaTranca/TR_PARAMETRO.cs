using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTranca.Dominio.DTO.LaTranca
{
    [Table("TR_PARAMETRO")]
    public class TR_PARAMETRO
    {
        [Key]
        public int PAR_ID { get; set; }
        public string PAR_NOMBRE { get; set; }
        public int TPAR_ID { get; set; }
    }
}
