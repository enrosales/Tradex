using System.ComponentModel;
using System.Windows.Forms;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;

namespace Tradex
{
    partial class RadForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            this.radioButtonRemoto = new System.Windows.Forms.RadioButton();
            this.radioButtonLocal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRemoto = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxServerRemoto = new System.Windows.Forms.ComboBox();
            this.comboBDRemoto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelLocal = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassw = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.comboBasesDatos = new System.Windows.Forms.ComboBox();
            this.comboServersLocal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.panelRemoto.SuspendLayout();
            this.panelLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonRemoto
            // 
            this.radioButtonRemoto.AutoSize = true;
            this.radioButtonRemoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRemoto.Location = new System.Drawing.Point(351, 38);
            this.radioButtonRemoto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioButtonRemoto.Name = "radioButtonRemoto";
            this.radioButtonRemoto.Size = new System.Drawing.Size(74, 20);
            this.radioButtonRemoto.TabIndex = 16;
            this.radioButtonRemoto.Text = "Remoto";
            this.radioButtonRemoto.UseVisualStyleBackColor = true;
            this.radioButtonRemoto.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonLocal
            // 
            this.radioButtonLocal.AutoSize = true;
            this.radioButtonLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLocal.Location = new System.Drawing.Point(102, 38);
            this.radioButtonLocal.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioButtonLocal.Name = "radioButtonLocal";
            this.radioButtonLocal.Size = new System.Drawing.Size(59, 20);
            this.radioButtonLocal.TabIndex = 15;
            this.radioButtonLocal.Text = "Local";
            this.radioButtonLocal.UseVisualStyleBackColor = true;
            this.radioButtonLocal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, -38);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "A que tipo de Servidor desea Conectarse?";
            // 
            // panelRemoto
            // 
            this.panelRemoto.Controls.Add(this.linkLabel2);
            this.panelRemoto.Controls.Add(this.button3);
            this.panelRemoto.Controls.Add(this.label7);
            this.panelRemoto.Controls.Add(this.label6);
            this.panelRemoto.Controls.Add(this.txtPassword);
            this.panelRemoto.Controls.Add(this.txtUsuario);
            this.panelRemoto.Controls.Add(this.button1);
            this.panelRemoto.Controls.Add(this.comboBoxServerRemoto);
            this.panelRemoto.Controls.Add(this.comboBDRemoto);
            this.panelRemoto.Controls.Add(this.label5);
            this.panelRemoto.Controls.Add(this.label4);
            this.panelRemoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRemoto.Location = new System.Drawing.Point(6, 74);
            this.panelRemoto.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.panelRemoto.Name = "panelRemoto";
            this.panelRemoto.Size = new System.Drawing.Size(442, 298);
            this.panelRemoto.TabIndex = 18;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(29, 22);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(131, 16);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Habilitar Parámetros";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Enabled = false;
            this.button3.Image = global::Tradex.Properties.Resources._104;
            this.button3.Location = new System.Drawing.Point(397, 255);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 32);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(158, 193);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(233, 22);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "Sql2016!";
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(158, 126);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(233, 22);
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.Text = "sa";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Enabled = false;
            this.button1.Image = global::Tradex.Properties.Resources._147___Copy;
            this.button1.Location = new System.Drawing.Point(399, 188);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 33);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBoxServerRemoto
            // 
            this.comboBoxServerRemoto.AllowDrop = true;
            this.comboBoxServerRemoto.Enabled = false;
            this.comboBoxServerRemoto.FormattingEnabled = true;
            this.comboBoxServerRemoto.Location = new System.Drawing.Point(158, 56);
            this.comboBoxServerRemoto.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.comboBoxServerRemoto.Name = "comboBoxServerRemoto";
            this.comboBoxServerRemoto.Size = new System.Drawing.Size(233, 24);
            this.comboBoxServerRemoto.TabIndex = 5;
            // 
            // comboBDRemoto
            // 
            this.comboBDRemoto.Enabled = false;
            this.comboBDRemoto.FormattingEnabled = true;
            this.comboBDRemoto.Location = new System.Drawing.Point(161, 260);
            this.comboBDRemoto.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.comboBDRemoto.Name = "comboBDRemoto";
            this.comboBDRemoto.Size = new System.Drawing.Size(230, 24);
            this.comboBDRemoto.TabIndex = 4;
            this.comboBDRemoto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBDRemoto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Base de Datos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Servidor en la Red";
            // 
            // panelLocal
            // 
            this.panelLocal.Controls.Add(this.button4);
            this.panelLocal.Controls.Add(this.linkLabel1);
            this.panelLocal.Controls.Add(this.btnConectar);
            this.panelLocal.Controls.Add(this.label8);
            this.panelLocal.Controls.Add(this.label9);
            this.panelLocal.Controls.Add(this.txtPassw);
            this.panelLocal.Controls.Add(this.txtUser);
            this.panelLocal.Controls.Add(this.comboBasesDatos);
            this.panelLocal.Controls.Add(this.comboServersLocal);
            this.panelLocal.Controls.Add(this.label3);
            this.panelLocal.Controls.Add(this.label2);
            this.panelLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLocal.Location = new System.Drawing.Point(6, 63);
            this.panelLocal.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelLocal.Name = "panelLocal";
            this.panelLocal.Size = new System.Drawing.Size(444, 314);
            this.panelLocal.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Enabled = false;
            this.button4.Image = global::Tradex.Properties.Resources._104;
            this.button4.Location = new System.Drawing.Point(381, 263);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 30);
            this.button4.TabIndex = 16;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(35, 33);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(130, 16);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Habilitar parámetros";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.White;
            this.btnConectar.Enabled = false;
            this.btnConectar.Image = global::Tradex.Properties.Resources._147___Copy;
            this.btnConectar.Location = new System.Drawing.Point(380, 194);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(37, 32);
            this.btnConectar.TabIndex = 15;
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(57, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Contraseña";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(79, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Usuario";
            // 
            // txtPassw
            // 
            this.txtPassw.Enabled = false;
            this.txtPassw.Location = new System.Drawing.Point(140, 198);
            this.txtPassw.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtPassw.Name = "txtPassw";
            this.txtPassw.PasswordChar = '•';
            this.txtPassw.Size = new System.Drawing.Size(233, 22);
            this.txtPassw.TabIndex = 12;
            this.txtPassw.Text = "Sql2016!";
            this.txtPassw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassw_KeyPress);
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(140, 135);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(233, 22);
            this.txtUser.TabIndex = 11;
            this.txtUser.Text = "sa";
            // 
            // comboBasesDatos
            // 
            this.comboBasesDatos.Enabled = false;
            this.comboBasesDatos.FormattingEnabled = true;
            this.comboBasesDatos.Location = new System.Drawing.Point(141, 263);
            this.comboBasesDatos.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.comboBasesDatos.Name = "comboBasesDatos";
            this.comboBasesDatos.Size = new System.Drawing.Size(231, 24);
            this.comboBasesDatos.TabIndex = 3;
            this.comboBasesDatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBasesDatos_KeyPress);
            // 
            // comboServersLocal
            // 
            this.comboServersLocal.Enabled = false;
            this.comboServersLocal.FormattingEnabled = true;
            this.comboServersLocal.Location = new System.Drawing.Point(140, 80);
            this.comboServersLocal.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.comboServersLocal.Name = "comboServersLocal";
            this.comboServersLocal.Size = new System.Drawing.Size(233, 24);
            this.comboServersLocal.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(40, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Base de Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Servidor Local";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "Archivo";
            this.radMenuItem1.AccessibleName = "Archivo";
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuSeparatorItem1,
            this.radMenuItem2});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Modificar";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.AccessibleDescription = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.AccessibleName = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "Licencia";
            this.radMenuItem2.AccessibleName = "Licencia";
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Parámetros de configuración";
            this.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem2.Click += new System.EventHandler(this.radMenuItem2_Click_1);
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.radMenu1.Size = new System.Drawing.Size(472, 29);
            this.radMenu1.TabIndex = 20;
            this.radMenu1.Text = "radMenu1";
            this.radMenu1.ThemeName = "TelerikMetro";
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 408);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.radioButtonRemoto);
            this.Controls.Add(this.radioButtonLocal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelRemoto);
            this.Controls.Add(this.panelLocal);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Conectar con Base de Datos";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            this.panelRemoto.ResumeLayout(false);
            this.panelRemoto.PerformLayout();
            this.panelLocal.ResumeLayout(false);
            this.panelLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

       

        #endregion

        private RadioButton radioButtonRemoto;
        private RadioButton radioButtonLocal;
        private Label label1;
        private Panel panelRemoto;
        private Button button3;
        private Label label7;
        private Label label6;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Button button1;
        private ComboBox comboBoxServerRemoto;
        private ComboBox comboBDRemoto;
        private Label label5;
        private Label label4;
        private Panel panelLocal;
        private Button button4;
        private Button btnConectar;
        private Label label8;
        private Label label9;
        private TextBox txtPassw;
        private TextBox txtUser;
        private ComboBox comboBasesDatos;
        private ComboBox comboServersLocal;
        private Label label3;
        private Label label2;
        private TelerikMetroTheme telerikMetroTheme1;
        private VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private RadMenuItem radMenuItem1;
        private RadMenuSeparatorItem radMenuSeparatorItem1;
        private RadMenuItem radMenuItem2;
        private RadMenu radMenu1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
     
    }
}
