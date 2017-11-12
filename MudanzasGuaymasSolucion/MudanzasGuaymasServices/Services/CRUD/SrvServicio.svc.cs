using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MudanzasGuaymasServices.Entity;

namespace MudanzasGuaymasServices.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SrvServicio" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SrvServicio.svc o SrvServicio.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SrvServicio : ISrvServicio
    {
        MudanzasGuaymasDbEntities DataBase = new MudanzasGuaymasDbEntities();
        public Servicio ConsultarPorId(int id)
        {
            Servicio objeto = new Servicio();
            objeto = DataBase.Servicio.Find(id);
            return objeto;
        }

        public List<Servicio> ConsultarPorNombre(string nombre)
        {
            List<Servicio> lista = new List<Servicio>();

            var Query = from objeto in DataBase.Servicio
                        where objeto.Nombre == nombre
                        select objeto;

            foreach (var result in Query)
            {
                lista.Add(result);
            }
            
            return lista;
        }

        public List<Servicio> ConsultarTodos()
        {
            List<Servicio> lista = new List<Servicio>();

            var Query = from objeto in DataBase.Servicio
                        select objeto;

            foreach (var result in Query)
            {
                lista.Add(result);
            }
           
            return lista;
        }

        public void Editar(int id, string descripcion, string nombre, bool mostrar, string imagen)
        {
            var objeto = DataBase.Servicio.FirstOrDefault(x => x.Id == id);

            objeto.Nombre = nombre;
            objeto.Descripcion = descripcion;
            DataBase.SaveChanges();
        }

        public bool Eliminar(int id)
        {
            Servicio objeto = DataBase.Servicio.Find(id);
            DataBase.Servicio.Remove(objeto);
            DataBase.SaveChanges();
            return true;
        }

        public bool Insertar(string descripcion, string nombre, bool mostrar, string imagen)
        {
            //Contruccion del objeto
            Servicio objeto = new Servicio();
            objeto.Nombre = nombre;
            
            DataBase.Servicio.Add(objeto);
            DataBase.SaveChanges();
            return true;
        }
    }
}
