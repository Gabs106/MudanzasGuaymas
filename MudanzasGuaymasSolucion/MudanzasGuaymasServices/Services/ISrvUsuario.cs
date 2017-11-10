using MudanzasGuaymasServices.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MudanzasGuaymasServices.Services
{
 
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISrvUsuario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISrvUsuario
    {
        [OperationContract]
        bool Insertar(Usuario usuario);
        [OperationContract]
        bool Editar(Usuario usuario);
        [OperationContract]
        bool Eliminar(int id);
        [OperationContract]
        List<Usuario> ConsultarTodos();
        [OperationContract]
        List<Usuario> ConsultarPorNombre(string nombre);
        [OperationContract]
        Usuario ConsultarPorId();
    }
}
