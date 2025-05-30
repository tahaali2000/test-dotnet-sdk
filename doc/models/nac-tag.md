
# Nac Tag

## Structure

`NacTag`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AllowUsermacOverride` | `bool?` | Optional | can be set to true to allow the override by usermac result<br><br>**Default**: `false` |
| `CreatedTime` | `double?` | Optional | - |
| `EgressVlanNames` | `List<string>` | Optional | if `type`==`egress_vlan_names`, list of egress vlans to return |
| `GbpTag` | `int?` | Optional | if `type`==`gbp_tag` |
| `Id` | `Guid?` | Optional | - |
| `Match` | [`NacTag`](../../doc/models/nac-tag.md) | Optional | - |
| `MatchAll` | `bool?` | Optional | This field is applicable only when `type`==`match`<br><br>* `false`: means it is sufficient to match any of the values (i.e., match-any behavior)<br>* `true`: means all values should be matched (i.e., match-all behavior)<br><br>Currently it makes sense to set this field to `true` only if the `match`==`idp_role` or `match`==`usermac_label`'<br><br>**Default**: `false` |
| `ModifiedTime` | `double?` | Optional | - |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `OrgId` | `Guid?` | Optional | - |
| `RadiusAttrs` | `List<string>` | Optional | if `type`==`radius_attrs`, user can specify a list of one or more standard attributes in the field "radius_attrs".<br>It is the responsibility of the user to provide a syntactically correct string, otherwise it may not work as expected.<br>Note that it is allowed to have more than one radius_attrs in the result of a given rule. |
| `RadiusGroup` | `string` | Optional | if `type`==`radius_group` |
| `RadiusVendorAttrs` | `List<string>` | Optional | if `type`==`radius_vendor_attrs`, user can specify a list of one or more vendor-specific attributes in the field "radius_vendor_attrs".<br>It is the responsibility of the user to provide a syntactically correct string, otherwise it may not work as expected.<br>Note that it is allowed to have more than one radius_vendor_attrs in the result of a given rule. |
| `SessionTimeout` | `int?` | Optional | if `type`==`session_timeout, in seconds |
| `Type` | [`NacTag`](../../doc/models/nac-tag.md) | Required | - |
| `UsernameAttr` | [`NacTag`](../../doc/models/nac-tag.md) | Optional | - |
| `Values` | `List<string>` | Optional | if `type`==`match` |
| `Vlan` | `string` | Optional | if `type`==`vlan` |

## Example (as JSON)

```json
{
  "allow_usermac_override": false,
  "egress_vlan_names": [
    "1vlan-30",
    "1vlan-20",
    "2-vlan10"
  ],
  "match_all": false,
  "name": "name4",
  "org_id": "a97c1b22-a4e9-411e-9bfd-d8695a0f9e61",
  "radius_attrs": [
    "Idle-Timeout=600",
    "Termination-Action=RADIUS-Request"
  ],
  "radius_vendor_attrs": [
    "PaloAlto-Admin-Role=superuser",
    "PaloAlto-Panorama-Admin-Role=administrator"
  ],
  "session_timeout": 86000,
  "type": {
    "allow_usermac_override": false,
    "egress_vlan_names": [
      "1vlan-30",
      "1vlan-20",
      "2-vlan10"
    ],
    "match_all": false,
    "name": "name0",
    "org_id": "a97c1b22-a4e9-411e-9bfd-d8695a0f9e61",
    "radius_attrs": [
      "Idle-Timeout=600",
      "Termination-Action=RADIUS-Request"
    ],
    "radius_vendor_attrs": [
      "PaloAlto-Admin-Role=superuser",
      "PaloAlto-Panorama-Admin-Role=administrator"
    ],
    "session_timeout": 86000,
    "type": {
      "allow_usermac_override": false,
      "created_time": 191.4,
      "egress_vlan_names": [
        "egress_vlan_names8",
        "egress_vlan_names7",
        "egress_vlan_names6"
      ],
      "gbp_tag": 34,
      "id": "0000196e-0000-0000-0000-000000000000",
      "name": "name0",
      "type": {}
    },
    "created_time": 191.4,
    "gbp_tag": 34,
    "id": "0000196e-0000-0000-0000-000000000000"
  },
  "created_time": 105.64,
  "gbp_tag": 162,
  "id": "00001efe-0000-0000-0000-000000000000"
}
```

