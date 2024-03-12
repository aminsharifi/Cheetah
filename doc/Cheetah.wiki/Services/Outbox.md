* rpc General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | gRPC proto3     |
| Broker Server Name  | localhost: 5000 |
| Project Version     | 8.2.100         |
| Service Name        | Outbox          |

* Grpc Messages

| Title | Value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
| --- | --- |
| Request Message Class Name  | Cartable_Input |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Request Message             | {google.protobuf.Int64Value PageNumber = 1;google.protobuf.Int64Value PageSize  = 2;google.protobuf.Int64Value TotalItems  = 3;GRPC_BaseClassWithName Assignee = 4;GRPC_BaseClassWithName CaseState = 5;GRPC_BaseClassWithName Process = 6;GRPC_BaseClass Case  = 7;GRPC_BaseClass WorkItem  = 8;} |
| Response Message Class Name | Cartable_Output |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Response Message            | {google.protobuf.Int64Value PageNumber = 1;google.protobuf.Int64Value PageSize  = 2;google.protobuf.Int64Value TotalItems  = 3;repeated RecordCartable RecordCartables = 4;GRPC_BaseClassWithName OutputState = 5;} |

* Grpc Custom Messages:

| Message Name   | Message Implementation |
| ---            | ---                    |
| GRPC_BaseClass | {google.protobuf.Int64Value Id = 1;google.protobuf.Int64Value ERPCode = 2;google.protobuf.StringValue Name = 3;google.protobuf.StringValue DisplayName = 4;google.protobuf.Timestamp CreateTimeRecord = 5; google.protobuf.Timestamp LastUpdatedRecord = 6;} |
| RecordCartable | { GRPC_BaseClass D_Tag = 1; GRPC_BaseClass Requestor  = 2; google.protobuf.Int64Value CaseId  = 3; google.protobuf.Int64Value WorkItemId  = 4; google.protobuf.Timestamp CreateDate  = 5; google.protobuf.Timestamp RecieveDate = 6; GRPC_BaseClass Process = 7; GRPC_BaseClass Task = 8; GRPC_BaseClass CaseState = 9; repeated GRPC_BaseClass ValidUserActions = 10; google.protobuf.StringValue Summary = 11; google.protobuf.Int64Value ERPCode = 12; GRPC_BaseClass WorkItem  = 13; } |

## * gRPC Sample Input Message:

```javascript
{
    "Assignee": { "Name": {"value": "m.sharifi"}},
    "Process": { "Name": {"value":"Admission"}},
    "PageNumber": {"value": 1},
    "PageSize": {"value":20},  
    "CaseState": {
        "ERPCode": {"value":"1"}
    }    
}
```

## * gRPC Sample Output Message:

```javascript
{
    "RecordCartables": [
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "-1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1696869897",
                    "nanos": 194577300
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1696869900",
                    "nanos": 372700600
                },
                "LastUpdatedRecord": {
                    "seconds": "1696869902",
                    "nanos": 173804600
                }
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "-10"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1698250339",
                    "nanos": 143762900
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "10002"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1698250342",
                    "nanos": 909593600
                },
                "LastUpdatedRecord": {
                    "seconds": "1698250344",
                    "nanos": 869285300
                }
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "3"
                },
                "ERPCode": {
                    "value": "-11"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1698250388",
                    "nanos": 10154700
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "10010"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1698250390",
                    "nanos": 214609300
                },
                "LastUpdatedRecord": {
                    "seconds": "1698250392",
                    "nanos": 875708200
                }
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "-12"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1698250567",
                    "nanos": 474554500
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "10018"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1698250567",
                    "nanos": 478815500
                },
                "LastUpdatedRecord": {
                    "seconds": "1698250567",
                    "nanos": 494727600
                }
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "10002"
                },
                "ERPCode": {
                    "value": "-15"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1698667577",
                    "nanos": 623275500
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "20002"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1698667578",
                    "nanos": 219424400
                },
                "LastUpdatedRecord": {
                    "seconds": "1698667578",
                    "nanos": 396163300
                }
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "10003"
                },
                "ERPCode": {
                    "value": "-16"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1698668216",
                    "nanos": 849372800
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "20010"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1698668216",
                    "nanos": 855829300
                },
                "LastUpdatedRecord": {
                    "seconds": "1698668216",
                    "nanos": 877333600
                }
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "20002"
                },
                "ERPCode": {
                    "value": "-17"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1698834315",
                    "nanos": 462277300
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "30002"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1698834315",
                    "nanos": 908240000
                },
                "LastUpdatedRecord": {
                    "seconds": "1698834316",
                    "nanos": 69699900
                }
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "30002"
                },
                "ERPCode": {
                    "value": "-18"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700411877",
                    "nanos": 822754000
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "40002"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700411878",
                    "nanos": 280846800
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "30003"
                },
                "ERPCode": {
                    "value": "-19"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700411985",
                    "nanos": 362348200
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "40010"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700411985",
                    "nanos": 662379300
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "30004"
                },
                "ERPCode": {
                    "value": "-20"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700412021",
                    "nanos": 16782900
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "40018"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700412026",
                    "nanos": 105999100
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "30005"
                },
                "ERPCode": {
                    "value": "-21"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700412088",
                    "nanos": 375018200
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "40026"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700412088",
                    "nanos": 680787000
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "30006"
                },
                "ERPCode": {
                    "value": "-22"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700412160",
                    "nanos": 725435700
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "40034"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700412161",
                    "nanos": 173438800
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "30007"
                },
                "ERPCode": {
                    "value": "-23"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700412196",
                    "nanos": 462508000
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "40042"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700412196",
                    "nanos": 483762400
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "30008"
                },
                "ERPCode": {
                    "value": "-24"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700413515",
                    "nanos": 986227600
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "40050"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700413516",
                    "nanos": 476588500
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "30009"
                },
                "ERPCode": {
                    "value": "-25"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700492300",
                    "nanos": 234242200
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "40058"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700492300",
                    "nanos": 454949000
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "40009"
                },
                "ERPCode": {
                    "value": "-26"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700908849",
                    "nanos": 310916700
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "50058"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700908849",
                    "nanos": 661444100
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "40010"
                },
                "ERPCode": {
                    "value": "-27"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700909396",
                    "nanos": 713886000
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "50066"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700909396",
                    "nanos": 787950800
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "40011"
                },
                "ERPCode": {
                    "value": "-28"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700909502",
                    "nanos": 38682900
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "50074"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700909502",
                    "nanos": 65687300
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "40012"
                },
                "ERPCode": {
                    "value": "-30"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700909936",
                    "nanos": 801586600
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "50082"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700909936",
                    "nanos": 833119000
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        },
        {
            "ValidUserActions": [
                {
                    "Id": {
                        "value": "302"
                    },
                    "ERPCode": {
                        "value": "302"
                    },
                    "SortIndex": {
                        "value": "0"
                    },
                    "Name": {
                        "value": "SendRequest"
                    },
                    "DisplayName": {
                        "value": "ارسال درخواست"
                    }
                }
            ],
            "Process": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "2"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Admission"
                },
                "DisplayName": {
                    "value": "پذیرش"
                }
            },
            "Case": {
                "Id": {
                    "value": "40013"
                },
                "ERPCode": {
                    "value": "-31"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1701014931",
                    "nanos": 790191800
                },
                "LastUpdatedRecord": null
            },
            "CaseState": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
                }
            },
            "Requestor": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Endorsement": {
                "Id": {
                    "value": "3"
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
                    "value": "ثبت درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "50090"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1701014947",
                    "nanos": 543692200
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "1"
                },
                "ERPCode": {
                    "value": "1"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "m.sharifi"
                },
                "DisplayName": {
                    "value": "محمد شریفی"
                }
            },
            "Tag": {
                "Id": {
                    "value": "302"
                },
                "ERPCode": {
                    "value": "302"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "SendRequest"
                },
                "DisplayName": {
                    "value": "ارسال درخواست"
                }
            }
        }
    ],
    "PageNumber": {
        "value": "1"
    },
    "PageSize": {
        "value": "20"
    },
    "TotalItems": {
        "value": "35"
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
            "value": "Cartable"
        }
    }
}

```