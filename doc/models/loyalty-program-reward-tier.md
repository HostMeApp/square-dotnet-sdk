
# Loyalty Program Reward Tier

Describes a loyalty program reward tier.

## Structure

`LoyaltyProgramRewardTier`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The Square-assigned ID of the reward tier.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `36` |
| `Points` | `int` | Required | The points exchanged for the reward tier.<br>**Constraints**: `>= 1` |
| `Name` | `string` | Required | The name of the reward tier.<br>**Constraints**: *Minimum Length*: `1` |
| `Definition` | [`Models.LoyaltyProgramRewardDefinition`](/doc/models/loyalty-program-reward-definition.md) | Required | Provides details about the reward tier discount. DEPRECATED at version 2020-12-16. Discount details<br>are now defined using a catalog pricing rule and other catalog objects. For more information, see<br>[Get discount details for the reward](https://developer.squareup.com/docs/loyalty-api/overview#get-discount-details). |
| `CreatedAt` | `string` | Required | The timestamp when the reward tier was created, in RFC 3339 format. |
| `PricingRuleReference` | [`Models.CatalogObjectReference`](/doc/models/catalog-object-reference.md) | Optional | A reference to a Catalog object at a specific version. In general this is<br>used as an entry point into a graph of catalog objects, where the objects exist<br>at a specific version. |

## Example (as JSON)

```json
{
  "id": "id0",
  "points": 236,
  "name": "name0",
  "definition": {
    "scope": "ORDER",
    "discount_type": "FIXED_AMOUNT",
    "percentage_discount": "percentage_discount2",
    "catalog_object_ids": [
      "catalog_object_ids6"
    ],
    "fixed_discount_money": {
      "amount": 132,
      "currency": "TRY"
    },
    "max_discount_money": {
      "amount": 176,
      "currency": "MYR"
    }
  },
  "created_at": "created_at2",
  "pricing_rule_reference": {
    "object_id": "object_id0",
    "catalog_version": 218
  }
}
```

