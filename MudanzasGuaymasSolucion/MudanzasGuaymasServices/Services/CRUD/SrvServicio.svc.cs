
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
        MGEntidades DataBase = new MGEntidades();


        public void agregarImagen(string id, string imagenBase64)
        {
            Servicio s = ConsultarPorId(id);
            s.Imagen = s.Imagen+imagenBase64;
            DataBase.SaveChanges();
        }

        public Servicio ConsultarPorId(string id)
        {
            Servicio ser = new Servicio();
            int ID = int.Parse(id);
            var Query = from servicio in DataBase.Servicio
                        where servicio.Id == ID
                        select servicio;

            foreach (var result in Query)
            {
                ser = result;
            }

            return ser;
        }

        public List<Servicio> ConsultarPorNombre(string nombre)
        {
            List<Servicio> lista = new List<Servicio>();

            var Query = from servicio in DataBase.Servicio
                        where servicio.Nombre == nombre
                        select servicio;

            foreach (var result in Query)
            {
                lista.Add(result);
            }
            Console.WriteLine("Resultado " + lista.First());
            return lista;
        }

        public List<Servicio> ConsultarTodos()
        {
            List<Servicio> lista = new List<Servicio>();

            var Query = from servicio in DataBase.Servicio
                        select servicio;

            foreach (var result in Query)
            {
                lista.Add(result);
            }
            return lista;
        }

        public void Editar(Servicio servicio)
        {

            var ser = DataBase.Servicio.FirstOrDefault(x => x.Id == servicio.Id);

            ser = servicio;
            DataBase.SaveChanges();


        }

        public bool Eliminar(Servicio ser)
        {
            Servicio servicio = DataBase.Servicio.Find(ser.Id);
            DataBase.Servicio.Remove(servicio);
            DataBase.SaveChanges();
            return true;
        }

        public bool Insertar(Servicio servicio)
        {
            //Contruccion del objeto


            DataBase.Servicio.Add(servicio);
            DataBase.SaveChanges();
            return true;
        }
    }
}
