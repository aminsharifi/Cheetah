## * rpc General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | gRPC proto3     |
| Broker Server Name  | localhost: 5000 |
| Project Version     | 8.4.100         |
| Service Name        | SyncCondition   |

## * Grpc Messages

| Title | Value |
| ---   | ---   |
| Request Message Class Name  | SyncCondition_Input |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Request Message             | {GRPC_BaseClassWithName Base = 1;repeated GRPC_Condition Records  = 2;google.protobuf.Int64Value Crud = 3;} |
| Response Message Class Name | SyncCondition_Output |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Response Message            | {GRPC_BaseClassWithName Result = 1;GRPC_BaseClassWithName OutputState = 2;}  |

## * Description



## * CRUD Matrix
     


## * gRPC Sample Input Message:

```javascript
{
    "Base": 
    {
        "Name": {"value": "F_Condition"}
    },
    "Crud": {"value": 1},
    "Records":
    [
        {
            "Base":
            {
                "Name": {"value": "16"},
                "DisplayName": {"value": "16"},
                "ERPCode": {"value": "16"},
                "EnableRecord": {"value": true}
            },
            "Tag": {"Name":{"value": "Role"}},
            "Operand": {"Name": {"value": "="}},
            "Value":{"value": "Role 16"}
        },
        {
            "Base":
            {
                "Name": {"value": "17"},
                "DisplayName": {"value": "17"},
                "ERPCode": {"value": "17"},
                "EnableRecord": {"value": false}
            },
            "Tag": {"Name":{"value": "Role"}},
            "Operand": {"Name": {"value": "="}},
            "Value":{"value": "Role 17"}
        }
    ]
}
```

## * gRPC Sample Output Message:

```javascript
{
    "Result": {
        "Id": null,
        "ERPCode": null,
        "SortIndex": null,
        "Name": {
            "value": "F_Condition"
        },
        "DisplayName": null,
        "EnableRecord": null
    },
    "OutputState": {
        "Id": {
            "value": "0"
        },
        "ERPCode": null,
        "SortIndex": null,
        "Name": null,
        "DisplayName": null,
        "EnableRecord": null
    }
}
```