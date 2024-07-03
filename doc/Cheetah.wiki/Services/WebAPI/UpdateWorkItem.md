## * WebAPI General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | WebAPI          |
| Broker Server Name  | localhost: 5000 |
| Project Version     | 8.2.100         |
| Service Name        | UpdateWorkItem  |

## * WebAPI Messages

| Title | Value                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
| --- | --- |
| Request Message Class Name  | UpdateWorkItemRequest |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Request Message             | {WorkItemDTO?:WorkItem;bool?:Rebase} |
| Response Message Class Name | UpdateWorkItemResponse |
| Response Message            | {CaseDTO?:Case;BaseClassWithNameDTO?:OutputState} |

## * Description

This service is used to send Work Items.
WorkItem's ID is the unique identifier of each user-task.
OccurredUserActions are actions taken by the user.
User is the user who did this work.
Rebase is used to resubmit work.

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

## * WebAPI Sample Input Message:

```javascript
{
 "WorkItem":
    {
        "Base":
        {
            "Id": 1456,
            "DisplayName":"Please consider this request too Last"
        },
        "OccurredUserActions":
         [
            {
                "Base":
                {
                    "ERPCode": -21
                }
            }
        ],
        "User":
        {
            //"Name": "AdmissionManager"
            "ERPCode": 1906
        }
    }
    ,"Rebase": true
}

```

## * WebAPI Sample Output Message:

```javascript
{
    "case": {
        "base": {
            "created": "2024-07-03T11:32:13.6565503+03:30",
            "lastModified": "2024-07-03T08:02:17.4521918+00:00",
            "id": 216,
            "erpCode": -1,
            "sortIndex": 0,
            "enableRecord": true
        },
        "processId": null,
        "creatorId": null,
        "requestorId": null,
        "tasks": null,
        "caseState": null
    },
    "outputState": {
        "name": null,
        "displayName": null,
        "id": 0,
        "erpCode": null,
        "sortIndex": null,
        "enableRecord": null
    }
}


```