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

	BEGIN TRANSACTION [PerformRequest]

	BEGIN TRY
	
	BEGIN --Set Variable

	EXEC	@IdRequestInformation = [dbo].[G_SetInitialValues] @JsonInput

	select * into #TempView_M_RequestInformation FROM View_M_RequestInformation
	where M_RequestInformation_IdRecord = @IdRequestInformation

	select * into #TempView_P_ProcessEndorsement from View_P_ProcessEndorsement
	where View_P_ProcessEndorsement.CPE_M_RequestInformationIdRecord = @IdRequestInformation and CPE_Active = 1

	END

	COMMIT TRANSACTION [PerformRequest]
	END TRY
	BEGIN CATCH
	SELECT 0 as Passed, ERROR_NUMBER() AS ID  ,ERROR_MESSAGE() AS Content;  
	ROLLBACK TRANSACTION [PerformRequest]
	END CATCH
END
return @IdRequestInformation
GO