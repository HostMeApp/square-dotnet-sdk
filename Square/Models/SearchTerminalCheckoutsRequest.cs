
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
    public class SearchTerminalCheckoutsRequest 
    {
        public SearchTerminalCheckoutsRequest(Models.TerminalCheckoutQuery query = null,
            string cursor = null,
            int? limit = null)
        {
            Query = query;
            Cursor = cursor;
            Limit = limit;
        }

        /// <summary>
        /// Getter for query
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TerminalCheckoutQuery Query { get; }

        /// <summary>
        /// A pagination cursor returned by a previous call to this endpoint.
        /// Provide this to retrieve the next set of results for the original query.
        /// See [Pagination](https://developer.squareup.com/docs/basics/api101/pagination) for more information.
        /// </summary>
        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public string Cursor { get; }

        /// <summary>
        /// Limit the number of results returned for a single request.
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchTerminalCheckoutsRequest : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Query = {(Query == null ? "null" : Query.ToString())}");
            toStringOutput.Add($"Cursor = {(Cursor == null ? "null" : Cursor == string.Empty ? "" : Cursor)}");
            toStringOutput.Add($"Limit = {(Limit == null ? "null" : Limit.ToString())}");
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

            return obj is SearchTerminalCheckoutsRequest other &&
                ((Query == null && other.Query == null) || (Query?.Equals(other.Query) == true)) &&
                ((Cursor == null && other.Cursor == null) || (Cursor?.Equals(other.Cursor) == true)) &&
                ((Limit == null && other.Limit == null) || (Limit?.Equals(other.Limit) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 1621232276;

            if (Query != null)
            {
               hashCode += Query.GetHashCode();
            }

            if (Cursor != null)
            {
               hashCode += Cursor.GetHashCode();
            }

            if (Limit != null)
            {
               hashCode += Limit.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Query(Query)
                .Cursor(Cursor)
                .Limit(Limit);
            return builder;
        }

        public class Builder
        {
            private Models.TerminalCheckoutQuery query;
            private string cursor;
            private int? limit;



            public Builder Query(Models.TerminalCheckoutQuery query)
            {
                this.query = query;
                return this;
            }

            public Builder Cursor(string cursor)
            {
                this.cursor = cursor;
                return this;
            }

            public Builder Limit(int? limit)
            {
                this.limit = limit;
                return this;
            }

            public SearchTerminalCheckoutsRequest Build()
            {
                return new SearchTerminalCheckoutsRequest(query,
                    cursor,
                    limit);
            }
        }
    }
}