using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Change_LastModified_OnUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_UserPosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 783, DateTimeKind.Unspecified).AddTicks(1377), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 937, DateTimeKind.Unspecified).AddTicks(4364), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserPosition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("6a7478b7-86e5-4d45-bdeb-14832b5b2ef7"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3b9d8c5b-ca2b-4412-b4b4-6d3c6eedd8f2"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserPosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 783, DateTimeKind.Unspecified).AddTicks(1148), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 937, DateTimeKind.Unspecified).AddTicks(4141), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_UserLocation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(8689), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 937, DateTimeKind.Unspecified).AddTicks(1779), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserLocation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("aaad5667-2df3-44fa-8438-fa68f0dddd72"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("34c0a2ea-1327-4988-85e9-2769f1afe8d5"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserLocation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(8481), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 937, DateTimeKind.Unspecified).AddTicks(1096), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_RolePosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(6252), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(8827), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_RolePosition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("dcdd7afe-ea01-4535-a963-c4b73b66defb"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("078a8c60-9b1d-4393-8df3-ac2b290173ab"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_RolePosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(6040), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(8604), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(3790), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(5684), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c46c4fd5-2b1e-4b8e-8ec4-e7afee4b1505"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("95bb99dc-3477-4d61-8731-20c05237741a"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(3578), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(5459), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(1292), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(2540), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f0f5b263-f3f7-4beb-8b57-da49d1aba7bb"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c92d0e8a-3186-4fea-9f13-00b062c28f25"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(1086), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(2316), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(8577), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(3), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("92528f94-1583-4dd7-bd2b-a4af8a26fd2a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3382c08d-e7f6-4c23-9886-293f66792592"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(9222), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(5821), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(6744), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8b00006e-8eba-4260-af64-b31b23502ef8"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("603b6e0b-902f-429d-a6ca-c1d6363df6a5"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(5555), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(6506), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(2849), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(3332), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("fdd48e37-fdaa-4239-9372-fa121566d52f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8ffd2ed3-c180-4dac-acdf-6648f871fc66"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(2688), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(3186), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(568), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(608), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c5a7a207-22cf-41eb-b7c2-b888bf43cbdc"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8e3e1344-bc34-414a-a710-13e67b623886"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(354), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(413), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Endorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(7794), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 934, DateTimeKind.Unspecified).AddTicks(7350), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Endorsement",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("85ca9bb4-215f-41f6-9fa3-97e641e8aa5b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("39f7a327-55dc-47a7-93e4-263349016877"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Endorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(7537), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 934, DateTimeKind.Unspecified).AddTicks(7129), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(4533), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 934, DateTimeKind.Unspecified).AddTicks(4238), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("79d3adc5-183c-45e8-a5bd-86ff8670b6e6"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c4c238b5-08e8-4119-8ce3-545bef8e6efc"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(4270), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 934, DateTimeKind.Unspecified).AddTicks(3314), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(1105), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 934, DateTimeKind.Unspecified).AddTicks(211), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8b6ee948-6355-4ed8-98d8-0213e021bf34"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("dcaca89a-3e19-43f2-9dd2-65a28f0172a0"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(856), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 933, DateTimeKind.Unspecified).AddTicks(9310), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(8225), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 933, DateTimeKind.Unspecified).AddTicks(6788), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e03ca010-4994-490b-b716-fc0bd7a8bd8e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1b788d6c-b2fb-4b90-8733-a96e59e560c6"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(8034), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 933, DateTimeKind.Unspecified).AddTicks(6591), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(6133), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(6143), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("21e674f3-6851-4597-bb52-7b4a8c6ad33b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("aaa90c59-b184-4777-bdbd-a1d660eb5fde"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(5972), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(5948), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(4082), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(2083), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7ea2631a-f81b-4424-8085-0f694257bab8"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("95d44cfa-9e8e-4347-920f-3a612d784227"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(3920), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(1971), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(1777), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(336), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("71414064-cb30-4db9-80b3-3f6d5a09ff5f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("da5d262f-e155-4c1b-abf2-0b568f7b15a7"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(1540), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(180), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(9024), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(8377), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5cc2ace9-5016-4cd6-8f52-f076cc5c3689"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d9f0b267-edbf-4842-8aa5-29b54af80741"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(8843), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(8259), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(6757), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("72d9b1ab-fe19-4fc4-ad1e-fe8c41ab86e3"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9ede2b65-043f-47e7-85e1-808e5503cbad"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(6727), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(6631), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(4510), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(5085), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("dfc0cfe9-fe85-4870-b503-843842766ba7"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("0fc224a9-2e3c-4784-b5d2-0a9fbbad8eba"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(4962), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(1426), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(3532), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b12e3df2-1816-4d2f-9fc3-9b4850739b3c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3ae783c5-fd58-40cb-bf81-e22077edc5b2"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(1295), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(3370), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(9794), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(1949), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7724f097-8327-4b13-8577-22cfcc03248f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("433b0bb2-e683-40a1-91b4-fc62e9eaf051"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(9635), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(1813), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(7517), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(339), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e439adbf-496b-42d3-9d97-6d4ec308e6e6"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("94c990e4-4381-4c50-abdc-6abb6b600a8f"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(7347), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(224), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(4951), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("aa12e9ac-2df5-4353-b7f4-e12d6ba6bfb7"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("fa2d50f5-7c6a-4c95-adf6-28f0282d3f4d"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(4664), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(8554), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(2627), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(6964), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d26defcd-4370-4bd6-9d08-cce0a01c7bb8"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5a951242-95c3-4f9c-a021-acef78c3a582"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(2450), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(6838), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(294), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(5254), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("6c184879-5922-4595-acbf-680c98d6344d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a349e660-f60f-4c9c-b0a5-383eba81b209"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(71), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(5061), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 388, DateTimeKind.Unspecified).AddTicks(6288), new TimeSpan(0, -8, 0, 0, 0)), new Guid("1c214f11-05f6-4b77-8919-2abbb0516603") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 388, DateTimeKind.Unspecified).AddTicks(6296), new TimeSpan(0, -8, 0, 0, 0)), new Guid("06e4c0d1-22b7-4990-b530-9ddc903727b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 388, DateTimeKind.Unspecified).AddTicks(6304), new TimeSpan(0, -8, 0, 0, 0)), new Guid("7987177a-ab7b-4c1e-ba63-908a4eafdf9f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 388, DateTimeKind.Unspecified).AddTicks(6307), new TimeSpan(0, -8, 0, 0, 0)), new Guid("baf14f61-43df-42a8-9cb9-27134cfdfcf9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 388, DateTimeKind.Unspecified).AddTicks(6309), new TimeSpan(0, -8, 0, 0, 0)), new Guid("c851a755-38c7-4b2f-8bf6-230812da462b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 389, DateTimeKind.Unspecified).AddTicks(6952), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ca4f9bd8-f629-4d16-831f-e39a887bed1f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7602), new TimeSpan(0, -8, 0, 0, 0)), new Guid("2797373c-22dd-4ccd-9fe5-a2aa30011cfb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, -8, 0, 0, 0)), new Guid("72ecb41f-e2a9-4943-8432-e40769c619b2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7677), new TimeSpan(0, -8, 0, 0, 0)), new Guid("801b57d0-4387-47da-8285-71fae53bab0e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7684), new TimeSpan(0, -8, 0, 0, 0)), new Guid("47aabec0-81bb-4a59-ba21-b32929e99479") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7734), new TimeSpan(0, -8, 0, 0, 0)), new Guid("91081d3b-5dc2-495d-b2f1-bc631c3d6f3b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7774), new TimeSpan(0, -8, 0, 0, 0)), new Guid("44980df4-ea9e-49cb-a72e-d31001d91091") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7795), new TimeSpan(0, -8, 0, 0, 0)), new Guid("cb021838-b7c7-4d61-aaf9-3efce5305370") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7803), new TimeSpan(0, -8, 0, 0, 0)), new Guid("cced6cb9-46d9-4c20-b4c1-c32cfc1e9d8c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7809), new TimeSpan(0, -8, 0, 0, 0)), new Guid("7bdb5f8f-d82a-4026-a2ec-8c01fb0d7662") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7816), new TimeSpan(0, -8, 0, 0, 0)), new Guid("5c308715-7c35-483d-afec-d2c5c479a633") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7823), new TimeSpan(0, -8, 0, 0, 0)), new Guid("149e221f-3c08-44f3-9175-af42f392c865") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, -8, 0, 0, 0)), new Guid("5c13bb5a-36ae-44e4-adb5-6e95ae5af725") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7847), new TimeSpan(0, -8, 0, 0, 0)), new Guid("14c83c8f-cfb9-4f60-9bc9-9ee4ca255b2b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7855), new TimeSpan(0, -8, 0, 0, 0)), new Guid("5b960b18-d71e-4a86-bed6-c65c15227b9c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7862), new TimeSpan(0, -8, 0, 0, 0)), new Guid("3bb5e4ad-1fcf-4c52-aacf-ed83b0541f85") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7868), new TimeSpan(0, -8, 0, 0, 0)), new Guid("b5ad8740-bf61-4c8c-9d81-fbe122eb4118") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7874), new TimeSpan(0, -8, 0, 0, 0)), new Guid("baa94831-2b5e-48c0-82cb-80dba0d71c7a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7880), new TimeSpan(0, -8, 0, 0, 0)), new Guid("fb94e016-97f5-4bc4-9801-6f10182473a7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(7887), new TimeSpan(0, -8, 0, 0, 0)), new Guid("77e17995-ca3d-44e0-bb1c-f5a2337c21ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 390, DateTimeKind.Unspecified).AddTicks(9689), new TimeSpan(0, -8, 0, 0, 0)), new Guid("364d9754-772e-4740-8d0f-5797935ea56c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(1570), new TimeSpan(0, -8, 0, 0, 0)), new Guid("f804418b-62db-4690-9c2f-4bfd0fac1d2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(1579), new TimeSpan(0, -8, 0, 0, 0)), new Guid("fc4e964f-85bb-4271-8dd4-16e515462651") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(1587), new TimeSpan(0, -8, 0, 0, 0)), new Guid("d035b429-562c-47b8-86ed-6504e7284153") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(1591), new TimeSpan(0, -8, 0, 0, 0)), new Guid("947b283e-1a7e-4d95-abaf-1ee3034773fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(1594), new TimeSpan(0, -8, 0, 0, 0)), new Guid("5d0f0900-e701-47f3-9a7b-1e8e138c1df6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(1596), new TimeSpan(0, -8, 0, 0, 0)), new Guid("a32938a5-fedb-4394-a24d-7d5383047c13") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(2948), new TimeSpan(0, -8, 0, 0, 0)), new Guid("eb36cd6a-49c6-467c-8bd6-e7dcd1be0110") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, -8, 0, 0, 0)), new Guid("3fd6e386-37fc-4d76-b69f-730593cf6abb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(4753), new TimeSpan(0, -8, 0, 0, 0)), new Guid("b58356c0-fe62-41ff-bc52-82efcef403b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(4897), new TimeSpan(0, -8, 0, 0, 0)), new Guid("a23ab70e-3484-4c96-b4cd-3555e3aa3b1b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(6684), new TimeSpan(0, -8, 0, 0, 0)), new Guid("433c506c-df92-4874-8f02-3fbf835a89ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(7013), new TimeSpan(0, -8, 0, 0, 0)), new Guid("21a31812-5f55-484e-a309-a714b2e174c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(7018), new TimeSpan(0, -8, 0, 0, 0)), new Guid("069cdd46-c61c-4aee-bdf7-835e07275962") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(7021), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ff0c3539-d707-4539-9284-b831e1d25526") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(7025), new TimeSpan(0, -8, 0, 0, 0)), new Guid("113318d5-c46e-43a7-a4f0-214982d61a21") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(8231), new TimeSpan(0, -8, 0, 0, 0)), new Guid("b1a9a19c-a33a-4556-b073-509358e646b7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(8238), new TimeSpan(0, -8, 0, 0, 0)), new Guid("e4ce047d-c865-43fa-b23d-91eb943d6b5e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(8241), new TimeSpan(0, -8, 0, 0, 0)), new Guid("e0fb6a0b-d7f0-4cc2-892c-314a7ed8b42c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 391, DateTimeKind.Unspecified).AddTicks(8247), new TimeSpan(0, -8, 0, 0, 0)), new Guid("4ea6bffc-09e1-4768-a23e-dd12459b67c8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 392, DateTimeKind.Unspecified).AddTicks(848), new TimeSpan(0, -8, 0, 0, 0)), new Guid("7157b501-3659-443e-9d7e-5aa750cb2a97") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 392, DateTimeKind.Unspecified).AddTicks(876), new TimeSpan(0, -8, 0, 0, 0)), new Guid("e4fc524f-4649-4955-8b4f-daa710a8b0ed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 392, DateTimeKind.Unspecified).AddTicks(2427), new TimeSpan(0, -8, 0, 0, 0)), new Guid("f58f835f-97e8-4cc4-a635-acb1c0b7813c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 392, DateTimeKind.Unspecified).AddTicks(2435), new TimeSpan(0, -8, 0, 0, 0)), new Guid("da6df4e7-24bd-4aa6-b664-3b67bceb1227") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 392, DateTimeKind.Unspecified).AddTicks(2438), new TimeSpan(0, -8, 0, 0, 0)), new Guid("609178e2-2da6-4d45-9515-13b6f0421e24") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 392, DateTimeKind.Unspecified).AddTicks(2441), new TimeSpan(0, -8, 0, 0, 0)), new Guid("b3ad9422-fba7-45fe-83b5-5aafa9f9a44c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 387, DateTimeKind.Unspecified).AddTicks(8082), new TimeSpan(0, -8, 0, 0, 0)), new Guid("85c8603a-a6b3-4530-98d1-39f55c5b3929") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 387, DateTimeKind.Unspecified).AddTicks(8870), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ac38cc49-628b-4b1d-913a-a900fa8f4300") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 387, DateTimeKind.Unspecified).AddTicks(8953), new TimeSpan(0, -8, 0, 0, 0)), new Guid("105d375e-4a29-43d5-9010-7102258a7efe") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 387, DateTimeKind.Unspecified).AddTicks(8957), new TimeSpan(0, -8, 0, 0, 0)), new Guid("850da692-765d-4659-8665-aea691010584") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 387, DateTimeKind.Unspecified).AddTicks(8961), new TimeSpan(0, -8, 0, 0, 0)), new Guid("832c13eb-1df7-4af0-ba98-6c261cda456b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 388, DateTimeKind.Unspecified).AddTicks(796), new TimeSpan(0, -8, 0, 0, 0)), new Guid("9effa680-e00c-483a-8a1e-c1871564591f") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 388, DateTimeKind.Unspecified).AddTicks(1025), new TimeSpan(0, -8, 0, 0, 0)), new Guid("3d02b9cb-2ca1-429b-b294-c2c26235e17b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 388, DateTimeKind.Unspecified).AddTicks(3178), new TimeSpan(0, -8, 0, 0, 0)), new Guid("49695703-8de5-43f4-9df8-14189d9b4cd7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 388, DateTimeKind.Unspecified).AddTicks(3389), new TimeSpan(0, -8, 0, 0, 0)), new Guid("f2b7222b-da0e-4d29-af6f-179dcd17d60c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 388, DateTimeKind.Unspecified).AddTicks(3395), new TimeSpan(0, -8, 0, 0, 0)), new Guid("72b773b7-2b97-467f-bf7a-14792e4b8585") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 388, DateTimeKind.Unspecified).AddTicks(3399), new TimeSpan(0, -8, 0, 0, 0)), new Guid("e6639fc2-2a76-4685-b822-cd829bc06285") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 388, DateTimeKind.Unspecified).AddTicks(4704), new TimeSpan(0, -8, 0, 0, 0)), new Guid("9f6cf182-942f-4073-9c22-e1e15d124ac7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 386, DateTimeKind.Unspecified).AddTicks(8290), new TimeSpan(0, -8, 0, 0, 0)), new Guid("401cdcd7-5378-4ec6-ab76-531453b58197") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 386, DateTimeKind.Unspecified).AddTicks(9045), new TimeSpan(0, -8, 0, 0, 0)), new Guid("18c8d2a7-b197-46fd-8243-4e8dc57d7999") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 387, DateTimeKind.Unspecified).AddTicks(2623), new TimeSpan(0, -8, 0, 0, 0)), new Guid("e7a72bfa-c2d8-459e-9ef4-918ce5a586cd") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 387, DateTimeKind.Unspecified).AddTicks(3864), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ddb3df30-871b-48d7-a7a3-1377e7d26332") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 387, DateTimeKind.Unspecified).AddTicks(3876), new TimeSpan(0, -8, 0, 0, 0)), new Guid("16ec903e-ccd1-4606-818d-c657c797e0ad") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 387, DateTimeKind.Unspecified).AddTicks(4813), new TimeSpan(0, -8, 0, 0, 0)), new Guid("bb2edd7f-19b2-4ca0-83d2-4c0ba5f0a6f6") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 387, DateTimeKind.Unspecified).AddTicks(4821), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ec0b3100-d079-44dc-84cf-acae56317aad") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 387, DateTimeKind.Unspecified).AddTicks(5687), new TimeSpan(0, -8, 0, 0, 0)), new Guid("06f1bce6-0183-49d1-94a7-b72756046348") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 387, DateTimeKind.Unspecified).AddTicks(5694), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ea9cfe72-1447-46fd-91db-d73fe6a3cf15") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_UserPosition",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 937, DateTimeKind.Unspecified).AddTicks(4364), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 783, DateTimeKind.Unspecified).AddTicks(1377), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserPosition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3b9d8c5b-ca2b-4412-b4b4-6d3c6eedd8f2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("6a7478b7-86e5-4d45-bdeb-14832b5b2ef7"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserPosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 937, DateTimeKind.Unspecified).AddTicks(4141), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 783, DateTimeKind.Unspecified).AddTicks(1148), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_UserLocation",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 937, DateTimeKind.Unspecified).AddTicks(1779), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(8689), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserLocation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("34c0a2ea-1327-4988-85e9-2769f1afe8d5"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("aaad5667-2df3-44fa-8438-fa68f0dddd72"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserLocation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 937, DateTimeKind.Unspecified).AddTicks(1096), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(8481), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_RolePosition",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(8827), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(6252), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_RolePosition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("078a8c60-9b1d-4393-8df3-ac2b290173ab"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("dcdd7afe-ea01-4535-a963-c4b73b66defb"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_RolePosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(8604), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(6040), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(5684), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(3790), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("95bb99dc-3477-4d61-8731-20c05237741a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c46c4fd5-2b1e-4b8e-8ec4-e7afee4b1505"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(5459), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(3578), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(2540), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(1292), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c92d0e8a-3186-4fea-9f13-00b062c28f25"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f0f5b263-f3f7-4beb-8b57-da49d1aba7bb"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(2316), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(1086), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(3), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(8577), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3382c08d-e7f6-4c23-9886-293f66792592"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("92528f94-1583-4dd7-bd2b-a4af8a26fd2a"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(9222), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(6744), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(5821), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("603b6e0b-902f-429d-a6ca-c1d6363df6a5"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8b00006e-8eba-4260-af64-b31b23502ef8"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(6506), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(5555), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(3332), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(2849), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8ffd2ed3-c180-4dac-acdf-6648f871fc66"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("fdd48e37-fdaa-4239-9372-fa121566d52f"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(3186), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(2688), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(608), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(568), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8e3e1344-bc34-414a-a710-13e67b623886"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c5a7a207-22cf-41eb-b7c2-b888bf43cbdc"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(413), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(354), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Endorsement",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 934, DateTimeKind.Unspecified).AddTicks(7350), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(7794), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Endorsement",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("39f7a327-55dc-47a7-93e4-263349016877"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("85ca9bb4-215f-41f6-9fa3-97e641e8aa5b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Endorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 934, DateTimeKind.Unspecified).AddTicks(7129), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(7537), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 934, DateTimeKind.Unspecified).AddTicks(4238), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(4533), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c4c238b5-08e8-4119-8ce3-545bef8e6efc"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("79d3adc5-183c-45e8-a5bd-86ff8670b6e6"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 934, DateTimeKind.Unspecified).AddTicks(3314), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(4270), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 934, DateTimeKind.Unspecified).AddTicks(211), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(1105), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("dcaca89a-3e19-43f2-9dd2-65a28f0172a0"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8b6ee948-6355-4ed8-98d8-0213e021bf34"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 933, DateTimeKind.Unspecified).AddTicks(9310), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(856), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 933, DateTimeKind.Unspecified).AddTicks(6788), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(8225), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1b788d6c-b2fb-4b90-8733-a96e59e560c6"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e03ca010-4994-490b-b716-fc0bd7a8bd8e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 933, DateTimeKind.Unspecified).AddTicks(6591), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(8034), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(6143), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(6133), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("aaa90c59-b184-4777-bdbd-a1d660eb5fde"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("21e674f3-6851-4597-bb52-7b4a8c6ad33b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(5948), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(5972), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(2083), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(4082), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("95d44cfa-9e8e-4347-920f-3a612d784227"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7ea2631a-f81b-4424-8085-0f694257bab8"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(1971), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(3920), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(336), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(1777), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("da5d262f-e155-4c1b-abf2-0b568f7b15a7"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("71414064-cb30-4db9-80b3-3f6d5a09ff5f"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(180), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(1540), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(8377), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(9024), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d9f0b267-edbf-4842-8aa5-29b54af80741"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5cc2ace9-5016-4cd6-8f52-f076cc5c3689"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(8259), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(8843), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(6757), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9ede2b65-043f-47e7-85e1-808e5503cbad"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("72d9b1ab-fe19-4fc4-ad1e-fe8c41ab86e3"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(6631), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(6727), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(5085), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(4510), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("0fc224a9-2e3c-4784-b5d2-0a9fbbad8eba"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("dfc0cfe9-fe85-4870-b503-843842766ba7"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(4962), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(3532), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(1426), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3ae783c5-fd58-40cb-bf81-e22077edc5b2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b12e3df2-1816-4d2f-9fc3-9b4850739b3c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(3370), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(1295), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(1949), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(9794), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("433b0bb2-e683-40a1-91b4-fc62e9eaf051"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7724f097-8327-4b13-8577-22cfcc03248f"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(1813), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(9635), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(339), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(7517), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("94c990e4-4381-4c50-abdc-6abb6b600a8f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e439adbf-496b-42d3-9d97-6d4ec308e6e6"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(224), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(7347), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(4951), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("fa2d50f5-7c6a-4c95-adf6-28f0282d3f4d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("aa12e9ac-2df5-4353-b7f4-e12d6ba6bfb7"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(8554), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(4664), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(6964), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(2627), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5a951242-95c3-4f9c-a021-acef78c3a582"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d26defcd-4370-4bd6-9d08-cce0a01c7bb8"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(6838), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(2450), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(5254), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(294), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a349e660-f60f-4c9c-b0a5-383eba81b209"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("6c184879-5922-4595-acbf-680c98d6344d"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(5061), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(71), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(5342), new TimeSpan(0, -8, 0, 0, 0)), new Guid("f9b55a52-85ac-4ff6-b1f9-8888ef08a1bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(5349), new TimeSpan(0, -8, 0, 0, 0)), new Guid("73e8937a-3109-4525-9657-b910a139cdbb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(5352), new TimeSpan(0, -8, 0, 0, 0)), new Guid("a96b922c-816b-48f8-80c7-954d08a72625") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(5355), new TimeSpan(0, -8, 0, 0, 0)), new Guid("05fbc29d-ac25-4098-b269-2eae688612bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(5358), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ecf70062-cb86-40ff-b15c-2232c37f76e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 485, DateTimeKind.Unspecified).AddTicks(5278), new TimeSpan(0, -8, 0, 0, 0)), new Guid("2a25a773-dfab-4f8e-9e96-401e7b6e3f1f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4645), new TimeSpan(0, -8, 0, 0, 0)), new Guid("90d2730d-c665-479e-b303-4ec313ea8d83") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4686), new TimeSpan(0, -8, 0, 0, 0)), new Guid("4549c53f-1458-4201-bbfb-35b89fabc26a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4700), new TimeSpan(0, -8, 0, 0, 0)), new Guid("4c6865ba-f268-435f-8c9f-3cb178253f8e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4707), new TimeSpan(0, -8, 0, 0, 0)), new Guid("da342a97-bbb4-4b69-bbd6-d77bc63fa652") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4713), new TimeSpan(0, -8, 0, 0, 0)), new Guid("f8adba07-a42e-41f7-8fec-e2a8d0c46410") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4719), new TimeSpan(0, -8, 0, 0, 0)), new Guid("e7abda66-a062-458a-ad42-77348e03ab54") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4725), new TimeSpan(0, -8, 0, 0, 0)), new Guid("5ee01315-c82c-4fa7-b7e9-eda54e95524d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4731), new TimeSpan(0, -8, 0, 0, 0)), new Guid("1df5db69-4729-49a8-8b73-e501b6b892ea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4745), new TimeSpan(0, -8, 0, 0, 0)), new Guid("3d74d4bd-62e3-4f61-be9d-e09218e48b93") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4751), new TimeSpan(0, -8, 0, 0, 0)), new Guid("301f96d5-929e-4bea-b287-e5c862b58280") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4758), new TimeSpan(0, -8, 0, 0, 0)), new Guid("a69ae0f4-aba4-4fc6-9e7c-d111e1b28716") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4762), new TimeSpan(0, -8, 0, 0, 0)), new Guid("f53264ef-2f7a-49a1-ad58-ed70b793bb5c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4767), new TimeSpan(0, -8, 0, 0, 0)), new Guid("a18aa156-e321-4fb8-a219-0c8e77c12d60") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4773), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ef39a25a-7bf4-4109-a097-b03502ca7169") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4779), new TimeSpan(0, -8, 0, 0, 0)), new Guid("e94d3ad8-bd71-48cb-a944-c1d074d72fe0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4783), new TimeSpan(0, -8, 0, 0, 0)), new Guid("9cbfb815-e694-4a66-90ce-fcfdded2d146") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4821), new TimeSpan(0, -8, 0, 0, 0)), new Guid("07cd51bd-08b9-4778-92ff-cf971773ed1b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4828), new TimeSpan(0, -8, 0, 0, 0)), new Guid("396a8843-e13c-4400-bdde-e919edc33248") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4835), new TimeSpan(0, -8, 0, 0, 0)), new Guid("cf15f1e6-67eb-4b2e-8bd3-588078bbce1f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(5860), new TimeSpan(0, -8, 0, 0, 0)), new Guid("99a822eb-4af1-4baf-8603-b58646e8ccc0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(7810), new TimeSpan(0, -8, 0, 0, 0)), new Guid("e9b71743-1dc3-45ac-97b9-0700850954ba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(7820), new TimeSpan(0, -8, 0, 0, 0)), new Guid("1924e203-98dc-4be5-a01f-f8b4c7c2f8ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(7823), new TimeSpan(0, -8, 0, 0, 0)), new Guid("d8c56a1c-d13d-4539-bef0-0e12776f95b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(7826), new TimeSpan(0, -8, 0, 0, 0)), new Guid("71702447-b68f-44f2-ac91-f7cd090590f5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(7830), new TimeSpan(0, -8, 0, 0, 0)), new Guid("7a97012b-ff4a-4e9a-8876-693a1b2313cd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(7832), new TimeSpan(0, -8, 0, 0, 0)), new Guid("acb7c691-b021-48ba-abd6-f2b497a555b3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(9086), new TimeSpan(0, -8, 0, 0, 0)), new Guid("14142346-6da3-4eb3-8be8-df52f7baf63e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(9846), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ed2773ae-cf8c-4442-a838-0533cea79e03") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(826), new TimeSpan(0, -8, 0, 0, 0)), new Guid("763e24a0-73c6-483d-87df-948b13f8e182") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(963), new TimeSpan(0, -8, 0, 0, 0)), new Guid("3bac8a9c-a9a4-4a84-87db-fd27bf6efe16") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(2699), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ccc900c8-4021-4589-ba87-ebb6df41669f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(2994), new TimeSpan(0, -8, 0, 0, 0)), new Guid("5e957543-c459-46ff-ad1c-8a642eaeef30") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(2999), new TimeSpan(0, -8, 0, 0, 0)), new Guid("49ab9698-fcea-490b-a34d-c5606a7216c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(3003), new TimeSpan(0, -8, 0, 0, 0)), new Guid("aec2ebf6-3ecd-49d7-85b9-6dabc03522e7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(3011), new TimeSpan(0, -8, 0, 0, 0)), new Guid("348062ec-01fc-4ee2-9945-f191a2b714c7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(4675), new TimeSpan(0, -8, 0, 0, 0)), new Guid("1a9e59e5-807f-42e2-84f2-d1529a0e2976") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(4713), new TimeSpan(0, -8, 0, 0, 0)), new Guid("70d16c68-e9a9-4593-8343-d230f0deb8a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(4724), new TimeSpan(0, -8, 0, 0, 0)), new Guid("63c162f1-79d2-4fba-8515-6eccd25134bb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(4728), new TimeSpan(0, -8, 0, 0, 0)), new Guid("4e38ca8a-abad-49c7-95bc-f7007565f9e8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, -8, 0, 0, 0)), new Guid("bbc942bf-5bab-477d-baec-184ecd9d4a3c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(8489), new TimeSpan(0, -8, 0, 0, 0)), new Guid("bc40a64b-1373-40b8-b0cc-e4e16eee5a35") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(9847), new TimeSpan(0, -8, 0, 0, 0)), new Guid("83df011b-fbd7-4509-a37f-f73e0f111957") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(9855), new TimeSpan(0, -8, 0, 0, 0)), new Guid("67786412-44fd-4db3-bf37-84bdf5d788ac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(9859), new TimeSpan(0, -8, 0, 0, 0)), new Guid("fed94a08-269c-4a84-844a-5cab9323799e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(9862), new TimeSpan(0, -8, 0, 0, 0)), new Guid("2b4a263a-a43a-4152-89d6-71c08a6d25f7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(8069), new TimeSpan(0, -8, 0, 0, 0)), new Guid("5b78510b-8713-4fc7-a0fb-605b1bd51eed") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(8549), new TimeSpan(0, -8, 0, 0, 0)), new Guid("d82cc118-18c9-43da-bfd5-43c668cfda2c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(8632), new TimeSpan(0, -8, 0, 0, 0)), new Guid("5a09b9af-01b0-45d1-8568-7519fcac0ca2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(8639), new TimeSpan(0, -8, 0, 0, 0)), new Guid("b1edb511-ee70-48cb-aff7-0c601033aa36") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(8647), new TimeSpan(0, -8, 0, 0, 0)), new Guid("203bee86-9029-4e68-9651-aa91d6aef2ca") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(375), new TimeSpan(0, -8, 0, 0, 0)), new Guid("be60350a-ad99-4385-b77f-f8b7b20454bd") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, -8, 0, 0, 0)), new Guid("6d59ef28-9acd-4ca3-ad99-e70f83602295") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(2689), new TimeSpan(0, -8, 0, 0, 0)), new Guid("348f1d82-f3a6-4dfc-b5c3-b2229db8096a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(2909), new TimeSpan(0, -8, 0, 0, 0)), new Guid("890ec66c-cbdc-47cc-a0ce-1d7134482a81") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(2915), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ead74cd3-0e98-4ee9-819e-b37444e13425") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(2918), new TimeSpan(0, -8, 0, 0, 0)), new Guid("aa43b198-8dfb-423d-b129-9afe99785438") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(3956), new TimeSpan(0, -8, 0, 0, 0)), new Guid("3e6cb777-9cee-4b75-b118-022fbde22b2f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 482, DateTimeKind.Unspecified).AddTicks(8432), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ec2d988d-ac03-4059-b9e6-d2f9df9c4028") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 482, DateTimeKind.Unspecified).AddTicks(9193), new TimeSpan(0, -8, 0, 0, 0)), new Guid("aac263a7-6497-4a0b-b3ad-1cbb7b767603") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(2876), new TimeSpan(0, -8, 0, 0, 0)), new Guid("25140dff-e8ac-4d99-8fb4-e940fb43dcd7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(4019), new TimeSpan(0, -8, 0, 0, 0)), new Guid("6f93b1dc-6070-4d19-a782-efa6e71ab661") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(4063), new TimeSpan(0, -8, 0, 0, 0)), new Guid("276c27cc-26eb-4719-9743-6d0476562b55") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(4995), new TimeSpan(0, -8, 0, 0, 0)), new Guid("77c104f2-0a5f-4ba9-a08a-7c57c01c91d3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(5002), new TimeSpan(0, -8, 0, 0, 0)), new Guid("4cfcc293-799b-4907-9ba4-84e3540b5e26") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(5887), new TimeSpan(0, -8, 0, 0, 0)), new Guid("3b7a419f-1640-4d1d-973c-af646791a23f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(5893), new TimeSpan(0, -8, 0, 0, 0)), new Guid("91a54290-50bf-44fb-bf33-8e5936a38a84") });
        }
    }
}
