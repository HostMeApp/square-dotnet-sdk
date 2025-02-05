
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Square;
using Square.Utilities;

namespace Square.Models
{
    public class CatalogItem 
    {
        public CatalogItem(string name = null,
            string description = null,
            string abbreviation = null,
            string labelColor = null,
            bool? availableOnline = null,
            bool? availableForPickup = null,
            bool? availableElectronically = null,
            string categoryId = null,
            IList<string> taxIds = null,
            IList<Models.CatalogItemModifierListInfo> modifierListInfo = null,
            IList<Models.CatalogObject> variations = null,
            string productType = null,
            bool? skipModifierScreen = null,
            IList<Models.CatalogItemOptionForItem> itemOptions = null)
        {
            Name = name;
            Description = description;
            Abbreviation = abbreviation;
            LabelColor = labelColor;
            AvailableOnline = availableOnline;
            AvailableForPickup = availableForPickup;
            AvailableElectronically = availableElectronically;
            CategoryId = categoryId;
            TaxIds = taxIds;
            ModifierListInfo = modifierListInfo;
            Variations = variations;
            ProductType = productType;
            SkipModifierScreen = skipModifierScreen;
            ItemOptions = itemOptions;
        }

        /// <summary>
        /// The item's name. This is a searchable attribute for use in applicable query filters, its value must not be empty, and the length is of Unicode code points.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; }

        /// <summary>
        /// The item's description. This is a searchable attribute for use in applicable query filters, and its value length is of Unicode code points.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; }

        /// <summary>
        /// The text of the item's display label in the Square Point of Sale app. Only up to the first five characters of the string are used.
        /// This attribute is searchable, and its value length is of Unicode code points.
        /// </summary>
        [JsonProperty("abbreviation", NullValueHandling = NullValueHandling.Ignore)]
        public string Abbreviation { get; }

        /// <summary>
        /// The color of the item's display label in the Square Point of Sale app. This must be a valid hex color code.
        /// </summary>
        [JsonProperty("label_color", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelColor { get; }

        /// <summary>
        /// If `true`, the item can be added to shipping orders from the merchant's online store.
        /// </summary>
        [JsonProperty("available_online", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AvailableOnline { get; }

        /// <summary>
        /// If `true`, the item can be added to pickup orders from the merchant's online store.
        /// </summary>
        [JsonProperty("available_for_pickup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AvailableForPickup { get; }

        /// <summary>
        /// If `true`, the item can be added to electronically fulfilled orders from the merchant's online store.
        /// </summary>
        [JsonProperty("available_electronically", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AvailableElectronically { get; }

        /// <summary>
        /// The ID of the item's category, if any.
        /// </summary>
        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryId { get; }

        /// <summary>
        /// A set of IDs indicating the taxes enabled for
        /// this item. When updating an item, any taxes listed here will be added to the item.
        /// Taxes may also be added to or deleted from an item using `UpdateItemTaxes`.
        /// </summary>
        [JsonProperty("tax_ids", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> TaxIds { get; }

        /// <summary>
        /// A set of `CatalogItemModifierListInfo` objects
        /// representing the modifier lists that apply to this item, along with the overrides and min
        /// and max limits that are specific to this item. Modifier lists
        /// may also be added to or deleted from an item using `UpdateItemModifierLists`.
        /// </summary>
        [JsonProperty("modifier_list_info", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.CatalogItemModifierListInfo> ModifierListInfo { get; }

        /// <summary>
        /// A list of CatalogObjects containing the `CatalogItemVariation`s for this item.
        /// </summary>
        [JsonProperty("variations", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.CatalogObject> Variations { get; }

        /// <summary>
        /// The type of a CatalogItem. Connect V2 only allows the creation of `REGULAR` or `APPOINTMENTS_SERVICE` items.
        /// </summary>
        [JsonProperty("product_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductType { get; }

        /// <summary>
        /// If `false`, the Square Point of Sale app will present the `CatalogItem`'s
        /// details screen immediately, allowing the merchant to choose `CatalogModifier`s
        /// before adding the item to the cart.  This is the default behavior.
        /// If `true`, the Square Point of Sale app will immediately add the item to the cart with the pre-selected
        /// modifiers, and merchants can edit modifiers by drilling down onto the item's details.
        /// Third-party clients are encouraged to implement similar behaviors.
        /// </summary>
        [JsonProperty("skip_modifier_screen", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SkipModifierScreen { get; }

        /// <summary>
        /// List of item options IDs for this item. Used to manage and group item
        /// variations in a specified order.
        /// Maximum: 6 item options.
        /// </summary>
        [JsonProperty("item_options", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.CatalogItemOptionForItem> ItemOptions { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CatalogItem : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {(Name == null ? "null" : Name == string.Empty ? "" : Name)}");
            toStringOutput.Add($"Description = {(Description == null ? "null" : Description == string.Empty ? "" : Description)}");
            toStringOutput.Add($"Abbreviation = {(Abbreviation == null ? "null" : Abbreviation == string.Empty ? "" : Abbreviation)}");
            toStringOutput.Add($"LabelColor = {(LabelColor == null ? "null" : LabelColor == string.Empty ? "" : LabelColor)}");
            toStringOutput.Add($"AvailableOnline = {(AvailableOnline == null ? "null" : AvailableOnline.ToString())}");
            toStringOutput.Add($"AvailableForPickup = {(AvailableForPickup == null ? "null" : AvailableForPickup.ToString())}");
            toStringOutput.Add($"AvailableElectronically = {(AvailableElectronically == null ? "null" : AvailableElectronically.ToString())}");
            toStringOutput.Add($"CategoryId = {(CategoryId == null ? "null" : CategoryId == string.Empty ? "" : CategoryId)}");
            toStringOutput.Add($"TaxIds = {(TaxIds == null ? "null" : $"[{ string.Join(", ", TaxIds)} ]")}");
            toStringOutput.Add($"ModifierListInfo = {(ModifierListInfo == null ? "null" : $"[{ string.Join(", ", ModifierListInfo)} ]")}");
            toStringOutput.Add($"Variations = {(Variations == null ? "null" : $"[{ string.Join(", ", Variations)} ]")}");
            toStringOutput.Add($"ProductType = {(ProductType == null ? "null" : ProductType.ToString())}");
            toStringOutput.Add($"SkipModifierScreen = {(SkipModifierScreen == null ? "null" : SkipModifierScreen.ToString())}");
            toStringOutput.Add($"ItemOptions = {(ItemOptions == null ? "null" : $"[{ string.Join(", ", ItemOptions)} ]")}");
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is CatalogItem other &&
                ((Name == null && other.Name == null) || (Name?.Equals(other.Name) == true)) &&
                ((Description == null && other.Description == null) || (Description?.Equals(other.Description) == true)) &&
                ((Abbreviation == null && other.Abbreviation == null) || (Abbreviation?.Equals(other.Abbreviation) == true)) &&
                ((LabelColor == null && other.LabelColor == null) || (LabelColor?.Equals(other.LabelColor) == true)) &&
                ((AvailableOnline == null && other.AvailableOnline == null) || (AvailableOnline?.Equals(other.AvailableOnline) == true)) &&
                ((AvailableForPickup == null && other.AvailableForPickup == null) || (AvailableForPickup?.Equals(other.AvailableForPickup) == true)) &&
                ((AvailableElectronically == null && other.AvailableElectronically == null) || (AvailableElectronically?.Equals(other.AvailableElectronically) == true)) &&
                ((CategoryId == null && other.CategoryId == null) || (CategoryId?.Equals(other.CategoryId) == true)) &&
                ((TaxIds == null && other.TaxIds == null) || (TaxIds?.Equals(other.TaxIds) == true)) &&
                ((ModifierListInfo == null && other.ModifierListInfo == null) || (ModifierListInfo?.Equals(other.ModifierListInfo) == true)) &&
                ((Variations == null && other.Variations == null) || (Variations?.Equals(other.Variations) == true)) &&
                ((ProductType == null && other.ProductType == null) || (ProductType?.Equals(other.ProductType) == true)) &&
                ((SkipModifierScreen == null && other.SkipModifierScreen == null) || (SkipModifierScreen?.Equals(other.SkipModifierScreen) == true)) &&
                ((ItemOptions == null && other.ItemOptions == null) || (ItemOptions?.Equals(other.ItemOptions) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = -268666674;

            if (Name != null)
            {
               hashCode += Name.GetHashCode();
            }

            if (Description != null)
            {
               hashCode += Description.GetHashCode();
            }

            if (Abbreviation != null)
            {
               hashCode += Abbreviation.GetHashCode();
            }

            if (LabelColor != null)
            {
               hashCode += LabelColor.GetHashCode();
            }

            if (AvailableOnline != null)
            {
               hashCode += AvailableOnline.GetHashCode();
            }

            if (AvailableForPickup != null)
            {
               hashCode += AvailableForPickup.GetHashCode();
            }

            if (AvailableElectronically != null)
            {
               hashCode += AvailableElectronically.GetHashCode();
            }

            if (CategoryId != null)
            {
               hashCode += CategoryId.GetHashCode();
            }

            if (TaxIds != null)
            {
               hashCode += TaxIds.GetHashCode();
            }

            if (ModifierListInfo != null)
            {
               hashCode += ModifierListInfo.GetHashCode();
            }

            if (Variations != null)
            {
               hashCode += Variations.GetHashCode();
            }

            if (ProductType != null)
            {
               hashCode += ProductType.GetHashCode();
            }

            if (SkipModifierScreen != null)
            {
               hashCode += SkipModifierScreen.GetHashCode();
            }

            if (ItemOptions != null)
            {
               hashCode += ItemOptions.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Name(Name)
                .Description(Description)
                .Abbreviation(Abbreviation)
                .LabelColor(LabelColor)
                .AvailableOnline(AvailableOnline)
                .AvailableForPickup(AvailableForPickup)
                .AvailableElectronically(AvailableElectronically)
                .CategoryId(CategoryId)
                .TaxIds(TaxIds)
                .ModifierListInfo(ModifierListInfo)
                .Variations(Variations)
                .ProductType(ProductType)
                .SkipModifierScreen(SkipModifierScreen)
                .ItemOptions(ItemOptions);
            return builder;
        }

        public class Builder
        {
            private string name;
            private string description;
            private string abbreviation;
            private string labelColor;
            private bool? availableOnline;
            private bool? availableForPickup;
            private bool? availableElectronically;
            private string categoryId;
            private IList<string> taxIds;
            private IList<Models.CatalogItemModifierListInfo> modifierListInfo;
            private IList<Models.CatalogObject> variations;
            private string productType;
            private bool? skipModifierScreen;
            private IList<Models.CatalogItemOptionForItem> itemOptions;



            public Builder Name(string name)
            {
                this.name = name;
                return this;
            }

            public Builder Description(string description)
            {
                this.description = description;
                return this;
            }

            public Builder Abbreviation(string abbreviation)
            {
                this.abbreviation = abbreviation;
                return this;
            }

            public Builder LabelColor(string labelColor)
            {
                this.labelColor = labelColor;
                return this;
            }

            public Builder AvailableOnline(bool? availableOnline)
            {
                this.availableOnline = availableOnline;
                return this;
            }

            public Builder AvailableForPickup(bool? availableForPickup)
            {
                this.availableForPickup = availableForPickup;
                return this;
            }

            public Builder AvailableElectronically(bool? availableElectronically)
            {
                this.availableElectronically = availableElectronically;
                return this;
            }

            public Builder CategoryId(string categoryId)
            {
                this.categoryId = categoryId;
                return this;
            }

            public Builder TaxIds(IList<string> taxIds)
            {
                this.taxIds = taxIds;
                return this;
            }

            public Builder ModifierListInfo(IList<Models.CatalogItemModifierListInfo> modifierListInfo)
            {
                this.modifierListInfo = modifierListInfo;
                return this;
            }

            public Builder Variations(IList<Models.CatalogObject> variations)
            {
                this.variations = variations;
                return this;
            }

            public Builder ProductType(string productType)
            {
                this.productType = productType;
                return this;
            }

            public Builder SkipModifierScreen(bool? skipModifierScreen)
            {
                this.skipModifierScreen = skipModifierScreen;
                return this;
            }

            public Builder ItemOptions(IList<Models.CatalogItemOptionForItem> itemOptions)
            {
                this.itemOptions = itemOptions;
                return this;
            }

            public CatalogItem Build()
            {
                return new CatalogItem(name,
                    description,
                    abbreviation,
                    labelColor,
                    availableOnline,
                    availableForPickup,
                    availableElectronically,
                    categoryId,
                    taxIds,
                    modifierListInfo,
                    variations,
                    productType,
                    skipModifierScreen,
                    itemOptions);
            }
        }
    }
}