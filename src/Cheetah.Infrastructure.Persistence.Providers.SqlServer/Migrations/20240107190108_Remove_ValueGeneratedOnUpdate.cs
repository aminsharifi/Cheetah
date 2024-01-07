using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Remove_ValueGeneratedOnUpdate : Migration
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 152, DateTimeKind.Unspecified).AddTicks(1711), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("b4ab7bf7-721a-47ff-becd-a0590f774894"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 152, DateTimeKind.Unspecified).AddTicks(1559), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 783, DateTimeKind.Unspecified).AddTicks(1148), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_UserLocation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(9651), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("2c6a6e1a-ff07-49c5-a619-a3b8b961690d"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(9496), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(8481), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_RolePosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(7619), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("6b08ff57-73f8-44d7-9622-46b8c2c58e7e"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(7463), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(6040), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(5545), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("925e3206-a47d-4b16-8014-0caaee96d61c"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(5394), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(3578), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(3483), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("79ffecd8-eddc-41f1-a56c-6e114e3efb20"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(3336), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(1086), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("a53a1ec2-7c31-496c-a777-c48642cb4539"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(1228), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(9230), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("88c30eef-9b95-4cdb-a923-c78ac19b7b01"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(9041), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(5555), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(6979), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("6e4f95d8-e0e3-4840-89f4-6a0df31b41c2"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(6830), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(2688), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(5209), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("557edbba-f46c-4e65-a4b4-b76603454a92"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(5014), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(354), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Endorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(2994), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("a9a5f631-c76d-4c82-9ec9-fcbb90fcf6da"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(2811), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(7537), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(457), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("bebd7cab-a367-4254-a6a3-aeff57d90b31"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(230), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(4270), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(7742), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("6cf6c9b7-8ade-49ca-b1ac-3f423047cda2"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(7527), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(856), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(5464), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("36d4b4ef-7b0a-43e6-abfb-39976a49851d"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(5335), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(8034), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(3853), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("a56716a2-79ed-4f2e-8168-0cd7c9d73059"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(3727), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(5972), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(2263), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("6d4d6a99-d7e1-4e40-9e38-29173d5a7a0b"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(2114), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(3920), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(392), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("ba1954fc-c2c6-4d96-913b-e5324b6466b2"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(226), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(1540), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(8397), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("f05500ab-070f-4dd3-9bd5-028ee35755c9"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(8241), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(8843), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("0c7a7ce5-43d3-4f72-a268-990afd9c5507"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(6572), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(6727), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(4940), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("38519ddb-822f-4fdb-9f71-149bbf41debc"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(4812), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(4335), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(3339), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("b34fcdf0-9fd8-4e92-967e-03a3ca88acda"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(1295), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(1730), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("f6520e8e-bb78-43d6-b9b3-15a1ae7b367c"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(1602), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(9635), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(16), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("9a763e47-b550-4c84-a5b6-e5ba1e13e704"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(9892), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(7347), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(8292), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("90e36cd5-4961-434e-8324-f7dc3c11fe0f"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(8149), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(4664), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("b33d131c-36d5-42d8-860e-3d026edbbbdd"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6331), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(2450), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(4654), new TimeSpan(0, -8, 0, 0, 0)),
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
                defaultValue: new Guid("288ead14-b66b-423a-b8f2-f50f42e6330b"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(4458), new TimeSpan(0, -8, 0, 0, 0)),
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
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(8058), new TimeSpan(0, -8, 0, 0, 0)), new Guid("a49653bb-507e-4dde-9116-0285108602aa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(8067), new TimeSpan(0, -8, 0, 0, 0)), new Guid("bd5c3330-427f-4b93-adb5-758c11d7604f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(8071), new TimeSpan(0, -8, 0, 0, 0)), new Guid("35a26bc2-f5ea-4936-9565-188fdaa427f6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(8078), new TimeSpan(0, -8, 0, 0, 0)), new Guid("7fb876fc-b0de-4811-af25-b6ed4c04a72b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(8082), new TimeSpan(0, -8, 0, 0, 0)), new Guid("121cbf84-f295-4752-b8a9-de94799b9a7e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 750, DateTimeKind.Unspecified).AddTicks(4598), new TimeSpan(0, -8, 0, 0, 0)), new Guid("b74c5606-525a-455d-a9e1-73e5ee53b79d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8241), new TimeSpan(0, -8, 0, 0, 0)), new Guid("14da8f7d-0366-482f-909f-a5412c7ad89d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8368), new TimeSpan(0, -8, 0, 0, 0)), new Guid("6fa9d4d9-03b7-4056-9ed1-dd05264ac7ac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8379), new TimeSpan(0, -8, 0, 0, 0)), new Guid("1b198789-97c3-4f33-a69a-5b9a8ee54b7c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8387), new TimeSpan(0, -8, 0, 0, 0)), new Guid("f092d712-fe15-410b-9ba8-5e629b0132dc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8394), new TimeSpan(0, -8, 0, 0, 0)), new Guid("e6c07f8f-735b-4a9f-8786-bda386cb392a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8402), new TimeSpan(0, -8, 0, 0, 0)), new Guid("9cde3976-aa51-4cdc-8f04-75cdbf299b06") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8431), new TimeSpan(0, -8, 0, 0, 0)), new Guid("516514cc-3799-4616-ab73-c3ff1b32780b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8439), new TimeSpan(0, -8, 0, 0, 0)), new Guid("d498ce9e-4f00-4013-9a0e-22682c7ab6b1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8446), new TimeSpan(0, -8, 0, 0, 0)), new Guid("fe0a1f26-e3c1-4ed9-84a9-72007859cee2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8453), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ba438247-a619-4976-b5d7-c026bc83c0aa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8460), new TimeSpan(0, -8, 0, 0, 0)), new Guid("656073a6-c853-41a3-942d-dc144a2d8b4e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8467), new TimeSpan(0, -8, 0, 0, 0)), new Guid("98bccce7-12af-4b57-958d-a5eed18dce80") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8484), new TimeSpan(0, -8, 0, 0, 0)), new Guid("5ddf3bdc-4d92-4648-af97-1d1c7cba3c57") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8491), new TimeSpan(0, -8, 0, 0, 0)), new Guid("be4185ff-3260-43b9-a480-c555f32a4e61") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), new Guid("2c75f208-5504-4e28-8901-252ce1d170fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8506), new TimeSpan(0, -8, 0, 0, 0)), new Guid("156f9ec7-30a3-4e5a-aecf-e2da60e59c4d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8513), new TimeSpan(0, -8, 0, 0, 0)), new Guid("cd58e31d-e51e-4df7-b59a-b5091936af83") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8520), new TimeSpan(0, -8, 0, 0, 0)), new Guid("412a900e-4e32-446f-9e5f-bdc797ace83e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8553), new TimeSpan(0, -8, 0, 0, 0)), new Guid("e6f3ec5d-48ab-4453-ab13-c1c349ffb8e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(119), new TimeSpan(0, -8, 0, 0, 0)), new Guid("5973fb2f-3f78-448f-b54c-601894801fa8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, -8, 0, 0, 0)), new Guid("f575801a-fcc1-45a5-a4f1-11e7e6bf84af") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(2255), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ce95edcc-40e6-42f3-bf97-1604aee43ecb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(2263), new TimeSpan(0, -8, 0, 0, 0)), new Guid("81570b73-c458-4c32-9e67-fb2527c91c12") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(2296), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ab0c20d6-0352-443b-9e0a-36f2d5837e64") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(2300), new TimeSpan(0, -8, 0, 0, 0)), new Guid("3b075ba8-4cd0-463d-a7a6-d3ce88c1ce35") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(2303), new TimeSpan(0, -8, 0, 0, 0)), new Guid("f1e0bc6c-1fd8-426f-abcd-5ecb2f479fc0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(3973), new TimeSpan(0, -8, 0, 0, 0)), new Guid("e04d681a-8a70-49ea-a427-923384b50198") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(5011), new TimeSpan(0, -8, 0, 0, 0)), new Guid("a05398e8-e69c-4a16-a573-33da6494f81f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(6159), new TimeSpan(0, -8, 0, 0, 0)), new Guid("d3497535-fc46-47eb-9f0d-cb806f16e005") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(6335), new TimeSpan(0, -8, 0, 0, 0)), new Guid("84d19c8f-cdba-496e-ac13-404eebbf9445") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), new Guid("a7179ed7-a8d6-496f-8ee3-41dd80a8c033") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(8883), new TimeSpan(0, -8, 0, 0, 0)), new Guid("0630d4a2-4137-4cc3-94e9-9b16c8c86b11") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(8891), new TimeSpan(0, -8, 0, 0, 0)), new Guid("24bcea23-bd7a-4ede-9070-1d916ef76a35") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(8895), new TimeSpan(0, -8, 0, 0, 0)), new Guid("00a53409-7ebd-4b45-9810-e8f6cf5b3280") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(8899), new TimeSpan(0, -8, 0, 0, 0)), new Guid("7874723c-37b5-4ab9-b29e-7234ac4b11c3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(400), new TimeSpan(0, -8, 0, 0, 0)), new Guid("4b9efe64-c9db-4781-b644-b8e7d80ddf4b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(408), new TimeSpan(0, -8, 0, 0, 0)), new Guid("38ee0683-4fb8-4b31-bc64-bbb232d8e338") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(411), new TimeSpan(0, -8, 0, 0, 0)), new Guid("763de082-ee01-4c85-8f85-b8d7e1c07c63") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(418), new TimeSpan(0, -8, 0, 0, 0)), new Guid("e695999c-4804-41b3-afeb-a9bebb469e29") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(3744), new TimeSpan(0, -8, 0, 0, 0)), new Guid("a5d386fc-e8d9-42ef-9704-673fe312d4af") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(3779), new TimeSpan(0, -8, 0, 0, 0)), new Guid("97d09cd3-bc21-4020-b9bd-ff5a136b877b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(5579), new TimeSpan(0, -8, 0, 0, 0)), new Guid("f0872738-815a-40ce-ac7a-ad9f13281d82") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(5589), new TimeSpan(0, -8, 0, 0, 0)), new Guid("77733e68-ed17-4f8a-b124-3741318a8e49") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(5593), new TimeSpan(0, -8, 0, 0, 0)), new Guid("1f6fe3be-d570-4004-8700-228685b11396") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(5598), new TimeSpan(0, -8, 0, 0, 0)), new Guid("5ec0ad0d-34ad-4f9c-bbc7-906fb05ed795") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(137), new TimeSpan(0, -8, 0, 0, 0)), new Guid("dcf284c9-d599-4b5a-81b5-baf9ee491bb8") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(580), new TimeSpan(0, -8, 0, 0, 0)), new Guid("d99793a0-968e-4c59-b6ad-8054fd939dd9") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(665), new TimeSpan(0, -8, 0, 0, 0)), new Guid("07b6bfc8-9753-40e5-8720-a3de38d7f878") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(670), new TimeSpan(0, -8, 0, 0, 0)), new Guid("d13db17d-909e-4f43-8fb3-68f29873f835") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(674), new TimeSpan(0, -8, 0, 0, 0)), new Guid("153909c8-cb4a-4e1b-aa6c-f9f1b9ff7acc") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(2355), new TimeSpan(0, -8, 0, 0, 0)), new Guid("1c05eb00-71cc-41cf-87f0-029f413138de") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(2578), new TimeSpan(0, -8, 0, 0, 0)), new Guid("3ddba966-1cc2-4957-b4f3-e4beddaf3b52") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(4647), new TimeSpan(0, -8, 0, 0, 0)), new Guid("336e3f3d-1aa8-415b-82fd-cb34ff2af06d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(4866), new TimeSpan(0, -8, 0, 0, 0)), new Guid("db8b8799-b102-488b-b35c-f35af55feecf") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(4872), new TimeSpan(0, -8, 0, 0, 0)), new Guid("fefd4aa0-2aa0-44d4-b060-a8b6091f4930") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(4876), new TimeSpan(0, -8, 0, 0, 0)), new Guid("eb79d5ed-2f53-4929-82c7-d2276c12708d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(6257), new TimeSpan(0, -8, 0, 0, 0)), new Guid("311366d0-0e91-4ebf-bc02-5b9f7f7ca81c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(514), new TimeSpan(0, -8, 0, 0, 0)), new Guid("00d8d31b-015a-40d7-a13a-03619a8cd77b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(1311), new TimeSpan(0, -8, 0, 0, 0)), new Guid("9bdaa144-5eb7-44ed-bce0-a9e06528bb87") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(4957), new TimeSpan(0, -8, 0, 0, 0)), new Guid("a2a99886-eaff-40c5-84b1-cbef7dd583ef") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(6088), new TimeSpan(0, -8, 0, 0, 0)), new Guid("826a3e94-118b-4ad1-9c0f-c615f72e118b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(6097), new TimeSpan(0, -8, 0, 0, 0)), new Guid("faa3104f-4c6c-4e88-88b8-d43349ce4606") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(7091), new TimeSpan(0, -8, 0, 0, 0)), new Guid("cfd34c71-b30d-4a23-beca-9ded173a54b7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(7099), new TimeSpan(0, -8, 0, 0, 0)), new Guid("9992522e-8df0-4bd2-baaf-eeb63121a23c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(7957), new TimeSpan(0, -8, 0, 0, 0)), new Guid("cfc5b093-9e4e-4e77-9336-79113bc28f0d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(7967), new TimeSpan(0, -8, 0, 0, 0)), new Guid("9ac193d9-6bae-4cf3-b73c-ab9d05990a32") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 152, DateTimeKind.Unspecified).AddTicks(1711), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("b4ab7bf7-721a-47ff-becd-a0590f774894"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 152, DateTimeKind.Unspecified).AddTicks(1559), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_UserLocation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(8689), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(9651), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("2c6a6e1a-ff07-49c5-a619-a3b8b961690d"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(9496), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_RolePosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(6252), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(7619), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("6b08ff57-73f8-44d7-9622-46b8c2c58e7e"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(7463), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(3790), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(5545), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("925e3206-a47d-4b16-8014-0caaee96d61c"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(5394), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 782, DateTimeKind.Unspecified).AddTicks(1292), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(3483), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("79ffecd8-eddc-41f1-a56c-6e114e3efb20"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(3336), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(8577), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("a53a1ec2-7c31-496c-a777-c48642cb4539"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(1228), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(5821), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(9230), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("88c30eef-9b95-4cdb-a923-c78ac19b7b01"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(9041), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(2849), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(6979), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("6e4f95d8-e0e3-4840-89f4-6a0df31b41c2"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(6830), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 781, DateTimeKind.Unspecified).AddTicks(568), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(5209), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("557edbba-f46c-4e65-a4b4-b76603454a92"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(5014), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Endorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(7794), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(2994), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("a9a5f631-c76d-4c82-9ec9-fcbb90fcf6da"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(2811), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(4533), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(457), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("bebd7cab-a367-4254-a6a3-aeff57d90b31"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(230), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 780, DateTimeKind.Unspecified).AddTicks(1105), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(7742), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("6cf6c9b7-8ade-49ca-b1ac-3f423047cda2"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(7527), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(8225), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(5464), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("36d4b4ef-7b0a-43e6-abfb-39976a49851d"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(5335), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(6133), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(3853), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("a56716a2-79ed-4f2e-8168-0cd7c9d73059"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(3727), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(4082), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(2263), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("6d4d6a99-d7e1-4e40-9e38-29173d5a7a0b"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(2114), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 779, DateTimeKind.Unspecified).AddTicks(1777), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(392), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("ba1954fc-c2c6-4d96-913b-e5324b6466b2"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(226), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(9024), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(8397), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("f05500ab-070f-4dd3-9bd5-028ee35755c9"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(8241), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("0c7a7ce5-43d3-4f72-a268-990afd9c5507"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(6572), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(4510), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(4940), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("38519ddb-822f-4fdb-9f71-149bbf41debc"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(4812), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 778, DateTimeKind.Unspecified).AddTicks(1426), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(3339), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("b34fcdf0-9fd8-4e92-967e-03a3ca88acda"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(9794), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(1730), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("f6520e8e-bb78-43d6-b9b3-15a1ae7b367c"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(1602), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(7517), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(16), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("9a763e47-b550-4c84-a5b6-e5ba1e13e704"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(9892), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(4951), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(8292), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("90e36cd5-4961-434e-8324-f7dc3c11fe0f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(8149), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(2627), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("b33d131c-36d5-42d8-860e-3d026edbbbdd"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6331), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 10, 33, 16, 777, DateTimeKind.Unspecified).AddTicks(294), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(4654), new TimeSpan(0, -8, 0, 0, 0)));

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
                oldDefaultValue: new Guid("288ead14-b66b-423a-b8f2-f50f42e6330b"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(4458), new TimeSpan(0, -8, 0, 0, 0)));

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
    }
}
