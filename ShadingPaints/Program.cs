using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using ShadingPaints.Views;

namespace ShadingPaints
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ShadingPaints());

            DatosPintura dp = new DatosPintura();
            dp.Modo = "R";
            Application.Run(dp);
        }
    }
}
