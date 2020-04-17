using System.IO;
using System.Text;
using System.Xml;
using DoenaSoft.DVDProfiler.DVDProfilerHelper;
using v1_1 = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v1_1;
using v2_0 = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_0;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker
{
    internal static class ConfigurationHelper
    {
        internal static v2_0.CheckConfiguration Load(string fileName)
        {
            if (IsVersionXFile(fileName, "2"))
            {
                var config = DVDProfilerSerializer<v2_0.CheckConfiguration>.Deserialize(fileName);

                return config;
            }
            else
            {
                var config_v1_1 = DVDProfilerSerializer<v1_1.CheckConfiguration>.Deserialize(fileName);

                var config_2_0 = config_v1_1.Upgrade();

                Save(config_2_0, fileName);

                return config_2_0;
            }
        }

        internal static void Save(v2_0.CheckConfiguration configuration, string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;

                    DVDProfilerSerializer<v2_0.CheckConfiguration>.Serialize(xtw, configuration);
                }
            }
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
