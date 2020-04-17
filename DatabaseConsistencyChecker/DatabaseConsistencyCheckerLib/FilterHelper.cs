using System;
using System.Collections.Generic;
using System.Linq;
using DoenaSoft.DVDProfiler.DVDProfilerXML.Version400;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker
{
    internal static class FilterHelper
    {
        internal static IEnumerable<DVD> FilterNull(this IEnumerable<DVD> profiles)
        {
            var result = profiles?.Where(p => p != null) ?? Enumerable.Empty<DVD>();

            return result;
        }

        internal static bool IsExpected(this string actual, string expected)
        {
            var result = actual?.Equals(expected, StringComparison.CurrentCultureIgnoreCase) == true;

            return result;
        }

        internal static bool HasTagName(this IEnumerable<Tag> tags, string expected)
        {
            if (tags == null)
            {
                return false;
            }
            else
            {
                var filtered = tags.Where(t => t != null
                    && (t.Name.IsExpected(expected) || t.FullName.IsExpected(expected)));

                var result = filtered.Any();

                return result;
            }
        }

        internal static bool HasEvent(this IEnumerable<Event> events, string eventType, string userFirstName, string userLastName)
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
                    filtered = filtered.Where(e => e.User.FirstName.IsExpected(userFirstName));
                }
                else
                {
                    filtered = filtered.Where(e => string.IsNullOrWhiteSpace(e.User.FirstName));
                }

                if (!string.IsNullOrWhiteSpace(userLastName))
                {
                    filtered = filtered.Where(e => e.User.LastName.IsExpected(userLastName));
                }
                else
                {
                    filtered = filtered.Where(e => string.IsNullOrWhiteSpace(e.User.LastName));
                }

                var result = filtered.Any();

                return result;
            }
        }

        internal static bool CheckValue(this Price price)
        {
            var result = price != null
                && price.Value > 0;

            return result;
        }

        internal static bool HasCurrency(this Price price)
        {
            var result = price != null
                && !string.IsNullOrWhiteSpace(price.DenominationType);

            return result;
        }

        internal static bool IsCurrency(this Price price, string value)
        {
            var result = price != null
                && (price.DenominationType.IsExpected(value)
                    || price.DenominationDesc.IsExpected(value));

            return result;
        }
    }
}
