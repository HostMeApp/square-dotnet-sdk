
# Order Return Line Item

The line item being returned in an Order.

## Structure

`OrderReturnLineItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | Unique identifier for this return line item entry.<br>**Constraints**: *Maximum Length*: `60` |
| `SourceLineItemUid` | `string` | Optional | `uid` of the LineItem in the original sale Order.<br>**Constraints**: *Maximum Length*: `60` |
| `Name` | `string` | Optional | The name of the line item.<br>**Constraints**: *Maximum Length*: `512` |
| `Quantity` | `string` | Required | The quantity returned, formatted as a decimal number.<br>For example: `"3"`.<br><br>Line items with a `quantity_unit` can have non-integer quantities.<br>For example: `"1.70000"`.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `12` |
| `QuantityUnit` | [`Models.OrderQuantityUnit`](/doc/models/order-quantity-unit.md) | Optional | Contains the measurement unit for a quantity and a precision which<br>specifies the number of digits after the decimal point for decimal quantities. |
| `Note` | `string` | Optional | The note of the returned line item.<br>**Constraints**: *Maximum Length*: `2000` |
| `CatalogObjectId` | `string` | Optional | The [CatalogItemVariation](#type-catalogitemvariation) id applied to this returned line item.<br>**Constraints**: *Maximum Length*: `192` |
| `VariationName` | `string` | Optional | The name of the variation applied to this returned line item.<br>**Constraints**: *Maximum Length*: `255` |
| `ReturnModifiers` | [`IList<Models.OrderReturnLineItemModifier>`](/doc/models/order-return-line-item-modifier.md) | Optional | The [CatalogModifier](#type-catalogmodifier)s applied to this line item. |
| `AppliedTaxes` | [`IList<Models.OrderLineItemAppliedTax>`](/doc/models/order-line-item-applied-tax.md) | Optional | The list of references to `OrderReturnTax` entities applied to the returned line item. Each<br>`OrderLineItemAppliedTax` has a `tax_uid` that references the `uid` of a top-level<br>`OrderReturnTax` applied to the returned line item. On reads, the amount applied<br>is populated. |
| `AppliedDiscounts` | [`IList<Models.OrderLineItemAppliedDiscount>`](/doc/models/order-line-item-applied-discount.md) | Optional | The list of references to `OrderReturnDiscount` entities applied to the returned line item. Each<br>`OrderLineItemAppliedDiscount` has a `discount_uid` that references the `uid` of a top-level<br>`OrderReturnDiscount` applied to the returned line item. On reads, the amount<br>applied is populated. |
| `BasePriceMoney` | [`Models.Money`](/doc/models/money.md) | Optional | Represents an amount of money. `Money` fields can be signed or unsigned.<br>Fields that do not explicitly define whether they are signed or unsigned are<br>considered unsigned and can only hold positive amounts. For signed fields, the<br>sign of the value indicates the purpose of the money transfer. See<br>[Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)<br>for more information. |
| `VariationTotalPriceMoney` | [`Models.Money`](/doc/models/money.md) | Optional | Represents an amount of money. `Money` fields can be signed or unsigned.<br>Fields that do not explicitly define whether they are signed or unsigned are<br>considered unsigned and can only hold positive amounts. For signed fields, the<br>sign of the value indicates the purpose of the money transfer. See<br>[Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)<br>for more information. |
| `GrossReturnMoney` | [`Models.Money`](/doc/models/money.md) | Optional | Represents an amount of money. `Money` fields can be signed or unsigned.<br>Fields that do not explicitly define whether they are signed or unsigned are<br>considered unsigned and can only hold positive amounts. For signed fields, the<br>sign of the value indicates the purpose of the money transfer. See<br>[Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)<br>for more information. |
| `TotalTaxMoney` | [`Models.Money`](/doc/models/money.md) | Optional | Represents an amount of money. `Money` fields can be signed or unsigned.<br>Fields that do not explicitly define whether they are signed or unsigned are<br>considered unsigned and can only hold positive amounts. For signed fields, the<br>sign of the value indicates the purpose of the money transfer. See<br>[Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)<br>for more information. |
| `TotalDiscountMoney` | [`Models.Money`](/doc/models/money.md) | Optional | Represents an amount of money. `Money` fields can be signed or unsigned.<br>Fields that do not explicitly define whether they are signed or unsigned are<br>considered unsigned and can only hold positive amounts. For signed fields, the<br>sign of the value indicates the purpose of the money transfer. See<br>[Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)<br>for more information. |
| `TotalMoney` | [`Models.Money`](/doc/models/money.md) | Optional | Represents an amount of money. `Money` fields can be signed or unsigned.<br>Fields that do not explicitly define whether they are signed or unsigned are<br>considered unsigned and can only hold positive amounts. For signed fields, the<br>sign of the value indicates the purpose of the money transfer. See<br>[Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)<br>for more information. |

## Example (as JSON)

```json
{
  "uid": "uid0",
  "source_line_item_uid": "source_line_item_uid2",
  "name": "name0",
  "quantity": "quantity6",
  "quantity_unit": {
    "measurement_unit": {
      "custom_unit": {
        "name": "name8",
        "abbreviation": "abbreviation0"
      },
      "area_unit": "IMPERIAL_SQUARE_FOOT",
      "length_unit": "METRIC_METER",
      "volume_unit": "GENERIC_CUP",
      "weight_unit": "IMPERIAL_WEIGHT_OUNCE"
    },
    "precision": 54
  },
  "note": "note4"
}
```

