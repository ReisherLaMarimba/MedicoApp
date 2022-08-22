using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MedicApp;

namespace MedicApp.Controllers
{
    public class CasoesController : Controller
    {
        private HospitalEntities db = new HospitalEntities();

        // GET: Casoes
        public ActionResult Index()
        {
            var casos = db.Casos.Include(c => c.Paciente).Include(c => c.Medico);
            return View(casos.ToList());
        }

        // GET: Casoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caso caso = db.Casos.Find(id);
            if (caso == null)
            {
                return HttpNotFound();
            }
            return View(caso);
        }

        // GET: Casoes/Create
        public ActionResult Create()
        {
            ViewBag.Paciente_Id = new SelectList(db.Pacientes, "Id", "Nombre");
            ViewBag.Doctor_Id = new SelectList(db.Medicos, "Id", "Nombre");
            return View();
        }

        // POST: Casoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Paciente_Id,Doctor_Id,Fecha_entrada,Fecha_salida")] Caso caso)
        {
            if (ModelState.IsValid)
            {
                db.Casos.Add(caso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Paciente_Id = new SelectList(db.Pacientes, "Id", "Nombre", caso.Paciente_Id);
            ViewBag.Doctor_Id = new SelectList(db.Medicos, "Id", "Nombre", caso.Doctor_Id);
            return View(caso);
        }

        // GET: Casoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caso caso = db.Casos.Find(id);
            if (caso == null)
            {
                return HttpNotFound();
            }
            ViewBag.Paciente_Id = new SelectList(db.Pacientes, "Id", "Nombre", caso.Paciente_Id);
            ViewBag.Doctor_Id = new SelectList(db.Medicos, "Id", "Nombre", caso.Doctor_Id);
            return View(caso);
        }

        // POST: Casoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Paciente_Id,Doctor_Id,Fecha_entrada,Fecha_salida")] Caso caso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(caso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Paciente_Id = new SelectList(db.Pacientes, "Id", "Nombre", caso.Paciente_Id);
            ViewBag.Doctor_Id = new SelectList(db.Medicos, "Id", "Nombre", caso.Doctor_Id);
            return View(caso);
        }

        // GET: Casoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caso caso = db.Casos.Find(id);
            if (caso == null)
            {
                return HttpNotFound();
            }
            return View(caso);
        }

        // POST: Casoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Caso caso = db.Casos.Find(id);
            db.Casos.Remove(caso);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
