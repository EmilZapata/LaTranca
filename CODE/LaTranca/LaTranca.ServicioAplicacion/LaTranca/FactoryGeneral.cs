using LaTranca.Context.Core;
using LaTranca.Infraestructura.Datos.LaTranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTranca.ServicioAplicacion.LaTranca
{
    public class FactoryGeneral
    {
        public static LaTrancaContext db = new LaTrancaContext();

        public static ProductoRepository GetProductoRepository()
        {
            return new ProductoRepository(db);
        }
    }
}
