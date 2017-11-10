using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MudanzasGuaymasServices.Entity;

namespace MudanzasGuaymasServices.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SrvUsuario" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SrvUsuario.svc o SrvUsuario.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SrvUsuario : ISrvUsuario
    {
        MudanzasGuaymasDbEntities db = new MudanzasGuaymasDbEntities();
        public Usuario ConsultarPorId()
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ConsultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ConsultarTodos()
        {
            throw new NotImplementedException();
        }

        public bool Editar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            Usuario usuario = db.Usuario.Find(id);
            db.Usuario.Remove(usuario);
            db.SaveChanges();
            return true;
        }

        public bool Insertar(Usuario usuario)
        {
            db.Usuario.Add(usuario);
            db.SaveChanges();
            return true;
        }
    }
}
