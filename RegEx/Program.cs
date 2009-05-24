//This Code is released under the full GPL license available here: http://www.gnu.org/licenses/gpl.html
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RegEx
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
            Application.Run(new MainForm());
        }
    }
}
