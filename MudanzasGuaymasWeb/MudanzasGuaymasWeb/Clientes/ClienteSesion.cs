using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace MudanzasGuaymasWeb.Clientes
{
    public class ClienteSesion
    {
        public string encriptar(string password)
        {
            string BASE_URL = "http://localhost:49727/Services/Seguridad/SrvSesion.svc/";
            var synClient = new WebClient();
            string url = string.Format(BASE_URL + "encriptar/{0}", password);
            var content = synClient.DownloadString(url);
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<string>(content);
        }
    }
}