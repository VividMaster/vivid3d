using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VividSplash
{
    public static class Launch
    {
        public static string Proj = "";
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] arg = Environment.GetCommandLineArgs();
            if (arg.Length > 1)
            {
                Launch.Proj = arg[1];
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogoSplash());
        }
    }
}
