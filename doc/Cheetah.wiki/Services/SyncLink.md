## * rpc General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | gRPC proto3     |
| Broker Server Name  | localhost: 5000 |
| Project Version     | 8.4.100         |
| Service Name        | SyncLink        |

## * Grpc Messages

| Title | Value |
| ---   | ---   |
| Request Message Class Name  | SyncLink_Input |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Request Message             | {GRPC_BaseClassWithName Base = 1;repeated LinkEntity Records = 2;google.protobuf.Int64Value Crud = 3;} |
| Response Message Class Name | SyncLink_Output |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Response Message            | {GRPC_BaseClassWithName Result = 1;GRPC_BaseClassWithName OutputState = 2;}  |

## * Description



## * CRUD Matrix
     


## * gRPC Sample Input Message:

```javascript
{
    "Base": 
    {
        "Name": {"value": "L_UserCondition"}
    },
    "Crud": {"value": "1"},
    "Records":
    [
        {
            "ERPCode": {"value": "12"},
            "First": {"ERPCode": {"value": "16"}},
            "Second": {"ERPCode": {"value": "17"}},
            "EnableRecord": {"value": false}
        },
        {
            "ERPCode": {"value": "13"},
            "First": {"ERPCode": {"value": "15"}},
            "Second": {"ERPCode": {"value": "17"}},
            "EnableRecord": {"value": true}
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
            "value": "L_UserCondition"
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