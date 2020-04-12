using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration;
using DoenaSoft.DVDProfiler.DVDProfilerXML.Version400;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker
{
    [DebuggerDisplay("{Check.Name}: {Success}")]
    public sealed class CheckResult
    {
        public CheckItem Check { get; }

        public IEnumerable<DVD> FailedProfiles { get; }

        public bool Success => !FailedProfiles.Any();

        public CheckResult(CheckItem check, IEnumerable<DVD> failedProfiles)
        {
            Check = check;
            FailedProfiles = failedProfiles.ToList();
        }
    }
}
