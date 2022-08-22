using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicApp.Controllers
{
    public class HomeController : Controller
    {
      private HospitalEntities db = new HospitalEntities();
        public ActionResult Index()
        {
           ViewBag.cuenta = db.Medicos.Count();
        ViewBag.pacientes = db.Pacientes.Count();

        var cuentacasos = db.Casos.Where(x => x.Medico.Caso_id == x.Id).ToList();
        ViewBag.caso = cuentacasos.Count;


            return View();
        }

       

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}