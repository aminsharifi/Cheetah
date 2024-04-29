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
    "Case": {"ERPCode": -268},
    "Creator":
    {
        "ERPCode": -1 //m.sharifi
    },
    "Requestor": 
    {
        "ERPCode":-1 //m.sharifi
    },
    "Process": 
    {
        "Name": "Admission"
    },
    "WorkItem":
    {
        "OccurredUserActions":
        [
            {
                "Tag": {"Name":"ReviewState"},
                "Operand": {"Name":  "="},
                "Value":"SendRequest"
            }
        ],
        "User": {"Name":"m.sharifi"}
    }
}
```

## * gRPC Sample Output Message:
```javascript
{
    "case": {
        "base": {
            "created": "2024-04-29T14:43:31.1930148+03:30",
            "lastModified": "2024-04-29T14:43:31.4719914+03:30",
            "id": 58,
            "erpCode": -268,
            "sortIndex": 0,
            "enableRecord": true
        },
        "processId": 2,
        "creatorId": 1,
        "requestorId": 1,
        "tasks": [
            {
                "base": {
                    "name": null,
                    "displayName": null,
                    "id": 3,
                    "erpCode": null,
                    "sortIndex": null,
                    "enableRecord": null
                },
                "workItems": [
                    {
                        "base": {
                            "created": "2024-04-29T14:43:31.1931274+03:30",
                            "lastModified": "2024-04-29T14:43:31.4916358+03:30",
                            "id": 571,
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
                    "name": null,
                    "displayName": null,
                    "id": 4,
                    "erpCode": null,
                    "sortIndex": null,
                    "enableRecord": null
                },
                "workItems": [
                    {
                        "base": {
                            "created": "2024-04-29T14:43:31.291656+03:30",
                            "lastModified": null,
                            "id": 572,
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
                    "name": null,
                    "displayName": null,
                    "id": 5,
                    "erpCode": null,
                    "sortIndex": null,
                    "enableRecord": null
                },
                "workItems": [
                    {
                        "base": {
                            "created": "2024-04-29T14:43:31.3157296+03:30",
                            "lastModified": null,
                            "id": 573,
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
                            "created": "2024-04-29T14:43:31.31574+03:30",
                            "lastModified": null,
                            "id": 574,
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
                    "name": null,
                    "displayName": null,
                    "id": 6,
                    "erpCode": null,
                    "sortIndex": null,
                    "enableRecord": null
                },
                "workItems": [
                    {
                        "base": {
                            "created": "2024-04-29T14:43:31.3650578+03:30",
                            "lastModified": null,
                            "id": 575,
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
                    "name": null,
                    "displayName": null,
                    "id": 7,
                    "erpCode": null,
                    "sortIndex": null,
                    "enableRecord": null
                },
                "workItems": [
                    {
                        "base": {
                            "created": "2024-04-29T14:43:31.3988775+03:30",
                            "lastModified": null,
                            "id": 576,
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
                    "name": null,
                    "displayName": null,
                    "id": 8,
                    "erpCode": null,
                    "sortIndex": null,
                    "enableRecord": null
                },
                "workItems": [
                    {
                        "base": {
                            "created": "2024-04-29T14:43:31.4249779+03:30",
                            "lastModified": null,
                            "id": 577,
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
                            "created": "2024-04-29T14:43:31.4249868+03:30",
                            "lastModified": null,
                            "id": 578,
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
                    "name": null,
                    "displayName": null,
                    "id": 9,
                    "erpCode": null,
                    "sortIndex": null,
                    "enableRecord": null
                },
                "workItems": [
                    {
                        "base": {
                            "created": "2024-04-29T14:43:31.4480379+03:30",
                            "lastModified": null,
                            "id": 579,
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
                    "name": null,
                    "displayName": null,
                    "id": 10,
                    "erpCode": null,
                    "sortIndex": null,
                    "enableRecord": null
                },
                "workItems": [
                    {
                        "base": {
                            "created": "2024-04-29T14:43:31.4718532+03:30",
                            "lastModified": null,
                            "id": 580,
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
        "displayName": "درخواست با شماره رهیگری 58 با موفقیت در چیتا ثبت شد",
        "id": 0,
        "erpCode": 0,
        "sortIndex": null,
        "enableRecord": true
    }
}
```