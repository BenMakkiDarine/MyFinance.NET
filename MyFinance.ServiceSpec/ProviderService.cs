using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myfinance.domain.Entities;

using MyFinance.ServicesPattern;
using Data.Infrastructure;

namespace MyFinance.ServiceSpec
{
   public class ProviderService: Service<Provider>, IProvider
    {
        private static IDatabaseFactory db = new DatabaseFactory();
        private static IUnitOfWork uow = new UnitOfWork(db);
        public ProviderService() :base(uow)
        {

        }

        public List<Provider> getByName(String name)
        {
            // return uow.GetRepository<Provider>().GetAll().Where(p=>p.Username.Equals(name)).ToList();
            List<Provider> providers = uow.GetRepository<Provider>().GetAll().ToList();
            //link
            var req = from p in providers
                      where p.Username == name
                      select p;
            return req.ToList();
        }
        public void DeleteById(int id)
        {
            uow.GetRepository<Provider>().Delete(p=>p.Id==id);
        }
        public void UpdateById(int id )
        {
            Provider ProviderNouveau = new Provider();
            ProviderNouveau = uow.GetRepository<Provider>().GetById(id);
            uow.GetRepository<Provider>().Update(ProviderNouveau);
        }
    }
}
