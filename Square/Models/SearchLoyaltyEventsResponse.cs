
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Square.Http.Client;
using Square;
using Square.Utilities;

namespace Square.Models
{
    public class SearchLoyaltyEventsResponse 
    {
        public SearchLoyaltyEventsResponse(IList<Models.Error> errors = null,
            IList<Models.LoyaltyEvent> events = null,
            string cursor = null)
        {
            Errors = errors;
            Events = events;
            Cursor = cursor;
        }

        [JsonIgnore]
        public HttpContext Context { get; internal set; }

        /// <summary>
        /// Any errors that occurred during the request.
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.Error> Errors { get; }

        /// <summary>
        /// The loyalty events that satisfy the search criteria.
        /// </summary>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.LoyaltyEvent> Events { get; }

        /// <summary>
        /// The pagination cursor to be used in a subsequent 
        /// request. If empty, this is the final response. 
        /// For more information, 
        /// see [Pagination](https://developer.squareup.com/docs/basics/api101/pagination).
        /// </summary>
        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public string Cursor { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchLoyaltyEventsResponse : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Errors = {(Errors == null ? "null" : $"[{ string.Join(", ", Errors)} ]")}");
            toStringOutput.Add($"Events = {(Events == null ? "null" : $"[{ string.Join(", ", Events)} ]")}");
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

            return obj is SearchLoyaltyEventsResponse other &&
                ((Context == null && other.Context == null) || (Context?.Equals(other.Context) == true)) &&
                ((Errors == null && other.Errors == null) || (Errors?.Equals(other.Errors) == true)) &&
                ((Events == null && other.Events == null) || (Events?.Equals(other.Events) == true)) &&
                ((Cursor == null && other.Cursor == null) || (Cursor?.Equals(other.Cursor) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 571920361;

            if (Context != null)
            {
                hashCode += Context.GetHashCode();
            }

            if (Errors != null)
            {
               hashCode += Errors.GetHashCode();
            }

            if (Events != null)
            {
               hashCode += Events.GetHashCode();
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
                .Errors(Errors)
                .Events(Events)
                .Cursor(Cursor);
            return builder;
        }

        public class Builder
        {
            private IList<Models.Error> errors;
            private IList<Models.LoyaltyEvent> events;
            private string cursor;



            public Builder Errors(IList<Models.Error> errors)
            {
                this.errors = errors;
                return this;
            }

            public Builder Events(IList<Models.LoyaltyEvent> events)
            {
                this.events = events;
                return this;
            }

            public Builder Cursor(string cursor)
            {
                this.cursor = cursor;
                return this;
            }

            public SearchLoyaltyEventsResponse Build()
            {
                return new SearchLoyaltyEventsResponse(errors,
                    events,
                    cursor);
            }
        }
    }
}