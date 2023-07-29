using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class EnableRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Links",
                table: "L_UserPosition",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_L_UserPosition_DsblRecord",
                schema: "Links",
                table: "L_UserPosition",
                newName: "IX_L_UserPosition_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Links",
                table: "L_UserLocation",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_L_UserLocation_DsblRecord",
                schema: "Links",
                table: "L_UserLocation",
                newName: "IX_L_UserLocation_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Links",
                table: "L_RolePosition",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_L_RolePosition_DsblRecord",
                schema: "Links",
                table: "L_RolePosition",
                newName: "IX_L_RolePosition_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_L_ProcessScenario_DsblRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                newName: "IX_L_ProcessScenario_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_WorkItem",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_WorkItem_DsblRecord",
                schema: "Facts",
                table: "F_WorkItem",
                newName: "IX_F_WorkItem_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_Scenario",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_Scenario_DsblRecord",
                schema: "Facts",
                table: "F_Scenario",
                newName: "IX_F_Scenario_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_Endorsement",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_Endorsement_DsblRecord",
                schema: "Facts",
                table: "F_Endorsement",
                newName: "IX_F_Endorsement_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_Condition",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_Condition_DsblRecord",
                schema: "Facts",
                table: "F_Condition",
                newName: "IX_F_Condition_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_Case",
                newName: "EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Facts",
                table: "F_Attachment",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_Attachment_DsblRecord",
                schema: "Facts",
                table: "F_Attachment",
                newName: "IX_F_Attachment_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_WorkItemState_DsblRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                newName: "IX_D_WorkItemState_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_UserInformation_DsblRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                newName: "IX_D_UserInformation_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_User",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_User_DsblRecord",
                schema: "Dimentions",
                table: "D_User",
                newName: "IX_D_User_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_TagType",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_TagType_DsblRecord",
                schema: "Dimentions",
                table: "D_TagType",
                newName: "IX_D_TagType_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Tag",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_Tag_DsblRecord",
                schema: "Dimentions",
                table: "D_Tag",
                newName: "IX_D_Tag_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Role",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_Role_DsblRecord",
                schema: "Dimentions",
                table: "D_Role",
                newName: "IX_D_Role_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Process",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_Process_DsblRecord",
                schema: "Dimentions",
                table: "D_Process",
                newName: "IX_D_Process_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Position",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_Position_DsblRecord",
                schema: "Dimentions",
                table: "D_Position",
                newName: "IX_D_Position_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Operand",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_Operand_DsblRecord",
                schema: "Dimentions",
                table: "D_Operand",
                newName: "IX_D_Operand_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Location",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_Location_DsblRecord",
                schema: "Dimentions",
                table: "D_Location",
                newName: "IX_D_Location_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_Entity",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_Entity_DsblRecord",
                schema: "Dimentions",
                table: "D_Entity",
                newName: "IX_D_Entity_EnableRecord");

            migrationBuilder.RenameColumn(
                name: "DsblRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                newName: "EnableRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_CaseState_DsblRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                newName: "IX_D_CaseState_EnableRecord");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4837), true, new Guid("8046a1ea-d999-4dcd-a921-9712848dc589"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4841), true, new Guid("b8f87d45-7e48-484b-bec6-aeffee13b9b7"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4843), true, new Guid("4a49d5fe-40ad-4caf-a2b0-08d166bf81d6"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4857), true, new Guid("44c42543-5463-4ed1-9594-e0fcae6129cc"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4858) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5219), true, new Guid("215b4961-8263-47a8-ae3a-522086a3df90"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5261), true, new Guid("02dd06d2-0bf2-4fbb-89e4-773d91c8313f"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5266), true, new Guid("e13ba552-4c66-47d7-a41a-9e9b729627e2"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5266) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5271), true, new Guid("d01af82b-a5d5-4ffc-9ac4-1540eec6989b"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5279), true, new Guid("39ef1922-8cfa-47ff-b1fb-0f4ef951a9e1"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5284), true, new Guid("a594a5ba-c140-4ef6-b440-ea47e295ba17"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5284) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5289), true, new Guid("85b8754d-e9d3-4bad-8541-6dad5ae073b5"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5294), true, new Guid("063a4708-a1a3-4133-81ec-c3fb149f5e13"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5295) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5299), true, new Guid("9a5625be-7d70-4440-b035-c6f0be05e7b7"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5299) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5304), true, new Guid("a4c46399-c0c4-4dc6-9cc1-b39b705d2fcf"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5309), true, new Guid("b5547864-ecca-48b1-9ce0-d31c0d404382"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5314), true, new Guid("1225df30-e346-4d73-83c8-c9145e037290"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5321), true, new Guid("7e78703b-ad8f-42a2-b5a3-c8a92240b621"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5327), true, new Guid("55b0911e-7a2a-4460-9459-6db757c19595"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5364), true, new Guid("226f6315-60ea-46fa-b4dc-fc1ca421b3fa"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5364) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5370), true, new Guid("ab4fa963-19ee-40ce-be90-01777a40a061"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5375), true, new Guid("74246ac1-2153-42ff-af0b-fa989ac252f7"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5375) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5379), true, new Guid("30315a50-5fff-4ce9-9a24-9a48cecef8ef"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5384), true, new Guid("d1636ed3-c806-4fda-99c8-62dfe6f10f73"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5389), true, new Guid("88747687-456a-425a-89b6-d8f21ce82903"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4909), true, new Guid("1a0c84c6-304d-44aa-9294-0cccf03c13f2"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4912), true, new Guid("83b4ad95-ffc8-40f6-a22a-650b8baa6d69"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4915), true, new Guid("fdb5b223-cd37-415b-a792-1c0f57f4f4e8"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4933), true, new Guid("5f31dd48-1608-41be-ba15-2766de2336dc"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4935), true, new Guid("fd6b894e-45d1-4dfa-a137-4fc8043baf9f"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4936) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4938), true, new Guid("8a291c4c-7eae-4024-a55a-9d717ff70774"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4940), true, new Guid("022d551b-6725-4493-875a-46c259468e1e"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4942), true, new Guid("3f4e5062-fafc-411f-a693-456f3ec4b43f"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4944), true, new Guid("2a7e7dac-d05c-482c-ad68-1b89e6d4cd9d"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4944) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5145), true, new Guid("b5c4b406-3cf2-467f-a1c4-f0f88f2e2c6f"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5148), true, new Guid("40cae5b6-8e54-47b9-b3be-3977b62f8fe9"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5183), true, new Guid("1ecc0bb1-673c-41d8-adf7-4ca4dd6de763"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5188), true, new Guid("bd83373f-a290-456c-a57d-ce4c7cdec4ac"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5190), true, new Guid("96ef58df-d7a7-40a6-acdc-ba353dab5f7a"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5191) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5193), true, new Guid("51281f36-1927-438a-84ee-d2a51b33cf7b"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5196), true, new Guid("4c574138-a7bd-4502-b0d0-c2e17bc2924d"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5196) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4592), true, new Guid("3c2f9296-9ec0-484e-ba77-6f3813a7fb79"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4642), true, new Guid("d1846000-2e20-4429-9e7f-0c1b7cd22b79"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4645), true, new Guid("7a056610-e255-4325-b948-668ecaead987"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5108), true, new Guid("bf6e62b5-ba84-4b84-b612-d8f05d18d322"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5111), true, new Guid("e483179f-97d2-4c77-a2b7-27dfc61dc4c4"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5116), true, new Guid("9971fbd1-07dd-4002-8895-302b5e8776fe"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5118), true, new Guid("7f660c55-1104-48b1-beff-b148dc089d77"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5121), true, new Guid("e04ac72b-8c6f-45b5-a787-8034fc4afe99"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5123), true, new Guid("12eb46df-f127-4477-8950-921081bff05d"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5126), true, new Guid("06ac02f2-509d-484c-815d-c68775ea8726"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5034), true, new Guid("4519e761-2a45-42c2-b809-f632a4080336"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5037), true, new Guid("823fe2e4-0ef8-4981-aedc-f9cfbc4db0e4"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5041), true, new Guid("31a63bea-5d87-44bd-8cb3-fac4498da406"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5041) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5043), true, new Guid("9234f617-91fc-4a85-8ff0-e415750519bd"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5046), true, new Guid("2fe608b3-448b-4cb9-9149-876c0ef163a0"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5048), true, new Guid("b9f18f4b-88a0-4fc3-808e-d68a2a0cba48"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5053), true, new Guid("45d36b2e-edbc-44bb-8fb1-846cf16a934b"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5055), true, new Guid("3e21970a-fd9d-4d1d-b627-c2ef9dae6027"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5058), true, new Guid("901de03b-7203-4cf7-92bf-2ffa2f1e6069"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5060), true, new Guid("68c59c1a-2b6a-48eb-aff6-7367730fb48e"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5008), true, new Guid("2423ca92-4020-420f-b060-c10cf2f44085"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5008) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5011), true, new Guid("70eca073-1246-4223-91b2-476dcd93e25b"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5016), true, new Guid("bde6ca6b-101f-45cf-8da7-d9630aeba013"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5018), true, new Guid("668d436a-67d8-400a-83da-c8c738751df3"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5085), true, new Guid("db379ebb-e6de-48c6-a294-38814a5fb97e"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5088), true, new Guid("615d47f4-b6da-48cf-99be-3c3bf107bdd0"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4881), true, new Guid("52aeb2b7-0fb1-4d45-8942-48d1428a9003"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4883), true, new Guid("d8656a51-b96e-4853-8f07-725b619b1cf0"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4886), true, new Guid("04279562-3be6-42f4-b414-00eb79575876"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4886) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4888), true, new Guid("73e95531-d178-4d17-be52-7a2b9349a114"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5456), true, new Guid("b923c0af-9f3c-4663-8274-996779b3c07b"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5463), true, new Guid("38678c75-ea25-4688-b6f2-980d7f3b104f"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5466), true, new Guid("5e0b8b5b-37e0-4ab1-a9fb-b5e7a42e7b5d"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5467) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5469), true, new Guid("c6846591-2a37-4dc6-b8cd-b96aa0d11a63"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5473), true, new Guid("bab16996-7f97-4eaa-8b9f-719969d8879b"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5473) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5495), true, new Guid("46c6dace-d47c-47c8-ac5d-514bf77686ab"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5496) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5499), true, new Guid("15064e81-acf2-4f92-b8e1-f6c02a44bd28"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5499) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5502), true, new Guid("9eb319f0-9a06-4f2c-82cd-208bac9b88e3"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5502) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5505), true, new Guid("79b59e7e-6844-4207-ba28-671bf8fb9f91"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5427), true, new Guid("a8e6202b-2e91-4557-913f-a8d90021400c"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5427) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5431), true, new Guid("e0bd255c-6a7c-4315-ba0c-e448c280edd0"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5431) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5433), true, new Guid("25ba257d-94d0-4541-8f85-328c5a4378a8"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5690), true, new Guid("5b2c3119-968e-4556-9163-256586d71a06"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5695), true, new Guid("463229fb-26eb-45e2-8861-9a55a87cf788"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5698), true, new Guid("e31d2cc3-16a1-4e23-a3aa-5cd846d052cd"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5701), true, new Guid("b45e6186-d61b-4e3a-96df-146581f16c8e"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5703), true, new Guid("501e576c-888b-4ffd-bdce-8120b932809d"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5649), true, new Guid("95420a20-fbee-404f-a696-2f6559a1167e"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5652), true, new Guid("a0716b55-e27b-41e9-9d12-ed67e3e7e5e6"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5655), true, new Guid("1c5ea599-b471-4d17-b9e7-7315ce3f8401"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5657), true, new Guid("cad43e25-ea81-4029-88db-512202601914"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5660), true, new Guid("27d419da-e8ad-470a-929a-c6ff046721e5"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5663), true, new Guid("f737657b-4cdd-426c-a23d-d4e234ee8ef0"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5665), true, new Guid("c838f365-d2f9-42b8-9d1a-d839e5e1a321"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5528), true, new Guid("db65b952-39c3-42e1-a52f-241ddd3b352b"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5534), true, new Guid("05af6f68-bf2f-4776-86c5-551061f6ac38"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5619), true, new Guid("958259c5-3e14-4f9b-b381-eaff8f28ebbd"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5623), true, new Guid("32a2fa6a-7346-4677-8394-5cffe829fd05"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5721), true, new Guid("075b0d3f-998e-43a5-a596-31b0dc9e62cc"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "EnableRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5724), true, new Guid("025ce52b-3136-4971-ad75-e312629c4914"), new DateTime(2023, 7, 29, 12, 31, 49, 45, DateTimeKind.Local).AddTicks(5724) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Links",
                table: "L_UserPosition",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_L_UserPosition_EnableRecord",
                schema: "Links",
                table: "L_UserPosition",
                newName: "IX_L_UserPosition_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Links",
                table: "L_UserLocation",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_L_UserLocation_EnableRecord",
                schema: "Links",
                table: "L_UserLocation",
                newName: "IX_L_UserLocation_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Links",
                table: "L_RolePosition",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_L_RolePosition_EnableRecord",
                schema: "Links",
                table: "L_RolePosition",
                newName: "IX_L_RolePosition_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_L_ProcessScenario_EnableRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                newName: "IX_L_ProcessScenario_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_WorkItem",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_WorkItem_EnableRecord",
                schema: "Facts",
                table: "F_WorkItem",
                newName: "IX_F_WorkItem_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Scenario",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_Scenario_EnableRecord",
                schema: "Facts",
                table: "F_Scenario",
                newName: "IX_F_Scenario_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Endorsement",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_Endorsement_EnableRecord",
                schema: "Facts",
                table: "F_Endorsement",
                newName: "IX_F_Endorsement_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Condition",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_Condition_EnableRecord",
                schema: "Facts",
                table: "F_Condition",
                newName: "IX_F_Condition_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Case",
                newName: "DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Attachment",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_F_Attachment_EnableRecord",
                schema: "Facts",
                table: "F_Attachment",
                newName: "IX_F_Attachment_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_WorkItemState_EnableRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                newName: "IX_D_WorkItemState_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_UserInformation_EnableRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                newName: "IX_D_UserInformation_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_User",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_User_EnableRecord",
                schema: "Dimentions",
                table: "D_User",
                newName: "IX_D_User_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_TagType",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_TagType_EnableRecord",
                schema: "Dimentions",
                table: "D_TagType",
                newName: "IX_D_TagType_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Tag",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_Tag_EnableRecord",
                schema: "Dimentions",
                table: "D_Tag",
                newName: "IX_D_Tag_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Role",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_Role_EnableRecord",
                schema: "Dimentions",
                table: "D_Role",
                newName: "IX_D_Role_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Process",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_Process_EnableRecord",
                schema: "Dimentions",
                table: "D_Process",
                newName: "IX_D_Process_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Position",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_Position_EnableRecord",
                schema: "Dimentions",
                table: "D_Position",
                newName: "IX_D_Position_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Operand",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_Operand_EnableRecord",
                schema: "Dimentions",
                table: "D_Operand",
                newName: "IX_D_Operand_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Location",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_Location_EnableRecord",
                schema: "Dimentions",
                table: "D_Location",
                newName: "IX_D_Location_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Entity",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_Entity_EnableRecord",
                schema: "Dimentions",
                table: "D_Entity",
                newName: "IX_D_Entity_DsblRecord");

            migrationBuilder.RenameColumn(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                newName: "DsblRecord");

            migrationBuilder.RenameIndex(
                name: "IX_D_CaseState_EnableRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                newName: "IX_D_CaseState_DsblRecord");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8499), false, new Guid("fd4f6d99-c06c-456a-9e5c-c97a8f83107b"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8503), false, new Guid("ce5c717c-2fef-4022-af95-f5af50f7d904"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8506), false, new Guid("b27a4346-0a50-480a-a472-a415eb9b640b"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8508), false, new Guid("21c0c7b0-7167-427f-ab43-9c263dcc6a4f"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8508) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8955), false, new Guid("f0a2e665-c86e-40b7-a1d0-507662406ad8"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8956) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8998), false, new Guid("e63110f0-5936-4644-9a6c-1edf4dd4bd89"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9003), false, new Guid("a4da7f06-9401-4b98-9a26-91f8948337e3"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9009), false, new Guid("5296e059-74cb-47f1-9a67-c1205f9fb0e7"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9014), false, new Guid("39bf9a54-e0bc-4b49-ab6d-52615545481b"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9015) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9019), false, new Guid("1b666849-b6dd-4d61-8d72-8d0d533b964b"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9027), false, new Guid("e5365ba8-4351-4c2f-b285-63d85a85b644"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9027) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9032), false, new Guid("f2a454ec-7f5e-4701-a020-2a2ec12138c9"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9037), false, new Guid("d109d5f6-9142-4572-920a-dbc13f26df90"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9042), false, new Guid("1caf5916-4ddc-4f12-aad9-652d4e4063b6"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9047), false, new Guid("be45296a-6b79-441c-9891-17afbdfa5cde"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9084), false, new Guid("ccbded1e-2efe-42ea-a9f3-7469146b696d"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9089), false, new Guid("76f9b0bb-739e-498d-a34d-f1cb34380bac"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9094), false, new Guid("68971932-d612-4ecb-9daf-86f7e0184628"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9102), false, new Guid("97f55404-f0a3-498c-b7dc-fa02c651fe84"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9107), false, new Guid("8fe82ec1-bb57-4f35-9a02-4d1f6de2a8c4"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9112), false, new Guid("019a7cf2-88a4-4c4a-85f7-f1ffc3a7c515"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9117), false, new Guid("19161cf6-a10c-49e5-aeb0-871cbd79003f"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9122), false, new Guid("e2f6dbd9-2bd8-4856-953e-6bf056ebeeed"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9127), false, new Guid("b7b9236b-7f26-4af0-ac72-23154f94df7c"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8577), false, new Guid("ff517ed5-6242-4c50-b695-11552eb2d3f3"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8664), false, new Guid("86612d3c-4564-4ae2-aac2-2138409baa67"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8664) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8667), false, new Guid("7e429c31-a0f2-402a-b938-49754bd41e57"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8688), false, new Guid("e1441603-80e3-499d-8e48-9517d3d85d20"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8691), false, new Guid("d925c208-b21a-4d05-bb56-5c0ec145a7c7"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8696), false, new Guid("eb757e8a-89a0-4c0d-b9b8-41373d67f6ae"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8699), false, new Guid("15e4c51b-a3cb-487c-8b7e-1e57e54140eb"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8701), false, new Guid("2ee5e330-dd3b-43c0-bfb1-e212ffbf9596"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8703), false, new Guid("a0a6b855-0514-4c16-a338-0139f5061938"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8703) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8917), false, new Guid("397a4a87-dca4-464c-b1db-ef418af864d7"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8920), false, new Guid("339d04da-599c-49dd-92f0-1357a40fe8d2"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8923), false, new Guid("b907ae10-eb91-4d1f-9328-9993e2a1479c"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8925), false, new Guid("c7b54875-feb8-4dc6-bda3-7e2a978e00e0"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8927), false, new Guid("0a2c9f9b-2cd8-4a74-958e-567a00374297"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8932), false, new Guid("1ef59a1d-8a89-4a8a-aae4-688cca77aa02"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8934), false, new Guid("a3f33b3a-42f2-434f-b9d4-ff9cec11301e"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8237), false, new Guid("a4bd5608-1c33-4fd3-8ccb-0a614d69df89"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8252) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8282), false, new Guid("129fd459-d338-4e0e-9b8a-15d515514c37"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8285), false, new Guid("04561cc5-e06b-4b8c-814b-d65e51116080"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8840), false, new Guid("47b02712-02b8-4c1a-8504-c2a1482d2a9b"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8844), false, new Guid("b41f8897-4979-4d48-9288-aa18f295a260"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8846), false, new Guid("ff40608a-59b3-4fc2-9f8c-318df0c462bb"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8849), false, new Guid("a7a4f3f4-fe30-43a2-9b13-84de2acadaaf"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8853), false, new Guid("c913d8f9-02d8-4221-af58-5126eb5d10e8"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8888), false, new Guid("8613bb97-6bf3-43b6-9034-20477e8f46e4"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8892), false, new Guid("c78569b8-c59b-466a-9815-1a1e8eab607b"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8761), false, new Guid("12cad801-b12e-4fb4-979d-8aacad451a38"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8764), false, new Guid("41ff8e6a-6855-4ff4-8272-12bdbce1d95b"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8767), false, new Guid("fe50c3aa-562d-4893-be37-c149d1a225e5"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8770), false, new Guid("1a588a30-820a-4d48-88e9-c894b35d79c5"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8772), false, new Guid("1ccdaed1-6d11-41e5-8390-cc0e7d850972"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8775), false, new Guid("aba6a636-fa7c-4fee-9e19-f6ca0cc37ade"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8777), false, new Guid("37360c2e-ba4c-4f39-8440-0fe033edfb83"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8780), false, new Guid("05e06e02-01a5-4d78-9751-49fb8dee1efe"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8785), false, new Guid("b3a92a8f-b7b6-4c5a-8cbf-771819d62d90"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8787), false, new Guid("4ac51a36-f33b-46d7-a5ee-03cf5ea5092e"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8735), false, new Guid("29852415-805b-409f-ada2-061fff782592"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8737), false, new Guid("ff2ae788-4a8f-480b-8541-77bf8a92022f"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8739), false, new Guid("5c8ec177-c134-46ec-bcb8-96f050b05efd"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8742), false, new Guid("9a4639ab-802a-4428-acb7-5935bee9fda4"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8814), false, new Guid("276d3920-3bd9-4bcf-aeaf-a7770ed10a73"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8817), false, new Guid("5b47f230-9b88-4939-8cab-62525c05085f"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8534), false, new Guid("47f0134b-9d2c-4f1d-8d1c-6323dcd8e455"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8549), false, new Guid("1502b21a-6fa3-4746-b446-7cd176609dbd"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8551), false, new Guid("770a0c38-ee81-4cc9-bbb0-cb4028e13853"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8554), false, new Guid("7a359e43-5177-496e-863d-82750a499e10"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(8554) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9197), false, new Guid("b8445b5d-82be-4a97-b082-36eb05ea3c8b"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9204), false, new Guid("ef5aec23-6a00-45e7-8279-a80c6d7a5fc8"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9207), false, new Guid("04cbf140-7b51-4e3a-867b-3be80c068faa"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9210), false, new Guid("113785aa-aeec-42c0-a6db-a77595b2402f"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9212), false, new Guid("2e8e36ba-5767-440a-8e80-736153af2880"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9265), false, new Guid("91260251-fe5b-4e52-9595-16ba80915981"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9270), false, new Guid("3db0826c-a013-4245-8e3e-a3e45beff6be"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9275), false, new Guid("52ee10ee-d289-4ac1-b93a-01f98fb4ff9a"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9279), false, new Guid("e2026d3c-2f3d-4193-9e3c-611d5d8407fc"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9166), false, new Guid("7d0f3a0d-6ccc-446d-8793-50b8563c48b7"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9169), false, new Guid("156d85b2-a63b-4c49-a653-083796ca3d69"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9174), false, new Guid("df4d6a97-2b30-46cf-b1cb-75d2032de0cb"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9380), false, new Guid("8cf725c7-13c3-4f5e-aef2-d01eb6431119"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9383), false, new Guid("cbc06e89-e5ad-47e2-b7cb-2c7f6b404084"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9386), false, new Guid("c0173932-f9de-4e5a-8ef0-a3d5a0b5cc41"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9386) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9391), false, new Guid("151d4d1d-b184-4406-a1b6-6e2566398ff3"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9391) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9393), false, new Guid("ff012055-bc82-4d98-b59f-4b11604112ed"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9394) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9339), false, new Guid("d4bf7166-862b-4d32-9769-812a7e228e1f"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9342), false, new Guid("8f28bf8b-14f1-4fad-8036-65ded51c78a6"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9347), false, new Guid("c2544734-6e9a-4e76-a9e3-b5d55a7a7e87"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9350), false, new Guid("650d2468-9427-4949-8cc3-079daeb43ee7"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9353), false, new Guid("db8c3519-5db2-4622-bcef-6b86402ff47a"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9356), false, new Guid("23731061-0aeb-409f-8f43-8a167f455c25"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9356) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9358), false, new Guid("53d0efcd-8ace-49d5-bb28-606f2f7d1d6d"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9310), false, new Guid("9dd6b446-8fd3-4b9e-afb2-26d712422cf7"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9314), false, new Guid("1a37ced0-2263-4967-b876-1147d16ecf3d"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9317), false, new Guid("0d7421c6-c3d5-4270-bfcc-cd39774cf9f8"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9317) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9319), false, new Guid("ccf15fb5-5adb-4efe-ba4d-e8a7e4f10c8a"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9415), false, new Guid("ca59bb50-5c3a-42e0-b0fc-8fea07ff6bf9"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9418), false, new Guid("2bb1aef3-22d6-4f42-8872-7ceb964b115c"), new DateTime(2023, 7, 26, 15, 46, 24, 371, DateTimeKind.Local).AddTicks(9419) });
        }
    }
}
