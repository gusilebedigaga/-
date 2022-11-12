using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Анкета
{
    internal class AplicationContext : DbContext
    {

        public DbSet<Anketa> Anketas { get; set; }

        public AplicationContext() : base("DefaultConnection") { }

    }
}
