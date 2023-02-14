USE [Pilot]
GO

/****** Object:  StoredProcedure [Cheetah].[Set_TaskName]    Script Date: 2/11/2023 4:22:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		MohammadAmin Sharifi
-- Create date: 
-- Description:	Cheetah
-- =============================================
Create PROCEDURE [Cheetah].[Set_TaskName]
	-- Add the parameters for the stored procedure here
	@IdRequestInformation bigint = 0
AS
BEGIN	
	SET NOCOUNT ON;
	DECLARE	@return_value int
	BEGIN TRANSACTION [GetBasicInformation]
	BEGIN TRY
	-------------------------------------------
	SELECT TOP (1) @return_value = RI_RequestTitle FROM [Pilot].[dbo].[RequestInformation]
	where  [idRequestInformation] = @IdRequestInformation	
	IF  @return_value is null RAISERROR ('هیچ رکوردی یافت نشد',16,1);
	else SELECT 1 as Passed,  -1 AS ID  ,@return_value AS Content;  
	-------------------------------------------
	UPDATE ProcessEndorsements SET PE_TaskName = ProcessEndorsements.PE_TaskName --درج نام فرم از جدول تاییدات	
	FROM ProcessEndorsements INNER JOIN
	RequestInformation ON ProcessEndorsements.idProcessEndorsements = RequestInformation.RI_ActiveProcessEndorseme
	-------------------------------------------
    COMMIT TRANSACTION [GetBasicInformation]
	END TRY
	BEGIN CATCH
	SELECT 0 as Passed, ERROR_NUMBER() AS ID  ,ERROR_MESSAGE() AS Content;  
	ROLLBACK TRANSACTION [GetBasicInformation]
	END CATCH
END
GO


