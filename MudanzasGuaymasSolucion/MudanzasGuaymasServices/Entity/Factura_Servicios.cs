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
    
    public partial class Factura_Servicios
    {
        public int Id { get; set; }
        public Nullable<int> Id_Factura { get; set; }
        public Nullable<int> Id_Servicio { get; set; }
        public Nullable<decimal> Total { get; set; }
    
        public virtual Factura Factura { get; set; }
        public virtual Servicio Servicio { get; set; }
    }
}
