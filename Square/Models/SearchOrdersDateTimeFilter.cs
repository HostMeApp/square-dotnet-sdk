
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
    public class SearchOrdersDateTimeFilter 
    {
        public SearchOrdersDateTimeFilter(Models.TimeRange createdAt = null,
            Models.TimeRange updatedAt = null,
            Models.TimeRange closedAt = null)
        {
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ClosedAt = closedAt;
        }

        /// <summary>
        /// Represents a generic time range. The start and end values are
        /// represented in RFC 3339 format. Time ranges are customized to be
        /// inclusive or exclusive based on the needs of a particular endpoint.
        /// Refer to the relevant endpoint-specific documentation to determine
        /// how time ranges are handled.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TimeRange CreatedAt { get; }

        /// <summary>
        /// Represents a generic time range. The start and end values are
        /// represented in RFC 3339 format. Time ranges are customized to be
        /// inclusive or exclusive based on the needs of a particular endpoint.
        /// Refer to the relevant endpoint-specific documentation to determine
        /// how time ranges are handled.
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TimeRange UpdatedAt { get; }

        /// <summary>
        /// Represents a generic time range. The start and end values are
        /// represented in RFC 3339 format. Time ranges are customized to be
        /// inclusive or exclusive based on the needs of a particular endpoint.
        /// Refer to the relevant endpoint-specific documentation to determine
        /// how time ranges are handled.
        /// </summary>
        [JsonProperty("closed_at", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TimeRange ClosedAt { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchOrdersDateTimeFilter : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CreatedAt = {(CreatedAt == null ? "null" : CreatedAt.ToString())}");
            toStringOutput.Add($"UpdatedAt = {(UpdatedAt == null ? "null" : UpdatedAt.ToString())}");
            toStringOutput.Add($"ClosedAt = {(ClosedAt == null ? "null" : ClosedAt.ToString())}");
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

            return obj is SearchOrdersDateTimeFilter other &&
                ((CreatedAt == null && other.CreatedAt == null) || (CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((UpdatedAt == null && other.UpdatedAt == null) || (UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((ClosedAt == null && other.ClosedAt == null) || (ClosedAt?.Equals(other.ClosedAt) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 713480227;

            if (CreatedAt != null)
            {
               hashCode += CreatedAt.GetHashCode();
            }

            if (UpdatedAt != null)
            {
               hashCode += UpdatedAt.GetHashCode();
            }

            if (ClosedAt != null)
            {
               hashCode += ClosedAt.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .CreatedAt(CreatedAt)
                .UpdatedAt(UpdatedAt)
                .ClosedAt(ClosedAt);
            return builder;
        }

        public class Builder
        {
            private Models.TimeRange createdAt;
            private Models.TimeRange updatedAt;
            private Models.TimeRange closedAt;



            public Builder CreatedAt(Models.TimeRange createdAt)
            {
                this.createdAt = createdAt;
                return this;
            }

            public Builder UpdatedAt(Models.TimeRange updatedAt)
            {
                this.updatedAt = updatedAt;
                return this;
            }

            public Builder ClosedAt(Models.TimeRange closedAt)
            {
                this.closedAt = closedAt;
                return this;
            }

            public SearchOrdersDateTimeFilter Build()
            {
                return new SearchOrdersDateTimeFilter(createdAt,
                    updatedAt,
                    closedAt);
            }
        }
    }
}