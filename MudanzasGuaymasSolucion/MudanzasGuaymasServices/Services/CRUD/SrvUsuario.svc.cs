using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MudanzasGuaymasServices.Entity;

namespace MudanzasGuaymasServices.Services.CRUD
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SrvUsuario" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SrvUsuario.svc o SrvUsuario.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SrvUsuario : ISrvUsuario
    {
        MudanzasGuaymasDbEntities DataBase = new MudanzasGuaymasDbEntities();

        public Usuario ConsultarPorId(string id)
        {
            Usuario user = new Usuario();
            int ID = int.Parse(id);
            var Query = from usuario in DataBase.Usuario
                        where usuario.Id == ID
                        select usuario;

            foreach (var result in Query)
            {
                user = result;
            }

            return user;
        }

        public List<Usuario> ConsultarPorNombre(string nombre)
        {
            List<Usuario> lista = new List<Usuario>();

            var Query = from usuario in DataBase.Usuario
                        where usuario.Nombre == nombre
                        select usuario;

            foreach (var result in Query)
            {
                lista.Add(result);
            }
            Console.WriteLine("Resultado " + lista.First());
            return lista;
        }

        public List<Usuario> ConsultarTodos()
        {
            List<Usuario> lista = new List<Usuario>();

            var Query = from usuario in DataBase.Usuario
                        select usuario;

            foreach (var result in Query)
            {
                lista.Add(result);
            }
            Console.WriteLine("Resultado " + lista.First());
            return lista;
        }

        public void Editar(Usuario usuario)
        {

            var user = DataBase.Usuario.FirstOrDefault(x => x.Id == usuario.Id);

            user.Nombre = usuario.Nombre;
            user.Apellido = usuario.Apellido;
            user.Password = usuario.Password;
            user.Telefono = usuario.Telefono;
            user.Telefono = usuario.Tipo;
            user.Email = usuario.Email;
            DataBase.SaveChanges();


        }

        public bool Eliminar(Usuario user)
        {
            Usuario usuario = DataBase.Usuario.Find(user.Id);
            DataBase.Usuario.Remove(usuario);
            DataBase.SaveChanges();
            return true;
        }

        public bool Insertar(Usuario usuario)
        {
            //Contruccion del objeto


            DataBase.Usuario.Add(usuario);
            DataBase.SaveChanges();
            return true;
        }
    }
}
