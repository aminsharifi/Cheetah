USE [Cheetah]
GO

/****** Object:  Table [dbo].[RequestInformation]    Script Date: 1/22/2023 1:36:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RequestInformation](
	[idRequestInformation] [bigint] NOT NULL,
	[finalEnt] [int] NULL,
	[RI_IsCancelled] [bit] NULL,
	[RI_RequestDate] [datetime] NULL,
	[RI_RequestFinishDate] [datetime] NULL,
	[RI_RequestID] [bigint] NULL,
	[RI_RequestNumber] [nvarchar](50) NULL,
	[RI_Requestor] [int] NULL,
	[RI_UserComment] [nvarchar](512) NULL,
	[RI_RequestTitle] [bigint] NULL,
	[RI_UserAction] [bigint] NULL,
	[RI_Address] [nvarchar](255) NULL,
	[RI_LastUserAction] [bigint] NULL,
	[RI_LastUserComment] [nvarchar](50) NULL,
	[RI_LastUserInCharge] [int] NULL,
	[RI_PE_Level] [tinyint] NULL,
	[RI_Attachment] [tinyint] NULL,
	[RI_ExpertUser] [int] NULL,
	[RI_Location] [int] NULL,
	[RI_UnitType] [bigint] NULL,
	[RI_ConditionOccur] [bit] NULL,
	[ERPID] [bigint] NULL,
	[RI_SubRequestTitles] [bigint] NULL,
	[RI_RequestSubject] [nvarchar](500) NULL,
	[RI_UserNameCreator] [nvarchar](50) NULL,
	[IsTest] [bit] NULL,
	[RI_ConditionOccur2] [bit] NULL,
	[RI_TaskName] [nvarchar](50) NULL,
	[WSResult] [bit] NULL,
	[RI_ValidUserAction] [nvarchar](50) NULL,
	[RI_ProcessState] [bigint] NULL,
	[RI_Creator] [int] NULL,
	[RI_OldDate] [datetime] NULL,
	[RI_NewDate] [datetime] NULL,
	[RI_RequestType] [bigint] NULL,
	[RI_ConditionOccur3] [bit] NULL,
	[RI_ConditionOccur4] [bit] NULL,
	[RI_ConditionOccur5] [bit] NULL,
	[RI_ProcessVar1] [nvarchar](1024) NULL,
	[RI_ProcessVar2] [nvarchar](1024) NULL,
	[RI_ProcessVar3] [nvarchar](1024) NULL,
	[RI_ProcessVar4] [nvarchar](1024) NULL,
	[RI_ProcessVar5] [nvarchar](1024) NULL,
	[WSResult_Desc] [nvarchar](1024) NULL,
	[RI_ActiveProcessEndorseme] [bigint] NULL,
	[WSResult_Code] [int] NULL,
	[RI_ERPBranchs] [nvarchar](50) NULL,
	[RI_ERPKindID] [nvarchar](50) NULL,
	[RT_ConditionDrug] [bit] NULL,
	[RT_ConditionFMCG] [bit] NULL,
	[CurrentQuestion] [bigint] NULL,
	[Priority] [bigint] NULL,
	[RI_Person] [bigint] NULL,
	[RI_CustomerView] [bigint] NULL,
	[RI_People] [nvarchar](50) NULL,
	[RI_UserComment2] [nvarchar](512) NULL,
	[RI_OutputVar1] [nvarchar](50) NULL,
	[RI_OutputVar2] [nvarchar](50) NULL,
	[RI_OutputVar3] [nvarchar](50) NULL,
	[RI_OutputVar4] [nvarchar](50) NULL,
	[RI_OutputVar5] [nvarchar](2500) NULL,
	[RI_UserComment3] [nvarchar](250) NULL,
	[Deploymentexpert] [int] NULL,
	[RT_SupplierSHare] [bit] NULL,
	[RT_AlborzSHare] [bit] NULL,
	[RI_Inputuser1] [nvarchar](50) NULL,
	[RI_CurrentUserNames] [nvarchar](2000) NULL,
	[RI_LastTaskSentDate] [datetime] NULL,
	[IdWorkItem] [nvarchar](100) NULL,
	[RI_RejectReason] [bigint] NULL,
	[RI_PERequestDate] [nvarchar](50) NULL,
	[RI_AttendanceInfo] [bigint] NULL,
	[RI_Area] [int] NULL,
	[baCreatedTime] [bigint] NOT NULL,
	[baGuid] [uniqueidentifier] NOT NULL,
	[WS_TryNum] [int] NULL,
	[WS_CurrentId] [bigint] NULL,
	[LastTimeModify] [datetime] NULL,
 CONSTRAINT [RequestInformation_PK] PRIMARY KEY CLUSTERED 
(
	[idRequestInformation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[RequestInformation] ADD  CONSTRAINT [DF_RequestInformation_RI_IsCancelled]  DEFAULT ((0)) FOR [RI_IsCancelled]
GO

ALTER TABLE [dbo].[RequestInformation] ADD  CONSTRAINT [DF_RequestInformation_RI_Address]  DEFAULT ('http://192.168.10.189:801/SupplierRegistration.jpg') FOR [RI_Address]
GO

ALTER TABLE [dbo].[RequestInformation] ADD  CONSTRAINT [DF_RequestInformation_RI_PE_Level]  DEFAULT ((1)) FOR [RI_PE_Level]
GO

ALTER TABLE [dbo].[RequestInformation] ADD  CONSTRAINT [DF_RequestInformation_RI_ConditionOccur]  DEFAULT ((1)) FOR [RI_ConditionOccur]
GO

ALTER TABLE [dbo].[RequestInformation] ADD  CONSTRAINT [DF_RequestInformation_IsTest]  DEFAULT ((0)) FOR [IsTest]
GO

ALTER TABLE [dbo].[RequestInformation] ADD  CONSTRAINT [DF_RequestInformation_RI_ConditionOccur2]  DEFAULT ((1)) FOR [RI_ConditionOccur2]
GO

ALTER TABLE [dbo].[RequestInformation] ADD  CONSTRAINT [DF_RequestInformation_RI_ConditionOccur3]  DEFAULT ((1)) FOR [RI_ConditionOccur3]
GO

ALTER TABLE [dbo].[RequestInformation] ADD  CONSTRAINT [DF_RequestInformation_RI_ConditionOccur4]  DEFAULT ((1)) FOR [RI_ConditionOccur4]
GO

ALTER TABLE [dbo].[RequestInformation] ADD  CONSTRAINT [DF_RequestInformation_RI_ConditionOccur5]  DEFAULT ((1)) FOR [RI_ConditionOccur5]
GO

ALTER TABLE [dbo].[RequestInformation] ADD  CONSTRAINT [DF_RequestInformation_RT_SupplierSHare]  DEFAULT ((0)) FOR [RT_SupplierSHare]
GO

ALTER TABLE [dbo].[RequestInformation] ADD  CONSTRAINT [DF_RequestInformation_RT_AlborzSHare]  DEFAULT ((0)) FOR [RT_AlborzSHare]
GO

ALTER TABLE [dbo].[RequestInformation] ADD  CONSTRAINT [DF_RequestInformation_baCreatedTime]  DEFAULT (CONVERT([bigint],datediff(second,'1970-01-01',getutcdate()))*(1000)) FOR [baCreatedTime]
GO

ALTER TABLE [dbo].[RequestInformation] ADD  CONSTRAINT [DF_RequestInformation_baGuid]  DEFAULT (newid()) FOR [baGuid]
GO

ALTER TABLE [dbo].[RequestInformation] ADD  CONSTRAINT [DF_RequestInformation_WS_TryNum]  DEFAULT ((0)) FOR [WS_TryNum]
GO


