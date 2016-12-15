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
       
       public string ConectionString { get; set; }

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
