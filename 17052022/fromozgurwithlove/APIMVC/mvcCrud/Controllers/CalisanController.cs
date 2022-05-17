using mvcCrud.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;

namespace mvcCrud.Controllers
{
    public class CalisanController : Controller
    {
        // GET: Calisan
        public ActionResult Index()
        {

            IEnumerable<mvcCalisanModel> calList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Calisanlars").Result;

            calList = response.Content.ReadAsAsync<IEnumerable<mvcCalisanModel>>().Result;

            return View(calList);
        }
    }
}