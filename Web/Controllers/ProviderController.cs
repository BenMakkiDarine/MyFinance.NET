using MyFinance.ServiceSpec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Myfinance.domain.Entities;



namespace Web.Controllers
{
    public class ProviderController : Controller
    {
        ProviderService p = new ProviderService();
        // GET: Provider
        public ActionResult Index()
        {
            var model = p.GetAll();
            return View(model);
        }
      
    }
}