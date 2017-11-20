using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTranca.Dominio.DTO.LaTranca
{
    [Table("TR_PRODUCTO")]
    public class TR_PRODUCTO
    {
        [Key]
        public int PROD_ID { get; set; }
        public string PROD_NOMBRE { get; set; }
        public string PROD_DESCRIPCION { get; set; }
        public decimal? PROD_PRECIO_UNIT { get; set; }
        public int? PROD_STOCK { get; set; }
        public DateTime? PROD_FECHA_VENCIMIENTO { get; set; }
        public DateTime? PROD_FECHA_REGISTRO { get; set; }
        public int? PROD_ESTADO { get; set; }
    }
}
