using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrakSister6_22SA11A116.Controllers
{
    public class DataController : Controller
    {
        private DataRepository rep = new DataRepository();

        // GET: Data
        public ActionResult Index()
        {
            var dataList = rep.GetAllData();
            return View(dataList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DataModel data)
        {
            rep.TambahData(data);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var data = rep.GetAllData().FirstOrDefault(d => d.IdBuku == id);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(DataModel data)
        {
            rep.UbahData(data);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            rep.HapusData(id);
            return RedirectToAction("Index");
        }
    }
}