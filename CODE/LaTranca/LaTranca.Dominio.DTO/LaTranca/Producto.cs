using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTranca.Dominio.DTO.LaTranca
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public int idProducto { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal? precio_costo { get; set; }
        public decimal? precio_ventas { get; set; }
        public int cantidad { get; set; }
        public decimal ganancia { get; set; }
        public DateTime? fecha_vencimiento { get; set; }
        public DateTime? fecha_registro { get; set; }
        public bool estado { get; set; }
    }
}
