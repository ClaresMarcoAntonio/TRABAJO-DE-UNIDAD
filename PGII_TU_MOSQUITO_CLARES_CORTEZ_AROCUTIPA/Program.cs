using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios;

namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ejercicio_06());
        }
    }
}
