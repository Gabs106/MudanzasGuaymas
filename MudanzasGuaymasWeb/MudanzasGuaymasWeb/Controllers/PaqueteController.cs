using MudanzasGuaymasWeb.SrvPaquete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MudanzasGuaymasWeb.Controllers
{
    public class PaqueteController : Controller
    {
        // GET: Paquete
        Clientes.ClientePaquete c = new Clientes.ClientePaquete();
        Clientes.ClienteServicio CS = new Clientes.ClienteServicio();
        public ActionResult Index(string id, string nombre)
        {
            ViewBag.paquete = c.verTodos(id);
            ViewBag.id = id;
            ViewBag.nombre = nombre;
            return View();
        }
        public ActionResult Post(string id)
        {
            ViewBag.paquete = c.encontrarUno(id);
            ViewBag.servicio = CS.verTodos();
            return View();
        }
        public ActionResult Create(string id)
        {
            if (Session["usuario"] != null)
            {

                if (Session["usuario"].Equals("Admin"))
                {
                    ViewBag.id_Servicio = id;
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
        public ActionResult Edit(string id)
        {
            if (Session["usuario"] != null)
            {

                if (Session["usuario"].Equals("Admin"))
                {
                    Paquete p = c.encontrarUno(id);
                    return View(p);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [HttpPost]
        public ActionResult subir(Paquete paquete, string id_Servicio, HttpPostedFileBase image)
        {
            if (Session["usuario"] != null)
            {

                if (Session["usuario"].Equals("Admin"))
                {
                    c.subir(paquete, id_Servicio, image);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public RedirectToRouteResult NoMostrar(string id)
        {
            Paquete s = c.encontrarUno(id);
            s.Mostrar = false;
            c.Editar(s);
            return RedirectToAction("Index", "Home");
        }
        public RedirectToRouteResult Mostrar(string id)
        {
            Paquete s =c.encontrarUno(id);
            s.Mostrar = true;
            c.Editar(s);
            return RedirectToAction("Index", "Home");
        }
        public RedirectToRouteResult Editar(Paquete paquete)
        {
            
            c.Editar(paquete);
            return RedirectToAction("Index", "Home");
        }
    }
}