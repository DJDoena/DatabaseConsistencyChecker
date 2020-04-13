using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DoenaSoft.DVDProfiler.DVDProfilerXML.Version400;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration
{
    //xsd.exe xsd CheckConfiguration.xsd /c /l:cs /f /n:DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration

    partial class CheckConfiguration
    {
        public CheckConfiguration Clone()
        {
            return new CheckConfiguration()
            {
                Rule = Rule?.Select(r => r?.Clone()).ToArray(),
            };
        }
    }

    partial class RuleItem
    {
        public RuleItem Clone()
        {
            return new RuleItem()
            {
                Name = Name,
                Filter = Filter?.Clone(),
                Check = Check?.Select(c => c?.Clone()).ToArray(),
            };
        }
    }

    partial class Item
    {
        public abstract IEnumerable<DVD> Filter(IEnumerable<DVD> profiles);

        public IEnumerable<DVD> Check(IEnumerable<DVD> profiles)
        {
            var correct = Filter(profiles);

            var incorrect = profiles.Except(correct);

            return incorrect;
        }

        public abstract Item Clone();

        public override string ToString() => string.Empty;
    }

    partial class BooleanItem
    {
        public override string ToString() => Value.ToString();
    }

    partial class IntItem
    {
        public override string ToString() => Value.ToString();
    }

    partial class StringItem
    {
        public override string ToString() => Value;
    }

    [DebuggerDisplay("{Name}")]
    partial class CheckItem
    {
        public CheckItem Clone()
        {
            return new CheckItem()
            {
                Name = Name,
                Item = Item?.Clone(),
            };
        }
    }

    partial class CountAsEqualToItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.CountAs == Value);

            return result;
        }

        public override Item Clone()
        {
            return new CountAsEqualToItem()
            {
                Value = Value,
            };
        }
    }

    partial class CountAsNotEqualToItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.CountAs != Value);

            return result;
        }

        public override Item Clone()
        {
            return new CountAsNotEqualToItem()
            {
                Value = Value,
            };
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

        public override Item Clone()
        {
            return new IsPartOfOwnedCollectionItem()
            {
                Value = Value,
            };
        }
    }

    partial class MustContainGenreItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.GenreList != null && p.GenreList.Any(g => g.CheckString(Value)));

            return result;
        }

        public override Item Clone()
        {
            return new MustContainGenreItem()
            {
                Value = Value,
            };
        }
    }

    partial class MustContainTagItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.TagList.CheckTagName(Value));

            return result;
        }

        public override Item Clone()
        {
            return new MustContainTagItem()
            {
                Value = Value,
            };
        }
    }

    partial class MustNotContainGenreItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.GenreList == null || !p.GenreList.Any(g => g.CheckString(Value)));

            return result;
        }

        public override Item Clone()
        {
            return new MustNotContainGenreItem()
            {
                Value = Value,
            };
        }
    }

    partial class MustNotContainTagItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => !p.TagList.CheckTagName(Value));

            return result;
        }

        public override Item Clone()
        {
            return new MustNotContainTagItem()
            {
                Value = Value,
            };
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

        public override Item Clone()
        {
            return new IsMediaTypeDVDItem()
            {
                Value = Value,
            };
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

        public override Item Clone()
        {
            return new IsMediaTypeBluRayItem()
            {
                Value = Value,
            };
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

        public override Item Clone()
        {
            return new IsMediaTypeUltraHDItem()
            {
                Value = Value,
            };
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

        public override Item Clone()
        {
            return new IsMediaTypeHDDVDItem()
            {
                Value = Value,
            };
        }
    }

    partial class IsCustomMediaTypeItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.MediaTypes != null && p.MediaTypes.CustomMediaType.CheckString(Value));

            return result;
        }

        public override Item Clone()
        {
            return new IsCustomMediaTypeItem()
            {
                Value = Value,
            };
        }
    }

    partial class IsNotCustomMediaTypeItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.MediaTypes == null || !p.MediaTypes.CustomMediaType.CheckString(Value));

            return result;
        }

        public override Item Clone()
        {
            return new IsNotCustomMediaTypeItem()
            {
                Value = Value,
            };
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

        public override Item Clone()
        {
            return new HasCustomMediaTypeItem()
            {
                Value = Value,
            };
        }
    }

    partial class IsCollectionTypeItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.CollectionType != null && p.CollectionType.Value.CheckString(Value));

            return result;
        }

        public override Item Clone()
        {
            return new IsCollectionTypeItem()
            {
                Value = Value,
            };
        }
    }

    partial class IsNotCollectionTypeItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.CollectionType == null || !p.CollectionType.Value.CheckString(Value));

            return result;
        }

        public override Item Clone()
        {
            return new IsNotCollectionTypeItem()
            {
                Value = Value,
            };
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

        public override Item Clone()
        {
            return new IsCollectionNumberSetItem()
            {
                Value = Value,
            };
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

        public override Item Clone()
        {
            return new IsRunningTimeSetItem()
            {
                Value = Value,
            };
        }
    }

    partial class MustContainGenresItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.GenreList != null && p.GenreList.Any());

            return result;
        }

        public override Item Clone()
        {
            return new MustContainGenresItem();
        }
    }

    partial class MustNotContainGenresItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.GenreList == null || !p.GenreList.Any());

            return result;
        }

        public override Item Clone()
        {
            return new MustNotContainGenresItem();
        }
    }

    partial class MustContainStudiosItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.StudioList != null && p.StudioList.Any());

            return result;
        }

        public override Item Clone()
        {
            return new MustContainStudiosItem();
        }
    }

    partial class MustNotContainStudiosItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.StudioList == null || !p.StudioList.Any());

            return result;
        }

        public override Item Clone()
        {
            return new MustNotContainStudiosItem();
        }
    }

    partial class MustContainMediaCompaniesItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.MediaCompanyList != null && p.MediaCompanyList.Any());

            return result;
        }

        public override Item Clone()
        {
            return new MustContainMediaCompaniesItem();
        }
    }

    partial class MustNotContainMediaCompaniesItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.MediaCompanyList == null || !p.MediaCompanyList.Any());

            return result;
        }

        public override Item Clone()
        {
            return new MustNotContainMediaCompaniesItem();
        }
    }

    partial class MustContainCountryOfOriginsItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.CountryOfOriginList != null && p.CountryOfOriginList.Any(coo => !string.IsNullOrWhiteSpace(coo)));

            return result;
        }

        public override Item Clone()
        {
            return new MustContainCountryOfOriginsItem();
        }
    }

    partial class MustNotContainCountryOfOriginsItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.CountryOfOriginList == null || !p.CountryOfOriginList.Any(coo => !string.IsNullOrWhiteSpace(coo)));

            return result;
        }

        public override Item Clone()
        {
            return new MustNotContainCountryOfOriginsItem();
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

        public override Item Clone()
        {
            return new IsProductionYearSet()
            {
                Value = Value,
            };
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

        public override Item Clone()
        {
            return new HasCastItem()
            {
                Value = Value,
            };
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

        public override Item Clone()
        {
            return new HasCrewItem()
            {
                Value = Value,
            };
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

        public override Item Clone()
        {
            return new HasEventItem()
            {
                Value = Value,
                EventType = EventType,
                UserFirstName = UserFirstName,
                UserLastName = UserLastName,
            };
        }

        public override string ToString() => $"Type: {EventType}, User: {(UserFirstName + " " + UserLastName).Trim()}";
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

        public override Item Clone()
        {
            return new HasOnlinePublicExclusionItem()
            {
                Value = Value,
            };
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

        public override Item Clone()
        {
            return new HasOnlinePrivateExclusionItem()
            {
                Value = Value,
            };
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

        public override Item Clone()
        {
            return new HasPDAExclusionItem()
            {
                Value = Value,
            };
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

        public override Item Clone()
        {
            return new HasSmartPhoneExclusionItem()
            {
                Value = Value,
            };
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

        public override Item Clone()
        {
            return new ExceptItem()
            {
                Except = Except?.Clone(),
            };
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

        public override Item Clone()
        {
            return new OrItem()
            {
                Or = Or?.Select(o => o?.Clone()).ToArray(),
            };
        }

        public override string ToString() => $"Count: {Or?.Length ?? 0}";
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

        public override Item Clone()
        {
            return new AndItem()
            {
                And = And?.Select(a => a?.Clone()).ToArray(),
            };
        }

        public override string ToString() => $"Count: {And?.Length ?? 0}";
    }
}