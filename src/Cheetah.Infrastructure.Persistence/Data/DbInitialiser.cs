using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Cheetah.Infrastructure.Persistence;


public static class InitialiserExtensions
{
    public static async Task InitialiseDatabaseAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var initialiser = scope.ServiceProvider.GetRequiredService<DbInitialiser>();

        await initialiser.InitialiseAsync();

        await initialiser.SeedAsync();
    }
}

public class DbInitialiser(ApplicationDbContext _context)
{
    public async Task<bool> InitialiseAsync()
    {
        await _context.Database.MigrateAsync();

        return true;
    }
    public async Task SeedAsync()
    {
        if (!_context.D_Processes.Any())
        {
            #region Dimentions

            #region D_Process

            await _context.D_Processes.AddAsync(
                 new D_Process
                 {
                     Id = 1,
                     ERPCode = 1,
                     SortIndex = 1,
                     Name = "SampleProcess",
                     DisplayName = "فرآیند نمونه",
                 }
                );

            #endregion

            #region D_ProcessState

            List<D_CaseState> _list_CaseStates = new();

            _list_CaseStates.Add(
                new D_CaseState
                {
                    Id = 1,
                    ERPCode = 1,
                    SortIndex = 1,
                    Name = "Ongoing",
                    DisplayName = "در دست بررسی"
                });

            _list_CaseStates.Add(
                new D_CaseState
                {
                    Id = 2,
                    ERPCode = 2,
                    SortIndex = 2,
                    Name = "Editing",
                    DisplayName = "منتظر بازنگری"
                });

            _list_CaseStates.Add(new D_CaseState
            {
                Id = 3,
                ERPCode = 3,
                SortIndex = 3,
                Name = "Completed",
                DisplayName = "کامل شده"
            });

            _list_CaseStates.Add(new D_CaseState
            {
                Id = 4,
                ERPCode = 4,
                SortIndex = 4,
                Name = "Rejected",
                DisplayName = "عدم تایید"
            });

            _list_CaseStates.Add(new D_CaseState
            {
                Id = 5,
                ERPCode = 5,
                SortIndex = 5,
                Name = "Aborted",
                DisplayName = "ابطال شده"
            });


            await _context.D_CaseStates.AddRangeAsync(_list_CaseStates);

            #endregion

            #region D_WorkItemState
            List<D_WorkItemState> _list_WorkItemState = new();

            _list_WorkItemState.Add(
            new D_WorkItemState
            {
                Id = 1,
                ERPCode = 1,
                SortIndex = 1,
                Name = "Inbox",
                DisplayName = "صندوق ورودی"
            });
            _list_WorkItemState.Add(new D_WorkItemState
            {
                Id = 2,
                ERPCode = 2,
                SortIndex = 2,
                Name = "Sent",
                DisplayName = "ارسال شده"
            });

            _list_WorkItemState.Add(new D_WorkItemState
            {
                Id = 3,
                ERPCode = 3,
                SortIndex = 3,
                Name = "Exit",
                DisplayName = "خارج شده"
            });

            _list_WorkItemState.Add(new D_WorkItemState
            {
                Id = 4,
                ERPCode = 4,
                SortIndex = 4,
                Name = "Future",
                DisplayName = "آینده"
            });
            await _context.D_WorkItemStates.AddRangeAsync(_list_WorkItemState);

            #endregion

            #region D_Location
            List<D_Location> _list_Location = new();

            _list_Location.Add(
                new D_Location
                {
                    Id = 1,
                    ERPCode = 1,
                    SortIndex = 1,
                    Name = "Fars",
                    DisplayName = "فارس"
                });
            await _context.D_Locations.AddRangeAsync(_list_Location);
            #endregion

            #region D_Operand
            List<D_Operand> _list_Operand = new();

            _list_Operand.Add(
                new D_Operand
                {
                    Id = 1,
                    ERPCode = 1,
                    SortIndex = 1,
                    Name = "=",
                    DisplayName = "مساوی"
                });
            _list_Operand.Add(new D_Operand
            {
                Id = 2,
                ERPCode = 2,
                SortIndex = 2,
                Name = "!=",
                DisplayName = "مخالف"
            });
            _list_Operand.Add(new D_Operand
            {
                Id = 3,
                ERPCode = 3,
                SortIndex = 3,
                Name = ">",
                DisplayName = "بزگتر از"
            });
            _list_Operand.Add(new D_Operand
            {
                Id = 4,
                ERPCode = 4,
                SortIndex = 4,
                Name = ">=",
                DisplayName = "بزرگتر و مساوی"
            });
            _list_Operand.Add(new D_Operand
            {
                Id = 5,
                ERPCode = 5,
                SortIndex = 5,
                Name = "<",
                DisplayName = " کوچکتر از"
            });
            _list_Operand.Add(new D_Operand
            {
                Id = 6,
                ERPCode = 6,
                SortIndex = 6,
                Name = "<=",
                DisplayName = "کوچکتر و مساوی"
            });
            await _context.D_Operands.AddRangeAsync(_list_Operand);
            #endregion

            #region D_TagType
            List<D_TagType> _list_TagType = new();

            _list_TagType.Add(
                new D_TagType
                {
                    Id = 1,
                    ERPCode = 1,
                    SortIndex = 1,
                    Name = "Numberic",
                    DisplayName = "عددی"
                });
            _list_TagType.Add(new D_TagType
            {
                Id = 2,
                ERPCode = 2,
                SortIndex = 2,
                Name = "Boolean",
                DisplayName = "دودویی"
            });
            _list_TagType.Add(new D_TagType
            {
                Id = 3,
                ERPCode = 3,
                SortIndex = 3,
                Name = "Date",
                DisplayName = "تاریخ"
            });
            _list_TagType.Add(new D_TagType
            {
                Id = 4,
                ERPCode = 4,
                SortIndex = 4,
                Name = "String",
                DisplayName = "حروف"
            });
            await _context.D_TagTypes.AddRangeAsync(_list_TagType);
            #endregion

            #region D_Tag
            List<D_Tag> _list_D_Tag = new();

            _list_D_Tag.Add(
                new D_Tag
                {
                    Id = 1,
                    ERPCode = 1,
                    SortIndex = 1,
                    Name = "D_Location",
                    DisplayName = "مرکز",
                    Description = "عددی",
                    TagTypeId = 1
                });
            _list_D_Tag.Add(
                new D_Tag
                {
                    Id = 201,
                    ERPCode = 201,
                    SortIndex = 201,
                    Name = "Approve",
                    DisplayName = "تایید",
                    Description = "پارامتریک",
                    TagTypeId = 2
                });
            _list_D_Tag.Add(
                new D_Tag
                {
                    Id = 202,
                    ERPCode = 202,
                    SortIndex = 202,
                    Name = "Reject",
                    DisplayName = "عدم تایید",
                    Description = "پارامتریک",
                    TagTypeId = 2
                });
            _list_D_Tag.Add(
            new D_Tag
            {
                Id = 203,
                ERPCode = 203,
                SortIndex = 203,
                Name = "Edit",
                DisplayName = "بازنگری",
                Description = "پارامتریک",
                TagTypeId = 2
            });
            _list_D_Tag.Add(
                new D_Tag
                {
                    Id = 301,
                    ERPCode = 301,
                    SortIndex = 301,
                    Name = "Price",
                    DisplayName = "مبلغ",
                    Description = "عددی",
                    TagTypeId = 1
                }
                );
            await _context.D_Tags.AddRangeAsync(_list_D_Tag);
            #endregion

            #region D_User
            List<D_User> _listD_User = new();

            _listD_User.Add(
                    new D_User
                    {
                        Id = 1,
                        ERPCode = 1,
                        SortIndex = 1,
                        Name = "m.sharifi",
                        DisplayName = "محمد شریفی"
                    });
            _listD_User.Add(
                    new D_User
                    {
                        Id = 2,
                        ERPCode = 2,
                        SortIndex = 2,
                        Name = "a.sharifi",
                        DisplayName = "امین شریفی"
                    }
                    );
            await _context.D_Users.AddRangeAsync(_listD_User);
            #endregion

            #region D_Role
            List<D_Role> _list_Role = new();

            _list_Role.Add(
                      new D_Role
                      {
                          Id = 100,
                          ERPCode = 100,
                          SortIndex = 100,
                          Name = "Requestor",
                          DisplayName = "درخواست کننده",
                          FixedRole = true
                      });
            _list_Role.Add(
                      new D_Role
                      {
                          Id = 101,
                          ERPCode = 101,
                          SortIndex = 101,
                          Name = "RequestorManager",
                          DisplayName = "مدیر درخواست کننده",
                          FixedRole = true
                      }
                      );
            await _context.D_Roles.AddRangeAsync(_list_Role);
            #endregion

            #region D_Position
            List<D_Position> _list_Position = new();
            _list_Position.Add(
                       new D_Position
                       {
                           Id = 1,
                           ERPCode = 1,
                           SortIndex = 1,
                           Name = "Expert",
                           DisplayName = "کارشناس"
                       }
                       );
            await _context.D_Positions.AddRangeAsync(_list_Position);
            #endregion

            #region D_Entity
            List<D_Entity> _list_Entity = new();
            _list_Entity.Add(
                        new D_Entity
                        {
                            Id = 101,
                            ERPCode = 101,
                            SortIndex = 101,
                            Name = nameof(D_TagType),
                            DisplayName = new StringBuilder().Append("نوع تگ‌ها")
                            .Append($"({TableType.Dimentions})").ToString(),
                            Display = false
                        });
            _list_Entity.Add(new D_Entity
            {
                Id = 102,
                ERPCode = 102,
                SortIndex = 102,
                Name = nameof(D_Location),
                DisplayName = new StringBuilder().Append("موقعیت‌ها")
                            .Append($"({TableType.Dimentions})").ToString(),
                Display = false
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 103,
                ERPCode = 103,
                SortIndex = 103,
                Name = nameof(D_Operand),
                DisplayName = new StringBuilder().Append("عملگرها")
                            .Append($"({TableType.Dimentions})").ToString(),
                Display = false
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 104,
                ERPCode = 104,
                SortIndex = 104,
                Name = nameof(D_Tag),
                DisplayName = new StringBuilder().Append("تگ‌ها")
                            .Append($"({TableType.Dimentions})").ToString(),
                Display = true
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 105,
                ERPCode = 105,
                SortIndex = 105,
                Name = nameof(D_Position),
                DisplayName = new StringBuilder().Append("سمت‌ها")
                            .Append($"({TableType.Dimentions})").ToString(),
                Display = false
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 106,
                ERPCode = 106,
                SortIndex = 106,
                Name = nameof(D_CaseState),
                DisplayName = new StringBuilder().Append("وضعیت فرآیندها")
                            .Append($"({TableType.Dimentions})").ToString(),
                Display = false
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 107,
                ERPCode = 107,
                SortIndex = 107,
                Name = nameof(D_Process),
                DisplayName = new StringBuilder().Append("فرآیند‌ها")
                            .Append($"({TableType.Dimentions})").ToString(),
                Display = true
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 108,
                ERPCode = 108,
                SortIndex = 108,
                Name = nameof(D_Role),
                DisplayName = new StringBuilder().Append("نقش‌ها")
                            .Append($"({TableType.Dimentions})").ToString(),
                Display = true
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 109,
                ERPCode = 109,
                SortIndex = 109,
                Name = nameof(D_User),
                DisplayName = new StringBuilder().Append("کاربران")
                            .Append($"({TableType.Dimentions})").ToString(),
                Display = true
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 112,
                ERPCode = 112,
                SortIndex = 112,
                Name = nameof(D_UserInformation),
                DisplayName = new StringBuilder().Append("اطلاعات کاربرها")
                            .Append($"({TableType.Facts})").ToString(),
                Display = false
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 200,
                ERPCode = 200,
                SortIndex = 200,
                Name = nameof(F_WorkItem),
                DisplayName = new StringBuilder().Append("تمام تاییدها")
                            .Append($"({TableType.Facts})").ToString(),
                Display = false
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 202,
                ERPCode = 202,
                SortIndex = 202,
                Name = nameof(F_Attachment),
                DisplayName = new StringBuilder().Append("ضمیمه‌ها")
                            .Append($"({TableType.Facts})").ToString(),
                Display = false
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 203,
                ERPCode = 203,
                SortIndex = 203,
                Name = nameof(F_Endorsement),
                DisplayName = new StringBuilder().Append("لیست تخصیص‌ها")
                            .Append($"({TableType.Facts})").ToString(),
                Display = false
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 204,
                ERPCode = 204,
                SortIndex = 204,
                Name = nameof(F_Condition),
                DisplayName = new StringBuilder().Append("لیست شرط‌ها")
                            .Append($"({TableType.Facts})").ToString(),
                Display = false
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 205,
                ERPCode = 205,
                SortIndex = 205,
                Name = nameof(F_Case),
                DisplayName = new StringBuilder().Append("اطلاعات درخواست‌ها")
                            .Append($"({TableType.Facts})").ToString(),
                Display = false
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 206,
                ERPCode = 206,
                SortIndex = 206,
                Name = nameof(F_Scenario),
                DisplayName = new StringBuilder().Append("سناریوها")
                             .Append($"({TableType.Facts})").ToString(),
                Display = true
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 300,
                ERPCode = 300,
                SortIndex = 300,
                Name = nameof(L_RolePosition),
                DisplayName = new StringBuilder().Append("نقش-سمت")
                            .Append($"({TableType.Links})").ToString(),
                Display = false
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 301,
                ERPCode = 301,
                SortIndex = 301,
                Name = nameof(L_ProcessScenario),
                DisplayName = new StringBuilder().Append("فرآیند-سناریو")
                            .Append($"({TableType.Links})").ToString(),
                Display = false
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 302,
                ERPCode = 302,
                SortIndex = 302,
                Name = nameof(L_UserLocation),
                DisplayName = new StringBuilder().Append("کاربر-موقعیت")
                            .Append($"({TableType.Links})").ToString(),
                Display = false
            });
            _list_Entity.Add(new D_Entity
            {
                Id = 303,
                ERPCode = 303,
                SortIndex = 303,
                Name = nameof(L_UserPosition),
                DisplayName = new StringBuilder().Append("کاربر-سمت")
                            .Append($"({TableType.Links})").ToString(),
                Display = false
            }
                        );
            await _context.D_Entities.AddRangeAsync(_list_Entity);
            #endregion

            #endregion

            #region Facts

            #region F_Scenario
            List<F_Scenario> _list_Scenario = new();
            _list_Scenario.Add(
                new F_Scenario
                {
                    Id = 1,
                    ERPCode = 1,
                    SortIndex = 1,
                    Name = "SampleScenario",
                    DisplayName = "سناریو نمونه"
                }
                );
            await _context.F_Scenarios.AddRangeAsync(_list_Scenario);
            #endregion

            #region F_Endorsement
            List<F_Endorsement> _list_Endorsement = new();

            _list_Endorsement.Add(
                new F_Endorsement
                {
                    Id = 1,
                    ERPCode = 1,
                    SortIndex = 1,
                    Name = "Sample_Scenario,Requestor",
                    DisplayName = "ثبت درخواست",
                    RoleId = 100,
                    ScenarioId = 1
                });
            _list_Endorsement.Add(
                new F_Endorsement
                {
                    Id = 2,
                    ERPCode = 2,
                    SortIndex = 2,
                    Name = "Sample_Scenario,RequestorManager",
                    DisplayName = "بررسی درخواست",
                    RoleId = 101,
                    ScenarioId = 1
                }
                );
            await _context.F_Endorsements.AddRangeAsync(_list_Endorsement);
            #endregion

            #region F_EndorsementItem
            List<F_EndorsementItem> _list_EndorsementItem = new();

            _list_EndorsementItem.Add(
                new F_EndorsementItem
                {
                    Id = 1,
                    ERPCode = 1,
                    SortIndex = 1,
                    CaseStateId = 1,
                    EndorsementId = 1
                });
            _list_EndorsementItem.Add(new F_EndorsementItem
            {
                Id = 2,
                ERPCode = 2,
                SortIndex = 1,
                CaseStateId = 3,
                EndorsementId = 2
            });
            _list_EndorsementItem.Add(new F_EndorsementItem
            {
                Id = 3,
                ERPCode = 3,
                SortIndex = 2,
                CaseStateId = 2,
                EndorsementId = 2
            });
            _list_EndorsementItem.Add(new F_EndorsementItem
            {
                Id = 4,
                ERPCode = 4,
                SortIndex = 3,
                CaseStateId = 4,
                EndorsementId = 2
            }
                );

            await _context.F_EndorsementItems.AddRangeAsync(_list_EndorsementItem);
            #endregion

            #region F_Condition

            List<F_Condition> _list_Condition = new();

            _list_Condition.Add(
                new F_Condition
                {
                    Id = 1,
                    ERPCode = 1,
                    SortIndex = 1,
                    Name = "Price",
                    DisplayName = "مبلغ",
                    TagId = 301,
                    OperandId = 3,
                    Value = "0",
                    ScenarioId = 1
                });
            _list_Condition.Add(
                new F_Condition
                {
                    Id = 2,
                    ERPCode = 2,
                    SortIndex = 1,
                    TagId = 201,
                    OperandId = 1,
                    Value = "0",
                    EndorsementItemId = 1
                });
            _list_Condition.Add(new F_Condition
            {
                Id = 3,
                ERPCode = 3,
                SortIndex = 1,
                TagId = 201,
                OperandId = 1,
                Value = "0",
                EndorsementItemId = 2
            });
            _list_Condition.Add(
                new F_Condition
                {
                    Id = 4,
                    ERPCode = 4,
                    SortIndex = 1,
                    TagId = 203,
                    OperandId = 1,
                    Value = "0",
                    EndorsementItemId = 3
                });

            _list_Condition.Add(new F_Condition
            {
                Id = 5,
                ERPCode = 5,
                SortIndex = 1,
                TagId = 202,
                OperandId = 1,
                Value = "1",
                EndorsementItemId = 4
            }
                );
            await _context.F_Conditions.AddRangeAsync(_list_Condition);
            #endregion

            #endregion

            #region Links

            #region L_UserLocation
            List<L_UserLocation> _list_UserLocation = new();

            _list_UserLocation.Add(
                        new L_UserLocation
                        {
                            Id = 1,
                            ERPCode = 1,
                            SortIndex = 1,
                            Name = "m.sharifi-Fars",
                            DisplayName = "محمد شریفی-فارس",
                            FirstId = 1,
                            SecondId = 1
                        });
            _list_UserLocation.Add(
                        new L_UserLocation
                        {
                            Id = 2,
                            ERPCode = 2,
                            SortIndex = 2,
                            Name = "a.sharifi-Fars",
                            DisplayName = "امین شریفی-فارس",
                            FirstId = 2,
                            SecondId = 1
                        }
                       );

            await _context.L_UserLocations.AddRangeAsync(_list_UserLocation);
            #endregion

            #region L_RolePosition
            List<L_RolePosition> _list_RolePosition = new();

            _list_RolePosition.Add(
                          new L_RolePosition
                          {
                              Id = 1,
                              ERPCode = 1,
                              SortIndex = 1,
                              Name = "Requestor-Expert",
                              DisplayName = "درخواست کننده-کارشناس",
                              FirstId = 100,
                              SecondId = 1
                          });
            _list_RolePosition.Add(
                            new L_RolePosition
                            {
                                Id = 2,
                                ERPCode = 2,
                                SortIndex = 2,
                                Name = "RequestorManager-Expert",
                                DisplayName = "مدیر درخواست کننده-کارشناس",
                                FirstId = 101,
                                SecondId = 1
                            }
                          );
            await _context.L_RolePositions.AddRangeAsync(_list_RolePosition);
            #endregion

            #region L_ProcessScenario
            List<L_ProcessScenario> _list_ProcessScenario = new();
            _list_ProcessScenario.Add(
                          new L_ProcessScenario
                          {
                              Id = 1,
                              ERPCode = 1,
                              SortIndex = 1,
                              Name = "SampleProcess-SampleScenario",
                              DisplayName = "فرآیند نمونه-سناریو نمونه",
                              FirstId = 1,
                              SecondId = 1
                          }
                          );
            await _context.L_ProcessScenarios.AddRangeAsync(_list_ProcessScenario);
            #endregion

            #region L_UserPosition
            List<L_UserPosition> _list_UserPosition = new();

            _list_UserPosition.Add(new L_UserPosition
            {
                Id = 1,
                ERPCode = 1,
                SortIndex = 1,
                Name = "m.sharifi-Expert",
                DisplayName = "محمد شریفی-کارشناس",
                FirstId = 1,
                SecondId = 1
            });
            _list_UserPosition.Add(new L_UserPosition
            {
                Id = 2,
                ERPCode = 2,
                SortIndex = 2,
                Name = "a.sharifi-Expert",
                DisplayName = "امین شریفی-کارشناس",
                FirstId = 2,
                SecondId = 1
            }
                );
            await _context.L_UserPositions.AddRangeAsync(_list_UserPosition);
            #endregion

            #region L_EndorsementItemEndorsement

            List<L_EndorsementItemEndorsement> _list_EndorsementItemEndorsement = new();
            _list_EndorsementItemEndorsement.Add(
                    new L_EndorsementItemEndorsement
                    {
                        Id = 1,
                        ERPCode = 1,
                        SortIndex = 1,
                        FirstId = 1,
                        SecondId = 2
                    });
            _list_EndorsementItemEndorsement.Add(
                    new L_EndorsementItemEndorsement
                    {
                        Id = 2,
                        ERPCode = 2,
                        SortIndex = 2,
                        FirstId = 3,
                        SecondId = 1
                    }
                );
            await _context.L_EndorsementItemEndorsements.AddRangeAsync(_list_EndorsementItemEndorsement);
            #endregion

            #endregion

            await _context.SaveChangesAsync();
        }
    }
}