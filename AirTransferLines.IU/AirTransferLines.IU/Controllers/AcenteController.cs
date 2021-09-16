
using AirTransferLines.Dall;
using AirTransferLines.IU.Models;
using AirTransferLines.Repos.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirTransferLines.IU.Controllers
{
    public class AcenteController : Controller
    {
        // GET: Acente
        AcenteRep acenteRep = new AcenteRep();
        public ActionResult List()
        {
            return View(acenteRep.AcenteListe());
        }
        [HttpGet]
        public ActionResult Add()
        {
            AcenteModel model = new AcenteModel();
            model.ace = new Acente();
            model.BtnClass ="btn btn-primary";
            model.Header ="Yeni Kayıt";
            model.BtnText ="Ekle";
            return View("Crud",model);
        }
        [HttpPost]
        public ActionResult Add(AcenteModel model)
        {
            acenteRep.Add(model.ace);
            acenteRep.Commit();
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            AcenteModel model = new AcenteModel();
            model.ace = acenteRep.Find(id);
            model.BtnClass = "btn btn-succes";
            model.Header = "Güncelleme İşlemi";
            model.BtnText = "Güncelle";
            return View("Crud", model);
        }
        [HttpPost]
        public ActionResult Update(AcenteModel model)
        {
            acenteRep.Update(model.ace);
            acenteRep.Commit();
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            AcenteModel model = new AcenteModel();
            model.ace = acenteRep.Find(id);
            model.BtnClass = "btn btn-danger";
            model.Header = "Silme İşlemi";
            model.BtnText = "Sil";
            return View("Crud", model);
        }
        [HttpPost]
        public ActionResult Delete(AcenteModel model)
        {
            acenteRep.Delete(model.ace);
            acenteRep.Commit();
            return RedirectToAction("List");
        }
    }
}