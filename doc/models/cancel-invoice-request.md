
# Cancel Invoice Request

Describes a `CancelInvoice` request.

## Structure

`CancelInvoiceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Version` | `int` | Required | The version of the [invoice](#type-invoice) to cancel.<br>If you do not know the version, you can call<br>[GetInvoice](#endpoint-Invoices-GetInvoice) or [ListInvoices](#endpoint-Invoices-ListInvoices). |

## Example (as JSON)

```json
{
  "version": 0
}
```

