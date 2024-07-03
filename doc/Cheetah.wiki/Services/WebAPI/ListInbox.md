## * WebAPI General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | WebAPI		    |
| Broker Server Name  | localhost: 1991 |
| Project Version     | 8.2.100         |
| Service Name        | ListInbox       |

## * WebAPI Messages

| Title | Value |
| ---   | ---   |
| Request Message Class Name  | Cartable_Input |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Request Message             | {long?:PageNumber;long?:PageSize;long?:TotalItems;BaseClassWithNameDTO?:Assignee;BaseClassWithNameDTO?:CaseState;List<BaseClassWithNameDTO>?:CaseStateList;BaseClassWithNameDTO?:Process;BaseClassDTO? Case; BaseClassDTO?:WorkItem} |
| Response Message Class Name | Cartable_Output |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Response Message            | {long?:PageNumber;long?:PageSize;long?:TotalItems;BaseClassWithNameDTO?:Assignee;BaseClassWithNameDTO?:CaseState;List<BaseClassWithNameDTO>?:CaseStateList;BaseClassWithNameDTO?:Process;BaseClassDTO? Case; BaseClassDTO?:WorkItem} |

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

## * WebAPI Sample Input Message:

```javascript
{
    "Assignee": { "ERPCode":1906},
    //"Assignee": { "ERPCode":-7},
    //"Process": { "Name": "Admission"},
    "Process": { "ERPCode": -6},
    "PageNumber": 1,
    "PageSize": 20
    // ,"CaseState":
    //  {
    //      "ERPCode": -2
    //  }
    //  ,"Case": 
    // {
    //      //"Id": 94
    //      "ERPCode": -1
    // }
}

```

## * WebAPI Sample Output Message:

```javascript
{
    "pageNumber": 1,
    "pageSize": 20,
    "totalItems": 1,
    "cases": [
        {
            "base": {
                "created": "2024-07-03T10:31:10.5791954+03:30",
                "lastModified": "2024-07-03T07:01:11.5950357+00:00",
                "id": 210,
                "erpCode": -14,
                "sortIndex": 0,
                "enableRecord": true
            },
            "processId": 6,
            "creatorId": 103,
            "requestorId": 103,
            "tasks": [
                {
                    "base": {
                        "name": "",
                        "displayName": "بررسی کارشناسی درخواست",
                        "id": 14,
                        "erpCode": null,
                        "sortIndex": 2,
                        "enableRecord": true
                    },
                    "form": {
                        "name": "ExpertForm",
                        "displayName": "اقدام کارشناسی",
                        "id": 1,
                        "erpCode": -1,
                        "sortIndex": 1,
                        "enableRecord": true
                    },
                    "performers": [
                        {
                            "base": {
                                "name": "تغییر رمز عبور",
                                "displayName": "تغییر رمز عبور",
                                "id": 240,
                                "erpCode": 49,
                                "sortIndex": 49,
                                "enableRecord": true
                            },
                            "tag": null,
                            "operand": null,
                            "value": "تغییر رمز عبور"
                        }
                    ],
                    "validUserActions": [
                        {
                            "base": {
                                "name": "ReviewState = Reject",
                                "displayName": "وضعیت بررسی مساوی Reject است.",
                                "id": 21,
                                "erpCode": -21,
                                "sortIndex": -21,
                                "enableRecord": true
                            },
                            "tag": null,
                            "operand": null,
                            "value": "Reject"
                        }
                    ],
                    "workItems": [
                        {
                            "base": {
                                "name": "",
                                "displayName": "",
                                "created": "2024-07-03T10:31:11.2197085+03:30",
                                "lastModified": null,
                                "id": 1448,
                                "erpCode": null,
                                "sortIndex": 0,
                                "enableRecord": true
                            },
                            "user": {
                                "name": "jahankhani",
                                "displayName": "رضا جهان خانی",
                                "id": 777,
                                "erpCode": 1906,
                                "sortIndex": 1906,
                                "enableRecord": true
                            },
                            "workItemState": {
                                "name": "Inbox",
                                "displayName": "صندوق ورودی",
                                "id": 1,
                                "erpCode": -1,
                                "sortIndex": 1,
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
                "erpCode": -2,
                "sortIndex": 2,
                "enableRecord": true
            }
        }
    ],
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