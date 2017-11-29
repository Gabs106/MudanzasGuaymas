using MudanzasGuaymasWeb.SrvPreCita;
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
    public class ClienteCita
    {
        private string BASE_URL = "http://mudanzasguaymasservices.azurewebsites.net/Services/Operaciones/SrvPreCita.svc/";

        public preCita encontrarUno(string id)
        {
            var synClient = new WebClient();
            string url = string.Format(BASE_URL + "get/{0}", id);
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<preCita>(content);

        }
        public List<preCita> verTodos()
        {
            var synClient = new WebClient();
            string url = string.Format(BASE_URL + "getAll");
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<List<preCita>>(content);

        }


        public bool subir(preCita cita)
        {
            
            //Agregar al usuario
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(preCita));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, cita);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString(BASE_URL + "create", "POST", data);
            return true;
        }
        public void Editar(preCita s)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(preCita));
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