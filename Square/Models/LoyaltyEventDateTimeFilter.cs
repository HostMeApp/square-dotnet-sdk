
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
    public class LoyaltyEventDateTimeFilter 
    {
        public LoyaltyEventDateTimeFilter(Models.TimeRange createdAt)
        {
            CreatedAt = createdAt;
        }

        /// <summary>
        /// Represents a generic time range. The start and end values are
        /// represented in RFC 3339 format. Time ranges are customized to be
        /// inclusive or exclusive based on the needs of a particular endpoint.
        /// Refer to the relevant endpoint-specific documentation to determine
        /// how time ranges are handled.
        /// </summary>
        [JsonProperty("created_at")]
        public Models.TimeRange CreatedAt { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LoyaltyEventDateTimeFilter : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CreatedAt = {(CreatedAt == null ? "null" : CreatedAt.ToString())}");
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

            return obj is LoyaltyEventDateTimeFilter other &&
                ((CreatedAt == null && other.CreatedAt == null) || (CreatedAt?.Equals(other.CreatedAt) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 2053531921;

            if (CreatedAt != null)
            {
               hashCode += CreatedAt.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder(CreatedAt);
            return builder;
        }

        public class Builder
        {
            private Models.TimeRange createdAt;

            public Builder(Models.TimeRange createdAt)
            {
                this.createdAt = createdAt;
            }

            public Builder CreatedAt(Models.TimeRange createdAt)
            {
                this.createdAt = createdAt;
                return this;
            }

            public LoyaltyEventDateTimeFilter Build()
            {
                return new LoyaltyEventDateTimeFilter(createdAt);
            }
        }
    }
}