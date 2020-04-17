using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DoenaSoft.DVDProfiler.DVDProfilerXML.Version400;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_1;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker
{
    [DebuggerDisplay("{Check.Name}: {Success}")]
    public sealed class CheckResult
    {
        public Config.CheckItem Check { get; }

        public IEnumerable<DVD> FailedProfiles { get; }

        public bool Success => !FailedProfiles.Any();

        public CheckResult(Config.CheckItem check, IEnumerable<DVD> failedProfiles)
        {
            Check = check;

            FailedProfiles = failedProfiles.ToList();
        }
    }
}