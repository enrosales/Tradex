using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using Tradex.Models;
using Tablas= System.Data;
namespace Tradex
{
    public class Versat:DbContext
    {
        private readonly TradexEntities _tradexEntities = new TradexEntities();
        private readonly facturasEntities _facturasEntities = new facturasEntities();

    
        public Versat()
        {
            _tradexEntities.Database.Connection.ConnectionString = DataContainer.Instance().ConectionString;
            _facturasEntities.Database.Connection.ConnectionString = DataContainer.Instance().ConectionString;
        }
        
   

        #region Metodos que devuelven listas para llenar combos en la app
        public List<inv_concepto> ListConceptos()
        {
                Configuration.LazyLoadingEnabled = false;
                var codigo = Helper.GetValueConf("codigoinv");
                var list = _tradexEntities.inv_concepto.Where(a => a.codigo == codigo).ToList();
               // var list = _tradexEntities.inv_concepto.ToList();
                Configuration.LazyLoadingEnabled = true; 
                return list;
        }

        public List<gen_almacen> ListAlmacenes()
        {
            Configuration.LazyLoadingEnabled = false;
            var codigo = Helper.GetValueConf("almacenes");
            var list = _tradexEntities.gen_almacen.Where(a => a.codigo == codigo).ToList();
            Configuration.LazyLoadingEnabled = true;
            return list;
        }

        public List<gen_unidadcontable> ListUnidades()
        {
            Configuration.LazyLoadingEnabled = false;
            var codigo = Helper.GetValueConf("unidades");
            var list = _tradexEntities.gen_unidadcontable.Where(a => a.codigo == codigo).ToList();
            Configuration.LazyLoadingEnabled = true;
            return list;
        }

        #endregion

        /// <summary>
        /// Devuelve una lista con todas las monedas del versat
        /// </summary>
        /// <returns></returns>
        private List<gen_moneda> ListMonedas()
        {
            //Select * from gen_moneda order by tipomoneda
            Configuration.LazyLoadingEnabled = false;
            var list = _tradexEntities.gen_moneda.Where(a=>a.tipomoneda!=1).ToList();
            Configuration.LazyLoadingEnabled = true;
            return list;
        }

        public string MonedaContable()
        {
            //Select * from gen_moneda order by tipomoneda
            Configuration.LazyLoadingEnabled = false;
            var list = _tradexEntities.gen_moneda.Where(a => a.tipomoneda == 1).ToList();
            Configuration.LazyLoadingEnabled = true;
            var x = list[0];
            return x.nombre;
        }

       private List<object[]> ListCuentasMlc(string idUnidad, string idConcepto)
        {
            List<object[]> total = SqlDataReader(new[] { "idcuenta", "clave", "descripcion" }, _tradexEntities.Database.Connection,
                    "select c.idcuenta, clave, descripcion  " +
                                                                          "from inv_configconceptocta c " +
                                                                          "inner join con_cuenta cta" +
                                                                          " on cta.idcuenta = c.idcuenta " +
                                                                          " inner join con_cuentadescrip d " +
                                                                          "on d.idcuenta = c.idcuenta " +
                                                                          " where (idconcepto = " + idConcepto + ") and (idunidad =" + idUnidad + ")" +
                                                                          "  order by clave ");
            return total;
        }

        private List<object[]> ListCuentasMn(string idUnidad, string idConcepto)
        {
            /*   var cuentasMn = _tradexEntities.Database.SqlQuery<IEnumerable<Tuple<int, string,string>>>("select c.idcuenta, clave, descripcion  " +
                                                                             "from inv_configconceptocta c " +
                                                                             "inner join con_cuenta cta" +
                                                                             " on cta.idcuenta = c.idcuenta " +
                                                                             " inner join con_cuentadescrip d " +
                                                                             "on d.idcuenta = c.idcuenta " +
                                                                             " where (idconcepto = 17) and (idunidad = 1)" +
                                                                             "  order by clave ");
             * */


            List<object[]> total = SqlDataReader(new[] { "idcuenta", "clave", "descripcion" }, _tradexEntities.Database.Connection,
                    "select c.idcuenta, clave, descripcion  " +
                                                                          "from inv_configconceptocta c " +
                                                                          "inner join con_cuenta cta" +
                                                                          " on cta.idcuenta = c.idcuenta " +
                                                                          " inner join con_cuentadescrip d " +
                                                                          "on d.idcuenta = c.idcuenta " +
                                                                          " where (idconcepto = " + idConcepto + ") and (idunidad =" + idUnidad + ")" +
                                                                          "  order by clave ");
            return total;

        }

        private List<object[]> ListUMO()
        {
            //select idmedida,rtrim(clave) as clave,descripcion from gen_medida order by clave
            string query = "select idmedida,rtrim(clave) as clave,descripcion from gen_medida order by clave";

            List<object[]> total = SqlDataReader(new[] { "idmedida", "clave", "descripcion" },
                _tradexEntities.Database.Connection, query);

            return total;
        }

        private List<object[]> ListCuentasCUP(string idAlmacen)
        {
            //select c.idcuenta, clave, descripcion  from inv_cuentasalm c  inner join con_cuenta cta on cta.idcuenta = c.idcuenta 
            //inner join con_cuentadescrip d on d.idcuenta = c.idcuenta  where (idalmacen = 4) and (idcategoria = 2)  order by clave 
             
             string query = "select c.idcuenta, clave, descripcion  from inv_cuentasalm c  inner join con_cuenta cta on cta.idcuenta = c.idcuenta" +
             " inner join con_cuentadescrip d on d.idcuenta = c.idcuenta  where (idalmacen = " + idAlmacen + ") and (idcategoria = 2)  order by clave ";

             List<object[]> total = SqlDataReader(new[] { "idcuenta", "clave", "descripcion" },
                _tradexEntities.Database.Connection, query);

            return total;
        }

        private List<object[]> ListSubCUP()
        {
             // select idsubelemento,codigo,descripcion  from cos_subelementogasto where (monnac = 1) and (activo = 1)  order by codigo

            string query = "  select idsubelemento,codigo,descripcion  from cos_subelementogasto where (monnac = 1) and (activo = 1)  order by codigo";

            List<object[]> total = SqlDataReader(new[] { "idsubelemento", "codigo", "descripcion" },
               _tradexEntities.Database.Connection, query);
            //annadiendo un elemento vacio que permita dejarlo vacio en el combo
            object[] vacio = new object[3];
            vacio[0] = "";
            vacio[1] = "";
            vacio[2] = "";
            total.Insert(0,vacio);
            return total;
        }

        private List<object[]> ListSubCUC()
        {
            string query = "  select idsubelemento,codigo,descripcion  from cos_subelementogasto where (monnac = 0) and (activo = 1)  order by codigo";

            List<object[]> total = SqlDataReader(new[] { "idsubelemento", "codigo", "descripcion" },
               _tradexEntities.Database.Connection, query);
            //annadiendo un elemento vacio que permita dejarlo vacio en el combo
            object[] vacio = new object[3];
            vacio[0] = "";
            vacio[1] = "";
            vacio[2] = "";
            total.Insert(0, vacio);
            return total;
        }

        private List<object[]> ListEntidadCliente()
        {
            string query = "select identidad, codigo, nombre, codigoreu, abreviatura, " +
                "direccion, email, telefono, NIT, IRCC, provincia, pais from gen_entidad where 1=1 order by codigo";

            List<object[]> total = SqlDataReader(new[] { "identidad", "codigo", "nombre", "codigoreu", "abreviatura",
                "direccion", "email", "telefono", "NIT", "IRCC", "provincia", "pais" },
                _tradexEntities.Database.Connection, query);
           
            return total;
            
        }

        /// <summary>
        /// Devuelve  "codigo", "descripcion", "idmedida", "UMC", "medidadesc" de un producto
        /// </summary>
        /// <param name="codigoProducto"></param>
        /// <returns> Una lista de arreglos de objetos </returns>
        public List<object[]> ListProductoDetalles(string codigoProducto)
        {
            //select p.codigo, p.descripcion, p.idmedida, m.clave as UMC, m.descripcion as medidadesc
            //    from gen_producto p
            //    inner join gen_medida m on m.idmedida = p.idmedida
            //    where p.codigo='888888899999'
            //    order by p.codigo

            string query = "select p.codigo, p.descripcion, p.idmedida, m.clave as UMC, m.descripcion as medidadesc " +
                " from gen_producto p inner join gen_medida m on m.idmedida = p.idmedida" +
                " where p.codigo='"+ codigoProducto +"' order by p.codigo";

            List<object[]> total = SqlDataReader(new[] { "codigo", "descripcion", "idmedida", "UMC", "medidadesc",
                "medidadesc" }, _tradexEntities.Database.Connection, query);

            return total;

        }

        public List<object[]> ListCuentaMnProducto(string codigoProducto)
        {
            //23175
            /*  Select clave from con_cuenta 
                where idcuenta = (Select distinct isnull(idcuentamn,0) as idcuentamn 
             * from inv_existencia where idproducto=(Select idproducto from gen_producto where codigo='1832332010001'))
             */
            string query = "Select clave from con_cuenta where idcuenta = (Select distinct isnull(idcuentamn,0) as idcuentamn " +
                "from inv_existencia where idproducto=(Select idproducto from gen_producto where codigo='" + codigoProducto +"'))";

            List<object[]> total = SqlDataReader(new[] { "clave" }, _tradexEntities.Database.Connection, query);

            return total;
        }

        public List<object[]> ListCuentaCucProducto(string codigoProducto)
        {
            /*  Select clave from con_cuenta 
                where idcuenta = (Select distinct isnull(idcuentamn,0) as idcuentamn 
             * from inv_existencia where idproducto=(Select idproducto from gen_producto where codigo='1832332010001'))
           */
            string query = "Select clave from con_cuenta where idcuenta = (Select distinct isnull(idcuentamlc,0) as idcuentamlc " +
                "from inv_existencia where idproducto=(Select idproducto from gen_producto where codigo='" + codigoProducto + "'))";

            List<object[]> total = SqlDataReader(new[] { "clave" }, _tradexEntities.Database.Connection, query);

            return total;
        }

        public List<object[]> ListSubElementoCup(string codigoProducto)
        {
            /*SELECT c.codigo FROM inv_productosubelementomn 
            inner join cos_subelementogasto c
            on inv_productosubelementomn.idsubelemento = c.idsubelemento 
            WHERE (idproducto = (Select idproducto from gen_producto where codigo = '0000170517'))*/

            string query = "SELECT c.codigo FROM inv_productosubelementomn " + 
            " inner join cos_subelementogasto c on inv_productosubelementomn.idsubelemento = c.idsubelemento " +
            " WHERE (idproducto = (Select idproducto from gen_producto where codigo = '" + codigoProducto + "'))";

            List<object[]> total = SqlDataReader(new[] { "codigo" }, _tradexEntities.Database.Connection, query);

            return total;
        }

        public List<object[]> ListSubElementoCuc(string codigoProducto)
        {
            string query = "SELECT c.codigo FROM inv_productosubelementomlc inner join cos_subelementogasto c " +
            " on inv_productosubelementomlc.idsubelemento = c.idsubelemento WHERE (idproducto = " + 
            "(Select idproducto from gen_producto where codigo = '" + codigoProducto + "'))";

            List<object[]> total = SqlDataReader(new[] { "codigo" }, _tradexEntities.Database.Connection, query);

            return total;
        }
        /// <summary>
        /// Devuelve true si la existencia del producto es 0
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="idAlmacen"></param>
        /// <returns></returns>
        public bool Existencia(int idProducto, string idAlmacen)
        {
            string query = " select cantidad from inv_existencia e  inner join inv_existenciaalm ealm" +
            " on ealm.idexistencia = e.idexistencia left  join inv_existenciaconsig ec on ec.idexistencia = e.idexistencia " +
            " where (idalmacen = " + idAlmacen + ") and (idcategoria = 2) and (idproducto = " + idProducto + ") " +
             " and ((idcategoria < 4) or (identidad = 0))";

            List<object[]> total = SqlDataReader(new[] { "cantidad" }, _tradexEntities.Database.Connection, query);
            if (total.Count == 0)
                return true;
            return Math.Abs(double.Parse(total.First()[0].ToString())) < 0.000000001;
        }

        //metodo que recibe los args que son las columnas que voy a devolver de mi consulta, la conexion a la bd y una query
        // ejecuta esa query y me devuelve una lista de arreglo de objetos con el resultado de la query
        public List<object[]> SqlDataReader(string[] args, DbConnection db, string query)
        {
            List<object[]> final = new List<object[]>();
            DbCommand comando = db.CreateCommand();
            comando.CommandText = query;
            db.Open();
            DbDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                object[] o = new object[args.Length];
                int iterator = 0;
                foreach (var arg in args)
                {
                    o[iterator] = reader[arg];
                    iterator++;
                }
                final.Add(o);
            }
            db.Close();
            return final;
        }

        #region metodos que llenan los combos de la app
        public object ComboAlmacenes()
        {
            return Helper.FormarCombo(ListAlmacenes(), "almacenes");
        }

        public object ComboUnidades()
        {
            return Helper.FormarCombo(ListUnidades(), "unidades");
        }

        public object ComboConceptos()
        {
            return Helper.FormarCombo(ListConceptos(), "conceptos");
        }

        public object ComboCuentasMn(string idUnidad,string idConcepto)
        {
            return Helper.FormarCombo(ListCuentasMn(idUnidad, idConcepto), "cuentaMn");
        }

        public object ComboCuentasMlc(string idUnidad, string idConcepto)
        {
            return Helper.FormarCombo(ListCuentasMlc(idUnidad, idConcepto), "cuentaMlc");
        }

        public object ComboMonedas()
        {
            return Helper.FormarCombo(ListMonedas(), "monedas");
        }

        internal object ComboEntidadCliente()
        {
            return Helper.FormarCombo(ListEntidadCliente(), "clientes");
        }

        #endregion

       #region Metodos que devuelven un solo valor

        /// <summary>
        /// True si existe false other case
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public bool ExisteCodigo(string codigo)
        { 
                gen_producto producto = _tradexEntities.gen_producto.FirstOrDefault(p => p.codigo == codigo);
                if (producto == null)
                    return false;
            return true;
        }


       //Metodo que devuelve la fecha de procesamiento en que se encuentra inventario para una unidad X
       public string GetFechaProcesamientoInv(int idunidad)
       {
           inv_configgeneral unidad = _tradexEntities.inv_configgeneral.FirstOrDefault(a => a.idunidad == idunidad);
           return unidad.fecha != null ? unidad.fecha.Value.ToShortDateString() : null;
       }

       //Metodo que devuelve el id del periodo contable correspondiente a una fecha X
       public int GetIdPeriodoContable(DateTime fecha)
       {
           gen_periodo periodo = _tradexEntities.gen_periodo.FirstOrDefault(a => a.inicio <= fecha && a.fin >= fecha);
           return periodo.idperiodo;
       }

       //devuelve el maximo no de doc que hay en inventario para ese almacen
       // +1 seria el que le toca ahora
       public int GetNumeroDocumentoInv(int idAlmacen, int periodoContable)
       {
           var documento = _tradexEntities.Database.SqlQuery<int>("select isnull(max(numero),0) as num from inv_documento d " +
               "inner join inv_documentoalm da on da.iddocumento = d.iddocumento " +
               "where (idalmacen = @idAlmacen) and ( " + periodoContable + " in " +
               "(select idperiodo from gen_periodo where d.fecha between inicio and fin))", new SqlParameter("@idAlmacen", idAlmacen));

           var x = documento.ToList();
           return int.Parse(x[0].ToString()) + 1;
       }

       internal string GetTasaDeCambio(string idMonedaReal)
       {
           //No importa el subsistema, la tasa pueden haberla cambiado en otro subsistema,yo lo que tengo es que coger la ultima
           /*
                SELECT     *
                   FROM         gen_tasacambio where  idmoneda =3 and fechacambio =(SELECT  Max(fechacambio)
                   FROM         gen_tasacambio where idmoneda =3)
               */
           var tasa = _tradexEntities.Database.SqlQuery<int>("SELECT CAST(tasacambio as int) " +
                  " FROM gen_tasacambio where idmoneda = " + idMonedaReal +
                  " and fechacambio =(SELECT  Max(fechacambio) FROM gen_tasacambio where idmoneda ="+idMonedaReal+")");

           var x = tasa.ToList();
           return x[0].ToString(CultureInfo.InvariantCulture);
       }

        /// <summary>
        /// Devuelve 1 si existe y -1 si no existe
        /// </summary>
        /// <param name="codigoProducto"></param>
        /// <returns></returns>
        internal int ExisteProducto(string codigoProducto)
        {
            var existe = _tradexEntities.Database.SqlQuery<int>("if exists(select p.idproducto from gen_producto p where p.codigo = '" + codigoProducto + "')"+
                "select 1 else select -1 ");

            var x = existe.ToList();
            return int.Parse(x[0].ToString(CultureInfo.InvariantCulture));
        }

        internal bool ExistenciaZeero(string codigoProducto,string idAlmacen)
        {
            try
            {
                  return Existencia(int.Parse(GetIdProducto(codigoProducto)), idAlmacen);
            }
            catch ( Exception e)
            {
                throw new Exception();         
            }
          
        }


        private string GetIdProducto(string codigo)
        {
            string query ="Select idproducto from gen_producto where codigo='" +codigo + "'";
            var existencia = _tradexEntities.Database.SqlQuery<int>(query);
            var x = existencia.ToList();
            return x[0].ToString();
        }

        internal string GetDesc(string codigoProducto)
        {
            try
            {
                string query =
               "Select descripcion from gen_producto where codigo='" +
               codigoProducto + "'";
                var existencia = _tradexEntities.Database.SqlQuery<string>(query);
                var x = existencia.ToList();
                string desc = x[0].ToString();

                string propEncodeString = string.Empty;
                byte[] utf8_Bytes = new byte[desc.Length];
                for (int i = 0; i < desc.Length; ++i)
                    utf8_Bytes[i] = (byte)desc[i];

                propEncodeString = Encoding.UTF8.GetString(utf8_Bytes, 0, utf8_Bytes.Length);
                return propEncodeString;
            }
            catch (Exception )
            {
                return "Sin existencia en versat";
            }
        }

        internal string GetUM(string codigoProducto)
        {
            try
            {
                string query =
                    "SELECT dbo.gen_medida.clave FROM dbo.gen_producto " +
                    "INNER JOIN dbo.gen_medida ON dbo.gen_producto.idmedida = dbo.gen_medida.idmedida " +
                    "WHERE dbo.gen_producto.codigo = '" + codigoProducto + "'";
          
                var existencia = _tradexEntities.Database.SqlQuery<string>(query);
                var x = existencia.ToList();
                string desc = x[0].ToString();

                string propEncodeString = string.Empty;
                byte[] utf8_Bytes = new byte[desc.Length];
                for (int i = 0; i < desc.Length; ++i)
                    utf8_Bytes[i] = (byte)desc[i];

                propEncodeString = Encoding.UTF8.GetString(utf8_Bytes, 0, utf8_Bytes.Length);
                return propEncodeString;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        #endregion

       internal object ComboUMO()
       {
           return Helper.FormarCombo(ListUMO(), "UMO");
       }

        public object ComboCuentaCUP(string idAlmacen)
        {
            return Helper.FormarCombo(ListCuentasCUP(idAlmacen), "CuentasCUP");
        }

        public object ComboSubCUP()
        {
            return Helper.FormarCombo(ListSubCUP(), "SubCUP");
        }

        public object ComboSubCUC()
        {
            return Helper.FormarCombo(ListSubCUC(), "SubCUC");
        }


        public List<object[]> CargarPadresDelClasificador(int entidad)
        {
            string query = "exec sp_executesql N' SELECT cta.idcuenta, cta.clave, cta.activa, " +
           "(SELECT aps.idapertura FROM con_aperturasubordinada aps INNER JOIN con_apertura a " +
           "ON aps.idapertura = a.idapertura WHERE  (aps.idcuenta = cta.idcuenta) " +
           "AND ((a.idunidad = " + entidad + ") OR (a.idunidad IS NULL)))as idApertSub,clavenivel = ctanat.clave," +
           "ctanat.descripcion,ctanat.naturaleza,idmoneda FROM con_cuenta cta " +
           "join con_cuentamoneda m on m.idcuenta =cta.idcuenta " +
           "INNER JOIN con_cuentanat ctanat ON ctanat.idcuenta = cta.idcuenta " +
           "WHERE (cta.idapertura = 1) and cta.activa=1 order by cta.clave'";

            List<object[]> total = SqlDataReader(new[]
            {
                "idcuenta", "clave", "activa", "idApertSub",
                "clavenivel","descripcion","naturaleza","idmoneda"
            }, _tradexEntities.Database.Connection, query);

            return total;
        }

        public List<object[]> CargarHijosDelClasificador(int entidad, string idAperturaSub)
        {
            string query = "exec sp_executesql N' SELECT cta.idcuenta, cta.clave, cta.activa, " +
           "(SELECT aps.idapertura FROM con_aperturasubordinada aps INNER JOIN con_apertura a " +
           "ON aps.idapertura = a.idapertura WHERE  (aps.idcuenta = cta.idcuenta) " +
           "AND ((a.idunidad = " + entidad + ") OR (a.idunidad IS NULL)))as idApertSub,clavenivel = ctanat.clave," +
           "ctanat.descripcion,ctanat.naturaleza,idmoneda FROM con_cuenta cta " +
           "join con_cuentamoneda m on m.idcuenta =cta.idcuenta " +
           "INNER JOIN con_cuentanat ctanat ON ctanat.idcuenta = cta.idcuenta " +
           "WHERE (cta.idapertura = " + idAperturaSub + ") and cta.activa=1 order by cta.clave'";

            List<object[]> total = SqlDataReader(new[]
            {
                "idcuenta", "clave", "activa", "idApertSub",
                "clavenivel","descripcion","naturaleza","idmoneda"
            }, _tradexEntities.Database.Connection, query);

            return total;
        }

        public object Talones()
        {
           
            return Helper.FormarCombo(_facturasEntities.Fac_Talon.ToList(), "talones");
        }


        public object Nombres()
        {
            return Helper.FormarCombo(_facturasEntities.gen_usuario.ToList(), "nombhecho");
        }

        public object ConceptoVentas()
        {
            fac_conceptoventa uno=new fac_conceptoventa();
            uno.codigo = "001";
            uno.descripcion = "Venta de MERCANCIA COSTO MAS HASTA 10% ";
            fac_conceptoventa dos = new fac_conceptoventa();
            dos.codigo = "002";
            dos.descripcion = "VENTA DE OCIOSOS";
            List<fac_conceptoventa> lista=new List<fac_conceptoventa>(){uno,dos};
            return Helper.FormarCombo(lista, "conceptosventa");
        }

        public object Documentos(int numrows,DateTime ?fecha)
        {
            if (fecha == null)
                fecha = DateTime.Now;
            return _facturasEntities.inv_documento.Include(co => co.gen_usuario)
                .Where(a => a.fecha == fecha && a.idsubsistema == 4 && a.idestado == 3).Take(numrows).ToList();
        }

        public object Detalles(int docid)
        {
           List<inv_movimiento> movs=_facturasEntities.inv_documento.Find(docid).inv_movimiento.ToList();
           Tablas.DataTable t = new Tablas.DataTable();
           t.Columns.Add("Almacen");
           t.Columns.Add("Concepto");
           t.Columns.Add("CodProd");
           t.Columns.Add("UM");
           t.Columns.Add("Cantidad");
           t.Columns.Add("Precio CUP");
           t.Columns.Add("Importe CUP");
           t.Columns.Add("Precio CUC");
           t.Columns.Add("Importe CUC");
            string codigoAlmacen = DataContainer.Instance().Almacen;
            foreach (var m in movs)
            {
                Tablas.DataRow row = t.NewRow();
                row["Almacen"] = codigoAlmacen;
                row["Concepto"] = DataContainer.Instance().ConceptoVenta;
                row["CodProd"] = m.gen_producto.codigo;
                row["UM"] = m.gen_producto.gen_medida.clave;
                row["Cantidad"] = m.cantidad;
                


            }

            return t;
        }
    }
}
