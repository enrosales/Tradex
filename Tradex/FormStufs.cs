using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Tradex
{
   public class FormStufs
    {

 

      public void LockControls(RadPanel f)
      {
          var b = (RadWaitingBar) f.Controls["radWaitingBar1"];
          b.StartWaiting();
          foreach (Control c in f.Controls)
          {
              if (c.Name.ToLower() != "radWaitingBar1".ToLower() && c.Name != "radGridView1" && c.Name != "fechaend")
                  c.Enabled = false;
              if (c.Name == "fechaend")
                  c.Enabled = c.Enabled;
          }
          
        }

      public void ReleaseControls(RadPanel f)
        {
            var b = (RadWaitingBar)f.Controls["radWaitingBar1"];
            b.StopWaiting();
          foreach (Control c in f.Controls)
          {
              if (c.Name != "radWaitingBar1" && c.Name != "radGridView1" && c.Name != "fechaend")
                  c.Enabled = true;
              if (c.Name == "fechaend")
                  c.Enabled = c.Enabled;
          }
         
        }


      public void HideColums(RadGridView r, List<string> cols)
      {
          string []originalcols = new string[cols.Count];
          cols.CopyTo(originalcols);
          cols.AddRange(Addprefix(originalcols, "ic"));
          cols.AddRange(Addprefix(originalcols, "oc"));
          cols.AddRange(Addprefix(originalcols, "ap"));
          foreach (var c in cols)
          {
              if(r.Columns[c]!=null)
                  r.Columns[c].IsVisible = false;
          }
      }
      public void HideColums2(RadGridView r, List<string> cols){
       
          foreach (var c in cols)
          {
              if (r.Columns[c] != null)
                  r.Columns[c].IsVisible = false;
          }
      }
       private string[] Addprefix(string[] cols,string prefix)
       {
           string[] newscol = new string[cols.Count()];
           for (int i = 0; i < newscol.Count(); i++)
               newscol[i] =cols[i]+ prefix;
           return newscol;
       }

       public void ShowColum(RadGridView r, string[] cols)
      {
          foreach (var c in cols.Where(c => r.Columns.Contains(c)))
          {
              r.Columns[c].IsVisible = true;
          }
      }

      public void Formartear(RadGridView r, string param, string col)
      {
          foreach (GridViewRowInfo t in r.Rows)
          {
              if (t.Cells[1].Value != null)
              {
                  if (t.Cells[col].Value.ToString().Contains(param))
                  {
                      foreach (GridViewCellInfo c in t.Cells)
                      {

                          c.Style.ForeColor = Color.LimeGreen;
                      }
                  }
              }
          }
          r.MasterTemplate.Refresh(null);
      }

      public void Buscar(RadGridView r, int[] pos, string param)
      {
          foreach (GridViewRowInfo t in r.Rows)
          {
              foreach (int p in pos)
              {
                  if (!t.Cells[p].Value.ToString().ToLower().Contains(param.ToLower())) continue;
                  r.CurrentRow = t;
                  return;
              }

          }

      }
      public void BuscarAll(RadGridView r, string param)
      {
          foreach (GridViewRowInfo t in r.Rows)
          {
              foreach (var c  in r.Columns)
              {
                  if (!t.Cells[c.Name].Value.ToString().ToLower().Contains(param.ToLower())) continue;
                  r.CurrentRow = t;
                  return;
              }

          }

      }
      public  void ShowMensaje(string message)
      {
          MessageBox.Show(message, @"Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }

      public DialogResult ShowMensajeCOnf(string message)
      {
          return MessageBox.Show(message, @"Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
      }

      //public void FillGrid(List<object[]> objs, RadGridView r, bool band = false) //LLenar Grid Con array Objetos
      //{
      //    r.Columns.Clear();
      //    r.Rows.Clear();
      //    foreach (object objectse in objs[0])
      //    {
      //        r.Columns.Add(objectse.ToString());
      //    }
      //    Image img = Resources.agenda.ToBitmap();
      //    if (band)
      //    {

      //        GridViewImageColumn imageColumn = new GridViewImageColumn("Imprimir");
      //        imageColumn.MaxWidth = 80;
      //        imageColumn.MinWidth = 80;
      //        imageColumn.HeaderTextAlignment = ContentAlignment.MiddleCenter;
      //        imageColumn.HeaderText = @"Imprimir";
      //        r.Columns.Add(imageColumn);
      //    }

      //    for (int i = 1; i < objs.Count; i++)
      //    {
      //        if (band)
      //        {
      //            object[] objsnnew = new object[objs[i].Length + 1];
      //            for (int j = 0; j < objs[i].Length; j++)
      //            {
      //                objsnnew[j] = objs[i][j];
      //            }


      //            objsnnew[objs[0].Length] = img;
      //            r.Rows.Add(objsnnew);
      //        }
      //        else
      //        {
      //            r.Rows.Add(objs[i]);
      //        }
      //    }

      //    r.TableElement.RowHeight = 55;
      //    r.TableElement.TableHeaderHeight = 35;

      //}

      public void OcultarColum(string[] args, RadGridView r)
      {
          foreach (var c in args)
          {
              foreach (GridViewDataColumn t in r.Columns)
              {
                  if (t.Name == c)
                  {
                      t.IsVisible = false;
                      break;
                  }
              }
          }
          r.MasterTemplate.Refresh(null);
      }

      public void Check(RadGridView r, string col)
      {
          var band = false;
          foreach (GridViewRowInfo t in r.Rows)
          {
              if (t.Cells[col].Value == null || t.Cells[col].Value.ToString() == "")
              {
                  t.Cells[col].Value = "0.0";
                  band = true;
              }
          }
          ShowMensaje(band
              ? "Algunos trabajadores no tienen porciento asignado se completo con 0"
              : "Datos Correctos!!!");
      }

      public void BestFitColum(RadGridView r)
      {
          r.BestFitColumns(BestFitColumnMode.AllCells);
      }


      public bool IsColumIn(RadGridView r, string col)
      {
          return r.Columns.Contains(col);
      }

      public void GridCopy(RadGridView origen, RadGridView destino)
      {
          try
          {
              foreach (GridViewDataColumn c in origen.Columns)
              {
                  destino.Columns.Add(c.Name);
              }
              foreach (GridViewRowInfo r in origen.Rows)
              {

                  //  destino.Rows.Add(r.Cells);
              }
          }
          catch (Exception e)
          {
              ShowMensaje(e.Message);
          }

      }


      public void ClearCampos(RadTextBox[] campos)
      {
          foreach (RadTextBox t in campos)
          {
              t.Text = "";
          }
      }

      public bool Enter(KeyPressEventArgs e)
      {
          if (e.KeyChar == 13)
              return true;
          return false;

      }

      public void StartWaiting(RadWaitingBar bar)
      {
          bar.Visible = true;
          bar.StartWaiting();
      }

      public void StoptWaiting(RadWaitingBar bar)
      {
          bar.StopWaiting();
          bar.Visible = false;
      }

      public void Disabeall(RadForm f)
      {
          foreach (Control c in f.Controls)
          {
              if (c.Name != "radWaitingBar1")
                  c.Enabled = false;
          }
      }

      public void Enableall(RadForm f)
      {
          foreach (Control c in f.Controls)
          {
              c.Enabled = true;
          }
      }


      public void InicializarGrid(RadGridView r)
      {
          r.AllowAddNewRow = false;
          r.AllowDeleteRow = false;
          r.AllowEditRow = false;
          r.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
          r.VerticalScrollState = ScrollState.AlwaysShow;
          r.MultiSelect = true;
      }

       public void HideSpecial(string[] cols, RadGridView r)
       {
           foreach (var c in r.Columns)
               c.IsVisible = false;
           foreach (var c in cols)
           {
               foreach (var col in r.Columns)
               {
                   if (c == col.Name)
                       col.IsVisible = true;
               }
           }
       }
    }
}
