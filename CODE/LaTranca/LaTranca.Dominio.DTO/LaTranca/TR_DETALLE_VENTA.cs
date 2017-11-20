using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTranca.Dominio.DTO.LaTranca
{
    [Table("TR_DETALLE_VENTA")]
    public class TR_DETALLE_VENTA
    {
        [Key]
        public int DVEN_ID { get; set; }
        public int DVEN_ID_PRODUCTO { get; set; }
        public int DVEN_CANTIDAD { get; set; }
        public decimal? DVEN_MONTO { get; set; }
    }
}
