using MudanzasGuaymasWeb.SrvPaquete;
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
    public class ClientePaquete
    {
        private string BASE_URL = "http://localhost:49727/Services/CRUD/SrvPaquete.svc/";

        public Paquete encontrarUno(string id)
        {
            var synClient = new WebClient();
            string url = string.Format(BASE_URL + "get/{0}", id);
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<Paquete>(content);

        }
        public List<Paquete> verTodos(string id)
        {
            var synClient = new WebClient();
            string url = string.Format(BASE_URL + "getAll/{0}", id);
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<List<Paquete>>(content);

        }

        public bool subir(Paquete paquete, string id_Servicio, HttpPostedFileBase image)
        {
            paquete.Id_Servicio = int.Parse(id_Servicio);
            //Agregar al usuario
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(SrvPaquete.Paquete));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, paquete);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString(BASE_URL + "create", "POST", data);
            return true;
        }
        public void Editar(Paquete s)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Paquete));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, s);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString(BASE_URL + "edit", "PUT", data);
        }
        public void eliminar(SrvPaquete.Paquete p)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(SrvPaquete.Paquete));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, p);
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


        }
    }
}