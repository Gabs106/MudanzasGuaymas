using MudanzasGuaymasServices.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MudanzasGuaymasServices.Services.Operaciones
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISrvPreCita" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISrvPreCita
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "create", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool Insertar(preCita preCita);
        [OperationContract]
        [WebInvoke(UriTemplate = "edit", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "PUT")]
        void Editar(preCita preCita);
        [OperationContract]
        [WebInvoke(UriTemplate = "delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "DELETE")]
        bool Eliminar(preCita preCita);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getAll", ResponseFormat = WebMessageFormat.Json)]
        List<preCita> ConsultarTodos();
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getUsuario/{id}", ResponseFormat = WebMessageFormat.Json)]
        List<preCita> ConsultarPorUsuario(string id);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "get/{id}", ResponseFormat = WebMessageFormat.Json)]
        preCita ConsultarPorId(string id);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getPendientes", ResponseFormat = WebMessageFormat.Json)]
        List<preCita> ConsultarPendientes();
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getAceptadas", ResponseFormat = WebMessageFormat.Json)]
        List<preCita> ConsultarAceptadas();
    }
}
