//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Tradex.Models
{
    public partial class gen_producto
    {
        public int idproducto { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public int idmedida { get; set; }
        public int idnivelclas { get; set; }
        public bool activo { get; set; }
        public Nullable<decimal> precio { get; set; }
    
        public virtual gen_medida gen_medida { get; set; }
    }
}