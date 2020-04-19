using System;
using System.Collections.Generic;
using System.Linq;
using DoenaSoft.DVDProfiler.DVDProfilerXML.Version400;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_2;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker
{
    public sealed class RuleChecker
    {
        private readonly IEnumerable<DVD> _profiles;

        public RuleChecker(Collection collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            _profiles = collection.DVDList.FilterNull();
        }

        public RuleChecker(IEnumerable<DVD> profiles)
        {
            if (profiles == null)
            {
                throw new ArgumentNullException(nameof(profiles));
            }

            _profiles = profiles.FilterNull();
        }

        public IEnumerable<CheckResult> Check(Config.RuleItem rule)
        {
            if (rule == null)
            {
                throw new ArgumentNullException(nameof(rule));
            }
            else if (rule.Check == null)
            {
                throw new ArgumentNullException($"{nameof(rule)}.{nameof(Config.RuleItem.Check)}");
            }
            else if (rule.Check.Any(c => c == null))
            {
                throw new ArgumentException("A check must not be null", $"{nameof(rule)}.{nameof(Config.RuleItem.Check)}");
            }
            else if (rule.Check.Any(c => c.Item == null))
            {
                throw new ArgumentException("A check item must not be null", $"{nameof(rule)}.{nameof(Config.RuleItem.Check)}.{nameof(Config.CheckItem.Item)}");
            }

            var filtered = rule.Filter != null
                ? rule.Filter.Filter(_profiles)
                : _profiles;

            foreach (var check in rule.Check)
            {
                var failedProfiles = check.Item.Check(filtered);

                yield return new CheckResult(check, failedProfiles);
            }
        }
    }
}