using Cheetah_Business;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Facts;
using Cheetah_Business.Links;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Cheetah_DataAccess.Data;

public static class ModelBuilderExtensions
{
    public static async void Seed(this ModelBuilder modelBuilder)
    {
        #region Dimentions

        #region D_Process
        modelBuilder.Entity<D_Process>().HasData(
            new D_Process
            {
                Id = 1,
                SortIndex = 1,
                Name = "CustomerDefinition",
                DisplayName = "تعریف/اصلاح مشتری",
            },
            new D_Process
            {
                Id = 2,
                SortIndex = 2,
                Name = "PolicyCenter",
                DisplayName = "مجوزهای موردی"
            },
            new D_Process
            {
                Id = 3,
                SortIndex = 3,
                Name = "CustomerCredit",
                DisplayName = "اعتباردهی مالی مشتری"
            }
            );
        #endregion

        #region D_ProcessState
        modelBuilder.Entity<D_ProcessState>().HasData(
            new D_ProcessState
            {
                Id = 1,
                SortIndex = 1,
                Name = "Ongoing",
                DisplayName = "در دست بررسی"
            },
            new D_ProcessState
            {
                Id = 2,
                SortIndex = 2,
                Name = "Editing",
                DisplayName = "منتظر بازنگری"
            },
            new D_ProcessState
            {
                Id = 3,
                SortIndex = 3,
                Name = "Completed",
                DisplayName = "کامل شده"
            },
            new D_ProcessState
            {
                Id = 4,
                SortIndex = 4,
                Name = "Aborted",
                DisplayName = "ابطال شده"
            }
             );
        #endregion
        
        #region D_WorkItemState
        modelBuilder.Entity<D_WorkItemState>().HasData(
            new D_WorkItemState
            {
                Id = 1,
                SortIndex = 1,
                Name = "Inbox",
                DisplayName = "صندوق ورودی"
            },
            new D_WorkItemState
            {
                Id = 2,
                SortIndex = 2,
                Name = "Sent",
                DisplayName = "ارسال شده"
            },
            new D_WorkItemState
             {
                 Id = 3,
                 SortIndex = 3,
                 Name = "Exit",
                 DisplayName = "خارج شده"
             },
            new D_WorkItemState
            {
                Id = 4,
                SortIndex = 4,
                Name = "Future",
                DisplayName = "آینده"
            },
            new D_WorkItemState
            {
                Id = 5,
                SortIndex = 5,
                Name = "Aborted",
                DisplayName = "ابطال شده"
            }
             );
        #endregion

        
        #region D_Location
        modelBuilder.Entity<D_Location>().HasData(
            new D_Location
            {
                Id = 1,
                SortIndex = 1,
                Name = "Tehran",
                DisplayName = "تهران"
            },
            new D_Location
            {
                Id = 2,
                SortIndex = 2,
                Name = "Fars",
                DisplayName = "فارس"
            },
            new D_Location
            {
                Id = 3,
                SortIndex = 3,
                Name = "Esfahan",
                DisplayName = "اصفهان"
            }
            );
        #endregion

        #region D_Operand
        modelBuilder.Entity<D_Operand>().HasData(
            new D_Operand
            {
                Id = 1,
                SortIndex = 1,
                Name = "=",
                DisplayName = "مساوی"
            },
            new D_Operand
            {
                Id = 2,
                SortIndex = 2,
                Name = "!=",
                DisplayName = "مخالف"
            },
            new D_Operand
            {
                Id = 3,
                SortIndex = 3,
                Name = ">",
                DisplayName = "بزگتر از"
            },
            new D_Operand
            {
                Id = 4,
                SortIndex = 4,
                Name = ">=",
                DisplayName = "بزرگتر و مساوی"
            },
            new D_Operand
            {
                Id = 5,
                SortIndex = 5,
                Name = "<",
                DisplayName = " کوچکتر از"
            },
            new D_Operand
            {
                Id = 6,
                SortIndex = 6,
                Name = "<=",
                DisplayName = "کوچکتر و مساوی"
            }
            );
        #endregion

        #region D_TagType
        modelBuilder.Entity<D_TagType>().HasData(
            new D_TagType
            {
                Id = 1,
                SortIndex = 1,
                Name = "Numberic",
                DisplayName = "عددی"
            },
            new D_TagType
            {
                Id = 2,
                SortIndex = 2,
                Name = "Boolean",
                DisplayName = "دودویی"
            },
            new D_TagType
            {
                Id = 3,
                SortIndex = 3,
                Name = "Date",
                DisplayName = "تاریخ"
            },
            new D_TagType
            {
                Id = 4,
                SortIndex = 4,
                Name = "String",
                DisplayName = "حروف"
            }
                        );
        #endregion

        #region D_Tag
        modelBuilder.Entity<D_Tag>().HasData(
                 new D_Tag
                 {
                     Id = 100,
                     SortIndex = 100,
                     Name = "OursShare",
                     DisplayName = "سهم شرکت",
                     Description = "عددی",
                     TagTypeId = 1,
                 },
                 new D_Tag
                 {
                     Id = 101,
                     SortIndex = 101,
                     Name = "OthersShare",
                     DisplayName = "سهم دیگران",
                     Description = "عددی",
                     TagTypeId = 1
                 },
                 new D_Tag
                 {
                     Id = 103,
                     SortIndex = 103,
                     Name = "Price",
                     DisplayName = "مبلغ",
                     Description = "عددی",
                     TagTypeId = 1
                 },
                 new D_Tag
                 {
                     Id = 200,
                     SortIndex = 200,
                     Name = "Refrigerator",
                     DisplayName = "مخدر/ یخچالی",
                     Description = "دودویی",
                     TagTypeId = 2,
                 },
                 new D_Tag
                 {
                     Id = 201,
                     SortIndex = 201,
                     Name = "Approve",
                     DisplayName = "تایید",
                     Description = "پارامتریک",
                     TagTypeId = 2
                 },
                 new D_Tag
                 {
                     Id = 202,
                     SortIndex = 202,
                     Name = "Reject",
                     DisplayName = "عدم تایید",
                     Description = "پارامتریک",
                     TagTypeId = 2
                 },
                 new D_Tag
                 {
                     Id = 203,
                     SortIndex = 203,
                     Name = "Revise",
                     DisplayName = "بازنگری",
                     Description = "پارامتریک",
                     TagTypeId = 2
                 },
                 new D_Tag
                 {
                     Id = 204,
                     SortIndex = 204,
                     Name = "Med",
                     DisplayName = "دارویی",
                     Description = "پارامتریک",
                     TagTypeId = 2
                 },
                 new D_Tag
                 {
                     Id = 205,
                     SortIndex = 205,
                     Name = "FMCG",
                     DisplayName = "مصرفی",
                     Description = "پارامتریک",
                     TagTypeId = 2
                 },
                 new D_Tag
                 {
                     Id = 206,
                     SortIndex = 206,
                     Name = "General",
                     DisplayName = "کل",
                     Description = "پارامتریک",
                     TagTypeId = 2
                 }
                 );
        #endregion

        #region D_User
        modelBuilder.Entity<D_User>().HasData(
                new D_User
                {
                    Id = 1,
                    SortIndex = 1,
                    Name = "m.sharifi",
                    DisplayName = "محمد شریفی"
                },
                new D_User
                {
                    Id = 2,
                    SortIndex = 2,
                    Name = "a.sharifi",
                    DisplayName = "امین شریفی"
                }
                );
        #endregion

        #region D_Role
        modelBuilder.Entity<D_Role>().HasData(
                  new D_Role
                  {
                      Id = 1,
                      SortIndex = 1,
                      Name = "PharmaceuticalDeputy",
                      DisplayName = "معاونت دارویی",
                      Independent = true
                  },
                  new D_Role
                  {
                      Id = 2,
                      SortIndex = 2,
                      Name = "FMCGDeputy",
                      DisplayName = "معاونت غذایی",
                      Independent = true
                  },
                  new D_Role
                  {
                      Id = 3,
                      SortIndex = 3,
                      Name = "BusinessSpecialist",
                      DisplayName = "کارشناس بازرگانی",
                      Independent = true
                  },
                  new D_Role
                  {
                      Id = 4,
                      SortIndex = 4,
                      Name = "SalesSpecialist",
                      DisplayName = "کارشناس فروش",
                      Independent = true
                  },
                  new D_Role
                  {
                      Id = 5,
                      SortIndex = 5,
                      Name = "DistributionCenterManager",
                      DisplayName = "مدیریت مرکز توزیع",
                      Independent = false
                  }
                  );
        #endregion

        #region D_Position
        modelBuilder.Entity<D_Position>().HasData(
                   new D_Position
                   {
                       Id = 1,
                       SortIndex = 1,
                       Name = "PharmaceuticalDeputy",
                       DisplayName = "معاون دارویی"
                   },
                   new D_Position
                   {
                       Id = 2,
                       SortIndex = 2,
                       Name = "FMCGDeputy",
                       DisplayName = "معاون غذایی"
                   },
                   new D_Position
                   {
                       Id = 3,
                       SortIndex = 3,
                       Name = "BusinessSeniorSpecialist",
                       DisplayName = "کارشناس ارشد بازرگانی"
                   },
                   new D_Position
                   {
                       Id = 4,
                       SortIndex = 4,
                       Name = "BusinessSpecialist",
                       DisplayName = "کارشناس بازرگانی"
                   },
                   new D_Position
                   {
                       Id = 5,
                       SortIndex = 5,
                       Name = "SalesSeniorSpecialist",
                       DisplayName = "کارشناس ارشد فروش"
                   },
                   new D_Position
                   {
                       Id = 6,
                       SortIndex = 6,
                       Name = "SalesSpecialist",
                       DisplayName = "کارشناس فروش"
                   },
                   new D_Position
                   {
                       Id = 7,
                       SortIndex = 7,
                       Name = "DistributionCenterManager",
                       DisplayName = "مدیر مرکز توزیع"
                   }
                   );
        #endregion

        #region D_Entity
        modelBuilder.Entity<D_Entity>().HasData(
                    new D_Entity
                    {
                        Id = 101,
                        SortIndex = 101,
                        Name = nameof(D_TagType),
                        DisplayName = new StringBuilder().Append("نوع تگ‌ها")
                        .Append($"({TableType.Dimentions})").ToString(),
                        Display = false
                    },
                    new D_Entity
                    {
                        Id = 102,
                        SortIndex = 102,
                        Name = nameof(D_Location),
                        DisplayName = new StringBuilder().Append("موقعیت‌ها")
                        .Append($"({TableType.Dimentions})").ToString(),
                        Display = false
                    },
                    new D_Entity
                    {
                        Id = 103,
                        SortIndex = 103,
                        Name = nameof(D_Operand),
                        DisplayName = new StringBuilder().Append("عملگرها")
                        .Append($"({TableType.Dimentions})").ToString(),
                        Display = false
                    },
                    new D_Entity
                    {
                        Id = 104,
                        SortIndex = 104,
                        Name = nameof(D_Tag),
                        DisplayName = new StringBuilder().Append("تگ‌ها")
                        .Append($"({TableType.Dimentions})").ToString(),
                        Display = false
                    },
                    new D_Entity
                    {
                        Id = 105,
                        SortIndex = 105,
                        Name = nameof(D_Position),
                        DisplayName = new StringBuilder().Append("سمت‌ها")
                        .Append($"({TableType.Dimentions})").ToString(),
                        Display = true
                    },
                    new D_Entity
                    {
                        Id = 106,
                        SortIndex = 106,
                        Name = nameof(D_ProcessState),
                        DisplayName = new StringBuilder().Append("وضعیت فرآیندها")
                        .Append($"({TableType.Dimentions})").ToString(),
                        Display = false
                    },
                    new D_Entity
                    {
                        Id = 107,
                        SortIndex = 107,
                        Name = nameof(D_Process),
                        DisplayName = new StringBuilder().Append("فرآیند‌ها")
                        .Append($"({TableType.Dimentions})").ToString(),
                        Display = true
                    },
                    new D_Entity
                    {
                        Id = 108,
                        SortIndex = 108,
                        Name = nameof(D_Role),
                        DisplayName = new StringBuilder().Append("نقش‌ها")
                        .Append($"({TableType.Dimentions})").ToString(),
                        Display = true
                    },
                    new D_Entity
                    {
                        Id = 109,
                        SortIndex = 109,
                        Name = nameof(D_User),
                        DisplayName = new StringBuilder().Append("کاربران")
                        .Append($"({TableType.Dimentions})").ToString(),
                        Display = true
                    },
                    new D_Entity
                    {
                        Id = 112,
                        SortIndex = 112,
                        Name = nameof(D_UserInformation),
                        DisplayName = new StringBuilder().Append("اطلاعات کاربرها")
                        .Append($"({TableType.Facts})").ToString(),
                        Display = false
                    },
                    new D_Entity
                    {
                        Id = 200,
                        SortIndex = 200,
                        Name = nameof(F_WorkItem),
                        DisplayName = new StringBuilder().Append("تمام تاییدها")
                        .Append($"({TableType.Facts})").ToString(),
                        Display = false
                    },
                    new D_Entity
                    {
                        Id = 202,
                        SortIndex = 202,
                        Name = nameof(F_Attachment),
                        DisplayName = new StringBuilder().Append("ضمیمه‌ها")
                        .Append($"({TableType.Facts})").ToString(),
                        Display = false
                    },
                    new D_Entity
                    {
                        Id = 203,
                        SortIndex = 203,
                        Name = nameof(F_Endorsement),
                        DisplayName = new StringBuilder().Append("لیست تخصیص‌ها")
                        .Append($"({TableType.Facts})").ToString(),
                        Display = false
                    },
                    new D_Entity
                    {
                        Id = 204,
                        SortIndex = 204,
                        Name = nameof(F_Condition),
                        DisplayName = new StringBuilder().Append("لیست شرط‌ها")
                        .Append($"({TableType.Facts})").ToString(),
                        Display = false
                    },
                    new D_Entity
                    {
                        Id = 205,
                        SortIndex = 205,
                        Name = nameof(F_Case),
                        DisplayName = new StringBuilder().Append("اطلاعات درخواست‌ها")
                        .Append($"({TableType.Facts})").ToString(),
                        Display = true
                    },
                     new D_Entity
                     {
                         Id = 206,
                         SortIndex = 206,
                         Name = nameof(F_Scenario),
                         DisplayName = new StringBuilder().Append("سناریوها")
                         .Append($"({TableType.Facts})").ToString(),
                         Display = true
                     },
                    new D_Entity
                    {
                        Id = 300,
                        SortIndex = 300,
                        Name = nameof(L_RolePosition),
                        DisplayName = new StringBuilder().Append("نقش-سمت")
                        .Append($"({TableType.Links})").ToString(),
                        Display = false
                    },
                    new D_Entity
                    {
                        Id = 301,
                        SortIndex = 301,
                        Name = nameof(L_ProcessScenario),
                        DisplayName = new StringBuilder().Append("فرآیند-سناریو")
                        .Append($"({TableType.Links})").ToString(),
                        Display = false
                    },
                    new D_Entity
                    {
                        Id = 302,
                        SortIndex = 302,
                        Name = nameof(L_UserLocation),
                        DisplayName = new StringBuilder().Append("کاربر-موقعیت")
                        .Append($"({TableType.Links})").ToString(),
                        Display = false
                    },
                    new D_Entity
                    {
                        Id = 303,
                        SortIndex = 303,
                        Name = nameof(L_UserPosition),
                        DisplayName = new StringBuilder().Append("کاربر-سمت")
                        .Append($"({TableType.Links})").ToString(),
                        Display = false
                    }
                    );
        #endregion

        #endregion

        #region Facts

        #region F_Scenario
        modelBuilder.Entity<F_Scenario>().HasData(
            new F_Scenario
            {
                Id = 1,
                SortIndex = 1,
                Name = "Head_Scenario3",
                DisplayName = "سناریو ستاد"
            },
            new F_Scenario
            {
                Id = 2,
                SortIndex = 2,
                Name = "Med_Scenario",
                DisplayName = "سناریو دارویی"
            },
            new F_Scenario
            {
                Id = 3,
                SortIndex = 3,
                Name = "FMCG_Scenario",
                DisplayName = "سناریو مصرفی"
            }
            );
        #endregion

        #region F_Condition

        modelBuilder.Entity<F_Condition>().HasData(
            new F_Condition
            {
                Id = 1,
                SortIndex = 1,
                Name = "Head_Scenario,OursShare,>,0",
                DisplayName = "سناریو ستاد,سهم شرکت,بزگتر از,0",
                TagId = 100,
                OperandId = 3,
                Value = "0",
                ScenarioId = 1,
                EndorsementId = 2
            },
            new F_Condition
            {
                Id = 2,
                SortIndex = 2,
                Name = "Med_Scenario,Med,=,1",
                DisplayName = "سناریو دارویی,دارویی,مساوی,1",
                TagId = 204,
                OperandId = 1,
                Value = "1",
                ScenarioId = 2
            },
            new F_Condition
            {
                Id = 3,
                SortIndex = 3,
                Name = "Med_Scenario,OursShare,>,0",
                DisplayName = "سناریو دارویی,سهم شرکت,بزگتر از,0",
                TagId = 100,
                OperandId = 3,
                Value = "0",
                ScenarioId = 2
            },
            new F_Condition
            {
                Id = 4,
                SortIndex = 4,
                Name = "FMCG_Scenario,FMCG,=,1",
                DisplayName = "سناریو مصرفی,مصرفی,مساوی,1",
                TagId = 205,
                OperandId = 1,
                Value = "1",
                ScenarioId = 3
            },
            new F_Condition
            {
                Id = 5,
                SortIndex = 5,
                Name = "FMCG_Scenario,Price,>,0",
                DisplayName = "سناریو مصرفی,مبلغ,بزگتر از,0",
                TagId = 103,
                OperandId = 3,
                Value = "0",
                ScenarioId = 3
            }
            );
        #endregion

        #region F_Endorsement
        modelBuilder.Entity<F_Endorsement>().HasData(
            new F_Endorsement
            {
                Id = 1,
                SortIndex = 1,
                Name = "Med_Scenario,DistributionCenterManager",
                DisplayName = "سناریو سه,مدیریت مرکز توزیع",
                RoleId = 5,
                ScenarioId = 3
            },
            new F_Endorsement
            {
                Id = 2,
                SortIndex = 2,
                Name = "Strategy3,FMCGDeputy",
                DisplayName = "سناریو سه,معاونت غذایی",
                RoleId = 2,
                ScenarioId = 3
            },
            new F_Endorsement
            {
                Id = 3,
                SortIndex = 3,
                Name = "Strategy2,PharmaceuticalDeputy",
                DisplayName = "سناریو دو,معاونت دارویی",
                RoleId = 1,
                ScenarioId = 2
            },
            new F_Endorsement
            {
                Id = 4,
                SortIndex = 4,
                Name = "Med_Scenario,PharmaceuticalDeputy",
                DisplayName = "سناریو دارویی,معاونت دارویی",
                RoleId = 2,
                ScenarioId = 1
            }
            );
        #endregion

        #endregion

        #region Links

        #region L_UserLocation
        modelBuilder.Entity<L_UserLocation>().HasData(
                    new L_UserLocation
                    {
                        Id = 1,
                        SortIndex = 1,
                        Name = "m.sharifi-Tehran",
                        DisplayName = "محمد شریفی-تهران",
                        FirstId = 1,
                        SecondId = 1
                    },
                    new L_UserLocation
                    {
                        Id = 2,
                        SortIndex = 2,
                        Name = "a.sharifi-Fars",
                        DisplayName = "امین شریفی-فارس",
                        FirstId = 2,
                        SecondId = 2
                    },
                    new L_UserLocation
                    {
                        Id = 3,
                        SortIndex = 3,
                        Name = "m.sharifi-Fars",
                        DisplayName = "محمد شریفی-فارس",
                        FirstId = 1,
                        SecondId = 2
                    },
                     new L_UserLocation
                     {
                         Id = 4,
                         SortIndex = 4,
                         Name = "a.sharifi-Tehran",
                         DisplayName = "امین شریفی-تهران",
                         FirstId = 2,
                         SecondId = 1
                     }
                   );
        #endregion

        #region L_RolePosition
        modelBuilder.Entity<L_RolePosition>().HasData(
                      new L_RolePosition
                      {
                          Id = 1,
                          SortIndex = 1,
                          Name = "PharmaceuticalDeputy-PharmaceuticalDeputy",
                          DisplayName = "معاونت دارویی-معاون دارویی",
                          FirstId = 1,
                          SecondId = 1
                      },
                      new L_RolePosition
                      {
                          Id = 2,
                          SortIndex = 2,
                          Name = "FMCGDeputy-FMCGDeputy",
                          DisplayName = "معاونت غذایی-معاون غذایی",
                          FirstId = 2,
                          SecondId = 2
                      },
                      new L_RolePosition
                      {
                          Id = 3,
                          SortIndex = 3,
                          Name = "BusinessSpecialist-BusinessSeniorSpecialist",
                          DisplayName = "کارشناس بازرگانی-کارشناس ارشد بازرگانی",
                          FirstId = 3,
                          SecondId = 3
                      },
                      new L_RolePosition
                      {
                          Id = 4,
                          SortIndex = 4,
                          Name = "BusinessSpecialist-BusinessSpecialist",
                          DisplayName = "کارشناس بازرگانی-کارشناس بازرگانی",
                          FirstId = 3,
                          SecondId = 4
                      },
                      new L_RolePosition
                      {
                          Id = 5,
                          SortIndex = 5,
                          Name = "SalesSpecialist-SalesSeniorSpecialist",
                          DisplayName = "کارشناس فروش-کارشناس ارشد فروش",
                          FirstId = 4,
                          SecondId = 5
                      },
                      new L_RolePosition
                      {
                          Id = 6,
                          SortIndex = 6,
                          Name = "SalesSpecialist-SalesSpecialist",
                          DisplayName = "کارشناس فروش-کارشناس فروش",
                          FirstId = 4,
                          SecondId = 6
                      },
                      new L_RolePosition
                      {
                          Id = 7,
                          SortIndex = 7,
                          Name = "DistributionCenterManager-DistributionCenterManager",
                          DisplayName = "مدیریت مرکز توزیع-مدیر مرکز توزیع",
                          FirstId = 5,
                          SecondId = 7
                      }
                      );
        #endregion

        #region L_ProcessScenario
        modelBuilder.Entity<L_ProcessScenario>().HasData(
                      new L_ProcessScenario
                      {
                          Id = 1,
                          SortIndex = 1,
                          Name = "CustomerDefinition-Strategy3",
                          DisplayName = "تعریف/اصلاح مشتری-سناریو سه",
                          FirstId = 1,
                          SecondId = 3
                      },
                      new L_ProcessScenario
                      {
                          Id = 2,
                          SortIndex = 2,
                          Name = "CustomerDefinition-Strategy1",
                          DisplayName = "تعریف/اصلاح مشتری-سناریو یک",
                          FirstId = 1,
                          SecondId = 1
                      },
                      new L_ProcessScenario
                      {
                          Id = 3,
                          SortIndex = 3,
                          Name = "PolicyCenter-Strategy1",
                          DisplayName = "مجوزهای موردی-سناریو یک",
                          FirstId = 2,
                          SecondId = 1
                      },
                      new L_ProcessScenario
                      {
                          Id = 4,
                          SortIndex = 4,
                          Name = "PolicyCenter-Strategy2",
                          DisplayName = "تعریف/اصلاح مشتری-سناریو دو",
                          FirstId = 1,
                          SecondId = 2
                      },
                       new L_ProcessScenario
                       {
                           Id = 5,
                           SortIndex = 5,
                           Name = "CustomerDefinition-Strategy2",
                           DisplayName = "مجوزهای موردی-سناریو دو",
                           FirstId = 2,
                           SecondId = 2
                       }
                      );
        #endregion

        #region L_UserPosition

        modelBuilder.Entity<L_UserPosition>().HasData
            (
                new L_UserPosition
                {
                    Id = 1,
                    SortIndex = 1,
                    Name = "m.sharifi-PharmaceuticalDeputy",
                    DisplayName = "محمد شریفی-مدیر مرکز",
                    FirstId = 1,
                    SecondId = 7
                },
                new L_UserPosition
                {
                    Id = 2,
                    SortIndex = 2,
                    Name = "a.sharifi-FMCGDeputy",
                    DisplayName = "امین شریفی-معاون غذایی",
                    FirstId = 2,
                    SecondId = 2
                }
            );
        #endregion

        #endregion
    }
}