USE [Cheetah]
GO

/****** Object:  Table [dbo].[CurrentProcessEndorsemen]    Script Date: 1/22/2023 1:22:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CurrentProcessEndorsemen](
	[idCurrentProcessEndorsemen] [bigint] NOT NULL,
	[finalEnt] [int] NULL,
	[CU_ProcessEndorsements] [bigint] NULL,
	[RequestInformation] [bigint] NULL,
	[CU_UserAction] [bigint] NULL,
	[UserActionsProcess] [bigint] NULL,
	[CU_Active] [bit] NULL,
	[RequestGoods] [bigint] NULL,
	[CU_User] [int] NULL,
	[MeetingManagement] [bigint] NULL,
	[baCreatedTime] [bigint] NOT NULL,
	[baGuid] [uniqueidentifier] NOT NULL,
 CONSTRAINT [CurrentProcessEndorsemen_PK] PRIMARY KEY CLUSTERED 
(
	[idCurrentProcessEndorsemen] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CurrentProcessEndorsemen] ADD  CONSTRAINT [DF_CurrentProcessEndorsemen_baCreatedTime]  DEFAULT (CONVERT([bigint],datediff(second,'1970-01-01',getutcdate()))*(1000)) FOR [baCreatedTime]
GO

ALTER TABLE [dbo].[CurrentProcessEndorsemen] ADD  CONSTRAINT [DF_CurrentProcessEndorsemen_baGuid]  DEFAULT (newid()) FOR [baGuid]
GO


