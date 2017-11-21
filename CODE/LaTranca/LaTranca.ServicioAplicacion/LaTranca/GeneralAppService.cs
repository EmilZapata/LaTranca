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
        #region TR_PRODUCTO
        public List<TR_PRODUCTO> ListProducto()
        {
            return FactoryGeneral.GetProductoRepository().GetListProductos();
        }

        public Notification SaveUpdateProducto(TR_PRODUCTO entity)
        {
            return FactoryGeneral.GetProductoRepository().SaveUpdate(entity);
        }

        public TR_PRODUCTO GetIdProducto(int id)
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

        public Notification SaveUpdateUsuario(TR_USUARIO entity) {
            return FactoryGeneral.GetUsuarioRepository().SaveUpdate(entity);
        }
        #endregion
    }
}
