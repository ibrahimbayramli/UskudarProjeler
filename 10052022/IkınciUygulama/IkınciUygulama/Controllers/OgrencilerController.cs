using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IkınciUygulama.Controllers
{
    public class OgrencilerController : Controller
    {
        // GET: Ogrenciler
        public ActionResult IlkOkul()
        {
            return View();
        }
        public ActionResult OrtaOkul()
        {
            return View();
        }
        public ActionResult Lise()
        {
            return View();
        }
    }
}