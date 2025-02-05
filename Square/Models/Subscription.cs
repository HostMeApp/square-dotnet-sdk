
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
    public class Subscription 
    {
        public Subscription(string id = null,
            string locationId = null,
            string planId = null,
            string customerId = null,
            string startDate = null,
            string canceledDate = null,
            string status = null,
            string taxPercentage = null,
            IList<string> invoiceIds = null,
            Models.Money priceOverrideMoney = null,
            long? version = null,
            string createdAt = null,
            string cardId = null,
            string paidUntilDate = null,
            string timezone = null)
        {
            Id = id;
            LocationId = locationId;
            PlanId = planId;
            CustomerId = customerId;
            StartDate = startDate;
            CanceledDate = canceledDate;
            Status = status;
            TaxPercentage = taxPercentage;
            InvoiceIds = invoiceIds;
            PriceOverrideMoney = priceOverrideMoney;
            Version = version;
            CreatedAt = createdAt;
            CardId = cardId;
            PaidUntilDate = paidUntilDate;
            Timezone = timezone;
        }

        /// <summary>
        /// The Square-assigned ID of the subscription.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; }

        /// <summary>
        /// The ID of the location associated with the subscription.
        /// </summary>
        [JsonProperty("location_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationId { get; }

        /// <summary>
        /// The ID of the associated [subscription plan](#type-catalogsubscriptionplan).
        /// </summary>
        [JsonProperty("plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; }

        /// <summary>
        /// The ID of the associated [customer](#type-customer) profile.
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; }

        /// <summary>
        /// The start date of the subscription, in YYYY-MM-DD format (for example,
        /// 2013-01-15).
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; }

        /// <summary>
        /// The subscription cancellation date, in YYYY-MM-DD format (for
        /// example, 2013-01-15). On this date, the subscription status changes 
        /// to `CANCELED` and the subscription billing stops. 
        /// If you don't set this field, the subscription plan dictates if and 
        /// when subscription ends. 
        /// You cannot update this field, you can only clear it.
        /// </summary>
        [JsonProperty("canceled_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CanceledDate { get; }

        /// <summary>
        /// Possible subscription status values.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; }

        /// <summary>
        /// The tax amount applied when billing the subscription. The
        /// percentage is expressed in decimal form, using a `'.'` as the decimal
        /// separator and without a `'%'` sign. For example, a value of `7.5`
        /// corresponds to 7.5%.
        /// </summary>
        [JsonProperty("tax_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxPercentage { get; }

        /// <summary>
        /// The IDs of the [invoices](#type-invoice) created for the 
        /// subscription, listed in order when the invoices were created 
        /// (oldest invoices appear first).
        /// </summary>
        [JsonProperty("invoice_ids", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> InvoiceIds { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("price_override_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money PriceOverrideMoney { get; }

        /// <summary>
        /// The version of the object. When updating an object, the version
        /// supplied must match the version in the database, otherwise the write will
        /// be rejected as conflicting.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public long? Version { get; }

        /// <summary>
        /// The timestamp when the subscription was created, in RFC 3339 format.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; }

        /// <summary>
        /// The ID of the [customer](#type-customer) [card](#type-card)
        /// that is charged for the subscription.
        /// </summary>
        [JsonProperty("card_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CardId { get; }

        /// <summary>
        /// The date up to which the customer is invoiced for the
        /// subscription, in YYYY-MM-DD format (for example, 2013-01-15).
        /// After the invoice is paid for a given billing period,
        /// this date will be the last day of the billing period.
        /// For example,
        /// suppose for the month of May a customer gets an invoice
        /// (or charged the card) on May 1. For the monthly billing scenario,
        /// this date is then set to May 31.
        /// </summary>
        [JsonProperty("paid_until_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PaidUntilDate { get; }

        /// <summary>
        /// Timezone that will be used in date calculations for the subscription.
        /// Defaults to the timezone of the location based on `location_id`.
        /// Format: the IANA Timezone Database identifier for the location timezone (for example, `America/Los_Angeles`).
        /// </summary>
        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Subscription : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(Id == null ? "null" : Id == string.Empty ? "" : Id)}");
            toStringOutput.Add($"LocationId = {(LocationId == null ? "null" : LocationId == string.Empty ? "" : LocationId)}");
            toStringOutput.Add($"PlanId = {(PlanId == null ? "null" : PlanId == string.Empty ? "" : PlanId)}");
            toStringOutput.Add($"CustomerId = {(CustomerId == null ? "null" : CustomerId == string.Empty ? "" : CustomerId)}");
            toStringOutput.Add($"StartDate = {(StartDate == null ? "null" : StartDate == string.Empty ? "" : StartDate)}");
            toStringOutput.Add($"CanceledDate = {(CanceledDate == null ? "null" : CanceledDate == string.Empty ? "" : CanceledDate)}");
            toStringOutput.Add($"Status = {(Status == null ? "null" : Status.ToString())}");
            toStringOutput.Add($"TaxPercentage = {(TaxPercentage == null ? "null" : TaxPercentage == string.Empty ? "" : TaxPercentage)}");
            toStringOutput.Add($"InvoiceIds = {(InvoiceIds == null ? "null" : $"[{ string.Join(", ", InvoiceIds)} ]")}");
            toStringOutput.Add($"PriceOverrideMoney = {(PriceOverrideMoney == null ? "null" : PriceOverrideMoney.ToString())}");
            toStringOutput.Add($"Version = {(Version == null ? "null" : Version.ToString())}");
            toStringOutput.Add($"CreatedAt = {(CreatedAt == null ? "null" : CreatedAt == string.Empty ? "" : CreatedAt)}");
            toStringOutput.Add($"CardId = {(CardId == null ? "null" : CardId == string.Empty ? "" : CardId)}");
            toStringOutput.Add($"PaidUntilDate = {(PaidUntilDate == null ? "null" : PaidUntilDate == string.Empty ? "" : PaidUntilDate)}");
            toStringOutput.Add($"Timezone = {(Timezone == null ? "null" : Timezone == string.Empty ? "" : Timezone)}");
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

            return obj is Subscription other &&
                ((Id == null && other.Id == null) || (Id?.Equals(other.Id) == true)) &&
                ((LocationId == null && other.LocationId == null) || (LocationId?.Equals(other.LocationId) == true)) &&
                ((PlanId == null && other.PlanId == null) || (PlanId?.Equals(other.PlanId) == true)) &&
                ((CustomerId == null && other.CustomerId == null) || (CustomerId?.Equals(other.CustomerId) == true)) &&
                ((StartDate == null && other.StartDate == null) || (StartDate?.Equals(other.StartDate) == true)) &&
                ((CanceledDate == null && other.CanceledDate == null) || (CanceledDate?.Equals(other.CanceledDate) == true)) &&
                ((Status == null && other.Status == null) || (Status?.Equals(other.Status) == true)) &&
                ((TaxPercentage == null && other.TaxPercentage == null) || (TaxPercentage?.Equals(other.TaxPercentage) == true)) &&
                ((InvoiceIds == null && other.InvoiceIds == null) || (InvoiceIds?.Equals(other.InvoiceIds) == true)) &&
                ((PriceOverrideMoney == null && other.PriceOverrideMoney == null) || (PriceOverrideMoney?.Equals(other.PriceOverrideMoney) == true)) &&
                ((Version == null && other.Version == null) || (Version?.Equals(other.Version) == true)) &&
                ((CreatedAt == null && other.CreatedAt == null) || (CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((CardId == null && other.CardId == null) || (CardId?.Equals(other.CardId) == true)) &&
                ((PaidUntilDate == null && other.PaidUntilDate == null) || (PaidUntilDate?.Equals(other.PaidUntilDate) == true)) &&
                ((Timezone == null && other.Timezone == null) || (Timezone?.Equals(other.Timezone) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = -1265150766;

            if (Id != null)
            {
               hashCode += Id.GetHashCode();
            }

            if (LocationId != null)
            {
               hashCode += LocationId.GetHashCode();
            }

            if (PlanId != null)
            {
               hashCode += PlanId.GetHashCode();
            }

            if (CustomerId != null)
            {
               hashCode += CustomerId.GetHashCode();
            }

            if (StartDate != null)
            {
               hashCode += StartDate.GetHashCode();
            }

            if (CanceledDate != null)
            {
               hashCode += CanceledDate.GetHashCode();
            }

            if (Status != null)
            {
               hashCode += Status.GetHashCode();
            }

            if (TaxPercentage != null)
            {
               hashCode += TaxPercentage.GetHashCode();
            }

            if (InvoiceIds != null)
            {
               hashCode += InvoiceIds.GetHashCode();
            }

            if (PriceOverrideMoney != null)
            {
               hashCode += PriceOverrideMoney.GetHashCode();
            }

            if (Version != null)
            {
               hashCode += Version.GetHashCode();
            }

            if (CreatedAt != null)
            {
               hashCode += CreatedAt.GetHashCode();
            }

            if (CardId != null)
            {
               hashCode += CardId.GetHashCode();
            }

            if (PaidUntilDate != null)
            {
               hashCode += PaidUntilDate.GetHashCode();
            }

            if (Timezone != null)
            {
               hashCode += Timezone.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Id(Id)
                .LocationId(LocationId)
                .PlanId(PlanId)
                .CustomerId(CustomerId)
                .StartDate(StartDate)
                .CanceledDate(CanceledDate)
                .Status(Status)
                .TaxPercentage(TaxPercentage)
                .InvoiceIds(InvoiceIds)
                .PriceOverrideMoney(PriceOverrideMoney)
                .Version(Version)
                .CreatedAt(CreatedAt)
                .CardId(CardId)
                .PaidUntilDate(PaidUntilDate)
                .Timezone(Timezone);
            return builder;
        }

        public class Builder
        {
            private string id;
            private string locationId;
            private string planId;
            private string customerId;
            private string startDate;
            private string canceledDate;
            private string status;
            private string taxPercentage;
            private IList<string> invoiceIds;
            private Models.Money priceOverrideMoney;
            private long? version;
            private string createdAt;
            private string cardId;
            private string paidUntilDate;
            private string timezone;



            public Builder Id(string id)
            {
                this.id = id;
                return this;
            }

            public Builder LocationId(string locationId)
            {
                this.locationId = locationId;
                return this;
            }

            public Builder PlanId(string planId)
            {
                this.planId = planId;
                return this;
            }

            public Builder CustomerId(string customerId)
            {
                this.customerId = customerId;
                return this;
            }

            public Builder StartDate(string startDate)
            {
                this.startDate = startDate;
                return this;
            }

            public Builder CanceledDate(string canceledDate)
            {
                this.canceledDate = canceledDate;
                return this;
            }

            public Builder Status(string status)
            {
                this.status = status;
                return this;
            }

            public Builder TaxPercentage(string taxPercentage)
            {
                this.taxPercentage = taxPercentage;
                return this;
            }

            public Builder InvoiceIds(IList<string> invoiceIds)
            {
                this.invoiceIds = invoiceIds;
                return this;
            }

            public Builder PriceOverrideMoney(Models.Money priceOverrideMoney)
            {
                this.priceOverrideMoney = priceOverrideMoney;
                return this;
            }

            public Builder Version(long? version)
            {
                this.version = version;
                return this;
            }

            public Builder CreatedAt(string createdAt)
            {
                this.createdAt = createdAt;
                return this;
            }

            public Builder CardId(string cardId)
            {
                this.cardId = cardId;
                return this;
            }

            public Builder PaidUntilDate(string paidUntilDate)
            {
                this.paidUntilDate = paidUntilDate;
                return this;
            }

            public Builder Timezone(string timezone)
            {
                this.timezone = timezone;
                return this;
            }

            public Subscription Build()
            {
                return new Subscription(id,
                    locationId,
                    planId,
                    customerId,
                    startDate,
                    canceledDate,
                    status,
                    taxPercentage,
                    invoiceIds,
                    priceOverrideMoney,
                    version,
                    createdAt,
                    cardId,
                    paidUntilDate,
                    timezone);
            }
        }
    }
}