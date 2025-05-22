
# ACH Debit Response

A Resource representing a response of vaulted a ACH Debit Account.

## Structure

`ACHDebitResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `VerificationStatus` | `string` | Optional | The ach debit verification status.<br><br>**Default**: `"NOT_VERIFIED"`<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255` |

## Example (as JSON)

```json
{
  "verification_status": "NOT_VERIFIED"
}
```

