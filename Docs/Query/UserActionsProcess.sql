USE [Cheetah]
GO

/****** Object:  Table [dbo].[UserActionsProcess]    Script Date: 1/22/2023 1:21:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserActionsProcess](
	[idUserActionsProcess] [bigint] NOT NULL,
	[finalEnt] [int] NULL,
	[CurrentProcessEndorsemen] [bigint] NULL,
	[RequestTitles_Code] [int] NULL,
	[Automation] [bit] NULL,
	[sender_input] [nvarchar](50) NULL,
	[Receiver_input] [nvarchar](50) NULL,
	[Subject_input] [nvarchar](255) NULL,
	[TextBody_input] [nvarchar](2048) NULL,
	[IdentificationCode_input] [nvarchar](215) NULL,
	[SendLetterResponse] [bit] NULL,
	[SendERP] [bit] NULL,
	[RequestInformation] [bigint] NULL,
	[SendNotifyERP] [bit] NULL,
	[CreateDate] [datetime] NULL,
	[SMS] [bit] NULL,
	[baCreatedTime] [bigint] NOT NULL,
	[baGuid] [uniqueidentifier] NOT NULL,
	[SupplierDocPrintDtl] [bigint] NULL,
 CONSTRAINT [UserActionsProcess_PK] PRIMARY KEY CLUSTERED 
(
	[idUserActionsProcess] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UserActionsProcess] ADD  CONSTRAINT [DF_UserActionsProcess_Automation]  DEFAULT ((0)) FOR [Automation]
GO

ALTER TABLE [dbo].[UserActionsProcess] ADD  CONSTRAINT [DF_UserActionsProcess_SendERP]  DEFAULT ((0)) FOR [SendERP]
GO

ALTER TABLE [dbo].[UserActionsProcess] ADD  CONSTRAINT [DF_UserActionsProcess_SMS]  DEFAULT ((0)) FOR [SMS]
GO

ALTER TABLE [dbo].[UserActionsProcess] ADD  CONSTRAINT [DF_UserActionsProcess_baCreatedTime]  DEFAULT (CONVERT([bigint],datediff(second,'1970-01-01',getutcdate()))*(1000)) FOR [baCreatedTime]
GO

ALTER TABLE [dbo].[UserActionsProcess] ADD  CONSTRAINT [DF_UserActionsProcess_baGuid]  DEFAULT (newid()) FOR [baGuid]
GO


