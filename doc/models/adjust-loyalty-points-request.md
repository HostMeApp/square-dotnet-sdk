
# Adjust Loyalty Points Request

A request to adjust (add or subtract) points manually.

## Structure

`AdjustLoyaltyPointsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IdempotencyKey` | `string` | Required | A unique string that identifies this `AdjustLoyaltyPoints` request.<br>Keys can be any valid string, but must be unique for every request.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `128` |
| `AdjustPoints` | [`Models.LoyaltyEventAdjustPoints`](/doc/models/loyalty-event-adjust-points.md) | Required | Provides metadata when the event `type` is `ADJUST_POINTS`. |

## Example (as JSON)

```json
{
  "idempotency_key": "idempotency_key6",
  "adjust_points": {
    "loyalty_program_id": "loyalty_program_id2",
    "points": 96,
    "reason": "reason2"
  }
}
```

