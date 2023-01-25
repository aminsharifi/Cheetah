CREATE TABLE [dbo].[ROLE](
	[idRole] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [nvarchar](26) NOT NULL,
	[guidRole] [uniqueidentifier] NOT NULL,
	[roleDisplayName] [nvarchar](40) NULL,
	[roleDescription] [nvarchar](100) NULL,
	[dplyRole] [tinyint] NOT NULL,
	[finalEnt] [int] NOT NULL,
 CONSTRAINT [ROLE_PK] PRIMARY KEY CLUSTERED 
(
	[idRole] ASC
))