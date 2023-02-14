USE [Cheetah]
GO

/****** Object:  View [dbo].[View_M_CommonAttrib]    Script Date: 2/14/2023 1:37:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_M_CommonAttrib]
AS
SELECT        Masters.M_CommonAttrib.IdRecord, Masters.M_CommonAttrib.CMA_S_AreaIdRecord, Masters.M_CommonAttrib.CMA_S_LocationIdRecord, Masters.M_CommonAttrib.CMA_P_UnitTypeIdRecord, 
                         Parameters.P_UnitType.UT_KindID, Parameters.P_UnitType.PCode AS UT_PCode, Parameters.P_UnitType.PName AS UT_PName, Parameters.P_UnitType.PIndex AS UT_PIndex, 
                         Parameters.P_UnitType.PERPCode AS UT_PERPCode, Parameters.P_UnitType.PDescription AS UT_PDescription, Parameters.P_UnitType.DsblRecord AS UT_DsblRecord, Systems.S_Area.PCode AS AREA_PCode, 
                         Systems.S_Area.PName AS AREA_PName, Systems.S_Area.PIndex AS AREA_PIndex, Systems.S_Area.DsblRecord AS AREA_DsblRecord, Systems.S_Location.DsblRecord AS LOC_DsblRecord, 
                         Systems.S_Location.PCode AS LOC_PCode, Systems.S_Location.PName AS LOC_PName, Systems.S_Location.PIndex AS LOC_PIndex
FROM            Parameters.P_UnitType RIGHT OUTER JOIN
                         Masters.M_CommonAttrib ON Parameters.P_UnitType.IdRecord = Masters.M_CommonAttrib.CMA_P_UnitTypeIdRecord LEFT OUTER JOIN
                         Systems.S_Location ON Masters.M_CommonAttrib.CMA_S_LocationIdRecord = Systems.S_Location.IdRecord LEFT OUTER JOIN
                         Systems.S_Area ON Masters.M_CommonAttrib.CMA_S_AreaIdRecord = Systems.S_Area.IdRecord
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
         Configuration = "(H (1[39] 4) )"
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
      ActivePaneConfig = 4
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -192
         Left = 0
      End
      Begin Tables = 
         Begin Table = "P_UnitType (Parameters)"
            Begin Extent = 
               Top = 107
               Left = 62
               Bottom = 286
               Right = 254
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "M_CommonAttrib (Masters)"
            Begin Extent = 
               Top = 112
               Left = 325
               Bottom = 318
               Right = 548
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "S_Location (Systems)"
            Begin Extent = 
               Top = 335
               Left = 634
               Bottom = 596
               Right = 839
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "S_Area (Systems)"
            Begin Extent = 
               Top = 45
               Left = 644
               Bottom = 299
               Right = 836
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
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
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
         Column = 2910
         Alias = 2280
         Table = 3345
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy =' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_M_CommonAttrib'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_M_CommonAttrib'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_M_CommonAttrib'
GO


