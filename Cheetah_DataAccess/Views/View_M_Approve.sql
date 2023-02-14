USE [Cheetah]
GO

/****** Object:  View [dbo].[View_M_Approve]    Script Date: 2/14/2023 1:36:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_M_Approve]
AS
SELECT        Masters.M_Approve.IdRecord AS APV_IdRecord, Masters.M_Approve.APV_TaskRecieveDate, Masters.M_Approve.APV_TaskSentDate, Masters.M_Approve.APV_UserDescription, Masters.M_Approve.APV_Subject, 
                         Masters.M_Approve.APV_Number, Masters.M_Approve.APV_RequestInformationIdRecord, Masters.M_Approve.APV_UserActionIdRecord, Masters.M_Approve.APV_UserInChargeIdRecord, 
                         Parameters.P_UserAction.UA_ValidActions, Parameters.P_UserAction.UA_Abbreviation, Parameters.P_UserAction.UA_UserActionGroupIdRecord, Parameters.P_UserAction.PCode AS UA_PCode, 
                         Parameters.P_UserAction.PName AS UA_PName, Parameters.P_UserActionGroup.PCode AS UAG_PCode, Parameters.P_UserActionGroup.PName AS UAG_PName, Masters.M_Approve.PCode AS APV_PCode, 
                         Masters.M_Approve.PCost AS APV_PCost, Masters.M_Approve.PDescription AS APV_PDescription, Masters.M_Approve.PERPCode AS APV_PERPCode, Masters.M_Approve.PName AS APV_PName
FROM            Masters.M_Approve LEFT OUTER JOIN
                         Parameters.P_UserAction ON Masters.M_Approve.APV_UserActionIdRecord = Parameters.P_UserAction.IdRecord LEFT OUTER JOIN
                         Parameters.P_UserActionGroup ON Parameters.P_UserAction.UA_UserActionGroupIdRecord = Parameters.P_UserActionGroup.IdRecord AND 
                         Parameters.P_UserAction.UA_UserActionGroupIdRecord = Parameters.P_UserActionGroup.IdRecord AND Parameters.P_UserAction.UA_UserActionGroupIdRecord = Parameters.P_UserActionGroup.IdRecord
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1[56] 3) )"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1[78] 4) )"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 9
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = -207
      End
      Begin Tables = 
         Begin Table = "M_Approve (Masters)"
            Begin Extent = 
               Top = 47
               Left = 249
               Bottom = 362
               Right = 500
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "P_UserAction (Parameters)"
            Begin Extent = 
               Top = 46
               Left = 549
               Bottom = 352
               Right = 797
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "P_UserActionGroup (Parameters)"
            Begin Extent = 
               Top = 46
               Left = 845
               Bottom = 341
               Right = 1070
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
      PaneHidden = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3270
         Alias = 2715
         Table = 3120
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_M_Approve'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_M_Approve'
GO


