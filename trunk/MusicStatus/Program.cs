using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicStatus
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
            MusicStatusAppContext oContext = new MusicStatusAppContext();
            Application.Run(oContext);
        }
    }
}
