using Myfinance.domain.Entities;
using ServicesPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Myfinance.Data.;

namespace ServiceSpec
{
    public class ServiceProvider : Service<Provider>, IProvider
    {
        private static IDatabaseFactory db = new DatabaseFactory();
        private static IUnitOfWork uow = new UnitOfWork(db);
        public ServiceProvider() : base(uow)
        {

        }
    }
}
