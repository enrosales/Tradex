using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using Tradex.Excel;
using Tradex.Properties;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace Tradex
{
    public partial class ExcelForm : RadForm
    {
        private string idAlmacen, codigoAlmacen, concepto, nroDoc, nroControl, fecha, claveCuentaMn, claveCuentaMlc, comentario,
            entidad, monedaContable, monedaMca, tasa;
        private Versat _versat;
        long iRows, rowCounter;
        private int idEntidadreal;
       // private BindingList<ProductoDetalle> ListadoDeProductos = new BindingList<ProductoDetalle>();
        private List<ProductoDetalle> ListadoDeProductos = new List<ProductoDetalle>();

        private excelManager em;
        private Workbook excel;

        public ExcelForm(Versat versat, string idAlmacen, string codigoAlmacen,string concepto, string nroDoc, string nroControl,string fecha,
           string claveCuentaMn, string claveCuentaMlc, string comentario, string entidad,string monedaContable,string monedaMca,
           string tasa, int idEntidadreal)
        {
            InitializeComponent();
            this.idAlmacen = idAlmacen;
            this.concepto = concepto;
            this.nroDoc = nroDoc;
            this.nroControl = nroControl;
            this.fecha = fecha;
            this.claveCuentaMn = claveCuentaMn;
            this.claveCuentaMlc = claveCuentaMlc;
            this.comentario = comentario;
            this.entidad = entidad;
            this.monedaContable = monedaContable;
            this.monedaMca = monedaMca;
            this.tasa = tasa;
            this.codigoAlmacen = codigoAlmacen;
            _versat = versat;
            this.idEntidadreal = idEntidadreal;

        }
        
        private void ExcelForm_Load(object sender, EventArgs e)
        {
            ActualizarParametrosDeExcel();
            LlenarGrid();
            InitializeBackgoundWorker();

        }

        // Set up the BackgroundWorker object by 
        // attaching event handlers. 
        private void InitializeBackgoundWorker()
        {
            backgroundWorker1.DoWork +=
                new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(
            backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged +=
                new ProgressChangedEventHandler(
            backgroundWorker1_ProgressChanged);
        }

        #region Eventos del backgroundworker
        // This event handler is where the actual,
        // potentially time-consuming work is done.
        private void backgroundWorker1_DoWork(object sender,
            DoWorkEventArgs e)
        {
            // Get the BackgroundWorker that raised this event.
            BackgroundWorker worker = sender as BackgroundWorker;

            // Assign the result of the computation
            // to the Result property of the DoWorkEventArgs
            // object. This is will be available to the 
            // RunWorkerCompleted eventhandler.
            e.Result = LeerExcel((string)e.Argument);
        }

        // This event handler deals with the results of the
        // background operation.
        private void backgroundWorker1_RunWorkerCompleted(
            object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled 
                // the operation.
                // Note that due to a race condition in 
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.
               // resultLabel.Text = "Canceled";
            }
            else
            {
                // Finally, handle the case where the operation 
                // succeeded.
               // resultLabel.Text = e.Result.ToString();
                radGridView1.DataSource = (List<ProductoDetalle>)e.Result;
                ListadoDeProductos = (List<ProductoDetalle>) e.Result;
                btnExportar.Enabled =repetidos ;
                em.KillProcess();
                em.ReleaseObject(excel);
            }

            // Enable the UpDown control.
           // this.numericUpDown1.Enabled = true;

            // Enable the Start button.
           // startAsyncButton.Enabled = true;

            // Disable the Cancel button.
           // cancelAsyncButton.Enabled = false;
        }

        // This event handler updates the progress bar.
        private void backgroundWorker1_ProgressChanged(object sender,
            ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        #endregion

        private void ActualizarParametrosDeExcel()
        {
            txtColumnInicio.Text = Settings.Default.columnaInicio;
            txtColumnFin.Text = Settings.Default.columnaFin;
            txtFilaInicio.Text = Settings.Default.filaInicio;
            txtFilaFin.Text = Settings.Default.filaFin;
            txtHojaExcel.Text = Settings.Default.hojaExcel;

            txtColumnaCodigoP.Text = Settings.Default.columnaCodigo;
            txtColumnaUM.Text = Settings.Default.columnaUm;
            txtColumnaDesc.Text = Settings.Default.columnadescripcion;
            txtColumnaCant.Text = Settings.Default.columnaCantidad;
            txtColumnaCUC.Text = Settings.Default.columnaImporteCUC;
            txtColumnaMN.Text = Settings.Default.columnaImporteMN;
        }

        private void LlenarGrid()
        {

            radGridView1.MasterTemplate.AllowAddNewRow = false;
            radGridView1.MasterTemplate.AutoGenerateColumns = true;
            //  this.radGridView1.BestFitColumns();
            radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            radGridView1.DataSource = ListadoDeProductos;

            radGridView1.Columns[0].HeaderText = "Cód. Producto";
            radGridView1.Columns[1].HeaderText = "Descripción";
            radGridView1.Columns[2].HeaderText = "UMO";
            radGridView1.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
            radGridView1.Columns[3].HeaderText = "Cuenta CUP";
            radGridView1.Columns[4].HeaderText = "Cuenta CUC";
            radGridView1.Columns[5].HeaderText = "Subelemento CUP";
            radGridView1.Columns[6].HeaderText = "Subelemento CUC";
            radGridView1.Columns[7].HeaderText = "Cantidad";
            radGridView1.Columns[7].TextAlignment = ContentAlignment.MiddleCenter;
            radGridView1.Columns[8].HeaderText = "Importe MLC";
            radGridView1.Columns[8].TextAlignment = ContentAlignment.MiddleCenter;
            radGridView1.Columns[9].HeaderText = "Importe MN";
            radGridView1.Columns[9].TextAlignment = ContentAlignment.MiddleCenter;
            radGridView1.Columns[10].HeaderText = "Existencia";

            radGridView1.AllowEditRow = false;
            radGridView1.EnableAlternatingRowColor = true;
            //Permitir el filtrado de columnas
            radGridView1.MasterTemplate.EnableFiltering = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ConfigProperties(true).ShowDialog();
            ActualizarParametrosDeExcel();
        }

        private void ExcelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string ruta = BuscaExcel();
            if (ruta == null)
                return;
            // Start the asynchronous operation.
            backgroundWorker1.RunWorkerAsync(ruta);
        }

        private void DevolverPosicionDelArregloDeColumnasDelExcel(ref int colCod, ref int colUm, ref int colDesc,
            ref int colCant, ref int colImporteMn, ref int colImporteCuc)
        {
            char ini = char.Parse(Settings.Default.columnaInicio);
            char fin = char.Parse(Settings.Default.columnaFin);
            int index = 1;
            for (char i = ini; i <= fin; i++)
            {
                if (i == char.Parse(Settings.Default.columnaCodigo))
                    colCod = index;
                else if (i == char.Parse(Settings.Default.columnaCodigo))
                    colCod = index;
                else if (i == char.Parse(Settings.Default.columnaUm))
                    colUm = index;
                else if (i == char.Parse(Settings.Default.columnadescripcion))
                    colDesc = index;
                else if (i == char.Parse(Settings.Default.columnaCantidad))
                    colCant = index;
                else if (i == char.Parse(Settings.Default.columnaImporteMN))
                    colImporteMn = index;
                else if (i == char.Parse(Settings.Default.columnaImporteCUC))
                    colImporteCuc = index;
                index++;
            }
        }

        private string BuscaExcel()
        {
            FileDialog cargarExcelModelo = new OpenFileDialog();
            cargarExcelModelo.DefaultExt = "xls";
            cargarExcelModelo.AddExtension = true;
            cargarExcelModelo.CheckPathExists = true;
           // cargarExcelModelo.Filter = "Xls|*.xls|xlsx|*.xlsx";
            //(*.txt)|*.txt
            cargarExcelModelo.Filter = "Excel files(*.Xlsx)|*.Xlsx|Excel files(*.Xls)|*.Xls";
            cargarExcelModelo.Title = "Busque la dirección donde se encuentra el modelo excel con las recepciones";
            cargarExcelModelo.ShowDialog();


            if (cargarExcelModelo.FileName == "")
            {
                MessageBox.Show("Debe escoger el lugar donde se encuentra el modelo excel con las recepciones");
                return null;
            }

            return @cargarExcelModelo.FileName;
        }

        private object LeerExcel(string ruta)
        {

            em = new excelManager();
            excel = em.LeerExcel(ruta);
            int indexHoja = em.IndexHoja(excel, Settings.Default.hojaExcel);
            Worksheet hoja = em.LeerHoja(excel, indexHoja);

            string inicio = Settings.Default.columnaInicio + Settings.Default.filaInicio;
            string fin = Settings.Default.columnaFin + Settings.Default.filaFin;

            Range rango = hoja.get_Range(inicio, fin);

            try
            {
                List<ProductoDetalle> ListadoDeProductos = new List<ProductoDetalle>();
                
                //esta lista no cumple funcion objetiva es solo para ir annadiendo a ella los productos con sus codigos originales
                //a la hora de mostrar los repetidos que muestre los originales no los codigos ya modificados
                List<ProductoDetalle> ListadoProductosOriginalExcel = new List<ProductoDetalle>();

                Object[,] saRet;
                saRet = (Object[,])rango.get_Value(Missing.Value);
                List<ProductoDetalle> lrepfinal = new List<ProductoDetalle>(); 
                //Determine the dimensions of the array.
                //long iRows;
                // long iCols;
                iRows = saRet.GetUpperBound(0);
                // iCols = saRet.GetUpperBound(1);
                string codProd, Um, descrip;
                double cantidad, importeMn, importeCuc;

                #region comentado de ejemplo

                //for (long rowCounter = 1; rowCounter <= iRows; rowCounter++)
                //{
                //    for (long colCounter = 1; colCounter <= iCols; colCounter++)
                //    {

                //        //Write the next value into the string.
                //        valueString = String.Concat(valueString,
                //           saRet[rowCounter, colCounter].ToString() + ", ");
                //    }

                //    //Write in a new line.
                //    valueString = String.Concat(valueString, "\n");
                //}

                #endregion

                // int colCod=1, colUm=2, colDesc=3, colCant=6, colImporteMn=11, colImporteCuc=12;
                int colCod = 0, colUm = 0, colDesc = 0, colCant = 0, colImporteMn = 0, colImporteCuc = 0;



                List<object[]> producto, cuentas;
                object[] datos = new object[0];
                DevolverPosicionDelArregloDeColumnasDelExcel(ref colCod, ref colUm, ref colDesc, ref colCant,
                    ref colImporteMn, ref colImporteCuc);
                List<string> codigos = CodigosExcel(colCod, saRet);
                for (rowCounter = 1; rowCounter <= iRows; rowCounter++)
                {
                    // codProd = saRet[rowCounter, 1].ToString();
                    // le paso la funcion trim() para quitarle los espacios en blanco sobrantes leidos del excel
                    codProd = saRet[rowCounter, colCod].ToString().Trim();
                    Um = saRet[rowCounter, colUm].ToString().Trim();
                    descrip = saRet[rowCounter, colDesc].ToString().Trim();
                   // Encoding enc = new UTF8Encoding(true, true);
                    
                    cantidad = double.Parse(saRet[rowCounter, colCant].ToString());
                    importeMn = double.Parse(saRet[rowCounter, colImporteMn].ToString());
                    importeCuc = double.Parse(saRet[rowCounter, colImporteCuc].ToString());
                    ProductoDetalle pd = new ProductoDetalle();
                    //(si existe el prod en Versat y la existencia NO es 0 ) O si
                    //(si existe el prod en Versat y la descripcion es distinta a la del excel ) y la um es diferente a la del excel
                    //Si entra aqui es porque se crea el producto como nuevo
                    if ((_versat.ExisteProducto(codProd) == 1 && !_versat.ExistenciaZeero(codProd, idAlmacen)) 
                        || (_versat.ExisteProducto(codProd) == 1 && _versat.GetDesc(codProd) != descrip)||(_versat.ExisteProducto(codProd) == 1  && Um!=_versat.GetUM(codProd))) // si existe el producto en el versat
                    {
                        //lo que tengo que hacer es coger el codigo de ese producto y concatenarle _contador al final
                       

                        producto = _versat.ListProductoDetalles(codProd);

                        if (producto != null && producto.Count > 0)
                        {
                            datos = producto[0];

                            if (datos != null && datos.Length > 0)
                            {

                                string codigo = datos[0].ToString();
                                int index = 0;
                                
                                string nuevoCodigo = codigo;
                                
                                string temp;
                                
                                while (true)
                                {
                                   
                                    // si es la primera vez busco el codigo del excel
                                    if (index == 0)
                                    {
                                        //si no existe el codigo ni en el versat ni en el excel
                                        if (!_versat.ExisteCodigo(codigo) && !IsInCodigos(codigo, codigos))
                                        {
                                            //si no existe entonces este codigo lo puedo utilizar 
                                            temp = codigo;
                                            break;
                                        }
                                    }
                                        // si no es la primera vez el codigo que busco es el que estoy formando yo con _1 etc
                                    // si no existe ese codigo ni en versat ni mas abajo en el excel
                                
                                    temp = AsignarCodigo(nuevoCodigo, index.ToString());
                                    if (!_versat.ExisteCodigo(temp) && !IsInCodigos(temp, codigos) && !EstaenGen(temp, ListadoDeProductos))
                                    {
                                        break;
                                    }
                                    index++;
                                }

                                pd.codigo = temp;
                            }

                            //Encoding enc = new UTF8Encoding(true, true);
                            
                          //  if (datos != null && datos.Length > 1)
                          //      pd.Descripcion = datos[1].ToString();
                            pd.Descripcion = descrip;
                            pd.Umo = Um;
                            //if (datos != null && datos.Length > 3)
                            //    pd.Umo = datos[3].ToString();
                        }

                        cuentas = _versat.ListCuentaMnProducto(pd.codigo);
                        if (cuentas != null && cuentas.Count > 0)
                        {
                            datos = cuentas[0];
                            if (datos != null && datos.Length > 0)
                            {
                                pd.CuentaCup = datos[0].ToString();
                            }
                        }

                        cuentas = null;
                        datos = null;
                        cuentas = _versat.ListCuentaCucProducto(pd.codigo);
                        if (cuentas != null && cuentas.Count > 0)
                            datos = cuentas[0];

                        if (datos != null && datos.Length > 0)
                        {
                            pd.CuentaCuc = datos[0].ToString();
                        }

                        cuentas = null;
                        datos = null;
                        cuentas = _versat.ListSubElementoCup(pd.codigo);
                        if (cuentas != null && cuentas.Count > 0)
                            datos = cuentas[0];

                        if (datos != null && datos.Length > 0)
                        {
                            pd.SubElementoCup = datos[0].ToString();
                        }

                        cuentas = null;
                        datos = null;
                        cuentas = _versat.ListSubElementoCuc(pd.codigo);
                        if (cuentas != null && cuentas.Count > 0)
                            datos = cuentas[0];

                        if (datos != null && datos.Length > 0)
                        {
                            pd.SubElementoCuc = datos[0].ToString();
                        }

                        //cuentas = _versat.ListExistencia(pd.IdProducto, idAlmacen);
                        //if (cuentas!= null && cuentas.Count > 0)
                        //    datos = cuentas[0];

                        //if (datos != null && datos.Length > 0)
                        //{
                        //    pd.Existencia = double.Parse(datos[0].ToString()) + cantidad;
                        //}

                        pd.existencia = cantidad;
                        pd.Cantidad = cantidad;
                        pd.ImporteMlc = importeCuc;
                        pd.importeMn = importeMn;
                        ListadoDeProductos.Add(pd);
                        
                        //modifico la descripcion del producto y le pongo como viene en el excel para si acaso algo mostrarlo como repetido con su codigo original del excel
                        //pd.Codigo = codProd;
                      //  ProductoDetalle nuevo = pd;
                        ProductoDetalle nuevo = (ProductoDetalle)pd.Clone(); 
                        nuevo.codigo = codProd;
                        ListadoProductosOriginalExcel.Add(nuevo);
                    }
                    //(Si no existe en versat ) o (si existe el producto en versat y la existencia  es 0 y las descripciones son iguales=>Mantener producto.
                    else if ((_versat.ExisteProducto(codProd)==-1)
                        ||(_versat.ExisteProducto(codProd) == 1 && _versat.ExistenciaZeero(codProd,idAlmacen)
                        && (_versat.GetDesc(codProd)==descrip)))
                    {
                        //mantener prod con mismo codigo igual q en el versat 
                        pd.Codigo = codProd;
                        pd.Umo = Um;
                        pd.Descripcion = _versat.GetDesc(codProd);
                        pd.Cantidad = cantidad;
                        pd.ImporteMlc = importeCuc;
                        pd.importeMn = importeMn;
                        pd.Existencia = cantidad;
                        ListadoDeProductos.Add(pd);
                        
                        ListadoProductosOriginalExcel.Add(pd);
                    }

                    List<ProductoDetalle> lrep = ListadoProductosOriginalExcel.Where(a => a.codigo == pd.codigo).ToList();
                    if (lrep.Count() > 1)
                    {
                       lrepfinal.AddRange(lrep.Distinct());
                    }
                    // Report progress as a percentage of the total task.
                    int percentComplete =
                        (int)((float)rowCounter / (float)iRows * 100);
                         backgroundWorker1.ReportProgress(percentComplete);
                }
                if (lrepfinal.Any())
                {
                    repetidos = false;
                    MessageBox.Show(@"Los siguientes productos tienen códigos repetidos en el excel. Se deshabilitará la generación de la recepción.");
                    return lrepfinal.Distinct().ToList();
                }

                repetidos = true;
                return ListadoDeProductos;
                // PintameDeRojo();
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Linea: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
                em.KillProcess();
                em.ReleaseObject(excel);
            }
            em.KillProcess();
            em.ReleaseObject(excel);
            return null;
        }

        private bool repetidos;
        private void btnExportar_Click(object sender, EventArgs e)
        {
            List<ProductoDetalle> lrep = new List<ProductoDetalle>();
            lrep = ListadoDeProductos.Where(a => a.CuentaCuc == null || a.CuentaCup == null).ToList();
            if (lrep.Any())
            {
                MessageBox.Show("Hay productos sin cuentas contables asociadas en el listado. " +
                                "Para completar la exportación, todos los productos deben tener una cuenta en CUC y en CUP asociada.");
                return;
            }


            string ruta = GuardarFicheroTxt();
            if(ruta == null)
                return;
            FileStream fs;
            try
            {
                FileInfo fi = new FileInfo(ruta);

                // Open the file just specified such that no one else can use it.
                fs = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Write);
                
               
                // The using statement also closes the StreamWriter.
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    EscribirFichero(sw);
                    MessageBox.Show("Fichero generado satisfactoriamente en: " + ruta);
                }

            }
            catch (IOException io)
            {
                MessageBox.Show(io.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void EscribirFichero(StreamWriter sw)
        {
            // Add some text to the file.
            //sw.WriteLine();
            //sw.WriteLine();
            sw.WriteLine("[Documento]");
            sw.WriteLine("Concepto=" + concepto);
            sw.WriteLine("Almacen=" + codigoAlmacen);
            sw.WriteLine("Numero=" + nroDoc);
            sw.WriteLine("NumCtrl=" + nroControl);
            sw.WriteLine("Fecha=" + fecha);
            sw.WriteLine("CuentaMN=" + claveCuentaMn);
            sw.WriteLine("CuentaMLC=" + claveCuentaMlc);
            sw.WriteLine("Descripcion=" + comentario);
            sw.WriteLine("Entidad=" + entidad);
            sw.WriteLine("Moneda=" + monedaContable);
            sw.WriteLine("Recargo=0");
            sw.WriteLine("Descuento=0");
            sw.WriteLine("Servicios=0");
            sw.WriteLine("MonedaMCA=" + monedaMca);
            sw.WriteLine("Recargo=0");
            sw.WriteLine("Descuento=0");
            sw.WriteLine("Servicios=0");
            sw.WriteLine("Tasa=" + tasa);
            sw.WriteLine("[Ubicacion]");
            EscribirUbicaciones(sw);
            //una linea en blanco
            sw.WriteLine();
            sw.WriteLine("[Movimientos]");
            EscribirMovimientos(sw);
        }

        private void EscribirMovimientos(StreamWriter sw)
        {
            //000007014210|$|2|20|20|6|-1|0|0|0
            //cod|UMO|cantidad|importeCUP|importeCUC|existencia|recargocup|recargocuc|servicios|serviciosmlc
            foreach (var elemento in ListadoDeProductos)
            {
                sw.Write(elemento.Codigo.Trim());
                sw.Write("|");
                sw.Write(elemento.Umo.Trim());
                sw.Write("|");
                sw.Write(elemento.Cantidad.ToString().Replace(",", "."));
                sw.Write("|");
                sw.Write(elemento.ImporteMn.ToString().Replace(",", "."));
                sw.Write("|");
                sw.Write(elemento.ImporteMlc.ToString().Replace(",", "."));
                sw.Write("|");
                sw.Write(elemento.Existencia.ToString().Replace(",", "."));
                sw.Write("|");
                //recargo
                sw.Write("0");
                sw.Write("|");
                //recargo
                sw.Write("0");
                sw.Write("|");
                //servicios
                sw.Write("0");
                sw.Write("|");
                //serviciosmlc
                sw.WriteLine("0");
            }
        }

        private void EscribirUbicaciones(StreamWriter sw)
        {
            foreach (var elemento in ListadoDeProductos)
            {
                sw.Write(elemento.Codigo.Trim());
                sw.Write("|");
                sw.Write(elemento.Descripcion.Trim());
                sw.Write("|");
                sw.Write(elemento.Umo.Trim());
                sw.Write("|");
                sw.Write(elemento.CuentaCup);
                sw.Write("|");
                sw.Write(elemento.CuentaCuc);
                sw.Write("|");
                sw.Write(elemento.SubElementoCup);
                sw.Write("|");
                sw.Write(elemento.SubElementoCuc);
                sw.WriteLine("|");
            }
        }

        private string GuardarFicheroTxt()
        {
            FileDialog guardarFichero = new SaveFileDialog();
            guardarFichero.DefaultExt = "mvt";
            guardarFichero.AddExtension = true;
            guardarFichero.CheckPathExists = true;
            guardarFichero.Filter = "Mvt|*.mvt";
            guardarFichero.Title = "Indique la dirección donde se guardará el comprobante";
            guardarFichero.ShowDialog();


            if (guardarFichero.FileName == "")
            {
                MessageBox.Show("Debe indicar la ruta para guardar el comprobante");
                return null;
            }

            return @guardarFichero.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  new ProductDetails(idAlmacen, ListadoDeProductos).ShowDialog();
            new ProductDetails(idAlmacen, ListadoDeProductos,idEntidadreal).ShowDialog();
            radGridView1.MasterTemplate.Refresh();
        }

        private void radGridView1_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
           // new ProductDetails(idAlmacen, ListadoDeProductos, e.RowIndex).ShowDialog();
            new ProductDetails(idAlmacen, ListadoDeProductos, idEntidadreal,e.RowIndex).ShowDialog();
            radGridView1.MasterTemplate.Refresh();
        }


        private List<string> CodigosExcel(int colCod, object[,] saRet)
        {
            List<string> fin = new List<string>();
            for (rowCounter = 1; rowCounter <= iRows; rowCounter++)
            {
                fin.Add(saRet[rowCounter, colCod].ToString().Trim());
            }
            return fin;
        }

        private bool IsInCodigos(string codigo, List<string> codigos)
        {
            if (codigos.Any(a => a == codigo))
                return true;
            return false;
        }

        private string AsignarCodigo(string oldcodigo,string newcod)
        {
            if (!oldcodigo.Contains("-"))
            {
                return oldcodigo+"-" + newcod;
            }
           
           string ultimaParte = RecorrerAlreves(oldcodigo)[1];
           string primeraParte = RecorrerAlreves(oldcodigo)[0];
           if (IsNumero(ultimaParte))
               return primeraParte + (Suma(ultimaParte,newcod));
           return   oldcodigo+"-" + newcod;
        }

        int Suma(string prim,string seg)
        {
            if (seg == "0")
                seg = "1";
            return (int)Double.Parse(prim) + (int)Double.Parse(seg);
            
        }

        string[] RecorrerAlreves(string oldcodigo)
        {
            string[] partes = oldcodigo.Split('-');
            string ultimoelem = partes[partes.Count() - 1];
            string primeraparte = "";
            for (int i = 0; i < partes.Count() - 1; i++)
            {
                primeraparte += partes[i] + "-";
            }
           // primeraparte.Remove(primeraparte.Count() - 1);
            return new[] {primeraparte, ultimoelem};
        }

        private bool IsNumero(string x)
        {
            double s=0;
            if (double.TryParse(x, out s))
            {
                return true;
            }
            return false;
        }

        private bool EstaenGen(string codigo,List<ProductoDetalle> prods)
        {
            if (prods.Any(a => a.codigo == codigo))
                return true;
            return false;
        }
    }
}
