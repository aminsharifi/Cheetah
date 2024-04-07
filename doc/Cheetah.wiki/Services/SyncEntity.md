## * rpc General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | gRPC proto3     |
| Broker Server Name  | localhost: 5000 |
| Project Version     | 8.4.100         |
| Service Name        | SyncEntity      |

## * Grpc Messages

| Title | Value |
| ---   | ---   |
| Request Message Class Name  | SyncEntity_Input |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Request Message             | {GRPC_BaseClassWithName Base = 1;repeated GRPC_BaseClassWithNameAndDate Records = 2;google.protobuf.Int64Value Crud = 3;} |
| Response Message Class Name | SyncEntity_Output |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Response Message            | {GRPC_BaseClassWithName Result = 1;GRPC_BaseClassWithName OutputState = 2;}  |

## * Description



## * CRUD Matrix
     


## * gRPC Sample Input Message:

```javascript
{
    "Base": 
    {
        "Name": {"value": "D_User"}
    },
    "Crud": {"value": 0},
    "Records":
    [
        {
            "ERPCode": {"value": 4},
            "Name": {"value": "Sample4"},
            "DisplayName": {"value": "نمونه4"}
        }
    ]
}
```

## * gRPC Sample Output Message:

```javascript
{
    "Result": {
        "Id": {
            "value": "0"
        },
        "ERPCode": {
            "value": "0"
        },
        "SortIndex": {
            "value": "0"
        },
        "Name": {
            "value": "D_User"
        },
        "DisplayName": {
            "value": ""
        }
    },
    "OutputState": {
        "Id": {
            "value": "0"
        },
        "ERPCode": null,
        "SortIndex": null,
        "Name": null,
        "DisplayName": null
    }
}
```