
# Customer Segment

Represents a group of customer profiles that match one or more predefined filter criteria.

Segments (also known as Smart Groups) are defined and created within Customer Directory in the Square Dashboard or Point of Sale.

## Structure

`CustomerSegment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Unique Square-generated ID for the segment.<br>**Constraints**: *Maximum Length*: `255` |
| `Name` | `string` | Required | Name of the segment. |
| `CreatedAt` | `string` | Optional | The timestamp when the segment was created, in RFC 3339 format. |
| `UpdatedAt` | `string` | Optional | The timestamp when the segment was last updated, in RFC 3339 format. |

## Example (as JSON)

```json
{
  "id": "id0",
  "name": "name0",
  "created_at": "created_at2",
  "updated_at": "updated_at4"
}
```

