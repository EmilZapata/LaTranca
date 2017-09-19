using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTranca.Context.Core
{
 public   class LaTrancaContext : DbContext
    {
        static LaTrancaContext()
        {
            Database.SetInitializer<LaTrancaContext>(null);
        }

        public LaTrancaContext() : base("Name=LaTrancaContext") { }

    }
}
