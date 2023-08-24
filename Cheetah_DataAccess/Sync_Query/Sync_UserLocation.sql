USE [IntegerationDB]
GO

/****** Object:  StoredProcedure [dbo].[Sync_UserLocation]    Script Date: 8/24/2023 12:51:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sync_UserLocation]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

INSERT INTO 
Cheetah.Links.L_UserLocation
(Name,DisplayName,EnableRecord,ERPCode, FirstId,SecondId)
select 
D_User.Name + N'-' +D_Location.Name as D_Name,
D_User.DisplayName + N'-' +D_Location.DisplayName as D_DisplayName, 
V_UserLocation.EnableRecord as EnableRecord,
V_UserLocation.ERPCode as D_ERPCode,
D_User.Id as D_FirstId, D_Location.Id as D_SecondId
FROM            Virtuals.V_UserLocation INNER JOIN
                Cheetah.Dimentions.D_User ON Virtuals.V_UserLocation.FirstId = Cheetah.Dimentions.D_User.ERPCode INNER JOIN
                Cheetah.Dimentions.D_Location ON Virtuals.V_UserLocation.SecondId = Cheetah.Dimentions.D_Location.ERPCode LEFT OUTER JOIN
                Cheetah.Links.L_UserLocation ON Cheetah.Dimentions.D_User.Id = Cheetah.Links.L_UserLocation.FirstId AND Cheetah.Dimentions.D_Location.Id = Cheetah.Links.L_UserLocation.SecondId
WHERE        (Cheetah.Links.L_UserLocation.Id IS NULL) AND (Virtuals.V_UserLocation.EnableRecord = 1)



UPDATE       Cheetah.Links.L_UserLocation
SET                EnableRecord = 0
FROM            Virtuals.V_UserLocation INNER JOIN
                         Cheetah.Dimentions.D_User ON Cheetah.Dimentions.D_User.ERPCode = Virtuals.V_UserLocation.FirstId INNER JOIN
                         Cheetah.Dimentions.D_Location ON Cheetah.Dimentions.D_Location.ERPCode = Virtuals.V_UserLocation.SecondId RIGHT OUTER JOIN
                         Cheetah.Links.L_UserLocation ON Cheetah.Links.L_UserLocation.FirstId = Cheetah.Dimentions.D_User.Id AND Cheetah.Links.L_UserLocation.SecondId = Cheetah.Dimentions.D_Location.Id
WHERE        (Virtuals.V_UserLocation.ERPCode IS NULL) and L_UserLocation.EnableRecord = 1



END
GO


