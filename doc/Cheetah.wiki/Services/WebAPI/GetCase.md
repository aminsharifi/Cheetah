## * rpc General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | WebAPI		    |
| Broker Server Name  | localhost: 1991 |
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
      "Case": {"ERPCode": -252}
}
```

## * gRPC Sample Output Message:

```javascript
{
    "case": {
        "base": {
            "createTimeRecord": "2024-04-28T16:06:32.0694403+03:30",
            "lastUpdatedRecord": "2024-04-28T16:06:32.7334726+03:30",
            "id": 42,
            "erpCode": -252,
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
                            "createTimeRecord": "2024-04-28T16:06:32.0695649+03:30",
                            "lastUpdatedRecord": "2024-04-28T16:06:32.9658094+03:30",
                            "id": 411,
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
                            "createTimeRecord": "2024-04-28T16:06:32.510404+03:30",
                            "lastUpdatedRecord": null,
                            "id": 412,
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
                            "createTimeRecord": "2024-04-28T16:06:32.5599576+03:30",
                            "lastUpdatedRecord": null,
                            "id": 413,
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
                            "createTimeRecord": "2024-04-28T16:06:32.559964+03:30",
                            "lastUpdatedRecord": null,
                            "id": 414,
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
                            "createTimeRecord": "2024-04-28T16:06:32.5978211+03:30",
                            "lastUpdatedRecord": null,
                            "id": 415,
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
                            "createTimeRecord": "2024-04-28T16:06:32.6278327+03:30",
                            "lastUpdatedRecord": null,
                            "id": 416,
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
                            "createTimeRecord": "2024-04-28T16:06:32.6729164+03:30",
                            "lastUpdatedRecord": null,
                            "id": 417,
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
                            "createTimeRecord": "2024-04-28T16:06:32.6729251+03:30",
                            "lastUpdatedRecord": null,
                            "id": 418,
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
                            "createTimeRecord": "2024-04-28T16:06:32.7018244+03:30",
                            "lastUpdatedRecord": null,
                            "id": 419,
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
                            "createTimeRecord": "2024-04-28T16:06:32.7307685+03:30",
                            "lastUpdatedRecord": null,
                            "id": 420,
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
        "displayName": "GetCase",
        "id": 0,
        "erpCode": 0,
        "sortIndex": null,
        "enableRecord": true
    }
}
```