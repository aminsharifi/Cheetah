## * gRPC General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | gRPC proto3     |
| Broker Server Name  | localhost: 5000 |
| Project Version     | 8.2.100         |
| Service Name        | CreateRequest   |

 
## * gRPC Messages
     
| Title | Value |
| --- | --- |
| Request Message Class Name  | CreateRequest_Input |
| Request Message             | {GRPC_BaseClass Case = 1;GRPC_BaseClassWithName Creator = 2;GRPC_BaseClassWithName Requestor = 3;GRPC_BaseClassWithName Process = 4;repeated GRPC_Condition Conditions = 5;GRPC_WorkItem WorkItem = 6;} |
| Response Message Class Name | CreateRequest_Output|
| Response Message            | {GRPC_Case Case = 1;GRPC_BaseClassWithName OutputState = 2;} |

## * Description

This service is used to create a new request
ERPCode, which is in Case, is actually the request ID in the base system
The creator is the person who creates the request.
The requestor is the person for whom the application is made.
The process is specified in the service.
If the process has conditions, these conditions are defined; Conditions are used for two purposes, first to determine the scenario and second to determine the user
A workitem is created for each person that is in the flow; In this workitem, it is determined which user the work belongs to, and with OccurredUserActions, it is determined what actions the user has performed.
The output of the service is the created case.

## * CRUD Matrix
     
| Table Name     | Operation | Description                                                            |
| ---            | ---       | ---                                                                    |
| D_User         | Read      | creator & requestor, workItem's performer, L_UserConditions            |
| D_Process      | Read      | current process                                                        |
| F_Condition    | Read      | workItem's condition, TaskConditions, FlowConditions, L_UserConditions |
| D_Tag          | Read      | condition's tag                                                        |
| D_Operand      | Read      | operand's tag                                                          |
| F_Case         | Write     | current case                                                           |
| F_Scenario     | Read      | processScenario                                                        |
| F_Task         | Read      | scenario's task, taskConditions, taskFlows, flowTasks                  |
| F_Flow         | Read      | taskFlows, flowConditions, flowTasks                                   |
| D_CaseState    | Read      | state of case                                                          |
| F_WorkItem     | Write     | case's workItems, L_WorkItemCondition                                  |
| WorkItemState  | Read      | workItem's state                                                       |
| L_CaseTaskUser | Read      | Read manual user selection                                             |


## * gRPC Sample Input Message:

```javascript
{    
    "Case": {"ERPCode": {"value": -2}},
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
        "Name": {"value": "Admission"}
    },
    "Conditions":
    [
        {
            "Tag": {"Name":{"value": "StockType"}},
            "Operand": {"Name": {"value": "="}},
            "Value":{"value": "FirstStock"}
        }
    ],
    "WorkItem":
    {
        "OccurredUserActions":
        [
            {
                "Tag": {"Name":{"value": "ReviewState"}},
                "Operand": {"Name": {"value": "="}},
                "Value":{"value": "SendRequest"}
            }
        ],
        "User": {"Name": {"value":"m.sharifi"}}
    }
}
```

## * gRPC Sample Output Message:
```javascript
{
    "Case": {
        "Tasks": [
            {
                "WorkItems": [
                    {
                        "OccurredUserActions": [
                            {
                                "Base": {
                                    "Id": {
                                        "value": "23"
                                    },
                                    "ERPCode": {
                                        "value": "23"
                                    },
                                    "SortIndex": {
                                        "value": "23"
                                    },
                                    "Name": {
                                        "value": "ReviewState = SendRequest"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی SendRequest است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "SendRequest"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "23"
                                    },
                                    "ERPCode": {
                                        "value": "23"
                                    },
                                    "SortIndex": {
                                        "value": "23"
                                    },
                                    "Name": {
                                        "value": "ReviewState = SendRequest"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی SendRequest است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "SendRequest"
                                }
                            }
                        ],
                        "ValidUserActions": [
                            {
                                "Base": {
                                    "Id": {
                                        "value": "23"
                                    },
                                    "ERPCode": {
                                        "value": "23"
                                    },
                                    "SortIndex": {
                                        "value": "23"
                                    },
                                    "Name": {
                                        "value": "ReviewState = SendRequest"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی SendRequest است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "SendRequest"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "23"
                                    },
                                    "ERPCode": {
                                        "value": "23"
                                    },
                                    "SortIndex": {
                                        "value": "23"
                                    },
                                    "Name": {
                                        "value": "ReviewState = SendRequest"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی SendRequest است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "SendRequest"
                                }
                            }
                        ],
                        "Base": {
                            "Id": {
                                "value": "11"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710225726",
                                "nanos": 667339400
                            },
                            "LastUpdatedRecord": {
                                "seconds": "1710225727",
                                "nanos": 402068400
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
                "Base": {
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
                        "OccurredUserActions": [],
                        "ValidUserActions": [
                            {
                                "Base": {
                                    "Id": {
                                        "value": "23"
                                    },
                                    "ERPCode": {
                                        "value": "23"
                                    },
                                    "SortIndex": {
                                        "value": "23"
                                    },
                                    "Name": {
                                        "value": "ReviewState = SendRequest"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی SendRequest است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "SendRequest"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "23"
                                    },
                                    "ERPCode": {
                                        "value": "23"
                                    },
                                    "SortIndex": {
                                        "value": "23"
                                    },
                                    "Name": {
                                        "value": "ReviewState = SendRequest"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی SendRequest است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "SendRequest"
                                }
                            }
                        ],
                        "Base": {
                            "Id": {
                                "value": "12"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710225727",
                                "nanos": 280295000
                            },
                            "LastUpdatedRecord": null
                        },
                        "User": {
                            "Id": {
                                "value": "7"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "7"
                            },
                            "Name": {
                                "value": "AdmissionManager"
                            },
                            "DisplayName": {
                                "value": "مدیر پذیرش"
                            }
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
                "Base": {
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
                        "OccurredUserActions": [],
                        "ValidUserActions": [
                            {
                                "Base": {
                                    "Id": {
                                        "value": "20"
                                    },
                                    "ERPCode": {
                                        "value": "20"
                                    },
                                    "SortIndex": {
                                        "value": "20"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Approve"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Approve است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Approve"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "21"
                                    },
                                    "ERPCode": {
                                        "value": "21"
                                    },
                                    "SortIndex": {
                                        "value": "21"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Reject"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Reject است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Reject"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "20"
                                    },
                                    "ERPCode": {
                                        "value": "20"
                                    },
                                    "SortIndex": {
                                        "value": "20"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Approve"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Approve است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Approve"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "21"
                                    },
                                    "ERPCode": {
                                        "value": "21"
                                    },
                                    "SortIndex": {
                                        "value": "21"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Reject"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Reject است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Reject"
                                }
                            }
                        ],
                        "Base": {
                            "Id": {
                                "value": "13"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710225727",
                                "nanos": 284297100
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
                                "value": "AdmissionSpecialist1"
                            },
                            "DisplayName": {
                                "value": "کارشناس پذیرش 1"
                            }
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
                    },
                    {
                        "OccurredUserActions": [],
                        "ValidUserActions": [
                            {
                                "Base": {
                                    "Id": {
                                        "value": "20"
                                    },
                                    "ERPCode": {
                                        "value": "20"
                                    },
                                    "SortIndex": {
                                        "value": "20"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Approve"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Approve است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Approve"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "21"
                                    },
                                    "ERPCode": {
                                        "value": "21"
                                    },
                                    "SortIndex": {
                                        "value": "21"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Reject"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Reject است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Reject"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "20"
                                    },
                                    "ERPCode": {
                                        "value": "20"
                                    },
                                    "SortIndex": {
                                        "value": "20"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Approve"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Approve است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Approve"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "21"
                                    },
                                    "ERPCode": {
                                        "value": "21"
                                    },
                                    "SortIndex": {
                                        "value": "21"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Reject"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Reject است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Reject"
                                }
                            }
                        ],
                        "Base": {
                            "Id": {
                                "value": "14"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710225727",
                                "nanos": 284303700
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
                                "value": "AdmissionSpecialist2"
                            },
                            "DisplayName": {
                                "value": "کارشناس پذیرش 2"
                            }
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
                "Base": {
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
                        "OccurredUserActions": [],
                        "ValidUserActions": [
                            {
                                "Base": {
                                    "Id": {
                                        "value": "20"
                                    },
                                    "ERPCode": {
                                        "value": "20"
                                    },
                                    "SortIndex": {
                                        "value": "20"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Approve"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Approve است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Approve"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "21"
                                    },
                                    "ERPCode": {
                                        "value": "21"
                                    },
                                    "SortIndex": {
                                        "value": "21"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Reject"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Reject است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Reject"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "20"
                                    },
                                    "ERPCode": {
                                        "value": "20"
                                    },
                                    "SortIndex": {
                                        "value": "20"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Approve"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Approve است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Approve"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "21"
                                    },
                                    "ERPCode": {
                                        "value": "21"
                                    },
                                    "SortIndex": {
                                        "value": "21"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Reject"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Reject است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Reject"
                                }
                            }
                        ],
                        "Base": {
                            "Id": {
                                "value": "15"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710225727",
                                "nanos": 287152100
                            },
                            "LastUpdatedRecord": null
                        },
                        "User": {
                            "Id": {
                                "value": "7"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "7"
                            },
                            "Name": {
                                "value": "AdmissionManager"
                            },
                            "DisplayName": {
                                "value": "مدیر پذیرش"
                            }
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
                "Base": {
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
                        "value": "تایید کارشناس پذیرش و بررسی مدیر"
                    }
                }
            },
            {
                "WorkItems": [
                    {
                        "OccurredUserActions": [],
                        "ValidUserActions": [
                            {
                                "Base": {
                                    "Id": {
                                        "value": "20"
                                    },
                                    "ERPCode": {
                                        "value": "20"
                                    },
                                    "SortIndex": {
                                        "value": "20"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Approve"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Approve است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Approve"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "21"
                                    },
                                    "ERPCode": {
                                        "value": "21"
                                    },
                                    "SortIndex": {
                                        "value": "21"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Reject"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Reject است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Reject"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "20"
                                    },
                                    "ERPCode": {
                                        "value": "20"
                                    },
                                    "SortIndex": {
                                        "value": "20"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Approve"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Approve است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Approve"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "21"
                                    },
                                    "ERPCode": {
                                        "value": "21"
                                    },
                                    "SortIndex": {
                                        "value": "21"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Reject"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Reject است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Reject"
                                }
                            }
                        ],
                        "Base": {
                            "Id": {
                                "value": "16"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710225727",
                                "nanos": 289795100
                            },
                            "LastUpdatedRecord": null
                        },
                        "User": {
                            "Id": {
                                "value": "7"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "7"
                            },
                            "Name": {
                                "value": "AdmissionManager"
                            },
                            "DisplayName": {
                                "value": "مدیر پذیرش"
                            }
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
                "Base": {
                    "Id": {
                        "value": "7"
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
                        "value": "رد کارشناس پذیرش و بررسی مدیر"
                    }
                }
            },
            {
                "WorkItems": [
                    {
                        "OccurredUserActions": [],
                        "ValidUserActions": [
                            {
                                "Base": {
                                    "Id": {
                                        "value": "23"
                                    },
                                    "ERPCode": {
                                        "value": "23"
                                    },
                                    "SortIndex": {
                                        "value": "23"
                                    },
                                    "Name": {
                                        "value": "ReviewState = SendRequest"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی SendRequest است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "SendRequest"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "23"
                                    },
                                    "ERPCode": {
                                        "value": "23"
                                    },
                                    "SortIndex": {
                                        "value": "23"
                                    },
                                    "Name": {
                                        "value": "ReviewState = SendRequest"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی SendRequest است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "SendRequest"
                                }
                            }
                        ],
                        "Base": {
                            "Id": {
                                "value": "17"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710225727",
                                "nanos": 292073700
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
                    },
                    {
                        "OccurredUserActions": [],
                        "ValidUserActions": [
                            {
                                "Base": {
                                    "Id": {
                                        "value": "23"
                                    },
                                    "ERPCode": {
                                        "value": "23"
                                    },
                                    "SortIndex": {
                                        "value": "23"
                                    },
                                    "Name": {
                                        "value": "ReviewState = SendRequest"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی SendRequest است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "SendRequest"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "23"
                                    },
                                    "ERPCode": {
                                        "value": "23"
                                    },
                                    "SortIndex": {
                                        "value": "23"
                                    },
                                    "Name": {
                                        "value": "ReviewState = SendRequest"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی SendRequest است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "SendRequest"
                                }
                            }
                        ],
                        "Base": {
                            "Id": {
                                "value": "18"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710225727",
                                "nanos": 292080700
                            },
                            "LastUpdatedRecord": null
                        },
                        "User": {
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
                                "value": "a.sharifi"
                            },
                            "DisplayName": {
                                "value": "امین شریفی"
                            }
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
                "Base": {
                    "Id": {
                        "value": "8"
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
                        "OccurredUserActions": [],
                        "ValidUserActions": [
                            {
                                "Base": {
                                    "Id": {
                                        "value": "20"
                                    },
                                    "ERPCode": {
                                        "value": "20"
                                    },
                                    "SortIndex": {
                                        "value": "20"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Approve"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Approve است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Approve"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "21"
                                    },
                                    "ERPCode": {
                                        "value": "21"
                                    },
                                    "SortIndex": {
                                        "value": "21"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Reject"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Reject است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Reject"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "20"
                                    },
                                    "ERPCode": {
                                        "value": "20"
                                    },
                                    "SortIndex": {
                                        "value": "20"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Approve"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Approve است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Approve"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "21"
                                    },
                                    "ERPCode": {
                                        "value": "21"
                                    },
                                    "SortIndex": {
                                        "value": "21"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Reject"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Reject است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Reject"
                                }
                            }
                        ],
                        "Base": {
                            "Id": {
                                "value": "19"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710225727",
                                "nanos": 294388800
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
                                "value": "AdmissionVice"
                            },
                            "DisplayName": {
                                "value": "معاونت پذیرش"
                            }
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
                "Base": {
                    "Id": {
                        "value": "9"
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
                        "OccurredUserActions": [],
                        "ValidUserActions": [
                            {
                                "Base": {
                                    "Id": {
                                        "value": "20"
                                    },
                                    "ERPCode": {
                                        "value": "20"
                                    },
                                    "SortIndex": {
                                        "value": "20"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Approve"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Approve است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Approve"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "21"
                                    },
                                    "ERPCode": {
                                        "value": "21"
                                    },
                                    "SortIndex": {
                                        "value": "21"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Reject"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Reject است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Reject"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "20"
                                    },
                                    "ERPCode": {
                                        "value": "20"
                                    },
                                    "SortIndex": {
                                        "value": "20"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Approve"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Approve است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Approve"
                                }
                            },
                            {
                                "Base": {
                                    "Id": {
                                        "value": "21"
                                    },
                                    "ERPCode": {
                                        "value": "21"
                                    },
                                    "SortIndex": {
                                        "value": "21"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Reject"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Reject است."
                                    }
                                },
                                "Tag": {
                                    "Id": {
                                        "value": "12"
                                    },
                                    "ERPCode": {
                                        "value": "12"
                                    },
                                    "SortIndex": {
                                        "value": "12"
                                    },
                                    "Name": {
                                        "value": "ReviewState"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی"
                                    }
                                },
                                "Operand": {
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
                                        "value": "="
                                    },
                                    "DisplayName": {
                                        "value": "مساوی"
                                    }
                                },
                                "Value": {
                                    "value": "Reject"
                                }
                            }
                        ],
                        "Base": {
                            "Id": {
                                "value": "20"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710225727",
                                "nanos": 296540500
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
                                "value": "AdmissionBoard"
                            },
                            "DisplayName": {
                                "value": "هیات پذیرش"
                            }
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
                "Base": {
                    "Id": {
                        "value": "10"
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
        "Base": {
            "Id": {
                "value": "2"
            },
            "ERPCode": {
                "value": "-2"
            },
            "SortIndex": {
                "value": "0"
            },
            "CreateTimeRecord": {
                "seconds": "1710225726",
                "nanos": 659821900
            },
            "LastUpdatedRecord": {
                "seconds": "1710225727",
                "nanos": 300891700
            }
        },
        "Process": {
            "Id": {
                "value": "2"
            },
            "ERPCode": {
                "value": "0"
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
        "Creator": {
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
        "Requestor": {
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
        "CaseState": {
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
            "value": "درخواست با شماره رهیگری 2 با موفقیت در چیتا ثبت شد"
        }
    }
}
```