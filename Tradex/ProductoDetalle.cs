using System.ComponentModel;

namespace Tradex
{
    public class ProductoDetalle //: INotifyPropertyChanged
    {
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public string umo { get; set; }
        public string cuentaCup { get; set; }
        public string cuentaCuc { get; set; }
        public string subelementoCup { get; set; }
        public string subelementoCuc { get; set; }
        public double cantidad { get; set; }
        public double importeMlc { get; set; }
        public double importeMn { get; set; }
        public double existencia { get; set; }

        public ProductoDetalle()
        {
            CuentaCup = null;
            CuentaCuc = null;
            SubElementoCup = null;
            SubElementoCuc = null;
        }

        public ProductoDetalle(string codigo, string descripcion, string umo = null, string cuentaCup = null, string cuentaCuc = null,
           string subElemCup = null, string subElemCuc = null, double cantidad = 0, double importeMn = 0, double importeMlc = 0, double existencia = 0)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.umo = umo;
            this.cuentaCup = cuentaCup;
            this.cuentaCuc = cuentaCuc;
            subelementoCup = subElemCup;
            subelementoCuc = subElemCuc;
            this.cantidad = cantidad;
            this.importeMn = importeMn;
            this.importeMlc = importeMlc;
            this.existencia = existencia;
        }

        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                if (descripcion != value)
                {
                    descripcion = value;
                   // OnPropertyChanged("descripcion");
                }
            }
        }

        public string Umo
        {
            get { return umo; }
            set
            {
                if (umo != value)
                {
                    umo = value;
                  //  OnPropertyChanged("umo");
                }
            }
        }

        public string CuentaCup
        {
            get { return cuentaCup; }
            set
            {
                if (cuentaCup != value)
                {
                    cuentaCup = value;
                  //  OnPropertyChanged("cuentaCup");
                }
            }
        }

        public string CuentaCuc
        {
            get { return cuentaCuc; }
            set
            {
                if (cuentaCuc != value)
                {
                    cuentaCuc = value;
                   // OnPropertyChanged("cuentaCuc");
                }
            }
        }

        public string SubElementoCup
        {
            get { return subelementoCup; }
            set
            {
                if (subelementoCup != value)
                {
                    subelementoCup = value;
                   // OnPropertyChanged("subelementoCup");
                }
            }
        }

        public string SubElementoCuc
        {
            get { return subelementoCuc; }
            set
            {
                if (subelementoCuc != value)
                {
                    subelementoCuc = value;
                  //  OnPropertyChanged("subelementoCup");
                }
            }
        }

        public string Codigo
        {
            get { return codigo; }
            set
            {
                if (codigo != value)
                {
                    codigo = value;
                   // OnPropertyChanged("codigo");
                }
            }
        }

        public double Cantidad
        {
            get { return cantidad; }
            set
            {
                if (cantidad != value)
                {
                    cantidad = value;
                   // OnPropertyChanged("cantidad");
                }
            }
        }

        public double ImporteMn
        {
            get { return importeMn; }
            set
            {
                if (importeMn != value)
                {
                    importeMn = value;
                  //  OnPropertyChanged("importeMn");
                }
            }
        }

        public double ImporteMlc
        {
            get { return importeMlc; }
            set
            {
                if (importeMlc != value)
                {
                    importeMlc = value;
                  //  OnPropertyChanged("importeMlc");
                }
            }
        }

        public double Existencia
        {
            get { return existencia; }
            set
            {
                if (existencia != value)
                {
                    existencia = value;
                  //  OnPropertyChanged("existencia");
                }
            }
        }

     /*   #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null) PropertyChanged(this, e);
        }

        #endregion

        */
    }
}
