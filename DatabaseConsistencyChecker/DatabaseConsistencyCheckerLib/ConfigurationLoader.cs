using System.IO;
using System.Text;
using DoenaSoft.DVDProfiler.DVDProfilerHelper;
using v1_1 = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v1_1;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker
{
    internal static class ConfigurationLoader
    {
        internal static v1_1.CheckConfiguration Load(string fileName)
        {
            var configuration = DVDProfilerSerializer<v1_1.CheckConfiguration>.Deserialize(fileName);

            return configuration;
        }

        private static bool IsVersionXFile(string fileName, string version)
        {
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    var lineNumber = 1;

                    var line = string.Empty;

                    while ((sr.EndOfStream == false) && (lineNumber < 3))
                    {
                        line = sr.ReadLine();

                        lineNumber++;
                    }

                    return line.Contains($"Version=\"{version}.");
                }
            }
        }
    }
}
