using System.ComponentModel;
using System.Windows.Forms;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;

namespace Tradex
{
    partial class ProductDetails
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
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboUmo = new Telerik.WinControls.UI.RadDropDownList();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboSubCUC = new Telerik.WinControls.UI.RadDropDownList();
            this.comboSubCUP = new Telerik.WinControls.UI.RadDropDownList();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCuentaCup = new System.Windows.Forms.Button();
            this.comboCuentaCUC = new Telerik.WinControls.UI.RadDropDownList();
            this.comboCuentaCUP = new Telerik.WinControls.UI.RadDropDownList();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCuentaCuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboUmo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboSubCUC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboSubCUP)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboCuentaCUC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboCuentaCUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ubicación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UMO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboUmo);
            this.groupBox1.Controls.Add(this.txtUbicacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // comboUmo
            // 
            this.comboUmo.Location = new System.Drawing.Point(70, 65);
            this.comboUmo.Name = "comboUmo";
            this.comboUmo.Size = new System.Drawing.Size(120, 20);
            this.comboUmo.TabIndex = 3;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Enabled = false;
            this.txtUbicacion.Location = new System.Drawing.Point(70, 26);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(189, 20);
            this.txtUbicacion.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 386);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.comboSubCUC);
            this.groupBox3.Controls.Add(this.comboSubCUP);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(3, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 124);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Subelementos para moneda:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(255, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboSubCUC
            // 
            this.comboSubCUC.Location = new System.Drawing.Point(44, 62);
            this.comboSubCUC.Name = "comboSubCUC";
            this.comboSubCUC.Size = new System.Drawing.Size(287, 20);
            this.comboSubCUC.TabIndex = 5;
            // 
            // comboSubCUP
            // 
            this.comboSubCUP.Location = new System.Drawing.Point(44, 21);
            this.comboSubCUP.Name = "comboSubCUP";
            this.comboSubCUP.Size = new System.Drawing.Size(287, 20);
            this.comboSubCUP.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(9, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "CUC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(9, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "CUP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCuentaCuc);
            this.groupBox2.Controls.Add(this.btnCuentaCup);
            this.groupBox2.Controls.Add(this.comboCuentaCUC);
            this.groupBox2.Controls.Add(this.comboCuentaCUP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(3, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 122);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuentas para moneda:";
            // 
            // btnCuentaCup
            // 
            this.btnCuentaCup.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCuentaCup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCuentaCup.Location = new System.Drawing.Point(265, 28);
            this.btnCuentaCup.Name = "btnCuentaCup";
            this.btnCuentaCup.Size = new System.Drawing.Size(32, 23);
            this.btnCuentaCup.TabIndex = 6;
            this.btnCuentaCup.Text = "...";
            this.btnCuentaCup.UseVisualStyleBackColor = false;
            this.btnCuentaCup.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboCuentaCUC
            // 
            this.comboCuentaCUC.Location = new System.Drawing.Point(44, 62);
            this.comboCuentaCUC.Name = "comboCuentaCUC";
            this.comboCuentaCUC.Size = new System.Drawing.Size(215, 20);
            this.comboCuentaCUC.TabIndex = 5;
            // 
            // comboCuentaCUP
            // 
            this.comboCuentaCUP.Location = new System.Drawing.Point(43, 28);
            this.comboCuentaCUP.Name = "comboCuentaCUP";
            this.comboCuentaCUP.Size = new System.Drawing.Size(216, 20);
            this.comboCuentaCUP.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "CUC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(9, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CUP";
            // 
            // btnCuentaCuc
            // 
            this.btnCuentaCuc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCuentaCuc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCuentaCuc.Location = new System.Drawing.Point(265, 62);
            this.btnCuentaCuc.Name = "btnCuentaCuc";
            this.btnCuentaCuc.Size = new System.Drawing.Size(32, 23);
            this.btnCuentaCuc.TabIndex = 7;
            this.btnCuentaCuc.Text = "...";
            this.btnCuentaCuc.UseVisualStyleBackColor = false;
            this.btnCuentaCuc.Click += new System.EventHandler(this.btnCuentaCuc_Click);
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 386);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductDetails";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del producto";
            this.Load += new System.EventHandler(this.ProductDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboUmo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboSubCUC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboSubCUP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboCuentaCUC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboCuentaCUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Label label2;
        private GroupBox groupBox1;
        private RadDropDownList comboUmo;
        private TextBox txtUbicacion;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox3;
        private RadDropDownList comboSubCUC;
        private RadDropDownList comboSubCUP;
        private Label label5;
        private Label label6;
        private GroupBox groupBox2;
        private RadDropDownList comboCuentaCUC;
        private RadDropDownList comboCuentaCUP;
        private Label label4;
        private Label label3;
        private Button button1;
        private Button btnCuentaCup;
        private Button btnCuentaCuc;

    }
}