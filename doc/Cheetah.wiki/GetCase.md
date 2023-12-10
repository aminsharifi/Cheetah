## * rpc General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | gRPC proto3     |
| Broker Server Name  | localhost: 5000 |
| Project Version     | 1.0.15          |
| Service Name        | GetCase         |

## * Grpc Messages

| Title | Value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
| --- | --- |
| Request Message Class Name  | GetCase_Input |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Request Message             | {GRPC_BaseClass Case = 1;} |
| Response Message Class Name | GetCase_Output |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Response Message            | {GRPC_BaseClass Case = 1;GRPC_BaseClassWithName CaseState = 2;GRPC_BaseClassWithName Process = 3;repeated GRPC_Endorsement Endorsements = 4;GRPC_BaseClassWithName OutputState = 5;} |

## * Grpc Custom Messages:

| Message Name   | Message Implementation |
| ---            | ---                    |
| GRPC_BaseClass | message GRPC_BaseClass{google.protobuf.Int64Value Id = 1;google.protobuf.Int64Value ERPCode = 2;google.protobuf.Int64Value SortIndex = 3;} |
| GRPC_BaseClassWithName | {google.protobuf.Int64Value Id = 1;google.protobuf.Int64Value ERPCode = 2;google.protobuf.Int64Value SortIndex = 3;google.protobuf.StringValue Name = 4;google.protobuf.StringValue DisplayName = 5;} |
| GRPC_Endorsement | {GRPC_BaseClassWithName Endorsement = 1;repeated GRPC_WorkItem WorkItems = 2;} |
| GRPC_WorkItem | {GRPC_BaseClassWithDate WorkItem = 1;GRPC_BaseClassWithName User = 2;GRPC_BaseClassWithName Tag = 3;GRPC_BaseClassWithName WorkItemState = 4;} |

## * gRPC Sample Input Message:

```javascript
{
    "Case": {"ERPCode": {"value": -38}}
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
                            "value": "60122"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "0"
                        },
                        "CreateTimeRecord": {
                            "seconds": "1701518764",
                            "nanos": 228383100
                        },
                        "LastUpdatedRecord": {
                            "seconds": "1701518769",
                            "nanos": 616823000
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
                            "value": "60123"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "0"
                        },
                        "CreateTimeRecord": {
                            "seconds": "1701518764",
                            "nanos": 382918800
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
                            "value": "60124"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "0"
                        },
                        "CreateTimeRecord": {
                            "seconds": "1701518764",
                            "nanos": 386786100
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
                            "value": "60125"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "0"
                        },
                        "CreateTimeRecord": {
                            "seconds": "1701518764",
                            "nanos": 389841200
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
                            "value": "60126"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "0"
                        },
                        "CreateTimeRecord": {
                            "seconds": "1701518764",
                            "nanos": 392858300
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
                            "value": "60127"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "0"
                        },
                        "CreateTimeRecord": {
                            "seconds": "1701518764",
                            "nanos": 392871700
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
                            "value": "60128"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "0"
                        },
                        "CreateTimeRecord": {
                            "seconds": "1701518764",
                            "nanos": 395887800
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
                            "value": "60129"
                        },
                        "ERPCode": {
                            "value": "0"
                        },
                        "SortIndex": {
                            "value": "0"
                        },
                        "CreateTimeRecord": {
                            "seconds": "1701518764",
                            "nanos": 399959200
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
            "value": "50017"
        },
        "ERPCode": {
            "value": "-43"
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