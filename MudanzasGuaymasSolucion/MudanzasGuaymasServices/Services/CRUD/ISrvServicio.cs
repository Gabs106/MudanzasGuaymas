using MudanzasGuaymasServices.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MudanzasGuaymasServices.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISrvServicio" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISrvServicio
    {
        [OperationContract]
        bool Insertar(string descripcion, string nombre, bool mostrar, string imagen);
        [OperationContract]
        void Editar(int id, string descripcion, string nombre, bool mostrar, string imagen);
        [OperationContract]
        bool Eliminar(int id);
        [OperationContract]
        List<Servicio> ConsultarTodos();
        [OperationContract]
        List<Servicio> ConsultarPorNombre(string nombre);
        [OperationContract]
        Servicio ConsultarPorId(int id);
    }
}
