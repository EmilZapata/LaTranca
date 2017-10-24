using LaTranca.Context.Helper;
using LaTranca.Dominio.DTO.LaTranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTranca.ServicioAplicacion.LaTranca
{
    public class GeneralAppService
    {
        public List<Producto> ListProducto()
        {
            return FactoryGeneral.GetProductoRepository().GetListProductos();
        }

        public Notification SaveUpdateProducto(Producto entity)
        {
            return FactoryGeneral.GetProductoRepository().SaveUpdate(entity);
        }

        public Producto GetIdProducto(int id)
        {
            return FactoryGeneral.GetProductoRepository().GetId(id);
        }
    }
}
