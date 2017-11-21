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

        public static TR_PRODUCTORepository GetProductoRepository()
        {
            return new TR_PRODUCTORepository(db);
        }

        public static TR_USUARIO_Repository GetUsuarioRepository()
        {
            return new TR_USUARIO_Repository(db);
        }
    }
}
