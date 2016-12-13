using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Tradex
{
    public partial class ProductDetails : RadForm
    {
        private Versat _versat;
        private string idAlmacen;
       // private BindingList<ProductoDetalle> ListadoDeProductos;
        private int rowindex,entidad;
        private List<ProductoDetalle> ListadoDeProductos;

        public ProductDetails(string idAlmacen, List<ProductoDetalle> ListadoDeProductos, int entidad,int rowIndex=-1)
        {
            InitializeComponent();
            _versat = new Versat();
            this.ListadoDeProductos = ListadoDeProductos;
            this.idAlmacen = idAlmacen;
            rowindex = rowIndex;
            this.entidad = entidad;
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            
            ThemeName = visualStudio2012DarkTheme1.ThemeName;

            comboUmo.DataSource = _versat.ComboUMO();

            comboCuentaCUP.DataSource = _versat.ComboCuentaCUP(idAlmacen);

            comboCuentaCUC.DataSource = _versat.ComboCuentaCUP(idAlmacen);

            comboSubCUP.DataSource = _versat.ComboSubCUP();

            comboSubCUC.DataSource = _versat.ComboSubCUC();

            if (rowindex == -1)
            {
                Text = "Agregar detalles a todos los productos.";
            }
            else // si es un producto en especifico ya cargo los datos de ese producto
            {
                Text = "Agregar detalles al producto: " + ListadoDeProductos[rowindex].Codigo;
                comboUmo.SelectedIndex = IndiceUmo(ListadoDeProductos[rowindex].Umo);
                comboCuentaCUP.SelectedIndex = IndiceCuentaCup(ListadoDeProductos[rowindex].CuentaCup);
                comboCuentaCUC.SelectedIndex = IndiceCuentaCuc(ListadoDeProductos[rowindex].CuentaCuc);
                comboSubCUP.SelectedIndex = IndiceSubCup(ListadoDeProductos[rowindex].SubElementoCup);
                comboSubCUC.SelectedIndex = IndiceSubCuc(ListadoDeProductos[rowindex].SubElementoCuc);
            }

        }

        private int IndiceSubCuc(string subElementoCuc)
        {
            if (subElementoCuc == null)
                return -1;
            /*
             * // en el value va: idsubelemento
                Value = x[0],
                //en el texto: codigo y descripcion
                Text = x[1] + " " + x[2]
            */
            int index = 0;
            foreach (var um in comboSubCUC.Items)
            {
                if (um.Text.Split(' ')[0].Trim() == subElementoCuc.Trim())
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        private int IndiceSubCup(string subElementoCup)
        {
            if (subElementoCup == null)
                return -1;
            /*
             * // en el value va: idsubelemento
                Value = x[0],
                //en el texto: codigo y descripcion
                Text = x[1] + " " + x[2]
            */
            int index = 0;
            foreach (var um in comboSubCUP.Items)
            {
                if (um.Text.Split(' ')[0].Trim() == subElementoCup.Trim())
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        private int IndiceCuentaCuc(string cuentaCuc)
        {
            if (cuentaCuc == null)
                return -1;
            /*
             *  // en el value va: idcuenta
                //en el texto: clave y descripcion
                Text = x[1] + "*" + x[2]
            */
            int index = 0;
            foreach (var um in comboCuentaCUC.Items)
            {
                if (um.Text.Split('*')[0].Trim() == cuentaCuc.Trim())
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        private int IndiceCuentaCup(string cuentaCup)
        {
            if (cuentaCup == null)
                return -1;
            /*
             *  // en el value va: idcuenta
                //en el texto: clave y descripcion
                Text = x[1] + "*" + x[2]
            */
            int index = 0;
            foreach (var um in comboCuentaCUP.Items)
            {
                if (um.Text.Split('*')[0].Trim() == cuentaCup.Trim())
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        private int IndiceUmo(string umo)
        {
            if (umo == null)
                return -1;

            int index = 0;
            foreach (var um in comboUmo.Items)
            {
                if (um.Text == umo.Trim())
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboCuentaCUC.SelectedItem == null || comboCuentaCUP.SelectedItem == null)
            {
                
                MessageBox.Show(@"Las dos cuentas deben estar seleccionadas");
                return;
            }

            var idUMO = (RadListDataItem)comboUmo.SelectedItem.DataBoundItem;
            string idUmoReal = idUMO.Text;

            var idCuentaCUP = comboCuentaCUP.SelectedItem;
            string idCuentaRealCUP = idCuentaCUP.Text.Split('*')[0];
           // string id = idCuentaCUP.Value.ToString();
            //en el texto: clave y descripcion
            var idCuentaCUC = (RadListDataItem)comboCuentaCUC.SelectedItem;
            string idCuentaRealCUC = idCuentaCUC.Text.Split('*')[0];
            //en el texto: codigo y descripcion
            string idSubRealCUC="",idSubRealCUP= "";
            RadListDataItem idSubCUC=null, idSubCUP = null;
            if (comboSubCUP.SelectedItem != null)
            {
                idSubCUP = (RadListDataItem)comboSubCUP.SelectedItem.DataBoundItem;
                idSubRealCUP = idSubCUP.Text.Split(' ')[0];
            }
            if (comboSubCUC.SelectedItem != null)
            {
                //en el texto: codigo y descripcion
                idSubCUC = (RadListDataItem)comboSubCUC.SelectedItem.DataBoundItem;
                idSubRealCUC = idSubCUC.Text.Split(' ')[0];
            }
           
         

            // si es para todos los elementos
            if (rowindex == -1)
            {
                foreach (var elemento in ListadoDeProductos)
                {
                    // elemento.Umo = idUmoReal;
                    elemento.cuentaCup = idCuentaRealCUP;
                    elemento.cuentaCuc = idCuentaRealCUC;
                    elemento.subelementoCup = idSubRealCUP;
                    elemento.SubElementoCuc = idSubRealCUC;
                }
            } // si es para un solo elemento
            else
            {
                ListadoDeProductos[rowindex].Umo = idUmoReal;
                ListadoDeProductos[rowindex].cuentaCup = idCuentaRealCUP;
                ListadoDeProductos[rowindex].cuentaCuc = idCuentaRealCUC;
                ListadoDeProductos[rowindex].subelementoCup = idSubRealCUP;
                ListadoDeProductos[rowindex].SubElementoCuc = idSubRealCUC;
            }

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            CuentaContable cc = new CuentaContable();
            new Clasificador(entidad,cc).ShowDialog();
            Cursor = Cursors.Arrow;
            
          //  comboCuentaCUP.SelectedValue = cc.idCuenta;
            //comboCuentaCUP.Text = cc.clave + "*" + cc.descripcion;
            var i = new RadListDataItem
                        {
                            // en el value va: idcuenta
                            Value = cc.idCuenta,
                            //en el texto: clave y descripcion
                            Text = cc.clave + "*" + cc.descripcion
                        };
            Helper.AddElemenet(i, comboCuentaCUP);
          //  button1.PerformClick();
        }

        private void btnCuentaCuc_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            CuentaContable cc = new CuentaContable();
            new Clasificador(entidad,cc).ShowDialog();
            Cursor = Cursors.Arrow;
            //comboCuentaCUC.SelectedValue = cc.idCuenta;
            //comboCuentaCUC.Text = cc.clave + "*" + cc.descripcion;
            var i = new RadListDataItem
            {
                // en el value va: idcuenta
                Value = cc.idCuenta,
                //en el texto: clave y descripcion
                Text = cc.clave + "*" + cc.descripcion
            };
            Helper.AddElemenet(i, comboCuentaCUC);
            
        }
    }
    public class CuentaContable
    {
        public int idCuenta { get; set; }
        public string clave { get; set; }
        public string descripcion { get; set; }
    }
}
