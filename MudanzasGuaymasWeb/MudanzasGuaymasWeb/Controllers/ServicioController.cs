using MudanzasGuaymasWeb.SrvServicio;
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
        // GET: Servicio
        public ActionResult Index()
        {
            ViewBag.servicio = verTodos();
            return View();
        }
        
        public ActionResult Create()
        {

            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Delete(int id)
        {
            string ID = id.ToString();
            Servicio servicio = encontrarUno(ID);
            return View();
        }
        public ActionResult Details(int id)
        {
            string ID = id.ToString();
            Servicio servicio = encontrarUno(ID);
            ViewBag.servicio = servicio;
            return View();
        }

        //Parte del cliente
        private string BASE_URL = "http://localhost:49727/Services/CRUD/SrvServicio.svc/";

        public List<Servicio> verTodos()
        {
            var synClient = new WebClient();
            var content = synClient.DownloadString(BASE_URL + "getAll");
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<List<Servicio>>(content);

        }
        public Servicio encontrarUno(string id)
        {
            var synClient = new WebClient();
            string url = string.Format(BASE_URL + "get/{0}", id);
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<Servicio>(content);

        }
        [HttpPost]
        public RedirectToRouteResult subir(Servicio servicio, HttpPostedFileBase image)
        {

            //Agregar al servicio
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Servicio));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, servicio);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString(BASE_URL + "create", "POST", data);

            if (image != null)
            {
                string nombre = image.ContentType;
                int length = image.ContentLength;
                byte[] buffer = new byte[length];
                image.InputStream.Read(buffer, 0, length);
                servicio.Imagen = buffer;
                SrvServicio.SrvServicioClient c = new SrvServicio.SrvServicioClient();
                c.agregarImagen(servicio);
            }
            
                return RedirectToAction("Index", "Home", new { mensaje = "OLA KE ASE" });
        }

        public string imagenServidor()
        {
            string ruta = null;
            return ruta;
        }

    }
}