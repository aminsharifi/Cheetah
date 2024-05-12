## * rpc General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | WebAPI		    |
| Broker Server Name  | localhost: 1991 |
| Project Version     | 8.2.100         |
| Service Name        | Inbox           |

## * Grpc Messages

| Title | Value |
| ---   | ---   |
| Request Message Class Name  | Cartable_Input |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Request Message             | {google.protobuf.Int64Value PageNumber = 1;google.protobuf.Int64Value PageSize  = 2;google.protobuf.Int64Value TotalItems  = 3;GRPC_BaseClassWithName Assignee = 4;GRPC_BaseClassWithName Process = 5;GRPC_BaseClass Case  = 6;GRPC_BaseClassWithName CaseState = 7;GRPC_BaseClass WorkItem  = 8;} |
| Response Message Class Name | Cartable_Output |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Response Message            | {google.protobuf.Int64Value PageNumber = 1;google.protobuf.Int64Value PageSize  = 2;google.protobuf.Int64Value TotalItems  = 3;repeated GRPC_Case Cases = 4;GRPC_BaseClassWithName OutputState = 5;} |

## * Description

This service is for receiving tasks in each user's inbox
Assignee is the person whose works in the inbox we want to be displayed.
PageSize is the number of records per page.
PageNumber is the desired page number
CaseState is the state of the request, which is optional
Case Id is the tracking number of the request, which is optional
Process is the considered process which is optional.
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
    //"Assignee": { "Name": "AdmissionManager"},
    "Assignee": { "ERPCode":-7},
    //"Process": { "Name": "Admission"},
    //"Process": { "ERPCode": -2},
    "PageNumber": 1,
    "PageSize": 20,
    "CaseState":
    {
        "ERPCode": 2 
    }
    ,"Case": 
    {
        //"Id": 94
        "ERPCode": -285
    }
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
                "created": "2024-05-08T13:11:39.8732626+03:30",
                "lastModified": null,
                "id": 88,
                "erpCode": -284,
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
                        "displayName": "پخش درخواست",
                        "id": 4,
                        "erpCode": null,
                        "sortIndex": null,
                        "enableRecord": true
                    },
                    "performers": null,
                    "validUserActions": [
                        {
                            "base": {
                                "name": "ReviewState = SendRequest",
                                "displayName": "ارسال درخواست",
                                "id": 23,
                                "erpCode": -23,
                                "sortIndex": null,
                                "enableRecord": true
                            },
                            "tag": null,
                            "operand": null,
                            "value": null
                        }
                    ],
                    "workItems": [
                        {
                            "base": {
                                "created": "2024-05-08T13:11:40.1438749+03:30",
                                "lastModified": null,
                                "id": 871,
                                "erpCode": null,
                                "sortIndex": null,
                                "enableRecord": true
                            },
                            "user": {
                                "name": "AdmissionManager",
                                "displayName": "مدیر پذیرش",
                                "id": 7,
                                "erpCode": -7,
                                "sortIndex": null,
                                "enableRecord": true
                            },
                            "workItemState": {
                                "name": "Inbox",
                                "displayName": "صندوق ورودی",
                                "id": 1,
                                "erpCode": 1,
                                "sortIndex": null,
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