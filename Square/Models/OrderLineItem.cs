
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
    public class OrderLineItem 
    {
        public OrderLineItem(string quantity = "0",
            string uid = null,
            string name = null,
            Models.OrderQuantityUnit quantityUnit = null,
            string note = null,
            string catalogObjectId = null,
            string variationName = null,
            IDictionary<string, string> metadata = null,
            IList<Models.OrderLineItemModifier> modifiers = null,
            IList<Models.OrderLineItemAppliedTax> appliedTaxes = null,
            IList<Models.OrderLineItemAppliedDiscount> appliedDiscounts = null,
            Models.Money basePriceMoney = null,
            Models.Money variationTotalPriceMoney = null,
            Models.Money grossSalesMoney = null,
            Models.Money totalTaxMoney = null,
            Models.Money totalDiscountMoney = null,
            Models.Money totalMoney = null,
            Models.OrderLineItemPricingBlocklists pricingBlocklists = null)
        {
            Uid = uid;
            Name = name;
            Quantity = quantity;
            QuantityUnit = quantityUnit;
            Note = note;
            CatalogObjectId = catalogObjectId;
            VariationName = variationName;
            Metadata = metadata;
            Modifiers = modifiers;
            AppliedTaxes = appliedTaxes;
            AppliedDiscounts = appliedDiscounts;
            BasePriceMoney = basePriceMoney;
            VariationTotalPriceMoney = variationTotalPriceMoney;
            GrossSalesMoney = grossSalesMoney;
            TotalTaxMoney = totalTaxMoney;
            TotalDiscountMoney = totalDiscountMoney;
            TotalMoney = totalMoney;
            PricingBlocklists = pricingBlocklists;
        }

        /// <summary>
        /// Unique ID that identifies the line item only within this order.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// The name of the line item.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The quantity purchased, formatted as a decimal number.
        /// For example: `"3"`.
        /// Line items with a quantity of `"0"` will be automatically removed
        /// upon paying for or otherwise completing the order.
        /// Line items with a `quantity_unit` can have non-integer quantities.
        /// For example: `"1.70000"`.
        /// </summary>
        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// Contains the measurement unit for a quantity and a precision which
        /// specifies the number of digits after the decimal point for decimal quantities.
        /// </summary>
        [JsonProperty("quantity_unit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderQuantityUnit QuantityUnit { get; set; }

        /// <summary>
        /// The note of the line item.
        /// </summary>
        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        /// <summary>
        /// The [CatalogItemVariation](#type-catalogitemvariation) id applied to this line item.
        /// </summary>
        [JsonProperty("catalog_object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CatalogObjectId { get; set; }

        /// <summary>
        /// The name of the variation applied to this line item.
        /// </summary>
        [JsonProperty("variation_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VariationName { get; set; }

        /// <summary>
        /// Application-defined data attached to this line item. Metadata fields are intended
        /// to store descriptive references or associations with an entity in another system or store brief
        /// information about the object. Square does not process this field; it only stores and returns it
        /// in relevant API calls. Do not use metadata to store any sensitive information (personally
        /// identifiable information, card details, etc.).
        /// Keys written by applications must be 60 characters or less and must be in the character set
        /// `[a-zA-Z0-9_-]`. Entries may also include metadata generated by Square. These keys are prefixed
        /// with a namespace, separated from the key with a ':' character.
        /// Values have a max length of 255 characters.
        /// An application may have up to 10 entries per metadata field.
        /// Entries written by applications are private and can only be read or modified by the same
        /// application.
        /// See [Metadata](https://developer.squareup.com/docs/build-basics/metadata) for more information.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The [CatalogModifier](#type-catalogmodifier)s applied to this line item.
        /// </summary>
        [JsonProperty("modifiers", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.OrderLineItemModifier> Modifiers { get; set; }

        /// <summary>
        /// The list of references to taxes applied to this line item. Each
        /// `OrderLineItemAppliedTax` has a `tax_uid` that references the `uid` of a
        /// top-level `OrderLineItemTax` applied to the line item. On reads, the
        /// amount applied is populated.
        /// An `OrderLineItemAppliedTax` will be automatically created on every line
        /// item for all `ORDER` scoped taxes added to the order. `OrderLineItemAppliedTax`
        /// records for `LINE_ITEM` scoped taxes must be added in requests for the tax
        /// to apply to any line items.
        /// To change the amount of a tax, modify the referenced top-level tax.
        /// </summary>
        [JsonProperty("applied_taxes", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.OrderLineItemAppliedTax> AppliedTaxes { get; set; }

        /// <summary>
        /// The list of references to discounts applied to this line item. Each
        /// `OrderLineItemAppliedDiscount` has a `discount_uid` that references the `uid` of a top-level
        /// `OrderLineItemDiscounts` applied to the line item. On reads, the amount
        /// applied is populated.
        /// An `OrderLineItemAppliedDiscount` will be automatically created on every line item for all
        /// `ORDER` scoped discounts that are added to the order. `OrderLineItemAppliedDiscount` records
        /// for `LINE_ITEM` scoped discounts must be added in requests for the discount to apply to any
        /// line items.
        /// To change the amount of a discount, modify the referenced top-level discount.
        /// </summary>
        [JsonProperty("applied_discounts", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.OrderLineItemAppliedDiscount> AppliedDiscounts { get; set; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("base_price_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money BasePriceMoney { get; set; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("variation_total_price_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money VariationTotalPriceMoney { get; set; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("gross_sales_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money GrossSalesMoney { get; set; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("total_tax_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money TotalTaxMoney { get; set; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("total_discount_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money TotalDiscountMoney { get; set; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("total_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money TotalMoney { get; set; }

        /// <summary>
        /// Describes pricing adjustments that are blocked from manual and 
        /// automatic application to a line item. For more information, see 
        /// [Apply Taxes and Discounts](https://developer.squareup.com/docs/orders-api/apply-taxes-and-discounts).
        /// </summary>
        [JsonProperty("pricing_blocklists", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderLineItemPricingBlocklists PricingBlocklists { get; set; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrderLineItem : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Uid = {(Uid == null ? "null" : Uid == string.Empty ? "" : Uid)}");
            toStringOutput.Add($"Name = {(Name == null ? "null" : Name == string.Empty ? "" : Name)}");
            toStringOutput.Add($"Quantity = {(Quantity == null ? "null" : Quantity == string.Empty ? "" : Quantity)}");
            toStringOutput.Add($"QuantityUnit = {(QuantityUnit == null ? "null" : QuantityUnit.ToString())}");
            toStringOutput.Add($"Note = {(Note == null ? "null" : Note == string.Empty ? "" : Note)}");
            toStringOutput.Add($"CatalogObjectId = {(CatalogObjectId == null ? "null" : CatalogObjectId == string.Empty ? "" : CatalogObjectId)}");
            toStringOutput.Add($"VariationName = {(VariationName == null ? "null" : VariationName == string.Empty ? "" : VariationName)}");
            toStringOutput.Add($"Metadata = {(Metadata == null ? "null" : Metadata.ToString())}");
            toStringOutput.Add($"Modifiers = {(Modifiers == null ? "null" : $"[{ string.Join(", ", Modifiers)} ]")}");
            toStringOutput.Add($"AppliedTaxes = {(AppliedTaxes == null ? "null" : $"[{ string.Join(", ", AppliedTaxes)} ]")}");
            toStringOutput.Add($"AppliedDiscounts = {(AppliedDiscounts == null ? "null" : $"[{ string.Join(", ", AppliedDiscounts)} ]")}");
            toStringOutput.Add($"BasePriceMoney = {(BasePriceMoney == null ? "null" : BasePriceMoney.ToString())}");
            toStringOutput.Add($"VariationTotalPriceMoney = {(VariationTotalPriceMoney == null ? "null" : VariationTotalPriceMoney.ToString())}");
            toStringOutput.Add($"GrossSalesMoney = {(GrossSalesMoney == null ? "null" : GrossSalesMoney.ToString())}");
            toStringOutput.Add($"TotalTaxMoney = {(TotalTaxMoney == null ? "null" : TotalTaxMoney.ToString())}");
            toStringOutput.Add($"TotalDiscountMoney = {(TotalDiscountMoney == null ? "null" : TotalDiscountMoney.ToString())}");
            toStringOutput.Add($"TotalMoney = {(TotalMoney == null ? "null" : TotalMoney.ToString())}");
            toStringOutput.Add($"PricingBlocklists = {(PricingBlocklists == null ? "null" : PricingBlocklists.ToString())}");
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

            return obj is OrderLineItem other &&
                ((Uid == null && other.Uid == null) || (Uid?.Equals(other.Uid) == true)) &&
                ((Name == null && other.Name == null) || (Name?.Equals(other.Name) == true)) &&
                ((Quantity == null && other.Quantity == null) || (Quantity?.Equals(other.Quantity) == true)) &&
                ((QuantityUnit == null && other.QuantityUnit == null) || (QuantityUnit?.Equals(other.QuantityUnit) == true)) &&
                ((Note == null && other.Note == null) || (Note?.Equals(other.Note) == true)) &&
                ((CatalogObjectId == null && other.CatalogObjectId == null) || (CatalogObjectId?.Equals(other.CatalogObjectId) == true)) &&
                ((VariationName == null && other.VariationName == null) || (VariationName?.Equals(other.VariationName) == true)) &&
                ((Metadata == null && other.Metadata == null) || (Metadata?.Equals(other.Metadata) == true)) &&
                ((Modifiers == null && other.Modifiers == null) || (Modifiers?.Equals(other.Modifiers) == true)) &&
                ((AppliedTaxes == null && other.AppliedTaxes == null) || (AppliedTaxes?.Equals(other.AppliedTaxes) == true)) &&
                ((AppliedDiscounts == null && other.AppliedDiscounts == null) || (AppliedDiscounts?.Equals(other.AppliedDiscounts) == true)) &&
                ((BasePriceMoney == null && other.BasePriceMoney == null) || (BasePriceMoney?.Equals(other.BasePriceMoney) == true)) &&
                ((VariationTotalPriceMoney == null && other.VariationTotalPriceMoney == null) || (VariationTotalPriceMoney?.Equals(other.VariationTotalPriceMoney) == true)) &&
                ((GrossSalesMoney == null && other.GrossSalesMoney == null) || (GrossSalesMoney?.Equals(other.GrossSalesMoney) == true)) &&
                ((TotalTaxMoney == null && other.TotalTaxMoney == null) || (TotalTaxMoney?.Equals(other.TotalTaxMoney) == true)) &&
                ((TotalDiscountMoney == null && other.TotalDiscountMoney == null) || (TotalDiscountMoney?.Equals(other.TotalDiscountMoney) == true)) &&
                ((TotalMoney == null && other.TotalMoney == null) || (TotalMoney?.Equals(other.TotalMoney) == true)) &&
                ((PricingBlocklists == null && other.PricingBlocklists == null) || (PricingBlocklists?.Equals(other.PricingBlocklists) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 441365892;

            if (Uid != null)
            {
               hashCode += Uid.GetHashCode();
            }

            if (Name != null)
            {
               hashCode += Name.GetHashCode();
            }

            if (Quantity != null)
            {
               hashCode += Quantity.GetHashCode();
            }

            if (QuantityUnit != null)
            {
               hashCode += QuantityUnit.GetHashCode();
            }

            if (Note != null)
            {
               hashCode += Note.GetHashCode();
            }

            if (CatalogObjectId != null)
            {
               hashCode += CatalogObjectId.GetHashCode();
            }

            if (VariationName != null)
            {
               hashCode += VariationName.GetHashCode();
            }

            if (Metadata != null)
            {
               hashCode += Metadata.GetHashCode();
            }

            if (Modifiers != null)
            {
               hashCode += Modifiers.GetHashCode();
            }

            if (AppliedTaxes != null)
            {
               hashCode += AppliedTaxes.GetHashCode();
            }

            if (AppliedDiscounts != null)
            {
               hashCode += AppliedDiscounts.GetHashCode();
            }

            if (BasePriceMoney != null)
            {
               hashCode += BasePriceMoney.GetHashCode();
            }

            if (VariationTotalPriceMoney != null)
            {
               hashCode += VariationTotalPriceMoney.GetHashCode();
            }

            if (GrossSalesMoney != null)
            {
               hashCode += GrossSalesMoney.GetHashCode();
            }

            if (TotalTaxMoney != null)
            {
               hashCode += TotalTaxMoney.GetHashCode();
            }

            if (TotalDiscountMoney != null)
            {
               hashCode += TotalDiscountMoney.GetHashCode();
            }

            if (TotalMoney != null)
            {
               hashCode += TotalMoney.GetHashCode();
            }

            if (PricingBlocklists != null)
            {
               hashCode += PricingBlocklists.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder(Quantity)
                .Uid(Uid)
                .Name(Name)
                .QuantityUnit(QuantityUnit)
                .Note(Note)
                .CatalogObjectId(CatalogObjectId)
                .VariationName(VariationName)
                .Metadata(Metadata)
                .Modifiers(Modifiers)
                .AppliedTaxes(AppliedTaxes)
                .AppliedDiscounts(AppliedDiscounts)
                .BasePriceMoney(BasePriceMoney)
                .VariationTotalPriceMoney(VariationTotalPriceMoney)
                .GrossSalesMoney(GrossSalesMoney)
                .TotalTaxMoney(TotalTaxMoney)
                .TotalDiscountMoney(TotalDiscountMoney)
                .TotalMoney(TotalMoney)
                .PricingBlocklists(PricingBlocklists);
            return builder;
        }

        public class Builder
        {
            private string quantity;
            private string uid;
            private string name;
            private Models.OrderQuantityUnit quantityUnit;
            private string note;
            private string catalogObjectId;
            private string variationName;
            private IDictionary<string, string> metadata;
            private IList<Models.OrderLineItemModifier> modifiers;
            private IList<Models.OrderLineItemAppliedTax> appliedTaxes;
            private IList<Models.OrderLineItemAppliedDiscount> appliedDiscounts;
            private Models.Money basePriceMoney;
            private Models.Money variationTotalPriceMoney;
            private Models.Money grossSalesMoney;
            private Models.Money totalTaxMoney;
            private Models.Money totalDiscountMoney;
            private Models.Money totalMoney;
            private Models.OrderLineItemPricingBlocklists pricingBlocklists;

            public Builder(string quantity)
            {
                this.quantity = quantity;
            }

            public Builder Quantity(string quantity)
            {
                this.quantity = quantity;
                return this;
            }

            public Builder Uid(string uid)
            {
                this.uid = uid;
                return this;
            }

            public Builder Name(string name)
            {
                this.name = name;
                return this;
            }

            public Builder QuantityUnit(Models.OrderQuantityUnit quantityUnit)
            {
                this.quantityUnit = quantityUnit;
                return this;
            }

            public Builder Note(string note)
            {
                this.note = note;
                return this;
            }

            public Builder CatalogObjectId(string catalogObjectId)
            {
                this.catalogObjectId = catalogObjectId;
                return this;
            }

            public Builder VariationName(string variationName)
            {
                this.variationName = variationName;
                return this;
            }

            public Builder Metadata(IDictionary<string, string> metadata)
            {
                this.metadata = metadata;
                return this;
            }

            public Builder Modifiers(IList<Models.OrderLineItemModifier> modifiers)
            {
                this.modifiers = modifiers;
                return this;
            }

            public Builder AppliedTaxes(IList<Models.OrderLineItemAppliedTax> appliedTaxes)
            {
                this.appliedTaxes = appliedTaxes;
                return this;
            }

            public Builder AppliedDiscounts(IList<Models.OrderLineItemAppliedDiscount> appliedDiscounts)
            {
                this.appliedDiscounts = appliedDiscounts;
                return this;
            }

            public Builder BasePriceMoney(Models.Money basePriceMoney)
            {
                this.basePriceMoney = basePriceMoney;
                return this;
            }

            public Builder VariationTotalPriceMoney(Models.Money variationTotalPriceMoney)
            {
                this.variationTotalPriceMoney = variationTotalPriceMoney;
                return this;
            }

            public Builder GrossSalesMoney(Models.Money grossSalesMoney)
            {
                this.grossSalesMoney = grossSalesMoney;
                return this;
            }

            public Builder TotalTaxMoney(Models.Money totalTaxMoney)
            {
                this.totalTaxMoney = totalTaxMoney;
                return this;
            }

            public Builder TotalDiscountMoney(Models.Money totalDiscountMoney)
            {
                this.totalDiscountMoney = totalDiscountMoney;
                return this;
            }

            public Builder TotalMoney(Models.Money totalMoney)
            {
                this.totalMoney = totalMoney;
                return this;
            }

            public Builder PricingBlocklists(Models.OrderLineItemPricingBlocklists pricingBlocklists)
            {
                this.pricingBlocklists = pricingBlocklists;
                return this;
            }

            public OrderLineItem Build()
            {
                return new OrderLineItem(quantity,
                    uid,
                    name,
                    quantityUnit,
                    note,
                    catalogObjectId,
                    variationName,
                    metadata,
                    modifiers,
                    appliedTaxes,
                    appliedDiscounts,
                    basePriceMoney,
                    variationTotalPriceMoney,
                    grossSalesMoney,
                    totalTaxMoney,
                    totalDiscountMoney,
                    totalMoney,
                    pricingBlocklists);
            }
        }
    }
}