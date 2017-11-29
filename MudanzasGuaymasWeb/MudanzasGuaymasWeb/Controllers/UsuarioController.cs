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
        Clientes.ClienteSesion CS = new Clientes.ClienteSesion();
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
        public RedirectToRouteResult Delete(int id)
        {
            string ID = id.ToString();
            Usuario usuario = CU.encontrarUno(ID);
            eliminar(usuario);
            TempData["msg"] = "<script>alert('El usuario: " + usuario.Nombre+" "+usuario.Apellido + " ha sido Eliminado');</script>";
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Details(int id)
        {
            string ID = id.ToString();
            ViewBag.usuario = CU.encontrarUno(ID);
            return View();
        }
        public ActionResult Edit(int id)
        {
            if (Session["usuario"] != null)
            {

                if (Session["usuario"].Equals("Admin"))
                {
                    string ID = id.ToString();

                    return View(CU.encontrarUno(ID));
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


        public RedirectToRouteResult subir(Usuario usuario)
        {
            Usuario user = CS.TraerPorCorreo(usuario.Email);
            if (user.Email!=null)
            {
                TempData["msg"] = "<script>alert('El correo ya esta siendo utilizado');</script>";
            }
            else
            {
                Random r = new Random();
                int azar = r.Next(1000, 9999);
                usuario.Llave = azar.ToString();
                usuario.Tipo = "normal";
                CU.subir(usuario);
                TempData["msg"] = "<script>alert('Registrado con exito');</script>";
            }
            
            return RedirectToAction("Index", "Home");
        }


        //Agrega una fila a la tabla
        public void eliminar(SrvUsuario.Usuario usuario)
        {
            CU.eliminar(usuario);
            RedirectToAction("Consultar", "Usuario");

        }
        //Agrega una fila a la tabla
        public RedirectToRouteResult editar(SrvUsuario.Usuario usuario)
        {

            CU.editar(usuario);
            TempData["msg"] = "<script>alert('El usuario: " + usuario.Nombre + " " + usuario.Apellido + " ha sido Editado');</script>";
            return RedirectToAction("Index", "Home");
        }
    }
}