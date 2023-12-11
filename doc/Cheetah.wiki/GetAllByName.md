* rpc General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | gRPC proto3     |
| Broker Server Name  | localhost: 5000 |
| Project Version     | 1.0.15          |
| Service Name        | GetAllByName    |

* Grpc Messages

| Title | Value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
| --- | --- |
| Request Message Class Name  | GetAllByName_Input |
| Request Message             | {GRPC_BaseClassWithName TableInput = 1;} |
| Response Message Class Name | GetAllByName_Output |
| Response Message            | {GRPC_BaseClassWithName TableInput = 1;repeated GRPC_BaseClassWithName TableOutput = 2;GRPC_BaseClassWithName OutputState = 3;} |

* Grpc Custom Messages:

| Message Name   | Message Implementation |
| ---            | ---                    |
| GRPC_BaseClass | {google.protobuf.Int64Value Id = 1;google.protobuf.Int64Value ERPCode = 2;google.protobuf.StringValue Name = 3;google.protobuf.StringValue DisplayName = 4;google.protobuf.Timestamp CreateTimeRecord = 5; google.protobuf.Timestamp LastUpdatedRecord = 6;} |

## * gRPC Sample Input Message:

```javascript
{
    "TableInput": {
        "Name": {"value": "D_Tag"}
    }
}
```

## * gRPC Sample Output Message:

```javascript
{
    "TableOutput": [
        {
            "Id": {
                "value": "1"
            },
            "ERPCode": {
                "value": "1"
            },
            "SortIndex": {
                "value": "1"
            },
            "Name": {
                "value": "D_Location"
            },
            "DisplayName": {
                "value": "مرکز"
            }
        },
        {
            "Id": {
                "value": "201"
            },
            "ERPCode": {
                "value": "201"
            },
            "SortIndex": {
                "value": "201"
            },
            "Name": {
                "value": "Approve"
            },
            "DisplayName": {
                "value": "تایید"
            }
        },
        {
            "Id": {
                "value": "202"
            },
            "ERPCode": {
                "value": "202"
            },
            "SortIndex": {
                "value": "202"
            },
            "Name": {
                "value": "Reject"
            },
            "DisplayName": {
                "value": "عدم تایید"
            }
        },
        {
            "Id": {
                "value": "203"
            },
            "ERPCode": {
                "value": "203"
            },
            "SortIndex": {
                "value": "203"
            },
            "Name": {
                "value": "Edit"
            },
            "DisplayName": {
                "value": "رد"
            }
        },
        {
            "Id": {
                "value": "301"
            },
            "ERPCode": {
                "value": "301"
            },
            "SortIndex": {
                "value": "301"
            },
            "Name": {
                "value": "Price"
            },
            "DisplayName": {
                "value": "مبلغ"
            }
        },
        {
            "Id": {
                "value": "302"
            },
            "ERPCode": {
                "value": "302"
            },
            "SortIndex": {
                "value": "302"
            },
            "Name": {
                "value": "SendRequest"
            },
            "DisplayName": {
                "value": "ارسال درخواست"
            }
        }
    ],
    "TableInput": {
        "Id": {
            "value": "104"
        },
        "ERPCode": {
            "value": "104"
        },
        "SortIndex": {
            "value": "104"
        },
        "Name": {
            "value": "D_Tag"
        },
        "DisplayName": {
            "value": "تگ‌ها(Dimentions)"
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
            "value": "GetAllByName"
        }
    }
}
```