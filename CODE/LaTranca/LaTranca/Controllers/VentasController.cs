﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaTranca.Controllers
{
    public class VentasController : Controller
    {
        // GET: Servicios
        public ActionResult Index()
        {
            return View();
        }

        // GET: Servicios
        public ActionResult Transaccion()
        {
            return View();
        }

        // GET: Servicios
        public ActionResult Confirmacion()
        {
            return View();
        }
    }
}