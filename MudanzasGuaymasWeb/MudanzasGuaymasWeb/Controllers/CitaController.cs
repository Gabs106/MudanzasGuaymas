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
        ClienteUsuario u = new ClienteUsuario();
        public ActionResult Index()
        {
            List<SrvPreCita.preCita> lista = c.verTodos();
            List<Paquete> listaPaquetes = new List<Paquete>();
            foreach (var result in lista)
            {
               listaPaquetes.Add(pa.encontrarUno(result.id_Paquete.ToString()));
            }
            foreach (var result in lista)
            {
                listaPaquetes.Add(pa.encontrarUno(result.id_Paquete.ToString()));
            }
            ViewBag.listaPaquetes = listaPaquetes;
            ViewBag.listaUsuarios = u.verTodos();
            return View(c.verTodos());
        }
        public ActionResult Create(string id)
        {
            ViewBag.id_Paquete = id;
            preCita p = new preCita();
            p.id_Paquete = int.Parse(id);
            p.Cantidad = 1;
            return View(p);
        }
        public ActionResult Details(string id)
        {

            return View(c.encontrarUno(id));
        }
        public RedirectToRouteResult Confirmar(string id)
        {
            preCita cita = c.encontrarUno(id);
            cita.Aceptado = true;
            TempData["msg"] = "<script>alert('Usted a confirmado la cita.');</script>";
            c.Editar(cita);
            return RedirectToAction("Index", "Cita");
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
            TempData["msg"] = "<script>alert('Gracias por usar nuestros servicios, Espere una respuesta pronta.');</script>";
            return RedirectToAction("Index", "Home");
        }
    }
}