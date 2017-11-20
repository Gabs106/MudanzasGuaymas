using MudanzasGuaymasWeb.SrvServicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MudanzasGuaymasWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.servicio = verTodos();
            return View();
        }

        private string BASE_URL = "http://localhost:49727/Services/CRUD/SrvServicio.svc/";

        public List<Servicio> verTodos()
        {
            var synClient = new WebClient();
            var content = synClient.DownloadString(BASE_URL + "getAll");
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<List<Servicio>>(content);

        }
    }
}