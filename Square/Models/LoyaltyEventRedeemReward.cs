
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
    public class LoyaltyEventRedeemReward 
    {
        public LoyaltyEventRedeemReward(string loyaltyProgramId,
            string rewardId = null,
            string orderId = null)
        {
            LoyaltyProgramId = loyaltyProgramId;
            RewardId = rewardId;
            OrderId = orderId;
        }

        /// <summary>
        /// The ID of the [loyalty program](#type-LoyaltyProgram).
        /// </summary>
        [JsonProperty("loyalty_program_id")]
        public string LoyaltyProgramId { get; }

        /// <summary>
        /// The ID of the redeemed [loyalty reward](#type-LoyaltyReward).
        /// This field is returned only if the event source is `LOYALTY_API`.
        /// </summary>
        [JsonProperty("reward_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RewardId { get; }

        /// <summary>
        /// The ID of the [order](#type-Order) that redeemed the reward.
        /// This field is returned only if the Orders API is used to process orders.
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LoyaltyEventRedeemReward : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"LoyaltyProgramId = {(LoyaltyProgramId == null ? "null" : LoyaltyProgramId == string.Empty ? "" : LoyaltyProgramId)}");
            toStringOutput.Add($"RewardId = {(RewardId == null ? "null" : RewardId == string.Empty ? "" : RewardId)}");
            toStringOutput.Add($"OrderId = {(OrderId == null ? "null" : OrderId == string.Empty ? "" : OrderId)}");
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

            return obj is LoyaltyEventRedeemReward other &&
                ((LoyaltyProgramId == null && other.LoyaltyProgramId == null) || (LoyaltyProgramId?.Equals(other.LoyaltyProgramId) == true)) &&
                ((RewardId == null && other.RewardId == null) || (RewardId?.Equals(other.RewardId) == true)) &&
                ((OrderId == null && other.OrderId == null) || (OrderId?.Equals(other.OrderId) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 2041086926;

            if (LoyaltyProgramId != null)
            {
               hashCode += LoyaltyProgramId.GetHashCode();
            }

            if (RewardId != null)
            {
               hashCode += RewardId.GetHashCode();
            }

            if (OrderId != null)
            {
               hashCode += OrderId.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder(LoyaltyProgramId)
                .RewardId(RewardId)
                .OrderId(OrderId);
            return builder;
        }

        public class Builder
        {
            private string loyaltyProgramId;
            private string rewardId;
            private string orderId;

            public Builder(string loyaltyProgramId)
            {
                this.loyaltyProgramId = loyaltyProgramId;
            }

            public Builder LoyaltyProgramId(string loyaltyProgramId)
            {
                this.loyaltyProgramId = loyaltyProgramId;
                return this;
            }

            public Builder RewardId(string rewardId)
            {
                this.rewardId = rewardId;
                return this;
            }

            public Builder OrderId(string orderId)
            {
                this.orderId = orderId;
                return this;
            }

            public LoyaltyEventRedeemReward Build()
            {
                return new LoyaltyEventRedeemReward(loyaltyProgramId,
                    rewardId,
                    orderId);
            }
        }
    }
}