
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
    public class SearchOrdersSourceFilter 
    {
        public SearchOrdersSourceFilter(IList<string> sourceNames = null)
        {
            SourceNames = sourceNames;
        }

        /// <summary>
        /// Filters by [Source](#type-ordersource) `name`. Will return any orders
        /// with with a `source.name` that matches any of the listed source names.
        /// Max: 10 source names.
        /// </summary>
        [JsonProperty("source_names", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> SourceNames { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchOrdersSourceFilter : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SourceNames = {(SourceNames == null ? "null" : $"[{ string.Join(", ", SourceNames)} ]")}");
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

            return obj is SearchOrdersSourceFilter other &&
                ((SourceNames == null && other.SourceNames == null) || (SourceNames?.Equals(other.SourceNames) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = -530513052;

            if (SourceNames != null)
            {
               hashCode += SourceNames.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .SourceNames(SourceNames);
            return builder;
        }

        public class Builder
        {
            private IList<string> sourceNames;



            public Builder SourceNames(IList<string> sourceNames)
            {
                this.sourceNames = sourceNames;
                return this;
            }

            public SearchOrdersSourceFilter Build()
            {
                return new SearchOrdersSourceFilter(sourceNames);
            }
        }
    }
}