USE [Cheetah]
GO
/****** Object:  StoredProcedure [dbo].[Get_ProcessEndorsements]    Script Date: 2/12/2023 12:58:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		MohammadAmin Sharifi
-- Create date: 
-- Description:	Cheetah
-- =============================================
ALTER PROCEDURE [dbo].[Get_ProcessEndorsements]
	-- Add the parameters for the stored procedure here
	@IdRequestInformation bigint = 0, @IdUser int
AS
BEGIN	
	SET NOCOUNT ON;

	Declare @return_value int,@CU_ProcessEndorsements int,
	@ErrorMessage NVARCHAR(500),@OrgPositions_Name NVARCHAR(500),
	@idOrgPositions int,@RI_RequestNumber int

	BEGIN TRANSACTION [GetBasicInformation]
	BEGIN TRY	
	
    select top(1) @CU_ProcessEndorsements = P_ProcessEndorsement.IdRecord,
	@idOrgPositions = S_OrgPosition.IdRecord,
	@OrgPositions_Name = S_OrgPosition.PName
	from [Masters].M_CurrentPE  --جدول تاییدات
	inner join [Parameters].P_ProcessEndorsement on P_ProcessEndorsement.IdRecord = M_CurrentPE.CPE_ProcessEndorsementsIdRecord
	inner join [Parameters].P_UserAction on P_UserAction .IdRecord = M_CurrentPE.CPE_UserActionIdRecord
	inner join [Systems].S_OrgPosition on S_OrgPosition.IdRecord = P_ProcessEndorsement.IdRecord
	where M_CurrentPE.IdRecord = @RI_RequestNumber and M_CurrentPE.CPE_Active = 1 and CPE_Active = 1 and P_UserAction.PCode != 1

	if @CU_ProcessEndorsements != null
	begin
		update [Masters].[M_RequestInformation] set  RI_ActiveProcessEndorsementIdRecord = @CU_ProcessEndorsements where IdRecord = @IdRequestInformation
	
	--EXEC @IdUser = GeneralGetUser @idOrgPositions --سمت سازمانی به عنوان ورودی ارسال می کنیم و کاربر مرتبط را دریافت می کنیم

	if @IdUser != null
	update [Masters].M_CurrentPE set M_CurrentPE.CPE_UserIdRecord = @IdUser where M_CurrentPE.CPE_ProcessEndorsementsIdRecord = @CU_ProcessEndorsements			
	else
	begin
	set  @ErrorMessage = N'هیچ کاربری متناسب با سمت ' + @OrgPositions_Name +'در چارت وجود ندارد.';
	RAISERROR (@ErrorMessage,16,1);
	end
	end
	else
	RAISERROR ('هیچ رکوردی برای تایید وجود ندارد bizagi',16,1);	
	return @CU_ProcessEndorsements;	
	END TRY
	BEGIN CATCH
	SELECT 0 as Passed, ERROR_NUMBER() AS ID  ,ERROR_MESSAGE() AS Content;  
	ROLLBACK TRANSACTION [GetBasicInformation]
	END CATCH
END
