using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Tradex
{
    public partial class RadForm1 : RadForm
    {
        private List<string> servidores;
        private string server;
        private string bd;
        private string user;
        private string pass;
        private Conexion _conexion;
        public RadForm1()
        {
            InitializeComponent();
            _conexion = new Conexion();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            #region locals
            comboServersLocal.Items.Clear();
            if (radioButtonLocal.Checked)
            {
                panelLocal.Visible = true;
                panelRemoto.Visible = false;
                Thread T = new Thread(LlenarLocales);
                T.Start();
                while (!T.IsAlive)
                    Thread.Sleep(1);
                T.Join();
                if (servidores.Count == 0)
                {
                    MessageBox.Show("No hemos encontrado Servidores SQL instalados en su PC.Contacte al administrador del sistema, vuela a intertarlo mas tarde o teclee el servidor manualmente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboServersLocal.Enabled = true;
                    txtPassw.Enabled = true;
                    txtUser.Enabled = true;
                    btnConectar.Enabled = true;
                }
                else
                {
                    comboServersLocal.Enabled = true;
                    txtPassw.Enabled = true;
                    txtUser.Enabled = true;
                    btnConectar.Enabled = true;
                    for (int i = 0; i < servidores.Count; i++)
                    {
                        comboServersLocal.Items.Add(servidores[i]);
                    }
                }
                comboServersLocal.Enabled = true;
                txtPassw.Enabled = true;
                txtUser.Enabled = true;
                btnConectar.Enabled = true;
            }
            #endregion
           
            Cursor=Cursors.Arrow;
        }

        public void LlenarLista()
        {
            servidores = _conexion.GetServersNet();

        }

        public void LlenarLocales()
        {
           servidores = _conexion.Locals();
        }

       

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            
            #region Remotos
            if (radioButtonRemoto.Checked)
            {
                comboBoxServerRemoto.Enabled = false;
                comboBoxServerRemoto.Items.Clear();
                panelLocal.Visible = true;
                panelRemoto.Visible = true;
                Thread T = new Thread(LlenarLista);
                T.Start();
                while (!T.IsAlive)
                    Thread.Sleep(1);
                T.Join();
                if (servidores.Count == 0)
                {
                    MessageBox.Show("No hemos encontrado Servidores SQL en la red.Contacte al administrador del sistema, vuela a intertarlo mas tarde o teclee el servidor manualmente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxServerRemoto.Enabled = true;
                    txtUsuario.Enabled = true;
                    txtPassword.Enabled = true;
                    button1.Enabled = true;

                }
                else
                {
                    comboBoxServerRemoto.Enabled = true;
                    txtUsuario.Enabled = true;
                    txtPassword.Enabled = true;
                    button1.Enabled = true;
                    for (int i = 0; i < servidores.Count; i++)
                    {
                        comboBoxServerRemoto.Items.Add(servidores[i]);
                    }
                }


            }
            #endregion
            Cursor = Cursors.Arrow;
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            comboBDRemoto.KeyPress += comboBox3_KeyPress;
          //  textBox3.KeyPress += textBox3_KeyPress;
            comboBasesDatos.KeyPress += comboBox2_KeyPress;
          //  txtPassword.KeyPress += textBox2_KeyPress;
            radioButtonLocal.Checked = true;
            comboBDRemoto.Enabled = false;
            comboBasesDatos.Enabled = false;

        }

       void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button4.PerformClick();
            }
        }

       void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button3.PerformClick();
            }
        }


        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtPassw.Enabled = false;
                txtUser.Enabled = false;
                comboServersLocal.Enabled = false;
                btnConectar.Enabled = false;
                user = txtUser.Text;
                pass = txtPassw.Text;
                CargarDefaultLocal();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            button4.Enabled = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                bd = comboBasesDatos.SelectedItem.ToString();
                DataContainer.Instance().Servidor = server;
                DataContainer.Instance().Bd = bd;
                DataContainer.Instance().Usuario = user;
                DataContainer.Instance().Password = pass;
                DataContainer.Instance().ConectionString = "data source=" + comboServersLocal.SelectedItem + ";" +
                "initial catalog=" + comboBasesDatos.SelectedItem + ";persist security info=True;user id="+user+";password="+pass+";MultipleActiveResultSets=True;";

                Form2 f = new Form2();

                Hide();
                f.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxServerRemoto.Items.Count == 0 && comboBoxServerRemoto.Text ==null)
                {
                    MessageBox.Show("Debe escribir el nombre del servidor en la red.");
                    return;
                }
                txtUsuario.Enabled = false;
                txtPassword.Enabled = false;
                comboBoxServerRemoto.Enabled = false;
                button1.Enabled = false;
                user = txtUsuario.Text;
                pass = txtPassword.Text;
               
              //  comboBoxServerRemoto.Items.Clear();

                CargarDefaultRemoto();

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            button3.Enabled = true;
        }

        //boton de conectarse a una bd remota aqui se muestra el otro form...
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                bd = comboBDRemoto.SelectedItem.ToString();
                DataContainer.Instance().Servidor = server;
                DataContainer.Instance().Bd = bd;
                DataContainer.Instance().Usuario = user;
                DataContainer.Instance().Password = pass;
                DataContainer.Instance().ConectionString = "data source=" + comboBoxServerRemoto.SelectedItem + ";" +
                "initial catalog=" + comboBDRemoto.SelectedItem + ";persist security info=True;user id="+user+";password="+pass+";MultipleActiveResultSets=True;";
                Form2 f = new Form2();
                Hide();
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           

        }

     
        private void radMenuItem2_Click_1(object sender, EventArgs e)
        {
            new ConfigProperties(false).ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            comboServersLocal.Enabled = true;
            txtUser.Enabled = true;
            txtPassw.Enabled = true;
            comboBasesDatos.Enabled = true;
            btnConectar.Enabled = true;
          //  comboServersLocal.Items.Clear();
            comboBDRemoto.Enabled = comboBasesDatos.Enabled = false;
            
            CargarDefaultLocal();

        }

        private void CargarDefaultLocal()
        {
            try
            {
                if (comboServersLocal.Text.Length > 0)
                {
                    comboBasesDatos.Items.Clear();
                    if (txtPassw.Text.Length == 0 || txtUser.Text.Length == 0)
                        throw new Exception("Ingrese el Usuario y la Contraseña");

                    comboBasesDatos.Enabled = true;
                    List<string> bases = new List<string>();

                    if (comboServersLocal.SelectedIndex == -1)
                        server = comboServersLocal.Text;
                    else
                        server = comboServersLocal.SelectedItem.ToString();
                   
                    bases = _conexion.BasesDatos(server, txtUser.Text, txtPassw.Text);
                    
                    for (int i = 0; i < bases.Count; i++)
                    {
                        comboBasesDatos.Items.Add(bases[i]);
                    }
                    // comboServersLocal.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Debe especificar el servidor de bases de datos");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CargarDefaultRemoto()
        {
            comboBDRemoto.Items.Clear();
            if (txtUsuario.Text.Length == 0 || txtPassword.Text.Length == 0)
                throw new Exception("Ingrese el Usuario y la Contraseña");
               comboBDRemoto.Enabled = true;
                List<string> bases = new List<string>();
            if (comboBoxServerRemoto.SelectedIndex == -1)
            {
                if (comboBoxServerRemoto.Text == "")
                    server = "-1";
                else
                server = comboBoxServerRemoto.Text;
            }
            else
                server = comboBoxServerRemoto.SelectedItem.ToString();

            try
            {
                bases = _conexion.BasesDatos(server, txtUsuario.Text, txtPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                if (bases != null)
                {
                    for (int i = 0; i < bases.Count; i++)
                    {
                        comboBDRemoto.Items.Add(bases[i]);
                    } 
                }
                
           }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            comboBoxServerRemoto.Enabled = true;
            txtUsuario.Enabled = true;
            txtPassword.Enabled = true;
            comboBDRemoto.Enabled = true;
            button1.Enabled = true;
            CargarDefaultRemoto();
            comboBDRemoto.Enabled = comboBasesDatos.Enabled = false;
        }

        private void txtPassw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (int) Keys.Enter)
                btnConectar.PerformClick();
        }

        private void comboBasesDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
                button4.PerformClick();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
                button1.PerformClick();
        }

        private void comboBDRemoto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
                button3.PerformClick();
        }
    }
}
