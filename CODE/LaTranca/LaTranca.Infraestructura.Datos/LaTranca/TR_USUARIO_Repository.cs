using LaTranca.Context.Core;
using LaTranca.Context.Helper;
using LaTranca.Dominio.DTO.LaTranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTranca.Infraestructura.Datos.LaTranca
{
    public class TR_USUARIO_Repository
    {
        LaTrancaContext db = null;

        public TR_USUARIO_Repository(LaTrancaContext context)
        {
            this.db = context;
        }

        public TR_USUARIO GetUsuarioID(int idUsuario)
        {
            return db.USUARIOS.Where(u => u.USER_ID == idUsuario).FirstOrDefault();
        }

        public List<TR_USUARIO> GetListUsuariosTR()
        {
            return db.USUARIOS.ToList();
        }

        public Notification SaveUpdate(TR_USUARIO entity)
        {

            Notification notificacion;
            try
            {
                if (entity.USER_ID == 0)
                {
                    //entity.USUARIO_FECHAREGISTRO = DateTime.Now;
                    //entity.ACTIVO = true;
                    db.USUARIOS.Add(entity);
                }
                else
                {
                    //entity.ACTUALIZACION_FECHA = DateTime.Now;
                }

                db.SaveChanges();
                notificacion = new Notification("exito", "Exito", "Transaccion exitosa.");

            }
            catch (Exception excp)
            {
                notificacion = new Notification("error", "Error", "Error en el sistema");
            }

            return notificacion;
        }
    }
}
