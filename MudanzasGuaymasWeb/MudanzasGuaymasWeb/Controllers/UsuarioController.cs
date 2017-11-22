using MudanzasGuaymasWeb.SrvUsuario;
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
    public class UsuarioController : Controller
    {
        Clientes.ClienteUsuario CU = new Clientes.ClienteUsuario();
        // GET: Usuario
        public ActionResult Index()
        {
            ViewBag.usuario = CU.verTodos();
            return View();
        }
        public ActionResult Agregar()
        {

            return View();
        }
        public bool Delete(int id)
        {
            string ID = id.ToString();
            Usuario usuario = CU.encontrarUno(ID);
            eliminar(usuario);
            return true;
        }
        public ActionResult Details(int id)
        {
            string ID = id.ToString();
            ViewBag.usuario = CU.encontrarUno(ID);
            return View();
        }
        public ActionResult Edit(int id)
        {
            string ID = id.ToString();
            ViewBag.usuario = CU.encontrarUno(ID);
            return View();
        }


        public bool subir(Usuario usuario)
        {
            Random r = new Random();
            int azar = r.Next(1000, 9999);
            usuario.Llave = azar.ToString();
            CU.subir(usuario);
            return true;
        }


        //Agrega una fila a la tabla
        public void eliminar(SrvUsuario.Usuario usuario)
        {
            CU.eliminar(usuario);
            RedirectToAction("Consultar", "Usuario");

        }
        //Agrega una fila a la tabla
        public void editar(SrvUsuario.Usuario usuario)
        {

            CU.editar(usuario);


        }
    }
}