## * gRPC General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | WebAPI		    |
| Broker Server Name  | localhost: 1991 |
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
    "Case": {"ERPCode": -284},
    "Creator":
    {
        //"Name": "m.sharifi"
        "ERPCode": -1 //
    },
    "Requestor": 
    {
        //"Name": "m.sharifi"
        "ERPCode":-1 //m.sharifi
    },
    "Process": 
    {
        //"Name": "Admission"
        "ERPCode": -2
    },
    "WorkItem":
    {
        "OccurredUserActions":
        [
            {
                "Tag":
                {
                    "ERPCode":-12
                    //"Name":"ReviewState"
                },
                "Operand":
                {
                    "ERPCode":-1
                    // "Name":  "="
                },
                "Value":"SendRequest"
            }
        ],
        "User":
        {
            //"Name": "m.sharifi"
            "ERPCode": -1 
        }
    }
}
```

## * gRPC Sample Output Message:
```javascript
{
    "case": {
        "base": {
            "created": "2024-05-08T13:11:39.8732626+03:30",
            "lastModified": null,
            "id": 88,
            "erpCode": -284,
            "sortIndex": 0,
            "enableRecord": true
        },
        "processId": 2,
        "creatorId": 1,
        "requestorId": 1,
        "tasks": [
            {
                "base": {
                    "name": "",
                    "displayName": "ثبت درخواست",
                    "id": 3,
                    "erpCode": null,
                    "sortIndex": 1,
                    "enableRecord": true
                },
                "performers": [
                    {
                        "base": {
                            "name": "Role = AdmissionRequestor",
                            "displayName": "کارگذاری",
                            "id": 29,
                            "erpCode": -29,
                            "sortIndex": 28,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "Role",
                            "displayName": "نقش",
                            "id": 5,
                            "erpCode": -5,
                            "sortIndex": 5,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "AdmissionRequestor"
                    }
                ],
                "validUserActions": [
                    {
                        "base": {
                            "name": "ReviewState = SendRequest",
                            "displayName": "ارسال درخواست",
                            "id": 23,
                            "erpCode": -23,
                            "sortIndex": 23,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "ReviewState",
                            "displayName": "وضعیت بررسی",
                            "id": 12,
                            "erpCode": -12,
                            "sortIndex": 12,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "SendRequest"
                    }
                ],
                "workItems": [
                    {
                        "base": {
                            "created": "2024-05-08T13:11:39.8733882+03:30",
                            "lastModified": null,
                            "id": 870,
                            "erpCode": null,
                            "sortIndex": 0,
                            "enableRecord": true
                        },
                        "user": {
                            "name": null,
                            "displayName": null,
                            "id": 1,
                            "erpCode": null,
                            "sortIndex": null,
                            "enableRecord": null
                        },
                        "workItemState": {
                            "name": "Sent",
                            "displayName": "ارسال شده",
                            "id": 2,
                            "erpCode": 2,
                            "sortIndex": 2,
                            "enableRecord": true
                        },
                        "occurredUserActions": [
                            {
                                "base": {
                                    "name": "ReviewState = SendRequest",
                                    "displayName": "ارسال درخواست",
                                    "id": 23,
                                    "erpCode": -23,
                                    "sortIndex": 23,
                                    "enableRecord": true
                                },
                                "tag": {
                                    "name": "ReviewState",
                                    "displayName": "وضعیت بررسی",
                                    "id": 12,
                                    "erpCode": -12,
                                    "sortIndex": 12,
                                    "enableRecord": true
                                },
                                "operand": {
                                    "name": "=",
                                    "displayName": "مساوی",
                                    "id": 1,
                                    "erpCode": -1,
                                    "sortIndex": 1,
                                    "enableRecord": true
                                },
                                "value": "SendRequest"
                            },
                            {
                                "base": {
                                    "name": null,
                                    "displayName": null,
                                    "id": 23,
                                    "erpCode": null,
                                    "sortIndex": null,
                                    "enableRecord": null
                                },
                                "tag": null,
                                "operand": null,
                                "value": null
                            }
                        ]
                    }
                ]
            },
            {
                "base": {
                    "name": "",
                    "displayName": "پخش درخواست",
                    "id": 4,
                    "erpCode": null,
                    "sortIndex": 2,
                    "enableRecord": true
                },
                "performers": [
                    {
                        "base": {
                            "name": "Role = AdmissionManager",
                            "displayName": "مدیر پذیرش",
                            "id": 24,
                            "erpCode": -24,
                            "sortIndex": 24,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "Role",
                            "displayName": "نقش",
                            "id": 5,
                            "erpCode": -5,
                            "sortIndex": 5,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "AdmissionManager"
                    }
                ],
                "validUserActions": [
                    {
                        "base": {
                            "name": "ReviewState = SendRequest",
                            "displayName": "ارسال درخواست",
                            "id": 23,
                            "erpCode": -23,
                            "sortIndex": 23,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "ReviewState",
                            "displayName": "وضعیت بررسی",
                            "id": 12,
                            "erpCode": -12,
                            "sortIndex": 12,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "SendRequest"
                    }
                ],
                "workItems": [
                    {
                        "base": {
                            "created": "2024-05-08T13:11:40.1438749+03:30",
                            "lastModified": null,
                            "id": 871,
                            "erpCode": null,
                            "sortIndex": 0,
                            "enableRecord": true
                        },
                        "user": {
                            "name": null,
                            "displayName": null,
                            "id": 7,
                            "erpCode": null,
                            "sortIndex": null,
                            "enableRecord": null
                        },
                        "workItemState": {
                            "name": "Inbox",
                            "displayName": "صندوق ورودی",
                            "id": 1,
                            "erpCode": 1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "occurredUserActions": []
                    }
                ]
            },
            {
                "base": {
                    "name": "",
                    "displayName": "کارشناس پذیرش",
                    "id": 5,
                    "erpCode": null,
                    "sortIndex": 3,
                    "enableRecord": true
                },
                "performers": [
                    {
                        "base": {
                            "name": "Role = AdmissionSpecialist",
                            "displayName": "کارشناس پذیرش",
                            "id": 25,
                            "erpCode": -25,
                            "sortIndex": 25,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "Role",
                            "displayName": "نقش",
                            "id": 5,
                            "erpCode": -5,
                            "sortIndex": 5,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "AdmissionSpecialist"
                    }
                ],
                "validUserActions": [
                    {
                        "base": {
                            "name": "ReviewState = Approve",
                            "displayName": "تایید",
                            "id": 20,
                            "erpCode": -20,
                            "sortIndex": 20,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "ReviewState",
                            "displayName": "وضعیت بررسی",
                            "id": 12,
                            "erpCode": -12,
                            "sortIndex": 12,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "Approve"
                    },
                    {
                        "base": {
                            "name": "ReviewState = Reject",
                            "displayName": "رد",
                            "id": 21,
                            "erpCode": -21,
                            "sortIndex": 21,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "ReviewState",
                            "displayName": "وضعیت بررسی",
                            "id": 12,
                            "erpCode": -12,
                            "sortIndex": 12,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "Reject"
                    }
                ],
                "workItems": [
                    {
                        "base": {
                            "created": "2024-05-08T13:11:40.1723116+03:30",
                            "lastModified": null,
                            "id": 872,
                            "erpCode": null,
                            "sortIndex": 0,
                            "enableRecord": true
                        },
                        "user": {
                            "name": null,
                            "displayName": null,
                            "id": 5,
                            "erpCode": null,
                            "sortIndex": null,
                            "enableRecord": null
                        },
                        "workItemState": {
                            "name": "Future",
                            "displayName": "آینده",
                            "id": 4,
                            "erpCode": 4,
                            "sortIndex": 4,
                            "enableRecord": true
                        },
                        "occurredUserActions": []
                    },
                    {
                        "base": {
                            "created": "2024-05-08T13:11:40.1723172+03:30",
                            "lastModified": null,
                            "id": 873,
                            "erpCode": null,
                            "sortIndex": 0,
                            "enableRecord": true
                        },
                        "user": {
                            "name": null,
                            "displayName": null,
                            "id": 6,
                            "erpCode": null,
                            "sortIndex": null,
                            "enableRecord": null
                        },
                        "workItemState": {
                            "name": "Future",
                            "displayName": "آینده",
                            "id": 4,
                            "erpCode": 4,
                            "sortIndex": 4,
                            "enableRecord": true
                        },
                        "occurredUserActions": []
                    }
                ]
            },
            {
                "base": {
                    "name": "",
                    "displayName": "تایید کارشناس پذیرش و بررسی مدیر",
                    "id": 6,
                    "erpCode": null,
                    "sortIndex": 4,
                    "enableRecord": true
                },
                "performers": [
                    {
                        "base": {
                            "name": "Role = AdmissionManager",
                            "displayName": "مدیر پذیرش",
                            "id": 24,
                            "erpCode": -24,
                            "sortIndex": 24,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "Role",
                            "displayName": "نقش",
                            "id": 5,
                            "erpCode": -5,
                            "sortIndex": 5,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "AdmissionManager"
                    }
                ],
                "validUserActions": [
                    {
                        "base": {
                            "name": "ReviewState = Approve",
                            "displayName": "تایید",
                            "id": 20,
                            "erpCode": -20,
                            "sortIndex": 20,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "ReviewState",
                            "displayName": "وضعیت بررسی",
                            "id": 12,
                            "erpCode": -12,
                            "sortIndex": 12,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "Approve"
                    },
                    {
                        "base": {
                            "name": "ReviewState = Reject",
                            "displayName": "رد",
                            "id": 21,
                            "erpCode": -21,
                            "sortIndex": 21,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "ReviewState",
                            "displayName": "وضعیت بررسی",
                            "id": 12,
                            "erpCode": -12,
                            "sortIndex": 12,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "Reject"
                    }
                ],
                "workItems": [
                    {
                        "base": {
                            "created": "2024-05-08T13:11:40.1978222+03:30",
                            "lastModified": null,
                            "id": 874,
                            "erpCode": null,
                            "sortIndex": 0,
                            "enableRecord": true
                        },
                        "user": {
                            "name": null,
                            "displayName": null,
                            "id": 7,
                            "erpCode": null,
                            "sortIndex": null,
                            "enableRecord": null
                        },
                        "workItemState": {
                            "name": "Future",
                            "displayName": "آینده",
                            "id": 4,
                            "erpCode": 4,
                            "sortIndex": 4,
                            "enableRecord": true
                        },
                        "occurredUserActions": []
                    }
                ]
            },
            {
                "base": {
                    "name": "",
                    "displayName": "رد کارشناس پذیرش و بررسی مدیر",
                    "id": 7,
                    "erpCode": null,
                    "sortIndex": 5,
                    "enableRecord": true
                },
                "performers": [
                    {
                        "base": {
                            "name": "Role = AdmissionManager",
                            "displayName": "مدیر پذیرش",
                            "id": 24,
                            "erpCode": -24,
                            "sortIndex": 24,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "Role",
                            "displayName": "نقش",
                            "id": 5,
                            "erpCode": -5,
                            "sortIndex": 5,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "AdmissionManager"
                    }
                ],
                "validUserActions": [
                    {
                        "base": {
                            "name": "ReviewState = Approve",
                            "displayName": "تایید",
                            "id": 20,
                            "erpCode": -20,
                            "sortIndex": 20,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "ReviewState",
                            "displayName": "وضعیت بررسی",
                            "id": 12,
                            "erpCode": -12,
                            "sortIndex": 12,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "Approve"
                    },
                    {
                        "base": {
                            "name": "ReviewState = Reject",
                            "displayName": "رد",
                            "id": 21,
                            "erpCode": -21,
                            "sortIndex": 21,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "ReviewState",
                            "displayName": "وضعیت بررسی",
                            "id": 12,
                            "erpCode": -12,
                            "sortIndex": 12,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "Reject"
                    }
                ],
                "workItems": [
                    {
                        "base": {
                            "created": "2024-05-08T13:11:40.2203809+03:30",
                            "lastModified": null,
                            "id": 875,
                            "erpCode": null,
                            "sortIndex": 0,
                            "enableRecord": true
                        },
                        "user": {
                            "name": null,
                            "displayName": null,
                            "id": 7,
                            "erpCode": null,
                            "sortIndex": null,
                            "enableRecord": null
                        },
                        "workItemState": {
                            "name": "Future",
                            "displayName": "آینده",
                            "id": 4,
                            "erpCode": 4,
                            "sortIndex": 4,
                            "enableRecord": true
                        },
                        "occurredUserActions": []
                    }
                ]
            },
            {
                "base": {
                    "name": "",
                    "displayName": "ویرایش درخواست",
                    "id": 8,
                    "erpCode": null,
                    "sortIndex": 6,
                    "enableRecord": true
                },
                "performers": [
                    {
                        "base": {
                            "name": "Role = AdmissionRequestor",
                            "displayName": "کارگذاری",
                            "id": 29,
                            "erpCode": -29,
                            "sortIndex": 28,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "Role",
                            "displayName": "نقش",
                            "id": 5,
                            "erpCode": -5,
                            "sortIndex": 5,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "AdmissionRequestor"
                    }
                ],
                "validUserActions": [
                    {
                        "base": {
                            "name": "ReviewState = SendRequest",
                            "displayName": "ارسال درخواست",
                            "id": 23,
                            "erpCode": -23,
                            "sortIndex": 23,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "ReviewState",
                            "displayName": "وضعیت بررسی",
                            "id": 12,
                            "erpCode": -12,
                            "sortIndex": 12,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "SendRequest"
                    }
                ],
                "workItems": [
                    {
                        "base": {
                            "created": "2024-05-08T13:11:40.2522549+03:30",
                            "lastModified": null,
                            "id": 876,
                            "erpCode": null,
                            "sortIndex": 0,
                            "enableRecord": true
                        },
                        "user": {
                            "name": null,
                            "displayName": null,
                            "id": 1,
                            "erpCode": null,
                            "sortIndex": null,
                            "enableRecord": null
                        },
                        "workItemState": {
                            "name": "Future",
                            "displayName": "آینده",
                            "id": 4,
                            "erpCode": 4,
                            "sortIndex": 4,
                            "enableRecord": true
                        },
                        "occurredUserActions": []
                    },
                    {
                        "base": {
                            "created": "2024-05-08T13:11:40.2522693+03:30",
                            "lastModified": null,
                            "id": 877,
                            "erpCode": null,
                            "sortIndex": 0,
                            "enableRecord": true
                        },
                        "user": {
                            "name": null,
                            "displayName": null,
                            "id": 2,
                            "erpCode": null,
                            "sortIndex": null,
                            "enableRecord": null
                        },
                        "workItemState": {
                            "name": "Future",
                            "displayName": "آینده",
                            "id": 4,
                            "erpCode": 4,
                            "sortIndex": 4,
                            "enableRecord": true
                        },
                        "occurredUserActions": []
                    }
                ]
            },
            {
                "base": {
                    "name": "",
                    "displayName": "بررسی معاونت پذیرش",
                    "id": 9,
                    "erpCode": null,
                    "sortIndex": 7,
                    "enableRecord": true
                },
                "performers": [
                    {
                        "base": {
                            "name": "Role = AdmissionVice",
                            "displayName": "معاون پذیرش",
                            "id": 26,
                            "erpCode": -26,
                            "sortIndex": 26,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "Role",
                            "displayName": "نقش",
                            "id": 5,
                            "erpCode": -5,
                            "sortIndex": 5,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "AdmissionVice"
                    }
                ],
                "validUserActions": [
                    {
                        "base": {
                            "name": "ReviewState = Approve",
                            "displayName": "تایید",
                            "id": 20,
                            "erpCode": -20,
                            "sortIndex": 20,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "ReviewState",
                            "displayName": "وضعیت بررسی",
                            "id": 12,
                            "erpCode": -12,
                            "sortIndex": 12,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "Approve"
                    },
                    {
                        "base": {
                            "name": "ReviewState = Reject",
                            "displayName": "رد",
                            "id": 21,
                            "erpCode": -21,
                            "sortIndex": 21,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "ReviewState",
                            "displayName": "وضعیت بررسی",
                            "id": 12,
                            "erpCode": -12,
                            "sortIndex": 12,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "Reject"
                    }
                ],
                "workItems": [
                    {
                        "base": {
                            "created": "2024-05-08T13:11:40.2744048+03:30",
                            "lastModified": null,
                            "id": 878,
                            "erpCode": null,
                            "sortIndex": 0,
                            "enableRecord": true
                        },
                        "user": {
                            "name": null,
                            "displayName": null,
                            "id": 4,
                            "erpCode": null,
                            "sortIndex": null,
                            "enableRecord": null
                        },
                        "workItemState": {
                            "name": "Future",
                            "displayName": "آینده",
                            "id": 4,
                            "erpCode": 4,
                            "sortIndex": 4,
                            "enableRecord": true
                        },
                        "occurredUserActions": []
                    }
                ]
            },
            {
                "base": {
                    "name": "",
                    "displayName": "بررسی هیات پذیرش",
                    "id": 10,
                    "erpCode": null,
                    "sortIndex": 8,
                    "enableRecord": true
                },
                "performers": [
                    {
                        "base": {
                            "name": "Role = AdmissionBoard",
                            "displayName": "هیات پذیرش",
                            "id": 27,
                            "erpCode": -27,
                            "sortIndex": 27,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "Role",
                            "displayName": "نقش",
                            "id": 5,
                            "erpCode": -5,
                            "sortIndex": 5,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "AdmissionBoard"
                    }
                ],
                "validUserActions": [
                    {
                        "base": {
                            "name": "ReviewState = Approve",
                            "displayName": "تایید",
                            "id": 20,
                            "erpCode": -20,
                            "sortIndex": 20,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "ReviewState",
                            "displayName": "وضعیت بررسی",
                            "id": 12,
                            "erpCode": -12,
                            "sortIndex": 12,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "Approve"
                    },
                    {
                        "base": {
                            "name": "ReviewState = Reject",
                            "displayName": "رد",
                            "id": 21,
                            "erpCode": -21,
                            "sortIndex": 21,
                            "enableRecord": true
                        },
                        "tag": {
                            "name": "ReviewState",
                            "displayName": "وضعیت بررسی",
                            "id": 12,
                            "erpCode": -12,
                            "sortIndex": 12,
                            "enableRecord": true
                        },
                        "operand": {
                            "name": "=",
                            "displayName": "مساوی",
                            "id": 1,
                            "erpCode": -1,
                            "sortIndex": 1,
                            "enableRecord": true
                        },
                        "value": "Reject"
                    }
                ],
                "workItems": [
                    {
                        "base": {
                            "created": "2024-05-08T13:11:40.2961264+03:30",
                            "lastModified": null,
                            "id": 879,
                            "erpCode": null,
                            "sortIndex": 0,
                            "enableRecord": true
                        },
                        "user": {
                            "name": null,
                            "displayName": null,
                            "id": 3,
                            "erpCode": null,
                            "sortIndex": null,
                            "enableRecord": null
                        },
                        "workItemState": {
                            "name": "Future",
                            "displayName": "آینده",
                            "id": 4,
                            "erpCode": 4,
                            "sortIndex": 4,
                            "enableRecord": true
                        },
                        "occurredUserActions": []
                    }
                ]
            }
        ],
        "caseState": {
            "name": "Ongoing",
            "displayName": "در دست بررسی",
            "id": 2,
            "erpCode": 2,
            "sortIndex": 2,
            "enableRecord": true
        }
    },
    "outputState": {
        "name": null,
        "displayName": "درخواست با شماره رهیگری 88 با موفقیت در چیتا ثبت شد",
        "id": 0,
        "erpCode": 0,
        "sortIndex": null,
        "enableRecord": true
    }
}
```