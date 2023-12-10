## * gRPC General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | gRPC proto3     |
| Broker Server Name  | localhost: 5000 |
| Project Version     | 1.0.15          |
| Service Name        | CreateRequest   |

## * gRPC Messages

| Title | Value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
| --- | --- |
| Request Message Class Name  | CreateRequest_Input |
| Request Message             | {GRPC_BaseClass Case = 1;GRPC_BaseClassWithName Creator = 2;GRPC_BaseClassWithName Requestor = 3;GRPC_BaseClassWithName Process = 4;repeated Condition Conditions = 5;} |
| Response Message Class Name | CreateRequest_Output|
| Response Message            | {GRPC_BaseClassWithDate Case = 1;GRPC_BaseClassWithName OutputState = 2;} |

## * gRPC Custom Messages:

| Message Name            | Message Implementation |
| ---                     | ---                    |
| GRPC_BaseClass          | {google.protobuf.Int64Value Id = 1;google.protobuf.Int64Value ERPCode = 2;google.protobuf.StringValue Name = 3;google.protobuf.StringValue DisplayName = 4;} |
| Condition               | {GRPC_BaseClassWithName Tag = 1;GRPC_BaseClassWithName Operand = 2;google.protobuf.StringValue Value = 3;GRPC_BaseClassWithName User = 4;GRPC_BaseClassWithName Base =5;} |
| GRPC_BaseClassWithName  | {google.protobuf.Int64Value Id = 1;google.protobuf.Int64Value ERPCode = 2;google.protobuf.StringValue Name = 3;google.protobuf.StringValue DisplayName = 4;} |

## * gRPC Sample Input Message:

```javascript
{    
    "Case": {"ERPCode": {"value": -47}},
    "Creator":
    {       
        "ERPCode":{"value": 1} //m.sharifi
    },
    "Requestor": 
    {
        "ERPCode":{"value": 1} //m.sharifi
    },
    "Process": 
    {
        "ERPCode":{"value": 2} //Admission
    },
    "Conditions":
    [
        {
            "Tag": {"ERPCode":{"value": 302}, "Name":{"value": "SendRequest"}},
            "Operand": {"ERPCode":{"value": 1}, "Name":{"value": "="}},
            "Value":{"value": "1"}
        }
    ]
}
```

## * gRPC Sample Output Message:
```javascript
{
    "Case": {
        "Id": {
            "value": "60020"
        },
        "ERPCode": {
            "value": "-47"
        },
        "SortIndex": {
            "value": "0"
        },
        "CreateTimeRecord": {
            "seconds": "1701618732",
            "nanos": 3655700
        },
        "LastUpdatedRecord": {
            "seconds": "1701618733",
            "nanos": 356567700
        }
    },
    "OutputState": {
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
            "value": ""
        },
        "DisplayName": {
            "value": "درخواست با شماره رهیگری 60020 با موفقیت در چیتا ثبت شد"
        }
    }
}
```