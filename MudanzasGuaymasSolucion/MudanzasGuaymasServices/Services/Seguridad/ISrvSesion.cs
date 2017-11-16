using MudanzasGuaymasServices.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MudanzasGuaymasServices.Services.Seguridad
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISrvSesion" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISrvSesion
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "encriptar/{password}", ResponseFormat = WebMessageFormat.Json)]
        string Encriptar(string password);
        [OperationContract]
        [WebInvoke(UriTemplate = "desencriptar/{password}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "GET")]
        string Desencriptar(string password);
        [OperationContract]
        [WebInvoke(UriTemplate = "logout", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool Logout();
        [OperationContract]
        [WebInvoke(UriTemplate = "login/{email},{password}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "GET")]
        bool Login(string email, string password);
        [WebInvoke(Method = "GET", UriTemplate = "porCorreo/{email}", ResponseFormat = WebMessageFormat.Json)]
        Usuario ConsultarPorEmail(string email);
    }
}
