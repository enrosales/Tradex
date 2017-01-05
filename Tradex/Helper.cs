using System;
using System.Collections.Generic;
using Telerik.WinControls.UI;
using Tradex.Models;
using Tradex.Properties;

namespace Tradex
{
    public static class Helper
    {
        private  const string _caracterSeperador = "|";



        public static void AddElemenet(RadListDataItem item, RadDropDownList l)
        {
                l.Items.Add(item);
                // l.SelectedItem = item;
        }

        public static List<RadListDataItem> FormarCombo<T>(List<T> lista, string parametroElegible)
        {
            List<RadListDataItem> fin = new List<RadListDataItem>();
            foreach (var elemen in lista)
                if (parametroElegible == "conceptos") //es un concepto
                {
                    var x = (inv_concepto) (object) elemen;
                    var i = new RadListDataItem
                    {
                        Value = x.idconcepto + "-" + x.codigo,
                        Text = x.codigo + " " + x.descripcion
                    };
                    fin.Add(i);
                }
                else // es un almacen
                    if (parametroElegible == "almacenes")
                    {
                        var x = (gen_almacen) (object) elemen;
                        var i = new RadListDataItem
                        {
                            Value = x.idalmacen + "-" + x.codigo,
                            Text = x.codigo + " " + x.nombre
                        };
                        fin.Add(i);
                    }
                    else if (parametroElegible == "unidades") //es una unidad
                    {
                        var x = (gen_unidadcontable)(object)elemen;
                        var i = new RadListDataItem
                        {
                            Value = x.idunidad,
                            Text = x.codigo + " " + x.nombre
                        };
                        fin.Add(i);
                    }
                    else if (parametroElegible == "monedas") //monedas
                    {
                        var x = (gen_moneda)(object)elemen;
                        var i = new RadListDataItem
                        {
                            Value = x.idmoneda + "-" + x.nombre,
                            Text = x.nombre
                        };
                        fin.Add(i);
                    } //[0] idcuenta=715 [1] clave=69902 [2] descripcion 
                    else if (parametroElegible == "cuentaMn") //cuentasMn
                    {
                        var x = (object[])(object)elemen;
                        var i = new RadListDataItem
                        {
                            Value = x[1].ToString(),
                            Text = x[1] + x[2].ToString()
                        };
                        fin.Add(i);
                    } //[0] idcuenta=715 [1] clave=69902 [2] descripcion
                    else if (parametroElegible == "cuentaMlc") //cuentasMLC
                    {
                        var x = (object[])(object)elemen;
                        var i = new RadListDataItem
                        {
                            Value = x[1].ToString(),
                            Text = x[1] + x[2].ToString()
                        };
                        fin.Add(i);
                    }
                    else if (parametroElegible == "clientes") //clientes
                    {
                        //identidad, codigo, nombre, codigoreu, abreviatura
                        //direccion, email, telefono, NIT, IRCC, provincia, pais
                        var x = (object[])(object)elemen;
                        string concatenar = "";
                        for (int j = 1; j < 12; j++)
                        {
                            concatenar = concatenar + x[j] + _caracterSeperador;
                        }

                        var i = new RadListDataItem
                        {
                            //aqui en el value guardo 
                            //todo lo que me de la gana para mostrarla directo en el notepad
                            Value = concatenar,
                            Text = x[1] + " " +  x[2]
                        };
                        fin.Add(i);
                    }
                    else if (parametroElegible == "UMO") //UMO
                    { // "idmedida", "clave", "descripcion"
                        var x = (object[])(object)elemen;
                        var i = new RadListDataItem
                        {
                            // en el value va: idmedida-descripcion
                            Value = x[0] + "-" + x[2],
                            //en el texto: clave
                            Text = x[1].ToString()
                        };
                        fin.Add(i);
                    }
                    else if (parametroElegible == "CuentasCUP") //CuentasCUP
                    { //"idcuenta", "clave", "descripcion"
                        var x = (object[])(object)elemen;
                        var i = new RadListDataItem
                        {
                            // en el value va: idcuenta
                            Value = x[0],
                            //en el texto: clave y descripcion
                            Text = x[1] + "*" + x[2]
                        };
                        fin.Add(i);
                    }
                    else if (parametroElegible == "SubCUP") //SubCUP
                    { //"idsubelemento", "codigo", "descripcion"
                        var x = (object[])(object)elemen;
                        var i = new RadListDataItem
                        {
                            // en el value va: idsubelemento
                            Value = x[0],
                            //en el texto: codigo y descripcion
                            Text = x[1] + " " + x[2]
                        };
                        fin.Add(i);
                    }
                    else if (parametroElegible == "SubCUC") //SubCUC
                    { //"idsubelemento", "codigo", "descripcion"
                        var x = (object[])(object)elemen;
                        var i = new RadListDataItem
                        {
                            // en el value va: idsubelemento
                            Value = x[0],
                            //en el texto: codigo y descripcion
                            Text = x[1] + " " + x[2]
                        };
                        fin.Add(i);
                    }
                    else if (parametroElegible == "talones") //SubCUC
                    { //"idsubelemento", "codigo", "descripcion"
                        var x = (Fac_Talon)(object)elemen;
                        var i = new RadListDataItem
                        {
                            // en el value va: idsubelemento
                            Value = x.Codigo,
                            //en el texto: codigo y descripcion
                            Text = x.Codigo + " " + x.Descripcion
                        };
                        fin.Add(i);
                    }
                    else if (parametroElegible == "nombhecho") //SubCUC
                    { //"idsubelemento", "codigo", "descripcion"
                        var x = (gen_usuario)(object)elemen;
                        var i = new RadListDataItem
                        {
                            // en el value va: idsubelemento
                            Value = x.nombre,
                            //en el texto: codigo y descripcion
                            Text = x.nombre
                        };
                        fin.Add(i);
                    }
                    else if (parametroElegible == "conceptosventa") //concetos de venta
                    { //"idsubelemento", "codigo", "descripcion"
                        var x = (fac_conceptoventa)(object)elemen;
                        var i = new RadListDataItem
                        {
                            // en el value va: idsubelemento
                            Value = x.codigo,
                            //en el texto: codigo y descripcion
                            Text = x.codigo+"-"+x.descripcion
                        };
                        fin.Add(i);
                    }

                        
            
            return fin;
        }

        public static string GetValueConf(string param)
        {
           // var re = Settings.Default.Properties[param];
            var re = Settings.Default[param];
            return re != null ? re.ToString() : "";
        }

        public static void SearchInCombo(RadDropDownList r,string texto)
        {
            foreach (var i in r.Items)
            {
                if (i.Value.ToString().ToLower().Contains(texto.ToLower()))
                {
                    r.SelectedIndex = i.RowIndex;
                    return;
                }
            }
        }

        public static void AddColumns(string columname, Type type, RadGridView r)
        {
            GridViewDataColumn c=new GridViewBrowseColumn(columname);
            c.DataType = type;
            r.Columns.Add(c);
        }


    }
}
