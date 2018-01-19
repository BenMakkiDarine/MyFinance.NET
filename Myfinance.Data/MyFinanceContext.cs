using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myfinance.domain.Entities;
using Myfinance.Data.Configuration;
using Myfinance.Data.Conventions;

namespace Myfinance.Data
{
    public class MyFinanceContext : DbContext
    {
        public MyFinanceContext() : base("name=Revision")
        {
     
         }
       
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Provider> providers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new AdressConfiguration());
            modelBuilder.Conventions.Add(new ConventionDate());

        }
    }
    
}

