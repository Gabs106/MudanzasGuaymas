using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MudanzasGuaymasServices.Entity;

namespace MudanzasGuaymasServices.Services.Operaciones
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Factura" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Factura.svc o Factura.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Factura : IFactura
    {
        public Factura ConsultarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Factura> ConsultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<Factura> ConsultarTodos()
        {
            throw new NotImplementedException();
        }

        public List<Factura_Paquetes> DetalleFactura(int id_factura)
        {
            throw new NotImplementedException();
        }

        public void Editar(int id, string descripcion, string nombre, bool mostrar, string imagen)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void GenerarFactura()
        {
            throw new NotImplementedException();
        }
    }
}
