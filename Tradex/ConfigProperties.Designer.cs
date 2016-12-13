using System.ComponentModel;
using System.Windows.Forms;
using Telerik.WinControls.Themes;

namespace Tradex
{
    partial class ConfigProperties
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlmacen = new System.Windows.Forms.TextBox();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtColumnaFin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtColumnaInicio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtColumnaCUP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtColumnaCUC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtColumnaCantidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtColumnaDesc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHojaExcel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFilaFin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColumnaUm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilaInicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtColumnaCodigo = new System.Windows.Forms.TextBox();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Almacén:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Concepto:";
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.Location = new System.Drawing.Point(71, 25);
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.Size = new System.Drawing.Size(100, 20);
            this.txtAlmacen.TabIndex = 3;
            this.txtAlmacen.TextChanged += new System.EventHandler(this.txtAlmacen_TextChanged);
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(420, 28);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(100, 20);
            this.txtConcepto.TabIndex = 4;
            this.txtConcepto.TextChanged += new System.EventHandler(this.txtConcepto_TextChanged);
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(237, 26);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(100, 20);
            this.txtUnidad.TabIndex = 5;
            this.txtUnidad.TextChanged += new System.EventHandler(this.txtUnidad_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUnidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAlmacen);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 76);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración del comprobante";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtColumnaFin);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtColumnaInicio);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtColumnaCUP);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtColumnaCUC);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtColumnaCantidad);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtColumnaDesc);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtHojaExcel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtFilaFin);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtColumnaUm);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFilaInicio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtColumnaCodigo);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 204);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuración del excel";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtColumnaFin
            // 
            this.txtColumnaFin.Location = new System.Drawing.Point(163, 136);
            this.txtColumnaFin.Name = "txtColumnaFin";
            this.txtColumnaFin.Size = new System.Drawing.Size(100, 20);
            this.txtColumnaFin.TabIndex = 21;
            this.txtColumnaFin.TextChanged += new System.EventHandler(this.txtColumnaFin_TextChanged_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Columna fin:";
            // 
            // txtColumnaInicio
            // 
            this.txtColumnaInicio.Location = new System.Drawing.Point(163, 110);
            this.txtColumnaInicio.Name = "txtColumnaInicio";
            this.txtColumnaInicio.Size = new System.Drawing.Size(100, 20);
            this.txtColumnaInicio.TabIndex = 19;
            this.txtColumnaInicio.TextChanged += new System.EventHandler(this.txtColumnaInicio_TextChanged_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Columna inicio:";
            // 
            // txtColumnaCUP
            // 
            this.txtColumnaCUP.Location = new System.Drawing.Point(433, 167);
            this.txtColumnaCUP.Name = "txtColumnaCUP";
            this.txtColumnaCUP.Size = new System.Drawing.Size(100, 20);
            this.txtColumnaCUP.TabIndex = 17;
            this.txtColumnaCUP.TextChanged += new System.EventHandler(this.txtColumnaCUP_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(282, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Columna importe MN:";
            // 
            // txtColumnaCUC
            // 
            this.txtColumnaCUC.Location = new System.Drawing.Point(433, 136);
            this.txtColumnaCUC.Name = "txtColumnaCUC";
            this.txtColumnaCUC.Size = new System.Drawing.Size(100, 20);
            this.txtColumnaCUC.TabIndex = 15;
            this.txtColumnaCUC.TextChanged += new System.EventHandler(this.txtColumnaCUC_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(282, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Columna importe CUC:";
            // 
            // txtColumnaCantidad
            // 
            this.txtColumnaCantidad.Location = new System.Drawing.Point(433, 107);
            this.txtColumnaCantidad.Name = "txtColumnaCantidad";
            this.txtColumnaCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtColumnaCantidad.TabIndex = 13;
            this.txtColumnaCantidad.TextChanged += new System.EventHandler(this.txtColumnaCantidad_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Columna cantidad:";
            // 
            // txtColumnaDesc
            // 
            this.txtColumnaDesc.Location = new System.Drawing.Point(433, 78);
            this.txtColumnaDesc.Name = "txtColumnaDesc";
            this.txtColumnaDesc.Size = new System.Drawing.Size(100, 20);
            this.txtColumnaDesc.TabIndex = 11;
            this.txtColumnaDesc.TextChanged += new System.EventHandler(this.txtColumnaDesc_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Columna descripción:";
            // 
            // txtHojaExcel
            // 
            this.txtHojaExcel.Location = new System.Drawing.Point(163, 25);
            this.txtHojaExcel.Name = "txtHojaExcel";
            this.txtHojaExcel.Size = new System.Drawing.Size(100, 20);
            this.txtHojaExcel.TabIndex = 9;
            this.txtHojaExcel.TextChanged += new System.EventHandler(this.txtHojaExcel_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hoja excel:";
            // 
            // txtFilaFin
            // 
            this.txtFilaFin.Location = new System.Drawing.Point(163, 78);
            this.txtFilaFin.Name = "txtFilaFin";
            this.txtFilaFin.Size = new System.Drawing.Size(100, 20);
            this.txtFilaFin.TabIndex = 7;
            this.txtFilaFin.TextChanged += new System.EventHandler(this.txtFilaFin_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fila fin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Columna código Producto:";
            // 
            // txtColumnaUm
            // 
            this.txtColumnaUm.Location = new System.Drawing.Point(433, 52);
            this.txtColumnaUm.Name = "txtColumnaUm";
            this.txtColumnaUm.Size = new System.Drawing.Size(100, 20);
            this.txtColumnaUm.TabIndex = 5;
            this.txtColumnaUm.TextChanged += new System.EventHandler(this.txtColumnaUm_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Columna UM:";
            // 
            // txtFilaInicio
            // 
            this.txtFilaInicio.Location = new System.Drawing.Point(163, 52);
            this.txtFilaInicio.Name = "txtFilaInicio";
            this.txtFilaInicio.Size = new System.Drawing.Size(100, 20);
            this.txtFilaInicio.TabIndex = 4;
            this.txtFilaInicio.TextChanged += new System.EventHandler(this.txtFilaInicio_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fila inicio:";
            // 
            // txtColumnaCodigo
            // 
            this.txtColumnaCodigo.Location = new System.Drawing.Point(433, 22);
            this.txtColumnaCodigo.Name = "txtColumnaCodigo";
            this.txtColumnaCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtColumnaCodigo.TabIndex = 3;
            this.txtColumnaCodigo.TextChanged += new System.EventHandler(this.txtColumnaCodigo_TextChanged);
            // 
            // ConfigProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigProperties";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parámetros de configuración";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.ConfigProperties_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAlmacen;
        private TextBox txtConcepto;
        private TextBox txtUnidad;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtColumnaUm;
        private Label label5;
        private TextBox txtFilaInicio;
        private Label label6;
        private TextBox txtColumnaCodigo;
        private TextBox txtFilaFin;
        private Label label7;
        private TextBox txtHojaExcel;
        private Label label8;
        private VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private TextBox txtColumnaCUP;
        private Label label12;
        private TextBox txtColumnaCUC;
        private Label label11;
        private TextBox txtColumnaCantidad;
        private Label label10;
        private TextBox txtColumnaDesc;
        private Label label9;
        private TextBox txtColumnaFin;
        private Label label13;
        private TextBox txtColumnaInicio;
        private Label label14;
    }
}