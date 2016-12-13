using System;
using System.Windows.Forms;

namespace Tradex
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RadForm1());
          //  Application.Run(new Clasificador(1));
        }
    }
}
