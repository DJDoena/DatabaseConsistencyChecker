using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DoenaSoft.DVDProfiler.DVDProfilerXML.Version400;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration
{
    //xsd.exe xsd CheckConfiguration.xsd /c /l:cs /f /n:DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration

    partial class Item
    {
        public abstract IEnumerable<DVD> Filter(IEnumerable<DVD> profiles);

        public IEnumerable<DVD> Check(IEnumerable<DVD> profiles)
        {
            var correct = Filter(profiles);

            var incorrect = profiles.Except(correct);

            return incorrect;
        }
    }

    [DebuggerDisplay("{Name}")]
    partial class CheckItem
    {
    }

    partial class CountAsEqualToItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.CountAs == Value);

            return result;
        }
    }

    partial class CountAsNotEqualToItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.CountAs != Value);

            return result;
        }
    }

    partial class IsPartOfOwnedCollectionItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            if (Value)
            {
                var result = profiles.Where(p => p.CollectionType != null && p.CollectionType.IsPartOfOwnedCollection);

                return result;
            }
            else
            {
                var result = profiles.Where(p => p.CollectionType == null || !p.CollectionType.IsPartOfOwnedCollection);

                return result;
            }
        }
    }

    partial class MustContainGenreItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.GenreList != null && p.GenreList.Any(g => g.CheckString(Value)));

            return result;
        }
    }

    partial class MustContainTagItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.TagList.CheckTagName(Value));

            return result;
        }
    }

    partial class MustNotContainGenreItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.GenreList == null || !p.GenreList.Any(g => g.CheckString(Value)));

            return result;
        }
    }

    partial class MustNotContainTagItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => !p.TagList.CheckTagName(Value));

            return result;
        }
    }


    partial class IsMediaTypeDVDItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            if (Value)
            {
                var result = profiles.Where(p => p.MediaTypes != null && p.MediaTypes.DVD);

                return result;
            }
            else
            {
                var result = profiles.Where(p => p.MediaTypes == null || !p.MediaTypes.DVD);

                return result;
            }
        }
    }

    partial class IsMediaTypeBluRayItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            if (Value)
            {
                var result = profiles.Where(p => p.MediaTypes != null && p.MediaTypes.BluRay);

                return result;
            }
            else
            {
                var result = profiles.Where(p => p.MediaTypes == null || !p.MediaTypes.BluRay);

                return result;
            }
        }
    }

    partial class IsMediaTypeUltraHDItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            if (Value)
            {
                var result = profiles.Where(p => p.MediaTypes != null && p.MediaTypes.UltraHD);

                return result;
            }
            else
            {
                var result = profiles.Where(p => p.MediaTypes == null || !p.MediaTypes.UltraHD);

                return result;
            }
        }
    }

    partial class IsMediaTypeHDDVDItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            if (Value)
            {
                var result = profiles.Where(p => p.MediaTypes != null && p.MediaTypes.HDDVD);

                return result;
            }
            else
            {
                var result = profiles.Where(p => p.MediaTypes == null || !p.MediaTypes.HDDVD);

                return result;
            }
        }
    }

    partial class IsCustomMediaTypeItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.MediaTypes != null && p.MediaTypes.CustomMediaType.CheckString(Value));

            return result;
        }
    }

    partial class IsNotCustomMediaTypeItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.MediaTypes == null || !p.MediaTypes.CustomMediaType.CheckString(Value));

            return result;
        }
    }

    partial class HasCustomMediaTypeItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            if (Value)
            {
                var result = profiles.Where(p => p.MediaTypes != null && !string.IsNullOrWhiteSpace(p.MediaTypes.CustomMediaType));

                return result;
            }
            else
            {
                var result = profiles.Where(p => p.MediaTypes == null || string.IsNullOrWhiteSpace(p.MediaTypes.CustomMediaType));

                return result;
            }
        }
    }

    partial class IsCollectionTypeItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.CollectionType != null && p.CollectionType.Value.CheckString(Value));

            return result;
        }
    }

    partial class IsNotCollectionTypeItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.CollectionType == null || !p.CollectionType.Value.CheckString(Value));

            return result;
        }
    }

    partial class IsCollectionNumberSetItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            if (Value)
            {
                var result = profiles.Where(p => !string.IsNullOrWhiteSpace(p.CollectionNumber));

                return result;
            }
            else
            {
                var result = profiles.Where(p => string.IsNullOrWhiteSpace(p.CollectionNumber));

                return result;
            }
        }
    }

    partial class IsRunningTimeSetItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            if (Value)
            {
                var result = profiles.Where(p => p.RunningTime > 0);

                return result;
            }
            else
            {
                var result = profiles.Where(p => p.RunningTime <= 0);

                return result;
            }
        }
    }

    partial class MustContainGenresItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.GenreList != null && p.GenreList.Any());

            return result;
        }
    }

    partial class MustNotContainGenresItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.GenreList == null || !p.GenreList.Any());

            return result;
        }
    }

    partial class MustContainStudiosItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.StudioList != null && p.StudioList.Any());

            return result;
        }
    }

    partial class MustNotContainStudiosItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.StudioList == null || !p.StudioList.Any());

            return result;
        }
    }

    partial class MustContainMediaCompaniesItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.MediaCompanyList != null && p.MediaCompanyList.Any());

            return result;
        }
    }

    partial class MustNotContainMediaCompaniesItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.MediaCompanyList == null || !p.MediaCompanyList.Any());

            return result;
        }
    }

    partial class MustContainCountryOfOriginsItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.CountryOfOriginList != null && p.CountryOfOriginList.Any(coo => !string.IsNullOrWhiteSpace(coo)));

            return result;
        }
    }

    partial class MustNotContainCountryOfOriginsItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.CountryOfOriginList == null || !p.CountryOfOriginList.Any(coo => !string.IsNullOrWhiteSpace(coo)));

            return result;
        }
    }

    partial class IsProductionYearSet
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            if (Value)
            {
                var result = profiles.Where(p => p.ProductionYear > 0);

                return result;
            }
            else
            {
                var result = profiles.Where(p => p.ProductionYear <= 0);

                return result;
            }
        }
    }

    partial class HasCastItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            if (Value)
            {
                var result = profiles.Where(p => p.CastList != null && p.CastList.OfType<CastMember>().Any());

                return result;
            }
            else
            {
                var result = profiles.Where(p => p.CastList == null || !p.CastList.Any());

                return result;
            }
        }
    }

    partial class HasCrewItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            if (Value)
            {
                var result = profiles.Where(p => p.CrewList != null && p.CrewList.OfType<CrewMember>().Any());

                return result;
            }
            else
            {
                var result = profiles.Where(p => p.CrewList == null || !p.CrewList.Any());

                return result;
            }
        }
    }

    partial class HasEventItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            if (Value)
            {
                var result = profiles.Where(p => p.EventList.CheckEvents(EventType.ToString(), UserFirstName, UserLastName));

                return result;
            }
            else
            {
                var result = profiles.Where(p => !p.EventList.CheckEvents(EventType.ToString(), UserFirstName, UserLastName));

                return result;
            }
        }
    }

    partial class HasOnlinePublicExclusionItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            if (Value)
            {
                var result = profiles.Where(p => p.Exclusions != null && p.Exclusions.DPOPublicSpecified && p.Exclusions.DPOPublic);

                return result;
            }
            else
            {
                var result = profiles.Where(p => p.Exclusions == null || (!p.Exclusions.DPOPublicSpecified || !p.Exclusions.DPOPublic));

                return result;
            }
        }
    }

    partial class HasOnlinePrivateExclusionItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            if (Value)
            {
                var result = profiles.Where(p => p.Exclusions != null && p.Exclusions.DPOPrivateSpecified && p.Exclusions.DPOPrivate);

                return result;
            }
            else
            {
                var result = profiles.Where(p => p.Exclusions == null || !p.Exclusions.DPOPrivateSpecified || !p.Exclusions.DPOPrivate);

                return result;
            }
        }
    }

    partial class HasPDAExclusionItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            if (Value)
            {
                var result = profiles.Where(p => p.Exclusions != null && p.Exclusions.MobileSpecified && p.Exclusions.Mobile);

                return result;
            }
            else
            {
                var result = profiles.Where(p => p.Exclusions == null || !p.Exclusions.MobileSpecified || !p.Exclusions.Mobile);

                return result;
            }
        }
    }

    partial class HasSmartPhoneExclusionItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            if (Value)
            {
                var result = profiles.Where(p => p.Exclusions != null && p.Exclusions.iPhoneSpecified && p.Exclusions.iPhone);

                return result;
            }
            else
            {
                var result = profiles.Where(p => p.Exclusions == null || !p.Exclusions.iPhoneSpecified || !p.Exclusions.iPhone);

                return result;
            }
        }
    }

    partial class ExceptItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            if (Except != null)
            {
                var filtered = Except.Filter(profiles);

                var result = profiles.Except(filtered);

                return result;
            }
            else
            {
                return profiles;
            }
        }
    }

    partial class OrItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var filters = (Or ?? Enumerable.Empty<Item>()).ToList();

            if (filters.Any())
            {
                var filtered = filters[0].Filter(profiles);

                for (var filterIndex = 1; filterIndex < filters.Count; filterIndex++)
                {
                    filtered = filters[filterIndex].Filter(profiles).Union(filtered);
                }

                var result = filtered;

                return result;
            }
            else
            {
                return profiles;
            }
        }
    }

    partial class AndItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var filters = (And ?? Enumerable.Empty<Item>()).ToList();

            if (filters.Any())
            {
                var filtered = filters[0].Filter(profiles);

                for (var filterIndex = 1; filterIndex < filters.Count; filterIndex++)
                {
                    filtered = filters[filterIndex].Filter(filtered);
                }

                var result = filtered;

                return result;
            }
            else
            {
                return profiles;
            }
        }
    }
}