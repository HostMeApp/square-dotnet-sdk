
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
    public class LoyaltyProgramAccrualRule 
    {
        public LoyaltyProgramAccrualRule(string accrualType,
            int? points = null,
            Models.Money visitMinimumAmountMoney = null,
            Models.Money spendAmountMoney = null,
            string catalogObjectId = null)
        {
            AccrualType = accrualType;
            Points = points;
            VisitMinimumAmountMoney = visitMinimumAmountMoney;
            SpendAmountMoney = spendAmountMoney;
            CatalogObjectId = catalogObjectId;
        }

        /// <summary>
        /// The type of the accrual rule that defines how buyers can earn points.
        /// </summary>
        [JsonProperty("accrual_type")]
        public string AccrualType { get; }

        /// <summary>
        /// The number of points that 
        /// buyers earn based on the `accrual_type`.
        /// </summary>
        [JsonProperty("points", NullValueHandling = NullValueHandling.Ignore)]
        public int? Points { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("visit_minimum_amount_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money VisitMinimumAmountMoney { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("spend_amount_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money SpendAmountMoney { get; }

        /// <summary>
        /// The ID of the [catalog object](#type-CatalogObject) to purchase to earn the number of points defined by the
        /// rule. This is either an item variation or a category, depending on the type. This is defined on
        /// `ITEM_VARIATION` rules and `CATEGORY` rules.
        /// </summary>
        [JsonProperty("catalog_object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CatalogObjectId { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LoyaltyProgramAccrualRule : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccrualType = {(AccrualType == null ? "null" : AccrualType.ToString())}");
            toStringOutput.Add($"Points = {(Points == null ? "null" : Points.ToString())}");
            toStringOutput.Add($"VisitMinimumAmountMoney = {(VisitMinimumAmountMoney == null ? "null" : VisitMinimumAmountMoney.ToString())}");
            toStringOutput.Add($"SpendAmountMoney = {(SpendAmountMoney == null ? "null" : SpendAmountMoney.ToString())}");
            toStringOutput.Add($"CatalogObjectId = {(CatalogObjectId == null ? "null" : CatalogObjectId == string.Empty ? "" : CatalogObjectId)}");
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

            return obj is LoyaltyProgramAccrualRule other &&
                ((AccrualType == null && other.AccrualType == null) || (AccrualType?.Equals(other.AccrualType) == true)) &&
                ((Points == null && other.Points == null) || (Points?.Equals(other.Points) == true)) &&
                ((VisitMinimumAmountMoney == null && other.VisitMinimumAmountMoney == null) || (VisitMinimumAmountMoney?.Equals(other.VisitMinimumAmountMoney) == true)) &&
                ((SpendAmountMoney == null && other.SpendAmountMoney == null) || (SpendAmountMoney?.Equals(other.SpendAmountMoney) == true)) &&
                ((CatalogObjectId == null && other.CatalogObjectId == null) || (CatalogObjectId?.Equals(other.CatalogObjectId) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = -765894953;

            if (AccrualType != null)
            {
               hashCode += AccrualType.GetHashCode();
            }

            if (Points != null)
            {
               hashCode += Points.GetHashCode();
            }

            if (VisitMinimumAmountMoney != null)
            {
               hashCode += VisitMinimumAmountMoney.GetHashCode();
            }

            if (SpendAmountMoney != null)
            {
               hashCode += SpendAmountMoney.GetHashCode();
            }

            if (CatalogObjectId != null)
            {
               hashCode += CatalogObjectId.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder(AccrualType)
                .Points(Points)
                .VisitMinimumAmountMoney(VisitMinimumAmountMoney)
                .SpendAmountMoney(SpendAmountMoney)
                .CatalogObjectId(CatalogObjectId);
            return builder;
        }

        public class Builder
        {
            private string accrualType;
            private int? points;
            private Models.Money visitMinimumAmountMoney;
            private Models.Money spendAmountMoney;
            private string catalogObjectId;

            public Builder(string accrualType)
            {
                this.accrualType = accrualType;
            }

            public Builder AccrualType(string accrualType)
            {
                this.accrualType = accrualType;
                return this;
            }

            public Builder Points(int? points)
            {
                this.points = points;
                return this;
            }

            public Builder VisitMinimumAmountMoney(Models.Money visitMinimumAmountMoney)
            {
                this.visitMinimumAmountMoney = visitMinimumAmountMoney;
                return this;
            }

            public Builder SpendAmountMoney(Models.Money spendAmountMoney)
            {
                this.spendAmountMoney = spendAmountMoney;
                return this;
            }

            public Builder CatalogObjectId(string catalogObjectId)
            {
                this.catalogObjectId = catalogObjectId;
                return this;
            }

            public LoyaltyProgramAccrualRule Build()
            {
                return new LoyaltyProgramAccrualRule(accrualType,
                    points,
                    visitMinimumAmountMoney,
                    spendAmountMoney,
                    catalogObjectId);
            }
        }
    }
}