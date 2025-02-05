
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
    public class CreatePaymentRequest 
    {
        public CreatePaymentRequest(string sourceId,
            string idempotencyKey,
            Models.Money amountMoney,
            Models.Money tipMoney = null,
            Models.Money appFeeMoney = null,
            string delayDuration = null,
            bool? autocomplete = null,
            string orderId = null,
            string customerId = null,
            string locationId = null,
            string referenceId = null,
            string verificationToken = null,
            bool? acceptPartialAuthorization = null,
            string buyerEmailAddress = null,
            Models.Address billingAddress = null,
            Models.Address shippingAddress = null,
            string note = null,
            string statementDescriptionIdentifier = null)
        {
            SourceId = sourceId;
            IdempotencyKey = idempotencyKey;
            AmountMoney = amountMoney;
            TipMoney = tipMoney;
            AppFeeMoney = appFeeMoney;
            DelayDuration = delayDuration;
            Autocomplete = autocomplete;
            OrderId = orderId;
            CustomerId = customerId;
            LocationId = locationId;
            ReferenceId = referenceId;
            VerificationToken = verificationToken;
            AcceptPartialAuthorization = acceptPartialAuthorization;
            BuyerEmailAddress = buyerEmailAddress;
            BillingAddress = billingAddress;
            ShippingAddress = shippingAddress;
            Note = note;
            StatementDescriptionIdentifier = statementDescriptionIdentifier;
        }

        /// <summary>
        /// The ID for the source of funds for this payment. This can be a nonce
        /// generated by the Square payment form or a card on file made with the Customers API.
        /// </summary>
        [JsonProperty("source_id")]
        public string SourceId { get; }

        /// <summary>
        /// A unique string that identifies this `CreatePayment` request. Keys can be any valid string
        /// but must be unique for every `CreatePayment` request.
        /// Max: 45 characters
        /// Note: The number of allowed characters might be less than the stated maximum, if multi-byte
        /// characters are used.
        /// For more information, see [Idempotency](https://developer.squareup.com/docs/working-with-apis/idempotency).
        /// </summary>
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("amount_money")]
        public Models.Money AmountMoney { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("tip_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money TipMoney { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("app_fee_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money AppFeeMoney { get; }

        /// <summary>
        /// The duration of time after the payment's creation when Square automatically cancels the
        /// payment. This automatic cancellation applies only to payments that do not reach a terminal state
        /// (COMPLETED, CANCELED, or FAILED) before the `delay_duration` time period.
        /// This parameter should be specified as a time duration, in RFC 3339 format, with a minimum value
        /// of 1 minute.
        /// Note: This feature is only supported for card payments. This parameter can only be set for a delayed
        /// capture payment (`autocomplete=false`).
        /// Default:
        /// - Card-present payments: "PT36H" (36 hours) from the creation time.
        /// - Card-not-present payments: "P7D" (7 days) from the creation time.
        /// </summary>
        [JsonProperty("delay_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string DelayDuration { get; }

        /// <summary>
        /// If set to `true`, this payment will be completed when possible. If
        /// set to `false`, this payment is held in an approved state until either
        /// explicitly completed (captured) or canceled (voided). For more information, see
        /// [Delayed capture](https://developer.squareup.com/docs/payments-api/take-payments#delayed-payments).
        /// Default: true
        /// </summary>
        [JsonProperty("autocomplete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autocomplete { get; }

        /// <summary>
        /// Associates a previously created order with this payment.
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; }

        /// <summary>
        /// The [Customer](#type-customer) ID of the customer associated with the payment.
        /// This is required if the `source_id` refers to a card on file created using the Customers API.
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; }

        /// <summary>
        /// The location ID to associate with the payment. If not specified, the default location is
        /// used.
        /// </summary>
        [JsonProperty("location_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationId { get; }

        /// <summary>
        /// A user-defined ID to associate with the payment.
        /// You can use this field to associate the payment to an entity in an external system 
        /// (for example, you might specify an order ID that is generated by a third-party shopping cart).
        /// Limit 40 characters.
        /// </summary>
        [JsonProperty("reference_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceId { get; }

        /// <summary>
        /// An identifying token generated by `SqPaymentForm.verifyBuyer()`.
        /// Verification tokens encapsulate customer device information and 3-D Secure
        /// challenge results to indicate that Square has verified the buyer identity.
        /// For more information, see [SCA Overview](https://developer.squareup.com/docs/sca-overview).
        /// </summary>
        [JsonProperty("verification_token", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationToken { get; }

        /// <summary>
        /// If set to `true` and charging a Square Gift Card, a payment might be returned with
        /// `amount_money` equal to less than what was requested. For example, a request for $20 when charging
        /// a Square Gift Card with a balance of $5 results in an APPROVED payment of $5. You might choose
        /// to prompt the buyer for an additional payment to cover the remainder or cancel the Gift Card
        /// payment. This field cannot be `true` when `autocomplete = true`.
        /// For more information, see
        /// [Partial amount with Square Gift Cards](https://developer.squareup.com/docs/payments-api/take-payments#partial-payment-gift-card).
        /// Default: false
        /// </summary>
        [JsonProperty("accept_partial_authorization", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AcceptPartialAuthorization { get; }

        /// <summary>
        /// The buyer's email address.
        /// </summary>
        [JsonProperty("buyer_email_address", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerEmailAddress { get; }

        /// <summary>
        /// Represents a physical address.
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address BillingAddress { get; }

        /// <summary>
        /// Represents a physical address.
        /// </summary>
        [JsonProperty("shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address ShippingAddress { get; }

        /// <summary>
        /// An optional note to be entered by the developer when creating a payment.
        /// Limit 500 characters.
        /// </summary>
        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; }

        /// <summary>
        /// Optional additional payment information to include on the customer's card statement
        /// as part of the statement description. This can be, for example, an invoice number, ticket number,
        /// or short description that uniquely identifies the purchase.
        /// Note that the `statement_description_identifier` might get truncated on the statement description
        /// to fit the required information including the Square identifier (SQ *) and name of the
        /// seller taking the payment.
        /// </summary>
        [JsonProperty("statement_description_identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string StatementDescriptionIdentifier { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreatePaymentRequest : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SourceId = {(SourceId == null ? "null" : SourceId == string.Empty ? "" : SourceId)}");
            toStringOutput.Add($"IdempotencyKey = {(IdempotencyKey == null ? "null" : IdempotencyKey == string.Empty ? "" : IdempotencyKey)}");
            toStringOutput.Add($"AmountMoney = {(AmountMoney == null ? "null" : AmountMoney.ToString())}");
            toStringOutput.Add($"TipMoney = {(TipMoney == null ? "null" : TipMoney.ToString())}");
            toStringOutput.Add($"AppFeeMoney = {(AppFeeMoney == null ? "null" : AppFeeMoney.ToString())}");
            toStringOutput.Add($"DelayDuration = {(DelayDuration == null ? "null" : DelayDuration == string.Empty ? "" : DelayDuration)}");
            toStringOutput.Add($"Autocomplete = {(Autocomplete == null ? "null" : Autocomplete.ToString())}");
            toStringOutput.Add($"OrderId = {(OrderId == null ? "null" : OrderId == string.Empty ? "" : OrderId)}");
            toStringOutput.Add($"CustomerId = {(CustomerId == null ? "null" : CustomerId == string.Empty ? "" : CustomerId)}");
            toStringOutput.Add($"LocationId = {(LocationId == null ? "null" : LocationId == string.Empty ? "" : LocationId)}");
            toStringOutput.Add($"ReferenceId = {(ReferenceId == null ? "null" : ReferenceId == string.Empty ? "" : ReferenceId)}");
            toStringOutput.Add($"VerificationToken = {(VerificationToken == null ? "null" : VerificationToken == string.Empty ? "" : VerificationToken)}");
            toStringOutput.Add($"AcceptPartialAuthorization = {(AcceptPartialAuthorization == null ? "null" : AcceptPartialAuthorization.ToString())}");
            toStringOutput.Add($"BuyerEmailAddress = {(BuyerEmailAddress == null ? "null" : BuyerEmailAddress == string.Empty ? "" : BuyerEmailAddress)}");
            toStringOutput.Add($"BillingAddress = {(BillingAddress == null ? "null" : BillingAddress.ToString())}");
            toStringOutput.Add($"ShippingAddress = {(ShippingAddress == null ? "null" : ShippingAddress.ToString())}");
            toStringOutput.Add($"Note = {(Note == null ? "null" : Note == string.Empty ? "" : Note)}");
            toStringOutput.Add($"StatementDescriptionIdentifier = {(StatementDescriptionIdentifier == null ? "null" : StatementDescriptionIdentifier == string.Empty ? "" : StatementDescriptionIdentifier)}");
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

            return obj is CreatePaymentRequest other &&
                ((SourceId == null && other.SourceId == null) || (SourceId?.Equals(other.SourceId) == true)) &&
                ((IdempotencyKey == null && other.IdempotencyKey == null) || (IdempotencyKey?.Equals(other.IdempotencyKey) == true)) &&
                ((AmountMoney == null && other.AmountMoney == null) || (AmountMoney?.Equals(other.AmountMoney) == true)) &&
                ((TipMoney == null && other.TipMoney == null) || (TipMoney?.Equals(other.TipMoney) == true)) &&
                ((AppFeeMoney == null && other.AppFeeMoney == null) || (AppFeeMoney?.Equals(other.AppFeeMoney) == true)) &&
                ((DelayDuration == null && other.DelayDuration == null) || (DelayDuration?.Equals(other.DelayDuration) == true)) &&
                ((Autocomplete == null && other.Autocomplete == null) || (Autocomplete?.Equals(other.Autocomplete) == true)) &&
                ((OrderId == null && other.OrderId == null) || (OrderId?.Equals(other.OrderId) == true)) &&
                ((CustomerId == null && other.CustomerId == null) || (CustomerId?.Equals(other.CustomerId) == true)) &&
                ((LocationId == null && other.LocationId == null) || (LocationId?.Equals(other.LocationId) == true)) &&
                ((ReferenceId == null && other.ReferenceId == null) || (ReferenceId?.Equals(other.ReferenceId) == true)) &&
                ((VerificationToken == null && other.VerificationToken == null) || (VerificationToken?.Equals(other.VerificationToken) == true)) &&
                ((AcceptPartialAuthorization == null && other.AcceptPartialAuthorization == null) || (AcceptPartialAuthorization?.Equals(other.AcceptPartialAuthorization) == true)) &&
                ((BuyerEmailAddress == null && other.BuyerEmailAddress == null) || (BuyerEmailAddress?.Equals(other.BuyerEmailAddress) == true)) &&
                ((BillingAddress == null && other.BillingAddress == null) || (BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((ShippingAddress == null && other.ShippingAddress == null) || (ShippingAddress?.Equals(other.ShippingAddress) == true)) &&
                ((Note == null && other.Note == null) || (Note?.Equals(other.Note) == true)) &&
                ((StatementDescriptionIdentifier == null && other.StatementDescriptionIdentifier == null) || (StatementDescriptionIdentifier?.Equals(other.StatementDescriptionIdentifier) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = -519761043;

            if (SourceId != null)
            {
               hashCode += SourceId.GetHashCode();
            }

            if (IdempotencyKey != null)
            {
               hashCode += IdempotencyKey.GetHashCode();
            }

            if (AmountMoney != null)
            {
               hashCode += AmountMoney.GetHashCode();
            }

            if (TipMoney != null)
            {
               hashCode += TipMoney.GetHashCode();
            }

            if (AppFeeMoney != null)
            {
               hashCode += AppFeeMoney.GetHashCode();
            }

            if (DelayDuration != null)
            {
               hashCode += DelayDuration.GetHashCode();
            }

            if (Autocomplete != null)
            {
               hashCode += Autocomplete.GetHashCode();
            }

            if (OrderId != null)
            {
               hashCode += OrderId.GetHashCode();
            }

            if (CustomerId != null)
            {
               hashCode += CustomerId.GetHashCode();
            }

            if (LocationId != null)
            {
               hashCode += LocationId.GetHashCode();
            }

            if (ReferenceId != null)
            {
               hashCode += ReferenceId.GetHashCode();
            }

            if (VerificationToken != null)
            {
               hashCode += VerificationToken.GetHashCode();
            }

            if (AcceptPartialAuthorization != null)
            {
               hashCode += AcceptPartialAuthorization.GetHashCode();
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

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder(SourceId,
                IdempotencyKey,
                AmountMoney)
                .TipMoney(TipMoney)
                .AppFeeMoney(AppFeeMoney)
                .DelayDuration(DelayDuration)
                .Autocomplete(Autocomplete)
                .OrderId(OrderId)
                .CustomerId(CustomerId)
                .LocationId(LocationId)
                .ReferenceId(ReferenceId)
                .VerificationToken(VerificationToken)
                .AcceptPartialAuthorization(AcceptPartialAuthorization)
                .BuyerEmailAddress(BuyerEmailAddress)
                .BillingAddress(BillingAddress)
                .ShippingAddress(ShippingAddress)
                .Note(Note)
                .StatementDescriptionIdentifier(StatementDescriptionIdentifier);
            return builder;
        }

        public class Builder
        {
            private string sourceId;
            private string idempotencyKey;
            private Models.Money amountMoney;
            private Models.Money tipMoney;
            private Models.Money appFeeMoney;
            private string delayDuration;
            private bool? autocomplete;
            private string orderId;
            private string customerId;
            private string locationId;
            private string referenceId;
            private string verificationToken;
            private bool? acceptPartialAuthorization;
            private string buyerEmailAddress;
            private Models.Address billingAddress;
            private Models.Address shippingAddress;
            private string note;
            private string statementDescriptionIdentifier;

            public Builder(string sourceId,
                string idempotencyKey,
                Models.Money amountMoney)
            {
                this.sourceId = sourceId;
                this.idempotencyKey = idempotencyKey;
                this.amountMoney = amountMoney;
            }

            public Builder SourceId(string sourceId)
            {
                this.sourceId = sourceId;
                return this;
            }

            public Builder IdempotencyKey(string idempotencyKey)
            {
                this.idempotencyKey = idempotencyKey;
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

            public Builder AppFeeMoney(Models.Money appFeeMoney)
            {
                this.appFeeMoney = appFeeMoney;
                return this;
            }

            public Builder DelayDuration(string delayDuration)
            {
                this.delayDuration = delayDuration;
                return this;
            }

            public Builder Autocomplete(bool? autocomplete)
            {
                this.autocomplete = autocomplete;
                return this;
            }

            public Builder OrderId(string orderId)
            {
                this.orderId = orderId;
                return this;
            }

            public Builder CustomerId(string customerId)
            {
                this.customerId = customerId;
                return this;
            }

            public Builder LocationId(string locationId)
            {
                this.locationId = locationId;
                return this;
            }

            public Builder ReferenceId(string referenceId)
            {
                this.referenceId = referenceId;
                return this;
            }

            public Builder VerificationToken(string verificationToken)
            {
                this.verificationToken = verificationToken;
                return this;
            }

            public Builder AcceptPartialAuthorization(bool? acceptPartialAuthorization)
            {
                this.acceptPartialAuthorization = acceptPartialAuthorization;
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

            public CreatePaymentRequest Build()
            {
                return new CreatePaymentRequest(sourceId,
                    idempotencyKey,
                    amountMoney,
                    tipMoney,
                    appFeeMoney,
                    delayDuration,
                    autocomplete,
                    orderId,
                    customerId,
                    locationId,
                    referenceId,
                    verificationToken,
                    acceptPartialAuthorization,
                    buyerEmailAddress,
                    billingAddress,
                    shippingAddress,
                    note,
                    statementDescriptionIdentifier);
            }
        }
    }
}