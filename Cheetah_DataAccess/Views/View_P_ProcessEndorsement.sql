USE [Cheetah]
GO

/****** Object:  View [dbo].[View_P_ProcessEndorsement]    Script Date: 2/14/2023 1:38:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_P_ProcessEndorsement]
AS
SELECT        Parameters.P_ProcessEndorsement.PSE_TaskName, Parameters.P_ProcessEndorsement.PSE_ValidUserAction, Parameters.P_ProcessEndorsement.PSE_Active, Parameters.P_ProcessEndorsement.PSE_ValidOutput, 
                         Parameters.P_ProcessEndorsement.PSE_SendAll, Parameters.P_ProcessEndorsement.PSE_UserRelationshipIdRecord, Parameters.P_UserRelationship.PCode AS UserRelationship_PCode, 
                         Parameters.P_UserRelationship.PName AS UserRelationship_PName, Parameters.P_UserRelationship.IdRecord AS P_UserRelationship_IdRecord, Parameters.P_ProcessEndorsement.PSE_CommonConditionIdRecord, 
                         Parameters.P_ProcessEndorsement.PCode AS APE_PCode, Parameters.P_ProcessEndorsement.PName AS APE_PName, Parameters.P_ProcessEndorsement.PIndex AS APE_PIndex, 
                         Parameters.P_ProcessEndorsement.PERPCode AS APE_PERPCode, Parameters.P_ProcessEndorsement.PSE_RequestTitleIdRecord, Parameters.P_ProcessEndorsement.PSE_ProcessStateIdRecord, 
                         Parameters.P_ProcessEndorsement.PSE_PONIdRecord, Parameters.P_ProcessEndorsement.PSE_ExpertUserIdRecord, Parameters.P_ProcessEndorsement.PSE_SubRequestTitles, 
                         Parameters.P_ProcessEndorsement.PSE_Transcript, Masters.M_CurrentPE.IdRecord AS CPE_IdRecord, Masters.M_CurrentPE.CPE_ProcessEndorsementsIdRecord, Masters.M_CurrentPE.CPE_UserActionIdRecord, 
                         Masters.M_CurrentPE.CPE_UserIdRecord, Masters.M_CurrentPE.DsblRecord AS CPE_DsblRecord, Masters.M_CurrentPE.CPE_Active, 
                         Masters.M_CurrentPE.M_RequestInformationIdRecord AS CPE_M_RequestInformationIdRecord, Parameters.P_UserAction.PCode AS UA_PCode, Parameters.P_UserAction.PName AS UA_PName, 
                         Parameters.P_UserAction.PIndex AS UA_PIndex, Parameters.P_UserAction.PERPCode AS UA_PERPCode, Parameters.P_UserAction.PDescription AS UA_PDescription, 
                         Parameters.P_UserAction.DsblRecord AS UA_DsblRecord
FROM            Parameters.P_UserAction RIGHT OUTER JOIN
                         Masters.M_CurrentPE ON Parameters.P_UserAction.IdRecord = Masters.M_CurrentPE.CPE_UserActionIdRecord AND Parameters.P_UserAction.IdRecord = Masters.M_CurrentPE.CPE_UserActionIdRecord LEFT OUTER JOIN
                         Parameters.P_ProcessEndorsement ON Masters.M_CurrentPE.CPE_ProcessEndorsementsIdRecord = Parameters.P_ProcessEndorsement.IdRecord LEFT OUTER JOIN
                         Parameters.P_UserRelationship ON Parameters.P_ProcessEndorsement.PSE_UserRelationshipIdRecord = Parameters.P_UserRelationship.IdRecord
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
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
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
         Configuration = "(H (1[28] 4) )"
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
         Left = -216
      End
      Begin Tables = 
         Begin Table = "P_UserAction (Parameters)"
            Begin Extent = 
               Top = 38
               Left = 247
               Bottom = 388
               Right = 531
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "M_CurrentPE (Masters)"
            Begin Extent = 
               Top = 1
               Left = 594
               Bottom = 372
               Right = 904
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "P_ProcessEndorsement (Parameters)"
            Begin Extent = 
               Top = 46
               Left = 1085
               Bottom = 396
               Right = 1364
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "P_UserRelationship (Parameters)"
            Begin Extent = 
               Top = 262
               Left = 1500
               Bottom = 512
               Right = 1745
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
         Column = 3705
         Alias = 5160
         Table = 4035
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_P_ProcessEndorsement'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_P_ProcessEndorsement'
GO


