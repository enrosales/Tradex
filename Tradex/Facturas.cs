using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Tradex.Models;

namespace Tradex
{
    public partial class Facturas : RadForm
    {
        public Facturas()
        {
            InitializeComponent();
        }

        readonly BackgroundWorker _worker = new BackgroundWorker();
 
        private readonly Versat _versat = new Versat();
        private void Facturas_Load(object sender, EventArgs e)
        {
          //  groupBox4.Paint += PaintBorderlessGroupBox;
          // groupBox1.Paint += PaintBorderlessGroupBox;
            comboEntidadCliente.DataSource = DataContainer.Instance().EntidadesCliente;
            comboTalon.DataSource = _versat.Talones();
            comboNombres.DataSource = _versat.Nombres();
            comboConceptos.DataSource = _versat.ConceptoVentas();
           // radGridView1.DataSource = _versat.Documentos();
            radDateTimeFechaDocumento.Value = DateTime.Now;
            radDateTimeFechaDocumento.ValueChanged += radDateTimeFechaDocumento_ValueChanged;
           
            _worker.DoWork += worker_DoWork;
            _worker.RunWorkerCompleted += worker_RunWorkerCompleted;

            radGridView1.CellDoubleClick += radGridView1_CellDoubleClick;
            new FormStufs().InicializarGrid(radGridView1);
            _worker.RunWorkerAsync();
        }

        void radGridView1_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            Cursor=Cursors.WaitCursor;
            if (comboNombres.SelectedIndex == -1 || comboEntidadCliente.SelectedIndex == -1 ||
                comboTalon.SelectedIndex == -1)
            {
                MessageBox.Show(@"Deben Seleccionar la Entidad, el Talon y el nombre del facturador.");
                Cursor = Cursors.Arrow;
                return;
            }
            DataContainer.Instance().Iddocumento = e.Row.Cells["ID"].Value.ToString();
            DataContainer.Instance().Entidad = ((RadListDataItem)comboEntidadCliente.SelectedItem.Value).Value.ToString();
            DataContainer.Instance().Talon = ((RadListDataItem)comboTalon.SelectedItem.Value).Value.ToString();
            DataContainer.Instance().NombHecho = ((RadListDataItem)comboNombres.SelectedItem.Value).Value.ToString();
            DataContainer.Instance().ConceptoVenta = ((RadListDataItem)comboConceptos.SelectedItem.Value).Value.ToString();
            _versat.Detalles(Convert.ToInt32(e.Row.Cells["ID"].Value.ToString()));
            Cursor = Cursors.Arrow;
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                List<inv_documento> docs = (List<inv_documento>)e.Result;
                DataTable t = new DataTable();
                t.Columns.Add("ID");
                t.Columns.Add("Numero");
                t.Columns.Add("Nombre");
                t.Columns.Add("Descripcion");

                Cursor = Cursors.WaitCursor;
                foreach (var d in docs)
                {
                    DataRow row = t.NewRow();
                    row["ID"] = d.iddocumento;
                    row["Numero"] = d.numero;
                    row["Nombre"] = d.gen_usuario.nombre;
                    row["Descripcion"] = d.descripcion;
                    t.Rows.Add(row);
                }

                radGridView1.DataSource = t;
                new FormStufs().HideColums2(radGridView1, new List<string>() { "ID" });
                radGridView1.MasterTemplate.Refresh(null);
                // new FormStufs().HideSpecial(new[] { "numero","gen_usuario", "descripcion" }, radGridView1);
                Cursor = Cursors.Arrow;
                radDateTimeFechaDocumento.Enabled = true;
            }
           
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Invoke(new MethodInvoker(delegate
                {
                   radDateTimeFechaDocumento.Enabled = false;
                }));
                e.Result = _versat.Documentos(int.Parse(radTextBox3.Text), radDateTimeFechaDocumento.Value);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void txtBuscarEntidad_TextChanged(object sender, EventArgs e)
        {
            Helper.SearchInCombo(comboEntidadCliente, txtBuscarEntidad.Text);
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            Helper.SearchInCombo(comboTalon, radTextBox1.Text);
        }

        private void radTextBox2_TextChanged(object sender, EventArgs e)
        {
            Helper.SearchInCombo(comboNombres, radTextBox2.Text);
        }

        private void radDateTimeFechaDocumento_ValueChanged(object sender, EventArgs e)
        {
            radDateTimeFechaDocumento.Enabled = false;
            _worker.RunWorkerAsync();
        }

        private void radTextBox4_TextChanged(object sender, EventArgs e)
        {
            new FormStufs().BuscarAll(radGridView1, radTextBox4.Text);
        }

        private void comboConceptos_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Helper.SearchInCombo(comboConceptos, radTextBox5.Text);
        }

       
   
        
    
    }
}
