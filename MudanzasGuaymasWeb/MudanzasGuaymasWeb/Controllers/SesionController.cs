using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MudanzasGuaymasWeb.Controllers
{
    public class SesionController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        public RedirectToRouteResult Logout()
        {
            Session["usuario"] = null;
            return RedirectToAction("Index", "Home", new { mensaje = "OLA KE ASE" });
        }
        public ActionResult Registrarse()
        {

            return View();
        }

        public void Logueart()
        {

        }
        //Clientes
        private string BASE_URL = "http://localhost:49727/Services/Seguridad/SrvSesion.svc/";

        public bool Loguear(string email, string password)
        {
            var synClient = new WebClient();
            string url = string.Format(BASE_URL + "login/{0},{1}", email, password);
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<bool>(content);
        }
        public RedirectToRouteResult Sesion(string email, string password)
        {
            if (Loguear(email, password))
            {
                Session["usuario"] = TraerPorCorreo(email).Tipo;
                Session["nombre"] = TraerPorCorreo(email).Nombre;
                Session["id"] = TraerPorCorreo(email).Id;
                Session["email"] = TraerPorCorreo(email).Email;
                return RedirectToAction("Index", "Home", new { mensaje = "OLA KE ASE" });
            }
            else
            {

            }
            return RedirectToAction("Index", "Home", new { mensaje = "OLA KE ASE" });
        }
        public SrvUsuario.Usuario TraerPorCorreo(string email)
        {
            var synClient = new WebClient();
            string url = string.Format(BASE_URL + "porCorreo/{0}", email);
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<SrvUsuario.Usuario>(content);
        }
    }
}