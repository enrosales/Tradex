using System;
using Telerik.WinControls.UI;
using Tradex.Properties;

namespace Tradex
{
    public partial class ConfigProperties : RadForm
    {
       
        public ConfigProperties(bool excel)
        {
            InitializeComponent();

            if (excel)
            {
                groupBox1.Enabled = false;
            }

        }

        private void ConfigProperties_Load(object sender, EventArgs e)
        {
            txtAlmacen.Text = Settings.Default.almacenes;
            txtConcepto.Text = Settings.Default.codigoinv;
            txtUnidad.Text = Settings.Default.unidades;

            txtHojaExcel.Text = Settings.Default.hojaExcel;
            txtFilaInicio.Text = Settings.Default.filaInicio;
            txtFilaFin.Text = Settings.Default.filaFin;
            
            txtColumnaInicio.Text = Settings.Default.columnaInicio;
            txtColumnaFin.Text = Settings.Default.columnaFin;
            txtColumnaCodigo.Text = Settings.Default.columnaCodigo;
            txtColumnaUm.Text = Settings.Default.columnaUm;
            txtColumnaDesc.Text = Settings.Default.columnadescripcion;
            txtColumnaCantidad.Text = Settings.Default.columnaCantidad;
            txtColumnaCUC.Text = Settings.Default.columnaImporteCUC;
            txtColumnaCUP.Text = Settings.Default.columnaImporteMN;

            textBoxpreciomn.Text = Settings.Default.ColumnaPrecioMNFACT;
            textBoxpreciocuc.Text = Settings.Default.ColumnaPrecioCUCFACT;

        }

        private void txtAlmacen_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.almacenes = txtAlmacen.Text;
            Salvar();
        }

        private void txtUnidad_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.unidades = txtUnidad.Text;
            Salvar();
        }

        private void txtConcepto_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.codigoinv = txtConcepto.Text;
            Salvar();
        }

        private void txtColumnaInicio_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.columnaInicio = txtColumnaCodigo.Text;
            Salvar();
        }

        private void txtColumnaFin_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.columnaFin = txtColumnaUm.Text;
            Salvar();
        }

        private void txtFilaInicio_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.filaInicio = txtFilaInicio.Text;
            Salvar();
        }

        private void txtFilaFin_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.filaFin = txtFilaFin.Text;
            Salvar();
        }

        private void txtHojaExcel_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.hojaExcel = txtHojaExcel.Text;
            Salvar();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtColumnaInicio_TextChanged_1(object sender, EventArgs e)
        {
            Settings.Default.columnaInicio = txtColumnaInicio.Text;
            Salvar();
        }

        private void Salvar()
        {
            Settings.Default.Save();
        }

        private void txtColumnaFin_TextChanged_1(object sender, EventArgs e)
        {
            Settings.Default.columnaFin = txtColumnaFin.Text;
            Salvar();
        }

        private void txtColumnaCodigo_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.columnaCodigo = txtColumnaCodigo.Text;
            Salvar();
        }

        private void txtColumnaUm_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.columnaUm = txtColumnaUm.Text;
            Salvar();
        }

        private void txtColumnaDesc_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.columnadescripcion = txtColumnaDesc.Text;
            Salvar();
        }

        private void txtColumnaCantidad_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.columnaCantidad = txtColumnaCantidad.Text;
            Salvar();
        }

        private void txtColumnaCUC_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.columnaImporteCUC = txtColumnaCUC.Text;
            Salvar();
        }

        private void txtColumnaCUP_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.columnaImporteMN = txtColumnaCUP.Text;
            Salvar();
        }

        private void textBoxpreciomn_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.ColumnaPrecioMNFACT = textBoxpreciomn.Text;
            Salvar();
        }

        private void textBoxpreciocuc_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.ColumnaPrecioCUCFACT = textBoxpreciocuc.Text;
            Salvar();
        }

        

    }
}
