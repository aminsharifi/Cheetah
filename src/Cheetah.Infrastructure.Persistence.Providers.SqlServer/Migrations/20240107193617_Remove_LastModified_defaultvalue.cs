using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Remove_LastModified_defaultvalue : Migration
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
                defaultValue: new Guid("1a53c2bf-4a06-456d-b69f-1bacc6b899a9"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 72, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("7bb7859d-6a20-4666-9c7c-01ab1980a0bd"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 72, DateTimeKind.Unspecified).AddTicks(3148), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("2fb713f9-febc-4c24-bf1f-4d5aad7d903f"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 71, DateTimeKind.Unspecified).AddTicks(9723), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("f28c1ad9-a50b-46fb-b8f5-aa31d9fed13d"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 71, DateTimeKind.Unspecified).AddTicks(6257), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("70313024-72df-4ae2-84e0-b39f6db0ca06"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 71, DateTimeKind.Unspecified).AddTicks(2703), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("9bdb5c42-7e0b-4b9e-860a-ca5e974c09af"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 70, DateTimeKind.Unspecified).AddTicks(8987), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("30f1508d-f527-4f89-a0c9-3686c285d667"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 70, DateTimeKind.Unspecified).AddTicks(6384), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("e745e3ce-4dfc-4551-8b90-8351364aff54"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 70, DateTimeKind.Unspecified).AddTicks(3703), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("e39b1b9f-b8ac-4c44-a162-59e87c8295e6"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 70, DateTimeKind.Unspecified).AddTicks(393), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("bfd38f2c-dff6-4713-a09c-3875c35551b5"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 69, DateTimeKind.Unspecified).AddTicks(7917), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("5ed855ac-e0d9-42b8-a644-83a31ceea0ee"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 69, DateTimeKind.Unspecified).AddTicks(5061), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("2634be80-fa87-488a-bc42-8d2b1aba3caf"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 69, DateTimeKind.Unspecified).AddTicks(1219), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("923a663c-2fc7-47e2-877f-5ad20dee2e5a"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 68, DateTimeKind.Unspecified).AddTicks(8152), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("2e3434cc-b2c3-4aab-9bb4-789b056b071c"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 68, DateTimeKind.Unspecified).AddTicks(5916), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("4acca7ad-de8e-4d66-857c-397cf89e4690"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 68, DateTimeKind.Unspecified).AddTicks(3892), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("c4d793b0-9dde-4743-a902-1b04aaaf83a2"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 68, DateTimeKind.Unspecified).AddTicks(1210), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("a100f063-0b4f-4698-b53f-b1bb6c18585b"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 67, DateTimeKind.Unspecified).AddTicks(8582), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("93bdf80b-9bd7-4416-a038-1ec17a1e3396"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 67, DateTimeKind.Unspecified).AddTicks(6364), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("c368e6cd-c48b-4156-84bd-4270930dd180"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 67, DateTimeKind.Unspecified).AddTicks(4003), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("2288200e-de94-4d0e-8735-28a25ee3e25e"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 67, DateTimeKind.Unspecified).AddTicks(1915), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("2cdcaf2f-3510-40ba-9ccd-e836a7d3328f"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 66, DateTimeKind.Unspecified).AddTicks(9630), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("72b6d54e-d3c0-46bb-a90c-1b1793018fe7"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 66, DateTimeKind.Unspecified).AddTicks(7149), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("5f016f2e-1bfc-4133-8085-8b6d1b4dcf6b"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 66, DateTimeKind.Unspecified).AddTicks(4900), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("131d4f2c-67be-426a-b92f-f36a625a7a11"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 66, DateTimeKind.Unspecified).AddTicks(2517), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("300ff3d6-7a74-48f5-814e-e684a690562c"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 65, DateTimeKind.Unspecified).AddTicks(9929), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(4458), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f9108182-367a-41e2-9e62-b0aa3cbcc905"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(5738), new TimeSpan(0, 3, 30, 0, 0)), new Guid("266f7606-ec3d-4b72-bcb7-339bdd29eaa5"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(5742), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a8c8cb75-3cb8-49d8-986d-13389b790da2"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(5749), new TimeSpan(0, 3, 30, 0, 0)), new Guid("309c409f-01ad-4000-a754-95a5b7b5401a"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(5752), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b57a3178-5b0f-40a5-a980-6297b2996ddd"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 590, DateTimeKind.Unspecified).AddTicks(8430), new TimeSpan(0, 3, 30, 0, 0)), new Guid("798ce64d-14d6-4e82-b1a3-8645cd49d659"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1625), new TimeSpan(0, 3, 30, 0, 0)), new Guid("efb1ecbc-6579-4f25-841e-e887074cd462"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1666), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fe5f34e0-cb5c-4356-a2e0-ab1860cfbd65"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1673), new TimeSpan(0, 3, 30, 0, 0)), new Guid("65042e36-89a0-4dc0-af61-508f085d68f5"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1681), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aeab6e51-e46b-46bd-96ef-a87160c1b625"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1689), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c0ef0af5-8c18-4bdd-ba4a-87b3d9a3bc42"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1703), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5d9defe0-3b90-4067-bd04-964280131363"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1711), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3dcdd953-8142-40d8-a4ea-0d9c8c739e5b"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1718), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0d63c734-c1f3-47e6-b101-edaefe4d1e77"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1736), new TimeSpan(0, 3, 30, 0, 0)), new Guid("763ddb36-894a-4c11-9231-3dd83557084a"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1741), new TimeSpan(0, 3, 30, 0, 0)), new Guid("069af2ea-2e43-45a9-9d29-7e8719a0cba5"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1749), new TimeSpan(0, 3, 30, 0, 0)), new Guid("edaf8998-b439-4f42-85a6-fe4176139aea"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1753), new TimeSpan(0, 3, 30, 0, 0)), new Guid("19e34c1c-57c5-4f1f-b5f3-24b2d72cac9c"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1759), new TimeSpan(0, 3, 30, 0, 0)), new Guid("351a1a73-c778-4077-84f4-6c7ea83d2d01"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1816), new TimeSpan(0, 3, 30, 0, 0)), new Guid("70240b8b-6946-43fa-b77c-aeb421ca216d"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1822), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a7cad31e-560f-4058-9344-e9db0aec9fef"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1826), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8cdaca47-5316-4a58-b370-85177e2770ad"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1830), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f3589560-277d-4ccc-9172-30bd750eb3b0"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1837), new TimeSpan(0, 3, 30, 0, 0)), new Guid("171be1d0-59be-4aa2-b792-43a308262fd1"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1842), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d48b0d02-3a98-4901-8877-a6fd9cf3bbe1"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(3085), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2bd0adb9-c5d8-4191-aeda-2865fa6326ce"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(4705), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9cb0a26d-bc86-415b-a7e4-57e674c557ae"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(4714), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bf3cbbbd-84b2-4c65-88b6-4b85d28e39c5"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(4717), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f8163bf6-b0fd-4628-8a8b-9c67d2652f1b"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(4719), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d0ce55ca-7e1d-455a-811c-038189a8ffe5"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(4722), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ea841fc4-40f2-4d2b-a9ef-7302cef0ddbd"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(4724), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cf203154-663c-4a7e-8901-150ffac8a7a2"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(6150), new TimeSpan(0, 3, 30, 0, 0)), new Guid("374ec259-80a3-415d-920f-0c84b0d01465"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(7049), new TimeSpan(0, 3, 30, 0, 0)), new Guid("819ea863-5d6e-4a0b-8394-685c3934542b"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(8036), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7e756677-3794-416e-b732-d569c2a42462"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(8211), new TimeSpan(0, 3, 30, 0, 0)), new Guid("994338ed-75cc-424a-83b3-66ea6add5040"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(2262), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7392d63-7962-4aed-a670-b730cbdd79ba"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(2590), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0333970e-1fa7-4b5b-9395-299094c25d55"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(2643), new TimeSpan(0, 3, 30, 0, 0)), new Guid("05f17533-edaf-419c-87ee-d80743996511"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(2647), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f319139a-e512-410d-ab71-2b3b1390cc52"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(2650), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cf900550-686c-4cc4-be7d-54e8c01211cc"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(4180), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e1265bf6-1fd7-4473-a3e0-245abd3f86d8"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(4187), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f7571f97-8cd1-4f1c-b692-aa31ca9cbc11"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(4196), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dbc06fe1-fff4-4f6d-a0de-f3721d9497d6"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(4199), new TimeSpan(0, 3, 30, 0, 0)), new Guid("932fb04a-ccbc-49cb-98df-7c188a87da7b"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(7353), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b57bea2f-ff33-421b-a6b2-82a5a62355c5"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(7387), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8a7b284b-9a18-41be-b509-8ad226920a84"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(8879), new TimeSpan(0, 3, 30, 0, 0)), new Guid("51b2ab6e-e11e-47e6-93e6-29b6db61712c"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(8886), new TimeSpan(0, 3, 30, 0, 0)), new Guid("55ee115d-67f2-455b-b3d0-8dd046d12e5c"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(8890), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e7de6388-ec5a-4474-bff5-e745620f269c"), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(8893), new TimeSpan(0, 3, 30, 0, 0)), new Guid("27f384cc-d066-47ff-945f-24c03b716162"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(6854), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1c2e9b1e-3f6d-4576-a3d4-66a86077fcca"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(7380), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c48a46ec-5573-4ac8-98ee-1664fbec5717"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(7475), new TimeSpan(0, 3, 30, 0, 0)), new Guid("46887efe-643f-427a-bef7-f77fbab518a6"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(7481), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a9186b61-7089-4994-b867-17c529d87bdd"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(7485), new TimeSpan(0, 3, 30, 0, 0)), new Guid("45c5e89b-4259-4a49-b34b-5323337317bc"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(9698), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ca82751e-e456-4a9c-b681-b2abcabab236"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(9982), new TimeSpan(0, 3, 30, 0, 0)), new Guid("79dec0bc-9731-4cfc-9892-20579e5296ff"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(2523), new TimeSpan(0, 3, 30, 0, 0)), new Guid("48da475b-1c0f-440a-a2e2-f48f239ee277"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(2793), new TimeSpan(0, 3, 30, 0, 0)), new Guid("48ee6aac-a83c-4753-a737-44677cc9305e"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(2800), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c446eee4-2c75-4f8e-991b-e2b8354ccffe"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(2805), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f53f7a69-5301-43c1-a8cc-d76159f81205"), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(4082), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9f5db529-a25c-4196-98da-fb0fe44a4e0c"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 587, DateTimeKind.Unspecified).AddTicks(3562), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c8a61584-f543-4cbe-b496-1c479183721f"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 587, DateTimeKind.Unspecified).AddTicks(4498), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cdddc528-6a8d-41da-9b45-12b8c4dc2d9c"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 587, DateTimeKind.Unspecified).AddTicks(9163), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ca7661cf-e324-4832-bce4-54cf7d0505c2"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(505), new TimeSpan(0, 3, 30, 0, 0)), new Guid("57b3a290-8c29-4438-b81a-4c40ecbacc90"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(514), new TimeSpan(0, 3, 30, 0, 0)), new Guid("370b2b22-5dc8-42f6-a0b7-31838e84eded"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(1572), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dc43f014-5e99-484d-81a4-3e435003c979"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(1580), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d5415bc8-670f-4124-bde9-2d29e18e2798"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(4232), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6e298123-b4f3-4e97-9499-39039f329a02"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(4251), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0c5ed780-b451-419e-84fc-e57f55f8952e"), null });
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 152, DateTimeKind.Unspecified).AddTicks(1711), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("1a53c2bf-4a06-456d-b69f-1bacc6b899a9"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 72, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_UserLocation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(9651), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("7bb7859d-6a20-4666-9c7c-01ab1980a0bd"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 72, DateTimeKind.Unspecified).AddTicks(3148), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_RolePosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(7619), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("2fb713f9-febc-4c24-bf1f-4d5aad7d903f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 71, DateTimeKind.Unspecified).AddTicks(9723), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(5545), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("f28c1ad9-a50b-46fb-b8f5-aa31d9fed13d"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 71, DateTimeKind.Unspecified).AddTicks(6257), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(3483), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("70313024-72df-4ae2-84e0-b39f6db0ca06"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 71, DateTimeKind.Unspecified).AddTicks(2703), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("9bdb5c42-7e0b-4b9e-860a-ca5e974c09af"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 70, DateTimeKind.Unspecified).AddTicks(8987), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(9230), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("30f1508d-f527-4f89-a0c9-3686c285d667"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 70, DateTimeKind.Unspecified).AddTicks(6384), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(6979), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("e745e3ce-4dfc-4551-8b90-8351364aff54"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 70, DateTimeKind.Unspecified).AddTicks(3703), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(5209), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("e39b1b9f-b8ac-4c44-a162-59e87c8295e6"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 70, DateTimeKind.Unspecified).AddTicks(393), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Endorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(2994), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("bfd38f2c-dff6-4713-a09c-3875c35551b5"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 69, DateTimeKind.Unspecified).AddTicks(7917), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(457), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("5ed855ac-e0d9-42b8-a644-83a31ceea0ee"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 69, DateTimeKind.Unspecified).AddTicks(5061), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(7742), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("2634be80-fa87-488a-bc42-8d2b1aba3caf"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 69, DateTimeKind.Unspecified).AddTicks(1219), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(5464), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("923a663c-2fc7-47e2-877f-5ad20dee2e5a"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 68, DateTimeKind.Unspecified).AddTicks(8152), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(3853), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("2e3434cc-b2c3-4aab-9bb4-789b056b071c"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 68, DateTimeKind.Unspecified).AddTicks(5916), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(2263), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("4acca7ad-de8e-4d66-857c-397cf89e4690"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 68, DateTimeKind.Unspecified).AddTicks(3892), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(392), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("c4d793b0-9dde-4743-a902-1b04aaaf83a2"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 68, DateTimeKind.Unspecified).AddTicks(1210), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(8397), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("a100f063-0b4f-4698-b53f-b1bb6c18585b"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 67, DateTimeKind.Unspecified).AddTicks(8582), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("93bdf80b-9bd7-4416-a038-1ec17a1e3396"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 67, DateTimeKind.Unspecified).AddTicks(6364), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(4940), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("c368e6cd-c48b-4156-84bd-4270930dd180"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 67, DateTimeKind.Unspecified).AddTicks(4003), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(3339), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("2288200e-de94-4d0e-8735-28a25ee3e25e"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 67, DateTimeKind.Unspecified).AddTicks(1915), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(1730), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("2cdcaf2f-3510-40ba-9ccd-e836a7d3328f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 66, DateTimeKind.Unspecified).AddTicks(9630), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(16), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("72b6d54e-d3c0-46bb-a90c-1b1793018fe7"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 66, DateTimeKind.Unspecified).AddTicks(7149), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(8292), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("5f016f2e-1bfc-4133-8085-8b6d1b4dcf6b"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 66, DateTimeKind.Unspecified).AddTicks(4900), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("131d4f2c-67be-426a-b92f-f36a625a7a11"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 66, DateTimeKind.Unspecified).AddTicks(2517), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(4654), new TimeSpan(0, -8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

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
                oldDefaultValue: new Guid("300ff3d6-7a74-48f5-814e-e684a690562c"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 65, DateTimeKind.Unspecified).AddTicks(9929), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(8058), new TimeSpan(0, -8, 0, 0, 0)), new Guid("a49653bb-507e-4dde-9116-0285108602aa"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(4654), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(8067), new TimeSpan(0, -8, 0, 0, 0)), new Guid("bd5c3330-427f-4b93-adb5-758c11d7604f"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(4654), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(8071), new TimeSpan(0, -8, 0, 0, 0)), new Guid("35a26bc2-f5ea-4936-9565-188fdaa427f6"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(4654), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(8078), new TimeSpan(0, -8, 0, 0, 0)), new Guid("7fb876fc-b0de-4811-af25-b6ed4c04a72b"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(4654), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(8082), new TimeSpan(0, -8, 0, 0, 0)), new Guid("121cbf84-f295-4752-b8a9-de94799b9a7e"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(4654), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 750, DateTimeKind.Unspecified).AddTicks(4598), new TimeSpan(0, -8, 0, 0, 0)), new Guid("b74c5606-525a-455d-a9e1-73e5ee53b79d"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8241), new TimeSpan(0, -8, 0, 0, 0)), new Guid("14da8f7d-0366-482f-909f-a5412c7ad89d"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8368), new TimeSpan(0, -8, 0, 0, 0)), new Guid("6fa9d4d9-03b7-4056-9ed1-dd05264ac7ac"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8379), new TimeSpan(0, -8, 0, 0, 0)), new Guid("1b198789-97c3-4f33-a69a-5b9a8ee54b7c"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8387), new TimeSpan(0, -8, 0, 0, 0)), new Guid("f092d712-fe15-410b-9ba8-5e629b0132dc"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8394), new TimeSpan(0, -8, 0, 0, 0)), new Guid("e6c07f8f-735b-4a9f-8786-bda386cb392a"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8402), new TimeSpan(0, -8, 0, 0, 0)), new Guid("9cde3976-aa51-4cdc-8f04-75cdbf299b06"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8431), new TimeSpan(0, -8, 0, 0, 0)), new Guid("516514cc-3799-4616-ab73-c3ff1b32780b"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8439), new TimeSpan(0, -8, 0, 0, 0)), new Guid("d498ce9e-4f00-4013-9a0e-22682c7ab6b1"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8446), new TimeSpan(0, -8, 0, 0, 0)), new Guid("fe0a1f26-e3c1-4ed9-84a9-72007859cee2"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8453), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ba438247-a619-4976-b5d7-c026bc83c0aa"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8460), new TimeSpan(0, -8, 0, 0, 0)), new Guid("656073a6-c853-41a3-942d-dc144a2d8b4e"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8467), new TimeSpan(0, -8, 0, 0, 0)), new Guid("98bccce7-12af-4b57-958d-a5eed18dce80"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8484), new TimeSpan(0, -8, 0, 0, 0)), new Guid("5ddf3bdc-4d92-4648-af97-1d1c7cba3c57"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8491), new TimeSpan(0, -8, 0, 0, 0)), new Guid("be4185ff-3260-43b9-a480-c555f32a4e61"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), new Guid("2c75f208-5504-4e28-8901-252ce1d170fe"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8506), new TimeSpan(0, -8, 0, 0, 0)), new Guid("156f9ec7-30a3-4e5a-aecf-e2da60e59c4d"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8513), new TimeSpan(0, -8, 0, 0, 0)), new Guid("cd58e31d-e51e-4df7-b59a-b5091936af83"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8520), new TimeSpan(0, -8, 0, 0, 0)), new Guid("412a900e-4e32-446f-9e5f-bdc797ace83e"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 751, DateTimeKind.Unspecified).AddTicks(8553), new TimeSpan(0, -8, 0, 0, 0)), new Guid("e6f3ec5d-48ab-4453-ab13-c1c349ffb8e4"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(119), new TimeSpan(0, -8, 0, 0, 0)), new Guid("5973fb2f-3f78-448f-b54c-601894801fa8"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 147, DateTimeKind.Unspecified).AddTicks(8292), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, -8, 0, 0, 0)), new Guid("f575801a-fcc1-45a5-a4f1-11e7e6bf84af"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(16), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(2255), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ce95edcc-40e6-42f3-bf97-1604aee43ecb"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(16), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(2263), new TimeSpan(0, -8, 0, 0, 0)), new Guid("81570b73-c458-4c32-9e67-fb2527c91c12"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(16), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(2296), new TimeSpan(0, -8, 0, 0, 0)), new Guid("ab0c20d6-0352-443b-9e0a-36f2d5837e64"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(16), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(2300), new TimeSpan(0, -8, 0, 0, 0)), new Guid("3b075ba8-4cd0-463d-a7a6-d3ce88c1ce35"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(16), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(2303), new TimeSpan(0, -8, 0, 0, 0)), new Guid("f1e0bc6c-1fd8-426f-abcd-5ecb2f479fc0"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(16), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(3973), new TimeSpan(0, -8, 0, 0, 0)), new Guid("e04d681a-8a70-49ea-a427-923384b50198"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(1730), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(5011), new TimeSpan(0, -8, 0, 0, 0)), new Guid("a05398e8-e69c-4a16-a573-33da6494f81f"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(3339), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(6159), new TimeSpan(0, -8, 0, 0, 0)), new Guid("d3497535-fc46-47eb-9f0d-cb806f16e005"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(4940), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(6335), new TimeSpan(0, -8, 0, 0, 0)), new Guid("84d19c8f-cdba-496e-ac13-404eebbf9445"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(4940), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), new Guid("a7179ed7-a8d6-496f-8ee3-41dd80a8c033"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(8883), new TimeSpan(0, -8, 0, 0, 0)), new Guid("0630d4a2-4137-4cc3-94e9-9b16c8c86b11"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(8891), new TimeSpan(0, -8, 0, 0, 0)), new Guid("24bcea23-bd7a-4ede-9070-1d916ef76a35"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(8895), new TimeSpan(0, -8, 0, 0, 0)), new Guid("00a53409-7ebd-4b45-9810-e8f6cf5b3280"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 752, DateTimeKind.Unspecified).AddTicks(8899), new TimeSpan(0, -8, 0, 0, 0)), new Guid("7874723c-37b5-4ab9-b29e-7234ac4b11c3"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(400), new TimeSpan(0, -8, 0, 0, 0)), new Guid("4b9efe64-c9db-4781-b644-b8e7d80ddf4b"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(8397), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(408), new TimeSpan(0, -8, 0, 0, 0)), new Guid("38ee0683-4fb8-4b31-bc64-bbb232d8e338"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(8397), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(411), new TimeSpan(0, -8, 0, 0, 0)), new Guid("763de082-ee01-4c85-8f85-b8d7e1c07c63"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(8397), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(418), new TimeSpan(0, -8, 0, 0, 0)), new Guid("e695999c-4804-41b3-afeb-a9bebb469e29"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 148, DateTimeKind.Unspecified).AddTicks(8397), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(3744), new TimeSpan(0, -8, 0, 0, 0)), new Guid("a5d386fc-e8d9-42ef-9704-673fe312d4af"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(392), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(3779), new TimeSpan(0, -8, 0, 0, 0)), new Guid("97d09cd3-bc21-4020-b9bd-ff5a136b877b"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(392), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(5579), new TimeSpan(0, -8, 0, 0, 0)), new Guid("f0872738-815a-40ce-ac7a-ad9f13281d82"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(3853), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(5589), new TimeSpan(0, -8, 0, 0, 0)), new Guid("77733e68-ed17-4f8a-b124-3741318a8e49"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(3853), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(5593), new TimeSpan(0, -8, 0, 0, 0)), new Guid("1f6fe3be-d570-4004-8700-228685b11396"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(3853), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 753, DateTimeKind.Unspecified).AddTicks(5598), new TimeSpan(0, -8, 0, 0, 0)), new Guid("5ec0ad0d-34ad-4f9c-bbc7-906fb05ed795"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 149, DateTimeKind.Unspecified).AddTicks(3853), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(137), new TimeSpan(0, -8, 0, 0, 0)), new Guid("dcf284c9-d599-4b5a-81b5-baf9ee491bb8"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(457), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(580), new TimeSpan(0, -8, 0, 0, 0)), new Guid("d99793a0-968e-4c59-b6ad-8054fd939dd9"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(457), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(665), new TimeSpan(0, -8, 0, 0, 0)), new Guid("07b6bfc8-9753-40e5-8720-a3de38d7f878"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(457), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(670), new TimeSpan(0, -8, 0, 0, 0)), new Guid("d13db17d-909e-4f43-8fb3-68f29873f835"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(457), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(674), new TimeSpan(0, -8, 0, 0, 0)), new Guid("153909c8-cb4a-4e1b-aa6c-f9f1b9ff7acc"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(457), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(2355), new TimeSpan(0, -8, 0, 0, 0)), new Guid("1c05eb00-71cc-41cf-87f0-029f413138de"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(2994), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(2578), new TimeSpan(0, -8, 0, 0, 0)), new Guid("3ddba966-1cc2-4957-b4f3-e4beddaf3b52"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(2994), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(4647), new TimeSpan(0, -8, 0, 0, 0)), new Guid("336e3f3d-1aa8-415b-82fd-cb34ff2af06d"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(5209), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(4866), new TimeSpan(0, -8, 0, 0, 0)), new Guid("db8b8799-b102-488b-b35c-f35af55feecf"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(5209), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(4872), new TimeSpan(0, -8, 0, 0, 0)), new Guid("fefd4aa0-2aa0-44d4-b060-a8b6091f4930"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(5209), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(4876), new TimeSpan(0, -8, 0, 0, 0)), new Guid("eb79d5ed-2f53-4929-82c7-d2276c12708d"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(5209), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 748, DateTimeKind.Unspecified).AddTicks(6257), new TimeSpan(0, -8, 0, 0, 0)), new Guid("311366d0-0e91-4ebf-bc02-5b9f7f7ca81c"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 150, DateTimeKind.Unspecified).AddTicks(6979), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(514), new TimeSpan(0, -8, 0, 0, 0)), new Guid("00d8d31b-015a-40d7-a13a-03619a8cd77b"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(1311), new TimeSpan(0, -8, 0, 0, 0)), new Guid("9bdaa144-5eb7-44ed-bce0-a9e06528bb87"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(4957), new TimeSpan(0, -8, 0, 0, 0)), new Guid("a2a99886-eaff-40c5-84b1-cbef7dd583ef"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(5545), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(6088), new TimeSpan(0, -8, 0, 0, 0)), new Guid("826a3e94-118b-4ad1-9c0f-c615f72e118b"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(7619), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(6097), new TimeSpan(0, -8, 0, 0, 0)), new Guid("faa3104f-4c6c-4e88-88b8-d43349ce4606"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(7619), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(7091), new TimeSpan(0, -8, 0, 0, 0)), new Guid("cfd34c71-b30d-4a23-beca-9ded173a54b7"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(9651), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(7099), new TimeSpan(0, -8, 0, 0, 0)), new Guid("9992522e-8df0-4bd2-baaf-eeb63121a23c"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 151, DateTimeKind.Unspecified).AddTicks(9651), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(7957), new TimeSpan(0, -8, 0, 0, 0)), new Guid("cfc5b093-9e4e-4e77-9336-79113bc28f0d"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 152, DateTimeKind.Unspecified).AddTicks(1711), new TimeSpan(0, -8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord", "LastModified" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 7, 747, DateTimeKind.Unspecified).AddTicks(7967), new TimeSpan(0, -8, 0, 0, 0)), new Guid("9ac193d9-6bae-4cf3-b73c-ab9d05990a32"), new DateTimeOffset(new DateTime(2024, 1, 7, 11, 1, 8, 152, DateTimeKind.Unspecified).AddTicks(1711), new TimeSpan(0, -8, 0, 0, 0)) });
        }
    }
}
