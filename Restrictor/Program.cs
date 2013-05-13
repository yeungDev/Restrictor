using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Restrictor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //just FYI, cmd: shutdown -a cancels logoff process.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
