## * Cheetah's ERD

![Cheetah ERD](https://raw.githubusercontent.com/aminsharifi/Cheetah/master/res/images/Cheetah_ERD.png)


## * All Cheetah tables have the same set of fields as described below:

| Field Name      | Field Type			| Default Value		 | Description							 |
| ---             | ---					| ---				 | ---									 |
| Id              | [bigint]			| IDENTITY(1,1)		 | The unique key of each record         |
| SortIndex       | [bigint]			| 0					 | The sort index of the record          |
| Name            | [nvarchar](512)     | string.Empty		 | English name of each record           |
| DisplayName     | [nvarchar](512)     | string.Empty		 | The localized name of each record     |
| Description     | [nvarchar](512)     | string.Empty		 | Additional description of each record |
| Created         | [datetimeoffset](7) | DateTimeOffset.Now | Record creation date                  |
| LastModified    | [datetimeoffset](7) | DateTimeOffset.Now | The date the record was last updated  |
| GuidRecord      | [uniqueidentifier]  | NewGuid()		     | Unique GUID identifier                |
| EnableRecord    | [bit]				| True			     | Active status of the record           |
| ERPCode         | [bigint]			| 0				     | ID of this record in ERP              |
| CreatedBy       | [nvarchar](512)     | string.Empty	     | Created by which user?                |
| LastModifiedBy  | [nvarchar](512)     | string.Empty	     | By which user has it been updated?    |



## * Dimension's Tables:

| #	  | Table Name		  | Description										|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
| --- | ---				  | ---												|
| D1  | D_CaseState		  | State of the case								|
| D2  | D_Entity		  | Table's name in the Cheetah						|
| D3  | D_Operand		  | Operand name, like equal, greater, etc.			|
| D4  | D_Process		  | The name of the processes that the admin enters |
| D5  | D_Tag			  | Entities like position, role, etc.				|
| D6  | D_TagType		  | Numeric, Text, Date, binary						|
| D7  | D_User			  | Cheetah's user									|
| D8  | D_UserInformation | Additional user information						|
| D9  | D_WorkItemState   | State of the WorkItem							|


## * Fact's Tables:

| #		| Table Name  | Description									 |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
| ---	| ---		  | ---											 |
| F1	| F_Case	  | Each request create one record in this table |
| F2	| F_Condition | Condition of each tag						 |
| F3	| F_Flow	  | Flow of BPMN for transferring between tasks	 |
| F4	| F_Scenario  | Scenario of processes						 |
| F5	| F_Task	  | Entities like position, role, etc.			 |
| F6	| F_WorkItem  | Numeric, Text, Date, binary					 |

## * Link's Tables:

| #	  | Table Name			| Description											 |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
| --- | ---					| ---													 |
| L1  | L_CaseCondition 	| Conditions of each case for selecting correct scenario |
| L2  | L_CaseTaskUser 		| Manual choosing performer								 |
| L3  | L_FlowCondition 	| Conditionals of each flow								 |
| L4  | L_FlowTask 			| Exit tasks of each flow								 |
| L5  | L_ProcessScenario 	| Related scenarios of each flow						 |
| L6  | L_ScenarioCondition | Conditionals of each scenario							 |
| L7  | L_TaskCondition		| Conditionals of each task								 |
| L8  | L_TaskFlow 			| Exit flows of each task								 |
| L9  | L_UserCondition		| Conditionals of each user								 |
| L10 | L_WorkItemCondition | Conditionals of each workitem							 |