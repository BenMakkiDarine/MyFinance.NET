using Myfinance.domain.ComplexType;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfinance.Data.Configuration
{
    public class AdressConfiguration : EntityTypeConfiguration<Address>
    {

        public AdressConfiguration()
        {
            Property(a => a.City).IsRequired();
            Property(a => a.StreetAddress).HasMaxLength(50).IsOptional();
        }
    }
}
