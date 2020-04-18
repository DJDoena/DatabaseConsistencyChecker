﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_1 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class CheckConfiguration {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rule")]
        public RuleItem[] Rule;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Version;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RuleItem {
        
        /// <remarks/>
        public Item Filter;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Check")]
        public CheckItem[] Check;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LogicItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AndItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExceptItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NoParameterItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasEventBeforePurchaseDateItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasExtrasReviewItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasAudioReviewItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasDVDReviewItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasMovieReviewItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasEasterEggsItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasSRPCurrencyItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasSRPPriceItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasCaseTypeItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasPurchaseCurrencyItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasPurchasePriceItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasPurchasePlaceItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasPurchaseDateItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasBoxSetChildrenItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasDiscsItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasOverviewItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasSubtitlesItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasAudioTracksItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasFeaturesItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasVideoFormatItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasDimensionsItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasColorFormatItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasAspectRatioItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasRatingItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasReleaseDateItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasSmartphoneExclusionItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasPDAExclusionItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasOnlinePrivateExclusionItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasOnlinePublicExclusionItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasEventItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasCrewItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasCastItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasProductionYearItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasCountryOfOriginsItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasMediaCompaniesItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasStudiosItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasGenresItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasRunningTimeItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasCollectionNumberItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasCustomMediaTypeItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsMediaTypeHDDVDItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsMediaTypeUltraHDItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsMediaTypeBluRayItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsMediaTypeDVDItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsPartOfOwnedCollectionItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DateItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CrewMemberBirthYearIsLargerThanItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CastMemberBirthYearIsLargerThanItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EventDateDateIsLargerThanItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PurchaseDateIsLargerThanItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsCountAsItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsSRPCurrencyItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsCaseTypeItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsPurchasePlaceItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsPurchaseCurrencyItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasSubtitleItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasAudioTrackItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsRatingSystemItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsRatingItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsCustomMediaTypeItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsCollectionTypeItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasTagItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasGenreItem))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public abstract partial class Item {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckItem {
        
        /// <remarks/>
        public Item Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AndItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExceptItem))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public abstract partial class LogicItem : Item {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AndItem : LogicItem {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("And")]
        public Item[] And;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OrItem : LogicItem {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Or")]
        public Item[] Or;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExceptItem : LogicItem {
        
        /// <remarks/>
        public Item Except;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasEventBeforePurchaseDateItem))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public abstract partial class NoParameterItem : Item {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasEventBeforePurchaseDateItem : NoParameterItem {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasExtrasReviewItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasAudioReviewItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasDVDReviewItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasMovieReviewItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasEasterEggsItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasSRPCurrencyItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasSRPPriceItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasCaseTypeItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasPurchaseCurrencyItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasPurchasePriceItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasPurchasePlaceItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasPurchaseDateItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasBoxSetChildrenItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasDiscsItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasOverviewItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasSubtitlesItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasAudioTracksItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasFeaturesItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasVideoFormatItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasDimensionsItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasColorFormatItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasAspectRatioItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasRatingItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasReleaseDateItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasSmartphoneExclusionItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasPDAExclusionItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasOnlinePrivateExclusionItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasOnlinePublicExclusionItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasEventItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasCrewItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasCastItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasProductionYearItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasCountryOfOriginsItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasMediaCompaniesItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasStudiosItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasGenresItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasRunningTimeItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasCollectionNumberItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasCustomMediaTypeItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsMediaTypeHDDVDItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsMediaTypeUltraHDItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsMediaTypeBluRayItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsMediaTypeDVDItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsPartOfOwnedCollectionItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DateItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CrewMemberBirthYearIsLargerThanItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CastMemberBirthYearIsLargerThanItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EventDateDateIsLargerThanItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PurchaseDateIsLargerThanItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsCountAsItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsSRPCurrencyItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsCaseTypeItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsPurchasePlaceItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsPurchaseCurrencyItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasSubtitleItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasAudioTrackItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsRatingSystemItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsRatingItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsCustomMediaTypeItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsCollectionTypeItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasTagItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasGenreItem))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public abstract partial class ValueItem : Item {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Choice;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasExtrasReviewItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasAudioReviewItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasDVDReviewItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasMovieReviewItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasEasterEggsItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasSRPCurrencyItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasSRPPriceItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasCaseTypeItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasPurchaseCurrencyItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasPurchasePriceItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasPurchasePlaceItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasPurchaseDateItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasBoxSetChildrenItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasDiscsItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasOverviewItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasSubtitlesItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasAudioTracksItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasFeaturesItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasVideoFormatItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasDimensionsItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasColorFormatItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasAspectRatioItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasRatingItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasReleaseDateItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasSmartphoneExclusionItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasPDAExclusionItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasOnlinePrivateExclusionItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasOnlinePublicExclusionItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasEventItem : ValueItem {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserFirstName;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserLastName;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HasEventItemEventType EventType;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum HasEventItemEventType {
        
        /// <remarks/>
        Watched,
        
        /// <remarks/>
        Returned,
        
        /// <remarks/>
        Borrowed,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasCrewItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasCastItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasProductionYearItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasCountryOfOriginsItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasMediaCompaniesItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasStudiosItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasGenresItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasRunningTimeItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasCollectionNumberItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasCustomMediaTypeItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsMediaTypeHDDVDItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsMediaTypeUltraHDItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsMediaTypeBluRayItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsMediaTypeDVDItem : ValueItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsPartOfOwnedCollectionItem : ValueItem {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CrewMemberBirthYearIsLargerThanItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CastMemberBirthYearIsLargerThanItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EventDateDateIsLargerThanItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PurchaseDateIsLargerThanItem))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public abstract partial class DateItem : ValueItem {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime Value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsToday;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CrewMemberBirthYearIsLargerThanItem : DateItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CastMemberBirthYearIsLargerThanItem : DateItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EventDateDateIsLargerThanItem : DateItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PurchaseDateIsLargerThanItem : DateItem {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsCountAsItem))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public abstract partial class IntItem : ValueItem {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Value;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsCountAsItem : IntItem {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsSRPCurrencyItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsCaseTypeItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsPurchasePlaceItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsPurchaseCurrencyItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasSubtitleItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasAudioTrackItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsRatingSystemItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsRatingItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsCustomMediaTypeItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IsCollectionTypeItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasTagItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HasGenreItem))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public abstract partial class StringItem : ValueItem {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsSRPCurrencyItem : StringItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsCaseTypeItem : StringItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsPurchasePlaceItem : StringItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsPurchaseCurrencyItem : StringItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasSubtitleItem : StringItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasAudioTrackItem : StringItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsRatingSystemItem : StringItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsRatingItem : StringItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsCustomMediaTypeItem : StringItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsCollectionTypeItem : StringItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasTagItem : StringItem {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HasGenreItem : StringItem {
    }
}
