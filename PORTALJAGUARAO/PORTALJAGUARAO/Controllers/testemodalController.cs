using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PORTALJAGUARAO.Controllers
{
    public class testemodalController : Controller
    {
        // GET: testemodal
        public ActionResult Index()
        {
            return View();
        }

        // GET: testemodal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: testemodal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: testemodal/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: testemodal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: testemodal/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: testemodal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: testemodal/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
