
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
    public class LoyaltyProgram 
    {
        public LoyaltyProgram(string id,
            string status,
            IList<Models.LoyaltyProgramRewardTier> rewardTiers,
            Models.LoyaltyProgramTerminology terminology,
            IList<string> locationIds,
            string createdAt,
            string updatedAt,
            IList<Models.LoyaltyProgramAccrualRule> accrualRules,
            Models.LoyaltyProgramExpirationPolicy expirationPolicy = null)
        {
            Id = id;
            Status = status;
            RewardTiers = rewardTiers;
            ExpirationPolicy = expirationPolicy;
            Terminology = terminology;
            LocationIds = locationIds;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            AccrualRules = accrualRules;
        }

        /// <summary>
        /// The Square-assigned ID of the loyalty program. Updates to 
        /// the loyalty program do not modify the identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; }

        /// <summary>
        /// Indicates whether the program is currently active.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; }

        /// <summary>
        /// The list of rewards for buyers, sorted by ascending points.
        /// </summary>
        [JsonProperty("reward_tiers")]
        public IList<Models.LoyaltyProgramRewardTier> RewardTiers { get; }

        /// <summary>
        /// Describes when the loyalty program expires.
        /// </summary>
        [JsonProperty("expiration_policy", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LoyaltyProgramExpirationPolicy ExpirationPolicy { get; }

        /// <summary>
        /// Getter for terminology
        /// </summary>
        [JsonProperty("terminology")]
        public Models.LoyaltyProgramTerminology Terminology { get; }

        /// <summary>
        /// The [locations](#type-Location) at which the program is active.
        /// </summary>
        [JsonProperty("location_ids")]
        public IList<string> LocationIds { get; }

        /// <summary>
        /// The timestamp when the program was created, in RFC 3339 format.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; }

        /// <summary>
        /// The timestamp when the reward was last updated, in RFC 3339 format.
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; }

        /// <summary>
        /// Defines how buyers can earn loyalty points.
        /// </summary>
        [JsonProperty("accrual_rules")]
        public IList<Models.LoyaltyProgramAccrualRule> AccrualRules { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LoyaltyProgram : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(Id == null ? "null" : Id == string.Empty ? "" : Id)}");
            toStringOutput.Add($"Status = {(Status == null ? "null" : Status.ToString())}");
            toStringOutput.Add($"RewardTiers = {(RewardTiers == null ? "null" : $"[{ string.Join(", ", RewardTiers)} ]")}");
            toStringOutput.Add($"ExpirationPolicy = {(ExpirationPolicy == null ? "null" : ExpirationPolicy.ToString())}");
            toStringOutput.Add($"Terminology = {(Terminology == null ? "null" : Terminology.ToString())}");
            toStringOutput.Add($"LocationIds = {(LocationIds == null ? "null" : $"[{ string.Join(", ", LocationIds)} ]")}");
            toStringOutput.Add($"CreatedAt = {(CreatedAt == null ? "null" : CreatedAt == string.Empty ? "" : CreatedAt)}");
            toStringOutput.Add($"UpdatedAt = {(UpdatedAt == null ? "null" : UpdatedAt == string.Empty ? "" : UpdatedAt)}");
            toStringOutput.Add($"AccrualRules = {(AccrualRules == null ? "null" : $"[{ string.Join(", ", AccrualRules)} ]")}");
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

            return obj is LoyaltyProgram other &&
                ((Id == null && other.Id == null) || (Id?.Equals(other.Id) == true)) &&
                ((Status == null && other.Status == null) || (Status?.Equals(other.Status) == true)) &&
                ((RewardTiers == null && other.RewardTiers == null) || (RewardTiers?.Equals(other.RewardTiers) == true)) &&
                ((ExpirationPolicy == null && other.ExpirationPolicy == null) || (ExpirationPolicy?.Equals(other.ExpirationPolicy) == true)) &&
                ((Terminology == null && other.Terminology == null) || (Terminology?.Equals(other.Terminology) == true)) &&
                ((LocationIds == null && other.LocationIds == null) || (LocationIds?.Equals(other.LocationIds) == true)) &&
                ((CreatedAt == null && other.CreatedAt == null) || (CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((UpdatedAt == null && other.UpdatedAt == null) || (UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((AccrualRules == null && other.AccrualRules == null) || (AccrualRules?.Equals(other.AccrualRules) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 2031047851;

            if (Id != null)
            {
               hashCode += Id.GetHashCode();
            }

            if (Status != null)
            {
               hashCode += Status.GetHashCode();
            }

            if (RewardTiers != null)
            {
               hashCode += RewardTiers.GetHashCode();
            }

            if (ExpirationPolicy != null)
            {
               hashCode += ExpirationPolicy.GetHashCode();
            }

            if (Terminology != null)
            {
               hashCode += Terminology.GetHashCode();
            }

            if (LocationIds != null)
            {
               hashCode += LocationIds.GetHashCode();
            }

            if (CreatedAt != null)
            {
               hashCode += CreatedAt.GetHashCode();
            }

            if (UpdatedAt != null)
            {
               hashCode += UpdatedAt.GetHashCode();
            }

            if (AccrualRules != null)
            {
               hashCode += AccrualRules.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder(Id,
                Status,
                RewardTiers,
                Terminology,
                LocationIds,
                CreatedAt,
                UpdatedAt,
                AccrualRules)
                .ExpirationPolicy(ExpirationPolicy);
            return builder;
        }

        public class Builder
        {
            private string id;
            private string status;
            private IList<Models.LoyaltyProgramRewardTier> rewardTiers;
            private Models.LoyaltyProgramTerminology terminology;
            private IList<string> locationIds;
            private string createdAt;
            private string updatedAt;
            private IList<Models.LoyaltyProgramAccrualRule> accrualRules;
            private Models.LoyaltyProgramExpirationPolicy expirationPolicy;

            public Builder(string id,
                string status,
                IList<Models.LoyaltyProgramRewardTier> rewardTiers,
                Models.LoyaltyProgramTerminology terminology,
                IList<string> locationIds,
                string createdAt,
                string updatedAt,
                IList<Models.LoyaltyProgramAccrualRule> accrualRules)
            {
                this.id = id;
                this.status = status;
                this.rewardTiers = rewardTiers;
                this.terminology = terminology;
                this.locationIds = locationIds;
                this.createdAt = createdAt;
                this.updatedAt = updatedAt;
                this.accrualRules = accrualRules;
            }

            public Builder Id(string id)
            {
                this.id = id;
                return this;
            }

            public Builder Status(string status)
            {
                this.status = status;
                return this;
            }

            public Builder RewardTiers(IList<Models.LoyaltyProgramRewardTier> rewardTiers)
            {
                this.rewardTiers = rewardTiers;
                return this;
            }

            public Builder Terminology(Models.LoyaltyProgramTerminology terminology)
            {
                this.terminology = terminology;
                return this;
            }

            public Builder LocationIds(IList<string> locationIds)
            {
                this.locationIds = locationIds;
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

            public Builder AccrualRules(IList<Models.LoyaltyProgramAccrualRule> accrualRules)
            {
                this.accrualRules = accrualRules;
                return this;
            }

            public Builder ExpirationPolicy(Models.LoyaltyProgramExpirationPolicy expirationPolicy)
            {
                this.expirationPolicy = expirationPolicy;
                return this;
            }

            public LoyaltyProgram Build()
            {
                return new LoyaltyProgram(id,
                    status,
                    rewardTiers,
                    terminology,
                    locationIds,
                    createdAt,
                    updatedAt,
                    accrualRules,
                    expirationPolicy);
            }
        }
    }
}