using Myfinance.domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfinance.Data.Configuration
{
   public  class ProductConfiguration :EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {

            //Many To Many asscociation class
            HasMany(p => p.providers)
            .WithMany(pr => pr.products)
            .Map(m => m.ToTable("Providing"));

            //Heritage
            Map<Biological>(b => b.Requires("TypeOfProduct").HasValue("Bio"));
            Map<Chemical>(b => b.Requires("TypeOfProduct").HasValue("PRod"));

            //0..1 To Manu
            HasOptional(c => c.category)
           .WithMany(p => p.products).HasForeignKey(p => p.CategoryId).WillCascadeOnDelete(false);
            
        }
    }
}
