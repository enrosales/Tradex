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
    
    public partial class gen_usuario
    {
        public gen_usuario()
        {
            this.inv_documento = new HashSet<inv_documento>();
            this.inv_documento1 = new HashSet<inv_documento>();
        }
    
        public int idusuario { get; set; }
        public byte tipo { get; set; }
        public bool activo { get; set; }
        public string loginusuario { get; set; }
        public string nombre { get; set; }
        public int intentos { get; set; }
        public System.DateTime expira { get; set; }
    
        public virtual ICollection<inv_documento> inv_documento { get; set; }
        public virtual ICollection<inv_documento> inv_documento1 { get; set; }
    }
}
