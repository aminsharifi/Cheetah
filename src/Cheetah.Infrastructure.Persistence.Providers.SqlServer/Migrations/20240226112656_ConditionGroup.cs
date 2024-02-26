using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class ConditionGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "L_UserCondition",
                schema: "Links");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c2808b3c-31d0-47b4-b6c3-81c7b254cf83"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b867885f-ecc4-4e62-8887-95753c2e6085"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 163, DateTimeKind.Unspecified).AddTicks(6678), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 908, DateTimeKind.Unspecified).AddTicks(6634), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d635bd03-5997-472c-9552-79ccc0beb9c2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("eb9f015c-365f-41b1-8ea0-93b7298ed190"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 162, DateTimeKind.Unspecified).AddTicks(9715), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 908, DateTimeKind.Unspecified).AddTicks(2272), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ad81689d-f6fa-4277-bd09-27d20d7d598a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e9063c71-e94e-489d-8a60-2445f2c8103d"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 162, DateTimeKind.Unspecified).AddTicks(6099), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 908, DateTimeKind.Unspecified).AddTicks(65), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("269ce883-cf5f-4a46-8ef0-31b40e153f2e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("79e49fbb-59d1-4ad3-a508-7a3e27e13b50"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 162, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 907, DateTimeKind.Unspecified).AddTicks(6946), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("198e35ff-d678-4414-9ac2-a7219493cdd7"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("10b9ed0a-f300-4559-86c4-03aceeea1b33"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 162, DateTimeKind.Unspecified).AddTicks(247), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 907, DateTimeKind.Unspecified).AddTicks(3587), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e4f554f9-c1ae-41b3-9ac1-54c2623f87e8"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7bcf7a07-ce69-414d-ad8d-218d0df6e78b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 161, DateTimeKind.Unspecified).AddTicks(7902), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 907, DateTimeKind.Unspecified).AddTicks(1405), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("10d03726-1106-480d-9d69-2d78ede99e6d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("152e83d2-ece1-437f-a953-0f9e4ac0412f"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 161, DateTimeKind.Unspecified).AddTicks(4843), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(9254), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5e57322f-9ee7-4678-aee0-dd51dde90ce0"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("56efe08a-27ca-45b2-8bde-6c0e866a2b52"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(7052), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b1649def-1c11-44c7-92b6-30acd529e954"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("70761dfa-593d-4bbe-89ed-d970440015a7"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(6919), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(4703), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("dbf7652b-67ad-4b42-be69-69e10a32d7df"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("392aa8a4-d5bc-47ba-8ed3-3293f4162e0b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(4448), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(2636), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5885294f-277b-4963-8d2a-5ab6fbc4ee93"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("33c9cfc6-5d35-46a0-b41a-39c316e437af"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(2145), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(303), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("caa7527b-8526-48ee-b3b3-08294a41af31"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3047b26c-1e4b-4325-a399-f5ac73454c1f"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(8776), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a3ac1b6f-ef7b-408f-a44a-8f7b1a6a322d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("02d7f842-ceef-4c8e-b015-56ba4a2083bf"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 159, DateTimeKind.Unspecified).AddTicks(8078), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(7296), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("74859f67-59ba-4ea1-9ad9-b6e2e9680187"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c738ba93-bce7-4836-82da-8a9414a8d6a0"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 159, DateTimeKind.Unspecified).AddTicks(4132), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(5618), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("4f615fe7-ded7-455c-a3fc-73a88f49dbc6"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("42959372-009b-4478-81a5-f7eeb8acd59c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 159, DateTimeKind.Unspecified).AddTicks(2098), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(3714), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("65799da7-1a29-41f3-83b9-44b1443d66d5"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d5f34990-b71f-44a6-83c8-fc1117e69d77"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(9614), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(1671), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("cf0f4751-5ac5-46f7-aeea-679e80668052"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("6a60f59e-45a9-4f5f-9ea7-5f66cf6ffc0e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(8095), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(221), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("68c9e926-c697-47b6-af66-963f72b8a57e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a880bfd1-db0e-40bf-b0a4-56506e222049"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(5837), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(8793), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("763ffac4-3e14-46e9-8dda-bcc53a33378e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("aeeb6630-e372-45a1-914d-a10864244fd1"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(3653), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(7072), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ddaf00d5-a2ae-4719-a625-4dcc228b4b25"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("30b86211-62ad-4065-8040-4035bdacdaad"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(1633), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(5251), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3d92e17d-8d2d-4432-a28e-169f3c497d33"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8efe853d-028b-46b9-b538-277f7d3d973d"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(9293), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(3727), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("fb4ccb53-7044-4620-a660-23192328414d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9d38f106-b853-4e72-b43a-9cb1c83f59c8"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(7530), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(2155), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3b0c3a69-c494-47e7-8549-da338e3ff407"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b15e5845-4545-4b1a-9219-a8711d1bef86"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(5748), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(689), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("42032e3c-c2fb-443a-9dfa-879085d930fd"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ce44efb3-1d84-4118-a604-6bd2dd6aba19"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(4210), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 903, DateTimeKind.Unspecified).AddTicks(9233), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7a5c487e-1f71-4ac2-a7a8-938c766bbc55"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3416c88e-c6f7-482c-a2a2-e469d1d10c28"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(2141), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 903, DateTimeKind.Unspecified).AddTicks(7551), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.CreateTable(
                name: "F_ConditionGroup",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 159, DateTimeKind.Unspecified).AddTicks(6425), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("56f0d25a-5211-4c8c-b0d9-42c2338a0d51")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_ConditionGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "L_ConditionGroupCondition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 161, DateTimeKind.Unspecified).AddTicks(2158), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("783811ed-3e93-46ca-a8b4-edbcc6748e7e")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
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
                    table.PrimaryKey("PK_L_ConditionGroupCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_ConditionGroupCondition_F_ConditionGroup_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_ConditionGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_ConditionGroupCondition_F_Condition_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_UserConditionGroup",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 163, DateTimeKind.Unspecified).AddTicks(3173), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("115e5da5-3b83-4c48-9449-ed67b82f311c")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
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
                    table.PrimaryKey("PK_L_UserConditionGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserConditionGroup_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_UserConditionGroup_F_ConditionGroup_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_ConditionGroup",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 785, DateTimeKind.Unspecified).AddTicks(792), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a8abd22e-6255-4d56-b27f-1a0090645a08") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 785, DateTimeKind.Unspecified).AddTicks(806), new TimeSpan(0, 3, 30, 0, 0)), new Guid("403dc90b-2f98-4878-8c47-470a46b6ff37") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 785, DateTimeKind.Unspecified).AddTicks(816), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eb7bf519-7eb7-4bed-ba34-8949933e9620") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 785, DateTimeKind.Unspecified).AddTicks(819), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c6de1e2b-2718-4e48-90ee-cdaad7b8416d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 785, DateTimeKind.Unspecified).AddTicks(821), new TimeSpan(0, 3, 30, 0, 0)), new Guid("624ecaf0-a357-4d8c-bd7d-a22bfefa4b39") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 785, DateTimeKind.Unspecified).AddTicks(824), new TimeSpan(0, 3, 30, 0, 0)), new Guid("32252c51-6ae0-4309-bcfe-d003c2d9785c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 786, DateTimeKind.Unspecified).AddTicks(1073), new TimeSpan(0, 3, 30, 0, 0)), new Guid("067684fa-8eb2-4bbb-a328-3cb4ccf996f0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(714), new TimeSpan(0, 3, 30, 0, 0)), new Guid("77b52fb2-a166-4aef-b14f-e9ebd881e6b2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(749), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b290454c-0662-43c7-b2eb-7103af9bae8d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(755), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b881ebec-c7d4-4c33-b3f6-94e21e3a26aa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(761), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8bcaccf4-17eb-4bd4-bcfe-f7305bbab253") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(777), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e62f132f-fa7d-45a8-a27b-481e4d21cd35") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(783), new TimeSpan(0, 3, 30, 0, 0)), new Guid("359087e6-cf3c-400c-ad23-af7d202c44b2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(824), new TimeSpan(0, 3, 30, 0, 0)), new Guid("67af549d-02dc-41c9-8274-6bd1c52c8711") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(830), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1ab65304-1c0c-445a-a91e-012c69610cac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(837), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e8bd94ea-7224-4b2f-bc91-aaae544cc593") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(842), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0a0637c9-4ed5-43a3-abd3-f5a849a6399a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(847), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bf96bbda-ca31-4200-a464-887af3eb5c87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(851), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9eba76f3-7de3-4f90-99de-94905e3d2d30") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(855), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7ef51cb-552e-4317-87d4-efcf52cdf2e2") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "Created", "CreatedBy", "Display", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[] { 115L, new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(860), new TimeSpan(0, 3, 30, 0, 0)), null, true, "گروه شرط‌ها(Facts)", 115L, true, new Guid("e20592e9-7b23-4da8-ae57-b795c9ed17d0"), null, null, "F_ConditionGroup", 115L });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(3159), new TimeSpan(0, 3, 30, 0, 0)), new Guid("052721d0-470b-411c-ae95-d7e8c0116c10") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(3167), new TimeSpan(0, 3, 30, 0, 0)), new Guid("611f18de-1516-4a62-9953-8c9f52f8701f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(3173), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1290c4de-2673-4bb1-98c6-a8b42ac216de") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(3175), new TimeSpan(0, 3, 30, 0, 0)), new Guid("91c278ec-4f84-49c9-b4ef-b803920f3a3d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(3177), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0cbee099-e612-48e6-a0e8-8b7da08b2773") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(3180), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f045b31a-d42b-4851-be4e-10af25df3a81") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(4117), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1569786c-2be1-42a6-8afd-f5a6119e6fc6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(7255), new TimeSpan(0, 3, 30, 0, 0)), new Guid("145cc7e0-b089-438b-b097-0b7e2f031f53") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8865), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bcc6b4b0-5293-4c1d-9272-466a7ca724d2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8869), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c18075f8-1c7e-429c-9ed1-896357e20f45") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8872), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dca00ebd-1da4-44ad-8c0e-fa04c17e4a92") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8875), new TimeSpan(0, 3, 30, 0, 0)), new Guid("029feef7-7efb-4171-977c-418936d8c3d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8878), new TimeSpan(0, 3, 30, 0, 0)), new Guid("703488ef-5c1b-437f-9244-5713b437bdd0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8881), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4c48a157-eec9-43c6-be1b-eb93751713fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8886), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ca87e766-2dab-43d0-8811-1605a55e9290") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8355), new TimeSpan(0, 3, 30, 0, 0)), new Guid("085f5e46-f4da-4e81-b87e-660e8424d2b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8360), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9d145f6d-c932-4787-85c7-ec3e09352e25") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8366), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e1332f21-bbc1-42bb-a708-16fac977be3e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 787, DateTimeKind.Unspecified).AddTicks(8368), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c776a1bd-bbed-41d4-a4d7-f389a20d5e12") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 788, DateTimeKind.Unspecified).AddTicks(1679), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0536b3d6-f1b9-4810-8013-2954bd18c731") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 788, DateTimeKind.Unspecified).AddTicks(1706), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a8772ab6-c3b1-4c6c-917a-9e802d9de1db") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 788, DateTimeKind.Unspecified).AddTicks(3061), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b945677a-8245-4f98-8d46-51b1e97600d1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 788, DateTimeKind.Unspecified).AddTicks(3067), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6907ec18-377f-41db-944f-2544dd2d7122") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 788, DateTimeKind.Unspecified).AddTicks(3070), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5f2f23b5-a1a7-4a46-a7d3-ce614e1b2c3c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 788, DateTimeKind.Unspecified).AddTicks(3072), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f6c554d5-e5c8-4692-9ca3-4852dd3db47b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 784, DateTimeKind.Unspecified).AddTicks(6954), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1be3a2d9-1894-47e4-8608-640edda560ed") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 784, DateTimeKind.Unspecified).AddTicks(8703), new TimeSpan(0, 3, 30, 0, 0)), new Guid("58357bcd-dc0a-4c0e-9c22-c7147b230008") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 784, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0206d1b9-3123-4c86-ba63-68ead46702df") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 55, 784, DateTimeKind.Unspecified).AddTicks(1397), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eced882e-db85-453e-a544-ab95e65abdea") });

            migrationBuilder.CreateIndex(
                name: "IX_F_ConditionGroup_Created",
                schema: "Facts",
                table: "F_ConditionGroup",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ConditionGroup_EnableRecord",
                schema: "Facts",
                table: "F_ConditionGroup",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ConditionGroup_ERPCode",
                schema: "Facts",
                table: "F_ConditionGroup",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ConditionGroup_LastModified",
                schema: "Facts",
                table: "F_ConditionGroup",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_ConditionGroup_Name",
                schema: "Facts",
                table: "F_ConditionGroup",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_Created",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_EnableRecord",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_ERPCode",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_FifthId",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_FirstId",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_FourthId",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_LastModified",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_Name",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_SecondId",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ConditionGroupCondition_ThirdId",
                schema: "Links",
                table: "L_ConditionGroupCondition",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_Created",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_EnableRecord",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_ERPCode",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_FifthId",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_FirstId",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_FourthId",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_LastModified",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_Name",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_SecondId",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserConditionGroup_ThirdId",
                schema: "Links",
                table: "L_UserConditionGroup",
                column: "ThirdId",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "L_ConditionGroupCondition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_UserConditionGroup",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "F_ConditionGroup",
                schema: "Facts");

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b867885f-ecc4-4e62-8887-95753c2e6085"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c2808b3c-31d0-47b4-b6c3-81c7b254cf83"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 908, DateTimeKind.Unspecified).AddTicks(6634), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 163, DateTimeKind.Unspecified).AddTicks(6678), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("eb9f015c-365f-41b1-8ea0-93b7298ed190"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d635bd03-5997-472c-9552-79ccc0beb9c2"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskFlow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 908, DateTimeKind.Unspecified).AddTicks(2272), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 162, DateTimeKind.Unspecified).AddTicks(9715), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e9063c71-e94e-489d-8a60-2445f2c8103d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ad81689d-f6fa-4277-bd09-27d20d7d598a"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_TaskCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 908, DateTimeKind.Unspecified).AddTicks(65), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 162, DateTimeKind.Unspecified).AddTicks(6099), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("79e49fbb-59d1-4ad3-a508-7a3e27e13b50"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("269ce883-cf5f-4a46-8ef0-31b40e153f2e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 907, DateTimeKind.Unspecified).AddTicks(6946), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 162, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("10b9ed0a-f300-4559-86c4-03aceeea1b33"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("198e35ff-d678-4414-9ac2-a7219493cdd7"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 907, DateTimeKind.Unspecified).AddTicks(3587), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 162, DateTimeKind.Unspecified).AddTicks(247), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7bcf7a07-ce69-414d-ad8d-218d0df6e78b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e4f554f9-c1ae-41b3-9ac1-54c2623f87e8"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowTask",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 907, DateTimeKind.Unspecified).AddTicks(1405), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 161, DateTimeKind.Unspecified).AddTicks(7902), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("152e83d2-ece1-437f-a953-0f9e4ac0412f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("10d03726-1106-480d-9d69-2d78ede99e6d"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_FlowCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(9254), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 161, DateTimeKind.Unspecified).AddTicks(4843), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("56efe08a-27ca-45b2-8bde-6c0e866a2b52"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5e57322f-9ee7-4678-aee0-dd51dde90ce0"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(7052), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("70761dfa-593d-4bbe-89ed-d970440015a7"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b1649def-1c11-44c7-92b6-30acd529e954"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseCondition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(4703), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(6919), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("392aa8a4-d5bc-47ba-8ed3-3293f4162e0b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("dbf7652b-67ad-4b42-be69-69e10a32d7df"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(2636), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(4448), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Task",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("33c9cfc6-5d35-46a0-b41a-39c316e437af"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5885294f-277b-4963-8d2a-5ab6fbc4ee93"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Task",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 906, DateTimeKind.Unspecified).AddTicks(303), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(2145), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3047b26c-1e4b-4325-a399-f5ac73454c1f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("caa7527b-8526-48ee-b3b3-08294a41af31"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(8776), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 160, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("02d7f842-ceef-4c8e-b015-56ba4a2083bf"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a3ac1b6f-ef7b-408f-a44a-8f7b1a6a322d"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Flow",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(7296), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 159, DateTimeKind.Unspecified).AddTicks(8078), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c738ba93-bce7-4836-82da-8a9414a8d6a0"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("74859f67-59ba-4ea1-9ad9-b6e2e9680187"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(5618), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 159, DateTimeKind.Unspecified).AddTicks(4132), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("42959372-009b-4478-81a5-f7eeb8acd59c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("4f615fe7-ded7-455c-a3fc-73a88f49dbc6"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(3714), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 159, DateTimeKind.Unspecified).AddTicks(2098), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d5f34990-b71f-44a6-83c8-fc1117e69d77"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("65799da7-1a29-41f3-83b9-44b1443d66d5"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(1671), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(9614), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("6a60f59e-45a9-4f5f-9ea7-5f66cf6ffc0e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("cf0f4751-5ac5-46f7-aeea-679e80668052"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 905, DateTimeKind.Unspecified).AddTicks(221), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(8095), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a880bfd1-db0e-40bf-b0a4-56506e222049"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("68c9e926-c697-47b6-af66-963f72b8a57e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(8793), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(5837), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("aeeb6630-e372-45a1-914d-a10864244fd1"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("763ffac4-3e14-46e9-8dda-bcc53a33378e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(7072), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(3653), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("30b86211-62ad-4065-8040-4035bdacdaad"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ddaf00d5-a2ae-4719-a625-4dcc228b4b25"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(5251), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 158, DateTimeKind.Unspecified).AddTicks(1633), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8efe853d-028b-46b9-b538-277f7d3d973d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3d92e17d-8d2d-4432-a28e-169f3c497d33"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(3727), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(9293), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9d38f106-b853-4e72-b43a-9cb1c83f59c8"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("fb4ccb53-7044-4620-a660-23192328414d"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(2155), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(7530), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b15e5845-4545-4b1a-9219-a8711d1bef86"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3b0c3a69-c494-47e7-8549-da338e3ff407"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 904, DateTimeKind.Unspecified).AddTicks(689), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(5748), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ce44efb3-1d84-4118-a604-6bd2dd6aba19"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("42032e3c-c2fb-443a-9dfa-879085d930fd"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 903, DateTimeKind.Unspecified).AddTicks(9233), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(4210), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3416c88e-c6f7-482c-a2a2-e469d1d10c28"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7a5c487e-1f71-4ac2-a7a8-938c766bbc55"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 903, DateTimeKind.Unspecified).AddTicks(7551), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 2, 26, 14, 56, 56, 157, DateTimeKind.Unspecified).AddTicks(2141), new TimeSpan(0, 3, 30, 0, 0)));

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
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 908, DateTimeKind.Unspecified).AddTicks(4445), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("40e7eac0-7021-4117-b4bc-760e3b6ef4e7")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
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
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(2097), new TimeSpan(0, 3, 30, 0, 0)), new Guid("846a9619-613c-47c9-b25b-eb7be56a2962") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(2102), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c78edfef-d62e-41e8-8b54-a7135e7d94a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(2105), new TimeSpan(0, 3, 30, 0, 0)), new Guid("96f5111d-c7ab-4870-beda-a6090688f2d4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(2115), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0d1c119d-1dc7-4d72-be23-b9f2ad444cf2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(2118), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b4806a3a-2399-468c-b09c-ea2fb928498b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(2120), new TimeSpan(0, 3, 30, 0, 0)), new Guid("955bbfa4-726f-416f-93cd-d2a0d6cd8e5e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(9400), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a992407-8c19-4730-9c79-acf9c408b128") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9164), new TimeSpan(0, 3, 30, 0, 0)), new Guid("00dbe9cc-e07b-43f2-ac61-3c9f6da19775") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9202), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1a68274a-3cbe-406f-bf1e-f5d3f71db8a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9209), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fd0fb31a-9c9c-4b58-b61a-ba247b676bb3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9216), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ed17b4a8-d2c6-49ce-a6db-f981d0cf9c14") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9227), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1f045466-aca8-4ad6-88fe-527bf9363833") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9233), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7b805ab7-ad79-41e7-9e48-90bdf6a8a424") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9238), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8f203a8c-bdb6-468b-9fe0-63ad7bfc4a7e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9244), new TimeSpan(0, 3, 30, 0, 0)), new Guid("306660b1-b3a4-447c-b84c-f88b2733fef2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9248), new TimeSpan(0, 3, 30, 0, 0)), new Guid("207e037f-ef44-4467-ad16-5448aa2d9c4d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9254), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6b271e87-704f-4707-aed2-7ed3cc4eb7ba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9258), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b4ae36a2-26db-416c-a45f-8c3c55d9eb5a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9263), new TimeSpan(0, 3, 30, 0, 0)), new Guid("93828b85-af29-437a-a3c0-61c6f6e11f30") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 482, DateTimeKind.Unspecified).AddTicks(9268), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0085e6bc-79fb-4ee3-9899-acf77336484a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(1474), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fed69ebc-8203-4971-a98a-f9a27ef8333a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(1482), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d3c394a8-6c46-4e82-a019-84fd480e4561") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(1485), new TimeSpan(0, 3, 30, 0, 0)), new Guid("746a3528-8064-46f4-8232-7ee223140b6d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(1488), new TimeSpan(0, 3, 30, 0, 0)), new Guid("55ccb56d-3faf-435e-bcd1-7bbcd473d75d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(1490), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9d0227c6-d6e8-4069-ac2b-69fa49d7ef5f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(1493), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e89e46b3-5234-4531-aea8-0c51142d5a95") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(2438), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9d952c78-aee1-457e-8942-3fae74c7b683") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(5614), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a1dd6f7d-8da4-414e-ae3a-4174d1b354cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(7445), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1c61d411-129e-4188-8e7a-8e4b0638ce64") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(7450), new TimeSpan(0, 3, 30, 0, 0)), new Guid("423efe56-4f73-49d7-a8d1-a8ce82d8bf7c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(7453), new TimeSpan(0, 3, 30, 0, 0)), new Guid("31f9def6-2cf8-4f64-9462-40645edcb64d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(7458), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bd3f39b9-142f-41ee-85ee-05c11d880dbc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(7461), new TimeSpan(0, 3, 30, 0, 0)), new Guid("544265e7-07c4-492b-8fc0-4c1701df06c8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(7464), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a5e2718-5a21-41a9-ad2b-46eec9357c32") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(7467), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7731186e-760d-46ba-9e4d-efe7cb72dd3e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a3c2342d-ad53-4851-b114-06d46002782f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(6822), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0133bd33-536e-4d51-bf03-3e6f9d3353f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(6872), new TimeSpan(0, 3, 30, 0, 0)), new Guid("acaa5841-bbe3-49c1-93e5-8785226cf5f3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 483, DateTimeKind.Unspecified).AddTicks(6875), new TimeSpan(0, 3, 30, 0, 0)), new Guid("263e43a2-6984-4b24-8fa8-edce01ce45b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 484, DateTimeKind.Unspecified).AddTicks(307), new TimeSpan(0, 3, 30, 0, 0)), new Guid("82d6aeb1-47b1-4702-a302-5f8b85fac49d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 484, DateTimeKind.Unspecified).AddTicks(332), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4aa7bb5f-3e0d-4a6b-badd-8dffe4241cf6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 484, DateTimeKind.Unspecified).AddTicks(1709), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e6cb8774-973b-43b3-af0c-10c2502f9a8d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 484, DateTimeKind.Unspecified).AddTicks(1771), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9aae0277-fa98-4a8a-8d35-0fc3512de336") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 484, DateTimeKind.Unspecified).AddTicks(1778), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3d1afa53-4b09-4466-a0d9-ee6930dd745e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 484, DateTimeKind.Unspecified).AddTicks(1781), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fa7abb27-0cee-473a-887f-b1b7fbb3eb50") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 480, DateTimeKind.Unspecified).AddTicks(8318), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3eebcebc-427a-4569-b5e1-2a6c4e29c37b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(120), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ac786ab9-6ab8-40ad-b51d-88ad752934c7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 481, DateTimeKind.Unspecified).AddTicks(329), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c0e9dbc3-21c5-407c-b143-fccad4a97318") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 19, 14, 59, 29, 480, DateTimeKind.Unspecified).AddTicks(2707), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1d0abc78-dbb6-4692-a7e0-b86d09936fcc") });

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
    }
}
