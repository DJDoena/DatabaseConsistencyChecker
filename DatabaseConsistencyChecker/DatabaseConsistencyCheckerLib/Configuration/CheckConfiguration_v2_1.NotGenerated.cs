using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DoenaSoft.DVDProfiler.DVDProfilerXML.Version400;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_1
{
    //xsd.exe CheckConfiguration_v2_1.xsd /c /l:cs /f /n:DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_1

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

        public virtual IEnumerable<DVD> Check(IEnumerable<DVD> profiles)
        {
            var correct = Filter(profiles);

            var incorrect = profiles.Except(correct);

            return incorrect;
        }

        public abstract Item Clone();

        public override string ToString() => string.Empty;
    }

    partial class ValueItem
    {
        public override string ToString() => Choice.ToString();
    }

    partial class StringItem
    {
        public override string ToString() => $"{(Choice ? "Must be" : "Must not be")}: {Value}";
    }

    partial class IntItem
    {
        public override string ToString() => $"{(Choice ? "Must be" : "Must not be")}: {Value}";
    }

    partial class DateItem
    {
        public override string ToString() => $"{(Choice ? "Must be larger than" : "Must be smaller than")}: {(IsToday ? DateTime.Today : Value.Date).ToShortDateString()}";
    }

    partial class NoParameterItem
    {
        public override string ToString() => string.Empty;
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

    partial class IsCountAsItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => IsCountAs(p) == Choice);

            return result;
        }

        private bool IsCountAs(DVD profile)
        {
            var result = profile.CountAs == Value;

            return result;
        }

        public override Item Clone()
        {
            return new IsCountAsItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class IsPartOfOwnedCollectionItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => IsPartOfOwnedCollection(p) == Choice);

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
                Choice = Choice,
            };
        }
    }

    partial class HasGenreItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasGenre(p) == Choice);

            return result;
        }

        private bool HasGenre(DVD profile)
        {
            var result = profile.GenreList != null
                && profile.GenreList.Any(g => g.IsExpected(Value));

            return result;
        }

        public override Item Clone()
        {
            return new HasGenreItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class HasTagItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasTag(p) == Choice);

            return result;
        }

        private bool HasTag(DVD profile)
        {
            var result = profile.TagList.HasTagName(Value);

            return result;
        }

        public override Item Clone()
        {
            return new HasTagItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class IsMediaTypeDVDItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => IsMediaTypeDVD(p) == Choice);

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
                Choice = Choice,
            };
        }
    }

    partial class IsMediaTypeBluRayItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => IsMediaTypeBluRay(p) == Choice);

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
                Choice = Choice,
            };
        }
    }

    partial class IsMediaTypeUltraHDItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => IsMediaTypeUltraHD(p) == Choice);

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
                Choice = Choice,
            };
        }
    }

    partial class IsMediaTypeHDDVDItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => IsMediaTypeHDDVD(p) == Choice);

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
                Choice = Choice,
            };
        }
    }

    partial class IsCustomMediaTypeItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => IsCustomMediaType(p) == Choice);

            return result;
        }

        private bool IsCustomMediaType(DVD profile)
        {
            var result = profile.MediaTypes != null
                && profile.MediaTypes.CustomMediaType.IsExpected(Value);

            return result;
        }

        public override Item Clone()
        {
            return new IsCustomMediaTypeItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class HasCustomMediaTypeItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasCustomeMediaType(p) == Choice);

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
                Choice = Choice,
            };
        }
    }

    partial class IsCollectionTypeItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => IsCollectionType(p) == Choice);

            return result;
        }

        private bool IsCollectionType(DVD profile)
        {
            var result = profile.CollectionType != null
                && profile.CollectionType.Value.IsExpected(Value);

            return result;
        }

        public override Item Clone()
        {
            return new IsCollectionTypeItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class HasCollectionNumberItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasCollectionNumber(p) == Choice);

            return result;
        }

        private static bool HasCollectionNumber(DVD profile)
        {
            var result = !string.IsNullOrWhiteSpace(profile.CollectionNumber);

            return result;
        }

        public override Item Clone()
        {
            return new HasCollectionNumberItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasRunningTimeItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasRunningTime(p) == Choice);

            return result;
        }

        private static bool HasRunningTime(DVD profile)
        {
            var result = profile.RunningTime > 0;

            return result;
        }

        public override Item Clone()
        {
            return new HasRunningTimeItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasGenresItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasGenres(p) == Choice);

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
            return new HasGenresItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasStudiosItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasStudios(p) == Choice);

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
            return new HasStudiosItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasMediaCompaniesItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasMediaCompanies(p) == Choice);

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
            return new HasMediaCompaniesItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasCountryOfOriginsItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasCountryOfOrigins(p) == Choice);

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
            return new HasCountryOfOriginsItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasProductionYearItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => IsProductionYearSetCheck(p) == Choice);

            return result;
        }

        private static bool IsProductionYearSetCheck(DVD profile)
        {
            var result = profile.ProductionYear > 0;

            return result;
        }

        public override Item Clone()
        {
            return new HasProductionYearItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasCastItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasCast(p) == Choice);

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
                Choice = Choice,
            };
        }
    }

    partial class HasCrewItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasCrew(p) == Choice);

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
                Choice = Choice,
            };
        }
    }

    partial class HasEventItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasEvent(p) == Choice);

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
                Choice = Choice,
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
            var result = profiles.Where(p => HasOnlinePublicExclusion(p) == Choice);

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
                Choice = Choice,
            };
        }
    }

    partial class HasOnlinePrivateExclusionItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasOnlinePrivateExclusion(p) == Choice);

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
                Choice = Choice,
            };
        }
    }

    partial class HasPDAExclusionItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasPDAExclusion(p) == Choice);

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
                Choice = Choice,
            };
        }
    }

    partial class HasSmartphoneExclusionItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasSmartPhoneExclusion(p) == Choice);

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
            return new HasSmartphoneExclusionItem()
            {
                Choice = Choice,
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

    partial class IsRatingItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => IsRating(p) == Choice);

            return result;
        }

        private bool IsRating(DVD profile)
        {
            var result = profile.Rating.IsExpected(Value);

            return result;
        }

        public override Item Clone()
        {
            return new IsRatingItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class IsRatingSystemItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => IsRatingSystem(p) == Choice);

            return result;
        }

        private bool IsRatingSystem(DVD profile)
        {
            var result = profile.RatingSystem.IsExpected(Value);

            return result;
        }

        public override Item Clone()
        {
            return new IsRatingSystemItem()
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
            var result = profile.PurchaseInfo != null
                && profile.PurchaseInfo.Price.HasCurrency();

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
            var result = profile.PurchaseInfo != null
                && profile.PurchaseInfo.Price.IsCurrency(Value);

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

    partial class HasCaseTypeItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasCaseType(p) == Choice);

            return result;
        }

        private static bool HasCaseType(DVD profile)
        {
            var result = !string.IsNullOrWhiteSpace(profile.CaseType);

            return result;
        }

        public override Item Clone()
        {
            return new HasCaseTypeItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class IsCaseTypeItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => IsCaseType(p) == Choice);

            return result;
        }

        private bool IsCaseType(DVD profile)
        {
            var result = profile.CaseType.IsExpected(Value);

            return result;
        }

        public override Item Clone()
        {
            return new IsCaseTypeItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class HasSRPPriceItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasSRPrice(p) == Choice);

            return result;
        }

        private static bool HasSRPrice(DVD profile)
        {
            var result = profile.SRP.CheckValue();

            return result;
        }

        public override Item Clone()
        {
            return new HasSRPPriceItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasSRPCurrencyItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasSRPCurrency(p) == Choice);

            return result;
        }

        private static bool HasSRPCurrency(DVD profile)
        {
            var result = profile.SRP.HasCurrency();

            return result;
        }

        public override Item Clone()
        {
            return new HasSRPCurrencyItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasEasterEggsItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasEasterEggs(p) == Choice);

            return result;
        }

        private static bool HasEasterEggs(DVD profile)
        {
            var result = !string.IsNullOrWhiteSpace(profile.EasterEggs);

            return result;
        }

        public override Item Clone()
        {
            return new HasEasterEggsItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasMovieReviewItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasMovieReview(p) == Choice);

            return result;
        }

        private static bool HasMovieReview(DVD profile)
        {
            var result = profile.Review != null
                && profile.Review.Film > 0;

            return result;
        }


        public override Item Clone()
        {
            return new HasMovieReviewItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasDVDReviewItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasDVDReview(p) == Choice);

            return result;
        }

        private static bool HasDVDReview(DVD profile)
        {
            var result = profile.Review != null
                && profile.Review.Video > 0;

            return result;
        }

        public override Item Clone()
        {
            return new HasDVDReviewItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasAudioReviewItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasAudioReview(p) == Choice);

            return result;
        }

        private static bool HasAudioReview(DVD profile)
        {
            var result = profile.Review != null
                && profile.Review.Audio > 0;

            return result;
        }

        public override Item Clone()
        {
            return new HasAudioReviewItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasExtrasReviewItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => HasExtrasReview(p) == Choice);

            return result;
        }

        private static bool HasExtrasReview(DVD profile)
        {
            var result = profile.Review != null
                && profile.Review.Extras > 0;

            return result;
        }

        public override Item Clone()
        {
            return new HasExtrasReviewItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class IsSRPCurrencyItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(p => IsSRPCurrency(p) == Choice);

            return result;
        }

        private bool IsSRPCurrency(DVD profile)
        {
            var result = profile.SRP.IsCurrency(Value);

            return result;
        }

        public override Item Clone()
        {
            return new IsSRPCurrencyItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class PurchaseDateIsLargerThanItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(IsMatch);

            return result;
        }

        public override IEnumerable<DVD> Check(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(IsMatch);

            return result;
        }

        private bool IsMatch(DVD profile)
        {
            if (profile.PurchaseInfo != null && profile.PurchaseInfo.DateSpecified)
            {
                var date = IsToday
                    ? DateTime.Today
                    : Value.Date;

                if (Choice)
                {
                    var result = profile.PurchaseInfo.Date.Date > date;

                    return result;
                }
                else
                {
                    var result = profile.PurchaseInfo.Date.Date < date;

                    return result;
                }
            }
            else
            {
                //it's not in filter, but it's also not a failed check
                return false;
            }
        }

        public override Item Clone()
        {
            return new PurchaseDateIsLargerThanItem()
            {
                Choice = Choice,
                Value = Value,
                IsToday = IsToday,
            };
        }
    }

    partial class EventDateDateIsLargerThanItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(IsMatch);

            return result;
        }

        public override IEnumerable<DVD> Check(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(IsMatch);

            return result;
        }

        private bool IsMatch(DVD profile)
        {
            var events = profile.EventList ?? Enumerable.Empty<Event>();

            if (events.Any())
            {
                var date = IsToday
                    ? DateTime.Today
                    : Value.Date;

                if (Choice)
                {
                    var result = events.Any(e => e.Timestamp.Date > date);

                    return result;
                }
                else
                {
                    var result = events.Any(e => e.Timestamp.Date < date);

                    return result;
                }
            }
            else
            {
                //it's not in filter, but it's also not a failed check
                return false;
            }
        }

        public override Item Clone()
        {
            return new EventDateDateIsLargerThanItem()
            {
                Choice = Choice,
                Value = Value,
                IsToday = IsToday,
            };
        }
    }

    partial class CastMemberBirthYearIsLargerThanItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(IsMatch);

            return result;
        }

        public override IEnumerable<DVD> Check(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(IsMatch);

            return result;
        }

        private bool IsMatch(DVD profile)
        {
            var castMembers = profile.CastList?.OfType<CastMember>() ?? Enumerable.Empty<CastMember>();

            castMembers = castMembers.Where(c => c.BirthYear != 0);

            if (castMembers.Any())
            {
                var year = IsToday
                    ? DateTime.Today.Year
                    : Value.Year;

                if (Choice)
                {
                    var result = castMembers.Any(c => c.BirthYear > year);

                    return result;
                }
                else
                {
                    var result = castMembers.Any(c => c.BirthYear < year);

                    return result;
                }
            }
            else
            {
                //it's not in filter, but it's also not a failed check
                return false;
            }
        }

        public override Item Clone()
        {
            return new CastMemberBirthYearIsLargerThanItem()
            {
                Choice = Choice,
                Value = Value,
                IsToday = IsToday,
            };
        }
    }

    partial class CrewMemberBirthYearIsLargerThanItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(IsMatch);

            return result;
        }

        public override IEnumerable<DVD> Check(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(IsMatch);

            return result;
        }

        private bool IsMatch(DVD profile)
        {
            var crewMembers = profile.CrewList?.OfType<CrewMember>() ?? Enumerable.Empty<CrewMember>();

            crewMembers = crewMembers.Where(c => c.BirthYear != 0);

            if (crewMembers.Any())
            {
                var year = IsToday
                    ? DateTime.Today.Year
                    : Value.Year;

                if (Choice)
                {
                    var result = crewMembers.Any(c => c.BirthYear > year);

                    return result;
                }
                else
                {
                    var result = crewMembers.Any(c => c.BirthYear < year);

                    return result;
                }
            }
            else
            {
                //it's not in filter, but it's also not a failed check
                return false;
            }
        }

        public override Item Clone()
        {
            return new CrewMemberBirthYearIsLargerThanItem()
            {
                Choice = Choice,
                Value = Value,
                IsToday = IsToday,
            };
        }
    }

    partial class HasEventBeforePurchaseDateItem
    {
        public override IEnumerable<DVD> Filter(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(IsMatch);

            return result;
        }

        public override IEnumerable<DVD> Check(IEnumerable<DVD> profiles)
        {
            var result = profiles.Where(IsMatch);

            return result;
        }

        private static bool IsMatch(DVD profile)
        {
            var events = profile.EventList ?? Enumerable.Empty<Event>();

            if (profile.PurchaseInfo != null && profile.PurchaseInfo.DateSpecified && events.Any())
            {
                var result = events.Any(e => e.Timestamp.Date < profile.PurchaseInfo.Date.Date);

                return result;
            }
            else
            {
                //it's not in filter, but it's also not a failed check
                return false;
            }
        }

        public override Item Clone()
        {
            return new HasEventBeforePurchaseDateItem()
            {
            };
        }
    }
}