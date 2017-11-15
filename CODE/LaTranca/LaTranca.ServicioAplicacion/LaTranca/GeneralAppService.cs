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
        #region Tabla_Producto
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
        #endregion

        #region Tabla->TR_USUARIO
        public TR_USUARIO GetUsuarioID(int idUsuario)
        {
            return FactoryGeneral.GetUsuarioRepository().GetUsuarioID(idUsuario);
        }

        public List<TR_USUARIO> GetListUsuariosTR()
        {
            return FactoryGeneral.GetUsuarioRepository().GetListUsuariosTR();
        }

        public Notification SaveUpdate(TR_USUARIO entity) {
            return FactoryGeneral.GetUsuarioRepository().SaveUpdate(entity);
        }
        #endregion
    }
}
