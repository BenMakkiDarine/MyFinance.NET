using Myfinance.domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfinance.Data.Configuration
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("MyCategories");
            HasKey(c => c.CategoryId);
            Property(c => c.Name).IsRequired().HasMaxLength(50);


        }

    }
}
