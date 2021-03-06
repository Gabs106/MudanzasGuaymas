﻿using MudanzasGuaymasWeb.SrvServicio;
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
using System.Web.UI.WebControls;

namespace MudanzasGuaymasWeb.Controllers
{
    public class ServicioController : Controller
    {
        Clientes.ClienteServicio CS = new Clientes.ClienteServicio();
        // GET: Servicio
        public ActionResult Index()
        {
            if (Session["usuario"] != null)
            {

                if (Session["usuario"].Equals("Admin"))
                {
                    ViewBag.servicio = CS.verTodos();
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
        
        public ActionResult Create()
        {
            if (Session["usuario"] != null)
            {

                if (Session["usuario"].Equals("Admin"))
                {
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
                    ViewBag.Id = id;
                    Servicio  servicio = CS.encontrarUno(id);
                    return View(servicio);
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
        public ActionResult Delete(int id)
        {
            if (Session["usuario"] !=null)
            {
                if (Session["usuario"].Equals("Admin"))
                {
                    string ID = id.ToString();
                    Servicio servicio = CS.encontrarUno(ID);
                    TempData["msg"] = "<script>alert('Se ha eliminado con exito');</script>";
                }
            }
            return RedirectToAction("Home", "Index");
        }
        public ActionResult Details(int id)
        {
            string ID = id.ToString();
            Servicio servicio = CS.encontrarUno(ID);
            ViewBag.servicio = servicio;
            return View();
        }

        //Parte del cliente

        [HttpPost]
        public RedirectToRouteResult subir(Servicio servicio, HttpPostedFileBase image)
        {
            if (Session["usuario"] != null)
            {

                if (Session["usuario"].Equals("Admin"))
                {
                    //Agregar al servicio
                    servicio.Mostrar = true;
                    CS.subir(servicio, image);
                    TempData["msg"] = "<script>alert('El servicio fue agregado correctamente');</script>";
                }

            }       
            return RedirectToAction("Index", "Home");
        }

        public RedirectToRouteResult NoMostrar(string id)
        {
            Servicio s = CS.encontrarUno(id);
            s.Mostrar = false;
            CS.Editar(s);
            TempData["msg"] = "<script>alert('Usted ha cambiado a no mostrar el servicio: " + s.Nombre + "');</script>";
            return RedirectToAction("Index", "Home");
        }
        public RedirectToRouteResult Mostrar(string id)
        {
            Servicio s = CS.encontrarUno(id);
            s.Mostrar = true;
            CS.Editar(s);
            TempData["msg"] = "<script>alert('Usted ha cambiado a mostrar el servicio: " + s.Nombre + "');</script>";
            return RedirectToAction("Index", "Home");
        }
        public RedirectToRouteResult Editar(string id, Servicio servicio)
        {
            servicio.Id = int.Parse(id);
            CS.Editar(servicio);
            TempData["msg"] = "<script>alert('Servicio editado con exito');</script>";
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public string imagenServidor(string id, HttpPostedFileBase image)
        { 
            //CS.imagenServidor(id,image);
            return "";
        }
        public ActionResult Prueba()
        {
            return null;
        }

    }
}