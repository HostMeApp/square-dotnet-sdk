
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
    public class CatalogQuickAmount 
    {
        public CatalogQuickAmount(string type,
            Models.Money amount,
            long? score = null,
            long? ordinal = null)
        {
            Type = type;
            Amount = amount;
            Score = score;
            Ordinal = ordinal;
        }

        /// <summary>
        /// Determines the type of a specific Quick Amount.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("amount")]
        public Models.Money Amount { get; }

        /// <summary>
        /// Describes the ranking of the Quick Amount provided by machine learning model, in the range [0, 100].
        /// MANUAL type amount will always have score = 100.
        /// </summary>
        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public long? Score { get; }

        /// <summary>
        /// The order in which this Quick Amount should be displayed.
        /// </summary>
        [JsonProperty("ordinal", NullValueHandling = NullValueHandling.Ignore)]
        public long? Ordinal { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CatalogQuickAmount : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {(Type == null ? "null" : Type.ToString())}");
            toStringOutput.Add($"Amount = {(Amount == null ? "null" : Amount.ToString())}");
            toStringOutput.Add($"Score = {(Score == null ? "null" : Score.ToString())}");
            toStringOutput.Add($"Ordinal = {(Ordinal == null ? "null" : Ordinal.ToString())}");
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

            return obj is CatalogQuickAmount other &&
                ((Type == null && other.Type == null) || (Type?.Equals(other.Type) == true)) &&
                ((Amount == null && other.Amount == null) || (Amount?.Equals(other.Amount) == true)) &&
                ((Score == null && other.Score == null) || (Score?.Equals(other.Score) == true)) &&
                ((Ordinal == null && other.Ordinal == null) || (Ordinal?.Equals(other.Ordinal) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = -1903352296;

            if (Type != null)
            {
               hashCode += Type.GetHashCode();
            }

            if (Amount != null)
            {
               hashCode += Amount.GetHashCode();
            }

            if (Score != null)
            {
               hashCode += Score.GetHashCode();
            }

            if (Ordinal != null)
            {
               hashCode += Ordinal.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder(Type,
                Amount)
                .Score(Score)
                .Ordinal(Ordinal);
            return builder;
        }

        public class Builder
        {
            private string type;
            private Models.Money amount;
            private long? score;
            private long? ordinal;

            public Builder(string type,
                Models.Money amount)
            {
                this.type = type;
                this.amount = amount;
            }

            public Builder Type(string type)
            {
                this.type = type;
                return this;
            }

            public Builder Amount(Models.Money amount)
            {
                this.amount = amount;
                return this;
            }

            public Builder Score(long? score)
            {
                this.score = score;
                return this;
            }

            public Builder Ordinal(long? ordinal)
            {
                this.ordinal = ordinal;
                return this;
            }

            public CatalogQuickAmount Build()
            {
                return new CatalogQuickAmount(type,
                    amount,
                    score,
                    ordinal);
            }
        }
    }
}