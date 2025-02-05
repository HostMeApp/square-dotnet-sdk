
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
    public class RefundPaymentRequest 
    {
        public RefundPaymentRequest(string idempotencyKey,
            Models.Money amountMoney,
            string paymentId,
            Models.Money appFeeMoney = null,
            string reason = null)
        {
            IdempotencyKey = idempotencyKey;
            AmountMoney = amountMoney;
            AppFeeMoney = appFeeMoney;
            PaymentId = paymentId;
            Reason = reason;
        }

        /// <summary>
        /// A unique string that identifies this `RefundPayment` request. The key can be any valid string
        /// but must be unique for every `RefundPayment` request.
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
        [JsonProperty("app_fee_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money AppFeeMoney { get; }

        /// <summary>
        /// The unique ID of the payment being refunded.
        /// </summary>
        [JsonProperty("payment_id")]
        public string PaymentId { get; }

        /// <summary>
        /// A description of the reason for the refund.
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RefundPaymentRequest : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"IdempotencyKey = {(IdempotencyKey == null ? "null" : IdempotencyKey == string.Empty ? "" : IdempotencyKey)}");
            toStringOutput.Add($"AmountMoney = {(AmountMoney == null ? "null" : AmountMoney.ToString())}");
            toStringOutput.Add($"AppFeeMoney = {(AppFeeMoney == null ? "null" : AppFeeMoney.ToString())}");
            toStringOutput.Add($"PaymentId = {(PaymentId == null ? "null" : PaymentId == string.Empty ? "" : PaymentId)}");
            toStringOutput.Add($"Reason = {(Reason == null ? "null" : Reason == string.Empty ? "" : Reason)}");
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

            return obj is RefundPaymentRequest other &&
                ((IdempotencyKey == null && other.IdempotencyKey == null) || (IdempotencyKey?.Equals(other.IdempotencyKey) == true)) &&
                ((AmountMoney == null && other.AmountMoney == null) || (AmountMoney?.Equals(other.AmountMoney) == true)) &&
                ((AppFeeMoney == null && other.AppFeeMoney == null) || (AppFeeMoney?.Equals(other.AppFeeMoney) == true)) &&
                ((PaymentId == null && other.PaymentId == null) || (PaymentId?.Equals(other.PaymentId) == true)) &&
                ((Reason == null && other.Reason == null) || (Reason?.Equals(other.Reason) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = -682129491;

            if (IdempotencyKey != null)
            {
               hashCode += IdempotencyKey.GetHashCode();
            }

            if (AmountMoney != null)
            {
               hashCode += AmountMoney.GetHashCode();
            }

            if (AppFeeMoney != null)
            {
               hashCode += AppFeeMoney.GetHashCode();
            }

            if (PaymentId != null)
            {
               hashCode += PaymentId.GetHashCode();
            }

            if (Reason != null)
            {
               hashCode += Reason.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder(IdempotencyKey,
                AmountMoney,
                PaymentId)
                .AppFeeMoney(AppFeeMoney)
                .Reason(Reason);
            return builder;
        }

        public class Builder
        {
            private string idempotencyKey;
            private Models.Money amountMoney;
            private string paymentId;
            private Models.Money appFeeMoney;
            private string reason;

            public Builder(string idempotencyKey,
                Models.Money amountMoney,
                string paymentId)
            {
                this.idempotencyKey = idempotencyKey;
                this.amountMoney = amountMoney;
                this.paymentId = paymentId;
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

            public Builder PaymentId(string paymentId)
            {
                this.paymentId = paymentId;
                return this;
            }

            public Builder AppFeeMoney(Models.Money appFeeMoney)
            {
                this.appFeeMoney = appFeeMoney;
                return this;
            }

            public Builder Reason(string reason)
            {
                this.reason = reason;
                return this;
            }

            public RefundPaymentRequest Build()
            {
                return new RefundPaymentRequest(idempotencyKey,
                    amountMoney,
                    paymentId,
                    appFeeMoney,
                    reason);
            }
        }
    }
}