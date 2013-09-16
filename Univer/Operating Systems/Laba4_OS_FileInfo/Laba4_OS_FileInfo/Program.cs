using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Laba4_OS_FileInfo
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new myForm());
        }
    }
}
