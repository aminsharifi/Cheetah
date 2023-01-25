USE [Cheetah]
GO

/****** Object:  Table [dbo].[CallWebService]    Script Date: 1/22/2023 12:46:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CallWebService](
	[idCallWebService] [bigint] NOT NULL,
	[finalEnt] [int] NOT NULL,
	[baCreatedTime] [bigint] NOT NULL,
	[baGuid] [uniqueidentifier] NOT NULL,
	[URL] [nvarchar](500) NULL,
	[JsonInputBody] [ntext] NULL,
	[Status] [bigint] NULL,
	[WSResult] [bit] NULL,
	[WSResult_Code] [int] NULL,
	[WSResult_Desc] [nvarchar](2500) NULL,
	[RequestInformation] [bigint] NULL,
 CONSTRAINT [pk8a6cbfb4350ad601710caf9ff5c] PRIMARY KEY CLUSTERED 
(
	[idCallWebService] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[CallWebService] ADD  DEFAULT ((11213)) FOR [finalEnt]
GO

ALTER TABLE [dbo].[CallWebService] ADD  CONSTRAINT [DF_CallWebService_baCreatedTime]  DEFAULT (CONVERT([bigint],datediff(second,'1970-01-01',getutcdate()))*(1000)) FOR [baCreatedTime]
GO

ALTER TABLE [dbo].[CallWebService] ADD  CONSTRAINT [DF_CallWebService_baGuid]  DEFAULT (newid()) FOR [baGuid]
GO


