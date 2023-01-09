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
            var settings = Properties.Settings.Default;

            if (settings.UpgradeRequired)
            {
                settings.Upgrade();
                settings.UpgradeRequired = false;
                settings.Save();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm(null, settings.CollectionFile, settings.ConfigurationFile, settings.IgnoreFile);

            Application.Run(mainForm);

            settings.CollectionFile = mainForm.CollectionFile;
            settings.ConfigurationFile = mainForm.ConfigurationFile;
            settings.IgnoreFile = mainForm.IgnoreFile;
            settings.Save();
        }
    }
}