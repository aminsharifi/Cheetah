USE [Cheetah]
GO

/****** Object:  Table [Links].[L_UserSkill]    Script Date: 4/6/2023 1:03:52 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Links].[L_UserSkill]') AND type in (N'U'))
DROP TABLE [Links].[L_UserSkill]
GO

/****** Object:  Table [Links].[L_UserRole]    Script Date: 4/6/2023 1:04:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Links].[L_UserRole]') AND type in (N'U'))
DROP TABLE [Links].[L_UserRole]
GO

/****** Object:  Table [Links].[L_UserRelatedLocation]    Script Date: 4/6/2023 1:05:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Links].[L_UserRelatedLocation]') AND type in (N'U'))
DROP TABLE [Links].[L_UserRelatedLocation]
GO

/****** Object:  Table [Links].[L_UserLocation]    Script Date: 4/6/2023 1:06:06 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Links].[L_UserLocation]') AND type in (N'U'))
DROP TABLE [Links].[L_UserLocation]
GO

/****** Object:  Table [Links].[L_UserArea]    Script Date: 4/6/2023 1:06:29 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Links].[L_UserArea]') AND type in (N'U'))
DROP TABLE [Links].[L_UserArea]
GO

/****** Object:  Table [Links].[L_RolePosition]    Script Date: 4/6/2023 1:06:47 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Links].[L_RolePosition]') AND type in (N'U'))
DROP TABLE [Links].[L_RolePosition]
GO

/****** Object:  Table [Facts].[F_ListOfParameter]    Script Date: 4/6/2023 1:07:47 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Facts].[F_ListOfParameter]') AND type in (N'U'))
DROP TABLE [Facts].[F_ListOfParameter]
GO

/****** Object:  Table [Facts].[F_EndorsementPosition]    Script Date: 4/6/2023 1:07:58 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Facts].[F_EndorsementPosition]') AND type in (N'U'))
DROP TABLE [Facts].[F_EndorsementPosition]
GO


/****** Object:  Table [Facts].[F_EndorsementPosition]    Script Date: 4/6/2023 1:07:58 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Links].[L_UserPosition]') AND type in (N'U'))
DROP TABLE [Links].[L_UserPosition]
GO
/****** Object:  Table [Facts].[F_EndorsementPosition]    Script Date: 4/6/2023 1:07:58 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Links].[L_Process_Strategy]') AND type in (N'U'))
DROP TABLE [Links].[L_Process_Strategy]
GO

/****** Object:  Table [Facts].[F_Attachment]    Script Date: 4/6/2023 1:08:14 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Facts].[F_Attachment]') AND type in (N'U'))
DROP TABLE [Facts].[F_Attachment]
GO


/****** Object:  Table [Dimentions].[D_Skill]    Script Date: 4/6/2023 1:08:14 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_Skill]') AND type in (N'U'))
DROP TABLE [Facts].[D_Skill]
GO


/****** Object:  Table [Dimentions].[D_Area]    Script Date: 4/6/2023 1:11:18 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_Area]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_Area]
GO

/****** Object:  Table [Dimentions].[D_Operand]    Script Date: 4/6/2023 1:12:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Facts].[F_Condition]') AND type in (N'U'))
DROP TABLE [Facts].[F_Condition]
GO




/****** Object:  Table [Dimentions].[D_Operand]    Script Date: 4/6/2023 1:12:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_Operand]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_Operand]
GO

/****** Object:  Table [Facts].[F_RequestInformation]    Script Date: 4/6/2023 1:13:56 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Facts].[F_RequestInformation]') AND type in (N'U'))
DROP TABLE [Facts].[F_RequestInformation]
GO

/****** Object:  Table [Dimentions].[D_UnitType]    Script Date: 4/6/2023 1:14:36 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_UnitType]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_UnitType]
GO

/****** Object:  Table [Dimentions].[D_Role]    Script Date: 4/6/2023 1:15:08 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Facts].[F_Endorsement]') AND type in (N'U'))
DROP TABLE [Facts].[F_Endorsement]
GO

/****** Object:  Table [Dimentions].[D_Role]    Script Date: 4/6/2023 1:15:08 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_Role]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_Role]
GO

/****** Object:  Table [Dimentions].[D_Role]    Script Date: 4/6/2023 1:15:08 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Facts].[F_Scenario]') AND type in (N'U'))
DROP TABLE [Facts].[F_Scenario]
GO

/****** Object:  Table [Dimentions].[D_Position]    Script Date: 4/6/2023 1:15:50 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_Position]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_Position]
GO

/****** Object:  Table [Dimentions].[D_ParameterList]    Script Date: 4/6/2023 1:16:12 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_ParameterList]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_ParameterList]
GO

/****** Object:  Table [Dimentions].[D_Location]    Script Date: 4/6/2023 1:16:33 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_Location]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_Location]
GO

/****** Object:  Table [Dimentions].[D_ParameterType]    Script Date: 4/6/2023 1:17:26 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_ParameterType]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_ParameterType]
GO


/****** Object:  Table [Dimentions].[D_FieldType]    Script Date: 4/6/2023 1:20:50 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_FieldType]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_FieldType]
GO

ALTER TABLE [Facts].[F_UserInformation] DROP CONSTRAINT [FK_F_UserInformation_F_UserInformation_Parent_Id]
GO

ALTER TABLE [Facts].[F_UserInformation] DROP CONSTRAINT [DF__F_UserInf__PDesc__2097C3F2]
GO

ALTER TABLE [Facts].[F_UserInformation] DROP CONSTRAINT [DF__F_UserInf__DsblR__218BE82B]
GO

ALTER TABLE [Facts].[F_UserInformation] DROP CONSTRAINT [DF__F_UserInf__PInde__1FA39FB9]
GO


ALTER TABLE [Facts].[F_Approve] DROP CONSTRAINT [FK_F_Approve_F_Approve_Parent_Id]
GO

ALTER TABLE [Facts].[F_Approve] DROP CONSTRAINT [FK_F_Approve_F_AllApprove_APV_NeedApproveId]
GO

ALTER TABLE [Facts].[F_Approve] DROP CONSTRAINT [FK_F_Approve_F_AllApprove_APV_ApproveId]
GO

ALTER TABLE [Facts].[F_Approve] DROP CONSTRAINT [FK_F_Approve_D_User_APV_UserInChargeId]
GO

ALTER TABLE [Facts].[F_Approve] DROP CONSTRAINT [FK_F_Approve_D_ProcessEndorsement_APV_ProcessEndorsementId]
GO

ALTER TABLE [Facts].[F_Approve] DROP CONSTRAINT [DF__F_Approve__PDesc__2EE5E349]
GO

ALTER TABLE [Facts].[F_Approve] DROP CONSTRAINT [DF__F_Approve__DsblR__2FDA0782]
GO

ALTER TABLE [Facts].[F_Approve] DROP CONSTRAINT [DF__F_Approve__PInde__2DF1BF10]
GO

ALTER TABLE [Facts].[F_AllApprove] DROP CONSTRAINT [FK_F_AllApprove_F_Approve_AAP_Last_ApproveId]
GO

ALTER TABLE [Facts].[F_AllApprove] DROP CONSTRAINT [FK_F_AllApprove_F_Approve_AAP_Current_ApproveId]
GO

ALTER TABLE [Facts].[F_AllApprove] DROP CONSTRAINT [FK_F_AllApprove_F_AllApprove_Parent_Id]
GO

ALTER TABLE [Facts].[F_AllApprove] DROP CONSTRAINT [DF__F_AllAppr__PDesc__31C24FF4]
GO

ALTER TABLE [Facts].[F_AllApprove] DROP CONSTRAINT [DF__F_AllAppr__DsblR__32B6742D]
GO

ALTER TABLE [Facts].[F_AllApprove] DROP CONSTRAINT [DF__F_AllAppr__PInde__30CE2BBB]
GO

ALTER TABLE [Dimentions].[D_User] DROP CONSTRAINT [FK_D_User_F_UserInformation_User_UserInformationId]
GO

ALTER TABLE [Dimentions].[D_User] DROP CONSTRAINT [FK_D_User_D_User_User_DelegateId]
GO

ALTER TABLE [Dimentions].[D_User] DROP CONSTRAINT [FK_D_User_D_User_User_BossUserId]
GO

ALTER TABLE [Dimentions].[D_User] DROP CONSTRAINT [FK_D_User_D_User_Parent_Id]
GO

ALTER TABLE [Dimentions].[D_User] DROP CONSTRAINT [DF__D_User__PDescrip__349EBC9F]
GO

ALTER TABLE [Dimentions].[D_User] DROP CONSTRAINT [DF__D_User__DsblReco__3592E0D8]
GO

ALTER TABLE [Dimentions].[D_User] DROP CONSTRAINT [DF__D_User__PIndex__33AA9866]
GO
ALTER TABLE [Dimentions].[D_SubRequestTitle] DROP CONSTRAINT [FK_D_SubRequestTitle_D_SubRequestTitle_Parent_Id]
GO

ALTER TABLE [Dimentions].[D_SubRequestTitle] DROP CONSTRAINT [FK_D_SubRequestTitle_D_RequestTitle_D_RequestTitleId]
GO

ALTER TABLE [Dimentions].[D_SubRequestTitle] DROP CONSTRAINT [DF__D_SubRequ__PDesc__3A5795F5]
GO

ALTER TABLE [Dimentions].[D_SubRequestTitle] DROP CONSTRAINT [DF__D_SubRequ__DsblR__3B4BBA2E]
GO

ALTER TABLE [Dimentions].[D_SubRequestTitle] DROP CONSTRAINT [DF__D_SubRequ__PInde__396371BC]
GO

ALTER TABLE [Dimentions].[D_RequestTitle] DROP CONSTRAINT [FK_D_RequestTitle_D_RequestTitle_Parent_Id]
GO

ALTER TABLE [Dimentions].[D_RequestTitle] DROP CONSTRAINT [DF__D_Request__PDesc__42ECDBF6]
GO

ALTER TABLE [Dimentions].[D_RequestTitle] DROP CONSTRAINT [DF__D_Request__DsblR__43E1002F]
GO

ALTER TABLE [Dimentions].[D_RequestTitle] DROP CONSTRAINT [DF__D_Request__PInde__41F8B7BD]
GO
ALTER TABLE [Dimentions].[D_ProcessState] DROP CONSTRAINT [FK_D_ProcessState_D_ProcessState_Parent_Id]
GO

ALTER TABLE [Dimentions].[D_ProcessState] DROP CONSTRAINT [DF__D_Process__PDesc__45C948A1]
GO

ALTER TABLE [Dimentions].[D_ProcessState] DROP CONSTRAINT [DF__D_Process__DsblR__46BD6CDA]
GO

ALTER TABLE [Dimentions].[D_ProcessState] DROP CONSTRAINT [DF__D_Process__PInde__44D52468]
GO

ALTER TABLE [Dimentions].[D_ProcessEndorsement] DROP CONSTRAINT [FK_D_ProcessEndorsement_D_User_PSE_ExpertUserId]
GO

ALTER TABLE [Dimentions].[D_ProcessEndorsement] DROP CONSTRAINT [FK_D_ProcessEndorsement_D_SubRequestTitle_PSE_SubRequestTitleId]
GO

ALTER TABLE [Dimentions].[D_ProcessEndorsement] DROP CONSTRAINT [FK_D_ProcessEndorsement_D_RequestTitle_PSE_RequestTitleId]
GO

ALTER TABLE [Dimentions].[D_ProcessEndorsement] DROP CONSTRAINT [FK_D_ProcessEndorsement_D_ProcessState_PSE_ProcessStateId]
GO

ALTER TABLE [Dimentions].[D_ProcessEndorsement] DROP CONSTRAINT [FK_D_ProcessEndorsement_D_ProcessEndorsement_Parent_Id]
GO

ALTER TABLE [Dimentions].[D_ProcessEndorsement] DROP CONSTRAINT [DF__D_Process__PDesc__48A5B54C]
GO

ALTER TABLE [Dimentions].[D_ProcessEndorsement] DROP CONSTRAINT [DF__D_Process__DsblR__4999D985]
GO

ALTER TABLE [Dimentions].[D_ProcessEndorsement] DROP CONSTRAINT [DF__D_Process__PInde__47B19113]
GO

/****** Object:  Table [Dimentions].[D_ProcessEndorsement]    Script Date: 4/6/2023 1:33:38 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_ProcessEndorsement]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_ProcessEndorsement]
GO



/****** Object:  Table [Dimentions].[D_ProcessEndorsement]    Script Date: 4/6/2023 1:33:38 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_ProcessState]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_ProcessState]
GO

/****** Object:  Table [Dimentions].[D_ProcessEndorsement]    Script Date: 4/6/2023 1:33:38 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_Endorsement]') AND type in (N'U'))
DROP

/****** Object:  Table [Dimentions].[D_ProcessState]    Script Date: 4/6/2023 1:33:07 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_ProcessState]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_ProcessState]
GO


/****** Object:  Table [Dimentions].[D_RequestTitle]    Script Date: 4/6/2023 1:32:44 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_Process]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_Process]
GO




/****** Object:  Table [Dimentions].[D_RequestTitle]    Script Date: 4/6/2023 1:32:44 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_Tag]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_Tag]
GO



/****** Object:  Table [Dimentions].[D_RequestTitle]    Script Date: 4/6/2023 1:32:44 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[F_Endorsement]') AND type in (N'U'))
DROP TABLE [Facts].[F_Endorsement]
GO

/****** Object:  Table [Dimentions].[D_RequestTitle]    Script Date: 4/6/2023 1:32:44 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_TagType]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_TagType]
GO

/****** Object:  Table [Dimentions].[D_SubRequestTitle]    Script Date: 4/6/2023 1:32:12 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_SubRequestTitle]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_SubRequestTitle]
GO

/****** Object:  Table [Dimentions].[D_User]    Script Date: 4/6/2023 1:31:43 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_User]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_User]
GO


/****** Object:  Table [Facts].[F_AllApprove]    Script Date: 4/6/2023 1:30:51 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Facts].[F_AllApprove]') AND type in (N'U'))
DROP TABLE [Facts].[F_AllApprove]
GO

/****** Object:  Table [Facts].[F_Approve]    Script Date: 4/6/2023 1:30:13 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Facts].[F_Approve]') AND type in (N'U'))
DROP TABLE [Facts].[F_Approve]
GO


/****** Object:  Table [Facts].[F_UserInformation]    Script Date: 4/6/2023 1:28:11 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_UserInformation]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_UserInformation]
GO


/****** Object:  Table [Facts].[F_UserInformation]    Script Date: 4/6/2023 1:28:11 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_Strategy]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_Strategy]
GO



/****** Object:  Table [Facts].[F_UserInformation]    Script Date: 4/6/2023 1:28:11 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_Process]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_Process]
GO

/****** Object:  Table [Dimentions].[D_Entities]    Script Date: 4/6/2023 1:57:51 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_Entities]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_Entities]
GO

/****** Object:  Table [Dimentions].[D_Skill]    Script Date: 4/6/2023 1:58:21 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_Skill]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_Skill]
GO

/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 4/6/2023 1:36:19 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserTokens]') AND type in (N'U'))
DROP TABLE [dbo].[AspNetUserTokens]
GO


/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 4/6/2023 1:36:43 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserRoles]') AND type in (N'U'))
DROP TABLE [dbo].[AspNetUserRoles]
GO

/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 4/6/2023 1:36:58 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserLogins]') AND type in (N'U'))
DROP TABLE [dbo].[AspNetUserLogins]
GO


/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 4/6/2023 1:37:11 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserClaims]') AND type in (N'U'))
DROP TABLE [dbo].[AspNetUserClaims]
GO


/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 4/6/2023 1:37:37 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetRoleClaims]') AND type in (N'U'))
DROP TABLE [dbo].[AspNetRoleClaims]
GO


/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 4/6/2023 1:38:58 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUsers]') AND type in (N'U'))
DROP TABLE [dbo].[AspNetUsers]
GO

/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 4/6/2023 1:39:48 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetRoles]') AND type in (N'U'))
DROP TABLE [dbo].[AspNetRoles]
GO

/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 4/6/2023 1:38:25 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[__EFMigrationsHistory]') AND type in (N'U'))
DROP TABLE [dbo].[__EFMigrationsHistory]
GO

/****** Object:  Table [Dimentions].[D_Entity]    Script Date: 4/7/2023 9:54:22 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_Entity]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_Entity]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_EndorsementPattern]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_EndorsementPattern]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_Endorsement]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_Endorsement]
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Dimentions].[D_Role]') AND type in (N'U'))
DROP TABLE [Dimentions].[D_Role]
GO