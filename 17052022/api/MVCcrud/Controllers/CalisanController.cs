using MVCcrud.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace MVCcrud.Controllers
{
    public class CalisanController : Controller
    {
        // GET: Calisan
        public ActionResult Index()
        {
            IEnumerable<MVCcalisanModel> calList;
            HttpResponseMessage response =
                GlobalVariables.WepApiClient.GetAsync
                ("Calisanlar").Result;
            calList =
                response.Content.ReadAsAsync<IEnumerable<MVCcalisanModel>>().Result;
            return View(calList);
        }

        public ActionResult EKLE(int id = 0)
        {
            if (id == 0)
            {
                return View(new MVCcalisanModel());
            }
            else
            {
                HttpResponseMessage response =
                    GlobalVariables.WepApiClient.GetAsync("Calisanlars/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<MVCcalisanModel>().Result);
            }
        }

        [HttpPost]
        public ActionResult EEKLE(MVCcalisanModel calisan)
        {
            if (calisan.CalisanID==0)
            {
                HttpResponseMessage response =
                    GlobalVariables.WepApiClient.PostAsJsonAsync("Calisanlars", calisan).Result;
                TempData["SuccessMessage"] = "Başarılı şekilde kaydedildi.";

            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WepApiClient
                    .PutAsJsonAsync("Calisanlars/" + calisan.CalisanID, calisan).Result;
                TempData["SuccessMessage"] = "Update başarılı";
            }

            return RedirectToAction("Index");
        }

        public ActionResult Sil()
        {
            throw new System.NotImplementedException();
        }
    }
}