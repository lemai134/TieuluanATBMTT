using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ma_Hoa_AES
{
    static class Program
    {
    
        /// The main entry point for the application.

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ma_HOa());
        }
    }
}
