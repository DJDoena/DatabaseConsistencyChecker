using System.IO;
using System.Text;
using System.Xml;
using DoenaSoft.DVDProfiler.DVDProfilerHelper;
using v1_1 = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v1_1;
using v2_0 = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_0;
using v2_1 = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_1;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker
{
    internal static class ConfigurationHelper
    {
        internal static v2_1.CheckConfiguration Load(string fileName)
        {
            if (IsVersionXFile(fileName, "2"))
            {
                var config = DVDProfilerSerializer<v2_1.CheckConfiguration>.Deserialize(fileName);

                return config;
            }
            else
            {
                var config_v1_1 = DVDProfilerSerializer<v1_1.CheckConfiguration>.Deserialize(fileName);

                var config_v2_0 = config_v1_1.Upgrade();

                Save(config_v2_0, fileName);

                var config_v2_1 = DVDProfilerSerializer<v2_1.CheckConfiguration>.Deserialize(fileName);

                return config_v2_1;
            }
        }

        internal static void Save(v2_1.CheckConfiguration configuration, string fileName)
        {
            configuration.Version = 2.1m;

            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;

                    DVDProfilerSerializer<v2_1.CheckConfiguration>.Serialize(xtw, configuration);
                }
            }
        }

        private static void Save(v2_0.CheckConfiguration configuration, string fileName)
        {
            configuration.Version = 2.0m;

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
