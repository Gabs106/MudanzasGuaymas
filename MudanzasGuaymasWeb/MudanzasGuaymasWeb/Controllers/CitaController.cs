﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MudanzasGuaymasWeb.Controllers
{
    public class CitaController : Controller
    {
        // GET: Cita
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create(string id)
        {
            ViewBag.id_Paquete = id;
            return View();
        }
    }
}