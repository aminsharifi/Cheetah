USE [IntegerationDB]
GO

/****** Object:  StoredProcedure [dbo].[Sync_UserPosition]    Script Date: 8/24/2023 12:50:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sync_UserPosition]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

INSERT INTO 
Cheetah.Links.L_UserPosition
(Name,DisplayName,EnableRecord,ERPCode, FirstId,SecondId)
select 
D_User.Name + N'-' +D_Position.Name as D_Name,
D_User.DisplayName + N'-' +D_Position.DisplayName as D_DisplayName, 
V_UserPosition.EnableRecord as EnableRecord,
V_UserPosition.ERPCode as D_ERPCode,
D_User.Id as D_FirstId, D_Position.Id as D_SecondId
FROM            Virtuals.V_UserPosition INNER JOIN
Cheetah.Dimentions.D_User ON V_UserPosition.FirstId = D_User.ERPCode INNER JOIN
Cheetah.Dimentions.D_Position ON V_UserPosition.SecondId = D_Position.ERPCode LEFT OUTER JOIN
Cheetah.Links.L_UserPosition ON D_User.Id = L_UserPosition.FirstId AND D_Position.Id = L_UserPosition.SecondId
WHERE (L_UserPosition.Id IS NULL) AND (V_UserPosition.EnableRecord = 1)



UPDATE Cheetah.Links.L_UserPosition
SET EnableRecord = 0
FROM  Virtuals.V_UserPosition INNER JOIN
Cheetah.Dimentions.D_User ON D_User.ERPCode = V_UserPosition.FirstId INNER JOIN
Cheetah.Dimentions.D_Position ON D_Position.ERPCode = Virtuals.V_UserPosition.SecondId RIGHT OUTER JOIN
Cheetah.Links.L_UserPosition ON L_UserPosition.FirstId = D_User.Id AND L_UserPosition.SecondId = D_Position.Id
WHERE (V_UserPosition.ERPCode IS NULL) and L_UserPosition.EnableRecord = 1



END
GO


