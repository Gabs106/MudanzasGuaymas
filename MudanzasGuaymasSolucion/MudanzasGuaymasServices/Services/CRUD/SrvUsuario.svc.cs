using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MudanzasGuaymasServices.Entity;
using System.Data.Entity;

namespace MudanzasGuaymasServices.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SrvUsuario" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SrvUsuario.svc o SrvUsuario.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SrvUsuario : ISrvUsuario
    {
        MudanzasGuaymasDbEntities DataBase = new MudanzasGuaymasDbEntities();

        public Usuario ConsultarPorId(int id)
        {
            Usuario usuario = new Usuario();
            usuario = DataBase.Usuario.Find(id);
            return usuario;
        }

        public List<Usuario> ConsultarPorNombre(string nombre)
        {
            List<Usuario> lista = new List<Usuario>();

            var Query = from usuario in DataBase.Usuario where usuario.Nombre == nombre
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
            Console.WriteLine("Resultado "+ lista.First());
            return lista;
        }

        public void Editar(int id, string nombre, string apellido, string email, string password, string telefono, string tipo)
        {

            var usuario = DataBase.Usuario.FirstOrDefault(x=> x.Id == id);
            
            usuario.Nombre = nombre;
            usuario.Apellido = apellido;
            DataBase.SaveChanges();
            
            
        }

        public bool Eliminar(int id)
        {
            Usuario usuario = DataBase.Usuario.Find(id);
            DataBase.Usuario.Remove(usuario);
            DataBase.SaveChanges();
            return true;
        }

        public bool Insertar(string nombre, string apellido, string email, string password, string telefono, string tipo)
        {
            //Contruccion del objeto
            Usuario usuario = new Usuario();
            usuario.Apellido=apellido;
            usuario.Nombre = nombre;
            DataBase.Usuario.Add(usuario);
            DataBase.SaveChanges();
           return true;
        }
    }
}
