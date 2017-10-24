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
    public class ProductoRepository
    {
        LaTrancaContext db = null;

        public ProductoRepository(LaTrancaContext context)
        {
            this.db = context;
        }

        public List<Producto> GetListProductos()
        {
            return db.Productos.ToList();
        }

        public Notification SaveUpdate(Producto model) {
            Notification notificacion;
            try
            {
                if (model.idProducto == 0)
                {
                    db.Productos.Add(model);
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

        public Producto GetId(int id)
        {
            return db.Productos.Where(p => p.idProducto == id).FirstOrDefault();
        }

    }
}
