using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            Application.Run(new Form1());
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string ResultfilePath = Path.Combine(desktopPath, "Results.txt");
            string rulesfilePath = Path.Combine(desktopPath, "rules.txt");
            // Clear the contents of the file
            File.WriteAllText(ResultfilePath, string.Empty);
            File.WriteAllText(rulesfilePath, string.Empty);
        }
    }
}
