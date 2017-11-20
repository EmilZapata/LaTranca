using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTranca.Dominio.DTO.LaTranca
{
    [Table("TR_TIPO_PARAMETRO")]
    public class TR_TIPO_PARAMETRO
    {
        [Key]
        public int TPAR_ID { get; set; }
        public decimal? TPAR_NOMBRE { get; set; }
    }
}
