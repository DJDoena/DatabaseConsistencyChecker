using System.Linq;
using v2_0 = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_0;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v1_1
{
    partial class CheckConfiguration
    {
        public v2_0.CheckConfiguration Upgrade()
        {
            return new v2_0.CheckConfiguration()
            {
                Rule = (Rule ?? Enumerable.Empty<RuleItem>()).Where(r => r != null).Select(r => r.Upgrade()).ToArray(),
                Version = 2.0m,
            };
        }
    }

    partial class RuleItem
    {
        public v2_0.RuleItem Upgrade()
        {
            return new v2_0.RuleItem()
            {
                Name = Name,
                Filter = Filter?.Upgrade(),
                Check = (Check ?? Enumerable.Empty<CheckItem>()).Where(c => c != null).Select(c => c.Upgrade()).ToArray(),
            };
        }
    }

    partial class Item
    {
        public abstract v2_0.Item Upgrade();
    }

    partial class CheckItem
    {
        public v2_0.CheckItem Upgrade()
        {
            return new v2_0.CheckItem()
            {
                Name = Name,
                Item = Item?.Upgrade(),
            };
        }
    }

    partial class CountAsEqualToItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.CountAsEqualToItem()
            {
                Choice = true,
                Value = Value,
            };
        }
    }

    partial class CountAsNotEqualToItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.CountAsEqualToItem()
            {
                Choice = false,
                Value = Value,
            };
        }
    }

    partial class IsPartOfOwnedCollectionItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.IsPartOfOwnedCollectionItem()
            {
                Choice = Value,
            };
        }
    }

    partial class MustContainGenreItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasGenreItem()
            {
                Choice = true,
                Value = Value,
            };
        }
    }

    partial class MustNotContainGenreItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasGenreItem()
            {
                Choice = false,
                Value = Value,
            };
        }
    }

    partial class MustContainTagItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasTagItem()
            {
                Choice = true,
                Value = Value,
            };
        }
    }

    partial class MustNotContainTagItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasTagItem()
            {
                Choice = false,
                Value = Value,
            };
        }
    }


    partial class IsMediaTypeDVDItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.IsMediaTypeDVDItem()
            {
                Choice = Value,
            };
        }
    }

    partial class IsMediaTypeBluRayItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.IsMediaTypeBluRayItem()
            {
                Choice = Value,
            };
        }
    }

    partial class IsMediaTypeUltraHDItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.IsMediaTypeUltraHDItem()
            {
                Choice = Value,
            };
        }
    }

    partial class IsMediaTypeHDDVDItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.IsMediaTypeHDDVDItem()
            {
                Choice = Value,
            };
        }
    }

    partial class IsCustomMediaTypeItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.IsCustomMediaTypeItem()
            {
                Choice = true,
                Value = Value,
            };
        }
    }

    partial class IsNotCustomMediaTypeItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.IsCustomMediaTypeItem()
            {
                Choice = false,
                Value = Value,
            };
        }
    }

    partial class HasCustomMediaTypeItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasCustomMediaTypeItem()
            {
                Choice = Value,
            };
        }
    }

    partial class IsCollectionTypeItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.IsCollectionTypeItem()
            {
                Choice = true,
                Value = Value,
            };
        }
    }

    partial class IsNotCollectionTypeItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.IsCollectionTypeItem()
            {
                Choice = false,
                Value = Value,
            };
        }
    }

    partial class IsCollectionNumberSetItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasCollectionNumberItem()
            {
                Choice = Value,
            };
        }
    }

    partial class IsRunningTimeSetItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasRunningTimeItem()
            {
                Choice = Value,
            };
        }
    }

    partial class MustContainGenresItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasGenresItem()
            {
                Choice = true,
            };
        }
    }

    partial class MustNotContainGenresItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasGenresItem()
            {
                Choice = false,
            };
        }
    }

    partial class MustContainStudiosItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasStudiosItem()
            {
                Choice = true,
            };
        }
    }

    partial class MustNotContainStudiosItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasStudiosItem()
            {
                Choice = false,
            };
        }
    }

    partial class MustContainMediaCompaniesItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasMediaCompaniesItem()
            {
                Choice = true,
            };
        }
    }

    partial class MustNotContainMediaCompaniesItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasMediaCompaniesItem()
            {
                Choice = false,
            };
        }
    }

    partial class MustContainCountryOfOriginsItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasCountryOfOriginsItem()
            {
                Choice = true,
            };
        }
    }

    partial class MustNotContainCountryOfOriginsItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasCountryOfOriginsItem()
            {
                Choice = false,
            };
        }
    }

    partial class IsProductionYearSet
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasProductionYearItem()
            {
                Choice = Value,
            };
        }
    }

    partial class HasCastItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasCastItem()
            {
                Choice = Value,
            };
        }
    }

    partial class HasCrewItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasCrewItem()
            {
                Choice = Value,
            };
        }
    }

    partial class HasEventItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasEventItem()
            {
                Choice = Value,
                EventType = (v2_0.HasEventItemEventType)EventType,
                UserFirstName = UserFirstName,
                UserLastName = UserLastName,
            };
        }
    }

    partial class HasOnlinePublicExclusionItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasOnlinePublicExclusionItem()
            {
                Choice = Value,
            };
        }
    }

    partial class HasOnlinePrivateExclusionItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasOnlinePrivateExclusionItem()
            {
                Choice = Value,
            };
        }
    }

    partial class HasPDAExclusionItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasPDAExclusionItem()
            {
                Choice = Value,
            };
        }
    }

    partial class HasSmartPhoneExclusionItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasSmartPhoneExclusionItem()
            {
                Choice = Value,
            };
        }
    }

    partial class ExceptItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.ExceptItem()
            {
                Except = Except?.Upgrade(),
            };
        }
    }

    partial class OrItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.OrItem()
            {
                Or = (Or ?? Enumerable.Empty<Item>()).Where(o => o != null).Select(o => o.Upgrade()).ToArray(),
            };
        }
    }

    partial class AndItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.AndItem()
            {
                And = (And ?? Enumerable.Empty<Item>()).Where(a => a != null).Select(a => a.Upgrade()).ToArray(),
            };
        }
    }

    partial class HasReleaseDateItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasReleaseDateItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasRatingItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasRatingItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasRatingEqualToItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.RatingEqualToItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class HasRatingSystemEqualToItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.RatingSystemEqualToItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class HasAspectRatioItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasAspectRatioItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasColorFormatItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasColorFormatItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasDimensionsItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasDimensionsItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasVideoFormatItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasVideoFormatItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasFeaturesItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasFeaturesItem
            {
                Choice = Choice,
            };
        }
    }

    partial class HasAudioTracksItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasAudioTracksItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasAudioTrackItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasAudioTrackItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class HasSubtitlesItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasSubtitlesItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasSubtitleItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasSubtitleItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class HasOverviewItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasOverviewItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasDiscsItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasDiscsItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasBoxSetChildrenItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasBoxSetChildrenItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasPurchaseDateItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasPurchaseDateItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasPurchasePlaceItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasPurchasePlaceItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasPurchasePriceItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasPurchasePriceItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class HasPurchaseCurrencyItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.HasPurchaseCurrencyItem()
            {
                Choice = Choice,
            };
        }
    }

    partial class IsPurchaseCurrencyItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.IsPurchaseCurrencyItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }

    partial class IsPurchasePlaceItem
    {
        public override v2_0.Item Upgrade()
        {
            return new v2_0.IsPurchasePlaceItem()
            {
                Choice = Choice,
                Value = Value,
            };
        }
    }
}