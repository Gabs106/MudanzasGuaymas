using MudanzasGuaymasServices.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MudanzasGuaymasServices.Services.Seguridad
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SrvSesion" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SrvSesion.svc o SrvSesion.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SrvSesion : ISrvSesion
    {
        MGEntidades DataBase = new MGEntidades();
        public Usuario ConsultarPorEmail(string email)
        {
            Usuario user = new Usuario();
            var Query = from usuario in DataBase.Usuario
                        where usuario.Email == email
                        select usuario;

            foreach (var result in Query)
            {
                user = result;
            }

            return user;
        }
        public string Desencriptar(string password)
        {
            string result = string.Empty;
            if (password!=null) {
                byte[] decryted = Convert.FromBase64String(password);
                //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
                result = System.Text.Encoding.Unicode.GetString(decryted);
            }
            return result;
        }

        public string Encriptar(string password)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(password);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        public bool Login(string email, string password)
        {

            bool correcto = false;
            Usuario user = new Usuario();
            var Query = from usuario in DataBase.Usuario
                        where usuario.Email == email
                        select usuario;

            foreach (var result in Query)
            {
                user = result;
            }
            if (user!=null)
            {
                if (password.Equals(Desencriptar(user.Password)))
                {
                    correcto = true;
                }
                else
                {
                    correcto = false;
                }
            }

            return correcto;
        }

        public bool Logout()
        {
            return true;
        }
    }
}
