using MudanzasGuaymasServices.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MudanzasGuaymasServices.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISrvServicio" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISrvServicio
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "create", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool Insertar(Servicio servicio);
        [OperationContract]
        [WebInvoke(UriTemplate = "edit", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "PUT")]
        void Editar(Servicio servicio);
        [OperationContract]
        [WebInvoke(UriTemplate = "delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "DELETE")]
        bool Eliminar(Servicio servicio);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getAll", ResponseFormat = WebMessageFormat.Json)]
        List<Servicio> ConsultarTodos();
        [OperationContract]
        List<Servicio> ConsultarPorNombre(string nombre);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "get/{id}", ResponseFormat = WebMessageFormat.Json)]
        Servicio ConsultarPorId(string id);
    }
}
