
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
    public class CatalogItemVariation 
    {
        public CatalogItemVariation(string itemId = null,
            string name = null,
            string sku = null,
            string upc = null,
            int? ordinal = null,
            string pricingType = null,
            Models.Money priceMoney = null,
            IList<Models.ItemVariationLocationOverrides> locationOverrides = null,
            bool? trackInventory = null,
            string inventoryAlertType = null,
            long? inventoryAlertThreshold = null,
            string userData = null,
            long? serviceDuration = null,
            bool? availableForBooking = null,
            IList<Models.CatalogItemOptionValueForItemVariation> itemOptionValues = null,
            string measurementUnitId = null,
            IList<string> teamMemberIds = null)
        {
            ItemId = itemId;
            Name = name;
            Sku = sku;
            Upc = upc;
            Ordinal = ordinal;
            PricingType = pricingType;
            PriceMoney = priceMoney;
            LocationOverrides = locationOverrides;
            TrackInventory = trackInventory;
            InventoryAlertType = inventoryAlertType;
            InventoryAlertThreshold = inventoryAlertThreshold;
            UserData = userData;
            ServiceDuration = serviceDuration;
            AvailableForBooking = availableForBooking;
            ItemOptionValues = itemOptionValues;
            MeasurementUnitId = measurementUnitId;
            TeamMemberIds = teamMemberIds;
        }

        /// <summary>
        /// The ID of the `CatalogItem` associated with this item variation.
        /// </summary>
        [JsonProperty("item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemId { get; }

        /// <summary>
        /// The item variation's name. This is a searchable attribute for use in applicable query filters, and its value length is of Unicode code points.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; }

        /// <summary>
        /// The item variation's SKU, if any. This is a searchable attribute for use in applicable query filters.
        /// </summary>
        [JsonProperty("sku", NullValueHandling = NullValueHandling.Ignore)]
        public string Sku { get; }

        /// <summary>
        /// The universal product code (UPC) of the item variation, if any. This is a searchable attribute for use in applicable query filters.
        /// The value of this attribute should be a number of 12-14 digits long.  This restriction is enforced on the Square Seller Dashboard, 
        /// Square Point of Sale or Retail Point of Sale apps, where this attribute shows in the GTIN field. If a non-compliant UPC value is assigned 
        /// to this attribute using the API, the value is not editable on the Seller Dashboard, Square Point of Sale or Retail Point of Sale apps 
        /// unless it is updated to fit the expected format.
        /// </summary>
        [JsonProperty("upc", NullValueHandling = NullValueHandling.Ignore)]
        public string Upc { get; }

        /// <summary>
        /// The order in which this item variation should be displayed. This value is read-only. On writes, the ordinal
        /// for each item variation within a parent `CatalogItem` is set according to the item variations's
        /// position. On reads, the value is not guaranteed to be sequential or unique.
        /// </summary>
        [JsonProperty("ordinal", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ordinal { get; }

        /// <summary>
        /// Indicates whether the price of a CatalogItemVariation should be entered manually at the time of sale.
        /// </summary>
        [JsonProperty("pricing_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PricingType { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("price_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money PriceMoney { get; }

        /// <summary>
        /// Per-location price and inventory overrides.
        /// </summary>
        [JsonProperty("location_overrides", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.ItemVariationLocationOverrides> LocationOverrides { get; }

        /// <summary>
        /// If `true`, inventory tracking is active for the variation.
        /// </summary>
        [JsonProperty("track_inventory", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TrackInventory { get; }

        /// <summary>
        /// Indicates whether Square should alert the merchant when the inventory quantity of a CatalogItemVariation is low.
        /// </summary>
        [JsonProperty("inventory_alert_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InventoryAlertType { get; }

        /// <summary>
        /// If the inventory quantity for the variation is less than or equal to this value and `inventory_alert_type`
        /// is `LOW_QUANTITY`, the variation displays an alert in the merchant dashboard.
        /// This value is always an integer.
        /// </summary>
        [JsonProperty("inventory_alert_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public long? InventoryAlertThreshold { get; }

        /// <summary>
        /// Arbitrary user metadata to associate with the item variation. This attribute value length is of Unicode code points.
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; }

        /// <summary>
        /// If the `CatalogItem` that owns this item variation is of type
        /// `APPOINTMENTS_SERVICE`, then this is the duration of the service in milliseconds. For
        /// example, a 30 minute appointment would have the value `1800000`, which is equal to
        /// 30 (minutes) * 60 (seconds per minute) * 1000 (milliseconds per second).
        /// </summary>
        [JsonProperty("service_duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? ServiceDuration { get; }

        /// <summary>
        /// If the `CatalogItem` that owns this item variation is of type
        /// `APPOINTMENTS_SERVICE`, a bool representing whether this service is available for booking.
        /// </summary>
        [JsonProperty("available_for_booking", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AvailableForBooking { get; }

        /// <summary>
        /// List of item option values associated with this item variation. Listed
        /// in the same order as the item options of the parent item.
        /// </summary>
        [JsonProperty("item_option_values", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.CatalogItemOptionValueForItemVariation> ItemOptionValues { get; }

        /// <summary>
        /// ID of the ‘CatalogMeasurementUnit’ that is used to measure the quantity
        /// sold of this item variation. If left unset, the item will be sold in
        /// whole quantities.
        /// </summary>
        [JsonProperty("measurement_unit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MeasurementUnitId { get; }

        /// <summary>
        /// Tokens of employees that can perform the service represented by this variation. Only valid for
        /// variations of type `APPOINTMENTS_SERVICE`.
        /// </summary>
        [JsonProperty("team_member_ids", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> TeamMemberIds { get; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CatalogItemVariation : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ItemId = {(ItemId == null ? "null" : ItemId == string.Empty ? "" : ItemId)}");
            toStringOutput.Add($"Name = {(Name == null ? "null" : Name == string.Empty ? "" : Name)}");
            toStringOutput.Add($"Sku = {(Sku == null ? "null" : Sku == string.Empty ? "" : Sku)}");
            toStringOutput.Add($"Upc = {(Upc == null ? "null" : Upc == string.Empty ? "" : Upc)}");
            toStringOutput.Add($"Ordinal = {(Ordinal == null ? "null" : Ordinal.ToString())}");
            toStringOutput.Add($"PricingType = {(PricingType == null ? "null" : PricingType.ToString())}");
            toStringOutput.Add($"PriceMoney = {(PriceMoney == null ? "null" : PriceMoney.ToString())}");
            toStringOutput.Add($"LocationOverrides = {(LocationOverrides == null ? "null" : $"[{ string.Join(", ", LocationOverrides)} ]")}");
            toStringOutput.Add($"TrackInventory = {(TrackInventory == null ? "null" : TrackInventory.ToString())}");
            toStringOutput.Add($"InventoryAlertType = {(InventoryAlertType == null ? "null" : InventoryAlertType.ToString())}");
            toStringOutput.Add($"InventoryAlertThreshold = {(InventoryAlertThreshold == null ? "null" : InventoryAlertThreshold.ToString())}");
            toStringOutput.Add($"UserData = {(UserData == null ? "null" : UserData == string.Empty ? "" : UserData)}");
            toStringOutput.Add($"ServiceDuration = {(ServiceDuration == null ? "null" : ServiceDuration.ToString())}");
            toStringOutput.Add($"AvailableForBooking = {(AvailableForBooking == null ? "null" : AvailableForBooking.ToString())}");
            toStringOutput.Add($"ItemOptionValues = {(ItemOptionValues == null ? "null" : $"[{ string.Join(", ", ItemOptionValues)} ]")}");
            toStringOutput.Add($"MeasurementUnitId = {(MeasurementUnitId == null ? "null" : MeasurementUnitId == string.Empty ? "" : MeasurementUnitId)}");
            toStringOutput.Add($"TeamMemberIds = {(TeamMemberIds == null ? "null" : $"[{ string.Join(", ", TeamMemberIds)} ]")}");
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

            return obj is CatalogItemVariation other &&
                ((ItemId == null && other.ItemId == null) || (ItemId?.Equals(other.ItemId) == true)) &&
                ((Name == null && other.Name == null) || (Name?.Equals(other.Name) == true)) &&
                ((Sku == null && other.Sku == null) || (Sku?.Equals(other.Sku) == true)) &&
                ((Upc == null && other.Upc == null) || (Upc?.Equals(other.Upc) == true)) &&
                ((Ordinal == null && other.Ordinal == null) || (Ordinal?.Equals(other.Ordinal) == true)) &&
                ((PricingType == null && other.PricingType == null) || (PricingType?.Equals(other.PricingType) == true)) &&
                ((PriceMoney == null && other.PriceMoney == null) || (PriceMoney?.Equals(other.PriceMoney) == true)) &&
                ((LocationOverrides == null && other.LocationOverrides == null) || (LocationOverrides?.Equals(other.LocationOverrides) == true)) &&
                ((TrackInventory == null && other.TrackInventory == null) || (TrackInventory?.Equals(other.TrackInventory) == true)) &&
                ((InventoryAlertType == null && other.InventoryAlertType == null) || (InventoryAlertType?.Equals(other.InventoryAlertType) == true)) &&
                ((InventoryAlertThreshold == null && other.InventoryAlertThreshold == null) || (InventoryAlertThreshold?.Equals(other.InventoryAlertThreshold) == true)) &&
                ((UserData == null && other.UserData == null) || (UserData?.Equals(other.UserData) == true)) &&
                ((ServiceDuration == null && other.ServiceDuration == null) || (ServiceDuration?.Equals(other.ServiceDuration) == true)) &&
                ((AvailableForBooking == null && other.AvailableForBooking == null) || (AvailableForBooking?.Equals(other.AvailableForBooking) == true)) &&
                ((ItemOptionValues == null && other.ItemOptionValues == null) || (ItemOptionValues?.Equals(other.ItemOptionValues) == true)) &&
                ((MeasurementUnitId == null && other.MeasurementUnitId == null) || (MeasurementUnitId?.Equals(other.MeasurementUnitId) == true)) &&
                ((TeamMemberIds == null && other.TeamMemberIds == null) || (TeamMemberIds?.Equals(other.TeamMemberIds) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = -1155387790;

            if (ItemId != null)
            {
               hashCode += ItemId.GetHashCode();
            }

            if (Name != null)
            {
               hashCode += Name.GetHashCode();
            }

            if (Sku != null)
            {
               hashCode += Sku.GetHashCode();
            }

            if (Upc != null)
            {
               hashCode += Upc.GetHashCode();
            }

            if (Ordinal != null)
            {
               hashCode += Ordinal.GetHashCode();
            }

            if (PricingType != null)
            {
               hashCode += PricingType.GetHashCode();
            }

            if (PriceMoney != null)
            {
               hashCode += PriceMoney.GetHashCode();
            }

            if (LocationOverrides != null)
            {
               hashCode += LocationOverrides.GetHashCode();
            }

            if (TrackInventory != null)
            {
               hashCode += TrackInventory.GetHashCode();
            }

            if (InventoryAlertType != null)
            {
               hashCode += InventoryAlertType.GetHashCode();
            }

            if (InventoryAlertThreshold != null)
            {
               hashCode += InventoryAlertThreshold.GetHashCode();
            }

            if (UserData != null)
            {
               hashCode += UserData.GetHashCode();
            }

            if (ServiceDuration != null)
            {
               hashCode += ServiceDuration.GetHashCode();
            }

            if (AvailableForBooking != null)
            {
               hashCode += AvailableForBooking.GetHashCode();
            }

            if (ItemOptionValues != null)
            {
               hashCode += ItemOptionValues.GetHashCode();
            }

            if (MeasurementUnitId != null)
            {
               hashCode += MeasurementUnitId.GetHashCode();
            }

            if (TeamMemberIds != null)
            {
               hashCode += TeamMemberIds.GetHashCode();
            }

            return hashCode;
        }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .ItemId(ItemId)
                .Name(Name)
                .Sku(Sku)
                .Upc(Upc)
                .Ordinal(Ordinal)
                .PricingType(PricingType)
                .PriceMoney(PriceMoney)
                .LocationOverrides(LocationOverrides)
                .TrackInventory(TrackInventory)
                .InventoryAlertType(InventoryAlertType)
                .InventoryAlertThreshold(InventoryAlertThreshold)
                .UserData(UserData)
                .ServiceDuration(ServiceDuration)
                .AvailableForBooking(AvailableForBooking)
                .ItemOptionValues(ItemOptionValues)
                .MeasurementUnitId(MeasurementUnitId)
                .TeamMemberIds(TeamMemberIds);
            return builder;
        }

        public class Builder
        {
            private string itemId;
            private string name;
            private string sku;
            private string upc;
            private int? ordinal;
            private string pricingType;
            private Models.Money priceMoney;
            private IList<Models.ItemVariationLocationOverrides> locationOverrides;
            private bool? trackInventory;
            private string inventoryAlertType;
            private long? inventoryAlertThreshold;
            private string userData;
            private long? serviceDuration;
            private bool? availableForBooking;
            private IList<Models.CatalogItemOptionValueForItemVariation> itemOptionValues;
            private string measurementUnitId;
            private IList<string> teamMemberIds;



            public Builder ItemId(string itemId)
            {
                this.itemId = itemId;
                return this;
            }

            public Builder Name(string name)
            {
                this.name = name;
                return this;
            }

            public Builder Sku(string sku)
            {
                this.sku = sku;
                return this;
            }

            public Builder Upc(string upc)
            {
                this.upc = upc;
                return this;
            }

            public Builder Ordinal(int? ordinal)
            {
                this.ordinal = ordinal;
                return this;
            }

            public Builder PricingType(string pricingType)
            {
                this.pricingType = pricingType;
                return this;
            }

            public Builder PriceMoney(Models.Money priceMoney)
            {
                this.priceMoney = priceMoney;
                return this;
            }

            public Builder LocationOverrides(IList<Models.ItemVariationLocationOverrides> locationOverrides)
            {
                this.locationOverrides = locationOverrides;
                return this;
            }

            public Builder TrackInventory(bool? trackInventory)
            {
                this.trackInventory = trackInventory;
                return this;
            }

            public Builder InventoryAlertType(string inventoryAlertType)
            {
                this.inventoryAlertType = inventoryAlertType;
                return this;
            }

            public Builder InventoryAlertThreshold(long? inventoryAlertThreshold)
            {
                this.inventoryAlertThreshold = inventoryAlertThreshold;
                return this;
            }

            public Builder UserData(string userData)
            {
                this.userData = userData;
                return this;
            }

            public Builder ServiceDuration(long? serviceDuration)
            {
                this.serviceDuration = serviceDuration;
                return this;
            }

            public Builder AvailableForBooking(bool? availableForBooking)
            {
                this.availableForBooking = availableForBooking;
                return this;
            }

            public Builder ItemOptionValues(IList<Models.CatalogItemOptionValueForItemVariation> itemOptionValues)
            {
                this.itemOptionValues = itemOptionValues;
                return this;
            }

            public Builder MeasurementUnitId(string measurementUnitId)
            {
                this.measurementUnitId = measurementUnitId;
                return this;
            }

            public Builder TeamMemberIds(IList<string> teamMemberIds)
            {
                this.teamMemberIds = teamMemberIds;
                return this;
            }

            public CatalogItemVariation Build()
            {
                return new CatalogItemVariation(itemId,
                    name,
                    sku,
                    upc,
                    ordinal,
                    pricingType,
                    priceMoney,
                    locationOverrides,
                    trackInventory,
                    inventoryAlertType,
                    inventoryAlertThreshold,
                    userData,
                    serviceDuration,
                    availableForBooking,
                    itemOptionValues,
                    measurementUnitId,
                    teamMemberIds);
            }
        }
    }
}