using System;
using System.Windows.Forms;
using DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration;
using DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms;
using DoenaSoft.DVDProfiler.DVDProfilerHelper;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            var sampleConfiguration = DVDProfilerSerializer<CheckConfiguration>.Deserialize("SampleConfiguration.xml");

            var firstRule = sampleConfiguration.Rule[0].Clone();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RuleForm(firstRule));
        }
    }
}
