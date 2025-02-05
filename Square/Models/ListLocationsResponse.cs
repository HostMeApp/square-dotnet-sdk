
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
    public class ListLocationsResponse 
    {
        public ListLocationsResponse(IList<Models.Error> errors = null,
            IList<Models.Location> locations = null)
        {
            Errors = errors;
            Locations = locations;
        }

        [JsonIgnore]
        public HttpContext Context { get; internal set; }

        /// <summary>
        /// Any errors that occurred during the request.
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.Error> Errors { get; }

        /// <summary>
        /// The business locations.
        /// </summary>
        [JsonProperty("locations", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.Location> Locations { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListLocationsResponse : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Errors = {(Errors == null ? "null" : $"[{ string.Join(", ", Errors)} ]")}");
            toStringOutput.Add($"Locations = {(Locations == null ? "null" : $"[{ string.Join(", ", Locations)} ]")}");
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

            return obj is ListLocationsResponse other &&
                ((Context == null && other.Context == null) || (Context?.Equals(other.Context) == true)) &&
                ((Errors == null && other.Errors == null) || (Errors?.Equals(other.Errors) == true)) &&
                ((Locations == null && other.Locations == null) || (Locations?.Equals(other.Locations) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = -320471119;

            if (Context != null)
            {
                hashCode += Context.GetHashCode();
            }

            if (Errors != null)
            {
               hashCode += Errors.GetHashCode();
            }

            if (Locations != null)
            {
               hashCode += Locations.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Errors(Errors)
                .Locations(Locations);
            return builder;
        }

        public class Builder
        {
            private IList<Models.Error> errors;
            private IList<Models.Location> locations;



            public Builder Errors(IList<Models.Error> errors)
            {
                this.errors = errors;
                return this;
            }

            public Builder Locations(IList<Models.Location> locations)
            {
                this.locations = locations;
                return this;
            }

            public ListLocationsResponse Build()
            {
                return new ListLocationsResponse(errors,
                    locations);
            }
        }
    }
}