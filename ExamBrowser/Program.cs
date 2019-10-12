using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamBrowser
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] arguments)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (arguments.Length > 0 && arguments[0].ToLower() == "lock")
            {
                Application.Run(new MainForm());
            }
            else
            {
                Application.Run(new TitleForm());
            }
        }
    }
}
