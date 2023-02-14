USE [Cheetah]
GO

/****** Object:  StoredProcedure [Cheetah].[GetActiveBossUser]    Script Date: 2/11/2023 4:22:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		MohammadAmin Sharifi
-- Create date: 
-- Description:	Cheetah
-- =============================================
alter PROCEDURE [GetActiveBossUser]
	@idUser int
AS
BEGIN	
	SET NOCOUNT ON;
	DECLARE	@return_value int
	DECLARE	@RI_RequestTitle int
	DECLARE @ActiveBossUser int
	BEGIN TRANSACTION [GetActiveBossUser]
	BEGIN TRY
	
	;with cte as 
	(
		select IdRecord,User_BossUserId,User_Enabled from Systems.S_User where IdRecord = @idUser and IdRecord <> User_BossUserId
		union all
		select t.IdRecord,t.User_BossUserId,t.User_Enabled from cte 
			inner join Systems.S_User t on cte.User_BossUserId = t.IdRecord
			where (cte.IdRecord <> t.User_BossUserId or t.User_BossUserId is null)
	)
	select top(1)  @return_value = IdRecord from cte where IdRecord <> @IdUser and cte.User_Enabled = 1
	
	SELECT 1 as Passed,  -1 AS ID  ,@return_value AS Content;  
    COMMIT TRANSACTION [GetActiveBossUser]
	END TRY
	BEGIN CATCH
	SELECT 0 as Passed, ERROR_NUMBER() AS ID  ,ERROR_MESSAGE() AS Content;  
	ROLLBACK TRANSACTION [GetActiveBossUser]
	END CATCH
END
GO


