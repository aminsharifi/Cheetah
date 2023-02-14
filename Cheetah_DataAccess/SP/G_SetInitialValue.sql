USE [Pilot]
GO

/****** Object:  StoredProcedure [Cheetah].[G_SetInitialValue]    Script Date: 2/11/2023 4:22:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		MohammadAmin Sharifi
-- Create date: 
-- Description:	Cheetah
-- =============================================
CREATE PROCEDURE [Cheetah].[G_SetInitialValue]
	-- Add the parameters for the stored procedure here
	@IdRequestInformation bigint = 0
AS
BEGIN	
	SET NOCOUNT ON;

	Declare @return_value int
	DECLARE	@RI_RequestTitle int
	DECLARE	@RI_Location int
	DECLARE	@ERPID int
	DECLARE	@DuplicateID int
	DECLARE	@RI_RequestType int
	DECLARE	@RI_RequestNumber int
	DECLARE	@RI_UserNameCreator NVARCHAR(255)
	DECLARE	@Content NVARCHAR(255)
	DECLARE	@RI_ERPBranchs int
	DECLARE	@RI_Requestor int
	DECLARE @RI_ERPKindID int
	DECLARE @RI_UnitType int
	DECLARE @RI_Area int
	DECLARE @RT_ConditionDrug bit
    DECLARE @RT_ConditionFMCG bit

	BEGIN TRANSACTION [GetBasicInformation]
	BEGIN TRY	
	exec @RI_RequestTitle = [Cheetah].[GetBasicInformation] @IdRequestInformation
	
	SELECT TOP (1) @ERPID = ERPID, @RI_RequestType = RI_RequestType,@RI_UserNameCreator = RI_UserNameCreator,
	@RI_ERPBranchs = RI_ERPBranchs,
	@RI_ERPKindID = RI_ERPKindID,
	@RI_UnitType = RI_UnitType
	FROM [Pilot].[dbo].[RequestInformation]
	where [idRequestInformation] = @IdRequestInformation	

	IF @ERPID is null   
	BEGIN
    RAISERROR ('لطفا ERPID را وارد نمایید',16,1);
	END
	ELSE
	BEGIN
	select top(1) @DuplicateID = idRequestInformation
	from [Pilot].[dbo].[RequestInformation]
	where  ERPID = @ERPID and RI_IsCancelled = 0
	and RI_RequestFinishDate IS NULL
	and RI_RequestTitle = @RI_RequestTitle
	IF @DuplicateID is not null   
	BEGIN
	set @Content = N'پیشین برای این مورد درخواستی با شماره رهگیری ' + @ERPID + N' در سیستم ثبت شده است.'
		RAISERROR (@Content,16,1);
	END	
	IF @RI_RequestType is not null  
	update RequestInformation set RI_RequestType = 1 where [idRequestInformation] = @IdRequestInformation
	
	IF @RI_RequestNumber is not null
	BEGIN
	
	IF @RI_UserNameCreator is not null
	begin
		select top(1) @RI_UnitType = @RI_UnitType ,@RI_Requestor = iduser,
		@RI_Area = wfuser.idArea
		from wfuser where username = @RI_UserNameCreator		
	    update [Pilot].[dbo].[RequestInformation] set RI_Requestor = @RI_Requestor where [idRequestInformation] = @IdRequestInformation	
		
		end
		update [Pilot].[dbo].[RequestInformation] set RI_RequestDate = getdate(),
		RI_PERequestDate = FORMAT(getdate() ,'yyyy/MM/dd','fa') ,
		RI_RequestID = @IdRequestInformation,
		RI_RequestNumber = @IdRequestInformation
		where [idRequestInformation] = @IdRequestInformation	
		
		IF @RI_ERPBranchs is not null 
		update [Pilot].[dbo].[RequestInformation] set RI_Location = (SELECT TOP (1) idLocation FROM [Pilot].[dbo].LOCATION WHERE locDescription = @RI_ERPBranchs) where [idRequestInformation] = @IdRequestInformation	
		else
		update [Pilot].[dbo].[RequestInformation] set RI_Location = (select top(1) idLocation from wfuser where iduser = @RI_Requestor) where [idRequestInformation] = @IdRequestInformation	
		
		if @RI_ERPKindID != null and @RI_UnitType is null and @RI_ERPKindID != 4 -- ماهیت کل انتخاب نشده باشد
			update [Pilot].[dbo].[RequestInformation] set RI_UnitType = (SELECT TOP (1) idUnitType FROM UnitType WHERE UT_KindID = @RI_UnitType) 

		else if @RI_UnitType is not null
		update [Pilot].[dbo].[RequestInformation] set RI_UnitType = @RI_UnitType where [idRequestInformation] = @IdRequestInformation		
		else 
		update [Pilot].[dbo].[RequestInformation] set RI_UnitType = 152 where [idRequestInformation] = @IdRequestInformation	--نامشخص
	
		if @RI_Area is null
		update [Pilot].[dbo].[RequestInformation] set RI_Area = @RI_Area where [idRequestInformation] = @IdRequestInformation	

		if @RI_UnitType = 2
		update [Pilot].[dbo].[RequestInformation] set RT_ConditionDrug = 1 where [idRequestInformation] = @IdRequestInformation	
		
		if @RI_UnitType = 3
		update [Pilot].[dbo].[RequestInformation] set RT_ConditionDrug = 1 where [idRequestInformation] = @IdRequestInformation			
	END

	IF  @return_value is null RAISERROR ('هیچ رکوردی یافت نشد',16,1);
	else SELECT 1 as Passed,  -1 AS ID  ,@return_value AS Content;  
    
	COMMIT TRANSACTION [GetBasicInformation]
	END
	
	END TRY
	BEGIN CATCH
	SELECT 0 as Passed, ERROR_NUMBER() AS ID  ,ERROR_MESSAGE() AS Content;  
	ROLLBACK TRANSACTION [GetBasicInformation]
	END CATCH
END
GO


