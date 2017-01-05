using Telerik.WinControls.UI;

namespace Tradex
{
   public class DataContainer
    {
        private static DataContainer _instance;

        public string Servidor { get; set; }
        public string Bd { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }

        public string Iddocumento { get; set; }

       //Datos Factura
        public string Almacen { get; set; }
        public string Entidad { get; set; }
        public string Talon { get; set; }
        public string NombHecho { get; set; }
       
       public string ConectionString { get; set; }

       public object EntidadesCliente { get; set; }
       public string ConceptoVenta { get; set; }
        protected DataContainer()
        {

        }

        public static DataContainer Instance()
        {

            if (_instance == null)
                _instance = new DataContainer();
            return _instance;

        }
    }
}
