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
    
    public partial class preCita
    {
        public int Id { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Detalle { get; set; }
        public string Direccion { get; set; }
        public Nullable<bool> Hecho { get; set; }
        public Nullable<int> id_usuario { get; set; }
        public Nullable<bool> Terminado { get; set; }
    }
}