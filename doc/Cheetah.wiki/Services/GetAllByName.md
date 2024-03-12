## * rpc General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | gRPC proto3     |
| Broker Server Name  | localhost: 5000 |
| Project Version     | 8.2.100         |
| Service Name        | GetAllByName    |

## * Grpc Messages
    
| Title | Value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
| --- | --- |
| Request Message Class Name  | GetAllByName_Input |
| Request Message             | {GRPC_BaseClassWithName TableInput = 1;} |
| Response Message Class Name | GetAllByName_Output |
| Response Message            | {GRPC_BaseClassWithName TableInput = 1;repeated GRPC_BaseClassWithName TableOutput = 2;GRPC_BaseClassWithName OutputState = 3;} |

## * CRUD Matrix
     
| Table Name     | Operation | Description                                                            |
| ---            | ---       | ---                                                                    |
| D_Entity       | Read      | ---                                                                    |


## * gRPC Sample Input Message:

```javascript
{
    "TableInput": {
        "Name": {"value": "D_CaseState"}
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
                "value": "Initializing"
            },
            "DisplayName": {
                "value": "مقداردهی اولیه"
            }
        },
        {
            "Id": {
                "value": "2"
            },
            "ERPCode": {
                "value": "2"
            },
            "SortIndex": {
                "value": "2"
            },
            "Name": {
                "value": "Ongoing"
            },
            "DisplayName": {
                "value": "در دست بررسی"
            }
        },
        {
            "Id": {
                "value": "3"
            },
            "ERPCode": {
                "value": "3"
            },
            "SortIndex": {
                "value": "3"
            },
            "Name": {
                "value": "Editing"
            },
            "DisplayName": {
                "value": "منتظر بازنگری"
            }
        },
        {
            "Id": {
                "value": "4"
            },
            "ERPCode": {
                "value": "4"
            },
            "SortIndex": {
                "value": "4"
            },
            "Name": {
                "value": "Completed"
            },
            "DisplayName": {
                "value": "کامل شده"
            }
        },
        {
            "Id": {
                "value": "5"
            },
            "ERPCode": {
                "value": "5"
            },
            "SortIndex": {
                "value": "5"
            },
            "Name": {
                "value": "Rejected"
            },
            "DisplayName": {
                "value": "عدم تایید"
            }
        },
        {
            "Id": {
                "value": "6"
            },
            "ERPCode": {
                "value": "6"
            },
            "SortIndex": {
                "value": "6"
            },
            "Name": {
                "value": "Aborted"
            },
            "DisplayName": {
                "value": "ابطال شده"
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
            "value": "D_CaseState"
        },
        "DisplayName": {
            "value": "وضعیت فرآیندها(Dimentions)"
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