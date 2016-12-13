using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace Tradex.Excel
{
   public class excelManager
    {

       private CultureInfo oldCI;

       public Worksheet LeerHoja(string ruta, string nombreHoja)
        {
            SetCultura();
            _Application aExcel = new Application();
           Workbook oBook = null;
         //  oBook.WebOptions.Encoding = Microsoft.Office.Core.MsoEncoding.msoEncodingUTF8;
          // Encoding encode = System.Text.Encoding.GetEncoding("1251");
          // Encoding enc = new UTF8Encoding(true, true);
           oBook = aExcel.Workbooks.Open(ruta, Type.Missing, false, /*Encoding.UTF8*/ Type.Missing, Type.Missing
                , Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing
                , Type.Missing, Type.Missing, Type.Missing);
            Worksheet hoja = (Worksheet)oBook.Worksheets.get_Item(IndexHojaException(oBook, nombreHoja));
            
            OffCulture();
            return hoja;
        }

       public Worksheet LeerHoja(Workbook libro, int indexHoja)
       {
           Worksheet hoja = null;
           try
           {
               hoja = (Worksheet)libro.Worksheets.get_Item(indexHoja);
               
           }
           catch (Exception theException)
           {
               String errorMessage;
               errorMessage = "Error: ";
               errorMessage = String.Concat(errorMessage, theException.Message);
               errorMessage = String.Concat(errorMessage, " Linea: ");
               errorMessage = String.Concat(errorMessage, theException.Source);
               errorMessage = String.Concat(errorMessage, "Error al buscar la Hoja Excel");
               MessageBox.Show(errorMessage, "Error");
           }
           return hoja;
       }

        private int IndexHojaException(Workbook libro, string nombHoja)
        {

            int cont = 1;
            foreach (Worksheet hoja in libro.Worksheets)
            {
                if (hoja.Name.ToUpper().Trim() == nombHoja.ToUpper().Trim())
                    return cont;
                cont++;
            }
            throw new Exception("Hoja " + nombHoja + " no encontrada");
        }

        public Workbook LeerExcel(string ruta)
        {
            SetCultura();
            _Application aExcel = new Application();
            Workbook oBook = aExcel.Workbooks.Open(ruta, Type.Missing, false, Type.Missing, Type.Missing
                , Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing
                , Type.Missing, Type.Missing, Type.Missing);
            OffCulture();
            return oBook;
        }

        public int IndexHoja(Workbook libro, string nombHoja)
        {
            int cont = 1;
            foreach (Worksheet hoja in libro.Worksheets)
            {
                if (hoja.Name.ToUpper() == nombHoja.ToUpper())
                    return cont;
                cont++;

            }
            return 0;
        }

        private string SaberExt(string name)
        {
            string ext = "";
            for (int i = name.Count() - 1; i >= 0; i--)
            {
                if (name[i] == '.')
                    break;
                ext += name[i];
            }
            string fin = "";
            for (int i = ext.Count() - 1; i >= 0; i--)
            {
                fin += ext[i];
            }
            return fin;
        }

        private void SetCultura()
        {
            oldCI = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }

        private void OffCulture()
        {
            Thread.CurrentThread.CurrentCulture = oldCI;

        }

        public void KillProcess()
        {

            int idproc = GetIDProcces("EXCEL"); //cerrando proceso
            if (idproc != -1)
            {
                Process.GetProcessById(idproc).Kill();
            }
        }

        private int GetIDProcces(string nameProcces)
        {
            try
            {
                Process[] asProccess = Process.GetProcessesByName(nameProcces);
                foreach (Process pProccess in asProccess)
                {
                    if (pProccess.MainWindowTitle == "")
                    {
                        return pProccess.Id;
                    }
                }
                return -1;
            }
            catch
            {
                return -1;
            }
        }

       public object[] ExtractRow(Object[,] valores, int start, int end, int fila)
        {
            object[] arr = new object[end - start + 1];
            var iterator = 0;
            for (var j = start; j <= end; j++)
            {
                object[] o = new object[2]; //Devolver tambien la columna donde esta ese valor
                o[0] = valores[fila, j];
                o[1] = j;
                arr[iterator] = o;
                iterator++;
            }
            return arr;
        }

        public void ReleaseObject(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                throw new Exception("Error en la liberación del proceso. " + ex.Message);
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
