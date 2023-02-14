USE [Pilot]
GO

/****** Object:  StoredProcedure [Cheetah].[GeneralGetUser]    Script Date: 2/11/2023 4:22:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		MohammadAmin Sharifi
-- Create date: 
-- Description:	Cheetah
-- =============================================
CREATE PROCEDURE [Cheetah].[GeneralGetUser]
	-- Add the parameters for the stored procedure here
	@OrgPositions int,
	@IdRequestInformation bigint = 0
AS
BEGIN	
	SET NOCOUNT ON;
	DECLARE	@return_value int
	DECLARE	@RI_RequestTitle int
	DECLARE	@RI_Location int --موقعیت سازمانی مانند برنامه ریزی
	DECLARE	@ERPID int
	DECLARE	@DuplicateID int
	DECLARE	@RI_RequestType int
	DECLARE	@RI_RequestNumber int
	DECLARE	@RI_UserNameCreator NVARCHAR(255)
	DECLARE	@Content NVARCHAR(255)
	DECLARE	@RI_ERPBranchs int
	DECLARE	@RI_Requestor int --درخواست کننده
	DECLARE @ActiveBossUser int --مدیر
	DECLARE @RI_ERPKindID int
	DECLARE @RI_UnitType int -- واحد داروئی/مصرفی
	DECLARE @RI_Area int
	DECLARE @RT_ConditionDrug bit
    DECLARE @RT_ConditionFMCG bit
	DECLARE @ErrorMessage NVARCHAR(500)
	DECLARE @OrgPositions_Name NVARCHAR(500)
	DECLARE @OrgPositions_User  int
	DECLARE @OrgPositions_Role  int
	DECLARE @OrgPositions_Role2 int
	DECLARE @OP_MedicineRole  int
	DECLARE @OP_FMCGRole int
	DECLARE @OrgPositions_Group bit --اگر در سطح ستاد باشد مرکز را دیگر بررسی نمیکند
	DECLARE @RI_Inputuser1 NVARCHAR(500)
	declare @List_idUser table(idUser int,idRole int)
	DECLARE @Role NVARCHAR(500)
	DECLARE @BossUser int

	BEGIN TRANSACTION [GeneralGetUser]
	BEGIN TRY
	----------------------------------------------------------------------
	SELECT TOP (1) @ERPID = ERPID, @RI_RequestType = RI_RequestType,
	@RI_UserNameCreator = RI_UserNameCreator,
	@RI_ERPBranchs = RI_ERPBranchs, 
	@RI_ERPKindID = RI_ERPKindID,
	@RI_UnitType = RI_UnitType, @RI_Location = RI_Location
	FROM [Pilot].[dbo].[RequestInformation]
	where [idRequestInformation] = @IdRequestInformation	

	select top(1) @OrgPositions_User = OrgPositions_User, @OrgPositions_Role = OrgPositions_Role,
	@OrgPositions_Role2 = OrgPositions_Role2, @OP_MedicineRole = OP_MedicineRole,
	@OP_FMCGRole = OP_FMCGRole, @OrgPositions_Group = OrgPositions_Group
	from OrgPositions where idOrgPositions = @OrgPositions

	if @OrgPositions_Group = 1
		set @RI_Location = 23;
    
	-----------------------------------------------------------------------
if @OrgPositions = 701 --سرپرست مستقيم
begin

	exec @RI_RequestTitle = [Cheetah].[GetBasicInformation] @IdRequestInformation
	exec @BossUser = [Cheetah].[GetActiveBossUser] @RI_RequestTitle,@RI_Requestor

	set @ActiveBossUser = 1
	if @ActiveBossUser != -1  --کاربری پیدا شد
			--myAL.Add(UserID);
			set @ActiveBossUser = 1
end
	if @OrgPositions = 1202 AND @RI_Inputuser1 != null --کارشناس دريافتي
		insert into @List_idUser select idUser, enabled from WFUSER where userName in(@RI_Inputuser1) -- به ازای لیست دریافتی در کالکشن درج می کند

	else if @OrgPositions_User != null --ایفاکننده
		insert into @List_idUser select idUser,1 from WFUSER where idUser in(@OrgPositions_User) and enabled = 1	
	
	else if @OrgPositions_Role != null
		set @Role =  N',' + @OrgPositions_Role --نقش

	else if @OrgPositions_Role2 != null	
		set @Role = @Role + N',' + @OrgPositions_Role2 --نقش جایگزین

	else if @RI_UnitType = 2 and @OP_MedicineRole != null --اگه واحد داروئی باشد
		set @Role = ',' + @OP_MedicineRole
		
	else if @RI_UnitType = 3 and @OP_FMCGRole != null --مصرفی
		set @Role = N',' + @OP_FMCGRole
		
	set @Role = RIGHT(@Role, LEN(@Role) - 1) --کاما را پاک میکند
	insert into @List_idUser 
	SELECT WFUSER.idUser,USERROLE.idRole FROM dbo.WFUSER
	INNER JOIN  dbo.USERROLE ON dbo.USERROLE.idUser = WFUSER.idUser 
	WHERE WFUSER.enabled = 1 AND WFUSER.idUnitType in(1,@RI_UnitType) 
	and (exists(select * from Split((select top(1) RelatedLocation from WFUSER as
	WFUSER2 where WFUSER.idUser = WFUSER2.idUser), ',') as sp2 where sp2.Item = @RI_Location) 
	OR exists(select * from Split((select top(1) DistrictManager_RelatedL
	from WFUSER as WFUSER2 where WFUSER.idUser = WFUSER2.idUser), ',') as sp2
	where sp2.Item = @RI_Location))
	and exists(select * from Split(@Role, ',') as sp2 where sp2.Item = dbo.USERROLE.idRole) --کاربرانی که دارای نقش تعیین شده است بر می گرداند	
	-----------------------------------------------------------------------
	COMMIT TRANSACTION [GeneralGetUser]
	END TRY
	BEGIN CATCH
	SELECT 0 as Passed, ERROR_NUMBER() AS ID  ,ERROR_MESSAGE() AS Content;  
	ROLLBACK TRANSACTION [GetBasicInformation]
	END CATCH
END
GO


