using System;
using System.Windows.Forms;
using System.IO;

namespace Wallpaper_Generator
{
    // do sprawdzenia - ustawianie tapety
    

    static class Index
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }

    }
}
