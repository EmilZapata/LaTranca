using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaTranca.Areas.MuduloAdministracion.Controllers
{
    public class GestorEventosController : Controller
    {
        // GET: MuduloAdministracion/GestorEventos
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult SaveUpdateEvento()
        {
            return View();
        }
    }
}