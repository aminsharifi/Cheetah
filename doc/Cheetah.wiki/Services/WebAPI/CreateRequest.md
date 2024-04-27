## * gRPC General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | gRPC proto3     |
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
    "Case": {"ERPCode": -216},
    "Creator":
    {
        "ERPCode": 1 //m.sharifi
    },
    "Requestor": 
    {
        "ERPCode":1 //m.sharifi
    },
    "Process": 
    {
        "Name": "SampleProcess"
    },
    "Conditions":
    [
        {
            "Tag": {"Name": "StockType"},
            "Operand": {"Name": "="},
            "Value":"FirstStock"
        }
    ],
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
            "createTimeRecord": "2024-04-27T11:05:27.3645267+03:30",
            "lastUpdatedRecord": "2024-04-27T11:05:27.8561377+03:30",
            "id": 68,
            "erpCode": -216,
            "sortIndex": 0,
            "enableRecord": null
        },
        "processId": 1,
        "creatorId": 1,
        "requestorId": 1,
        "tasks": [
            {
                "base": null,
                "workItems": [
                    {
                        "base": {
                            "createTimeRecord": "2024-04-27T11:05:27.8534311+03:30",
                            "lastUpdatedRecord": null,
                            "id": 255,
                            "erpCode": null,
                            "sortIndex": 0,
                            "enableRecord": null
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
                            "enableRecord": null
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
            "enableRecord": null
        }
    },
    "outputState": {
        "name": null,
        "displayName": "درخواست با شماره رهیگری 68 با موفقیت در چیتا ثبت شد",
        "id": 0,
        "erpCode": 0,
        "sortIndex": null,
        "enableRecord": null
    }
}
```