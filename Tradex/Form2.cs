using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using PositionChangedEventArgs = Telerik.WinControls.UI.Data.PositionChangedEventArgs;

namespace Tradex
{
    public partial class Form2 : RadForm
    {


        private readonly Versat _versat = new Versat();

        private RadListDataItem idAlmacen, idConcepto, claveCuentaMn, claveCuentaMlc, entidad, monedaMca;

        private string nroDoc, monedaContable, conceptoId;

        private void Form2_Load(object sender, EventArgs e)
        {
           
            try
            {
                //Poniendo como fecha en el componente fecha la fecha actual de la pc
                radDateTimeFechaDocumento.Value = DateTime.Now;

                comboconceptos.DataSource = _versat.ComboConceptos();
                comboalmacenes.DataSource = _versat.ComboAlmacenes();
                combounidades.DataSource = _versat.ComboUnidades();
                //idUnidad
                var idUnidad = (RadListDataItem)combounidades.SelectedItem.DataBoundItem;
                //idAlmacen
                 idAlmacen = (RadListDataItem)comboalmacenes.SelectedItem.DataBoundItem;
                //idConcepto
                 idConcepto = (RadListDataItem) comboconceptos.SelectedItem.DataBoundItem;

                fechaProcesamientoDataToDisplay.Text = _versat.GetFechaProcesamientoInv(int.Parse(idUnidad.Value.ToString()));
                //periodo contable Ej: 114. Es el periodo de octubre de 2016 a noviembre 2016
                var periodoContable = _versat.GetIdPeriodoContable(Convert.ToDateTime(fechaProcesamientoDataToDisplay.Text));

                nroDoc = _versat.GetNumeroDocumentoInv(int.Parse(idAlmacen.Value.ToString().Split('-')[0]), periodoContable).ToString();
                labelNoDocDataToDisplay.Text = nroDoc;
               
                //poniendo en este combo todas las monedas alternativas para elegir
                comboMonedas.DataSource = _versat.ComboMonedas();
                monedaContable = _versat.MonedaContable();
                radLabelMonedaContable.Text = monedaContable;

                // en el value del idConcepto esta guardado idConcepto-codigo por eso spliteo y cojo [0]
                conceptoId = idConcepto.Value.ToString().Split('-')[0];
                //Las cuentas en MLC configuradas para ese subsistema para que elijan
                comboCuentaMlc.DataSource = _versat.ComboCuentasMlc(idUnidad.Value.ToString(), conceptoId);
                //Las cuentas en MN configuradas para ese subsistema para que elijan
                comboCuentaMn.DataSource = _versat.ComboCuentasMn(idUnidad.Value.ToString(), conceptoId);
               //lleno el combo con las entidadespara que el usuario seleccione
               comboEntidadCliente.DataSource = _versat.ComboEntidadCliente();
              //  MessageBox.Show(radDateTimeFechaDocumento.Value.ToShortDateString());

              //  var codigoCliente = (RadListDataItem) comboEntidadCliente.SelectedItem.DataBoundItem;
                
              //  MessageBox.Show(codigoCliente.Value.ToString());

                //Esta es la consulta que se genera cdo se levanta la ventana de agregar un servicio a una recepcion

                /*
                 * select E.identidad,E.codigo+'' ''+E.nombre as Nentidad,S.idservicio,S.descripcion,
                  M.idmoneda,M.Nombre,ISNULL(DS.idtasa,0) as idtasa,ISNULL(T.tasacambio,1) as tasa,
                  Importe,DS.iddocumentoserv,ISNULL(T.tasacambio,1) /M.factor as TasaReal
                from inv_documentoserv DS
                inner join gen_entidad E on DS.identidad=E.identidad
                inner join inv_servasoc S on DS.idservicio=S.idservicio
                inner join gen_moneda M on DS.idmoneda=M.idmoneda
                left join gen_tasacambio T on DS.idtasa=T.idtasa
                where iddocumento=@P1
                 */
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);     
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
        {
            
        }
       
        private void txtBuscarEntidad_TextChanged(object sender, EventArgs e)
        {
            Helper.SearchInCombo(comboEntidadCliente, txtBuscarEntidad.Text);
        }

        private void comboMonedas_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
        {
            try
            {
                //idMoneda viene conformado asi: idMoneda-Nombre
                var idMoneda = (RadListDataItem)comboMonedas.SelectedItem.DataBoundItem;
                string idMonedaSintratar = idMoneda.Value.ToString();
                //pico por este caracter (-) y cojo en cero el idMoneda
                //en el value de la moneda tengo idmoneda-nombre
                string idMonedaReal = idMonedaSintratar.Split('-')[0];

                //tasa de cambio
                //idsubsistema=>4 es inventario
                labelTasaCambioDataToDisplay.Text = _versat.GetTasaDeCambio(idMonedaReal);
              //  groupBoxPesosOtro.Text = idMonedaSintratar.Split('-')[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            string dia = radDateTimeFechaDocumento.Value.Day.ToString();
            string mes = radDateTimeFechaDocumento.Value.Month.ToString();
            string anno = radDateTimeFechaDocumento.Value.Year.ToString();
            //Fecha=31/10/2016
            string fecha = string.Format("{0}/{1}/{2}", dia, mes, anno);

            claveCuentaMlc = (RadListDataItem)comboCuentaMlc.SelectedItem.DataBoundItem;
            claveCuentaMn = (RadListDataItem)comboCuentaMn.SelectedItem.DataBoundItem;
            entidad = (RadListDataItem)comboEntidadCliente.SelectedItem.DataBoundItem;
            monedaMca = (RadListDataItem)comboMonedas.SelectedItem.DataBoundItem;
            //idUnidad
            var idUnidad = (RadListDataItem)combounidades.SelectedItem.DataBoundItem;
            int idUnidadReal = int.Parse(idUnidad.Value.ToString());
            //Almacen: Value = x.idalmacen + "-" + x.codigo,
            new ExcelForm(_versat, idAlmacen.Value.ToString().Split('-')[0], idAlmacen.Value.ToString().Split('-')[1], idConcepto.Value.ToString().Split('-')[1], nroDoc, txtNoDeControl.Text, fecha,
                claveCuentaMn.Value.ToString(),claveCuentaMlc.Value.ToString(), txtComentario.Text,
                entidad.Value.ToString(),radLabelMonedaContable.Text,monedaMca.Text, labelTasaCambioDataToDisplay.Text,idUnidadReal).ShowDialog();
        }

        private void parámetrosDeConfiguraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConfigProperties(true).ShowDialog();
        }
    }
}
