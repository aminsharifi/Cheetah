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
ALTER PROCEDURE [G_SetInitialValues]
	  @JsonInput nvarchar(max)
AS
BEGIN	
	SET NOCOUNT ON;

	BEGIN --DECLARATION
	declare @InputTable table ([key] nvarchar(max),[Value] nvarchar(max),[type] int);
	declare @OutputTable table ([key] nvarchar(max),[Value] nvarchar(max),[type] int);
	declare @ArrayList table(idUser int)
	declare @List_idUser table(idUser int,idRole int)
	DECLARE	@return_value int

	end

	BEGIN TRANSACTION [GetBasicInformation]

	BEGIN TRY
	
	insert into @InputTable
	SELECT * FROM OPENJSON(@JsonInput)

	begin --Read from JSON

	select * into #TempInputTable from @InputTable

	DECLARE @cols AS NVARCHAR(MAX), @query  AS NVARCHAR(MAX)

	select @cols = STUFF((SELECT ',' + QUOTENAME([key]) 
                    from @InputTable
            FOR XML PATH(''), TYPE
            ).value('.', 'NVARCHAR(MAX)') 
        ,1,1,'')

	set @query = N'SELECT ' + @cols + N' into ##MyTempTable from 
             (
                select [Value], [key]
                from #TempInputTable
            ) x
            pivot 
            (
                max(value)
                for [key] in (' + @cols + N')
            ) p '

	IF OBJECT_ID('tempdb..##MyTempTable') IS NOT NULL
	begin
			drop table ##MyTempTable
	end

	exec sp_executesql @query;
	declare @key VARCHAR(MAX),@Value VARCHAR(MAX),@HeaderSQL VARCHAR(MAX),@FooterSQL VARCHAR(MAX);

	end

	begin --Insert or Update BasicInformation
	if (select count(*) cnt FROM @InputTable where [key] = N'IdRecord') = 0 
	begin
		set @HeaderSQL = N'INSERT INTO [Masters].[M_RequestInformation] ( ';
		set @FooterSQL = N'SELECT ';

		DECLARE c CURSOR LOCAL FAST_FORWARD FOR
			   SELECT [key] FROM @InputTable;
		OPEN c;
		FETCH NEXT FROM c INTO @key;

		WHILE @@FETCH_STATUS = 0
		BEGIN
		set @HeaderSQL = @HeaderSQL + @key + N','
		set @FooterSQL = @FooterSQL + @key+ N','
		FETCH NEXT FROM c INTO @key;
		END
		CLOSE c;
		DEALLOCATE c;
		set @HeaderSQL = substring(@HeaderSQL, 1, (len(@HeaderSQL) - 1)) + N')'
		set @FooterSQL = substring(@FooterSQL, 1, (len(@FooterSQL) - 1)) + N' FROM ##MyTempTable'
		EXEC(@HeaderSQL+@FooterSQL); 
		SELECT @return_value = @@IDENTITY
	end
	else
	begin
		select top(1) @return_value = [Value] FROM @InputTable where [key] = N'IdRecord'
		
		set @HeaderSQL = N'UPDATE  [Masters].[M_RequestInformation] set ';
	
		DECLARE c CURSOR LOCAL FAST_FORWARD FOR
			   SELECT [key],[Value] FROM @InputTable;
		OPEN c;
		FETCH NEXT FROM c INTO @key,@Value;

		WHILE @@FETCH_STATUS = 0
		BEGIN
		if @key != N'IdRecord'
		set @HeaderSQL = @HeaderSQL +  @key + N'=''' + @Value + N''','
		FETCH NEXT FROM c INTO @key,@Value;
		END
		CLOSE c;
		DEALLOCATE c;	
		set @HeaderSQL = substring(@HeaderSQL, 1, (len(@HeaderSQL) - 1)) + N' where IdRecord = ' +  CAST(@return_value as nvarchar(50))
		EXEC(@HeaderSQL);
		
	end
	/*
	IF  @return_value is null RAISERROR ('هیچ رکوردی یافت نشد',16,1);
	else SELECT 1 as Passed,  -1 AS ID  ,@return_value AS Content;  
	*/
	end	
	COMMIT TRANSACTION [GetBasicInformation]
	END TRY
	BEGIN CATCH
	SELECT 0 as Passed, ERROR_NUMBER() AS ID  ,ERROR_MESSAGE() AS Content;  
	ROLLBACK TRANSACTION [GetBasicInformation]
	END CATCH
    return  @return_value
END
GO