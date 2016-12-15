using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Tradex
{
    public partial class Clasificador : RadForm
    {
        private Versat _versat;
        private int entidad;
        private CuentaContable cc;
        
        public Clasificador(int entidad, CuentaContable cc)
        {
            InitializeComponent();
            _versat = new Versat();
            this.entidad = entidad;
            this.cc = cc;
        }

        private void Clasificador_Load(object sender, EventArgs e)
        {
            txtClave.Enabled = false;
            txtDescrip.Enabled = false;
            txtNaturaleza.Enabled = false;
            
            radTreeView1.TreeViewElement.AllowAlternatingRowColor = true;

            CargarPadres();
        }
        
        private void CargarPadres()
        {
            radTreeView1.BeginUpdate();

            List<object[]> lista = _versat.CargarPadresDelClasificador(entidad);

            foreach (var elemento in lista)
            {
                var cuenta = (object[]) (object) elemento;
                                                    // clavenivel " " descrip
                RadTreeNode raiz = new RadTreeNode(cuenta[4] + " " + cuenta[5]);
                            //idcuenta      idAperturaSub      " " clave      + " " naturaleza    +   descripcion
                raiz.Value = cuenta[0] + "*" + cuenta[3]+ "*" + cuenta[1] + "*" + cuenta[6] + "*" + cuenta[5];
                radTreeView1.Nodes.Add(raiz);
            }

            foreach (var nodo in radTreeView1.Nodes)
            {
                LlenadoRecursivo(nodo);
            }
            radTreeView1.EndUpdate();
        }

        private void LlenadoRecursivo(RadTreeNode nodeActual)
        {
            // si idApertSub == "" es una hoja, no tiene mas hijos
            string idApertSub = nodeActual.Value.ToString().Split('*')[1];
            
            if (idApertSub == "")
                return;
            List<object[]> list = _versat.CargarHijosDelClasificador(entidad, idApertSub);
            foreach (var elemento in list)
            {
                var x = (object[]) elemento;// clavenivel " " descrip
                RadTreeNode hijo = new RadTreeNode(x[4] + " " + x[5]);
                //idcuenta      idAperturaSub      " " clave      + " " naturaleza    +   descripcion
                hijo.Value = x[0] + "*" + x[3] + "*" + x[1] + "*" + x[6] + "*" + x[5];
                nodeActual.Nodes.Add(hijo);
                LlenadoRecursivo(hijo);
            }
        }

        private void radTreeView1_NodeMouseClick(object sender, RadTreeViewEventArgs e)
        {
            txtClave.Text = e.Node.Text.Split(' ')[0];
            txtDescrip.Text = e.Node.Value.ToString().Split('*')[4];
            string naturaleza = e.Node.Value.ToString().Split('*')[3];
            if (naturaleza == "1")
                txtNaturaleza.Text = "Deudora";
            else if(naturaleza == "-1")
            {
                txtNaturaleza.Text = "Acreedora";
            }
            else
            {
                txtNaturaleza.Text = "";
            }
        }

        private void radTreeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void radTreeView1_NodeMouseDoubleClick(object sender, RadTreeViewEventArgs e)
        {
            cc.clave = e.Node.Value.ToString().Split('*')[2];
            string[] x = e.Node.Value.ToString().Split('*');
            cc.descripcion = e.Node.Value.ToString().Split('*')[4];
            cc.idCuenta = int.Parse(e.Node.Value.ToString().Split('*')[0]);
            Close();
        }

    }
}
