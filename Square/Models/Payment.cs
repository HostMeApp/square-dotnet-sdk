
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
    public class Payment 
    {
        public Payment(string id = null,
            string createdAt = null,
            string updatedAt = null,
            Models.Money amountMoney = null,
            Models.Money tipMoney = null,
            Models.Money totalMoney = null,
            Models.Money appFeeMoney = null,
            IList<Models.ProcessingFee> processingFee = null,
            Models.Money refundedMoney = null,
            string status = null,
            string delayDuration = null,
            string delayAction = null,
            string delayedUntil = null,
            string sourceType = null,
            Models.CardPaymentDetails cardDetails = null,
            string locationId = null,
            string orderId = null,
            string referenceId = null,
            string customerId = null,
            string employeeId = null,
            IList<string> refundIds = null,
            Models.RiskEvaluation riskEvaluation = null,
            string buyerEmailAddress = null,
            Models.Address billingAddress = null,
            Models.Address shippingAddress = null,
            string note = null,
            string statementDescriptionIdentifier = null,
            string receiptNumber = null,
            string receiptUrl = null)
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            AmountMoney = amountMoney;
            TipMoney = tipMoney;
            TotalMoney = totalMoney;
            AppFeeMoney = appFeeMoney;
            ProcessingFee = processingFee;
            RefundedMoney = refundedMoney;
            Status = status;
            DelayDuration = delayDuration;
            DelayAction = delayAction;
            DelayedUntil = delayedUntil;
            SourceType = sourceType;
            CardDetails = cardDetails;
            LocationId = locationId;
            OrderId = orderId;
            ReferenceId = referenceId;
            CustomerId = customerId;
            EmployeeId = employeeId;
            RefundIds = refundIds;
            RiskEvaluation = riskEvaluation;
            BuyerEmailAddress = buyerEmailAddress;
            BillingAddress = billingAddress;
            ShippingAddress = shippingAddress;
            Note = note;
            StatementDescriptionIdentifier = statementDescriptionIdentifier;
            ReceiptNumber = receiptNumber;
            ReceiptUrl = receiptUrl;
        }

        /// <summary>
        /// A unique ID for the payment.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The timestamp of when the payment was created, in RFC 3339 format.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The timestamp of when the payment was last updated, in RFC 3339 format.
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("amount_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money AmountMoney { get; set; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("tip_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money TipMoney { get; set; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("total_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money TotalMoney { get; set; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("app_fee_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money AppFeeMoney { get; set; }

        /// <summary>
        /// The processing fees and fee adjustments assessed by Square for this payment.
        /// </summary>
        [JsonProperty("processing_fee", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.ProcessingFee> ProcessingFee { get; set; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("refunded_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money RefundedMoney { get; set; }

        /// <summary>
        /// Indicates whether the payment is APPROVED, COMPLETED, CANCELED, or FAILED.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// The duration of time after the payment's creation when Square automatically applies the
        /// `delay_action` to the payment. This automatic `delay_action` applies only to payments that
        /// do not reach a terminal state (COMPLETED, CANCELED, or FAILED) before the `delay_duration`
        /// time period.
        /// This field is specified as a time duration, in RFC 3339 format.
        /// Notes:
        /// This feature is only supported for card payments.
        /// Default:
        /// - Card-present payments: "PT36H" (36 hours) from the creation time.
        /// - Card-not-present payments: "P7D" (7 days) from the creation time.
        /// </summary>
        [JsonProperty("delay_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string DelayDuration { get; set; }

        /// <summary>
        /// The action to be applied to the payment when the `delay_duration` has elapsed. This field
        /// is read-only.
        /// Current values include `CANCEL`.
        /// </summary>
        [JsonProperty("delay_action", NullValueHandling = NullValueHandling.Ignore)]
        public string DelayAction { get; set; }

        /// <summary>
        /// The read-only timestamp of when the `delay_action` is automatically applied,
        /// in RFC 3339 format.
        /// Note that this field is calculated by summing the payment's `delay_duration` and `created_at`
        /// fields. The `created_at` field is generated by Square and might not exactly match the
        /// time on your local machine.
        /// </summary>
        [JsonProperty("delayed_until", NullValueHandling = NullValueHandling.Ignore)]
        public string DelayedUntil { get; set; }

        /// <summary>
        /// The source type for this payment.
        /// Current values include `CARD`.
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceType { get; set; }

        /// <summary>
        /// Reflects the current status of a card payment.
        /// </summary>
        [JsonProperty("card_details", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardPaymentDetails CardDetails { get; set; }

        /// <summary>
        /// The ID of the location associated with the payment.
        /// </summary>
        [JsonProperty("location_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationId { get; set; }

        /// <summary>
        /// The ID of the order associated with the payment.
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// An optional ID that associates the payment with an entity in
        /// another system.
        /// </summary>
        [JsonProperty("reference_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The [Customer](#type-customer) ID of the customer associated with the payment.
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// An optional ID of the employee associated with taking the payment.
        /// </summary>
        [JsonProperty("employee_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// A list of `refund_id`s identifying refunds for the payment.
        /// </summary>
        [JsonProperty("refund_ids", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> RefundIds { get; set; }

        /// <summary>
        /// Represents fraud risk information for the associated payment.
        /// When you take a payment through Square's Payments API (using the `CreatePayment`
        /// endpoint), Square evaluates it and assigns a risk level to the payment. Sellers
        /// can use this information to determine the course of action (for example,
        /// provide the goods/services or refund the payment).
        /// </summary>
        [JsonProperty("risk_evaluation", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RiskEvaluation RiskEvaluation { get; set; }

        /// <summary>
        /// The buyer's email address.
        /// </summary>
        [JsonProperty("buyer_email_address", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerEmailAddress { get; set; }

        /// <summary>
        /// Represents a physical address.
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address BillingAddress { get; set; }

        /// <summary>
        /// Represents a physical address.
        /// </summary>
        [JsonProperty("shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address ShippingAddress { get; set; }

        /// <summary>
        /// An optional note to include when creating a payment.
        /// </summary>
        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        /// <summary>
        /// Additional payment information that gets added to the customer's card statement
        /// as part of the statement description.
        /// Note that the `statement_description_identifier` might get truncated on the statement description
        /// to fit the required information including the Square identifier (SQ *) and the name of the
        /// seller taking the payment.
        /// </summary>
        [JsonProperty("statement_description_identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string StatementDescriptionIdentifier { get; set; }

        /// <summary>
        /// The payment's receipt number.
        /// The field is missing if a payment is canceled.
        /// </summary>
        [JsonProperty("receipt_number", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiptNumber { get; set; }

        /// <summary>
        /// The URL for the payment's receipt.
        /// The field is only populated for COMPLETED payments.
        /// </summary>
        [JsonProperty("receipt_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiptUrl { get; set; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Payment : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(Id == null ? "null" : Id == string.Empty ? "" : Id)}");
            toStringOutput.Add($"CreatedAt = {(CreatedAt == null ? "null" : CreatedAt == string.Empty ? "" : CreatedAt)}");
            toStringOutput.Add($"UpdatedAt = {(UpdatedAt == null ? "null" : UpdatedAt == string.Empty ? "" : UpdatedAt)}");
            toStringOutput.Add($"AmountMoney = {(AmountMoney == null ? "null" : AmountMoney.ToString())}");
            toStringOutput.Add($"TipMoney = {(TipMoney == null ? "null" : TipMoney.ToString())}");
            toStringOutput.Add($"TotalMoney = {(TotalMoney == null ? "null" : TotalMoney.ToString())}");
            toStringOutput.Add($"AppFeeMoney = {(AppFeeMoney == null ? "null" : AppFeeMoney.ToString())}");
            toStringOutput.Add($"ProcessingFee = {(ProcessingFee == null ? "null" : $"[{ string.Join(", ", ProcessingFee)} ]")}");
            toStringOutput.Add($"RefundedMoney = {(RefundedMoney == null ? "null" : RefundedMoney.ToString())}");
            toStringOutput.Add($"Status = {(Status == null ? "null" : Status == string.Empty ? "" : Status)}");
            toStringOutput.Add($"DelayDuration = {(DelayDuration == null ? "null" : DelayDuration == string.Empty ? "" : DelayDuration)}");
            toStringOutput.Add($"DelayAction = {(DelayAction == null ? "null" : DelayAction == string.Empty ? "" : DelayAction)}");
            toStringOutput.Add($"DelayedUntil = {(DelayedUntil == null ? "null" : DelayedUntil == string.Empty ? "" : DelayedUntil)}");
            toStringOutput.Add($"SourceType = {(SourceType == null ? "null" : SourceType == string.Empty ? "" : SourceType)}");
            toStringOutput.Add($"CardDetails = {(CardDetails == null ? "null" : CardDetails.ToString())}");
            toStringOutput.Add($"LocationId = {(LocationId == null ? "null" : LocationId == string.Empty ? "" : LocationId)}");
            toStringOutput.Add($"OrderId = {(OrderId == null ? "null" : OrderId == string.Empty ? "" : OrderId)}");
            toStringOutput.Add($"ReferenceId = {(ReferenceId == null ? "null" : ReferenceId == string.Empty ? "" : ReferenceId)}");
            toStringOutput.Add($"CustomerId = {(CustomerId == null ? "null" : CustomerId == string.Empty ? "" : CustomerId)}");
            toStringOutput.Add($"EmployeeId = {(EmployeeId == null ? "null" : EmployeeId == string.Empty ? "" : EmployeeId)}");
            toStringOutput.Add($"RefundIds = {(RefundIds == null ? "null" : $"[{ string.Join(", ", RefundIds)} ]")}");
            toStringOutput.Add($"RiskEvaluation = {(RiskEvaluation == null ? "null" : RiskEvaluation.ToString())}");
            toStringOutput.Add($"BuyerEmailAddress = {(BuyerEmailAddress == null ? "null" : BuyerEmailAddress == string.Empty ? "" : BuyerEmailAddress)}");
            toStringOutput.Add($"BillingAddress = {(BillingAddress == null ? "null" : BillingAddress.ToString())}");
            toStringOutput.Add($"ShippingAddress = {(ShippingAddress == null ? "null" : ShippingAddress.ToString())}");
            toStringOutput.Add($"Note = {(Note == null ? "null" : Note == string.Empty ? "" : Note)}");
            toStringOutput.Add($"StatementDescriptionIdentifier = {(StatementDescriptionIdentifier == null ? "null" : StatementDescriptionIdentifier == string.Empty ? "" : StatementDescriptionIdentifier)}");
            toStringOutput.Add($"ReceiptNumber = {(ReceiptNumber == null ? "null" : ReceiptNumber == string.Empty ? "" : ReceiptNumber)}");
            toStringOutput.Add($"ReceiptUrl = {(ReceiptUrl == null ? "null" : ReceiptUrl == string.Empty ? "" : ReceiptUrl)}");
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

            return obj is Payment other &&
                ((Id == null && other.Id == null) || (Id?.Equals(other.Id) == true)) &&
                ((CreatedAt == null && other.CreatedAt == null) || (CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((UpdatedAt == null && other.UpdatedAt == null) || (UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((AmountMoney == null && other.AmountMoney == null) || (AmountMoney?.Equals(other.AmountMoney) == true)) &&
                ((TipMoney == null && other.TipMoney == null) || (TipMoney?.Equals(other.TipMoney) == true)) &&
                ((TotalMoney == null && other.TotalMoney == null) || (TotalMoney?.Equals(other.TotalMoney) == true)) &&
                ((AppFeeMoney == null && other.AppFeeMoney == null) || (AppFeeMoney?.Equals(other.AppFeeMoney) == true)) &&
                ((ProcessingFee == null && other.ProcessingFee == null) || (ProcessingFee?.Equals(other.ProcessingFee) == true)) &&
                ((RefundedMoney == null && other.RefundedMoney == null) || (RefundedMoney?.Equals(other.RefundedMoney) == true)) &&
                ((Status == null && other.Status == null) || (Status?.Equals(other.Status) == true)) &&
                ((DelayDuration == null && other.DelayDuration == null) || (DelayDuration?.Equals(other.DelayDuration) == true)) &&
                ((DelayAction == null && other.DelayAction == null) || (DelayAction?.Equals(other.DelayAction) == true)) &&
                ((DelayedUntil == null && other.DelayedUntil == null) || (DelayedUntil?.Equals(other.DelayedUntil) == true)) &&
                ((SourceType == null && other.SourceType == null) || (SourceType?.Equals(other.SourceType) == true)) &&
                ((CardDetails == null && other.CardDetails == null) || (CardDetails?.Equals(other.CardDetails) == true)) &&
                ((LocationId == null && other.LocationId == null) || (LocationId?.Equals(other.LocationId) == true)) &&
                ((OrderId == null && other.OrderId == null) || (OrderId?.Equals(other.OrderId) == true)) &&
                ((ReferenceId == null && other.ReferenceId == null) || (ReferenceId?.Equals(other.ReferenceId) == true)) &&
                ((CustomerId == null && other.CustomerId == null) || (CustomerId?.Equals(other.CustomerId) == true)) &&
                ((EmployeeId == null && other.EmployeeId == null) || (EmployeeId?.Equals(other.EmployeeId) == true)) &&
                ((RefundIds == null && other.RefundIds == null) || (RefundIds?.Equals(other.RefundIds) == true)) &&
                ((RiskEvaluation == null && other.RiskEvaluation == null) || (RiskEvaluation?.Equals(other.RiskEvaluation) == true)) &&
                ((BuyerEmailAddress == null && other.BuyerEmailAddress == null) || (BuyerEmailAddress?.Equals(other.BuyerEmailAddress) == true)) &&
                ((BillingAddress == null && other.BillingAddress == null) || (BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((ShippingAddress == null && other.ShippingAddress == null) || (ShippingAddress?.Equals(other.ShippingAddress) == true)) &&
                ((Note == null && other.Note == null) || (Note?.Equals(other.Note) == true)) &&
                ((StatementDescriptionIdentifier == null && other.StatementDescriptionIdentifier == null) || (StatementDescriptionIdentifier?.Equals(other.StatementDescriptionIdentifier) == true)) &&
                ((ReceiptNumber == null && other.ReceiptNumber == null) || (ReceiptNumber?.Equals(other.ReceiptNumber) == true)) &&
                ((ReceiptUrl == null && other.ReceiptUrl == null) || (ReceiptUrl?.Equals(other.ReceiptUrl) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 1131972147;

            if (Id != null)
            {
               hashCode += Id.GetHashCode();
            }

            if (CreatedAt != null)
            {
               hashCode += CreatedAt.GetHashCode();
            }

            if (UpdatedAt != null)
            {
               hashCode += UpdatedAt.GetHashCode();
            }

            if (AmountMoney != null)
            {
               hashCode += AmountMoney.GetHashCode();
            }

            if (TipMoney != null)
            {
               hashCode += TipMoney.GetHashCode();
            }

            if (TotalMoney != null)
            {
               hashCode += TotalMoney.GetHashCode();
            }

            if (AppFeeMoney != null)
            {
               hashCode += AppFeeMoney.GetHashCode();
            }

            if (ProcessingFee != null)
            {
               hashCode += ProcessingFee.GetHashCode();
            }

            if (RefundedMoney != null)
            {
               hashCode += RefundedMoney.GetHashCode();
            }

            if (Status != null)
            {
               hashCode += Status.GetHashCode();
            }

            if (DelayDuration != null)
            {
               hashCode += DelayDuration.GetHashCode();
            }

            if (DelayAction != null)
            {
               hashCode += DelayAction.GetHashCode();
            }

            if (DelayedUntil != null)
            {
               hashCode += DelayedUntil.GetHashCode();
            }

            if (SourceType != null)
            {
               hashCode += SourceType.GetHashCode();
            }

            if (CardDetails != null)
            {
               hashCode += CardDetails.GetHashCode();
            }

            if (LocationId != null)
            {
               hashCode += LocationId.GetHashCode();
            }

            if (OrderId != null)
            {
               hashCode += OrderId.GetHashCode();
            }

            if (ReferenceId != null)
            {
               hashCode += ReferenceId.GetHashCode();
            }

            if (CustomerId != null)
            {
               hashCode += CustomerId.GetHashCode();
            }

            if (EmployeeId != null)
            {
               hashCode += EmployeeId.GetHashCode();
            }

            if (RefundIds != null)
            {
               hashCode += RefundIds.GetHashCode();
            }

            if (RiskEvaluation != null)
            {
               hashCode += RiskEvaluation.GetHashCode();
            }

            if (BuyerEmailAddress != null)
            {
               hashCode += BuyerEmailAddress.GetHashCode();
            }

            if (BillingAddress != null)
            {
               hashCode += BillingAddress.GetHashCode();
            }

            if (ShippingAddress != null)
            {
               hashCode += ShippingAddress.GetHashCode();
            }

            if (Note != null)
            {
               hashCode += Note.GetHashCode();
            }

            if (StatementDescriptionIdentifier != null)
            {
               hashCode += StatementDescriptionIdentifier.GetHashCode();
            }

            if (ReceiptNumber != null)
            {
               hashCode += ReceiptNumber.GetHashCode();
            }

            if (ReceiptUrl != null)
            {
               hashCode += ReceiptUrl.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Id(Id)
                .CreatedAt(CreatedAt)
                .UpdatedAt(UpdatedAt)
                .AmountMoney(AmountMoney)
                .TipMoney(TipMoney)
                .TotalMoney(TotalMoney)
                .AppFeeMoney(AppFeeMoney)
                .ProcessingFee(ProcessingFee)
                .RefundedMoney(RefundedMoney)
                .Status(Status)
                .DelayDuration(DelayDuration)
                .DelayAction(DelayAction)
                .DelayedUntil(DelayedUntil)
                .SourceType(SourceType)
                .CardDetails(CardDetails)
                .LocationId(LocationId)
                .OrderId(OrderId)
                .ReferenceId(ReferenceId)
                .CustomerId(CustomerId)
                .EmployeeId(EmployeeId)
                .RefundIds(RefundIds)
                .RiskEvaluation(RiskEvaluation)
                .BuyerEmailAddress(BuyerEmailAddress)
                .BillingAddress(BillingAddress)
                .ShippingAddress(ShippingAddress)
                .Note(Note)
                .StatementDescriptionIdentifier(StatementDescriptionIdentifier)
                .ReceiptNumber(ReceiptNumber)
                .ReceiptUrl(ReceiptUrl);
            return builder;
        }

        public class Builder
        {
            private string id;
            private string createdAt;
            private string updatedAt;
            private Models.Money amountMoney;
            private Models.Money tipMoney;
            private Models.Money totalMoney;
            private Models.Money appFeeMoney;
            private IList<Models.ProcessingFee> processingFee;
            private Models.Money refundedMoney;
            private string status;
            private string delayDuration;
            private string delayAction;
            private string delayedUntil;
            private string sourceType;
            private Models.CardPaymentDetails cardDetails;
            private string locationId;
            private string orderId;
            private string referenceId;
            private string customerId;
            private string employeeId;
            private IList<string> refundIds;
            private Models.RiskEvaluation riskEvaluation;
            private string buyerEmailAddress;
            private Models.Address billingAddress;
            private Models.Address shippingAddress;
            private string note;
            private string statementDescriptionIdentifier;
            private string receiptNumber;
            private string receiptUrl;



            public Builder Id(string id)
            {
                this.id = id;
                return this;
            }

            public Builder CreatedAt(string createdAt)
            {
                this.createdAt = createdAt;
                return this;
            }

            public Builder UpdatedAt(string updatedAt)
            {
                this.updatedAt = updatedAt;
                return this;
            }

            public Builder AmountMoney(Models.Money amountMoney)
            {
                this.amountMoney = amountMoney;
                return this;
            }

            public Builder TipMoney(Models.Money tipMoney)
            {
                this.tipMoney = tipMoney;
                return this;
            }

            public Builder TotalMoney(Models.Money totalMoney)
            {
                this.totalMoney = totalMoney;
                return this;
            }

            public Builder AppFeeMoney(Models.Money appFeeMoney)
            {
                this.appFeeMoney = appFeeMoney;
                return this;
            }

            public Builder ProcessingFee(IList<Models.ProcessingFee> processingFee)
            {
                this.processingFee = processingFee;
                return this;
            }

            public Builder RefundedMoney(Models.Money refundedMoney)
            {
                this.refundedMoney = refundedMoney;
                return this;
            }

            public Builder Status(string status)
            {
                this.status = status;
                return this;
            }

            public Builder DelayDuration(string delayDuration)
            {
                this.delayDuration = delayDuration;
                return this;
            }

            public Builder DelayAction(string delayAction)
            {
                this.delayAction = delayAction;
                return this;
            }

            public Builder DelayedUntil(string delayedUntil)
            {
                this.delayedUntil = delayedUntil;
                return this;
            }

            public Builder SourceType(string sourceType)
            {
                this.sourceType = sourceType;
                return this;
            }

            public Builder CardDetails(Models.CardPaymentDetails cardDetails)
            {
                this.cardDetails = cardDetails;
                return this;
            }

            public Builder LocationId(string locationId)
            {
                this.locationId = locationId;
                return this;
            }

            public Builder OrderId(string orderId)
            {
                this.orderId = orderId;
                return this;
            }

            public Builder ReferenceId(string referenceId)
            {
                this.referenceId = referenceId;
                return this;
            }

            public Builder CustomerId(string customerId)
            {
                this.customerId = customerId;
                return this;
            }

            public Builder EmployeeId(string employeeId)
            {
                this.employeeId = employeeId;
                return this;
            }

            public Builder RefundIds(IList<string> refundIds)
            {
                this.refundIds = refundIds;
                return this;
            }

            public Builder RiskEvaluation(Models.RiskEvaluation riskEvaluation)
            {
                this.riskEvaluation = riskEvaluation;
                return this;
            }

            public Builder BuyerEmailAddress(string buyerEmailAddress)
            {
                this.buyerEmailAddress = buyerEmailAddress;
                return this;
            }

            public Builder BillingAddress(Models.Address billingAddress)
            {
                this.billingAddress = billingAddress;
                return this;
            }

            public Builder ShippingAddress(Models.Address shippingAddress)
            {
                this.shippingAddress = shippingAddress;
                return this;
            }

            public Builder Note(string note)
            {
                this.note = note;
                return this;
            }

            public Builder StatementDescriptionIdentifier(string statementDescriptionIdentifier)
            {
                this.statementDescriptionIdentifier = statementDescriptionIdentifier;
                return this;
            }

            public Builder ReceiptNumber(string receiptNumber)
            {
                this.receiptNumber = receiptNumber;
                return this;
            }

            public Builder ReceiptUrl(string receiptUrl)
            {
                this.receiptUrl = receiptUrl;
                return this;
            }

            public Payment Build()
            {
                return new Payment(id,
                    createdAt,
                    updatedAt,
                    amountMoney,
                    tipMoney,
                    totalMoney,
                    appFeeMoney,
                    processingFee,
                    refundedMoney,
                    status,
                    delayDuration,
                    delayAction,
                    delayedUntil,
                    sourceType,
                    cardDetails,
                    locationId,
                    orderId,
                    referenceId,
                    customerId,
                    employeeId,
                    refundIds,
                    riskEvaluation,
                    buyerEmailAddress,
                    billingAddress,
                    shippingAddress,
                    note,
                    statementDescriptionIdentifier,
                    receiptNumber,
                    receiptUrl);
            }
        }
    }
}