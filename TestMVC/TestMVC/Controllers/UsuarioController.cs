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


namespace TestMVC.Controllers
{
    public class UsuarioController : Controller
    {

        SrvUsuario.SrvUsuarioClient cliente = new SrvUsuario.SrvUsuarioClient();


        //Controladores
        public ActionResult Agregar()
        {
            return View();
        }
        public ActionResult Consultar()
        {
            ViewBag.usuario = verTodos();
            return View();
        }
        public ActionResult Details(string id)
        {
            ViewBag.usuario = encontrarUno(id);
            return View();
        }
        public ActionResult Edit(string id)
        {
            ViewBag.usuario = encontrarUno(id);
            return View();
        }
        public void Delete(string id)
        {
            SrvUsuario.Usuario usuario = encontrarUno(id);
            eliminar(usuario);
        }

/// <summary>
/// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// </summary>
        //Cliente crud para recibir parametros y enviar
        //instancia de cliente
        private string BASE_URL = "http://localhost:49727/Services/CRUD/SrvUsuario.svc/";
        
        //Consulta todos los usuarios dentro de la tabla
        public List<SrvUsuario.Usuario> verTodos()
        {
            var synClient = new WebClient();
            var content = synClient.DownloadString(BASE_URL+ "getAll");
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<List<SrvUsuario.Usuario>>(content);

        }

        //Agrega una fila a la tabla
        public void subir(SrvUsuario.Usuario usuario)
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
                webClient.UploadString(BASE_URL + "create", "POST", data);
            }
            catch (Exception)
            {

                throw;
            }
            RedirectToAction("Consultar","Usuario");
           
        }
        
        //Consulta un registro
        public SrvUsuario.Usuario encontrarUno(string id)
        {
            var synClient = new WebClient();
            string url = string.Format(BASE_URL + "get/{0}", id);
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<SrvUsuario.Usuario>(content);

        }

        //Agrega una fila a la tabla
        public void editar(SrvUsuario.Usuario usuario)
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
                webClient.UploadString(BASE_URL + "edit", "PUT", data);
            }
            catch (Exception)
            {

                throw;
            }
            RedirectToAction("Consultar", "Usuario");

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


    }
}