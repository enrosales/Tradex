using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Tradex
{
    public class Conexion
    {
        
        private SqlConnection _conexion;

       public void ConectarBd(string server, string user, string pass)
        {
            try
            {
                _conexion = new SqlConnection("Server=" + server + ";User ID=" + user + ";Password=" + pass + ";Trusted_Connection=False");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #region Conectividad
        public List<string> GetServersNet()
        {
            List<string> servers = new List<string>();
            try
            {
                DataTable x = null;
                SqlClientFactory fabrica = SqlClientFactory.Instance;
                bool bandera = fabrica.CanCreateDataSourceEnumerator;
                if (bandera)
                {
                    SqlDataSourceEnumerator servidores = SqlDataSourceEnumerator.Instance;
                    x = servidores.GetDataSources();
                    int s = x.Rows.Count;
                    DataRow r = x.NewRow();
                    for (int i = 0; i < x.Rows.Count; i++)
                    {
                        r = x.Rows[i];

                        if (string.IsNullOrEmpty(r["InstanceName"].ToString()))
                            servers.Add(r["ServerName"].ToString());
                        else
                            servers.Add(r["ServerName"] + "\\" + r["InstanceName"]);

                    }
                }
            }

            catch (Exception)
            {
                throw new Exception("Ha ocurrido un Error Mientras se Accedía a la Red");
            }
            return servers;
        }

        public List<string> Locals()
        {
            List<string> serveres = new List<string>();
            RegistryKey RegKey = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Microsoft SQL Server");
       
            String[] Instancias = (String[])RegKey.GetValue("InstalledInstances");
            if (Instancias != null)
            {
                if (Instancias.Length > 0)
                {
                    foreach (String Elemento in Instancias)
                    {
                        if (Elemento == "MSSQLSERVER")
                            serveres.Add(Environment.MachineName);
                        else
                            serveres.Add(Environment.MachineName + @"\" + Elemento);
                    }
                }
            }
            return serveres;
        }

        public List<string> BasesDatos(string server,string user,string pass)
        {
            try
            {

                List<string> bases = new List<string>();
               // _conexion = new SqlConnection("Server=" + server + ";User ID=" + user + ";Password=" + pass + ";Trusted_Connection=False");
                ConectarBd(server,user,pass);

                _conexion.Open();
                
                SqlCommand SqlCom = new SqlCommand();
                SqlCom.Connection = _conexion;
                SqlCom.CommandType = CommandType.StoredProcedure;
                SqlCom.CommandText = "sp_databases";

                SqlDataReader SqlDReader;
                SqlDReader = SqlCom.ExecuteReader();

                while (SqlDReader.Read())
                {
                    bases.Add(SqlDReader.GetString(0));
                }
                _conexion.Close();
                return bases;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            if (_conexion != null)
                _conexion.Close();

            return null;
        }

        //private void Conectar(string server,string database,string user,string pass)
        //{
        //    try
        //    {
        //        string cadenadconexion = "Server=" + server + "; Database=" + database + ";Uid=" + user + ";Pwd=" + pass + ";";
        //        _conexion = new SqlConnection();
        //        _conexion.ConnectionString = cadenadconexion;
        //        _conexion.Open();
        //    }
        //    catch (SqlException)
        //    {                
        //        throw new Exception("No se ha podido conectar con la base de datos");
        //    }
         
           
        //}

        //private void Desconectar()
        //{
        //    _conexion.Close();
        //}

        #endregion
        
    }
}
