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
        // GET: Usuario
        public ActionResult Index()
        {
            ViewBag.usuario = verTodos();
            return View();
        }
        public ActionResult Agregar()
        {

            return View();
        }
        public bool Delete(int id)
        {
            string ID = id.ToString();
            Usuario usuario = encontrarUno(ID);
            eliminar(usuario);
            return true;
        }
        public ActionResult Details(int id)
        {
            string ID = id.ToString();
            ViewBag.usuario = encontrarUno(ID);
            return View();
        }
        public ActionResult Edit(int id)
        {
            string ID = id.ToString();
            ViewBag.usuario = encontrarUno(ID);
            return View();
        }
        private string BASE_URL = "http://localhost:49727/Services/CRUD/SrvUsuario.svc/";

        //Consulta todos los usuarios dentro de la tabla
        public List<Usuario> verTodos()
        {
            var synClient = new WebClient();
            var content = synClient.DownloadString(BASE_URL + "getAll");
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<List<Usuario>>(content);
        }
        public string encriptar(string password)
        {
            BASE_URL = "http://localhost:49727/Services/Seguridad/SrvSesion.svc/";
            var synClient = new WebClient();
            string url = string.Format(BASE_URL + "encriptar/{0},", password);
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<string>(content);
        }
        public bool subir(Usuario usuario)
        {
            //Encriptar password
            string password = encriptar(usuario.Password);
            usuario.Password = password;
            //Agregar al usuario
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(SrvUsuario.Usuario));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, usuario);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            BASE_URL = "http://localhost:49727/Services/CRUD/SrvUsuario.svc/";
            webClient.UploadString(BASE_URL + "create", "POST", data);


            return true;
        }

        public SrvUsuario.Usuario encontrarUno(string id)
        {
            var synClient = new WebClient();
            string url = string.Format(BASE_URL + "get/{0}", id);
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<SrvUsuario.Usuario>(content);

        }
        //Agrega una fila a la tabla
        public void eliminar(SrvUsuario.Usuario usuario)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(SrvUsuario.Usuario));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, usuario);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(BASE_URL + "delete", "DELETE", data);
            }
            catch (Exception)
            {

                throw;
            }
            RedirectToAction("Consultar", "Usuario");

        }
        //Agrega una fila a la tabla
        public void editar(SrvUsuario.Usuario usuario)
        {

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(SrvUsuario.Usuario));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, usuario);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString(BASE_URL + "edit", "PUT", data);



        }
    }
}