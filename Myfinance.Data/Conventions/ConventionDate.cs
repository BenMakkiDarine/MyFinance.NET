using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfinance.Data.Conventions
{
    public class ConventionDate :Convention
    {
        public ConventionDate()
        {
            this.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
        }
    }
}
