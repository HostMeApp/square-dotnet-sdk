
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
    public class AdditionalRecipient 
    {
        public AdditionalRecipient(string locationId,
            string description,
            Models.Money amountMoney,
            string receivableId = null)
        {
            LocationId = locationId;
            Description = description;
            AmountMoney = amountMoney;
            ReceivableId = receivableId;
        }

        /// <summary>
        /// The location ID for a recipient (other than the merchant) receiving a portion of this tender.
        /// </summary>
        [JsonProperty("location_id")]
        public string LocationId { get; }

        /// <summary>
        /// The description of the additional recipient.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("amount_money")]
        public Models.Money AmountMoney { get; }

        /// <summary>
        /// The unique ID for this [AdditionalRecipientReceivable](#type-additionalrecipientreceivable), assigned by the server.
        /// </summary>
        [JsonProperty("receivable_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceivableId { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalRecipient : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"LocationId = {(LocationId == null ? "null" : LocationId == string.Empty ? "" : LocationId)}");
            toStringOutput.Add($"Description = {(Description == null ? "null" : Description == string.Empty ? "" : Description)}");
            toStringOutput.Add($"AmountMoney = {(AmountMoney == null ? "null" : AmountMoney.ToString())}");
            toStringOutput.Add($"ReceivableId = {(ReceivableId == null ? "null" : ReceivableId == string.Empty ? "" : ReceivableId)}");
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

            return obj is AdditionalRecipient other &&
                ((LocationId == null && other.LocationId == null) || (LocationId?.Equals(other.LocationId) == true)) &&
                ((Description == null && other.Description == null) || (Description?.Equals(other.Description) == true)) &&
                ((AmountMoney == null && other.AmountMoney == null) || (AmountMoney?.Equals(other.AmountMoney) == true)) &&
                ((ReceivableId == null && other.ReceivableId == null) || (ReceivableId?.Equals(other.ReceivableId) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = -1717136415;

            if (LocationId != null)
            {
               hashCode += LocationId.GetHashCode();
            }

            if (Description != null)
            {
               hashCode += Description.GetHashCode();
            }

            if (AmountMoney != null)
            {
               hashCode += AmountMoney.GetHashCode();
            }

            if (ReceivableId != null)
            {
               hashCode += ReceivableId.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder(LocationId,
                Description,
                AmountMoney)
                .ReceivableId(ReceivableId);
            return builder;
        }

        public class Builder
        {
            private string locationId;
            private string description;
            private Models.Money amountMoney;
            private string receivableId;

            public Builder(string locationId,
                string description,
                Models.Money amountMoney)
            {
                this.locationId = locationId;
                this.description = description;
                this.amountMoney = amountMoney;
            }

            public Builder LocationId(string locationId)
            {
                this.locationId = locationId;
                return this;
            }

            public Builder Description(string description)
            {
                this.description = description;
                return this;
            }

            public Builder AmountMoney(Models.Money amountMoney)
            {
                this.amountMoney = amountMoney;
                return this;
            }

            public Builder ReceivableId(string receivableId)
            {
                this.receivableId = receivableId;
                return this;
            }

            public AdditionalRecipient Build()
            {
                return new AdditionalRecipient(locationId,
                    description,
                    amountMoney,
                    receivableId);
            }
        }
    }
}