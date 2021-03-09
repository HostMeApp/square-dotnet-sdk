
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
    public class OrderLineItemModifier 
    {
        public OrderLineItemModifier(string uid = null,
            string catalogObjectId = null,
            string name = null,
            Models.Money basePriceMoney = null,
            Models.Money totalPriceMoney = null)
        {
            Uid = uid;
            CatalogObjectId = catalogObjectId;
            Name = name;
            BasePriceMoney = basePriceMoney;
            TotalPriceMoney = totalPriceMoney;
        }

        /// <summary>
        /// Unique ID that identifies the modifier only within this order.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid{ get; set; }

        /// <summary>
        /// The catalog object id referencing [CatalogModifier](#type-catalogmodifier).
        /// </summary>
        [JsonProperty("catalog_object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CatalogObjectId{ get; set; }

        /// <summary>
        /// The name of the item modifier.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name{ get; set; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("base_price_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money BasePriceMoney{ get; set; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("total_price_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money TotalPriceMoney{ get; set; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrderLineItemModifier : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Uid = {(Uid == null ? "null" : Uid == string.Empty ? "" : Uid)}");
            toStringOutput.Add($"CatalogObjectId = {(CatalogObjectId == null ? "null" : CatalogObjectId == string.Empty ? "" : CatalogObjectId)}");
            toStringOutput.Add($"Name = {(Name == null ? "null" : Name == string.Empty ? "" : Name)}");
            toStringOutput.Add($"BasePriceMoney = {(BasePriceMoney == null ? "null" : BasePriceMoney.ToString())}");
            toStringOutput.Add($"TotalPriceMoney = {(TotalPriceMoney == null ? "null" : TotalPriceMoney.ToString())}");
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

            return obj is OrderLineItemModifier other &&
                ((Uid == null && other.Uid == null) || (Uid?.Equals(other.Uid) == true)) &&
                ((CatalogObjectId == null && other.CatalogObjectId == null) || (CatalogObjectId?.Equals(other.CatalogObjectId) == true)) &&
                ((Name == null && other.Name == null) || (Name?.Equals(other.Name) == true)) &&
                ((BasePriceMoney == null && other.BasePriceMoney == null) || (BasePriceMoney?.Equals(other.BasePriceMoney) == true)) &&
                ((TotalPriceMoney == null && other.TotalPriceMoney == null) || (TotalPriceMoney?.Equals(other.TotalPriceMoney) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 141089450;

            if (Uid != null)
            {
               hashCode += Uid.GetHashCode();
            }

            if (CatalogObjectId != null)
            {
               hashCode += CatalogObjectId.GetHashCode();
            }

            if (Name != null)
            {
               hashCode += Name.GetHashCode();
            }

            if (BasePriceMoney != null)
            {
               hashCode += BasePriceMoney.GetHashCode();
            }

            if (TotalPriceMoney != null)
            {
               hashCode += TotalPriceMoney.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Uid(Uid)
                .CatalogObjectId(CatalogObjectId)
                .Name(Name)
                .BasePriceMoney(BasePriceMoney)
                .TotalPriceMoney(TotalPriceMoney);
            return builder;
        }

        public class Builder
        {
            private string uid;
            private string catalogObjectId;
            private string name;
            private Models.Money basePriceMoney;
            private Models.Money totalPriceMoney;



            public Builder Uid(string uid)
            {
                this.uid = uid;
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

            public Builder BasePriceMoney(Models.Money basePriceMoney)
            {
                this.basePriceMoney = basePriceMoney;
                return this;
            }

            public Builder TotalPriceMoney(Models.Money totalPriceMoney)
            {
                this.totalPriceMoney = totalPriceMoney;
                return this;
            }

            public OrderLineItemModifier Build()
            {
                return new OrderLineItemModifier(uid,
                    catalogObjectId,
                    name,
                    basePriceMoney,
                    totalPriceMoney);
            }
        }
    }
}