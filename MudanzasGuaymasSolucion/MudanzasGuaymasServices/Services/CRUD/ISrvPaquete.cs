using MudanzasGuaymasServices.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services;

namespace MudanzasGuaymasServices.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISrvPaquete" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISrvPaquete
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "create", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool Insertar(Paquete paquete);
        [OperationContract]
        [WebInvoke(UriTemplate = "edit", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "PUT")]
        void Editar(Paquete paquete);
        [OperationContract]
        [WebInvoke(UriTemplate = "delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "DELETE")]
        bool Eliminar(Paquete paquete);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getAll", ResponseFormat = WebMessageFormat.Json)]
        List<Paquete> ConsultarTodos();
        [OperationContract]
        List<Paquete> ConsultarPorNombre(string nombre);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "get/{id}", ResponseFormat = WebMessageFormat.Json)]
        Paquete ConsultarPorId(string id);
    }
}
