using MudanzasGuaymasServices.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MudanzasGuaymasServices.Services.Operaciones
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IFactura" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IFactura
    {
        [OperationContract]
        void GenerarFactura();
        [OperationContract]
        void Editar(int id, string descripcion, string nombre, bool mostrar, string imagen);
        [OperationContract]
        bool Eliminar(int id);
        [OperationContract]
        List<Factura> ConsultarTodos();
        [OperationContract]
        List<Factura> ConsultarPorNombre(string nombre);
        [OperationContract]
        Factura ConsultarPorId(int id);
        [OperationContract]
        List<Factura_Paquetes> DetalleFactura(int id_factura);


    }
}
