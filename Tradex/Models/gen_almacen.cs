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
    public partial class gen_almacen
    {
        public int idalmacen { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public int idunidad { get; set; }
        public bool activo { get; set; }
        public string Jefe { get; set; }
        public string Direccion { get; set; }
    
        public virtual gen_unidadcontable gen_unidadcontable { get; set; }
    }
}
