//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tradex.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class inv_movimiento
    {
        public int idmovimiento { get; set; }
        public decimal cantidad { get; set; }
        public decimal importe { get; set; }
        public decimal existencia { get; set; }
        public int iddocumento { get; set; }
        public int idproducto { get; set; }
        public int idmedida { get; set; }
        public long crc { get; set; }
    
        public virtual gen_producto gen_producto { get; set; }
        public virtual inv_documento inv_documento { get; set; }
        public virtual gen_medida gen_medida { get; set; }
    }
}