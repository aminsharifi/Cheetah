* rpc General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | gRPC proto3     |
| Broker Server Name  | localhost: 5000 |
| Project Version     | 8.2.100         |
| Service Name        | Inbox           |

* Grpc Messages

| Title | Value |
| ---   | ---   |
| Request Message Class Name  | Cartable_Input |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Request Message             | {google.protobuf.Int64Value PageNumber = 1;google.protobuf.Int64Value PageSize  = 2;google.protobuf.Int64Value TotalItems  = 3;GRPC_BaseClassWithName Assignee = 4;GRPC_BaseClassWithName Process = 5;GRPC_BaseClass Case  = 6;GRPC_BaseClassWithName CaseState = 7;GRPC_BaseClass WorkItem  = 8;} |
| Response Message Class Name | Cartable_Output |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Response Message            | {google.protobuf.Int64Value PageNumber = 1;google.protobuf.Int64Value PageSize  = 2;google.protobuf.Int64Value TotalItems  = 3;repeated GRPC_Case Cases = 4;GRPC_BaseClassWithName OutputState = 5;} |

## * CRUD Matrix
     
| Table Name     | Operation | Description                                                            |
| ---            | ---       | ---                                                                    |
| D_User         | Read      | creator & requestor, workItem's performer, L_UserConditions            |
| D_Process      | Read      | current process                                                        |
| F_Condition    | Read      | workItem's condition, TaskConditions, FlowConditions, L_UserConditions |
| D_Tag          | Read      | condition's tag                                                        |
| D_Operand      | Read      | operand's tag                                                          |
| F_Case         | Read      | current case                                                           |
| F_Scenario     | Read      | processScenario                                                        |
| F_Task         | Read      | scenario's task, taskConditions, taskFlows, flowTasks                  |
| F_Flow         | Read      | taskFlows, flowConditions, flowTasks                                   |
| D_CaseState    | Read      | state of case                                                          |
| F_WorkItem     | Read      | case's workItems, L_WorkItemCondition                                  |
| WorkItemState  | Read      | workItem's state                                                       |
| L_CaseTaskUser | Read      | Read manual user selection                                             |

## * gRPC Sample Input Message:

```javascript
{
    "Assignee": { "Name": {"value": "AdmissionManager"}},
    "Process": { "Name": {"value":"Admission"}},
    "PageNumber": {"value": 1},
    "PageSize": {"value":20},  
    "CaseState": {
        "ERPCode": {"value": 2 }
    },
    "Case": {"Id": {"value": 1}}
}
```

## * gRPC Sample Output Message:

```javascript
{
    "Cases": [
        {
            "Tasks": [
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
                                    "value": "2"
                                },
                                "ERPCode": {
                                    "value": "0"
                                },
                                "SortIndex": {
                                    "value": "0"
                                },
                                "CreateTimeRecord": {
                                    "seconds": "1709535046",
                                    "nanos": 131326100
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
                                    "value": "0"
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
                                    "value": "0"
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
                            "value": "0"
                        },
                        "Name": {
                            "value": ""
                        },
                        "DisplayName": {
                            "value": "پخش درخواست"
                        }
                    }
                }
            ],
            "Base": {
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
                    "seconds": "1709535045",
                    "nanos": 59103800
                },
                "LastUpdatedRecord": {
                    "seconds": "1709535046",
                    "nanos": 158548100
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
                    "value": "0"
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
                    "value": "0"
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
                    "value": "0"
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
                    "value": "0"
                },
                "Name": {
                    "value": "Ongoing"
                },
                "DisplayName": {
                    "value": "در دست بررسی"
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
        "value": "1"
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