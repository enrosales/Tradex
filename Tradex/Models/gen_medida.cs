//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Tradex.Models
{
    public partial class gen_medida
    {
        public gen_medida()
        {
            this.gen_producto = new HashSet<gen_producto>();
        }
    
        public int idmedida { get; set; }
        public string clave { get; set; }
        public string descripcion { get; set; }
    
        public virtual ICollection<gen_producto> gen_producto { get; set; }
    }
}
