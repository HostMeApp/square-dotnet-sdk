
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
    public class ListBreakTypesRequest 
    {
        public ListBreakTypesRequest(string locationId = null,
            int? limit = null,
            string cursor = null)
        {
            LocationId = locationId;
            Limit = limit;
            Cursor = cursor;
        }

        /// <summary>
        /// Filter Break Types returned to only those that are associated with the
        /// specified location.
        /// </summary>
        [JsonProperty("location_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationId { get; }

        /// <summary>
        /// Maximum number of Break Types to return per page. Can range between 1
        /// and 200. The default is the maximum at 200.
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; }

        /// <summary>
        /// Pointer to the next page of Break Type results to fetch.
        /// </summary>
        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public string Cursor { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListBreakTypesRequest : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"LocationId = {(LocationId == null ? "null" : LocationId == string.Empty ? "" : LocationId)}");
            toStringOutput.Add($"Limit = {(Limit == null ? "null" : Limit.ToString())}");
            toStringOutput.Add($"Cursor = {(Cursor == null ? "null" : Cursor == string.Empty ? "" : Cursor)}");
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

            return obj is ListBreakTypesRequest other &&
                ((LocationId == null && other.LocationId == null) || (LocationId?.Equals(other.LocationId) == true)) &&
                ((Limit == null && other.Limit == null) || (Limit?.Equals(other.Limit) == true)) &&
                ((Cursor == null && other.Cursor == null) || (Cursor?.Equals(other.Cursor) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = -1110829719;

            if (LocationId != null)
            {
               hashCode += LocationId.GetHashCode();
            }

            if (Limit != null)
            {
               hashCode += Limit.GetHashCode();
            }

            if (Cursor != null)
            {
               hashCode += Cursor.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .LocationId(LocationId)
                .Limit(Limit)
                .Cursor(Cursor);
            return builder;
        }

        public class Builder
        {
            private string locationId;
            private int? limit;
            private string cursor;



            public Builder LocationId(string locationId)
            {
                this.locationId = locationId;
                return this;
            }

            public Builder Limit(int? limit)
            {
                this.limit = limit;
                return this;
            }

            public Builder Cursor(string cursor)
            {
                this.cursor = cursor;
                return this;
            }

            public ListBreakTypesRequest Build()
            {
                return new ListBreakTypesRequest(locationId,
                    limit,
                    cursor);
            }
        }
    }
}