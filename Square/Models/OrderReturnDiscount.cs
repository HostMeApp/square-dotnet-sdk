
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
    public class OrderReturnDiscount 
    {
        public OrderReturnDiscount(string uid = null,
            string sourceDiscountUid = null,
            string catalogObjectId = null,
            string name = null,
            string type = null,
            string percentage = null,
            Models.Money amountMoney = null,
            Models.Money appliedMoney = null,
            string scope = null)
        {
            Uid = uid;
            SourceDiscountUid = sourceDiscountUid;
            CatalogObjectId = catalogObjectId;
            Name = name;
            Type = type;
            Percentage = percentage;
            AmountMoney = amountMoney;
            AppliedMoney = appliedMoney;
            Scope = scope;
        }

        /// <summary>
        /// Unique ID that identifies the return discount only within this order.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; }

        /// <summary>
        /// `uid` of the Discount from the Order which contains the original application of this discount.
        /// </summary>
        [JsonProperty("source_discount_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDiscountUid { get; }

        /// <summary>
        /// The catalog object id referencing [CatalogDiscount](#type-catalogdiscount).
        /// </summary>
        [JsonProperty("catalog_object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CatalogObjectId { get; }

        /// <summary>
        /// The discount's name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; }

        /// <summary>
        /// Indicates how the discount is applied to the associated line item or order.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; }

        /// <summary>
        /// The percentage of the tax, as a string representation of a decimal number.
        /// A value of `7.25` corresponds to a percentage of 7.25%.
        /// `percentage` is not set for amount-based discounts.
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
        /// Indicates whether this is a line item or order level discount.
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrderReturnDiscount : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Uid = {(Uid == null ? "null" : Uid == string.Empty ? "" : Uid)}");
            toStringOutput.Add($"SourceDiscountUid = {(SourceDiscountUid == null ? "null" : SourceDiscountUid == string.Empty ? "" : SourceDiscountUid)}");
            toStringOutput.Add($"CatalogObjectId = {(CatalogObjectId == null ? "null" : CatalogObjectId == string.Empty ? "" : CatalogObjectId)}");
            toStringOutput.Add($"Name = {(Name == null ? "null" : Name == string.Empty ? "" : Name)}");
            toStringOutput.Add($"Type = {(Type == null ? "null" : Type.ToString())}");
            toStringOutput.Add($"Percentage = {(Percentage == null ? "null" : Percentage == string.Empty ? "" : Percentage)}");
            toStringOutput.Add($"AmountMoney = {(AmountMoney == null ? "null" : AmountMoney.ToString())}");
            toStringOutput.Add($"AppliedMoney = {(AppliedMoney == null ? "null" : AppliedMoney.ToString())}");
            toStringOutput.Add($"Scope = {(Scope == null ? "null" : Scope.ToString())}");
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

            return obj is OrderReturnDiscount other &&
                ((Uid == null && other.Uid == null) || (Uid?.Equals(other.Uid) == true)) &&
                ((SourceDiscountUid == null && other.SourceDiscountUid == null) || (SourceDiscountUid?.Equals(other.SourceDiscountUid) == true)) &&
                ((CatalogObjectId == null && other.CatalogObjectId == null) || (CatalogObjectId?.Equals(other.CatalogObjectId) == true)) &&
                ((Name == null && other.Name == null) || (Name?.Equals(other.Name) == true)) &&
                ((Type == null && other.Type == null) || (Type?.Equals(other.Type) == true)) &&
                ((Percentage == null && other.Percentage == null) || (Percentage?.Equals(other.Percentage) == true)) &&
                ((AmountMoney == null && other.AmountMoney == null) || (AmountMoney?.Equals(other.AmountMoney) == true)) &&
                ((AppliedMoney == null && other.AppliedMoney == null) || (AppliedMoney?.Equals(other.AppliedMoney) == true)) &&
                ((Scope == null && other.Scope == null) || (Scope?.Equals(other.Scope) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 1132361355;

            if (Uid != null)
            {
               hashCode += Uid.GetHashCode();
            }

            if (SourceDiscountUid != null)
            {
               hashCode += SourceDiscountUid.GetHashCode();
            }

            if (CatalogObjectId != null)
            {
               hashCode += CatalogObjectId.GetHashCode();
            }

            if (Name != null)
            {
               hashCode += Name.GetHashCode();
            }

            if (Type != null)
            {
               hashCode += Type.GetHashCode();
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

            if (Scope != null)
            {
               hashCode += Scope.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Uid(Uid)
                .SourceDiscountUid(SourceDiscountUid)
                .CatalogObjectId(CatalogObjectId)
                .Name(Name)
                .Type(Type)
                .Percentage(Percentage)
                .AmountMoney(AmountMoney)
                .AppliedMoney(AppliedMoney)
                .Scope(Scope);
            return builder;
        }

        public class Builder
        {
            private string uid;
            private string sourceDiscountUid;
            private string catalogObjectId;
            private string name;
            private string type;
            private string percentage;
            private Models.Money amountMoney;
            private Models.Money appliedMoney;
            private string scope;



            public Builder Uid(string uid)
            {
                this.uid = uid;
                return this;
            }

            public Builder SourceDiscountUid(string sourceDiscountUid)
            {
                this.sourceDiscountUid = sourceDiscountUid;
                return this;
            }

            public Builder CatalogObjectId(string catalogObjectId)
            {
                this.catalogObjectId = catalogObjectId;
                return this;
            }

            public Builder Name(string name)
            {
                this.name = name;
                return this;
            }

            public Builder Type(string type)
            {
                this.type = type;
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

            public Builder Scope(string scope)
            {
                this.scope = scope;
                return this;
            }

            public OrderReturnDiscount Build()
            {
                return new OrderReturnDiscount(uid,
                    sourceDiscountUid,
                    catalogObjectId,
                    name,
                    type,
                    percentage,
                    amountMoney,
                    appliedMoney,
                    scope);
            }
        }
    }
}