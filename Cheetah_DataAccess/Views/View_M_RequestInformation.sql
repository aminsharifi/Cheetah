USE [Cheetah]
GO

/****** Object:  View [dbo].[View_M_RequestInformation]    Script Date: 2/14/2023 1:37:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_M_RequestInformation]
AS
SELECT        Masters.M_RequestInformation.RI_ERPID, Masters.M_RequestInformation.RI_RequestTypeIdRecord, Masters.M_RequestInformation.RI_PE_Level, Masters.M_RequestInformation.RI_UserNameCreator, 
                         Masters.M_RequestInformation.RI_ERPBranchs, Masters.M_RequestInformation.RI_ERPKindID, RI_RequestTitle.RT_RemoveRequestorApproval, Masters.M_RequestInformation.RI_RequestTitleIdRecord, 
                         Masters.M_RequestInformation.RI_RequestorIdRecord, RI_RequestTitle.RT_ERP, Masters.M_RequestInformation.RI_OutputVar1, Masters.M_RequestInformation.RI_OutputVar2, Masters.M_RequestInformation.RI_OutputVar3, 
                         Masters.M_RequestInformation.RI_OutputVar4, Masters.M_RequestInformation.RI_OutputVar5, RI_RequestTitle.RT_OutputVar1, RI_RequestTitle.RT_OutputVar2, RI_RequestTitle.RT_OutputVar3, RI_RequestTitle.RT_OutputVar4, 
                         RI_RequestTitle.RT_OutputVar5, Masters.M_RequestInformation.RI_CreatorIdRecord, Masters.M_RequestInformation.RI_ExpertUserIdRecord, Masters.M_RequestInformation.RI_SubRequestTitleIdRecord, 
                         RI_SubRequestTitle.PCode AS SRT_PCode, RI_SubRequestTitle.PName AS SRT_PName, RI_RequestType.PCode AS RT_PCode, RI_RequestType.PName AS RT_PName, Masters.M_RequestInformation.RI_ProcessVar1, 
                         Masters.M_RequestInformation.RI_ProcessVar2, Masters.M_RequestInformation.RI_ProcessVar3, Masters.M_RequestInformation.RI_ProcessVar4, Masters.M_RequestInformation.RI_ProcessVar5, 
                         Masters.M_RequestInformation.RI_Inputuser1, Masters.M_RequestInformation.IsTest, Masters.M_RequestInformation.RI_IsCancelled, Masters.M_RequestInformation.RI_CurrentUserNames, 
                         RI_RequestTitle.RT_ConditionOccur, RI_RequestTitle.RT_ConditionOccur2, RI_RequestTitle.RT_ConditionOccur3, RI_RequestTitle.RT_ConditionOccur4, RI_RequestTitle.RT_ConditionOccur5, 
                         RI_ProcessState.PCode AS ProcessState_PCode, RI_ProcessState.PName AS ProcessState_PName, Masters.M_RequestInformation.IdRecord AS M_RequestInformation_IdRecord, 
                         Masters.M_RequestInformation.RI_AllApproveIdRecord, Masters.M_RequestInformation.RI_CommonAttribIdRecord, Masters.M_RequestInformation.RI_CommonConditionIdRecord, 
                         RI_RequestTitle.PCode AS RI_RequestTitle_PCode, RI_RequestTitle.PName AS RI_RequestTitle_PName, Masters.M_RequestInformation.RI_M_CurrentPEIdRecord, 
                         Masters.M_RequestInformation.RI_ProcessStateIdRecord
FROM            Masters.M_RequestInformation LEFT OUTER JOIN
                         Parameters.P_ProcessState AS RI_ProcessState ON RI_ProcessState.IdRecord = Masters.M_RequestInformation.RI_ProcessStateIdRecord LEFT OUTER JOIN
                         Parameters.P_RequestType AS RI_RequestType ON RI_RequestType.IdRecord = Masters.M_RequestInformation.RI_RequestTypeIdRecord LEFT OUTER JOIN
                         Parameters.P_RequestTitle AS RI_RequestTitle ON RI_RequestTitle.IdRecord = Masters.M_RequestInformation.RI_RequestTitleIdRecord LEFT OUTER JOIN
                         Parameters.P_SubRequestTitle AS RI_SubRequestTitle ON RI_SubRequestTitle.IdRecord = Masters.M_RequestInformation.RI_SubRequestTitleIdRecord
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
         Configuration = "(H (1[50] 4[25] 3) )"
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
         Configuration = "(H (1[78] 3) )"
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
         Configuration = "(H (1[51] 4) )"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[45] 2) )"
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
         Configuration = "(V (4) )"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 12
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = -307
      End
      Begin Tables = 
         Begin Table = "M_RequestInformation (Masters)"
            Begin Extent = 
               Top = 163
               Left = 736
               Bottom = 924
               Right = 1026
            End
            DisplayFlags = 280
            TopColumn = 14
         End
         Begin Table = "RI_ProcessState"
            Begin Extent = 
               Top = 543
               Left = 361
               Bottom = 673
               Right = 592
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "RI_RequestType"
            Begin Extent = 
               Top = 383
               Left = 369
               Bottom = 513
               Right = 582
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "RI_RequestTitle"
            Begin Extent = 
               Top = 411
               Left = 1193
               Bottom = 769
               Right = 1445
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "RI_SubRequestTitle"
            Begin Extent = 
               Top = 812
               Left = 1195
               Bottom = 942
               Right = 1444
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
      Begin ColumnWidths = 28
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_M_RequestInformation'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'= 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 4365
         Alias = 3780
         Table = 4005
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_M_RequestInformation'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_M_RequestInformation'
GO


