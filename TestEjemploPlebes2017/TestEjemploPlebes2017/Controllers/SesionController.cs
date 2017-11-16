using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace TestEjemploPlebes2017.Controllers
{
    public class SesionController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        public bool Logout()
        {
            Session["usuario"] = null;
            return true;
        }
        public bool Registrarse()
        {
            return true;
        }

        public void Logueart()
        {
           
        }
        //Clientes
        private string BASE_URL= "http://localhost:49727/Services/Seguridad/SrvSesion.svc/";
        public bool Loguear(string email, string password)
        {
            var synClient = new WebClient();
            string url = string.Format(BASE_URL + "login/{0},{1}",email,password);
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<bool>(content);
        }
        public void Sesion(string email, string password)
        {
            if (Loguear(email, password))
            {
                Session["usuario"] = TraerPorCorreo(email);
            }
            else
            {

            }
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