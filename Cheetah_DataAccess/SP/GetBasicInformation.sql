USE [Cheetah]
GO

/****** Object:  StoredProcedure [Cheetah].[GetBasicInformation]    Script Date: 2/11/2023 4:22:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		MohammadAmin Sharifi
-- Create date: 
-- Description:	Cheetah
-- =============================================
Alter PROCEDURE [PerformRequest]
	  @JsonInput nvarchar(max)
AS
BEGIN	
	SET NOCOUNT ON;

	BEGIN --DECLARATION	
	DECLARE	@return_value int,@IdRequestInformation int
	end

	BEGIN TRANSACTION [GetBasicInformation]

	BEGIN TRY
	
	BEGIN --Set Variable

	EXEC	@IdRequestInformation = [dbo].[G_SetInitialValues] @JsonInput

	select * into #TempView_M_RequestInformation FROM View_M_RequestInformation
	where M_RequestInformation_IdRecord = @IdRequestInformation

	select * from #TempView_M_RequestInformation

	/*

	select top(1) @CU_ProcessEndorsements = P_ProcessEndorsement.IdRecord,
	@idOrgPositions = S_OrgPosition.IdRecord,
	@OrgPositions_Name = S_OrgPosition.PName
	from [Masters].M_CurrentPE  --جدول تاییدات
	inner join [Parameters].P_ProcessEndorsement on P_ProcessEndorsement.IdRecord = M_CurrentPE.CPE_ProcessEndorsementsIdRecord
	inner join [Parameters].P_UserAction on P_UserAction .IdRecord = M_CurrentPE.CPE_UserActionIdRecord
	inner join [Systems].S_OrgPosition on S_OrgPosition.IdRecord = P_ProcessEndorsement.IdRecord
	where M_CurrentPE.IdRecord = @RI_RequestNumber and M_CurrentPE.CPE_Active = 1 and CPE_Active = 1 and P_UserAction.PCode != 1

	select @ExistsRecord = count(*)  from [Masters].M_CurrentPE --در جدول تاییدات رکوردی هست که تایید نشده باشد؟
	inner join [Parameters].[P_UserAction] on [P_UserAction].IdRecord = M_CurrentPE.CPE_UserActionIdRecord
	inner join [Parameters].[P_ProcessEndorsement] on [P_ProcessEndorsement].IdRecord = M_CurrentPE.CPE_ProcessEndorsementsIdRecord
	where M_CurrentPE.CPE_ProcessEndorsementsIdRecord = @IdRequestInformation and [P_UserAction].PCode != 1
	and M_CurrentPE.CPE_Active = 1 AND [P_ProcessEndorsement].PSE_Active = 1 
	*/
	END

	COMMIT TRANSACTION [GetBasicInformation]
	END TRY
	BEGIN CATCH
	SELECT 0 as Passed, ERROR_NUMBER() AS ID  ,ERROR_MESSAGE() AS Content;  
	ROLLBACK TRANSACTION [GetBasicInformation]
	END CATCH
END
return @IdRequestInformation
GO


