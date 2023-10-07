using Cheetah.Domain;
using Cheetah.Domain.Dimentions;
using Cheetah.Domain.Facts;
using Cheetah.Domain.Links;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Cheetah.Infrastructure.Persistence;

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
                Name = "SampleProcess",
                DisplayName = "فرآیند نمونه",
            }
            );
        #endregion

        #region D_ProcessState
        modelBuilder.Entity<D_CaseState>().HasData(
            new D_CaseState
            {
                Id = 1,
                SortIndex = 1,
                Name = "Ongoing",
                DisplayName = "در دست بررسی"
            },
            new D_CaseState
            {
                Id = 2,
                SortIndex = 2,
                Name = "Editing",
                DisplayName = "منتظر بازنگری"
            },
            new D_CaseState
            {
                Id = 3,
                SortIndex = 3,
                Name = "Completed",
                DisplayName = "کامل شده"
            },
            new D_CaseState
            {
                Id = 4,
                SortIndex = 4,
                Name = "Rejected",
                DisplayName = "عدم تایید"
            }
            ,
            new D_CaseState
            {
                Id = 5,
                SortIndex = 5,
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
            }
             );
        #endregion

        #region D_Location
        modelBuilder.Entity<D_Location>().HasData(
            new D_Location
            {
                Id = 1,
                SortIndex = 1,
                Name = "Fars",
                DisplayName = "فارس"
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
                Id = 1,
                SortIndex = 1,
                Name = "D_Location",
                DisplayName = "مرکز",
                Description = "عددی",
                TagTypeId = 1,
                ERPCode = 1
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
                Name = "Edit",
                DisplayName = "بازنگری",
                Description = "پارامتریک",
                TagTypeId = 2
            },
            new D_Tag
            {
                Id = 301,
                SortIndex = 301,
                Name = "Price",
                DisplayName = "مبلغ",
                Description = "عددی",
                TagTypeId = 1
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
                      Id = 100,
                      SortIndex = 100,
                      Name = "Requestor",
                      DisplayName = "درخواست کننده",
                      FixedRole = true
                  },
                  new D_Role
                  {
                      Id = 101,
                      SortIndex = 101,
                      Name = "RequestorManager",
                      DisplayName = "مدیر درخواست کننده",
                      FixedRole = true
                  }
                  );
        #endregion

        #region D_Position
        modelBuilder.Entity<D_Position>().HasData(
                   new D_Position
                   {
                       Id = 1,
                       SortIndex = 1,
                       Name = "Expert",
                       DisplayName = "کارشناس"
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
                        Display = true
                    },
                    new D_Entity
                    {
                        Id = 105,
                        SortIndex = 105,
                        Name = nameof(D_Position),
                        DisplayName = new StringBuilder().Append("سمت‌ها")
                        .Append($"({TableType.Dimentions})").ToString(),
                        Display = false
                    },
                    new D_Entity
                    {
                        Id = 106,
                        SortIndex = 106,
                        Name = nameof(D_CaseState),
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
                        Display = false
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
                Name = "SampleScenario",
                DisplayName = "سناریو نمونه"
            }
            );
        #endregion

        #region F_Endorsement
        modelBuilder.Entity<F_Endorsement>().HasData(
            new F_Endorsement
            {
                Id = 1,
                SortIndex = 1,
                Name = "Sample_Scenario,Requestor",
                DisplayName = "ثبت درخواست",
                RoleId = 100,
                ScenarioId = 1
            },
            new F_Endorsement
            {
                Id = 2,
                SortIndex = 2,
                Name = "Sample_Scenario,RequestorManager",
                DisplayName = "بررسی درخواست",
                RoleId = 101,
                ScenarioId = 1
            }
            );
        #endregion

        #region F_EndorsementItem
        modelBuilder.Entity<F_EndorsementItem>().HasData(
            new F_EndorsementItem
            {
                Id = 1,
                SortIndex = 1,
                CaseStateId = 1,
                EndorsementId = 1
            },
            new F_EndorsementItem
            {
                Id = 2,
                SortIndex = 1,
                CaseStateId = 3,
                EndorsementId = 2
            },
            new F_EndorsementItem
            {
                Id = 3,
                SortIndex = 2,
                CaseStateId = 2,
                EndorsementId = 2
            },
            new F_EndorsementItem
            {
                Id = 4,
                SortIndex = 3,
                CaseStateId = 4,
                EndorsementId = 2
            }
            );
        #endregion

        #region F_Condition

        modelBuilder.Entity<F_Condition>().HasData(
            new F_Condition
            {
                Id = 1,
                SortIndex = 1,
                Name = "Price",
                DisplayName = "مبلغ",
                TagId = 301,
                OperandId = 3,
                Value = "0",
                ScenarioId = 1
            },
            new F_Condition
            {
                Id = 2,
                SortIndex = 1,
                TagId = 201,
                OperandId = 1,
                Value = "0",
                EndorsementItemId = 1
            },
            new F_Condition
            {
                Id = 3,
                SortIndex = 1,
                TagId = 201,
                OperandId = 1,
                Value = "0",
                EndorsementItemId = 2
            },
            new F_Condition
            {
                Id = 4,
                SortIndex = 1,
                TagId = 203,
                OperandId = 1,
                Value = "0",
                EndorsementItemId = 3
            },
            new F_Condition
            {
                Id = 5,
                SortIndex = 1,
                TagId = 202,
                OperandId = 1,
                Value = "1",
                EndorsementItemId = 4
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
                        Name = "m.sharifi-Fars",
                        DisplayName = "محمد شریفی-فارس",
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
                          Name = "Requestor-Expert",
                          DisplayName = "درخواست کننده-کارشناس",
                          FirstId = 100,
                          SecondId = 1
                      },
                        new L_RolePosition
                        {
                            Id = 2,
                            SortIndex = 2,
                            Name = "RequestorManager-Expert",
                            DisplayName = "مدیر درخواست کننده-کارشناس",
                            FirstId = 101,
                            SecondId = 1
                        }
                      );
        #endregion

        #region L_ProcessScenario
        modelBuilder.Entity<L_ProcessScenario>().HasData(
                      new L_ProcessScenario
                      {
                          Id = 1,
                          SortIndex = 1,
                          Name = "SampleProcess-SampleScenario",
                          DisplayName = "فرآیند نمونه-سناریو نمونه",
                          FirstId = 1,
                          SecondId = 1
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
                    Name = "m.sharifi-Expert",
                    DisplayName = "محمد شریفی-کارشناس",
                    FirstId = 1,
                    SecondId = 1
                },
                new L_UserPosition
                {
                    Id = 2,
                    SortIndex = 2,
                    Name = "a.sharifi-Expert",
                    DisplayName = "امین شریفی-کارشناس",
                    FirstId = 2,
                    SecondId = 1
                }
            );
        #endregion

        #region L_EndorsementItemEndorsement

        modelBuilder.Entity<L_EndorsementItemEndorsement>().HasData
            (
                new L_EndorsementItemEndorsement
                {
                    Id = 1,
                    SortIndex = 1,
                    FirstId = 1,
                    SecondId = 2
                },
                new L_EndorsementItemEndorsement
                {
                    Id = 2,
                    SortIndex = 2,
                    FirstId = 3,
                    SecondId = 1
                }
            );
        #endregion

        #endregion
    }
}