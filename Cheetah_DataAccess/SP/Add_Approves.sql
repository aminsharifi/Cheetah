USE [Cheetah]
GO

/****** Object:  StoredProcedure [Cheetah].[Add_Approves]    Script Date: 2/11/2023 4:21:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		MohammadAmin Sharifi
-- Create date: 
-- Description:	Cheetah
-- =============================================
CREATE PROCEDURE [Add_Approves]
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
	BEGIN TRANSACTION [GetBasicInformation]
	BEGIN TRY
	select @CNTApproves = count(*) from Approves where Approves.RequestInformation = @IdRequestInformation
	set @Approves_Number = @IdRequestInformation + N'-' + @CNTApproves + 1 -- شماره فعالیت در جدول تاریخچه اقدامات	
	EXEC @CU_ProcessEndorsements = [Cheetah].[Get_ProcessEndorsements] @IdRequestInformation
	select top(1) @PE_ProcessState = PE_ProcessState from ProcessEndorsements
	where idProcessEndorsements = @CU_ProcessEndorsements
	INSERT --درج رکورد جدید فهرست تاییدات
	INTO Approves(
	Approves_TaskRecieveDate,--تاریخ دریافت فرم
	Approves_Number, --شماره درخواست
	Approves_Subject, -- نام فرم	
	RequestInformation)
	VALUES (getdate(),@Approves_Number,@RI_TaskName,@IdRequestInformation)

	update RequestInformation set RI_ProcessState = @PE_ProcessState
	where IdRequestInformation = @IdRequestInformation -- وضعیت فرایند(در دست بررسی) 	
	--GeneralFunction.SendERP(Me); --فرم ارسال به erp در اقدامات کاربر	
	SELECT 1 as Passed,  -1 AS ID  ,@return_value AS Content;  
	-------------------------------------------
    COMMIT TRANSACTION [GetBasicInformation]
	END TRY
	BEGIN CATCH
	SELECT 0 as Passed, ERROR_NUMBER() AS ID  ,ERROR_MESSAGE() AS Content;  
	ROLLBACK TRANSACTION [GetBasicInformation]
	END CATCH
END
GO


