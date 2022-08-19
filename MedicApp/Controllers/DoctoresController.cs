using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicApp.Controllers
{
    public class DoctoresController : Controller
    {
        // GET: Doctores
        public ActionResult ViewDoctores()
        {
            return View();
        }

        // GET: Doctores/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Doctores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Doctores/Create
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

        // GET: Doctores/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Doctores/Edit/5
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

        // GET: Doctores/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Doctores/Delete/5
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
