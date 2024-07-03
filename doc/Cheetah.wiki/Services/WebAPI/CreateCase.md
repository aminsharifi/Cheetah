## * WebAPI General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | WebAPI		    |
| Broker Server Name  | localhost: 1991 |
| Project Version     | 8.2.100         |
| Service Name        | CreateCase      |

 
## * WebAPI Messages
     
| Title | Value |
| --- | --- |
| Request Message Class Name  | CreateCaseRequest |
| Request Message             | {BaseClassWithDateDTO?:Case;BaseClassWithNameDTO:Creator;BaseClassWithNameDTO?: Requestor;BaseClassWithNameDTO:Process;List<ConditionDTO>?:Conditions; WorkItemDTO?:WorkItem;} |
| Response Message Class Name | CreateRequest_Output|
| Response Message            | {CaseDTO?:Case;BaseClassWithNameDTO?:OutputState} |

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


## * WebAPI Sample Input Message:

```javascript
{    
    "Case": {"ERPCode": -14},
    "Creator":
    {
        "ERPCode": 198
    },
    "Requestor": 
    {
        "ERPCode":198
    },
    "Process":
    {
        "ERPCode": -6
    },
    "WorkItem":
    {
        "Base":{"DisplayName":"Please consider request"},
        "OccurredUserActions":
        [
            {
                "Base":
                {
                    "ERPCode": -23
                }
            }
        ],
        "User":
        {
            "ERPCode": 198
        }
    }
}

```

## * WebAPI Sample Output Message:
```javascript
{
    "case": {
        "base": {
            "created": null,
            "lastModified": null,
            "id": 210,
            "erpCode": null,
            "sortIndex": null,
            "enableRecord": null
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