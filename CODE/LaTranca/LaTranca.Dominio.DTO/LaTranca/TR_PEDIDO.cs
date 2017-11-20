using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTranca.Dominio.DTO.LaTranca
{
    [Table("TR_PEDIDO")]
    public class TR_PEDIDO
    {
        [Key]
        public int PED_ID { get; set; }
        public DateTime? PED_FECHA_VENTA { get; set; }
        public decimal? PED_MONTO_TOTAL { get; set; }
        public int PED_ID_CLIENTE { get; set; }
        public int PED_ESTADO { get; set; }
    }
}
