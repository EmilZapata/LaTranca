using LaTranca.Dominio.DTO;
using LaTranca.Dominio.DTO.LaTranca;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LaTranca.Context.Core
{
    public class LaTrancaContext : DbContext
    {
        static LaTrancaContext()
        {
            Database.SetInitializer<LaTrancaContext>(null);
        }

        public LaTrancaContext() : base("Name=LaTrancaContext") { }

        public DbSet<TR_PRODUCTO> PRODUCTOS { get; set; }
        public DbSet<TR_USUARIO> USUARIOS { get; set; }
        public DbSet<TR_FERIA> FERIAS { get; set; }
        public DbSet<TR_DETALLE_VENTA> DETALLE_VENTAS { get; set; }
        public DbSet<TR_PEDIDO> PEDIDOS { get; set; }
        public DbSet<TR_PARAMETRO> PARAMETROS { get; set; }
        public DbSet<TR_TIPO_PARAMETRO> TIPO_PARAMETROS { get; set; }


        public override int SaveChanges()
        {
            // Obtener lista de entidades que heredan de AbstractModel (Clase que impementa propiedades de log)
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseDTO && (x.State == EntityState.Added || x.State == EntityState.Modified));

            // Obtener usuario de sesión
            var userName = !string.IsNullOrEmpty(System.Web.HttpContext.Current?.User?.Identity?.Name) ? HttpContext.Current.User.Identity.Name : "Anonymous";
            string[] listName;

            if (userName != "Anonymous")
            {
                listName = userName.Split('@');
            }
            else
            {
                listName = new string[] { "Anonymous" };
            }

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added) // Nuevas entidades agregadas
                {
                    ((BaseDTO)entity.Entity).REGISTRO_USUARIO = listName[0]; // Set usuario
                    ((BaseDTO)entity.Entity).REGISTRO_FECHA = DateTime.Now; // Set fecha
                }

                if (entity.State == EntityState.Modified) // Entidades modificacdas
                {
                    ((BaseDTO)entity.Entity).ACTUALIZACION_USUARIO = listName[0]; // Set usuario
                    ((BaseDTO)entity.Entity).ACTUALIZACION_FECHA = DateTime.Now; // Set fecha
                }
            }

            return base.SaveChanges();
        }

    }
}
