## * WebAPI General Info

| Title               | Value           |
| ---                 | ---             |
| Broker Name         | WebAPI		    |
| Broker Server Name  | localhost: 1991 |
| Project Version     | 8.2.100         |
| Service Name        | ListWorkItemsHistory   |

## * WebAPI Messages

| Title | Value |
| ---   | ---   |
| Request Message Class Name  | Cartable_Input |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Request Message             | {long?:PageNumber;long?:PageSize;long?:TotalItems;BaseClassWithNameDTO?:Assignee;BaseClassWithNameDTO?:CaseState;List<BaseClassWithNameDTO>?:CaseStateList;BaseClassWithNameDTO?:Process;BaseClassDTO? Case; BaseClassDTO?:WorkItem} |
| Response Message Class Name | Cartable_Output |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
| Response Message            | {BaseClassWithDateDTO?:Case;BaseClassWithNameDTO?:Task;BaseClassWithNameDTO?:Form;List<BaseClassWithNameDTO>?:Performer;BaseClassWithNameDTO?: User;BaseClassWithNameAndDateDTO?:WorkItem;BaseClassWithNameDTO?:WorkItemState;List<BaseClassWithNameDTO>?:OccurredUserActions;BaseClassWithNameDTO: OutputState} |

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
    //"Assignee": { "ERPCode":1906},
    //"Assignee": { "ERPCode":-7},
    //"Process": { "Name": "Admission"},
    "Process": { "ERPCode": -6},
    "PageNumber": 1,
    "PageSize": 20
    // ,"CaseState":
    //  {
    //      "ERPCode": -2
    //  }
    ,"Case": 
    {
          "ERPCode": -1
    }
}

```

## * WebAPI Sample Output Message:

```javascript
[
    {
        "case": {
            "created": "2024-07-03T12:54:04.8854373+03:30",
            "lastModified": "2024-07-03T09:24:05.7841427+00:00",
            "id": 217,
            "erpCode": -1,
            "sortIndex": 0,
            "enableRecord": true
        },
        "task": {
            "name": "",
            "displayName": "ثبت درخواست",
            "id": 13,
            "erpCode": null,
            "sortIndex": 1,
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
        "performer": [
            {
                "name": "Role = AdmissionManager",
                "displayName": "مدیر پذیرش",
                "id": 24,
                "erpCode": -24,
                "sortIndex": -24,
                "enableRecord": true
            }
        ],
        "user": {
            "name": "mofid@91008700",
            "displayName": "mofid@91008700",
            "id": 103,
            "erpCode": 198,
            "sortIndex": 198,
            "enableRecord": true
        },
        "workItem": {
            "name": "",
            "displayName": "Please consider request",
            "created": "2024-07-03T12:54:04.8976853+03:30",
            "lastModified": "2024-07-03T12:54:05.7796138+03:30",
            "id": 1458,
            "erpCode": null,
            "sortIndex": 0,
            "enableRecord": true
        },
        "workItemState": {
            "name": "Sent",
            "displayName": "ارسال شده",
            "id": 2,
            "erpCode": -2,
            "sortIndex": 2,
            "enableRecord": true
        },
        "occurredUserActions": [
            {
                "name": "ReviewState = SendRequest",
                "displayName": "وضعیت بررسی مساوی SendRequest است.",
                "id": 23,
                "erpCode": -23,
                "sortIndex": -23,
                "enableRecord": true
            }
        ],
        "outputState": {
            "name": "Ok",
            "displayName": null,
            "id": 0,
            "erpCode": null,
            "sortIndex": null,
            "enableRecord": null
        }
    },
    {
        "case": {
            "created": "2024-07-03T12:54:04.8854373+03:30",
            "lastModified": "2024-07-03T09:24:05.7841427+00:00",
            "id": 217,
            "erpCode": -1,
            "sortIndex": 0,
            "enableRecord": true
        },
        "task": {
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
        "performer": [
            {
                "name": "تغییر رمز عبور",
                "displayName": "تغییر رمز عبور",
                "id": 240,
                "erpCode": 49,
                "sortIndex": 49,
                "enableRecord": true
            }
        ],
        "user": {
            "name": "Hasanzadeh.a@seo.ir",
            "displayName": "علی حسن زاده سروستانی",
            "id": 778,
            "erpCode": 1907,
            "sortIndex": 1907,
            "enableRecord": true
        },
        "workItem": {
            "name": "",
            "displayName": "",
            "created": "2024-07-03T12:54:05.435682+03:30",
            "lastModified": null,
            "id": 1459,
            "erpCode": null,
            "sortIndex": 0,
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
        "occurredUserActions": [
            {
                "name": "ReviewState = SendRequest",
                "displayName": "وضعیت بررسی مساوی SendRequest است.",
                "id": 23,
                "erpCode": -23,
                "sortIndex": -23,
                "enableRecord": true
            }
        ],
        "outputState": {
            "name": "Ok",
            "displayName": null,
            "id": 0,
            "erpCode": null,
            "sortIndex": null,
            "enableRecord": null
        }
    },
    {
        "case": {
            "created": "2024-07-03T12:54:04.8854373+03:30",
            "lastModified": "2024-07-03T09:24:05.7841427+00:00",
            "id": 217,
            "erpCode": -1,
            "sortIndex": 0,
            "enableRecord": true
        },
        "task": {
            "name": "",
            "displayName": "بررسی مدیریت درخواست",
            "id": 15,
            "erpCode": null,
            "sortIndex": 3,
            "enableRecord": true
        },
        "form": {
            "name": "ReviewForm",
            "displayName": "بررسی درخواست",
            "id": 2,
            "erpCode": -2,
            "sortIndex": 2,
            "enableRecord": true
        },
        "performer": [
            {
                "name": "مدیر تغییر رمز عبور",
                "displayName": "مدیر تغییر رمز عبور",
                "id": 241,
                "erpCode": 50,
                "sortIndex": 50,
                "enableRecord": true
            }
        ],
        "user": {
            "name": "Hasanzadeh.a@seo.ir",
            "displayName": "علی حسن زاده سروستانی",
            "id": 778,
            "erpCode": 1907,
            "sortIndex": 1907,
            "enableRecord": true
        },
        "workItem": {
            "name": "",
            "displayName": "Changed manually",
            "created": "2024-07-03T12:54:05.498564+03:30",
            "lastModified": null,
            "id": 1460,
            "erpCode": null,
            "sortIndex": 0,
            "enableRecord": true
        },
        "workItemState": {
            "name": "Future",
            "displayName": "آینده",
            "id": 4,
            "erpCode": -4,
            "sortIndex": 4,
            "enableRecord": true
        },
        "occurredUserActions": [
            {
                "name": "ReviewState = SendRequest",
                "displayName": "وضعیت بررسی مساوی SendRequest است.",
                "id": 23,
                "erpCode": -23,
                "sortIndex": -23,
                "enableRecord": true
            }
        ],
        "outputState": {
            "name": "Ok",
            "displayName": null,
            "id": 0,
            "erpCode": null,
            "sortIndex": null,
            "enableRecord": null
        }
    }
]

```