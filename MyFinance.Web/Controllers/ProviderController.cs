using Myfinance.domain.Entities;
using MyFinance.ServiceSpec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFinance.Web.Controllers
{
    public class ProviderController : Controller
    {
        ProviderService p = new ProviderService();
        // GET: Provider
        public ActionResult Index()
        {
            return View();
        }
        // GET: Provider/getProviders
        public ActionResult getProviders()
        {
            return View(p.GetAll());
        }

        public ActionResult getProvidersByName()
        {
            String name = Request.QueryString["name"];
            return View(p.getByName(name));
        }

        // GET: Provider/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult CreateProvider()
        {
            Provider p = new Provider();
            return View(p);
        }
        // POST: Provider/CreateProvider
        [HttpPost]
        public ActionResult CreateProvider(Provider providerForm)
        {
            try
            {

                Provider pr = new Provider();
                ProviderService p = new ProviderService();

                pr.Email = providerForm.Email;
                pr.Username = providerForm.Username;
                pr.Password = providerForm.Password;
                pr.ConfirmPassword = providerForm.ConfirmPassword;
                p.Add(pr);
                p.Commit();

                return RedirectToAction("getProviders");
            }
            catch
            {
                return View();
            }
        }

        // GET: Provider/Edit/5
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                p.DeleteById(id);
                p.Commit();

                return RedirectToAction("getProviders");
            }
            catch
            {
                return View();
            }
           
        }
        public ActionResult Edit(int id)

        {
            
            return View(p.GetById(id));
        }
        // POST: Provider/Edit/5
        [HttpPost]
        public ActionResult Edit( Provider providers)
        {
           

                p.Update(providers);
                p.Commit();
                return RedirectToAction("getProviders");
           
        }

       

        // POST: Provider/Delete/5
      
    }
}
