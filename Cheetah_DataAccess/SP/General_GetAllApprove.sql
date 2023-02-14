USE [Pilot]
GO

/****** Object:  StoredProcedure [Cheetah].[General_GetAllApprove]    Script Date: 2/11/2023 4:22:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		MohammadAmin Sharifi
-- Create date: 
-- Description:	آیا تمام تاییدات را گرفته است؟
-- =============================================
CREATE PROCEDURE [Cheetah].[General_GetAllApprove]
	-- Add the parameters for the stored procedure here
	@IdRequestInformation bigint = 0
AS
BEGIN	
	SET NOCOUNT ON;
	DECLARE	@return_value int
	DECLARE @Approves_Number NVARCHAR(100)
	DECLARE @RI_TaskName NVARCHAR(100)
	DECLARE @CNTApproves int
	DECLARE @CU_ProcessEndorsements int
	DECLARE @PE_ProcessState int
	DECLARE @RI_PE_Level int
	DECLARE @RI_RequestTitle int
	declare @RI_SubRequestTitles int
	BEGIN TRANSACTION [General_GetAllApprove]
	BEGIN TRY
	-------------------------------------------
	EXEC @RI_RequestTitle = [Cheetah].[GetBasicInformation]

	select @RI_PE_Level = RI_PE_Level,
	@RI_SubRequestTitles = RI_SubRequestTitles
	from RequestInformation
	where RequestInformation.idRequestInformation = @IdRequestInformation

	declare @ExistsRecord bit

	select @ExistsRecord = count(*)  from CurrentProcessEndorsemen --در جدول تاییدات رکوردی هست که تایید نشده باشد؟
	inner join UserAction on UserAction.idUserAction = CurrentProcessEndorsemen.CU_UserAction
	inner join ProcessEndorsements on ProcessEndorsements.idProcessEndorsements = CurrentProcessEndorsemen.CU_ProcessEndorsements
	where CurrentProcessEndorsemen.RequestInformation = @IdRequestInformation and UserAction_Code != 1
	and CU_Active = 1 AND PE_Active =1 

	if @ExistsRecord = 0
	begin
		--var a = GeneralFunction.Add_RI_CurrentProcessEndor(Me);
		update RequestInformation set RI_PE_Level = 1 where RequestInformation.idRequestInformation = @IdRequestInformation
		select @ExistsRecord = count(*)  from CurrentProcessEndorsemen --در جدول تاییدات رکوردی هست که تایید نشده باشد؟
		inner join UserAction on UserAction.idUserAction = CurrentProcessEndorsemen.CU_UserAction
		inner join ProcessEndorsements on ProcessEndorsements.idProcessEndorsements = CurrentProcessEndorsemen.CU_ProcessEndorsements
		where CurrentProcessEndorsemen.RequestInformation = @IdRequestInformation and UserAction_Code != 1
		and CU_Active = 1 AND PE_Active =1 
	end

	if @ExistsRecord = 0
	update RequestInformation set RI_ProcessState = 3 where RequestInformation.idRequestInformation = @IdRequestInformation --وضعیت در حال بررسی
	-------------------------------------------
	SELECT 1 as Passed,  -1 AS ID  , @ExistsRecord AS Content;  
	-------------------------------------------
    COMMIT TRANSACTION [General_GetAllApprove]
	END TRY
	BEGIN CATCH
	SELECT 0 as Passed, ERROR_NUMBER() AS ID  ,ERROR_MESSAGE() AS Content;  
	ROLLBACK TRANSACTION [General_GetAllApprove]
	END CATCH
END
GO


