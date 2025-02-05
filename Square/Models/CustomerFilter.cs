
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
    public class CustomerFilter 
    {
        public CustomerFilter(Models.CustomerCreationSourceFilter creationSource = null,
            Models.TimeRange createdAt = null,
            Models.TimeRange updatedAt = null,
            Models.CustomerTextFilter emailAddress = null,
            Models.CustomerTextFilter phoneNumber = null,
            Models.CustomerTextFilter referenceId = null,
            Models.FilterValue groupIds = null)
        {
            CreationSource = creationSource;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            ReferenceId = referenceId;
            GroupIds = groupIds;
        }

        /// <summary>
        /// Creation source filter.
        /// If one or more creation sources are set, customer profiles are included in,
        /// or excluded from, the result if they match at least one of the filter
        /// criteria.
        /// </summary>
        [JsonProperty("creation_source", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomerCreationSourceFilter CreationSource { get; }

        /// <summary>
        /// Represents a generic time range. The start and end values are
        /// represented in RFC 3339 format. Time ranges are customized to be
        /// inclusive or exclusive based on the needs of a particular endpoint.
        /// Refer to the relevant endpoint-specific documentation to determine
        /// how time ranges are handled.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TimeRange CreatedAt { get; }

        /// <summary>
        /// Represents a generic time range. The start and end values are
        /// represented in RFC 3339 format. Time ranges are customized to be
        /// inclusive or exclusive based on the needs of a particular endpoint.
        /// Refer to the relevant endpoint-specific documentation to determine
        /// how time ranges are handled.
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TimeRange UpdatedAt { get; }

        /// <summary>
        /// A filter to select customers based on exact or fuzzy matching of
        /// customer attributes against a specified query. Depending on customer attributes, 
        /// the filter can be case sensitive. This filter can be either exact or fuzzy. It cannot be both.
        /// </summary>
        [JsonProperty("email_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomerTextFilter EmailAddress { get; }

        /// <summary>
        /// A filter to select customers based on exact or fuzzy matching of
        /// customer attributes against a specified query. Depending on customer attributes, 
        /// the filter can be case sensitive. This filter can be either exact or fuzzy. It cannot be both.
        /// </summary>
        [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomerTextFilter PhoneNumber { get; }

        /// <summary>
        /// A filter to select customers based on exact or fuzzy matching of
        /// customer attributes against a specified query. Depending on customer attributes, 
        /// the filter can be case sensitive. This filter can be either exact or fuzzy. It cannot be both.
        /// </summary>
        [JsonProperty("reference_id", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomerTextFilter ReferenceId { get; }

        /// <summary>
        /// A filter to select resources based on an exact field value. For any given
        /// value, the value can only be in one property. Depending on the field, either
        /// all properties can be set or only a subset will be available.
        /// Refer to the documentation of the field.
        /// </summary>
        [JsonProperty("group_ids", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FilterValue GroupIds { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CustomerFilter : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CreationSource = {(CreationSource == null ? "null" : CreationSource.ToString())}");
            toStringOutput.Add($"CreatedAt = {(CreatedAt == null ? "null" : CreatedAt.ToString())}");
            toStringOutput.Add($"UpdatedAt = {(UpdatedAt == null ? "null" : UpdatedAt.ToString())}");
            toStringOutput.Add($"EmailAddress = {(EmailAddress == null ? "null" : EmailAddress.ToString())}");
            toStringOutput.Add($"PhoneNumber = {(PhoneNumber == null ? "null" : PhoneNumber.ToString())}");
            toStringOutput.Add($"ReferenceId = {(ReferenceId == null ? "null" : ReferenceId.ToString())}");
            toStringOutput.Add($"GroupIds = {(GroupIds == null ? "null" : GroupIds.ToString())}");
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

            return obj is CustomerFilter other &&
                ((CreationSource == null && other.CreationSource == null) || (CreationSource?.Equals(other.CreationSource) == true)) &&
                ((CreatedAt == null && other.CreatedAt == null) || (CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((UpdatedAt == null && other.UpdatedAt == null) || (UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((EmailAddress == null && other.EmailAddress == null) || (EmailAddress?.Equals(other.EmailAddress) == true)) &&
                ((PhoneNumber == null && other.PhoneNumber == null) || (PhoneNumber?.Equals(other.PhoneNumber) == true)) &&
                ((ReferenceId == null && other.ReferenceId == null) || (ReferenceId?.Equals(other.ReferenceId) == true)) &&
                ((GroupIds == null && other.GroupIds == null) || (GroupIds?.Equals(other.GroupIds) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 1632151242;

            if (CreationSource != null)
            {
               hashCode += CreationSource.GetHashCode();
            }

            if (CreatedAt != null)
            {
               hashCode += CreatedAt.GetHashCode();
            }

            if (UpdatedAt != null)
            {
               hashCode += UpdatedAt.GetHashCode();
            }

            if (EmailAddress != null)
            {
               hashCode += EmailAddress.GetHashCode();
            }

            if (PhoneNumber != null)
            {
               hashCode += PhoneNumber.GetHashCode();
            }

            if (ReferenceId != null)
            {
               hashCode += ReferenceId.GetHashCode();
            }

            if (GroupIds != null)
            {
               hashCode += GroupIds.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .CreationSource(CreationSource)
                .CreatedAt(CreatedAt)
                .UpdatedAt(UpdatedAt)
                .EmailAddress(EmailAddress)
                .PhoneNumber(PhoneNumber)
                .ReferenceId(ReferenceId)
                .GroupIds(GroupIds);
            return builder;
        }

        public class Builder
        {
            private Models.CustomerCreationSourceFilter creationSource;
            private Models.TimeRange createdAt;
            private Models.TimeRange updatedAt;
            private Models.CustomerTextFilter emailAddress;
            private Models.CustomerTextFilter phoneNumber;
            private Models.CustomerTextFilter referenceId;
            private Models.FilterValue groupIds;



            public Builder CreationSource(Models.CustomerCreationSourceFilter creationSource)
            {
                this.creationSource = creationSource;
                return this;
            }

            public Builder CreatedAt(Models.TimeRange createdAt)
            {
                this.createdAt = createdAt;
                return this;
            }

            public Builder UpdatedAt(Models.TimeRange updatedAt)
            {
                this.updatedAt = updatedAt;
                return this;
            }

            public Builder EmailAddress(Models.CustomerTextFilter emailAddress)
            {
                this.emailAddress = emailAddress;
                return this;
            }

            public Builder PhoneNumber(Models.CustomerTextFilter phoneNumber)
            {
                this.phoneNumber = phoneNumber;
                return this;
            }

            public Builder ReferenceId(Models.CustomerTextFilter referenceId)
            {
                this.referenceId = referenceId;
                return this;
            }

            public Builder GroupIds(Models.FilterValue groupIds)
            {
                this.groupIds = groupIds;
                return this;
            }

            public CustomerFilter Build()
            {
                return new CustomerFilter(creationSource,
                    createdAt,
                    updatedAt,
                    emailAddress,
                    phoneNumber,
                    referenceId,
                    groupIds);
            }
        }
    }
}