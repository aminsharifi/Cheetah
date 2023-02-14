USE [Cheetah]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[PerformRequest]
		@JsonInput =  N'
						  {
							"IdRecord":6,"IsTest":0,"RI_ERPID":10,"RI_ConditionDrug": 1,"RI_SupplierSHare": 1,
							"RI_ConditionOccur1": 1 ,"RI_ConditionOccur2": 0, "RI_UserNameCreator": "ma.sharifi"
						  }
						'

SELECT @return_value
--"IdRecord": 0,
GO
