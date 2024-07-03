## * WebAPI General Info

| Title               | Value              |
| ---                 | ---                |
| Broker Name         | WebAPI		       |
| Broker Server Name  | localhost: 1991    |
| Project Version     | 8.2.100            |
| Service Name        | UpdateWorkItemUser |

 
## * WebAPI Messages
     
| Title | Value |
| --- | --- |
| Request Message Class Name  | CreateCaseRequest |
| Request Message             | {BaseClassWithNameDTO?:WorkItem;BaseClassWithNameDTO?:User} |
| Response Message Class Name | CreateRequest_Output|
| Response Message            | {BaseClassWithNameDTO? WorkItem; BaseClassWithNameDTO? OutputState} |

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
    "WorkItem": {"Id":1460,"DisplayName":"Changed manually"},
    "User": {"ERPCode": 1907}
}


```

## * WebAPI Sample Output Message:
```javascript
{
    "workItem": {
        "name": "",
        "displayName": "Changed manually",
        "id": 1460,
        "erpCode": null,
        "sortIndex": 0,
        "enableRecord": true
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