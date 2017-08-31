using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace layerino
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static LayerinoForm layerinoForm;

        [STAThread]
        static void Main()
        {           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            layerinoForm = new LayerinoForm();
            Application.Run(layerinoForm);
        }

    }
}
