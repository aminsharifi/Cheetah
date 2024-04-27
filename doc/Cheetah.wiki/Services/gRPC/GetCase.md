## * rpc General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | gRPC proto3     |
| Broker Server Name  | localhost: 5000 |
| Project Version     | 8.2.100         |
| Service Name        | GetCase         |


## * Grpc Messages

| Title | Value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
| --- | --- |
| Request Message Class Name  | GetCase_Input |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Request Message             | {GRPC_BaseClass Case = 1;GRPC_BaseClassWithName CaseState = 2;GRPC_BaseClassWithName Process = 3;} |
| Response Message Class Name | GetCase_Output |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Response Message            | {GRPC_Case Case = 1;GRPC_BaseClassWithName OutputState = 2;} |

## * Description

This service is for receiving a case
Case ID is the tracking number of the request, which is optional.
The Case State is the state of the request that is not mandatory
The output of the service is the cases in the individual's cartable

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
    "Case": {"Id": {"value": -12}},
    "CaseState": {"ERPCode": {"value": 2}}
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
                                "value": "51"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710239488",
                                "nanos": 277230400
                            },
                            "LastUpdatedRecord": {
                                "seconds": "1710239489",
                                "nanos": 253488800
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
                                "value": "52"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710239489",
                                "nanos": 134263200
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
                                "value": "53"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710239489",
                                "nanos": 134279200
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
                                        "value": "22"
                                    },
                                    "ERPCode": {
                                        "value": "22"
                                    },
                                    "SortIndex": {
                                        "value": "22"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Revise"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Revise است."
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
                                    "value": "Revise"
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
                                        "value": "22"
                                    },
                                    "ERPCode": {
                                        "value": "22"
                                    },
                                    "SortIndex": {
                                        "value": "22"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Revise"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Revise است."
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
                                    "value": "Revise"
                                }
                            }
                        ],
                        "Base": {
                            "Id": {
                                "value": "54"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710239489",
                                "nanos": 140673100
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
                                        "value": "22"
                                    },
                                    "ERPCode": {
                                        "value": "22"
                                    },
                                    "SortIndex": {
                                        "value": "22"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Revise"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Revise است."
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
                                    "value": "Revise"
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
                                        "value": "22"
                                    },
                                    "ERPCode": {
                                        "value": "22"
                                    },
                                    "SortIndex": {
                                        "value": "22"
                                    },
                                    "Name": {
                                        "value": "ReviewState = Revise"
                                    },
                                    "DisplayName": {
                                        "value": "وضعیت بررسی مساوی Revise است."
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
                                    "value": "Revise"
                                }
                            }
                        ],
                        "Base": {
                            "Id": {
                                "value": "55"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710239489",
                                "nanos": 140687500
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
                                "value": "56"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710239489",
                                "nanos": 143259400
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
                                "value": "57"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710239489",
                                "nanos": 143285200
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
                                "value": "58"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710239489",
                                "nanos": 145792200
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
                                "value": "59"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710239489",
                                "nanos": 145798300
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
                                "value": "60"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710239489",
                                "nanos": 150794300
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
                                "value": "61"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710239489",
                                "nanos": 156445700
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
                                "value": "62"
                            },
                            "ERPCode": {
                                "value": "0"
                            },
                            "SortIndex": {
                                "value": "0"
                            },
                            "CreateTimeRecord": {
                                "seconds": "1710239489",
                                "nanos": 159171200
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
                "value": "6"
            },
            "ERPCode": {
                "value": "-12"
            },
            "SortIndex": {
                "value": "0"
            },
            "CreateTimeRecord": {
                "seconds": "1710239488",
                "nanos": 252519600
            },
            "LastUpdatedRecord": {
                "seconds": "1710239489",
                "nanos": 163820400
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
            "value": "GetCase"
        }
    }
}
```