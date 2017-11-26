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
                    var user = db.USUARIOS.Where(u => u.USER_ID == entity.USER_ID).FirstOrDefault();

                    user.USER_NOMBRES = entity.USER_NOMBRES;
                    user.USER_APE_PATERNO = entity.USER_APE_PATERNO;
                    user.USER_APE_MATERNO = entity.USER_APE_MATERNO;
                    user.USER_TIPO_DOCUMENTO = entity.USER_TIPO_DOCUMENTO;
                    user.USER_NUM_DOCUMENTO = entity.USER_NUM_DOCUMENTO;
                    user.USER_TELEFONO = entity.USER_TELEFONO;
                    user.USER_CELULAR = entity.USER_CELULAR;
                    user.USER_DIRECCION = entity.USER_DIRECCION;
                    user.USER_CORREO = entity.USER_CORREO;
                }

                db.SaveChanges();
                notificacion = new Notification("exito", "Exito", "Transaccion exitosa.");

            }
            catch (Exception ex)
            {
                notificacion = new Notification("error", "Error", "Error en el sistema");
            }

            return notificacion;
        }
    }
}
