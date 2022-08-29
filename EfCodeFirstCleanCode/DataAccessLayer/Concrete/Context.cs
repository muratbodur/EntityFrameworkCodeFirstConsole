using EfCodeFirstCleanCode.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstCleanCode.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DEVELOPER;Initial Catalog=EFCodeFirst;integrated security=true; User ID=sa;Password=2697");
            
        }

        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
