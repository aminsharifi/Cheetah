USE [Pilot]
GO

/****** Object:  StoredProcedure [Cheetah].[Add_ProcessEndorsment]    Script Date: 2/11/2023 4:21:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		MohammadAmin Sharifi
-- Create date: 
-- Description:	Cheetah
-- =============================================
CREATE PROCEDURE [Cheetah].[Add_ProcessEndorsment]
	-- Add the parameters for the stored procedure here
	@IdRequestInformation bigint = 0
AS
BEGIN	
	SET NOCOUNT ON;
	DECLARE	@return_value int
	BEGIN TRANSACTION [Add_ProcessEndorsment]
	BEGIN TRY

	declare @RI_LastUserAction int
	declare @RI_SubRequestTitles int
	declare @UserRelationship int
	declare @UserRelationship_Code int
	declare @RequestTitles int
	declare @MCL_RowNumber int = 0
	declare @ArrayList table(idUser int)
	declare @RecordsNumber int = 0
	declare @Con1 bit
	declare @CurCon1 bit
	declare @Con2 bit
	declare @CurCon2 bit
	declare @Con3 bit
	declare @CurCon3 bit
	declare @Con4 bit
	declare @CurCon4 bit
	declare @Con5 bit
	declare @CurCon5 bit
	declare @ConDrug bit
	declare @ConFMCG bit
	declare @CurDrug bit
	declare @CurFMCG bit
	declare @ConSupplierSHare bit
	declare @ConAlborzSHare bit
	declare @CurSupplierSHare bit
	declare @CurAlborzSHare bit
	declare @idProcessEndorsements int
	declare @PE_Transcript int
	declare @OrgPositions_Group bit
	declare @idOrgPositions int
	declare @RT_RemoveRequestorApproval bit
	declare @RI_Requestor int
	select top(1) @RI_LastUserAction = RI_LastUserAction,
	@RT_RemoveRequestorApproval = RT_RemoveRequestorApproval,
	@RI_SubRequestTitles = RI_SubRequestTitles,
	@UserRelationship_Code = UserRelationship_Code,
	@RequestTitles = RI_RequestTitle,
	@RI_Requestor = RI_Requestor
	from RequestInformation
	inner join wfuser on wfuser.idUser = RI_Requestor
	inner join UserRelationship on UserRelationship.idUserRelationship = wfuser.id1
	inner join RequestTitles on .RequestTitles.idRequestTitles = RequestInformation.RI_RequestTitle
	where [idRequestInformation] = @IdRequestInformation

	if @RI_LastUserAction = 2
		DELETE FROM CurrentProcessEndorsemen WHERE CurrentProcessEndorsemen.RequestInformation = @IdRequestInformation
	else -- اگر رد نشده باشد
		select @RecordsNumber = max(CurrentProcessEndorsemen.idCurrentProcessEndorsemen) FROM CurrentProcessEndorsemen WHERE CurrentProcessEndorsemen.RequestInformation = @IdRequestInformation and CU_Active = 1 AND CU_UserAction = 1
	
		SELECT @Con1 = dbo.ProcessEndorsements.PE_Conditional,
		@Con2 = dbo.ProcessEndorsements.PE_Conditional2, --گرفتن اطلاعات جدول تاییدات
		@Con3 = dbo.ProcessEndorsements.PE_Conditional3, 
		@Con4 = dbo.ProcessEndorsements.PE_Conditional4,
		@Con5 = dbo.ProcessEndorsements.PE_Conditional5, 
		@ConDrug = dbo.ProcessEndorsements.RT_ConditionDrug,
		@ConFMCG = dbo.ProcessEndorsements.RT_ConditionFMCG,
		@ConSupplierSHare = dbo.ProcessEndorsements.RT_SupplierSHare,
		@ConAlborzSHare = dbo.ProcessEndorsements.RT_AlborzSHare,
		@PE_Transcript = dbo.ProcessEndorsements.PE_Transcript,
		@idProcessEndorsements = dbo.ProcessEndorsements.idProcessEndorsements,
		@OrgPositions_Group = dbo.OrgPositions.OrgPositions_Group,
		@idOrgPositions= dbo.OrgPositions.idOrgPositions 
		FROM dbo.ProcessEndorsements INNER JOIN 
		dbo.OrgPositions ON dbo.ProcessEndorsements.PE_OrgPositions = dbo.OrgPositions.idOrgPositions 
		WHERE (dbo.ProcessEndorsements.dsblProcessEndorsements = 0) 
		AND (ProcessEndorsements.PE_RequestTitles = @RequestTitles) and PE_Active = 1
	
	AND (@RI_SubRequestTitles = null or (select count(*) from [dbo].[Split](ProcessEndorsements.PE_SubRequestTitles ,N',') as spt where spt.Item = @RI_SubRequestTitles) > 0)
	AND (@UserRelationship = null or ( ProcessEndorsements.PE_UserRelationship is null OR (select count(*) from [dbo].[Split](ProcessEndorsements.PE_UserRelationship ,N',') as spt where spt.Item = @UserRelationship) > 0))
	AND ProcessEndorsements.PE_ApproveOrder > @RecordsNumber
	ORDER BY ProcessEndorsements.PE_ApproveOrder

	DECLARE @Counter int = 0

	WHILE @Counter < 20
	BEGIN
		SET @Counter = @Counter + 1
		--شروط جدول تاییدات فرایندی خوانده می شود
		declare @AddRecord bit = 0
		if @AddRecord = 0
		and (@Con1 = 0 or (@Con1 = 0 and @CurCon1 = 0))
		and (@Con2 = 0 or (@Con2 = 0 and @CurCon2 = 0))
		and (@Con3 = 0 or (@Con3 = 0 and @CurCon3 = 0))
		and (@Con4 = 0 or (@Con4 = 0 and @CurCon4 = 0))
		and (@Con5 = 0 or (@Con5 = 0 and @CurCon5 = 0))
		AND (@ConDrug = 0 or (@ConDrug = 1 and @CurDrug = 1))
		AND (@ConFMCG = 0 or (@ConFMCG = 1 and @CurFMCG = 1))
		AND (@ConSupplierSHare  = 0 or (@ConSupplierSHare = 1 and @CurSupplierSHare = 1))
		AND (@ConAlborzSHare = 0 or (@ConAlborzSHare = 1 and @CurAlborzSHare = 1))
		set @AddRecord = 1;

		if @AddRecord = 1
		begin
		--GeneralGetUser = GeneralFunction.GeneralGetUser(Me,Result.Tables[0].Rows[Counter]["idOrgPositions"]);
		declare @GeneralGetUser int = 1
		if @GeneralGetUser > 0
		begin
		declare @ExistsRecord bit = 0 -- تنها کاربرانی که در جدول تاییدات نیستند اضافه شود
			if @RT_RemoveRequestorApproval = 1 --اگر فیلد حذف تایید درخواست کننده تیک خورده بود تایید درخواست کننده حذف شود
			begin
			declare @GeneralGetUserCount int = 2
			-------------------
			DECLARE @m INT = 0
			WHILE ( @Counter <= @GeneralGetUserCount)
			BEGIN
			SET @m  = @m  + 1 --وجود دلزد یا نه؟ اگه درخواست کننده با تایید کننده یکی بود دیگه به جدول تاییدات اضافه نشود			
			if @RI_Requestor = @GeneralGetUserCount
				set @ExistsRecord = 1;
			END
			-------------------
			end
		
		if @ExistsRecord = 0
		begin
		select @ExistsRecord = count(*) from CurrentProcessEndorsemen --در صورتی که تایید کننده تکراری باشد ایجاد نکند
		where CU_ProcessEndorsements= @idProcessEndorsements
		if @ExistsRecord = 0
		begin
		select 0
		INSERT INTO [dbo].[CurrentProcessEndorsemen]
           ([CU_ProcessEndorsements],[RequestInformation],[CU_Active],[CU_User])
		VALUES (@idProcessEndorsements,@IdRequestInformation,1,@GeneralGetUser)
		end
		end


		end
		end

	END
    COMMIT TRANSACTION [Add_ProcessEndorsment]
	END TRY
	BEGIN CATCH
	SELECT 0 as Passed, ERROR_NUMBER() AS ID  ,ERROR_MESSAGE() AS Content;  
	ROLLBACK TRANSACTION [Add_ProcessEndorsment]
	END CATCH
END
GO


