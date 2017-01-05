using System.ComponentModel;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Tradex
{
    partial class ExcelForm
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
            this.btnAbrirExcel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.txtColumnaMN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtColumnaCUC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtColumnaCant = new System.Windows.Forms.TextBox();
            this.txtColumnaDesc = new System.Windows.Forms.TextBox();
            this.txtColumnaUM = new System.Windows.Forms.TextBox();
            this.txtColumnaCodigoP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtHojaExcel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilaFin = new System.Windows.Forms.TextBox();
            this.txtFilaInicio = new System.Windows.Forms.TextBox();
            this.txtColumnFin = new System.Windows.Forms.TextBox();
            this.txtColumnInicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirExcel
            // 
            this.btnAbrirExcel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAbrirExcel.Location = new System.Drawing.Point(603, 53);
            this.btnAbrirExcel.Name = "btnAbrirExcel";
            this.btnAbrirExcel.Size = new System.Drawing.Size(129, 23);
            this.btnAbrirExcel.TabIndex = 0;
            this.btnAbrirExcel.Text = "Abrir Excel";
            this.btnAbrirExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirExcel.UseVisualStyleBackColor = true;
            this.btnAbrirExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.02804F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.97196F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 535);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.txtColumnaMN);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtColumnaCUC);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtColumnaCant);
            this.groupBox1.Controls.Add(this.txtColumnaDesc);
            this.groupBox1.Controls.Add(this.txtColumnaUM);
            this.groupBox1.Controls.Add(this.txtColumnaCodigoP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.btnAbrirExcel);
            this.groupBox1.Controls.Add(this.txtHojaExcel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFilaFin);
            this.groupBox1.Controls.Add(this.txtFilaInicio);
            this.groupBox1.Controls.Add(this.txtColumnFin);
            this.groupBox1.Controls.Add(this.txtColumnInicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros del excel";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(603, 127);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(275, 23);
            this.progressBar1.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(747, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Datos de ubicación";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExportar.Location = new System.Drawing.Point(603, 89);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(131, 23);
            this.btnExportar.TabIndex = 23;
            this.btnExportar.Text = "Exportar documentos";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // txtColumnaMN
            // 
            this.txtColumnaMN.Enabled = false;
            this.txtColumnaMN.Location = new System.Drawing.Point(514, 89);
            this.txtColumnaMN.Name = "txtColumnaMN";
            this.txtColumnaMN.Size = new System.Drawing.Size(66, 20);
            this.txtColumnaMN.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(392, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Columna importe MN:";
            // 
            // txtColumnaCUC
            // 
            this.txtColumnaCUC.Enabled = false;
            this.txtColumnaCUC.Location = new System.Drawing.Point(514, 54);
            this.txtColumnaCUC.Name = "txtColumnaCUC";
            this.txtColumnaCUC.Size = new System.Drawing.Size(66, 20);
            this.txtColumnaCUC.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(388, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Columna importe CUC:";
            // 
            // txtColumnaCant
            // 
            this.txtColumnaCant.Enabled = false;
            this.txtColumnaCant.Location = new System.Drawing.Point(514, 24);
            this.txtColumnaCant.Name = "txtColumnaCant";
            this.txtColumnaCant.Size = new System.Drawing.Size(66, 20);
            this.txtColumnaCant.TabIndex = 18;
            // 
            // txtColumnaDesc
            // 
            this.txtColumnaDesc.Enabled = false;
            this.txtColumnaDesc.Location = new System.Drawing.Point(313, 111);
            this.txtColumnaDesc.Name = "txtColumnaDesc";
            this.txtColumnaDesc.Size = new System.Drawing.Size(66, 20);
            this.txtColumnaDesc.TabIndex = 17;
            // 
            // txtColumnaUM
            // 
            this.txtColumnaUM.Enabled = false;
            this.txtColumnaUM.Location = new System.Drawing.Point(313, 82);
            this.txtColumnaUM.Name = "txtColumnaUM";
            this.txtColumnaUM.Size = new System.Drawing.Size(66, 20);
            this.txtColumnaUM.TabIndex = 16;
            // 
            // txtColumnaCodigoP
            // 
            this.txtColumnaCodigoP.Enabled = false;
            this.txtColumnaCodigoP.Location = new System.Drawing.Point(313, 52);
            this.txtColumnaCodigoP.Name = "txtColumnaCodigoP";
            this.txtColumnaCodigoP.Size = new System.Drawing.Size(66, 20);
            this.txtColumnaCodigoP.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(408, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Columna cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(193, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Columna descripción:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(230, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Columna UM:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(206, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Columna código p:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.Location = new System.Drawing.Point(600, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(116, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Modificar Parámetros";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtHojaExcel
            // 
            this.txtHojaExcel.Enabled = false;
            this.txtHojaExcel.Location = new System.Drawing.Point(114, 22);
            this.txtHojaExcel.Name = "txtHojaExcel";
            this.txtHojaExcel.Size = new System.Drawing.Size(66, 20);
            this.txtHojaExcel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(29, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hoja del Excel:";
            // 
            // txtFilaFin
            // 
            this.txtFilaFin.Enabled = false;
            this.txtFilaFin.Location = new System.Drawing.Point(313, 22);
            this.txtFilaFin.Name = "txtFilaFin";
            this.txtFilaFin.Size = new System.Drawing.Size(66, 20);
            this.txtFilaFin.TabIndex = 7;
            // 
            // txtFilaInicio
            // 
            this.txtFilaInicio.Enabled = false;
            this.txtFilaInicio.Location = new System.Drawing.Point(114, 114);
            this.txtFilaInicio.Name = "txtFilaInicio";
            this.txtFilaInicio.Size = new System.Drawing.Size(66, 20);
            this.txtFilaInicio.TabIndex = 6;
            // 
            // txtColumnFin
            // 
            this.txtColumnFin.Enabled = false;
            this.txtColumnFin.Location = new System.Drawing.Point(114, 85);
            this.txtColumnFin.Name = "txtColumnFin";
            this.txtColumnFin.Size = new System.Drawing.Size(66, 20);
            this.txtColumnFin.TabIndex = 5;
            // 
            // txtColumnInicio
            // 
            this.txtColumnInicio.Enabled = false;
            this.txtColumnInicio.Location = new System.Drawing.Point(114, 55);
            this.txtColumnInicio.Name = "txtColumnInicio";
            this.txtColumnInicio.Size = new System.Drawing.Size(66, 20);
            this.txtColumnInicio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(246, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fila de fin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(35, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fila de inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Columna de fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Columna de inicio:";
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(3, 169);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(894, 363);
            this.radGridView1.TabIndex = 2;
            this.radGridView1.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellDoubleClick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // ExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 535);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ExcelForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lectura de excel";
            this.ThemeName = "ControlDefault";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExcelForm_FormClosed);
            this.Load += new System.EventHandler(this.ExcelForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAbrirExcel;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TextBox txtFilaFin;
        private TextBox txtFilaInicio;
        private TextBox txtColumnFin;
        private TextBox txtColumnInicio;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtHojaExcel;
        private Label label5;
        private LinkLabel linkLabel1;
        private RadGridView radGridView1;
        private TextBox txtColumnaCant;
        private TextBox txtColumnaDesc;
        private TextBox txtColumnaUM;
        private TextBox txtColumnaCodigoP;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtColumnaMN;
        private Label label11;
        private TextBox txtColumnaCUC;
        private Label label10;
        private Button btnExportar;
        private Button button2;
        private BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar1;
        
    }
}