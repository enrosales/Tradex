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
    public partial class FacturasCopy : RadForm
    {
        public FacturasCopy()
        {
            InitializeComponent();
        }

   
 
        private readonly Versat _versat = new Versat();
        private void Facturas_Load(object sender, EventArgs e)
        {
          //  groupBox4.Paint += PaintBorderlessGroupBox;
          // groupBox1.Paint += PaintBorderlessGroupBox;
            comboEntidadCliente.DataSource = DataContainer.Instance().EntidadesCliente;
            comboTalon.DataSource = _versat.Talones();
            comboNombres.DataSource = _versat.Nombres();
            comboConceptos.DataSource = _versat.ConceptoVentas();
            this.comboEntidadCliente.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.comboEntidadCliente_SelectedIndexChanged);
            this.comboConceptos.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.comboConceptos_SelectedIndexChanged);
            this.comboTalon.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.comboTalon_SelectedIndexChanged);
            this.comboNombres.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.comboNombres_SelectedIndexChanged);
        }
        private void txtBuscarEntidad_TextChanged(object sender, EventArgs e)
        {
            Helper.SearchInCombo(comboEntidadCliente, txtBuscarEntidad.Text);
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            Helper.SearchInCombo(comboTalon, radTextBox1.Text);
        }

      
        private void radTextBox2_TextChanged_1(object sender, EventArgs e)
        {
            Helper.SearchInCombo(comboNombres, radTextBox2.Text);
        }

        private void radTextBox5_TextChanged(object sender, EventArgs e)
        {
            Helper.SearchInCombo(comboConceptos, radTextBox5.Text);
        }

        protected override void OnClosed(EventArgs e)
        {
            UpdateValues();
        }

        private void UpdateValues()
        {
            DataContainer.Instance().Entidad = ((RadListDataItem)comboEntidadCliente.SelectedItem.Value).Value.ToString().Split('|')[0];
            DataContainer.Instance().Talon = ((RadListDataItem)comboTalon.SelectedItem.Value).Value.ToString();
            DataContainer.Instance().NombHecho = ((RadListDataItem)comboNombres.SelectedItem.Value).Value.ToString();
            DataContainer.Instance().ConceptoVenta = ((RadListDataItem)comboConceptos.SelectedItem.Value).Value.ToString();
        }

        private void comboEntidadCliente_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            UpdateValues();
        }

        private void comboConceptos_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            UpdateValues();
        }

        private void comboTalon_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            UpdateValues();
        }

        private void comboNombres_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            UpdateValues();
        }


    }
}
