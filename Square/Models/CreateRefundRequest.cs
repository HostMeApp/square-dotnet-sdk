
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
    public class CreateRefundRequest 
    {
        public CreateRefundRequest(string idempotencyKey,
            string paymentId,
            Models.Money amountMoney,
            string reason = null)
        {
            IdempotencyKey = idempotencyKey;
            PaymentId = paymentId;
            Reason = reason;
            AmountMoney = amountMoney;
        }

        /// <summary>
        /// A value you specify that uniquely identifies this
        /// refund among refunds you've created for the tender.
        /// If you're unsure whether a particular refund succeeded,
        /// you can reattempt it with the same idempotency key without
        /// worrying about duplicating the refund.
        /// See [Idempotency keys](#idempotencykeys) for more information.
        /// </summary>
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; }

        /// <summary>
        /// The ID of the tender to refund.
        /// A [`Transaction`](#type-transaction) has one or more `tenders` (i.e., methods
        /// of payment) associated with it, and you refund each tender separately with
        /// the Connect API.
        /// </summary>
        [JsonProperty("payment_id")]
        public string PaymentId { get; }

        /// <summary>
        /// A description of the reason for the refund.
        /// Default value: `Refund via API`
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; }

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

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateRefundRequest : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"IdempotencyKey = {(IdempotencyKey == null ? "null" : IdempotencyKey == string.Empty ? "" : IdempotencyKey)}");
            toStringOutput.Add($"PaymentId = {(PaymentId == null ? "null" : PaymentId == string.Empty ? "" : PaymentId)}");
            toStringOutput.Add($"Reason = {(Reason == null ? "null" : Reason == string.Empty ? "" : Reason)}");
            toStringOutput.Add($"AmountMoney = {(AmountMoney == null ? "null" : AmountMoney.ToString())}");
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

            return obj is CreateRefundRequest other &&
                ((IdempotencyKey == null && other.IdempotencyKey == null) || (IdempotencyKey?.Equals(other.IdempotencyKey) == true)) &&
                ((PaymentId == null && other.PaymentId == null) || (PaymentId?.Equals(other.PaymentId) == true)) &&
                ((Reason == null && other.Reason == null) || (Reason?.Equals(other.Reason) == true)) &&
                ((AmountMoney == null && other.AmountMoney == null) || (AmountMoney?.Equals(other.AmountMoney) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 50633946;

            if (IdempotencyKey != null)
            {
               hashCode += IdempotencyKey.GetHashCode();
            }

            if (PaymentId != null)
            {
               hashCode += PaymentId.GetHashCode();
            }

            if (Reason != null)
            {
               hashCode += Reason.GetHashCode();
            }

            if (AmountMoney != null)
            {
               hashCode += AmountMoney.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder(IdempotencyKey,
                PaymentId,
                AmountMoney)
                .Reason(Reason);
            return builder;
        }

        public class Builder
        {
            private string idempotencyKey;
            private string paymentId;
            private Models.Money amountMoney;
            private string reason;

            public Builder(string idempotencyKey,
                string paymentId,
                Models.Money amountMoney)
            {
                this.idempotencyKey = idempotencyKey;
                this.paymentId = paymentId;
                this.amountMoney = amountMoney;
            }

            public Builder IdempotencyKey(string idempotencyKey)
            {
                this.idempotencyKey = idempotencyKey;
                return this;
            }

            public Builder PaymentId(string paymentId)
            {
                this.paymentId = paymentId;
                return this;
            }

            public Builder AmountMoney(Models.Money amountMoney)
            {
                this.amountMoney = amountMoney;
                return this;
            }

            public Builder Reason(string reason)
            {
                this.reason = reason;
                return this;
            }

            public CreateRefundRequest Build()
            {
                return new CreateRefundRequest(idempotencyKey,
                    paymentId,
                    amountMoney,
                    reason);
            }
        }
    }
}