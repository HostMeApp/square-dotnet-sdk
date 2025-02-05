
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
    public class CustomAttributeFilter 
    {
        public CustomAttributeFilter(string customAttributeDefinitionId = null,
            string key = null,
            string stringFilter = null,
            Models.Range numberFilter = null,
            IList<string> selectionUidsFilter = null,
            bool? boolFilter = null)
        {
            CustomAttributeDefinitionId = customAttributeDefinitionId;
            Key = key;
            StringFilter = stringFilter;
            NumberFilter = numberFilter;
            SelectionUidsFilter = selectionUidsFilter;
            BoolFilter = boolFilter;
        }

        /// <summary>
        /// A query expression to filter items or item variations by matching their custom attributes'
        /// `custom_attribute_definition_id`
        /// property value against the the specified id.
        /// </summary>
        [JsonProperty("custom_attribute_definition_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomAttributeDefinitionId { get; }

        /// <summary>
        /// A query expression to filter items or item variations by matching their custom attributes'
        /// `key` property value against
        /// the specified key.
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; }

        /// <summary>
        /// A query expression to filter items or item variations by matching their custom attributes'
        /// `string_value`  property value
        /// against the specified text.
        /// </summary>
        [JsonProperty("string_filter", NullValueHandling = NullValueHandling.Ignore)]
        public string StringFilter { get; }

        /// <summary>
        /// The range of a number value between the specified lower and upper bounds.
        /// </summary>
        [JsonProperty("number_filter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Range NumberFilter { get; }

        /// <summary>
        /// A query expression to filter items or item variations by matching  their custom attributes'
        /// `selection_uid_values`
        /// values against the specified selection uids.
        /// </summary>
        [JsonProperty("selection_uids_filter", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> SelectionUidsFilter { get; }

        /// <summary>
        /// A query expression to filter items or item variations by matching their custom attributes'
        /// `boolean_value` property values
        /// against the specified Boolean expression.
        /// </summary>
        [JsonProperty("bool_filter", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BoolFilter { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CustomAttributeFilter : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CustomAttributeDefinitionId = {(CustomAttributeDefinitionId == null ? "null" : CustomAttributeDefinitionId == string.Empty ? "" : CustomAttributeDefinitionId)}");
            toStringOutput.Add($"Key = {(Key == null ? "null" : Key == string.Empty ? "" : Key)}");
            toStringOutput.Add($"StringFilter = {(StringFilter == null ? "null" : StringFilter == string.Empty ? "" : StringFilter)}");
            toStringOutput.Add($"NumberFilter = {(NumberFilter == null ? "null" : NumberFilter.ToString())}");
            toStringOutput.Add($"SelectionUidsFilter = {(SelectionUidsFilter == null ? "null" : $"[{ string.Join(", ", SelectionUidsFilter)} ]")}");
            toStringOutput.Add($"BoolFilter = {(BoolFilter == null ? "null" : BoolFilter.ToString())}");
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

            return obj is CustomAttributeFilter other &&
                ((CustomAttributeDefinitionId == null && other.CustomAttributeDefinitionId == null) || (CustomAttributeDefinitionId?.Equals(other.CustomAttributeDefinitionId) == true)) &&
                ((Key == null && other.Key == null) || (Key?.Equals(other.Key) == true)) &&
                ((StringFilter == null && other.StringFilter == null) || (StringFilter?.Equals(other.StringFilter) == true)) &&
                ((NumberFilter == null && other.NumberFilter == null) || (NumberFilter?.Equals(other.NumberFilter) == true)) &&
                ((SelectionUidsFilter == null && other.SelectionUidsFilter == null) || (SelectionUidsFilter?.Equals(other.SelectionUidsFilter) == true)) &&
                ((BoolFilter == null && other.BoolFilter == null) || (BoolFilter?.Equals(other.BoolFilter) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 1810299489;

            if (CustomAttributeDefinitionId != null)
            {
               hashCode += CustomAttributeDefinitionId.GetHashCode();
            }

            if (Key != null)
            {
               hashCode += Key.GetHashCode();
            }

            if (StringFilter != null)
            {
               hashCode += StringFilter.GetHashCode();
            }

            if (NumberFilter != null)
            {
               hashCode += NumberFilter.GetHashCode();
            }

            if (SelectionUidsFilter != null)
            {
               hashCode += SelectionUidsFilter.GetHashCode();
            }

            if (BoolFilter != null)
            {
               hashCode += BoolFilter.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .CustomAttributeDefinitionId(CustomAttributeDefinitionId)
                .Key(Key)
                .StringFilter(StringFilter)
                .NumberFilter(NumberFilter)
                .SelectionUidsFilter(SelectionUidsFilter)
                .BoolFilter(BoolFilter);
            return builder;
        }

        public class Builder
        {
            private string customAttributeDefinitionId;
            private string key;
            private string stringFilter;
            private Models.Range numberFilter;
            private IList<string> selectionUidsFilter;
            private bool? boolFilter;



            public Builder CustomAttributeDefinitionId(string customAttributeDefinitionId)
            {
                this.customAttributeDefinitionId = customAttributeDefinitionId;
                return this;
            }

            public Builder Key(string key)
            {
                this.key = key;
                return this;
            }

            public Builder StringFilter(string stringFilter)
            {
                this.stringFilter = stringFilter;
                return this;
            }

            public Builder NumberFilter(Models.Range numberFilter)
            {
                this.numberFilter = numberFilter;
                return this;
            }

            public Builder SelectionUidsFilter(IList<string> selectionUidsFilter)
            {
                this.selectionUidsFilter = selectionUidsFilter;
                return this;
            }

            public Builder BoolFilter(bool? boolFilter)
            {
                this.boolFilter = boolFilter;
                return this;
            }

            public CustomAttributeFilter Build()
            {
                return new CustomAttributeFilter(customAttributeDefinitionId,
                    key,
                    stringFilter,
                    numberFilter,
                    selectionUidsFilter,
                    boolFilter);
            }
        }
    }
}