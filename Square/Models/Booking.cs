
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
    public class Booking 
    {
        public Booking(string id = null,
            int? version = null,
            string status = null,
            string createdAt = null,
            string updatedAt = null,
            string startAt = null,
            string locationId = null,
            string customerId = null,
            string customerNote = null,
            string sellerNote = null,
            IList<Models.AppointmentSegment> appointmentSegments = null)
        {
            Id = id;
            Version = version;
            Status = status;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            StartAt = startAt;
            LocationId = locationId;
            CustomerId = customerId;
            CustomerNote = customerNote;
            SellerNote = sellerNote;
            AppointmentSegments = appointmentSegments;
        }

        /// <summary>
        /// A unique ID of this object representing a booking.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; }

        /// <summary>
        /// The revision number for the booking used for optimistic concurrency.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public int? Version { get; }

        /// <summary>
        /// Supported booking statuses.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; }

        /// <summary>
        /// The timestamp specifying the creation time of this booking.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; }

        /// <summary>
        /// The timestamp specifying the most recent update time of this booking.
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; }

        /// <summary>
        /// The timestamp specifying the starting time of this booking.
        /// </summary>
        [JsonProperty("start_at", NullValueHandling = NullValueHandling.Ignore)]
        public string StartAt { get; }

        /// <summary>
        /// The ID of the [Location](#type-location) object representing the location where the booked service is provided.
        /// </summary>
        [JsonProperty("location_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationId { get; }

        /// <summary>
        /// The ID of the [Customer](#type-Customer) object representing the customer attending this booking
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; }

        /// <summary>
        /// The free-text field for the customer to supply notes about the booking. For example, the note can be preferences that cannot be expressed by supported attributes of a relevant [CatalogObject](#type-CatalogObject) instance.
        /// </summary>
        [JsonProperty("customer_note", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerNote { get; }

        /// <summary>
        /// The free-text field for the seller to supply notes about the booking. For example, the note can be preferences that cannot be expressed by supported attributes of a specific [CatalogObject](#type-CatalogObject) instance.
        /// This field should not be visible to customers.
        /// </summary>
        [JsonProperty("seller_note", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerNote { get; }

        /// <summary>
        /// A list of appointment segments for this booking.
        /// </summary>
        [JsonProperty("appointment_segments", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.AppointmentSegment> AppointmentSegments { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Booking : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(Id == null ? "null" : Id == string.Empty ? "" : Id)}");
            toStringOutput.Add($"Version = {(Version == null ? "null" : Version.ToString())}");
            toStringOutput.Add($"Status = {(Status == null ? "null" : Status.ToString())}");
            toStringOutput.Add($"CreatedAt = {(CreatedAt == null ? "null" : CreatedAt == string.Empty ? "" : CreatedAt)}");
            toStringOutput.Add($"UpdatedAt = {(UpdatedAt == null ? "null" : UpdatedAt == string.Empty ? "" : UpdatedAt)}");
            toStringOutput.Add($"StartAt = {(StartAt == null ? "null" : StartAt == string.Empty ? "" : StartAt)}");
            toStringOutput.Add($"LocationId = {(LocationId == null ? "null" : LocationId == string.Empty ? "" : LocationId)}");
            toStringOutput.Add($"CustomerId = {(CustomerId == null ? "null" : CustomerId == string.Empty ? "" : CustomerId)}");
            toStringOutput.Add($"CustomerNote = {(CustomerNote == null ? "null" : CustomerNote == string.Empty ? "" : CustomerNote)}");
            toStringOutput.Add($"SellerNote = {(SellerNote == null ? "null" : SellerNote == string.Empty ? "" : SellerNote)}");
            toStringOutput.Add($"AppointmentSegments = {(AppointmentSegments == null ? "null" : $"[{ string.Join(", ", AppointmentSegments)} ]")}");
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

            return obj is Booking other &&
                ((Id == null && other.Id == null) || (Id?.Equals(other.Id) == true)) &&
                ((Version == null && other.Version == null) || (Version?.Equals(other.Version) == true)) &&
                ((Status == null && other.Status == null) || (Status?.Equals(other.Status) == true)) &&
                ((CreatedAt == null && other.CreatedAt == null) || (CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((UpdatedAt == null && other.UpdatedAt == null) || (UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((StartAt == null && other.StartAt == null) || (StartAt?.Equals(other.StartAt) == true)) &&
                ((LocationId == null && other.LocationId == null) || (LocationId?.Equals(other.LocationId) == true)) &&
                ((CustomerId == null && other.CustomerId == null) || (CustomerId?.Equals(other.CustomerId) == true)) &&
                ((CustomerNote == null && other.CustomerNote == null) || (CustomerNote?.Equals(other.CustomerNote) == true)) &&
                ((SellerNote == null && other.SellerNote == null) || (SellerNote?.Equals(other.SellerNote) == true)) &&
                ((AppointmentSegments == null && other.AppointmentSegments == null) || (AppointmentSegments?.Equals(other.AppointmentSegments) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 219005029;

            if (Id != null)
            {
               hashCode += Id.GetHashCode();
            }

            if (Version != null)
            {
               hashCode += Version.GetHashCode();
            }

            if (Status != null)
            {
               hashCode += Status.GetHashCode();
            }

            if (CreatedAt != null)
            {
               hashCode += CreatedAt.GetHashCode();
            }

            if (UpdatedAt != null)
            {
               hashCode += UpdatedAt.GetHashCode();
            }

            if (StartAt != null)
            {
               hashCode += StartAt.GetHashCode();
            }

            if (LocationId != null)
            {
               hashCode += LocationId.GetHashCode();
            }

            if (CustomerId != null)
            {
               hashCode += CustomerId.GetHashCode();
            }

            if (CustomerNote != null)
            {
               hashCode += CustomerNote.GetHashCode();
            }

            if (SellerNote != null)
            {
               hashCode += SellerNote.GetHashCode();
            }

            if (AppointmentSegments != null)
            {
               hashCode += AppointmentSegments.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Id(Id)
                .Version(Version)
                .Status(Status)
                .CreatedAt(CreatedAt)
                .UpdatedAt(UpdatedAt)
                .StartAt(StartAt)
                .LocationId(LocationId)
                .CustomerId(CustomerId)
                .CustomerNote(CustomerNote)
                .SellerNote(SellerNote)
                .AppointmentSegments(AppointmentSegments);
            return builder;
        }

        public class Builder
        {
            private string id;
            private int? version;
            private string status;
            private string createdAt;
            private string updatedAt;
            private string startAt;
            private string locationId;
            private string customerId;
            private string customerNote;
            private string sellerNote;
            private IList<Models.AppointmentSegment> appointmentSegments;



            public Builder Id(string id)
            {
                this.id = id;
                return this;
            }

            public Builder Version(int? version)
            {
                this.version = version;
                return this;
            }

            public Builder Status(string status)
            {
                this.status = status;
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

            public Builder StartAt(string startAt)
            {
                this.startAt = startAt;
                return this;
            }

            public Builder LocationId(string locationId)
            {
                this.locationId = locationId;
                return this;
            }

            public Builder CustomerId(string customerId)
            {
                this.customerId = customerId;
                return this;
            }

            public Builder CustomerNote(string customerNote)
            {
                this.customerNote = customerNote;
                return this;
            }

            public Builder SellerNote(string sellerNote)
            {
                this.sellerNote = sellerNote;
                return this;
            }

            public Builder AppointmentSegments(IList<Models.AppointmentSegment> appointmentSegments)
            {
                this.appointmentSegments = appointmentSegments;
                return this;
            }

            public Booking Build()
            {
                return new Booking(id,
                    version,
                    status,
                    createdAt,
                    updatedAt,
                    startAt,
                    locationId,
                    customerId,
                    customerNote,
                    sellerNote,
                    appointmentSegments);
            }
        }
    }
}