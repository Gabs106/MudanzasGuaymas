using MudanzasGuaymasServices.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MudanzasGuaymasServices.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISrvPaquete" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISrvPaquete
    {
        [OperationContract]
        bool Insertar(string descripcion, string nombre, bool mostrar, string imagen, double precio, int id_servicio);
        [OperationContract]
        void Editar(int id, string descripcion, string nombre, bool mostrar, string imagen, double precio, int id_servicio);
        [OperationContract]
        bool Eliminar(int id);
        [OperationContract]
        List<Paquete> ConsultarTodos();
        [OperationContract]
        List<Paquete> ConsultarPorNombre(string nombre);
        [OperationContract]
        Paquete ConsultarPorId(int id);
    }
}
