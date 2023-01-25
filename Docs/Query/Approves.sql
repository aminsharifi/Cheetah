USE [Cheetah]
GO

/****** Object:  Table [dbo].[Approves]    Script Date: 1/22/2023 1:23:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Approves](
	[idApproves] [bigint] NOT NULL,
	[finalEnt] [int] NULL,
	[Approves_TaskRecieveDate] [datetime] NULL,
	[Approves_TaskSentDate] [datetime] NULL,
	[Approves_UserInCharge] [int] NULL,
	[Approves_UserAction] [bigint] NULL,
	[Approves_UserDescription] [nvarchar](1024) NULL,
	[RequestInformation] [bigint] NULL,
	[Approves_Subject] [nvarchar](50) NULL,
	[Approves_Number] [nvarchar](50) NULL,
	[Approves_Attachment] [tinyint] NULL,
	[Knowledge] [bigint] NULL,
	[baCreatedTime] [bigint] NOT NULL,
	[baGuid] [uniqueidentifier] NOT NULL,
 CONSTRAINT [Approves_PK] PRIMARY KEY CLUSTERED 
(
	[idApproves] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Approves] ADD  CONSTRAINT [DF_Approves_baCreatedTime]  DEFAULT (CONVERT([bigint],datediff(second,'1970-01-01',getutcdate()))*(1000)) FOR [baCreatedTime]
GO

ALTER TABLE [dbo].[Approves] ADD  CONSTRAINT [DF_Approves_baGuid]  DEFAULT (newid()) FOR [baGuid]
GO


