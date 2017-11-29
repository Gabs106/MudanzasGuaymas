using MudanzasGuaymasWeb.SrvServicio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace MudanzasGuaymasWeb.Clientes
{
    public class ClienteServicio
    {
        private string BASE_URL = "http://mudanzasguaymasservices.azurewebsites.net/Services/CRUD/SrvServicio.svc/";

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
        
        public bool subir(Servicio servicio, HttpPostedFileBase image)
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

            return true;
        }
       
        public string imagenServidor(string id, HttpPostedFileBase image)
        {
            string imagenBase64 = null;
            int length = image.ContentLength;
            byte[] buffer = new byte[length];
            image.InputStream.Read(buffer, 0, length);
            imagenBase64 = Convert.ToBase64String(buffer);
            var synClient = new WebClient();
            for (int i = 0; i < imagenBase64.Length;)
            {
                int principio = i;
                i += 50;
                int final = i;
                string resultado = imagenBase64.Substring(principio, final);

                string url = string.Format(BASE_URL + "imagen/{0},{1}", id, resultado);
                var content = synClient.DownloadString(url);
            }
            return imagenBase64;
        }

        public void Editar(Servicio s)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Servicio));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, s);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString(BASE_URL + "edit", "PUT", data);
        }
    }
}