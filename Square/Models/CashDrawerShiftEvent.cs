
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
    public class CashDrawerShiftEvent 
    {
        public CashDrawerShiftEvent(string id = null,
            string employeeId = null,
            string eventType = null,
            Models.Money eventMoney = null,
            string createdAt = null,
            string description = null)
        {
            Id = id;
            EmployeeId = employeeId;
            EventType = eventType;
            EventMoney = eventMoney;
            CreatedAt = createdAt;
            Description = description;
        }

        /// <summary>
        /// The unique ID of the event.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; }

        /// <summary>
        /// The ID of the employee that created the event.
        /// </summary>
        [JsonProperty("employee_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EmployeeId { get; }

        /// <summary>
        /// The types of events on a CashDrawerShift.
        /// Each event type represents an employee action on the actual cash drawer
        /// represented by a CashDrawerShift.
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("event_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money EventMoney { get; }

        /// <summary>
        /// The event time in ISO 8601 format.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; }

        /// <summary>
        /// An optional description of the event, entered by the employee that
        /// created the event.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CashDrawerShiftEvent : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(Id == null ? "null" : Id == string.Empty ? "" : Id)}");
            toStringOutput.Add($"EmployeeId = {(EmployeeId == null ? "null" : EmployeeId == string.Empty ? "" : EmployeeId)}");
            toStringOutput.Add($"EventType = {(EventType == null ? "null" : EventType.ToString())}");
            toStringOutput.Add($"EventMoney = {(EventMoney == null ? "null" : EventMoney.ToString())}");
            toStringOutput.Add($"CreatedAt = {(CreatedAt == null ? "null" : CreatedAt == string.Empty ? "" : CreatedAt)}");
            toStringOutput.Add($"Description = {(Description == null ? "null" : Description == string.Empty ? "" : Description)}");
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

            return obj is CashDrawerShiftEvent other &&
                ((Id == null && other.Id == null) || (Id?.Equals(other.Id) == true)) &&
                ((EmployeeId == null && other.EmployeeId == null) || (EmployeeId?.Equals(other.EmployeeId) == true)) &&
                ((EventType == null && other.EventType == null) || (EventType?.Equals(other.EventType) == true)) &&
                ((EventMoney == null && other.EventMoney == null) || (EventMoney?.Equals(other.EventMoney) == true)) &&
                ((CreatedAt == null && other.CreatedAt == null) || (CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((Description == null && other.Description == null) || (Description?.Equals(other.Description) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 1056052778;

            if (Id != null)
            {
               hashCode += Id.GetHashCode();
            }

            if (EmployeeId != null)
            {
               hashCode += EmployeeId.GetHashCode();
            }

            if (EventType != null)
            {
               hashCode += EventType.GetHashCode();
            }

            if (EventMoney != null)
            {
               hashCode += EventMoney.GetHashCode();
            }

            if (CreatedAt != null)
            {
               hashCode += CreatedAt.GetHashCode();
            }

            if (Description != null)
            {
               hashCode += Description.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Id(Id)
                .EmployeeId(EmployeeId)
                .EventType(EventType)
                .EventMoney(EventMoney)
                .CreatedAt(CreatedAt)
                .Description(Description);
            return builder;
        }

        public class Builder
        {
            private string id;
            private string employeeId;
            private string eventType;
            private Models.Money eventMoney;
            private string createdAt;
            private string description;



            public Builder Id(string id)
            {
                this.id = id;
                return this;
            }

            public Builder EmployeeId(string employeeId)
            {
                this.employeeId = employeeId;
                return this;
            }

            public Builder EventType(string eventType)
            {
                this.eventType = eventType;
                return this;
            }

            public Builder EventMoney(Models.Money eventMoney)
            {
                this.eventMoney = eventMoney;
                return this;
            }

            public Builder CreatedAt(string createdAt)
            {
                this.createdAt = createdAt;
                return this;
            }

            public Builder Description(string description)
            {
                this.description = description;
                return this;
            }

            public CashDrawerShiftEvent Build()
            {
                return new CashDrawerShiftEvent(id,
                    employeeId,
                    eventType,
                    eventMoney,
                    createdAt,
                    description);
            }
        }
    }
}