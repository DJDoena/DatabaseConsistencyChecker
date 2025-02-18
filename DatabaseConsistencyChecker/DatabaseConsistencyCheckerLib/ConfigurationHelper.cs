using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using DoenaSoft.ToolBox.Generics;
using v1_1 = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v1_1;
using v2_0 = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_0;
using v2_2 = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_2;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker
{
    internal static class ConfigurationHelper
    {
        internal static Regex _versionRegex;

        static ConfigurationHelper()
        {
            _versionRegex = new Regex("Version=\"(?'Version'[0-9]+\\.[0-9]+)\"");
        }

        internal static v2_2.CheckConfiguration Load(string fileName, bool silent)
        {
            var fileVersion = GetFileVersion(fileName);

            if (fileVersion > 2.2m)
            {
                if (!silent)
                {
                    MessageBox.Show("The configuration file is newer than this program can read.", "Read error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return null;
            }
            else if (fileVersion >= 2.0m)
            {
                var config = TryLoad(fileName, silent, LoadFrom_v2_2);

                return config;
            }
            else if (fileVersion < 2.0m)
            {
                var config = TryLoad(fileName, silent, LoadFrom_v1_x);

                return config;
            }
            else //fileVersion is null
            {
                var config = TryLoad(fileName, silent, LoadFrom_v2_2);

                return config;
            }
        }

        internal static void Save(v2_2.CheckConfiguration configuration, string fileName)
        {
            configuration.Version = 2.2m;

            ExecuteSave(configuration, fileName);
        }

        private static v2_2.CheckConfiguration TryLoad(string fileName, bool silent, Func<string, v2_2.CheckConfiguration> load)
        {
            try
            {
                var config = load(fileName);

                return config;
            }
            catch
            {
                if (!silent)
                {
                    MessageBox.Show("The configuration file cannot be read.", "Read error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return null;
            }
        }

        private static v2_2.CheckConfiguration LoadFrom_v2_2(string fileName)
        {
            var config = XmlSerializer<v2_2.CheckConfiguration>.Deserialize(fileName);

            return config;
        }

        private static v2_2.CheckConfiguration LoadFrom_v1_x(string fileName)
        {
            var config_v1_1 = XmlSerializer<v1_1.CheckConfiguration>.Deserialize(fileName);

            var config_v2_0 = config_v1_1.Upgrade();

            var tempFile = Path.GetTempFileName();

            Save(config_v2_0, tempFile);

            var config_v2_2 = XmlSerializer<v2_2.CheckConfiguration>.Deserialize(tempFile);

            return config_v2_2;
        }

        private static void Save(v2_0.CheckConfiguration configuration, string fileName)
        {
            configuration.Version = 2.0m;

            ExecuteSave(configuration, fileName);
        }

        private static void ExecuteSave<T>(T configuration, string fileName) where T : class, new()
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;

                    XmlSerializer<T>.Serialize(xtw, configuration);
                }
            }
        }

        private static decimal? GetFileVersion(string fileName)
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

                    var match = _versionRegex.Match(line);

                    if (match.Success)
                    {
                        if (decimal.TryParse(match.Groups["Version"].Value, NumberStyles.Float, CultureInfo.GetCultureInfo("en-US"), out var version))
                        {
                            return version;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        return 1.0m;
                    }
                }
            }
        }
    }
}