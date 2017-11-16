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
        //Consulta un paquete por id
        public Paquete ConsultarPorId(string id)
        {
            Paquete pack = new Paquete();
            int ID = int.Parse(id);
            var Query = from paquete in DataBase.Paquete
                        where paquete.Id == ID
                        select paquete;

            foreach (var result in Query)
            {
                pack = result;
            }

            return pack;
        }
        //Consulta una lista de paquetes por nombre
        public List<Paquete> ConsultarPorNombre(string nombre)
        {
            List<Paquete> lista = new List<Paquete>();

            var Query = from servicio in DataBase.Paquete
                        where servicio.Nombre == nombre
                        select servicio;

            foreach (var result in Query)
            {
                lista.Add(result);
            }
            Console.WriteLine("Resultado " + lista.First());
            return lista;
        }
        //Trae todos los paquetes existentes
        public List<Paquete> ConsultarTodos()
        {
            List<Paquete> lista = new List<Paquete>();

            var Query = from servicio in DataBase.Paquete
                        select servicio;

            foreach (var result in Query)
            {
                lista.Add(result);
            }
            Console.WriteLine("Resultado " + lista.First());
            return lista;
        }

        public void Editar(Paquete paquete)
        {

            var pack = DataBase.Paquete.FirstOrDefault(x => x.Id == paquete.Id);

            pack = paquete;
            DataBase.SaveChanges();


        }

        public bool Eliminar(Paquete pack)
        {
            Paquete paquete = DataBase.Paquete.Find(pack.Id);
            DataBase.Paquete.Remove(paquete);
            DataBase.SaveChanges();
            return true;
        }

        public bool Insertar(Paquete paquete)
        {
            //Contruccion del objeto


            DataBase.Paquete.Add(paquete);
            DataBase.SaveChanges();
            return true;
        }
    }
}
