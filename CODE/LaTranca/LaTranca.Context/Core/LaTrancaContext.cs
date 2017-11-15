using LaTranca.Dominio.DTO.LaTranca;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTranca.Context.Core
{
    public class LaTrancaContext : DbContext
    {
        static LaTrancaContext()
        {
            Database.SetInitializer<LaTrancaContext>(null);
        }

        public LaTrancaContext() : base("Name=LaTrancaContext") { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<TR_USUARIO> USUARIOS { get; set; }
    }
}
