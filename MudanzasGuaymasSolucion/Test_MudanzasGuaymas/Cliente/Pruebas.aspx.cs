using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Test_MudanzasGuaymas.Cliente
{
    public partial class Pruebas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string y = "";
            using (SrvUsuario.SrvUsuarioClient client = new SrvUsuario.SrvUsuarioClient())
            {
               var x = client.ConsultarPorNombre("chale");

                for (int i=0; i<x.Length;i++)
                {
                  y+= x.ElementAt(i).Id;
                   
                }
                Label1.Text = y;
            }
        }
    }
}