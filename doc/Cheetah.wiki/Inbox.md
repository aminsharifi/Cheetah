* rpc General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | gRPC proto3     |
| Broker Server Name  | localhost: 5000 |
| Project Version     | 1.0.15          |
| Service Name        | Inbox           |

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
    "Assignee": { "Name": {"value": "AdmisionManager"}},
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "2"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1696869900",
                    "nanos": 521638600
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "10003"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1698250343",
                    "nanos": 58557400
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "10011"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1698250390",
                    "nanos": 230463300
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "10019"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1698250567",
                    "nanos": 481423500
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "20003"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1698667578",
                    "nanos": 362763500
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "30003"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1698834316",
                    "nanos": 34542500
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "40003"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700411881",
                    "nanos": 894114800
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "40011"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700411985",
                    "nanos": 818828900
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "40019"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700412026",
                    "nanos": 131562400
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "40027"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700412088",
                    "nanos": 839055200
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "40035"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700412161",
                    "nanos": 337540600
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "40043"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700412196",
                    "nanos": 510664700
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "40051"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700413516",
                    "nanos": 641847600
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "50067"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700909396",
                    "nanos": 806930800
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "50075"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1700909502",
                    "nanos": 92173000
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "50091"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1701014947",
                    "nanos": 704620200
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "40014"
                },
                "ERPCode": {
                    "value": "-32"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1701014965",
                    "nanos": 337494100
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "50099"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1701014965",
                    "nanos": 442433800
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "40015"
                },
                "ERPCode": {
                    "value": "-33"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1701015101",
                    "nanos": 541968100
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "50107"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1701015102",
                    "nanos": 500652000
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "40016"
                },
                "ERPCode": {
                    "value": "-34"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1701015171",
                    "nanos": 5609100
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "50115"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1701015171",
                    "nanos": 115598500
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
                    "value": "40017"
                },
                "ERPCode": {
                    "value": "-35"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1701015178",
                    "nanos": 627851100
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
                    "value": "4"
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
                    "value": "پخش درخواست"
                }
            },
            "WorkItem": {
                "Id": {
                    "value": "50123"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "CreateTimeRecord": {
                    "seconds": "1701015178",
                    "nanos": 646138300
                },
                "LastUpdatedRecord": null
            },
            "Assignee": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "0"
                },
                "Name": {
                    "value": "AdmisionManager"
                },
                "DisplayName": {
                    "value": "مدیر پذیرش"
                }
            },
            "Tag": {
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
                    "value": ""
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
        "value": "31"
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