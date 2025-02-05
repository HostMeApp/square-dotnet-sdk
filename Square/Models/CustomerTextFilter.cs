
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
    public class CustomerTextFilter 
    {
        public CustomerTextFilter(string exact = null,
            string fuzzy = null)
        {
            Exact = exact;
            Fuzzy = fuzzy;
        }

        /// <summary>
        /// Use the exact filter to select customers whose attributes match exactly the specified query.
        /// </summary>
        [JsonProperty("exact", NullValueHandling = NullValueHandling.Ignore)]
        public string Exact { get; }

        /// <summary>
        /// Use the fuzzy filter to select customers whose attributes match the specified query 
        /// in a fuzzy manner. When the fuzzy option is used, search queries are tokenized, and then 
        /// each query token must be matched somewhere in the searched attribute. For single token queries, 
        /// this is effectively the same behavior as a partial match operation.
        /// </summary>
        [JsonProperty("fuzzy", NullValueHandling = NullValueHandling.Ignore)]
        public string Fuzzy { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CustomerTextFilter : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Exact = {(Exact == null ? "null" : Exact == string.Empty ? "" : Exact)}");
            toStringOutput.Add($"Fuzzy = {(Fuzzy == null ? "null" : Fuzzy == string.Empty ? "" : Fuzzy)}");
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

            return obj is CustomerTextFilter other &&
                ((Exact == null && other.Exact == null) || (Exact?.Equals(other.Exact) == true)) &&
                ((Fuzzy == null && other.Fuzzy == null) || (Fuzzy?.Equals(other.Fuzzy) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = -1444472756;

            if (Exact != null)
            {
               hashCode += Exact.GetHashCode();
            }

            if (Fuzzy != null)
            {
               hashCode += Fuzzy.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Exact(Exact)
                .Fuzzy(Fuzzy);
            return builder;
        }

        public class Builder
        {
            private string exact;
            private string fuzzy;



            public Builder Exact(string exact)
            {
                this.exact = exact;
                return this;
            }

            public Builder Fuzzy(string fuzzy)
            {
                this.fuzzy = fuzzy;
                return this;
            }

            public CustomerTextFilter Build()
            {
                return new CustomerTextFilter(exact,
                    fuzzy);
            }
        }
    }
}