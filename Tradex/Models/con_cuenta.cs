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
    public partial class con_cuenta
    {
        public con_cuenta()
        {
            this.inv_configconceptocta = new HashSet<inv_configconceptocta>();
        }
    
        public int idcuenta { get; set; }
        public string clave { get; set; }
        public int idapertura { get; set; }
        public bool activa { get; set; }
    
        public virtual ICollection<inv_configconceptocta> inv_configconceptocta { get; set; }
    }
}
