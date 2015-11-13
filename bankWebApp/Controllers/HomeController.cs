using bankWebApp.Models;
using bankWebApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bankWebApp.Controllers
{
    public class HomeController : Controller
    {
        IClientRepository repository = new ClientRepository();

        public ActionResult Index()
        {
            
            return View(repository.getAll());
        }

        public ActionResult AddPanel()
        {
            return View();
        }
   
        public ActionResult delete(int? id)
        {
            repository.delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult edit(int? id)
        {
            if (id != null)
            {
                var clientToEdit = repository.getById(id);
                if (clientToEdit != null)
                {
                    return View(clientToEdit);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AddPanel(clientTable client)
        {
            if (ModelState.IsValid)
            {
                repository.insert(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public ActionResult edit(clientTable clientData)
        {
            if (ModelState.IsValid)
            {
                repository.edit(clientData);
                return RedirectToAction("Index");
            }
            return View();
        }

        public JsonResult CheckPassportId(string passportId, int? clientsId)
        
        {
            bool answer;
            var result = repository.getByPassportId(passportId);
            answer = (result == null) ? true : false;
            if (result != null)
            {
                if (result.clientsId == clientsId)
                {
                    answer = true;
                }
            }
            return Json(answer, JsonRequestBehavior.AllowGet);
        }
    }
}
