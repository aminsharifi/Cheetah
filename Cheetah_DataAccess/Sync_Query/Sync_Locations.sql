USE [IntegerationDB]
GO

/****** Object:  StoredProcedure [dbo].[Sync_Locations]    Script Date: 8/24/2023 12:46:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		MohammadAmin Sharifi
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[Sync_Locations] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO Cheetah.Dimentions.D_Location
	(Name,DisplayName,ERPCode)
	SELECT V_Location.Name, V_Location.DisplayName, V_Location.ERPCode
	FROM IntegerationDB.Virtuals.V_Location LEFT OUTER JOIN
	Cheetah.Dimentions.D_Location ON V_Location.ERPCode = D_Location.ERPCode
	WHERE (D_Location.ERPCode IS NULL)

    UPDATE D_Location
	SET EnableRecord = 0
	FROM Cheetah.Dimentions.D_Location LEFT JOIN
	IntegerationDB.Virtuals.V_Location ON V_Location.ERPCode = Cheetah.Dimentions.D_Location.ERPCode
	where
	V_Location.ERPCode is null
	and D_Location.EnableRecord = 1

	UPDATE D_Location
	SET DisplayName = V_Location.DisplayName, ERPCode = V_Location.ERPCode
	FROM IntegerationDB.Virtuals.V_Location INNER JOIN
	Cheetah.Dimentions.D_Location ON V_Location.ERPCode = Cheetah.Dimentions.D_Location.ERPCode
	where
	(D_Location.DisplayName <> V_Location.DisplayName collate SQL_Latin1_General_CP1_CI_AS)
	or (D_Location.Name <> V_Location.Name collate SQL_Latin1_General_CP1_CI_AS)

END
GO


