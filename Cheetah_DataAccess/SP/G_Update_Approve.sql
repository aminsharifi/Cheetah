USE [Pilot]
GO

/****** Object:  StoredProcedure [Cheetah].[G_Update_Approve]    Script Date: 2/11/2023 4:22:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		MohammadAmin Sharifi
-- Create date: 
-- Description:	Cheetah
-- =============================================
CREATE PROCEDURE [Cheetah].[G_Update_Approve]
	-- Add the parameters for the stored procedure here
	@IdRequestInformation bigint = 0
AS
BEGIN	
	SET NOCOUNT ON;
	DECLARE	@return_value int
	DECLARE	@RI_RequestTitle int
	DECLARE @ERP bit
	DECLARE @RI_Requestor int
	DECLARE @CurrentUser int
	DECLARE @RI_UserComment nvarchar(500)
	DECLARE @RI_LastUserAction int
	DECLARE @ERPCode int
	DECLARE @ProcessEndorsements int
	declare @PE_ValidOutput nvarchar(500)
	declare @RI_OutputVar1  nvarchar(500)
	declare @RI_OutputVar2  nvarchar(500)
	declare @RI_OutputVar3  nvarchar(500)
	declare @RI_OutputVar4  nvarchar(500)
	declare @RI_OutputVar5  nvarchar(500)
	declare @RT_OutputVar1  nvarchar(500)
	declare @RT_OutputVar2  nvarchar(500)
	declare @RT_OutputVar3  nvarchar(500)
	declare @RT_OutputVar4  nvarchar(500)
	declare @RT_OutputVar5  nvarchar(500)
	declare @Content nvarchar(500)
	declare @RI_UserAction int
	declare @RecordsNumber int
	declare @CU_Active bit
	BEGIN TRANSACTION [G_Update_Approve]
	BEGIN TRY
	-------------------------------------------
	SELECT TOP (1) @return_value = RI_RequestTitle,
	@RI_UserAction = RI_UserAction FROM [Pilot].[dbo].[RequestInformation]
	where  [idRequestInformation] = @IdRequestInformation	

	IF  @return_value is null RAISERROR ('هیچ رکوردی یافت نشد',16,1);
	else SELECT 1 as Passed,  -1 AS ID  ,@return_value AS Content;  

	select @RecordsNumber = count(*) from Approves
	where Approves.RequestInformation = @IdRequestInformation
	
	-------------------------------------------
	EXEC @RI_RequestTitle = [Cheetah].[GetBasicInformation] @IdRequestInformation
	EXEC @ProcessEndorsements = Get_ProcessEndorsements @IdRequestInformation

	select @RI_Requestor = RI_Requestor, --درخواست کننده
	@ERP = ERP, --IS ERP
	@RI_UserComment = RI_UserComment,
	@RI_LastUserAction = RI_LastUserAction,
	@ERPCode = ERPCode,
	@RI_OutputVar1 = RI_OutputVar1,
	@RI_OutputVar2 = RI_OutputVar2,
	@RI_OutputVar3 = RI_OutputVar3,
	@RI_OutputVar4 = RI_OutputVar4,
	@RI_OutputVar5 = RI_OutputVar5,
	@RT_OutputVar1 = RT_OutputVar1,
	@RT_OutputVar2 = RT_OutputVar2,
	@RT_OutputVar3 = RT_OutputVar3,
	@RT_OutputVar4 = RT_OutputVar4,
	@RT_OutputVar5 = RT_OutputVar5                                    
	from [RequestInformation]
	inner join RequestTitles on RequestInformation.RI_RequestTitle = RequestTitles.idRequestTitles
	inner join UserAction on UserAction.idUserAction = RI_LastUserAction
	where [RequestInformation].idRequestInformation = @IdRequestInformation

	select top(1) @PE_ValidOutput = ProcessEndorsements.PE_ValidOutput from ProcessEndorsements where idProcessEndorsements = @ProcessEndorsements
	
	if @PE_ValidOutput != null 
	begin
		if @PE_ValidOutput like N'%113%' and @RI_OutputVar1 = null  --output1 اجباری و مقدارآن خالی است
			set @Content += @RT_OutputVar1 +N'\\n';
		else if @PE_ValidOutput like N'213' and @RI_OutputVar2 = null --output2
			set @Content += @RT_OutputVar2 + N'\n';
		else if @PE_ValidOutput like N'313' and @RI_OutputVar3 = null --output3
			set @Content += @RT_OutputVar3 + N'\n';
		else if @PE_ValidOutput like N'413' and @RI_OutputVar4 = null --output4
			set @Content += @RT_OutputVar4 + N'\n';
		else if @PE_ValidOutput like N'513' and @RI_OutputVar5 = null --output5
			set @Content += @RT_OutputVar5 + N'\n';
	end
	if len(@Content) > 0
	begin
	set @Content = 'ثبت موارد زیر الزامی است: \\n' + @Content
		RAISERROR (@Content,16,1);
	end

if @RI_UserAction  = null
begin
	if @RecordsNumber = 1 -- تسک اول	
		set @RI_UserAction = 51 --صدور درخواست
	else
		set @RI_UserAction = 2 -- بازنگري
end

update Approves
set Approves_TaskSentDate = GETDATE(),
Approves_UserInCharge = @CurrentUser,
Approves_UserDescription = @RI_UserComment,
Approves_UserAction = @RI_UserAction
where RequestInformation = @IdRequestInformation

/*
var OriginalFile = Me.getXPath(EntName+".RI_Attachment");
//Go through the array of files
for(var i=0; i < OriginalFile.size(); i++)
{
	//Obtain the file data
	var FiletoCopy = OriginalFile.get(i);
	var Name = FiletoCopy.getXPath("FileName");
	var Data = FiletoCopy.getXPath("Data");
	//Copy the file in the file-type attribute of the collection
	var NewFile = Me.getXPath(EntName+".RI_Approves[" + RecordsNumber + "]").addRelation("Approves_Attachment");
	NewFile.setXPath("FileName", Name);
	NewFile.setXPath("Data", Data);
}
*/
update [RequestInformation]
set RI_LastUserInCharge = @CurrentUser
where idRequestInformation = @IdRequestInformation

if @RI_UserAction = 1 -- در صورتی که تایید باشد:
begin
declare @UpdateLastRecord bit
set  @UpdateLastRecord = 0
	
update  TOP (1) CurrentProcessEndorsemen
set CU_User = @CurrentUser, --اولین رکوردی که تایید نشده است تایید می کند
CU_UserAction = 1
from CurrentProcessEndorsemen
inner join UserAction on UserAction.idUserAction = CurrentProcessEndorsemen.idCurrentProcessEndorsemen
where RequestInformation = @IdRequestInformation and CU_Active = 1 and UserAction_Code != 1
END

update [RequestInformation]
set RI_UserComment = null,
RI_ValidUserAction = null
where idRequestInformation = @IdRequestInformation

--if GeneralFunction.General_GetAllApprove(Me) or @RI_UserAction = 3
if 1=1

update [RequestInformation]
set RI_RequestFinishDate = getdate(),
RI_ValidUserAction = null
where idRequestInformation = @IdRequestInformation

if @RI_UserAction = 3
update [RequestInformation] set RI_ProcessState = 4 where idRequestInformation = @IdRequestInformation

--else if((Me.Task.Name != "UpdateERP" && GeneralFunction.General_GetAllApprove(Me)) )	
else if 1 = 1
update [RequestInformation] set RI_ProcessState = 3 where idRequestInformation = @IdRequestInformation -- تایید
--if Me.Task.Name != "UpdateERP" and GeneralFunction.General_GetAllApprove(Me) and @RI_UserAction = 3 and @ERP and @RecordsNumber > 0		
if 1 = 1
begin
update [RequestInformation] set RI_OutputVar5 = 
N'RI_OutputVar1:' + RI_OutputVar1 + N',' + 'RI_OutputVar2:' + RI_OutputVar2+ N','+
'RI_OutputVar3:' + RI_OutputVar3 + N',' + N'RI_OutputVar4:' + RI_OutputVar4
where idRequestInformation = @IdRequestInformation	
end
	--else
		--GeneralFunction.SendERP(Me);	
	-------------------------------------------
    COMMIT TRANSACTION [G_Update_Approve]
	END TRY
	BEGIN CATCH
	SELECT 0 as Passed, ERROR_NUMBER() AS ID  ,ERROR_MESSAGE() AS Content;  
	ROLLBACK TRANSACTION [G_Update_Approve]
	END CATCH
END
GO


