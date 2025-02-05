
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
    public class SearchOrdersFilter 
    {
        public SearchOrdersFilter(Models.SearchOrdersStateFilter stateFilter = null,
            Models.SearchOrdersDateTimeFilter dateTimeFilter = null,
            Models.SearchOrdersFulfillmentFilter fulfillmentFilter = null,
            Models.SearchOrdersSourceFilter sourceFilter = null,
            Models.SearchOrdersCustomerFilter customerFilter = null)
        {
            StateFilter = stateFilter;
            DateTimeFilter = dateTimeFilter;
            FulfillmentFilter = fulfillmentFilter;
            SourceFilter = sourceFilter;
            CustomerFilter = customerFilter;
        }

        /// <summary>
        /// Filter by current Order `state`.
        /// </summary>
        [JsonProperty("state_filter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SearchOrdersStateFilter StateFilter { get; }

        /// <summary>
        /// Filter for `Order` objects based on whether their `CREATED_AT`,
        /// `CLOSED_AT` or `UPDATED_AT` timestamps fall within a specified time range.
        /// You can specify the time range and which timestamp to filter for. You can filter
        /// for only one time range at a time.
        /// For each time range, the start time and end time are inclusive. If the end time
        /// is absent, it defaults to the time of the first request for the cursor.
        /// __Important:__ If you use the DateTimeFilter in a SearchOrders query,
        /// you must also set the `sort_field` in [OrdersSort](#type-searchorderordersort)
        /// to the same field you filter for. For example, if you set the `CLOSED_AT` field
        /// in DateTimeFilter, you must also set the `sort_field` in SearchOrdersSort to
        /// `CLOSED_AT`. Otherwise, SearchOrders will throw an error.
        /// [Learn more about filtering orders by time range](https://developer.squareup.com/docs/orders-api/manage-orders#important-note-on-filtering-orders-by-time-range).
        /// </summary>
        [JsonProperty("date_time_filter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SearchOrdersDateTimeFilter DateTimeFilter { get; }

        /// <summary>
        /// Filter based on [Order Fulfillment](#type-orderfulfillment) information.
        /// </summary>
        [JsonProperty("fulfillment_filter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SearchOrdersFulfillmentFilter FulfillmentFilter { get; }

        /// <summary>
        /// Filter based on order `source` information.
        /// </summary>
        [JsonProperty("source_filter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SearchOrdersSourceFilter SourceFilter { get; }

        /// <summary>
        /// Filter based on Order `customer_id` and any Tender `customer_id`
        /// associated with the Order. Does not filter based on the
        /// [FulfillmentRecipient](#type-orderfulfillmentrecipient) `customer_id`.
        /// </summary>
        [JsonProperty("customer_filter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SearchOrdersCustomerFilter CustomerFilter { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchOrdersFilter : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"StateFilter = {(StateFilter == null ? "null" : StateFilter.ToString())}");
            toStringOutput.Add($"DateTimeFilter = {(DateTimeFilter == null ? "null" : DateTimeFilter.ToString())}");
            toStringOutput.Add($"FulfillmentFilter = {(FulfillmentFilter == null ? "null" : FulfillmentFilter.ToString())}");
            toStringOutput.Add($"SourceFilter = {(SourceFilter == null ? "null" : SourceFilter.ToString())}");
            toStringOutput.Add($"CustomerFilter = {(CustomerFilter == null ? "null" : CustomerFilter.ToString())}");
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

            return obj is SearchOrdersFilter other &&
                ((StateFilter == null && other.StateFilter == null) || (StateFilter?.Equals(other.StateFilter) == true)) &&
                ((DateTimeFilter == null && other.DateTimeFilter == null) || (DateTimeFilter?.Equals(other.DateTimeFilter) == true)) &&
                ((FulfillmentFilter == null && other.FulfillmentFilter == null) || (FulfillmentFilter?.Equals(other.FulfillmentFilter) == true)) &&
                ((SourceFilter == null && other.SourceFilter == null) || (SourceFilter?.Equals(other.SourceFilter) == true)) &&
                ((CustomerFilter == null && other.CustomerFilter == null) || (CustomerFilter?.Equals(other.CustomerFilter) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = -566134060;

            if (StateFilter != null)
            {
               hashCode += StateFilter.GetHashCode();
            }

            if (DateTimeFilter != null)
            {
               hashCode += DateTimeFilter.GetHashCode();
            }

            if (FulfillmentFilter != null)
            {
               hashCode += FulfillmentFilter.GetHashCode();
            }

            if (SourceFilter != null)
            {
               hashCode += SourceFilter.GetHashCode();
            }

            if (CustomerFilter != null)
            {
               hashCode += CustomerFilter.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .StateFilter(StateFilter)
                .DateTimeFilter(DateTimeFilter)
                .FulfillmentFilter(FulfillmentFilter)
                .SourceFilter(SourceFilter)
                .CustomerFilter(CustomerFilter);
            return builder;
        }

        public class Builder
        {
            private Models.SearchOrdersStateFilter stateFilter;
            private Models.SearchOrdersDateTimeFilter dateTimeFilter;
            private Models.SearchOrdersFulfillmentFilter fulfillmentFilter;
            private Models.SearchOrdersSourceFilter sourceFilter;
            private Models.SearchOrdersCustomerFilter customerFilter;



            public Builder StateFilter(Models.SearchOrdersStateFilter stateFilter)
            {
                this.stateFilter = stateFilter;
                return this;
            }

            public Builder DateTimeFilter(Models.SearchOrdersDateTimeFilter dateTimeFilter)
            {
                this.dateTimeFilter = dateTimeFilter;
                return this;
            }

            public Builder FulfillmentFilter(Models.SearchOrdersFulfillmentFilter fulfillmentFilter)
            {
                this.fulfillmentFilter = fulfillmentFilter;
                return this;
            }

            public Builder SourceFilter(Models.SearchOrdersSourceFilter sourceFilter)
            {
                this.sourceFilter = sourceFilter;
                return this;
            }

            public Builder CustomerFilter(Models.SearchOrdersCustomerFilter customerFilter)
            {
                this.customerFilter = customerFilter;
                return this;
            }

            public SearchOrdersFilter Build()
            {
                return new SearchOrdersFilter(stateFilter,
                    dateTimeFilter,
                    fulfillmentFilter,
                    sourceFilter,
                    customerFilter);
            }
        }
    }
}