//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MudanzasGuaymasServices.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paquete
    {
        public int Id { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> Mostrar { get; set; }
        public Nullable<int> Id_Servicio { get; set; }
        public string Imagen { get; set; }
        public string Unidad { get; set; }
    }
}
