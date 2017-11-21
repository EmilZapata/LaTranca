using LaTranca.Context.Core;
using LaTranca.Context.Helper;
using LaTranca.Dominio.DTO.LaTranca;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTranca.Infraestructura.Datos.LaTranca
{
    public class TR_PRODUCTORepository
    {
        LaTrancaContext db = null;

        public TR_PRODUCTORepository(LaTrancaContext context)
        {
            this.db = context;
        }

        public List<TR_PRODUCTO> GetListProductos()
        {
            return db.PRODUCTOS.ToList();
        }

        public Notification SaveUpdate(TR_PRODUCTO model) {
            Notification notificacion;
            try
            {
                if (model.PROD_ID == 0)
                {
                    db.PRODUCTOS.Add(model);
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

        public TR_PRODUCTO GetId(int id)
        {
            return db.PRODUCTOS.Where(p => p.PROD_ID == id).FirstOrDefault();
        }

    }
}
