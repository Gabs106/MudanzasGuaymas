using MudanzasGuaymasServices.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MudanzasGuaymasServices.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SrvPaquete" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SrvPaquete.svc o SrvPaquete.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SrvPaquete : ISrvPaquete
    {
        MudanzasGuaymasDbEntities DataBase = new MudanzasGuaymasDbEntities();
        public Paquete ConsultarPorId(int id)
        {
            Paquete objeto = new Paquete();
            objeto = DataBase.Paquete.Find(id);
            return objeto;
        }

        public List<Paquete> ConsultarPorNombre(string nombre)
        {
            List<Paquete> lista = new List<Paquete>();

            var Query = from objeto in DataBase.Paquete
                        where objeto.Nombre == nombre
                        select objeto;

            foreach (var result in Query)
            {
                lista.Add(result);
            }

            return lista;
        }

        public List<Paquete> ConsultarTodos()
        {
            List<Paquete> lista = new List<Paquete>();

            var Query = from objeto in DataBase.Paquete
                        select objeto;

            foreach (var result in Query)
            {
                lista.Add(result);
            }

            return lista;
        }

        public void Editar(int id, string descripcion, string nombre, bool mostrar, string imagen, double precio, int id_servicio)
        {
            var objeto = DataBase.Paquete.FirstOrDefault(x => x.Id == id);

            objeto.Nombre = nombre;
            objeto.Descripcion = descripcion;
            DataBase.SaveChanges();
        }

        public bool Eliminar(int id)
        {
            Paquete objeto = DataBase.Paquete.Find(id);
            DataBase.Paquete.Remove(objeto);
            DataBase.SaveChanges();
            return true;
        }

        public bool Insertar(string descripcion, string nombre, bool mostrar, string imagen, double precio, int id_servicio)
        {
            //Contruccion del objeto
            Paquete objeto = new Paquete();
            objeto.Nombre = nombre;

            DataBase.Paquete.Add(objeto);
            DataBase.SaveChanges();
            return true;
        }
    }
}
