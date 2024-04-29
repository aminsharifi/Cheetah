## * rpc General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | WebAPI		    |
| Broker Server Name  | localhost: 1991 |
| Project Version     | 8.2.100         |
| Service Name        | Outbox          |

## * Grpc Messages

| Title | Value |
| ---   | ---   |
| Request Message Class Name  | Cartable_Input |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Request Message             | {google.protobuf.Int64Value PageNumber = 1;google.protobuf.Int64Value PageSize  = 2;google.protobuf.Int64Value TotalItems  = 3;GRPC_BaseClassWithName Assignee = 4;GRPC_BaseClassWithName Process = 5;GRPC_BaseClass Case  = 6;GRPC_BaseClassWithName CaseState = 7;GRPC_BaseClass WorkItem  = 8;} |
| Response Message Class Name | Cartable_Output |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Response Message            | {google.protobuf.Int64Value PageNumber = 1;google.protobuf.Int64Value PageSize  = 2;google.protobuf.Int64Value TotalItems  = 3;repeated GRPC_Case Cases = 4;GRPC_BaseClassWithName OutputState = 5;} |

## * Description

This service is for receiving tasks in each user's outbox
Assignee is the person whose works in the inbox we want to be displayed.
Page size is the number of records displayed on a page.
PageNumber is the desired page number
Case State is the state of the request, which is optional
Case Id is the tracking number of the request, which is optional
The process can be considered as an optional element.
The output of the service is the cases inside the individual's cartable

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
    "Assignee": { "Name": "m.sharifi"},
    "Process": { "Name": "Admission"},
    "PageNumber": 1,
    "PageSize": 20,
    "CaseState":
    {
        "ERPCode": 2 
    },
    "Case": {"Id": 42}
}
```

## * gRPC Sample Output Message:

```javascript
{
    "pageNumber": 1,
    "pageSize": 20,
    "totalItems": 1,
    "cases": [
        {
            "base": {
                "createTimeRecord": "2024-04-28T16:06:32.0694403+03:30",
                "lastUpdatedRecord": "2024-04-28T16:06:32.7334726+03:30",
                "id": 42,
                "erpCode": -252,
                "sortIndex": null,
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
                        "sortIndex": null,
                        "enableRecord": true
                    },
                    "workItems": [
                        {
                            "base": {
                                "createTimeRecord": "2024-04-28T16:06:32.0695649+03:30",
                                "lastUpdatedRecord": "2024-04-28T16:06:32.9658094+03:30",
                                "id": 411,
                                "erpCode": null,
                                "sortIndex": null,
                                "enableRecord": true
                            },
                            "user": {
                                "name": "m.sharifi",
                                "displayName": "محمد شریفی",
                                "id": 1,
                                "erpCode": -1,
                                "sortIndex": null,
                                "enableRecord": true
                            },
                            "workItemState": {
                                "name": "Sent",
                                "displayName": "ارسال شده",
                                "id": 2,
                                "erpCode": 2,
                                "sortIndex": null,
                                "enableRecord": true
                            },
                            "occurredUserActions": null
                        }
                    ]
                }
            ],
            "caseState": {
                "name": "Ongoing",
                "displayName": "در دست بررسی",
                "id": 2,
                "erpCode": 2,
                "sortIndex": null,
                "enableRecord": true
            }
        }
    ],
    "outputState": {
        "name": null,
        "displayName": "Cartable",
        "id": 0,
        "erpCode": 0,
        "sortIndex": null,
        "enableRecord": true
    }
}
```