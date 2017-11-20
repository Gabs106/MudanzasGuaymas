using MudanzasGuaymasServices.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MudanzasGuaymasServices.Services.CRUD
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISrvUsuario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISrvUsuario
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "create", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool Insertar(Usuario usuario);
        [OperationContract]
        [WebInvoke(UriTemplate = "edit", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "PUT")]
        void Editar(Usuario usuario);
        [OperationContract]
        [WebInvoke(UriTemplate = "delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "DELETE")]
        bool Eliminar(Usuario usuario);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getAll", ResponseFormat = WebMessageFormat.Json)]
        List<Usuario> ConsultarTodos();
        [OperationContract]
        List<Usuario> ConsultarPorNombre(string nombre);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "get/{id}", ResponseFormat = WebMessageFormat.Json)]
        Usuario ConsultarPorId(string id);
    }
}
