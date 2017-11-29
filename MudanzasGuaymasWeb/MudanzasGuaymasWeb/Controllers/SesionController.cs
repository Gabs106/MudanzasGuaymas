using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Net.Mail;
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
            if (Session["usuario"] != null)
            {
                Session["usuario"] = null;
                Session["nombre"] = null;
                Session["id"] = null;
                Session["email"] = null;
                TempData["msg"] = "<script>alert('Gracias por usar nuestros servicios');</script>";
            }
                return RedirectToAction("Index", "Home");
        }
        public ActionResult Registrarse()
        {
            if (Session["usuario"] == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Recuperar()
        {
            TempData["msg"] = "<script>alert('Ingrese su Email para enviarle como puede recuperar su cuenta muy sencillo');</script>";
            return View();
        }
        public void EnviarCorreo(string email)
        {
            MailMessage m;
            m = new MailMessage();
            m.To.Add(new MailAddress(email));
            m.From = new MailAddress("gabriel.106@hotmail.es");
            m.Subject = "Recuperar Contraseña";
            m.Body = "Url de recuperacion";
            m.IsBodyHtml = true;
            SmtpClient cliente = new SmtpClient("smtp.live.com",587);
            using (cliente)
            {
                cliente.Credentials = new System.Net.NetworkCredential("mudanzasGuaymas@gmail.com", "Chingayamaye");
                cliente.EnableSsl = true;
                cliente.Send(m);
            }
        }
        //Clientes
        private string BASE_URL = "http://mudanzasguaymasservices.azurewebsites.net/Services/Seguridad/SrvSesion.svc/";

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
                TempData["msg"] = "<script>alert('Bienvenido: " + Session["nombre"] + "');</script>";
                return RedirectToAction("Index", "Home");
            }
            else
            {

            }
            return RedirectToAction("Index", "Home");
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