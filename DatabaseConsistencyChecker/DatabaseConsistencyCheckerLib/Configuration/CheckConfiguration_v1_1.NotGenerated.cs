using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DoenaSoft.DVDProfiler.DVDProfilerXML.Version400;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v1_1
{
    //xsd.exe CheckConfiguration_v1_1.xsd /c /l:cs /f /n:DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration.v1_1

    partial class CheckConfiguration
    {
        public CheckConfiguration Clone()
        {
            return new CheckConfiguration()
            {
                Rule = Rule?.Select(r => r?.Clone()).ToArray(),
                Version = 1.1m,
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

    partial class BooleanValueItem
    {
        public override string ToString() => Value.ToString();
    }

    partial class IntValueItem
    {
        public override string ToString() => Value.ToString();
    }

    partial class StringValueItem
    {
        public override string ToString() => Value;
    }

    partial class ChoiceItem
    {
        public override string ToString() => Choice.ToString();
    }

    partial class ChoiceStringItem
    {
        public override string ToString() => $"{Choice}: {Value}";
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
            var result = profiles.Where(p => CountAsEqualTo(p, Value));

            return result;
        }

        internal static bool CountAsEqualTo(DVD profile, int value)
        {
            var result = profile.CountAs == value;

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
            var result = profiles.Where(p => !CountAsEqualToItem.CountAsEqualTo(p, Value));

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
            var result = profiles.Where(p => IsPartOfOwnedCollection(p) == Value);

            return result;
        }

        private static bool IsPartOfOwnedCollection(DVD profile)
        {
            var result = profile.CollectionType != null
                && profile.CollectionType.IsPartOfOwnedCollection;

            return result;
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
            var result = profiles.Where(p => IsGenreSet(p, Value));

            return result;
        }

        internal static bool IsGenreSet(DVD profile, string value)
        {
            var result = profile.GenreList != null
                && profile.GenreList.Any(g => g.IsExpected(value));

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

    partial class MustNotContainGenreItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => !MustContainGenreItem.IsGenreSet(p, Value));

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

    partial class MustContainTagItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => IsTagSet(p, Value));

            return result;
        }

        internal static bool IsTagSet(DVD profile, string value)
        {
            var result = profile.TagList.HasTagName(value);

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

    partial class MustNotContainTagItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => !MustContainTagItem.IsTagSet(p, Value));

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
            var result = profiles.Where(p => IsMediaTypeDVD(p) == Value);

            return result;
        }

        private static bool IsMediaTypeDVD(DVD profile)
        {
            var result = profile.MediaTypes != null
                && profile.MediaTypes.DVD;

            return result;
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
            var result = profiles.Where(p => IsMediaTypeBluRay(p) == Value);

            return result;
        }

        private static bool IsMediaTypeBluRay(DVD profile)
        {
            var result = profile.MediaTypes != null
                && profile.MediaTypes.BluRay;

            return result;
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
            var result = profiles.Where(p => IsMediaTypeUltraHD(p) == Value);

            return result;
        }

        private static bool IsMediaTypeUltraHD(DVD profile)
        {
            var result = profile.MediaTypes != null
                && profile.MediaTypes.UltraHD;

            return result;
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
            var result = profiles.Where(p => IsMediaTypeHDDVD(p) == Value);

            return result;
        }

        private static bool IsMediaTypeHDDVD(DVD profile)
        {
            var result = profile.MediaTypes != null
                && profile.MediaTypes.HDDVD;

            return result;
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
            var result = profiles.Where(p => IsCustomMediaTypeSet(p, Value));

            return result;
        }

        internal static bool IsCustomMediaTypeSet(DVD profile, string value)
        {
            var result = profile.MediaTypes != null
                && profile.MediaTypes.CustomMediaType.IsExpected(value);

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
            var result = profiles.Where(p => !IsCustomMediaTypeItem.IsCustomMediaTypeSet(p, Value));

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
            var result = profiles.Where(p => HasCustomeMediaType(p) == Value);

            return result;
        }

        private static bool HasCustomeMediaType(DVD profile)
        {
            var result = profile.MediaTypes != null
                && !string.IsNullOrWhiteSpace(profile.MediaTypes.CustomMediaType);

            return result;
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
            var result = profiles.Where(p => IsCollectionType(p, Value));

            return result;
        }

        internal static bool IsCollectionType(DVD profile, string value)
        {
            var result = profile.CollectionType != null
                && profile.CollectionType.Value.IsExpected(value);

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
            var result = profiles.Where(p => !IsCollectionTypeItem.IsCollectionType(p, Value));

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
            var result = profiles.Where(p => IsCollectionNumberSet(p) == Value);

            return result;
        }

        private static bool IsCollectionNumberSet(DVD profile)
        {
            var result = !string.IsNullOrWhiteSpace(profile.CollectionNumber);

            return result;
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
            var result = profiles.Where(p => IsRunningTimeSet(p) == Value);

            return result;
        }

        private static bool IsRunningTimeSet(DVD profile)
        {
            var result = profile.RunningTime > 0;

            return result;
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
            var result = profiles.Where(p => HasGenres(p));

            return result;
        }

        internal static bool HasGenres(DVD profile)
        {
            var result = profile.GenreList != null
                && profile.GenreList.Any(g => !string.IsNullOrWhiteSpace(g));

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
            var result = profiles.Where(p => !MustContainGenresItem.HasGenres(p));

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
            var result = profiles.Where(p => HasStudios(p));

            return result;
        }

        internal static bool HasStudios(DVD profile)
        {
            var result = profile.StudioList != null
                && profile.StudioList.Any(s => !string.IsNullOrWhiteSpace(s));

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
            var result = profiles.Where(p => !MustContainStudiosItem.HasStudios(p));

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
            var result = profiles.Where(p => HasMediaCompanies(p));

            return result;
        }

        internal static bool HasMediaCompanies(DVD profile)
        {
            var result = profile.MediaCompanyList != null
                && profile.MediaCompanyList.Any(mc => !string.IsNullOrWhiteSpace(mc));

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
            var result = profiles.Where(p => !MustContainMediaCompaniesItem.HasMediaCompanies(p));

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
            var result = profiles.Where(p => HasCountryOfOrigins(p));

            return result;
        }

        internal static bool HasCountryOfOrigins(DVD profile)
        {
            var result = profile.CountryOfOriginList != null
                && profile.CountryOfOriginList.Any(coo => !string.IsNullOrWhiteSpace(coo));

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
            var result = profiles.Where(p => !MustContainCountryOfOriginsItem.HasCountryOfOrigins(p));

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
            var result = profiles.Where(p => IsProductionYearSetCheck(p) == Value);

            return result;
        }

        private static bool IsProductionYearSetCheck(DVD profile)
        {
            var result = profile.ProductionYear > 0;

            return result;
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
            var result = profiles.Where(p => HasCast(p) == Value);

            return result;
        }

        private static bool HasCast(DVD profile)
        {
            var result = profile.CastList != null
                && profile.CastList.OfType<CastMember>().Any();

            return result;
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
            var result = profiles.Where(p => HasCrew(p) == Value);

            return result;
        }

        private static bool HasCrew(DVD profile)
        {
            var result = profile.CrewList != null
                && profile.CrewList.OfType<CrewMember>().Any();

            return result;
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
            var result = profiles.Where(p => HasEvent(p) == Value);

            return result;
        }

        private bool HasEvent(DVD profile)
        {
            var result = profile.EventList.HasEvent(EventType.ToString(), UserFirstName, UserLastName);

            return result;
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
            var result = profiles.Where(p => HasOnlinePublicExclusion(p) == Value);

            return result;
        }

        private static bool HasOnlinePublicExclusion(DVD profile)
        {
            var result = profile.Exclusions != null
                && profile.Exclusions.DPOPublicSpecified
                && profile.Exclusions.DPOPublic;

            return result;
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
            var result = profiles.Where(p => HasOnlinePrivateExclusion(p) == Value);

            return result;
        }

        private static bool HasOnlinePrivateExclusion(DVD profile)
        {
            var result = profile.Exclusions != null
                && profile.Exclusions.DPOPrivateSpecified
                && profile.Exclusions.DPOPrivate;

            return result;
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
            var result = profiles.Where(p => HasPDAExclusion(p) == Value);

            return result;
        }

        private static bool HasPDAExclusion(DVD profile)
        {
            var result = profile.Exclusions != null
                && profile.Exclusions.MobileSpecified
                && profile.Exclusions.Mobile;

            return result;
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
            var result = profiles.Where(p => HasSmartPhoneExclusion(p) == Value);

            return result;
        }

        private static bool HasSmartPhoneExclusion(DVD profile)
        {
            var result = profile.Exclusions != null
                && profile.Exclusions.iPhoneSpecified
                && profile.Exclusions.iPhone;

            return result;
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
                    var subset = filters[filterIndex].Filter(profiles);

                    filtered = filtered.Union(subset);
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
                    var subset = filters[filterIndex].Filter(filtered);

                    filtered = subset;
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

    partial class HasReleaseDateItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => p.ReleasedSpecified == Choice);

            return result;
        }

        public override Item Clone()
        {
            return new HasReleaseDateItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasRatingItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasRating(p) == Choice);

            return result;
        }

        private static bool HasRating(DVD profile)
        {
            var result = !string.IsNullOrWhiteSpace(profile.Rating);

            return result;
        }

        public override Item Clone()
        {
            return new HasRatingItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasRatingEqualToItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => RatingEqualTo(p) == Choice);

            return result;
        }

        private bool RatingEqualTo(DVD profile)
        {
            var result = profile.Rating.IsExpected(Value);

            return result;
        }

        public override Item Clone()
        {
            return new HasRatingEqualToItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class HasRatingSystemEqualToItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => RatingSystemEqualTo(p) == Choice);

            return result;
        }

        private bool RatingSystemEqualTo(DVD profile)
        {
            var result = profile.RatingSystem.IsExpected(Value);

            return result;
        }

        public override Item Clone()
        {
            return new HasRatingSystemEqualToItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class HasAspectRatioItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasAspectRatio(p) == Choice);

            return result;
        }

        private static bool HasAspectRatio(DVD profile)
        {
            var result = profile.Format != null && !string.IsNullOrWhiteSpace(profile.Format.AspectRatio);

            return result;
        }

        public override Item Clone()
        {
            return new HasAspectRatioItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasColorFormatItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasColorFormat(p) == Choice);

            return result;
        }

        private static bool HasColorFormat(DVD profile)
        {
            var result = profile.Format?.Color != null
                && (profile.Format.Color.Color
                    || profile.Format.Color.BlackAndWhite
                    || profile.Format.Color.Colorized
                    || profile.Format.Color.Mixed);

            return result;
        }

        public override Item Clone()
        {
            return new HasColorFormatItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasDimensionsItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasDimensions(p) == Choice);

            return result;
        }

        private static bool HasDimensions(DVD profile)
        {
            var result = profile.Format?.Dimensions != null
                && (profile.Format.Dimensions.Dim2D
                    || profile.Format.Dimensions.Dim3DAnaglyph
                    || profile.Format.Dimensions.Dim3DBluRay);

            return result;
        }

        public override Item Clone()
        {
            return new HasDimensionsItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasVideoFormatItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasVideoFormat(p) == Choice);

            return result;
        }

        private static bool HasVideoFormat(DVD profile)
        {
            var result = profile.Format != null
                && (profile.Format.PanAndScan
                    || profile.Format.FullFrame
                    || profile.Format.LetterBox);

            return result;
        }

        public override Item Clone()
        {
            return new HasVideoFormatItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasFeaturesItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasFeatures(p) == Choice);

            return result;
        }

        private static bool HasFeatures(DVD profile)
        {
            var features = profile.Features;

            if (features != null)
            {
                var result = features.BDLive
                    || features.BonusTrailers
                    || features.CineChat
                    || features.ClosedCaptioned
                    || features.Commentary
                    || features.DBOX
                    || features.DeletedScenes
                    || features.DigitalCopy
                    || features.DVDROMContent
                    || features.Game
                    || features.Interviews
                    || features.MakingOf
                    || features.MovieIQ
                    || features.MultiAngle
                    || features.MusicVideos
                    || features.Outtakes
                    || features.PhotoGallery
                    || features.PIP
                    || features.PlayAll
                    || features.ProductionNotes
                    || features.SceneAccess
                    || features.StoryboardComparisons
                    || features.THXCertified
                    || features.Trailer
                    || !string.IsNullOrWhiteSpace(features.OtherFeatures);

                return result;
            }
            else
            {
                return false;
            }
        }

        public override Item Clone()
        {
            return new HasFeaturesItem
            {
                Choice = Choice,
            };
        }
    }

    partial class HasAudioTracksItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasAudioTracks(p) == Choice);

            return result;
        }

        private bool HasAudioTracks(DVD profile)
        {
            var result = profile.AudioList != null
                && profile.AudioList.Any(a => !string.IsNullOrWhiteSpace(a.Content));

            return result;
        }

        public override Item Clone()
        {
            return new HasAudioTracksItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasAudioTrackItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasAudioTrack(p) == Choice);

            return result;
        }

        private bool HasAudioTrack(DVD profile)
        {
            var result = profile.AudioList != null
                && profile.AudioList.Any(a => a.Content.IsExpected(Value));

            return result;
        }

        public override Item Clone()
        {
            return new HasAudioTrackItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class HasSubtitlesItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasSubtitles(p) == Choice);

            return result;
        }

        private bool HasSubtitles(DVD profile)
        {
            var result = profile.AudioList != null
                && profile.AudioList.Any(a => !string.IsNullOrWhiteSpace(a.Content));

            return result;
        }

        public override Item Clone()
        {
            return new HasSubtitlesItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasSubtitleItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasSubtitle(p) == Choice);

            return result;
        }

        private bool HasSubtitle(DVD profile)
        {
            var result = profile.SubtitleList != null
                && profile.SubtitleList.Any(s => s.IsExpected(Value));

            return result;
        }

        public override Item Clone()
        {
            return new HasSubtitleItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class HasOverviewItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasOverview(p) == Choice);

            return result;
        }

        private static bool HasOverview(DVD profile)
        {
            var result = !string.IsNullOrWhiteSpace(profile.Overview);

            return result;
        }

        public override Item Clone()
        {
            return new HasOverviewItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasDiscsItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasDiscs(p) == Choice);

            return result;
        }

        private static bool HasDiscs(DVD profile)
        {
            var result = profile.DiscList != null
                && profile.DiscList.Any();

            return result;
        }

        public override Item Clone()
        {
            return new HasDiscsItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasBoxSetChildrenItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasBoxSetChildren(p) == Choice);

            return result;
        }

        private static bool HasBoxSetChildren(DVD profile)
        {
            var result = profile.BoxSet != null
                && profile.BoxSet.ContentList != null
                && profile.BoxSet.ContentList.Any();

            return result;
        }

        public override Item Clone()
        {
            return new HasBoxSetChildrenItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasPurchaseDateItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasPurchaseDate(p) == Choice);

            return result;
        }

        private static bool HasPurchaseDate(DVD profile)
        {
            var result = profile.PurchaseInfo != null
                && profile.PurchaseInfo.DateSpecified;

            return result;
        }

        public override Item Clone()
        {
            return new HasPurchaseDateItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasPurchasePlaceItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasPurchasePlace(p) == Choice);

            return result;
        }

        private static bool HasPurchasePlace(DVD profile)
        {
            var result = profile.PurchaseInfo != null
                && !string.IsNullOrWhiteSpace(profile.PurchaseInfo.Place);

            return result;
        }

        public override Item Clone()
        {
            return new HasPurchasePlaceItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasPurchasePriceItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasPurchasePrice(p) == Choice);

            return result;
        }

        private static bool HasPurchasePrice(DVD profile)
        {
            var result = profile.PurchaseInfo != null
                && profile.PurchaseInfo.Price.CheckValue();

            return result;
        }

        public override Item Clone()
        {
            return new HasPurchasePriceItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasPurchaseCurrencyItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasPurchaseCurrency(p) == Choice);

            return result;
        }

        private static bool HasPurchaseCurrency(DVD profile)
        {
            var result = profile.PurchaseInfo?.Price != null
                && !string.IsNullOrWhiteSpace(profile.PurchaseInfo.Price.DenominationType);

            return result;
        }

        public override Item Clone()
        {
            return new HasPurchaseCurrencyItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class IsPurchaseCurrencyItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasPurchaseCurrency(p) == Choice);

            return result;
        }

        private bool HasPurchaseCurrency(DVD profile)
        {
            var result = profile.PurchaseInfo?.Price != null
                && (profile.PurchaseInfo.Price.DenominationType.IsExpected(Value)
                    || profile.PurchaseInfo.Price.DenominationDesc.IsExpected(Value));

            return result;
        }

        public override Item Clone()
        {
            return new IsPurchaseCurrencyItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class IsPurchasePlaceItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => IsPurchasePlace(p) == Choice);

            return result;
        }

        private bool IsPurchasePlace(DVD profile)
        {
            var result = profile.PurchaseInfo != null
                && profile.PurchaseInfo.Place.IsExpected(Value);

            return result;
        }

        public override Item Clone()
        {
            return new IsPurchasePlaceItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }
}