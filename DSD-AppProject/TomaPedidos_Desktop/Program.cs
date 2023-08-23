﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomaPedidos.Commons;
using TomaPedidos.View;

namespace TomaPedidos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmLogin());
                //Application.Run(new frmSplash());
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }  
        }
    }
}
