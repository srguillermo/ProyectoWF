using System;
using System.Windows.Forms;

namespace ProyectoWF {

    internal static class Program {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormularioPedidos(0,2));
            Application.Run(new FormularioPrincipal());
        }
    }
}