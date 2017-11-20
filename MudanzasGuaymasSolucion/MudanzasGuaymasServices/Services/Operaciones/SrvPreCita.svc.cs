using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MudanzasGuaymasServices.Entity;

namespace MudanzasGuaymasServices.Services.Operaciones
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SrvPreCita" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SrvPreCita.svc o SrvPreCita.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SrvPreCita : ISrvPreCita
    {
        MGEntidades DataBase = new MGEntidades();

        public List<preCita> ConsultarAceptadas()
        {
            DateTime localDate = DateTime.Now;
            List<preCita> lista = new List<preCita>();
            var Query = from p in DataBase.preCita
                        where p.Aceptado == true && p.Fecha < localDate
                        orderby p.Fecha descending
                        select p;

            foreach (var result in Query)
            {
                lista.Add(result);
            }

            return lista;
        }

        public List<preCita> ConsultarPendientes()
        {
            List<preCita> lista = new List<preCita>();
            var Query = from p in DataBase.preCita
                        where p.Aceptado == false
                        select p;

            foreach (var result in Query)
            {
                lista.Add(result);
            }

            return lista;
        }

        public preCita ConsultarPorId(string id)
        {
            preCita pre = new preCita();
            int ID = int.Parse(id);
            var Query = from preCita in DataBase.preCita
                        where preCita.Id == ID
                        select preCita;

            foreach (var result in Query)
            {
                pre = result;
            }

            return pre;
        }

        public List<preCita> ConsultarPorUsuario(string id)
        {
            List<preCita> lista = new List<preCita>();
            int ID = int.Parse(id);
            var Query = from p in DataBase.preCita
                        where p.id_usuario == ID
                        select p;

            foreach (var result in Query)
            {
                lista.Add(result);
            }

            return lista;
        }

        public List<preCita> ConsultarTodos()
        {
            List<preCita> lista = new List<preCita>();
            var Query = from p in DataBase.preCita
                        select p;
            foreach (var result in Query)
            {

                lista.Add(result);
            }

            return lista;
        }

        public void Editar(preCita preCita)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(preCita preCita)
        {
            preCita p = DataBase.preCita.Find(preCita.Id);
            DataBase.preCita.Remove(p);
            DataBase.SaveChanges();
            return true;
        }

        public bool Insertar(preCita preCita)
        {
            DataBase.preCita.Add(preCita);
            DataBase.SaveChanges();
            return true;
        }
    }
}
