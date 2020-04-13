using System;
using System.Windows.Forms;
using DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}