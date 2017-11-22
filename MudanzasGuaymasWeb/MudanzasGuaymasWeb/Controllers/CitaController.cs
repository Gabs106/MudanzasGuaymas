using MudanzasGuaymasWeb.Clientes;
using MudanzasGuaymasWeb.SrvPaquete;
using MudanzasGuaymasWeb.SrvPreCita;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MudanzasGuaymasWeb.Controllers
{
    public class CitaController : Controller
    {
        // GET: Cita
        ClienteCita c = new ClienteCita();
        ClientePaquete pa = new ClientePaquete();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create(string id)
        {
            ViewBag.id_Paquete = id;
            preCita p = new preCita();
            p.id_Paquete = int.Parse(id);
            p.Cantidad = 1;
            return View(p);
        }
        public RedirectToRouteResult subir(preCita cita)
        {
            Paquete p = new Paquete();
            p = pa.encontrarUno(cita.id_Paquete.ToString());
            cita.Aceptado = false;
            cita.id_usuario = int.Parse(Session["id"].ToString());
            cita.Total = cita.Cantidad * p.Precio;
                    //Agregar al servicio
            c.subir(cita);

            return RedirectToAction("Index", "Home");
        }
    }
}