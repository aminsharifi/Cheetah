* rpc General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | gRPC proto3     |
| Broker Server Name  | localhost: 5000 |
| Project Version     | 1.0.15          |
| Service Name        | PerformRequest  |

* Grpc Messages

| Title | Value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
| --- | --- |
| Request Message Class Name  | PerformRequest_Input |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Request Message             | {GRPC_BaseClass WorkItem = 1;repeated Condition Conditions = 2;} |
| Response Message Class Name | PerformRequest_Output |
| Response Message            | {GRPC_BaseClass Case = 1;GRPC_BaseClass Process = 2;GRPC_BaseClass CaseState = 3;GRPC_BaseClassWithName OutputState = 4;} |

* Grpc Custom Messages:

| Message Name   | Message Implementation |
| ---            | ---                    |
| GRPC_BaseClass | {google.protobuf.Int64Value Id = 1;google.protobuf.Int64Value ERPCode = 2;google.protobuf.StringValue Name = 3;google.protobuf.StringValue DisplayName = 4;google.protobuf.Timestamp CreateTimeRecord = 5; google.protobuf.Timestamp LastUpdatedRecord = 6;} |
| Condition      | { GRPC_BaseClass Tag = 1; GRPC_BaseClass Operand = 2; google.protobuf.StringValue Value = 3; GRPC_BaseClass User = 4; GRPC_BaseClass Base = 5;} |

## * gRPC Sample Input Message:

```javascript
{
    "WorkItemId": {"value":"50083"},    
    "Conditions":
    [
        {
            "Tag": {"ERPCode": {"value": "302"}, "Name": {"value": "SendRequest"}},
            "Operand": {"ERPCode": {"value":1}, "Name": {"value":"="}},
            "Value": {"value":"1"},
            //"User": {"ERPCode": {"value":10004}, "Name": {"value":"AdmisionManager"}}
            "User": {"Name": {"value":"AdmisionManager"}}
        }
    ]
}
```

## * gRPC Sample Output Message:

```javascript
{
    "Endorsements": [
        {
            "WorkItems": [
                {
                    "WorkItem": {
                        "Id": {
                            "value": "70146"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "0"
                        },
                        "CreateTimeRecord": {
                            "seconds": "1701618733",
                            "nanos": 59700800
                        },
                        "LastUpdatedRecord": {
                            "seconds": "1701618733",
                            "nanos": 356402200
                        }
                    },
                    "User": {
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
                            "value": "302"
                        },
                        "Name": {
                            "value": "SendRequest"
                        },
                        "DisplayName": {
                            "value": "ارسال درخواست"
                        }
                    },
                    "WorkItemState": {
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
                            "value": "Sent"
                        },
                        "DisplayName": {
                            "value": "ارسال شده"
                        }
                    }
                }
            ],
            "Endorsement": {
                "Id": {
                    "value": "3"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "1"
                },
                "Name": {
                    "value": ""
                },
                "DisplayName": {
                    "value": "ثبت درخواست"
                }
            }
        },
        {
            "WorkItems": [
                {
                    "WorkItem": {
                        "Id": {
                            "value": "70147"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "0"
                        },
                        "CreateTimeRecord": {
                            "seconds": "1701618733",
                            "nanos": 280870100
                        },
                        "LastUpdatedRecord": null
                    },
                    "User": {
                        "Id": {
                            "value": "4"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "4"
                        },
                        "Name": {
                            "value": "AdmisionManager"
                        },
                        "DisplayName": {
                            "value": "مدیر پذیرش"
                        }
                    },
                    "Tag": {
                        "Id": null,
                        "ERPCode": null,
                        "SortIndex": null,
                        "Name": null,
                        "DisplayName": null
                    },
                    "WorkItemState": {
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
                            "value": "Inbox"
                        },
                        "DisplayName": {
                            "value": "صندوق ورودی"
                        }
                    }
                }
            ],
            "Endorsement": {
                "Id": {
                    "value": "4"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "2"
                },
                "Name": {
                    "value": ""
                },
                "DisplayName": {
                    "value": "پخش درخواست"
                }
            }
        },
        {
            "WorkItems": [
                {
                    "WorkItem": {
                        "Id": {
                            "value": "70148"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "0"
                        },
                        "CreateTimeRecord": {
                            "seconds": "1701618733",
                            "nanos": 310074800
                        },
                        "LastUpdatedRecord": null
                    },
                    "User": {
                        "Id": {
                            "value": "3"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "3"
                        },
                        "Name": {
                            "value": "AdmissionSpecialist"
                        },
                        "DisplayName": {
                            "value": "کارشناس پذیرش"
                        }
                    },
                    "Tag": {
                        "Id": null,
                        "ERPCode": null,
                        "SortIndex": null,
                        "Name": null,
                        "DisplayName": null
                    },
                    "WorkItemState": {
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
                            "value": "Future"
                        },
                        "DisplayName": {
                            "value": "آینده"
                        }
                    }
                }
            ],
            "Endorsement": {
                "Id": {
                    "value": "5"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "3"
                },
                "Name": {
                    "value": ""
                },
                "DisplayName": {
                    "value": "کارشناس پذیرش"
                }
            }
        },
        {
            "WorkItems": [
                {
                    "WorkItem": {
                        "Id": {
                            "value": "70149"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "0"
                        },
                        "CreateTimeRecord": {
                            "seconds": "1701618733",
                            "nanos": 323170400
                        },
                        "LastUpdatedRecord": null
                    },
                    "User": {
                        "Id": {
                            "value": "4"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "4"
                        },
                        "Name": {
                            "value": "AdmisionManager"
                        },
                        "DisplayName": {
                            "value": "مدیر پذیرش"
                        }
                    },
                    "Tag": {
                        "Id": null,
                        "ERPCode": null,
                        "SortIndex": null,
                        "Name": null,
                        "DisplayName": null
                    },
                    "WorkItemState": {
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
                            "value": "Future"
                        },
                        "DisplayName": {
                            "value": "آینده"
                        }
                    }
                }
            ],
            "Endorsement": {
                "Id": {
                    "value": "6"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "4"
                },
                "Name": {
                    "value": ""
                },
                "DisplayName": {
                    "value": "تایید کارشناس و بررسی مدیر پذیرش"
                }
            }
        },
        {
            "WorkItems": [
                {
                    "WorkItem": {
                        "Id": {
                            "value": "70150"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "0"
                        },
                        "CreateTimeRecord": {
                            "seconds": "1701618733",
                            "nanos": 328449000
                        },
                        "LastUpdatedRecord": null
                    },
                    "User": {
                        "Id": {
                            "value": "4"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "4"
                        },
                        "Name": {
                            "value": "AdmisionManager"
                        },
                        "DisplayName": {
                            "value": "مدیر پذیرش"
                        }
                    },
                    "Tag": {
                        "Id": null,
                        "ERPCode": null,
                        "SortIndex": null,
                        "Name": null,
                        "DisplayName": null
                    },
                    "WorkItemState": {
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
                            "value": "Future"
                        },
                        "DisplayName": {
                            "value": "آینده"
                        }
                    }
                }
            ],
            "Endorsement": {
                "Id": {
                    "value": "10"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "5"
                },
                "Name": {
                    "value": ""
                },
                "DisplayName": {
                    "value": "رد کارشناس و بررسی مدیر پذیرش"
                }
            }
        },
        {
            "WorkItems": [
                {
                    "WorkItem": {
                        "Id": {
                            "value": "70151"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "0"
                        },
                        "CreateTimeRecord": {
                            "seconds": "1701618733",
                            "nanos": 328471200
                        },
                        "LastUpdatedRecord": null
                    },
                    "User": {
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
                            "value": "m.sharifi"
                        },
                        "DisplayName": {
                            "value": "محمد شریفی"
                        }
                    },
                    "Tag": {
                        "Id": null,
                        "ERPCode": null,
                        "SortIndex": null,
                        "Name": null,
                        "DisplayName": null
                    },
                    "WorkItemState": {
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
                            "value": "Future"
                        },
                        "DisplayName": {
                            "value": "آینده"
                        }
                    }
                }
            ],
            "Endorsement": {
                "Id": {
                    "value": "7"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "6"
                },
                "Name": {
                    "value": ""
                },
                "DisplayName": {
                    "value": "ویرایش درخواست"
                }
            }
        },
        {
            "WorkItems": [
                {
                    "WorkItem": {
                        "Id": {
                            "value": "70152"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "0"
                        },
                        "CreateTimeRecord": {
                            "seconds": "1701618733",
                            "nanos": 333065900
                        },
                        "LastUpdatedRecord": null
                    },
                    "User": {
                        "Id": {
                            "value": "5"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "5"
                        },
                        "Name": {
                            "value": "AdmissionAssistant"
                        },
                        "DisplayName": {
                            "value": "معاونت پذیرش"
                        }
                    },
                    "Tag": {
                        "Id": null,
                        "ERPCode": null,
                        "SortIndex": null,
                        "Name": null,
                        "DisplayName": null
                    },
                    "WorkItemState": {
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
                            "value": "Future"
                        },
                        "DisplayName": {
                            "value": "آینده"
                        }
                    }
                }
            ],
            "Endorsement": {
                "Id": {
                    "value": "8"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "7"
                },
                "Name": {
                    "value": ""
                },
                "DisplayName": {
                    "value": "بررسی معاونت پذیرش"
                }
            }
        },
        {
            "WorkItems": [
                {
                    "WorkItem": {
                        "Id": {
                            "value": "70153"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "0"
                        },
                        "CreateTimeRecord": {
                            "seconds": "1701618733",
                            "nanos": 344118700
                        },
                        "LastUpdatedRecord": null
                    },
                    "User": {
                        "Id": {
                            "value": "6"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "6"
                        },
                        "Name": {
                            "value": "AdmissionBoard"
                        },
                        "DisplayName": {
                            "value": "هیات پذیرش"
                        }
                    },
                    "Tag": {
                        "Id": null,
                        "ERPCode": null,
                        "SortIndex": null,
                        "Name": null,
                        "DisplayName": null
                    },
                    "WorkItemState": {
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
                            "value": "Future"
                        },
                        "DisplayName": {
                            "value": "آینده"
                        }
                    }
                }
            ],
            "Endorsement": {
                "Id": {
                    "value": "9"
                },
                "ERPCode": {
                    "value": "0"
                },
                "SortIndex": {
                    "value": "8"
                },
                "Name": {
                    "value": ""
                },
                "DisplayName": {
                    "value": "بررسی هیات پذیرش"
                }
            }
        }
    ],
    "Case": {
        "Id": {
            "value": "60020"
        },
        "ERPCode": {
            "value": "-47"
        },
        "SortIndex": {
            "value": "0"
        }
    },
    "CaseState": {
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
            "value": "Ongoing"
        },
        "DisplayName": {
            "value": "در دست بررسی"
        }
    },
    "Process": {
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
            "value": "Admission"
        },
        "DisplayName": {
            "value": "پذیرش"
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
            "value": "GetCase"
        }
    }
}
```