USE [IntegerationDB]
GO

/****** Object:  StoredProcedure [dbo].[Sync_Users]    Script Date: 8/24/2023 12:46:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		MohammadAmin Sharifi
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[Sync_Users]	
AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO Cheetah.Dimentions.D_User
	(Name,DisplayName,EnableRecord,ERPCode)
	SELECT V_User.Name, V_User.DisplayName, 
	V_User.EnableRecord, V_User.ERPCode
	FROM IntegerationDB.Virtuals.V_User LEFT OUTER JOIN
	Cheetah.Dimentions.D_User ON V_User.ERPCode = D_User.ERPCode
	WHERE (D_User.ERPCode IS NULL)


	UPDATE D_User	
	set EnableRecord = 0	
	FROM Cheetah.Dimentions.D_User Left OUTER JOIN
	IntegerationDB.Virtuals.V_User 
	ON V_User.ERPCode = D_User.ERPCode	
	WHERE (V_User.ERPCode IS NULL)
	and D_User.EnableRecord = 1

	UPDATE D_User
	SET DisplayName = V_User.DisplayName, ERPCode = V_User.ERPCode,
	EnableRecord = V_User.EnableRecord
	FROM Cheetah.Dimentions.D_User INNER JOIN
	IntegerationDB.Virtuals.V_User 
	ON V_User.ERPCode = D_User.ERPCode
	where
	   (D_User.DisplayName <> V_User.DisplayName collate SQL_Latin1_General_CP1_CI_AS)
	or (D_User.EnableRecord <> V_User.EnableRecord)
	or (D_User.Name <> V_User.Name collate SQL_Latin1_General_CP1_CI_AS)


	UPDATE D_User
	set D_User.Parent_Id = V_ParentUser.ParentId
	FROM [IntegerationDB].[Virtuals].[V_ParentUser]
	inner join
	Cheetah.Dimentions.D_User on D_User.ERPCode = V_ParentUser.ERPCode
	where D_User.Parent_Id <> V_ParentUser.ParentId

END
GO


