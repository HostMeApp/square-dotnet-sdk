
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
    public class CreateLoyaltyRewardRequest 
    {
        public CreateLoyaltyRewardRequest(Models.LoyaltyReward reward,
            string idempotencyKey)
        {
            Reward = reward;
            IdempotencyKey = idempotencyKey;
        }

        /// <summary>
        /// Getter for reward
        /// </summary>
        [JsonProperty("reward")]
        public Models.LoyaltyReward Reward { get; }

        /// <summary>
        /// A unique string that identifies this `CreateLoyaltyReward` request. 
        /// Keys can be any valid string, but must be unique for every request.
        /// </summary>
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateLoyaltyRewardRequest : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Reward = {(Reward == null ? "null" : Reward.ToString())}");
            toStringOutput.Add($"IdempotencyKey = {(IdempotencyKey == null ? "null" : IdempotencyKey == string.Empty ? "" : IdempotencyKey)}");
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

            return obj is CreateLoyaltyRewardRequest other &&
                ((Reward == null && other.Reward == null) || (Reward?.Equals(other.Reward) == true)) &&
                ((IdempotencyKey == null && other.IdempotencyKey == null) || (IdempotencyKey?.Equals(other.IdempotencyKey) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = -767337134;

            if (Reward != null)
            {
               hashCode += Reward.GetHashCode();
            }

            if (IdempotencyKey != null)
            {
               hashCode += IdempotencyKey.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder(Reward,
                IdempotencyKey);
            return builder;
        }

        public class Builder
        {
            private Models.LoyaltyReward reward;
            private string idempotencyKey;

            public Builder(Models.LoyaltyReward reward,
                string idempotencyKey)
            {
                this.reward = reward;
                this.idempotencyKey = idempotencyKey;
            }

            public Builder Reward(Models.LoyaltyReward reward)
            {
                this.reward = reward;
                return this;
            }

            public Builder IdempotencyKey(string idempotencyKey)
            {
                this.idempotencyKey = idempotencyKey;
                return this;
            }

            public CreateLoyaltyRewardRequest Build()
            {
                return new CreateLoyaltyRewardRequest(reward,
                    idempotencyKey);
            }
        }
    }
}