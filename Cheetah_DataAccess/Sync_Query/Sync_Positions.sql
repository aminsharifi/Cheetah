USE [IntegerationDB]
GO

/****** Object:  StoredProcedure [dbo].[Sync_Positions]    Script Date: 8/24/2023 12:46:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		MohammadAmin Sharifi
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[Sync_Positions]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO Cheetah.Dimentions.D_Position
	(Name,DisplayName)
	select V_Position.Name, V_Position.DisplayName
	FROM IntegerationDB.Virtuals.V_Position Left JOIN
	Cheetah.Dimentions.D_Position ON
	V_Position.ERPCode = D_Position.ERPCode
	where  (D_Position.ERPCode IS NULL)

    UPDATE D_Position
	SET EnableRecord = 0
	FROM Cheetah.Dimentions.D_Position Left JOIN
	IntegerationDB.Virtuals.V_Position ON
	V_Position.ERPCode = D_Position.ERPCode
	where  (V_Position.ERPCode IS NULL)
	and EnableRecord <> 0

	UPDATE D_Position
	SET Name = V_Position.Name, DisplayName = V_Position.DisplayName
	FROM IntegerationDB.Virtuals.V_Position INNER JOIN
	Cheetah.Dimentions.D_Position ON
	V_Position.ERPCode = D_Position.ERPCode
	where (D_Position.Name <> V_Position.Name)
	or (D_Position.DisplayName <> V_Position.DisplayName collate SQL_Latin1_General_CP1_CI_AS)

END
GO


