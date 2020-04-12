using System;
using System.Collections.Generic;
using System.Linq;
using DoenaSoft.DVDProfiler.DVDProfilerXML.Version400;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker
{
    internal static class FilterHelper
    {
        internal static IEnumerable<DVD> FilterNullProfiles(this IEnumerable<DVD> profiles)
        {
            var result = (profiles ?? Enumerable.Empty<DVD>()).Where(p => p != null);

            return result;
        }

        internal static bool CheckString(this string actual, string expected)
        {
            var result = actual?.Equals(expected, StringComparison.CurrentCultureIgnoreCase) == true;

            return result;
        }

        internal static bool CheckTagName(this IEnumerable<Tag> tags, string expected)
        {
            if (tags == null)
            {
                return false;
            }
            else
            {
                var filtered = tags.Where(t => t != null
                    && (t.Name.CheckString(expected) || t.FullName.CheckString(expected)));

                var result = filtered.Any();

                return result;
            }
        }

        internal static bool CheckEvents(this IEnumerable<Event> events, string eventType, string userFirstName, string userLastName)
        {
            if (events == null)
            {
                return false;
            }
            else
            {
                var filtered = events.Where(e => e != null
                    && e.Type.ToString() == eventType
                    && e.User != null);

                if (!string.IsNullOrWhiteSpace(userFirstName))
                {
                    filtered = filtered.Where(e => e.User.FirstName.CheckString(userFirstName));
                }
                else
                {
                    filtered = filtered.Where(e => string.IsNullOrWhiteSpace(e.User.FirstName));
                }

                if (!string.IsNullOrWhiteSpace(userLastName))
                {
                    filtered = filtered.Where(e => e.User.LastName.CheckString(userLastName));
                }
                else
                {
                    filtered = filtered.Where(e => string.IsNullOrWhiteSpace(e.User.LastName));
                }

                var result = filtered.Any();

                return result;
            }
        }
    }
}
