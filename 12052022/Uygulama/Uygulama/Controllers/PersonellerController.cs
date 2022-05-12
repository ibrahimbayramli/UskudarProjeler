using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Uygulama.Controllers
{
    public class PersonellerController : Controller
    {
        private HoldingEntities db = new HoldingEntities();

        // GET: Personeller
        public ActionResult Index()
        {
            return View();
        }
    }
}