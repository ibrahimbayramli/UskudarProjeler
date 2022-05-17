using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using MVCCrud.Models;

namespace MVCCrud.Controllers
{
    public class CalisanController : Controller
    {
        // GET: Calisan
        public ActionResult Index()
        {
            IEnumerable<MVCCalisanModel> calList;

            HttpResponseMessage response = GlobalVariables.WepApiClient.GetAsync("Calisanlar").Result;

            calList = response.Content.ReadAsAsync<IEnumerable<MVCCalisanModel>>().Result;
            return View(calList);
        }
    }
}