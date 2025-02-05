
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
    public class OrderServiceCharge 
    {
        public OrderServiceCharge(string uid = null,
            string name = null,
            string catalogObjectId = null,
            string percentage = null,
            Models.Money amountMoney = null,
            Models.Money appliedMoney = null,
            Models.Money totalMoney = null,
            Models.Money totalTaxMoney = null,
            string calculationPhase = null,
            bool? taxable = null,
            IList<Models.OrderLineItemAppliedTax> appliedTaxes = null,
            IDictionary<string, string> metadata = null)
        {
            Uid = uid;
            Name = name;
            CatalogObjectId = catalogObjectId;
            Percentage = percentage;
            AmountMoney = amountMoney;
            AppliedMoney = appliedMoney;
            TotalMoney = totalMoney;
            TotalTaxMoney = totalTaxMoney;
            CalculationPhase = calculationPhase;
            Taxable = taxable;
            AppliedTaxes = appliedTaxes;
            Metadata = metadata;
        }

        /// <summary>
        /// Unique ID that identifies the service charge only within this order.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; }

        /// <summary>
        /// The name of the service charge.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; }

        /// <summary>
        /// The catalog object ID referencing the service charge [CatalogObject](#type-catalogobject).
        /// </summary>
        [JsonProperty("catalog_object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CatalogObjectId { get; }

        /// <summary>
        /// The service charge percentage as a string representation of a
        /// decimal number. For example, `"7.25"` indicates a service charge of 7.25%.
        /// Exactly 1 of `percentage` or `amount_money` should be set.
        /// </summary>
        [JsonProperty("percentage", NullValueHandling = NullValueHandling.Ignore)]
        public string Percentage { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("amount_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money AmountMoney { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("applied_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money AppliedMoney { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("total_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money TotalMoney { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("total_tax_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money TotalTaxMoney { get; }

        /// <summary>
        /// Represents a phase in the process of calculating order totals.
        /// Service charges are applied __after__ the indicated phase.
        /// [Read more about how order totals are calculated.](https://developer.squareup.com/docs/orders-api/how-it-works#how-totals-are-calculated)
        /// </summary>
        [JsonProperty("calculation_phase", NullValueHandling = NullValueHandling.Ignore)]
        public string CalculationPhase { get; }

        /// <summary>
        /// Indicates whether the service charge can be taxed. If set to `true`,
        /// order-level taxes automatically apply to the service charge. Note that
        /// service charges calculated in the `TOTAL_PHASE` cannot be marked as taxable.
        /// </summary>
        [JsonProperty("taxable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taxable { get; }

        /// <summary>
        /// The list of references to taxes applied to this service charge. Each
        /// `OrderLineItemAppliedTax` has a `tax_uid` that references the `uid` of a top-level
        /// `OrderLineItemTax` that is being applied to this service charge. On reads, the amount applied
        /// is populated.
        /// An `OrderLineItemAppliedTax` will be automatically created on every taxable service charge
        /// for all `ORDER` scoped taxes that are added to the order. `OrderLineItemAppliedTax` records
        /// for `LINE_ITEM` scoped taxes must be added in requests for the tax to apply to any taxable
        /// service charge.  Taxable service charges have the `taxable` field set to true and calculated
        /// in the `SUBTOTAL_PHASE`.
        /// To change the amount of a tax, modify the referenced top-level tax.
        /// </summary>
        [JsonProperty("applied_taxes", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.OrderLineItemAppliedTax> AppliedTaxes { get; }

        /// <summary>
        /// Application-defined data attached to this service charge. Metadata fields are intended
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
        public IDictionary<string, string> Metadata { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrderServiceCharge : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Uid = {(Uid == null ? "null" : Uid == string.Empty ? "" : Uid)}");
            toStringOutput.Add($"Name = {(Name == null ? "null" : Name == string.Empty ? "" : Name)}");
            toStringOutput.Add($"CatalogObjectId = {(CatalogObjectId == null ? "null" : CatalogObjectId == string.Empty ? "" : CatalogObjectId)}");
            toStringOutput.Add($"Percentage = {(Percentage == null ? "null" : Percentage == string.Empty ? "" : Percentage)}");
            toStringOutput.Add($"AmountMoney = {(AmountMoney == null ? "null" : AmountMoney.ToString())}");
            toStringOutput.Add($"AppliedMoney = {(AppliedMoney == null ? "null" : AppliedMoney.ToString())}");
            toStringOutput.Add($"TotalMoney = {(TotalMoney == null ? "null" : TotalMoney.ToString())}");
            toStringOutput.Add($"TotalTaxMoney = {(TotalTaxMoney == null ? "null" : TotalTaxMoney.ToString())}");
            toStringOutput.Add($"CalculationPhase = {(CalculationPhase == null ? "null" : CalculationPhase.ToString())}");
            toStringOutput.Add($"Taxable = {(Taxable == null ? "null" : Taxable.ToString())}");
            toStringOutput.Add($"AppliedTaxes = {(AppliedTaxes == null ? "null" : $"[{ string.Join(", ", AppliedTaxes)} ]")}");
            toStringOutput.Add($"Metadata = {(Metadata == null ? "null" : Metadata.ToString())}");
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

            return obj is OrderServiceCharge other &&
                ((Uid == null && other.Uid == null) || (Uid?.Equals(other.Uid) == true)) &&
                ((Name == null && other.Name == null) || (Name?.Equals(other.Name) == true)) &&
                ((CatalogObjectId == null && other.CatalogObjectId == null) || (CatalogObjectId?.Equals(other.CatalogObjectId) == true)) &&
                ((Percentage == null && other.Percentage == null) || (Percentage?.Equals(other.Percentage) == true)) &&
                ((AmountMoney == null && other.AmountMoney == null) || (AmountMoney?.Equals(other.AmountMoney) == true)) &&
                ((AppliedMoney == null && other.AppliedMoney == null) || (AppliedMoney?.Equals(other.AppliedMoney) == true)) &&
                ((TotalMoney == null && other.TotalMoney == null) || (TotalMoney?.Equals(other.TotalMoney) == true)) &&
                ((TotalTaxMoney == null && other.TotalTaxMoney == null) || (TotalTaxMoney?.Equals(other.TotalTaxMoney) == true)) &&
                ((CalculationPhase == null && other.CalculationPhase == null) || (CalculationPhase?.Equals(other.CalculationPhase) == true)) &&
                ((Taxable == null && other.Taxable == null) || (Taxable?.Equals(other.Taxable) == true)) &&
                ((AppliedTaxes == null && other.AppliedTaxes == null) || (AppliedTaxes?.Equals(other.AppliedTaxes) == true)) &&
                ((Metadata == null && other.Metadata == null) || (Metadata?.Equals(other.Metadata) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 1266271501;

            if (Uid != null)
            {
               hashCode += Uid.GetHashCode();
            }

            if (Name != null)
            {
               hashCode += Name.GetHashCode();
            }

            if (CatalogObjectId != null)
            {
               hashCode += CatalogObjectId.GetHashCode();
            }

            if (Percentage != null)
            {
               hashCode += Percentage.GetHashCode();
            }

            if (AmountMoney != null)
            {
               hashCode += AmountMoney.GetHashCode();
            }

            if (AppliedMoney != null)
            {
               hashCode += AppliedMoney.GetHashCode();
            }

            if (TotalMoney != null)
            {
               hashCode += TotalMoney.GetHashCode();
            }

            if (TotalTaxMoney != null)
            {
               hashCode += TotalTaxMoney.GetHashCode();
            }

            if (CalculationPhase != null)
            {
               hashCode += CalculationPhase.GetHashCode();
            }

            if (Taxable != null)
            {
               hashCode += Taxable.GetHashCode();
            }

            if (AppliedTaxes != null)
            {
               hashCode += AppliedTaxes.GetHashCode();
            }

            if (Metadata != null)
            {
               hashCode += Metadata.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Uid(Uid)
                .Name(Name)
                .CatalogObjectId(CatalogObjectId)
                .Percentage(Percentage)
                .AmountMoney(AmountMoney)
                .AppliedMoney(AppliedMoney)
                .TotalMoney(TotalMoney)
                .TotalTaxMoney(TotalTaxMoney)
                .CalculationPhase(CalculationPhase)
                .Taxable(Taxable)
                .AppliedTaxes(AppliedTaxes)
                .Metadata(Metadata);
            return builder;
        }

        public class Builder
        {
            private string uid;
            private string name;
            private string catalogObjectId;
            private string percentage;
            private Models.Money amountMoney;
            private Models.Money appliedMoney;
            private Models.Money totalMoney;
            private Models.Money totalTaxMoney;
            private string calculationPhase;
            private bool? taxable;
            private IList<Models.OrderLineItemAppliedTax> appliedTaxes;
            private IDictionary<string, string> metadata;



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

            public Builder CatalogObjectId(string catalogObjectId)
            {
                this.catalogObjectId = catalogObjectId;
                return this;
            }

            public Builder Percentage(string percentage)
            {
                this.percentage = percentage;
                return this;
            }

            public Builder AmountMoney(Models.Money amountMoney)
            {
                this.amountMoney = amountMoney;
                return this;
            }

            public Builder AppliedMoney(Models.Money appliedMoney)
            {
                this.appliedMoney = appliedMoney;
                return this;
            }

            public Builder TotalMoney(Models.Money totalMoney)
            {
                this.totalMoney = totalMoney;
                return this;
            }

            public Builder TotalTaxMoney(Models.Money totalTaxMoney)
            {
                this.totalTaxMoney = totalTaxMoney;
                return this;
            }

            public Builder CalculationPhase(string calculationPhase)
            {
                this.calculationPhase = calculationPhase;
                return this;
            }

            public Builder Taxable(bool? taxable)
            {
                this.taxable = taxable;
                return this;
            }

            public Builder AppliedTaxes(IList<Models.OrderLineItemAppliedTax> appliedTaxes)
            {
                this.appliedTaxes = appliedTaxes;
                return this;
            }

            public Builder Metadata(IDictionary<string, string> metadata)
            {
                this.metadata = metadata;
                return this;
            }

            public OrderServiceCharge Build()
            {
                return new OrderServiceCharge(uid,
                    name,
                    catalogObjectId,
                    percentage,
                    amountMoney,
                    appliedMoney,
                    totalMoney,
                    totalTaxMoney,
                    calculationPhase,
                    taxable,
                    appliedTaxes,
                    metadata);
            }
        }
    }
}