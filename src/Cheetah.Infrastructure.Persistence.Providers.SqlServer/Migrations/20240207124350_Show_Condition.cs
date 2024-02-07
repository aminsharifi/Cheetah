using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Show_Condition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserPosition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("012fdc85-83d1-4e7c-822b-b0847896cc84"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("963ebe24-08bf-4d31-b2d6-597e855afa30"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserPosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 389, DateTimeKind.Unspecified).AddTicks(1694), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 992, DateTimeKind.Unspecified).AddTicks(3802), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserLocation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("2ac1a45e-f530-473d-9cb3-b7a53ad4f4d1"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("6ab94bb4-179c-45ed-b61d-1e8452e04801"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserLocation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 388, DateTimeKind.Unspecified).AddTicks(9238), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 992, DateTimeKind.Unspecified).AddTicks(1147), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskAction",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e90199d0-e2e9-46ea-88bd-ac261290ad02"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("fc1a346f-fde0-4671-a9f0-30a19dff658d"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskAction",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 388, DateTimeKind.Unspecified).AddTicks(1079), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 991, DateTimeKind.Unspecified).AddTicks(8549), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_RolePosition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f717da01-9ef8-4831-ae11-0f38d88d177b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("faf237b8-d006-48ab-9325-f87877c7468b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_RolePosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 387, DateTimeKind.Unspecified).AddTicks(8956), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 991, DateTimeKind.Unspecified).AddTicks(6067), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8b3acd40-13d1-4ea7-83d9-8992dd23768b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a1f47cc0-fd64-430f-a8e3-856c014ac2a4"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 387, DateTimeKind.Unspecified).AddTicks(6767), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 991, DateTimeKind.Unspecified).AddTicks(3418), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("12ca17c5-4254-4f29-9655-4a0a8b7d23c8"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("2be3293f-fc74-4917-9efa-7123931d9a2c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 387, DateTimeKind.Unspecified).AddTicks(4542), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 991, DateTimeKind.Unspecified).AddTicks(826), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ca1aa316-318b-4a50-88b6-6b47191c83df"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1ba507c5-b71b-4912-96a4-08ec0e82ed95"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 387, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 990, DateTimeKind.Unspecified).AddTicks(8129), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5e83b3fc-d835-4095-ad0c-2409dbb9fa80"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9c94d8e9-339c-40d1-88ed-cc0c6e83ed47"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 387, DateTimeKind.Unspecified).AddTicks(245), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 990, DateTimeKind.Unspecified).AddTicks(5969), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("418f056b-1aff-4870-abec-7bb96f1b7091"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1cce491f-cdac-461a-b722-a5fc06040635"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 386, DateTimeKind.Unspecified).AddTicks(8528), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 990, DateTimeKind.Unspecified).AddTicks(3787), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8d1c4a1e-37c9-4c74-a1db-b437531547a9"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b4068e23-b96a-4fb9-bc4d-8f1bfc2b030c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 386, DateTimeKind.Unspecified).AddTicks(6701), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 990, DateTimeKind.Unspecified).AddTicks(1791), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1d7cf20f-5c43-40b4-8d7e-8732398cd305"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("88c684df-8884-4e83-ad02-3a1925e004ad"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 386, DateTimeKind.Unspecified).AddTicks(4001), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 989, DateTimeKind.Unspecified).AddTicks(8780), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c3740d8f-81b5-4f5c-a168-236df19939c2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("81a169ef-d4ba-401f-ae75-53206ceb4941"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 386, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 989, DateTimeKind.Unspecified).AddTicks(6640), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Action",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5694b941-9a21-4b56-83c8-4b3925ea2d63"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ac4a6e0e-9084-494b-b2d7-00b8e6c0a48a"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Action",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 386, DateTimeKind.Unspecified).AddTicks(335), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 989, DateTimeKind.Unspecified).AddTicks(4865), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("32d43554-7574-4a47-8027-5f46f5ff0215"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("0d0ff193-54a1-4760-ae17-584aa2f98517"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 385, DateTimeKind.Unspecified).AddTicks(8809), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 989, DateTimeKind.Unspecified).AddTicks(3235), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a817c2eb-99cc-413d-8ebf-27f7843a43c2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("23aba9e4-5c5b-44b0-8e65-82125cdd6f09"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 385, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 989, DateTimeKind.Unspecified).AddTicks(1392), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7048384f-0764-443e-a430-31813161843f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3e770f6a-efc4-4c1f-8a6f-b10637456c24"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 385, DateTimeKind.Unspecified).AddTicks(5619), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(9350), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a63385d0-2a90-43af-8aa2-c3aa5abbae1e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a2497045-ebda-47ec-b278-bb52a7042085"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 385, DateTimeKind.Unspecified).AddTicks(3703), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(7175), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8dbd66ce-a2ea-4aa6-9ffa-fe1eb22675cc"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("eef57a1e-15ce-4cee-b29b-4b644d4dcc74"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 385, DateTimeKind.Unspecified).AddTicks(1968), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(5668), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a00c02bd-9325-404c-a80a-b286973bab6f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f439ada9-a416-4e52-bb06-db5d1acb9973"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 385, DateTimeKind.Unspecified).AddTicks(366), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(3990), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f43c0ae7-8676-48ec-9c66-4c3e0fbfdc19"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("45925529-610f-4559-ab97-a4d0aa2e6de8"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 384, DateTimeKind.Unspecified).AddTicks(8997), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(2178), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("09be89d9-1845-45fb-a5ab-32dbf2de6e02"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c021e67c-3d3c-434a-9110-58a116f61585"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 384, DateTimeKind.Unspecified).AddTicks(7558), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(493), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("85177938-b17a-499a-848d-c0b21437f78b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("4b36d22c-9246-4643-a764-7d186646e843"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 384, DateTimeKind.Unspecified).AddTicks(6151), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 987, DateTimeKind.Unspecified).AddTicks(8479), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("6cc238d8-5dbf-4554-bc9f-5c5682f5bc01"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8a4bd697-4a08-446e-96b1-5ad978db47ac"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 384, DateTimeKind.Unspecified).AddTicks(4590), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 987, DateTimeKind.Unspecified).AddTicks(7020), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("50def198-b831-45a7-92e1-f95cf0d94bd4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b1d8d434-045c-489d-a617-ac27487ceb0c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 384, DateTimeKind.Unspecified).AddTicks(2237), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 987, DateTimeKind.Unspecified).AddTicks(5461), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("057bbd3f-8db3-4337-8280-8be66b863411"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("29ac12d4-f166-4f5c-9309-c154ca669d72"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 384, DateTimeKind.Unspecified).AddTicks(595), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 987, DateTimeKind.Unspecified).AddTicks(3438), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.CreateTable(
                name: "L_UserCondition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 388, DateTimeKind.Unspecified).AddTicks(6168), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("0d1a827b-48d7-4b81-8dd6-6ae51175c256")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserCondition_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_UserCondition_F_Condition_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 24, DateTimeKind.Unspecified).AddTicks(3123), new TimeSpan(0, 3, 30, 0, 0)), new Guid("204470ae-f73a-473c-842a-cc0cc694e0cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 24, DateTimeKind.Unspecified).AddTicks(3131), new TimeSpan(0, 3, 30, 0, 0)), new Guid("59ad9664-40c6-4779-80ca-5b9504c5131f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 24, DateTimeKind.Unspecified).AddTicks(3134), new TimeSpan(0, 3, 30, 0, 0)), new Guid("682f5a9e-08a7-476c-b251-3ebb29b6a68e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 24, DateTimeKind.Unspecified).AddTicks(3142), new TimeSpan(0, 3, 30, 0, 0)), new Guid("08f51118-b6b1-4fc9-89ad-8d5d4b8182a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 24, DateTimeKind.Unspecified).AddTicks(3145), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c116627b-4330-46c9-82fb-060418d4f512") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 25, DateTimeKind.Unspecified).AddTicks(3949), new TimeSpan(0, 3, 30, 0, 0)), new Guid("21d51f3f-b342-43df-907a-e7a36bd5b456") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(3893), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6c05ad91-c577-4f05-b249-34824055ebff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(3923), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e0c3c195-f899-4683-9da5-0350b449334f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(3930), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2899cd97-55be-4079-a5bd-cc3c502c32f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(3937), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ccdbe636-e20a-4892-a5ea-eec9ad4f8620") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(3953), new TimeSpan(0, 3, 30, 0, 0)), new Guid("10efb314-0b79-452d-ac78-93430ed19951") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(3965), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ebab267a-ae50-49bc-95d2-850d6d126a01") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(3971), new TimeSpan(0, 3, 30, 0, 0)), new Guid("30b7cc1f-1ce0-4d3c-8fb6-64a03d81b414") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(3978), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c4fb3ea7-9767-4b62-aa46-955d836a1928") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(4039), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c5e614d5-8208-42a9-8b27-14393f12e350") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(4046), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd5b67e9-2512-4d68-a2cd-6f0936e5edad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(4052), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0c5815c3-fb9c-4193-8b35-5736333490d6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(4066), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9d75e7b6-0b0e-4bcd-9cbf-d38cb7b15b88") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "Created", "Display", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(4071), new TimeSpan(0, 3, 30, 0, 0)), true, new Guid("bb8fcf38-034a-4d01-8128-2f92f8c2a10c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(4079), new TimeSpan(0, 3, 30, 0, 0)), new Guid("67c97a4a-6522-4eed-8036-45ad0e9cf609") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(4084), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d3df88c9-65f4-432d-b89c-e1a3c8ad428f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(4089), new TimeSpan(0, 3, 30, 0, 0)), new Guid("99af582b-dc89-408c-b445-2bab5cb687d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(4093), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d0ecb57c-efb3-44f2-9b6b-6941fa0633fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(4099), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8fac1a33-cefb-49b5-9475-7aa04f207339") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(4104), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7602338d-687b-4d8f-aa01-11523a3ca40d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(5315), new TimeSpan(0, 3, 30, 0, 0)), new Guid("471890d5-0ffb-43d6-a4f2-ffdf2c99fc91") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(7111), new TimeSpan(0, 3, 30, 0, 0)), new Guid("46ab08a6-b3f3-42f4-ba96-877fa663f0cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(7121), new TimeSpan(0, 3, 30, 0, 0)), new Guid("efcf6538-1787-426a-9657-d573e8da00da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(7124), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a560406a-deb2-4635-97a7-aff483b94554") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(7127), new TimeSpan(0, 3, 30, 0, 0)), new Guid("801895bc-27e5-4e8d-9b00-430fe5f43179") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(7130), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4bdcedbb-8100-4475-a053-0f5c97bd41ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 3, 30, 0, 0)), new Guid("56517d2c-aeec-435d-a529-98c265d6845c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(8403), new TimeSpan(0, 3, 30, 0, 0)), new Guid("664e35bc-fd09-4979-ae44-e37f58ccd76e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 26, DateTimeKind.Unspecified).AddTicks(9258), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7571d373-c54b-436c-b55d-46c4839ed3e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 27, DateTimeKind.Unspecified).AddTicks(185), new TimeSpan(0, 3, 30, 0, 0)), new Guid("af34e871-173f-40c2-bfb7-82f60f966ed4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 27, DateTimeKind.Unspecified).AddTicks(340), new TimeSpan(0, 3, 30, 0, 0)), new Guid("69655505-3c09-424c-8b1a-2b0d0b6c16bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 27, DateTimeKind.Unspecified).AddTicks(2172), new TimeSpan(0, 3, 30, 0, 0)), new Guid("df20a4c6-7458-4031-9d01-8b5368fcf870") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 27, DateTimeKind.Unspecified).AddTicks(2467), new TimeSpan(0, 3, 30, 0, 0)), new Guid("68f70bbc-a124-4f34-b311-94b0b5886f26") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 27, DateTimeKind.Unspecified).AddTicks(2471), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6d554abe-0e1b-45c0-9804-a760538b6e91") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 27, DateTimeKind.Unspecified).AddTicks(2474), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c6d57ab5-d628-4584-849d-82b5884c35ff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 27, DateTimeKind.Unspecified).AddTicks(2477), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a9b0e98a-1b5f-4dc0-b422-4d896c301ba9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 27, DateTimeKind.Unspecified).AddTicks(3682), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a8815933-2b17-48bd-9f8e-9786e7ae3a36") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 27, DateTimeKind.Unspecified).AddTicks(3687), new TimeSpan(0, 3, 30, 0, 0)), new Guid("67aeb0ba-58e3-4b82-a4c1-3e51c1007909") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 27, DateTimeKind.Unspecified).AddTicks(3693), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4d43c065-8281-4801-87d2-7b5e5982bf1a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 27, DateTimeKind.Unspecified).AddTicks(3696), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9068cf9d-37c9-423c-8a74-9c739cc5c866") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 27, DateTimeKind.Unspecified).AddTicks(6354), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d744ecf8-a1c6-4e39-a6b7-089720beac2e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 27, DateTimeKind.Unspecified).AddTicks(6408), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4e2cff7e-d621-47c0-9f50-134ea5d16588") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 27, DateTimeKind.Unspecified).AddTicks(7930), new TimeSpan(0, 3, 30, 0, 0)), new Guid("58d34faa-bb9e-4597-873c-cd00e0cc5515") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 27, DateTimeKind.Unspecified).AddTicks(7936), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e09eb57d-652e-458d-bbe5-8afa18b914ba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 27, DateTimeKind.Unspecified).AddTicks(7939), new TimeSpan(0, 3, 30, 0, 0)), new Guid("55f36f7b-122c-48bb-a81d-d7e5c5696b97") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 27, DateTimeKind.Unspecified).AddTicks(7941), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ac07c24f-4069-49ee-abfb-71137b6c791e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Action",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 23, DateTimeKind.Unspecified).AddTicks(5123), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d115e683-49b0-43e6-83ab-e32fd9a88374") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Action",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 23, DateTimeKind.Unspecified).AddTicks(5349), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c01db67b-721c-4571-a34b-0a0bf7a82a25") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Action",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 23, DateTimeKind.Unspecified).AddTicks(5353), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7fe1a2f2-783c-4992-b302-975059b7497d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Action",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 23, DateTimeKind.Unspecified).AddTicks(5356), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a253f8e-50ee-4b44-983b-39b543efa878") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 23, DateTimeKind.Unspecified).AddTicks(7718), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f4d7e976-fc44-4a0d-b8ce-31e2de4ac67c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 23, DateTimeKind.Unspecified).AddTicks(8387), new TimeSpan(0, 3, 30, 0, 0)), new Guid("41645398-96f8-426c-8632-cba656d2b5de") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 23, DateTimeKind.Unspecified).AddTicks(8494), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ab29ec1b-f8d6-4718-8c53-9d756d198f96") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 23, DateTimeKind.Unspecified).AddTicks(8503), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d1e079d8-f95a-4ab6-9044-c6ee081ff185") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 23, DateTimeKind.Unspecified).AddTicks(8507), new TimeSpan(0, 3, 30, 0, 0)), new Guid("03db51d3-07b5-42f4-bc99-d49025c2cab4") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 23, DateTimeKind.Unspecified).AddTicks(9760), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4017590d-51b4-488c-adf6-607b64b50d6c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 24, DateTimeKind.Unspecified).AddTicks(993), new TimeSpan(0, 3, 30, 0, 0)), new Guid("57ddeeb5-59a8-4aa7-8cd6-747372482a2c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 24, DateTimeKind.Unspecified).AddTicks(1455), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a5870b61-e837-47ca-9f08-489c9b90750c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 21, DateTimeKind.Unspecified).AddTicks(9238), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cedebbe8-d2df-49e7-9529-6c071dc1438e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 23, DateTimeKind.Unspecified).AddTicks(73), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3d8f160e-801f-4b04-b3cd-b367eb9a279a") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 23, DateTimeKind.Unspecified).AddTicks(119), new TimeSpan(0, 3, 30, 0, 0)), new Guid("92510add-f03d-4461-a32d-8533925f570e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 23, DateTimeKind.Unspecified).AddTicks(1983), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7aca5b5c-baeb-4581-8d94-52e74acde9a4") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 23, DateTimeKind.Unspecified).AddTicks(1991), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6a844a37-8258-4332-9cf3-87fd77288657") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 23, DateTimeKind.Unspecified).AddTicks(2936), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e1108a43-6d57-4ceb-9b0a-0a10402da035") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 23, DateTimeKind.Unspecified).AddTicks(2949), new TimeSpan(0, 3, 30, 0, 0)), new Guid("da44096a-b1cb-44af-b555-c3760c4fc809") });

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_Created",
                schema: "Links",
                table: "L_UserCondition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_EnableRecord",
                schema: "Links",
                table: "L_UserCondition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_ERPCode",
                schema: "Links",
                table: "L_UserCondition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_FifthId",
                schema: "Links",
                table: "L_UserCondition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_FirstId",
                schema: "Links",
                table: "L_UserCondition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_FourthId",
                schema: "Links",
                table: "L_UserCondition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_LastModified",
                schema: "Links",
                table: "L_UserCondition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_Name",
                schema: "Links",
                table: "L_UserCondition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_SecondId",
                schema: "Links",
                table: "L_UserCondition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_ThirdId",
                schema: "Links",
                table: "L_UserCondition",
                column: "ThirdId",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "L_UserCondition",
                schema: "Links");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserPosition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("963ebe24-08bf-4d31-b2d6-597e855afa30"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("012fdc85-83d1-4e7c-822b-b0847896cc84"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserPosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 992, DateTimeKind.Unspecified).AddTicks(3802), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 389, DateTimeKind.Unspecified).AddTicks(1694), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserLocation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("6ab94bb4-179c-45ed-b61d-1e8452e04801"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("2ac1a45e-f530-473d-9cb3-b7a53ad4f4d1"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserLocation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 992, DateTimeKind.Unspecified).AddTicks(1147), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 388, DateTimeKind.Unspecified).AddTicks(9238), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskAction",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("fc1a346f-fde0-4671-a9f0-30a19dff658d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e90199d0-e2e9-46ea-88bd-ac261290ad02"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskAction",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 991, DateTimeKind.Unspecified).AddTicks(8549), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 388, DateTimeKind.Unspecified).AddTicks(1079), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_RolePosition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("faf237b8-d006-48ab-9325-f87877c7468b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f717da01-9ef8-4831-ae11-0f38d88d177b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_RolePosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 991, DateTimeKind.Unspecified).AddTicks(6067), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 387, DateTimeKind.Unspecified).AddTicks(8956), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a1f47cc0-fd64-430f-a8e3-856c014ac2a4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8b3acd40-13d1-4ea7-83d9-8992dd23768b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 991, DateTimeKind.Unspecified).AddTicks(3418), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 387, DateTimeKind.Unspecified).AddTicks(6767), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("2be3293f-fc74-4917-9efa-7123931d9a2c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("12ca17c5-4254-4f29-9655-4a0a8b7d23c8"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 991, DateTimeKind.Unspecified).AddTicks(826), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 387, DateTimeKind.Unspecified).AddTicks(4542), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1ba507c5-b71b-4912-96a4-08ec0e82ed95"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ca1aa316-318b-4a50-88b6-6b47191c83df"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 990, DateTimeKind.Unspecified).AddTicks(8129), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 387, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9c94d8e9-339c-40d1-88ed-cc0c6e83ed47"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5e83b3fc-d835-4095-ad0c-2409dbb9fa80"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 990, DateTimeKind.Unspecified).AddTicks(5969), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 387, DateTimeKind.Unspecified).AddTicks(245), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1cce491f-cdac-461a-b722-a5fc06040635"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("418f056b-1aff-4870-abec-7bb96f1b7091"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 990, DateTimeKind.Unspecified).AddTicks(3787), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 386, DateTimeKind.Unspecified).AddTicks(8528), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b4068e23-b96a-4fb9-bc4d-8f1bfc2b030c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8d1c4a1e-37c9-4c74-a1db-b437531547a9"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 990, DateTimeKind.Unspecified).AddTicks(1791), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 386, DateTimeKind.Unspecified).AddTicks(6701), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("88c684df-8884-4e83-ad02-3a1925e004ad"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1d7cf20f-5c43-40b4-8d7e-8732398cd305"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 989, DateTimeKind.Unspecified).AddTicks(8780), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 386, DateTimeKind.Unspecified).AddTicks(4001), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("81a169ef-d4ba-401f-ae75-53206ceb4941"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c3740d8f-81b5-4f5c-a168-236df19939c2"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 989, DateTimeKind.Unspecified).AddTicks(6640), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 386, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Action",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ac4a6e0e-9084-494b-b2d7-00b8e6c0a48a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5694b941-9a21-4b56-83c8-4b3925ea2d63"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Action",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 989, DateTimeKind.Unspecified).AddTicks(4865), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 386, DateTimeKind.Unspecified).AddTicks(335), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("0d0ff193-54a1-4760-ae17-584aa2f98517"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("32d43554-7574-4a47-8027-5f46f5ff0215"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 989, DateTimeKind.Unspecified).AddTicks(3235), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 385, DateTimeKind.Unspecified).AddTicks(8809), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("23aba9e4-5c5b-44b0-8e65-82125cdd6f09"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a817c2eb-99cc-413d-8ebf-27f7843a43c2"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 989, DateTimeKind.Unspecified).AddTicks(1392), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 385, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3e770f6a-efc4-4c1f-8a6f-b10637456c24"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7048384f-0764-443e-a430-31813161843f"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(9350), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 385, DateTimeKind.Unspecified).AddTicks(5619), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a2497045-ebda-47ec-b278-bb52a7042085"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a63385d0-2a90-43af-8aa2-c3aa5abbae1e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(7175), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 385, DateTimeKind.Unspecified).AddTicks(3703), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("eef57a1e-15ce-4cee-b29b-4b644d4dcc74"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8dbd66ce-a2ea-4aa6-9ffa-fe1eb22675cc"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(5668), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 385, DateTimeKind.Unspecified).AddTicks(1968), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f439ada9-a416-4e52-bb06-db5d1acb9973"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a00c02bd-9325-404c-a80a-b286973bab6f"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(3990), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 385, DateTimeKind.Unspecified).AddTicks(366), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("45925529-610f-4559-ab97-a4d0aa2e6de8"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f43c0ae7-8676-48ec-9c66-4c3e0fbfdc19"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(2178), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 384, DateTimeKind.Unspecified).AddTicks(8997), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c021e67c-3d3c-434a-9110-58a116f61585"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("09be89d9-1845-45fb-a5ab-32dbf2de6e02"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 988, DateTimeKind.Unspecified).AddTicks(493), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 384, DateTimeKind.Unspecified).AddTicks(7558), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("4b36d22c-9246-4643-a764-7d186646e843"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("85177938-b17a-499a-848d-c0b21437f78b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 987, DateTimeKind.Unspecified).AddTicks(8479), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 384, DateTimeKind.Unspecified).AddTicks(6151), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8a4bd697-4a08-446e-96b1-5ad978db47ac"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("6cc238d8-5dbf-4554-bc9f-5c5682f5bc01"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 987, DateTimeKind.Unspecified).AddTicks(7020), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 384, DateTimeKind.Unspecified).AddTicks(4590), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b1d8d434-045c-489d-a617-ac27487ceb0c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("50def198-b831-45a7-92e1-f95cf0d94bd4"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 987, DateTimeKind.Unspecified).AddTicks(5461), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 384, DateTimeKind.Unspecified).AddTicks(2237), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("29ac12d4-f166-4f5c-9309-c154ca669d72"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("057bbd3f-8db3-4337-8280-8be66b863411"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 987, DateTimeKind.Unspecified).AddTicks(3438), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 7, 16, 13, 49, 384, DateTimeKind.Unspecified).AddTicks(595), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 583, DateTimeKind.Unspecified).AddTicks(1048), new TimeSpan(0, 3, 30, 0, 0)), new Guid("19475260-09c7-42a6-a6e9-bde4adfc09bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 583, DateTimeKind.Unspecified).AddTicks(1054), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8e74ab29-18a1-4b6f-a111-0f18e9a78874") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 583, DateTimeKind.Unspecified).AddTicks(1057), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f5c836a4-37df-4f5f-8514-ca5a68371bbc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 583, DateTimeKind.Unspecified).AddTicks(1064), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ccfb176b-2ffa-4e56-8fd6-f8a41b70f3a9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 583, DateTimeKind.Unspecified).AddTicks(1067), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c1ede1c9-f61f-4201-aebe-0fd79510ed7d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 584, DateTimeKind.Unspecified).AddTicks(1159), new TimeSpan(0, 3, 30, 0, 0)), new Guid("321f14f4-882c-4273-b817-3c3197b7f9f6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(982), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cbdaa45c-c5de-4ff7-b624-647f86fcae29") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1016), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd919d24-8068-405e-b43d-04aa6d4ceb09") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1024), new TimeSpan(0, 3, 30, 0, 0)), new Guid("984a95aa-403d-44eb-bfc3-0455452f9edd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1030), new TimeSpan(0, 3, 30, 0, 0)), new Guid("56a2fb72-b391-4eb9-88cc-67e2e512adae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1036), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e7ba93f4-807c-4749-8c88-d5f16aa85f7c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1046), new TimeSpan(0, 3, 30, 0, 0)), new Guid("02e34806-230f-471b-b36d-da14bd9314c0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1100), new TimeSpan(0, 3, 30, 0, 0)), new Guid("23733f3c-8f2e-4dd6-be41-b4fa6c395511") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1106), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ea1083fe-bf2c-4472-b775-b83761115f1d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1111), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2143cca9-00ec-4657-9d94-c2977ccfd232") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1116), new TimeSpan(0, 3, 30, 0, 0)), new Guid("336754b9-658c-4868-a17c-968be1a63ba5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1122), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7b67f284-6b8b-4aa7-9024-cc2f63e01208") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1127), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b6c739eb-2a88-400d-910a-292914f80fc9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "Created", "Display", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1132), new TimeSpan(0, 3, 30, 0, 0)), false, new Guid("df46d271-e654-4b45-a5ab-854e90d1711c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1148), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eff302e1-bb50-4f12-882d-db9f6bd8a7c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1154), new TimeSpan(0, 3, 30, 0, 0)), new Guid("394a1531-2523-4326-a204-04b587145ec8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1158), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1c01b035-21de-49bc-8b2c-f362dd2b8c70") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1163), new TimeSpan(0, 3, 30, 0, 0)), new Guid("faefefc8-f947-467c-a82e-618d24d3f209") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1168), new TimeSpan(0, 3, 30, 0, 0)), new Guid("37adffed-65ed-4025-8b5e-3cc9f6d6734e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(1172), new TimeSpan(0, 3, 30, 0, 0)), new Guid("440cb2c5-c0dd-4b47-b8f7-40c352af1f61") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(2839), new TimeSpan(0, 3, 30, 0, 0)), new Guid("43f8144f-8371-4a8a-bb25-7cd4232d8940") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(5309), new TimeSpan(0, 3, 30, 0, 0)), new Guid("06a9cbb0-6055-489e-a7d0-8f0d017d5063") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(5327), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2e77e0b9-6690-4c4e-b3d3-9af3501dfeaf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(5330), new TimeSpan(0, 3, 30, 0, 0)), new Guid("218d84f6-9821-4add-b8bc-ab7f3274af08") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(5333), new TimeSpan(0, 3, 30, 0, 0)), new Guid("875a6d89-783b-4d49-a51c-bea1b2759c9b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(5336), new TimeSpan(0, 3, 30, 0, 0)), new Guid("48ff11c8-9062-43fa-a62e-e19e21139121") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(5338), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ddf48ad7-ab78-4416-a6ba-60c7f15c7e4b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(6763), new TimeSpan(0, 3, 30, 0, 0)), new Guid("448940cf-e1b2-46a8-a451-5a4703dd3bcf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(7641), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b7ceaf9a-a8be-4eac-aa5b-a974bf8631b9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(8732), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5faf2ab5-5f4a-4f1b-8903-de85d35cb808") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 585, DateTimeKind.Unspecified).AddTicks(8897), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c975064f-eb3f-4815-b8fd-f87d17d2936b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(789), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3c44d21e-7102-4e92-980a-c678a3e6e5ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(1073), new TimeSpan(0, 3, 30, 0, 0)), new Guid("828c84b9-81d2-463f-9cc8-e61d27baaeec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(1077), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b464f278-0f53-45d4-a556-25f30539c961") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(1080), new TimeSpan(0, 3, 30, 0, 0)), new Guid("023cfae0-7563-46a5-a397-0404956eedbd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(1084), new TimeSpan(0, 3, 30, 0, 0)), new Guid("79333b7b-e21f-498d-87b0-3c94e19bb6c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(2499), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8843f06f-e244-4a8d-9e05-82b60bb2fc81") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(2510), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4fdfa96a-ccf8-45a3-85d4-ce5b19359727") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(2517), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7d971c83-fbfa-4153-b0d6-67299eabb2fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(2519), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2560fcbe-834b-44e3-b5d9-cee5dd4aed90") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(5337), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ba5c3147-4921-4146-a078-eaba7ed8dbdc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(5365), new TimeSpan(0, 3, 30, 0, 0)), new Guid("480a6b4c-ffb0-4788-8dd9-b88c15f74117") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(6860), new TimeSpan(0, 3, 30, 0, 0)), new Guid("46e682a3-dc30-4aeb-8782-250571d45929") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(6874), new TimeSpan(0, 3, 30, 0, 0)), new Guid("33b0e591-cc6a-4c08-b778-bf449a531b43") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(6877), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d432ec2f-d71f-49e8-b261-a86be215b0ba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 586, DateTimeKind.Unspecified).AddTicks(6879), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c179671a-0bd2-483e-9e6d-720a2ab74ddc") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Action",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(3499), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bd2d558e-f194-4ae9-be92-92c53b1d0e18") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Action",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(3715), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3ed0ffa0-80bd-4d1b-bdf6-65cdef504a41") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Action",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(3720), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4fb678aa-d3a0-4c66-a857-81fd107648d2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Action",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(3723), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b3921197-74f9-42bb-8dad-b7e8200779bd") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(6141), new TimeSpan(0, 3, 30, 0, 0)), new Guid("544ec3c6-0b88-4661-b9e3-234c85c77022") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(6606), new TimeSpan(0, 3, 30, 0, 0)), new Guid("455ebe78-9d95-489c-beea-2993f01872f4") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(6690), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5b60cc0f-d469-44bc-929d-ed8b727e048a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(6701), new TimeSpan(0, 3, 30, 0, 0)), new Guid("03b312e1-f779-49a9-abe5-4ffccb227f1a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(6705), new TimeSpan(0, 3, 30, 0, 0)), new Guid("08e29e7d-a5f8-433d-8d25-cc319d99d219") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(8095), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cf5ec95a-67c9-45bc-8a26-66a1230eefca") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(9296), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6da386c2-5698-4653-8a0a-8438c2f22b76") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(9546), new TimeSpan(0, 3, 30, 0, 0)), new Guid("97bd45e1-887d-4da2-8dde-8e8bea9c58be") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 581, DateTimeKind.Unspecified).AddTicks(3931), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c9bd59e3-cfea-4278-882b-cb98233bf49d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 581, DateTimeKind.Unspecified).AddTicks(9078), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c99a1044-8cb1-4083-a8a8-b9c7c830d89a") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 581, DateTimeKind.Unspecified).AddTicks(9104), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4dbd3885-8ea2-4b16-8b9e-00965bd33c8f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(393), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4aa54c27-f8de-45d7-bb08-42919ec6da3e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(401), new TimeSpan(0, 3, 30, 0, 0)), new Guid("79a96521-6657-48e5-96bd-6dfe170f0035") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(1318), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d5417d11-4cdf-41fd-931a-9ce24c14967e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 7, 13, 44, 29, 582, DateTimeKind.Unspecified).AddTicks(1331), new TimeSpan(0, 3, 30, 0, 0)), new Guid("73059df2-b2b9-4111-ad0d-6a12ad191d54") });
        }
    }
}
