using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUserFromEndorsment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "L_EndorsementUser",
                schema: "Links");

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserPosition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("66552b0d-cd96-4733-94c0-e1ef20388a3c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f498886d-96f8-4ea8-a839-b54756324c60"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserPosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 60, DateTimeKind.Unspecified).AddTicks(3854), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 794, DateTimeKind.Unspecified).AddTicks(9800), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserLocation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("2b50bc14-833a-4758-add9-07ddf298db55"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e3d123d7-775a-4a15-afbf-63ff9dbf8d3b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserLocation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 60, DateTimeKind.Unspecified).AddTicks(1649), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 794, DateTimeKind.Unspecified).AddTicks(7530), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_RolePosition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9de97880-1241-4d56-a50d-cf4a30b35d66"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e7517ace-2660-4a68-8692-58743af961dd"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_RolePosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 59, DateTimeKind.Unspecified).AddTicks(9462), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 794, DateTimeKind.Unspecified).AddTicks(5301), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("84b61d8b-1f73-4818-aefc-b105c3831dde"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b79c0a08-9cc1-450c-b8b4-f8c9ac52123a"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 59, DateTimeKind.Unspecified).AddTicks(7259), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 794, DateTimeKind.Unspecified).AddTicks(3057), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("3ab7327e-a335-4758-9bbf-1b48e4d9d6c1"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5e0b4b1b-293f-454f-9bc7-d045cbfac6aa"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 59, DateTimeKind.Unspecified).AddTicks(5034), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 793, DateTimeKind.Unspecified).AddTicks(8525), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e9f47db3-a30f-4089-8fa5-7209d5ab8774"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("974ee5e5-5cd2-4e56-981e-3003c295e365"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 59, DateTimeKind.Unspecified).AddTicks(2391), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 793, DateTimeKind.Unspecified).AddTicks(6213), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9edee2c8-9e41-4a3f-b7a9-2a1c29b8bb04"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5086ff5a-93d9-4988-b881-26bd75472763"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 58, DateTimeKind.Unspecified).AddTicks(9930), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 793, DateTimeKind.Unspecified).AddTicks(4092), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("864fb316-d300-4bad-b8ad-54cca57b6ccd"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("228183ba-b63c-4c91-a16f-54be0251eaaa"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 58, DateTimeKind.Unspecified).AddTicks(7579), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 793, DateTimeKind.Unspecified).AddTicks(2006), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c147e86d-985e-4627-9214-b65d0e19c0e3"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ae0fc1d2-250d-4dce-8fa5-4a1adc268358"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 58, DateTimeKind.Unspecified).AddTicks(5723), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 793, DateTimeKind.Unspecified).AddTicks(377), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Endorsement",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("cd200f76-1b5e-4280-988f-6e1525e06611"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("22ad6cc9-3bc1-4c67-ab87-a99c050c044a"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Endorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 58, DateTimeKind.Unspecified).AddTicks(3410), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 792, DateTimeKind.Unspecified).AddTicks(8366), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5cf545b3-465b-4b82-9f1d-e674a4aff4aa"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b7bbfe14-09c2-4210-b6b1-84b3decef4ed"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 58, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 792, DateTimeKind.Unspecified).AddTicks(6011), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1271bbc0-7c9b-476f-8222-41883c2d4e86"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("2f0082dd-2a5b-4ebb-b98e-f3dd37cf4268"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 57, DateTimeKind.Unspecified).AddTicks(7820), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 792, DateTimeKind.Unspecified).AddTicks(3454), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("116582ab-a4cd-4454-9566-bbc51115bd1b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("67394e1a-0216-44e6-acbe-6f31e96f8244"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 57, DateTimeKind.Unspecified).AddTicks(5460), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 792, DateTimeKind.Unspecified).AddTicks(1385), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("72f6fc14-bf4c-4611-afde-3307d732ca1a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1563f35e-57ff-4f98-8612-78bb417b4af1"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 57, DateTimeKind.Unspecified).AddTicks(3735), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 791, DateTimeKind.Unspecified).AddTicks(9892), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("9e4ecf86-c309-41e7-91dc-2f662b50d661"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("bb212183-2a58-42d8-91e6-e549afdaceda"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 57, DateTimeKind.Unspecified).AddTicks(2005), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 791, DateTimeKind.Unspecified).AddTicks(8398), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("afa1aa7f-2b80-410f-a2ae-302ee8558251"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8bb41adf-7a9e-4164-a4dc-ca125b5ac199"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 57, DateTimeKind.Unspecified).AddTicks(19), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 791, DateTimeKind.Unspecified).AddTicks(6672), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("41adfd0a-7c01-47b6-97ef-6fa6817c04a8"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("07e778ca-f227-4962-8273-fd9ec427a270"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 56, DateTimeKind.Unspecified).AddTicks(7821), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 791, DateTimeKind.Unspecified).AddTicks(4844), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("2203c392-f635-4920-829b-8481fc9e51e6"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("73e83fa3-fcee-42fe-9e38-06793caf9d2d"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 56, DateTimeKind.Unspecified).AddTicks(5618), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 791, DateTimeKind.Unspecified).AddTicks(3287), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1cba2ced-606f-4251-9513-1aad9552e345"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("79f33075-ba72-49c3-b73c-b9b92e698e75"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 56, DateTimeKind.Unspecified).AddTicks(3693), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 791, DateTimeKind.Unspecified).AddTicks(1697), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("31c255ca-0c6d-498a-aff1-8352b62ad3d7"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e86e287b-70ce-4e1d-8fd9-69a972bbc8d1"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 56, DateTimeKind.Unspecified).AddTicks(1893), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 791, DateTimeKind.Unspecified).AddTicks(193), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("560b9ace-93ed-4aca-8998-fdb71e5b9b39"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5d7c6e57-7e06-4ac1-8aaa-341cf7c0efa4"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 56, DateTimeKind.Unspecified).AddTicks(124), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 790, DateTimeKind.Unspecified).AddTicks(8745), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("71a6d22a-d721-4706-8d8c-208a56b05d03"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("dac5a85f-ce55-4b44-a0fc-5c541a127167"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 55, DateTimeKind.Unspecified).AddTicks(8309), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 790, DateTimeKind.Unspecified).AddTicks(7243), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b214ba30-71cf-477a-8e79-8efcfe3959f9"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("18cc2788-a9a5-421f-8416-0c7ea0ae2c55"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 55, DateTimeKind.Unspecified).AddTicks(6449), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 790, DateTimeKind.Unspecified).AddTicks(5692), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("064b5704-cbfe-4523-b91a-eebbef55c94f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("71788e2f-0626-4f45-aa02-d1c73da43819"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 55, DateTimeKind.Unspecified).AddTicks(4436), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 790, DateTimeKind.Unspecified).AddTicks(4008), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("28862583-add1-4a21-8791-f1fa9a179f41"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("dea5b250-257d-424f-9313-94a551db45de"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 55, DateTimeKind.Unspecified).AddTicks(2343), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 790, DateTimeKind.Unspecified).AddTicks(2308), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 697, DateTimeKind.Unspecified).AddTicks(599), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2e683d91-d2e3-4114-ac2f-d310122b3fc7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 697, DateTimeKind.Unspecified).AddTicks(605), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a2d286d3-a90e-4579-be04-5ef22f9b12ea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 697, DateTimeKind.Unspecified).AddTicks(608), new TimeSpan(0, 3, 30, 0, 0)), new Guid("346bb42e-df1d-485f-b3c4-c6330f9c244d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 697, DateTimeKind.Unspecified).AddTicks(611), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b8d9689b-7b0c-4b85-b25d-62792609f343") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 697, DateTimeKind.Unspecified).AddTicks(613), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eb0c7217-20df-47ad-96ad-83f099fb88a0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 698, DateTimeKind.Unspecified).AddTicks(1012), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8782f0ec-99e8-4d5a-8a1c-724882467e62") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(588), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fcf0e5b5-e3ed-45bd-8c07-9065380996e6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(617), new TimeSpan(0, 3, 30, 0, 0)), new Guid("86e8c258-0a8b-4738-90e4-eae0e9b9605b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(630), new TimeSpan(0, 3, 30, 0, 0)), new Guid("47192768-c380-46c2-8f80-172281dd89b2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(636), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cc0b7879-9cb5-40bb-87ba-41752d282768") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(668), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e31acff0-4dd8-46bc-ae66-5f3541a13ad3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(674), new TimeSpan(0, 3, 30, 0, 0)), new Guid("77bbe7da-53ab-4930-8872-906f1cb98004") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(691), new TimeSpan(0, 3, 30, 0, 0)), new Guid("763c5ea5-dc0e-42af-8e3b-15e4d80ab409") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(696), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c847d3a1-d6b6-4610-a1b0-9a4d22bb2ae1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(701), new TimeSpan(0, 3, 30, 0, 0)), new Guid("955d81b1-661e-43e9-ac5a-03a717ba08c6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(706), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f53d01ca-c955-4554-8320-1f7d4b9f2780") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(714), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c45a8679-127e-41f8-83ac-88cedb5a37e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(719), new TimeSpan(0, 3, 30, 0, 0)), new Guid("74a5b847-e447-4dcf-88cc-b6e15e6f07a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(730), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0d817f9a-08ec-4adb-bcda-ed8fe008c4de") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(736), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5a7ee702-5e4f-49fb-9ed7-19b8c0e28446") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(742), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7145994a-ad6b-4782-b08b-a6767791e8d7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 3, 30, 0, 0)), new Guid("08ae468d-8383-488f-9ad7-827e9d3982ed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(751), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1340fdab-66e7-4bef-b3db-6ee636f21e72") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(756), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5b249370-e46e-48f6-b4e4-fe01df833493") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(762), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5760cbd5-c70d-4a06-82c2-b520409537f5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(1879), new TimeSpan(0, 3, 30, 0, 0)), new Guid("07495f9d-9b6e-48df-af3b-dee3c36d23c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(3544), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2e6f1a33-5b69-4e8a-a0f0-b6c043a241be") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(3550), new TimeSpan(0, 3, 30, 0, 0)), new Guid("93e914f0-9cf3-441f-9b17-4796f8034213") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(3552), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8740736a-732c-47ba-988a-ba3ff86e8b4f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(3554), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a70c2a81-b4f0-4d22-b16f-6189066eb095") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(3557), new TimeSpan(0, 3, 30, 0, 0)), new Guid("94ab1d91-42ee-4d14-8008-5172d112dea5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(3559), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bed84c7b-000c-4e33-a1b8-6b2ab213e5e2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(4827), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2b18d550-4004-4be0-80cc-73f1896731d6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(5652), new TimeSpan(0, 3, 30, 0, 0)), new Guid("32de882f-2673-4b4f-ae0f-3bfac4f2898f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(6530), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b6afd3d7-3287-43f3-8438-b20107306b2b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(6663), new TimeSpan(0, 3, 30, 0, 0)), new Guid("212b39ae-69fb-4049-92c5-270147fe4fbc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(8427), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3025e96a-3dc8-418f-b079-566058c0d2f0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(8720), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1167f320-a849-4dca-9cf8-0599aade8c65") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(8725), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c125eae7-26d0-46cf-be46-bbb8c3296b72") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(8728), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a80ba139-4667-49ff-a811-f4890c0d8c01") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(8735), new TimeSpan(0, 3, 30, 0, 0)), new Guid("26b0d8a6-d54d-4a3c-b9df-e50a735b2933") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(9882), new TimeSpan(0, 3, 30, 0, 0)), new Guid("02bd80d8-9695-4602-96d3-2792eae3dfd4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(9888), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fe220558-752c-457c-b56e-292699c64558") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(9891), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fa469ac3-671d-4f32-ae3d-27b384cdb16f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 699, DateTimeKind.Unspecified).AddTicks(9894), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d30e13d2-2d14-4f76-80be-902f46e5886f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 700, DateTimeKind.Unspecified).AddTicks(2383), new TimeSpan(0, 3, 30, 0, 0)), new Guid("68d09bb6-c84a-4882-be03-1d31d02ac91b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 700, DateTimeKind.Unspecified).AddTicks(2412), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b07531c8-202f-4bf3-9814-6cf4f2a6d864") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 700, DateTimeKind.Unspecified).AddTicks(3696), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b05edfb0-fcc2-41ab-a9dc-42029d1d8c10") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 700, DateTimeKind.Unspecified).AddTicks(3706), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d9bf5dd1-e531-4363-8e9c-4172e51065df") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 700, DateTimeKind.Unspecified).AddTicks(3709), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1b2ace3c-d15e-4983-853c-762ce75e1bd1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 700, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 3, 30, 0, 0)), new Guid("42a76d1d-5918-43b0-9644-6023f00faf44") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 696, DateTimeKind.Unspecified).AddTicks(3534), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4ccd0c1c-dee9-49da-b889-041c69a53360") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 696, DateTimeKind.Unspecified).AddTicks(3954), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c636566d-9db3-4e36-915b-f2817bfacf12") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 696, DateTimeKind.Unspecified).AddTicks(4032), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fbb9c33d-cfbc-4f4f-b977-a0d6c2fbd38f") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 696, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b2dce714-f640-42f2-a1d4-f439c865b5be") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 696, DateTimeKind.Unspecified).AddTicks(4044), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3779ed12-4f3f-435b-9fbd-5180557daffa") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 696, DateTimeKind.Unspecified).AddTicks(5458), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2f1571e9-9603-4d60-9c8d-86e155d22c2c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 696, DateTimeKind.Unspecified).AddTicks(5671), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f57a024f-a4f1-49db-83d7-e76916e52680") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 696, DateTimeKind.Unspecified).AddTicks(7888), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aff33108-2060-46ba-8a80-a7b70087566a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 696, DateTimeKind.Unspecified).AddTicks(8116), new TimeSpan(0, 3, 30, 0, 0)), new Guid("537badfb-77bd-4cdd-986d-dfa18c43c7bf") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 696, DateTimeKind.Unspecified).AddTicks(8122), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ea3b2269-4547-4d6e-9552-97c8ba6d32d4") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 696, DateTimeKind.Unspecified).AddTicks(8156), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7ab7dfd3-8900-440d-90b6-567e91f43817") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 696, DateTimeKind.Unspecified).AddTicks(9214), new TimeSpan(0, 3, 30, 0, 0)), new Guid("59abddd1-1917-4adf-a342-5a043c63bf96") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 695, DateTimeKind.Unspecified).AddTicks(4215), new TimeSpan(0, 3, 30, 0, 0)), new Guid("84702674-c08c-4d20-bc1b-6604fdb8a437") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 695, DateTimeKind.Unspecified).AddTicks(4931), new TimeSpan(0, 3, 30, 0, 0)), new Guid("421fc347-93b9-44f4-b60a-1983c753dc55") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 695, DateTimeKind.Unspecified).AddTicks(8471), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d890123d-6a38-48b2-b620-19145523e0e4") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 695, DateTimeKind.Unspecified).AddTicks(9562), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a75519a0-4d65-4f67-92f3-e4a6e071cbb2") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 695, DateTimeKind.Unspecified).AddTicks(9569), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a3dca024-0af9-4d9b-9203-6fa99f2c8561") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 696, DateTimeKind.Unspecified).AddTicks(485), new TimeSpan(0, 3, 30, 0, 0)), new Guid("702a06cb-d878-44d5-b4f8-946c02dee162") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 696, DateTimeKind.Unspecified).AddTicks(491), new TimeSpan(0, 3, 30, 0, 0)), new Guid("273e42c4-3367-4a34-8376-47188b6a70d3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 696, DateTimeKind.Unspecified).AddTicks(1353), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2fbd3566-65b4-41ea-aff5-d71310371d82") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 29, 696, DateTimeKind.Unspecified).AddTicks(1359), new TimeSpan(0, 3, 30, 0, 0)), new Guid("70156d34-2320-4d65-bb93-cbc3e6ee27fa") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserPosition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f498886d-96f8-4ea8-a839-b54756324c60"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("66552b0d-cd96-4733-94c0-e1ef20388a3c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserPosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 794, DateTimeKind.Unspecified).AddTicks(9800), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 60, DateTimeKind.Unspecified).AddTicks(3854), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserLocation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e3d123d7-775a-4a15-afbf-63ff9dbf8d3b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("2b50bc14-833a-4758-add9-07ddf298db55"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserLocation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 794, DateTimeKind.Unspecified).AddTicks(7530), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 60, DateTimeKind.Unspecified).AddTicks(1649), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_RolePosition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e7517ace-2660-4a68-8692-58743af961dd"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9de97880-1241-4d56-a50d-cf4a30b35d66"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_RolePosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 794, DateTimeKind.Unspecified).AddTicks(5301), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 59, DateTimeKind.Unspecified).AddTicks(9462), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b79c0a08-9cc1-450c-b8b4-f8c9ac52123a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("84b61d8b-1f73-4818-aefc-b105c3831dde"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 794, DateTimeKind.Unspecified).AddTicks(3057), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 59, DateTimeKind.Unspecified).AddTicks(7259), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5e0b4b1b-293f-454f-9bc7-d045cbfac6aa"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("3ab7327e-a335-4758-9bbf-1b48e4d9d6c1"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 793, DateTimeKind.Unspecified).AddTicks(8525), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 59, DateTimeKind.Unspecified).AddTicks(5034), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("974ee5e5-5cd2-4e56-981e-3003c295e365"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("e9f47db3-a30f-4089-8fa5-7209d5ab8774"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 793, DateTimeKind.Unspecified).AddTicks(6213), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 59, DateTimeKind.Unspecified).AddTicks(2391), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5086ff5a-93d9-4988-b881-26bd75472763"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9edee2c8-9e41-4a3f-b7a9-2a1c29b8bb04"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 793, DateTimeKind.Unspecified).AddTicks(4092), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 58, DateTimeKind.Unspecified).AddTicks(9930), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("228183ba-b63c-4c91-a16f-54be0251eaaa"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("864fb316-d300-4bad-b8ad-54cca57b6ccd"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 793, DateTimeKind.Unspecified).AddTicks(2006), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 58, DateTimeKind.Unspecified).AddTicks(7579), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ae0fc1d2-250d-4dce-8fa5-4a1adc268358"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c147e86d-985e-4627-9214-b65d0e19c0e3"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 793, DateTimeKind.Unspecified).AddTicks(377), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 58, DateTimeKind.Unspecified).AddTicks(5723), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Endorsement",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("22ad6cc9-3bc1-4c67-ab87-a99c050c044a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("cd200f76-1b5e-4280-988f-6e1525e06611"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Endorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 792, DateTimeKind.Unspecified).AddTicks(8366), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 58, DateTimeKind.Unspecified).AddTicks(3410), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b7bbfe14-09c2-4210-b6b1-84b3decef4ed"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5cf545b3-465b-4b82-9f1d-e674a4aff4aa"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 792, DateTimeKind.Unspecified).AddTicks(6011), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 58, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("2f0082dd-2a5b-4ebb-b98e-f3dd37cf4268"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1271bbc0-7c9b-476f-8222-41883c2d4e86"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 792, DateTimeKind.Unspecified).AddTicks(3454), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 57, DateTimeKind.Unspecified).AddTicks(7820), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("67394e1a-0216-44e6-acbe-6f31e96f8244"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("116582ab-a4cd-4454-9566-bbc51115bd1b"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 792, DateTimeKind.Unspecified).AddTicks(1385), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 57, DateTimeKind.Unspecified).AddTicks(5460), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("1563f35e-57ff-4f98-8612-78bb417b4af1"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("72f6fc14-bf4c-4611-afde-3307d732ca1a"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 791, DateTimeKind.Unspecified).AddTicks(9892), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 57, DateTimeKind.Unspecified).AddTicks(3735), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("bb212183-2a58-42d8-91e6-e549afdaceda"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("9e4ecf86-c309-41e7-91dc-2f662b50d661"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 791, DateTimeKind.Unspecified).AddTicks(8398), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 57, DateTimeKind.Unspecified).AddTicks(2005), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8bb41adf-7a9e-4164-a4dc-ca125b5ac199"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("afa1aa7f-2b80-410f-a2ae-302ee8558251"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_User",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 791, DateTimeKind.Unspecified).AddTicks(6672), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 57, DateTimeKind.Unspecified).AddTicks(19), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("07e778ca-f227-4962-8273-fd9ec427a270"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("41adfd0a-7c01-47b6-97ef-6fa6817c04a8"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 791, DateTimeKind.Unspecified).AddTicks(4844), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 56, DateTimeKind.Unspecified).AddTicks(7821), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("73e83fa3-fcee-42fe-9e38-06793caf9d2d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("2203c392-f635-4920-829b-8481fc9e51e6"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 791, DateTimeKind.Unspecified).AddTicks(3287), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 56, DateTimeKind.Unspecified).AddTicks(5618), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("79f33075-ba72-49c3-b73c-b9b92e698e75"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("1cba2ced-606f-4251-9513-1aad9552e345"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 791, DateTimeKind.Unspecified).AddTicks(1697), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 56, DateTimeKind.Unspecified).AddTicks(3693), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("e86e287b-70ce-4e1d-8fd9-69a972bbc8d1"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("31c255ca-0c6d-498a-aff1-8352b62ad3d7"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 791, DateTimeKind.Unspecified).AddTicks(193), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 56, DateTimeKind.Unspecified).AddTicks(1893), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5d7c6e57-7e06-4ac1-8aaa-341cf7c0efa4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("560b9ace-93ed-4aca-8998-fdb71e5b9b39"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 790, DateTimeKind.Unspecified).AddTicks(8745), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 56, DateTimeKind.Unspecified).AddTicks(124), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("dac5a85f-ce55-4b44-a0fc-5c541a127167"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("71a6d22a-d721-4706-8d8c-208a56b05d03"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 790, DateTimeKind.Unspecified).AddTicks(7243), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 55, DateTimeKind.Unspecified).AddTicks(8309), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("18cc2788-a9a5-421f-8416-0c7ea0ae2c55"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b214ba30-71cf-477a-8e79-8efcfe3959f9"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 790, DateTimeKind.Unspecified).AddTicks(5692), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 55, DateTimeKind.Unspecified).AddTicks(6449), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("71788e2f-0626-4f45-aa02-d1c73da43819"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("064b5704-cbfe-4523-b91a-eebbef55c94f"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 790, DateTimeKind.Unspecified).AddTicks(4008), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 55, DateTimeKind.Unspecified).AddTicks(4436), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("dea5b250-257d-424f-9313-94a551db45de"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("28862583-add1-4a21-8791-f1fa9a179f41"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 790, DateTimeKind.Unspecified).AddTicks(2308), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 9, 0, 19, 30, 55, DateTimeKind.Unspecified).AddTicks(2343), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.CreateTable(
                name: "L_EndorsementUser",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 794, DateTimeKind.Unspecified).AddTicks(814), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("d542aaf7-98bd-46f4-bfcc-8c33d415883e")),
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
                    table.PrimaryKey("PK_L_EndorsementUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_EndorsementUser_D_User_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_EndorsementUser_F_Endorsement_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 413, DateTimeKind.Unspecified).AddTicks(3996), new TimeSpan(0, 3, 30, 0, 0)), new Guid("532f56e5-475d-4020-bd57-05f13f9855b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 413, DateTimeKind.Unspecified).AddTicks(4002), new TimeSpan(0, 3, 30, 0, 0)), new Guid("904edf7c-bc41-44c1-9fdb-ff6d92e3d6b3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 413, DateTimeKind.Unspecified).AddTicks(4004), new TimeSpan(0, 3, 30, 0, 0)), new Guid("177f0fee-4d13-426b-92d0-90d8067cfa6b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 413, DateTimeKind.Unspecified).AddTicks(4006), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a6e58368-0aab-43ac-877d-fe07eba0211e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 413, DateTimeKind.Unspecified).AddTicks(4009), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7c92e1d5-8e92-4d9d-a396-6d6f097c33f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 414, DateTimeKind.Unspecified).AddTicks(4497), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6cf5b2c2-a5b1-4c8f-b5f5-40184c460b1d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(3853), new TimeSpan(0, 3, 30, 0, 0)), new Guid("37e162bd-cfe9-47b1-9c59-6289a05560a7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(3884), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3cfc371c-9f4a-4b8b-b11f-3a6db3b97dbd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(3891), new TimeSpan(0, 3, 30, 0, 0)), new Guid("023dbff6-7cfa-4882-a45b-f21282a84adc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(3897), new TimeSpan(0, 3, 30, 0, 0)), new Guid("273de045-1040-4e2d-abf7-714debf18ea7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(3902), new TimeSpan(0, 3, 30, 0, 0)), new Guid("091bf16f-17b8-427a-8386-d567918dc02e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(3907), new TimeSpan(0, 3, 30, 0, 0)), new Guid("621ed103-c28c-4b80-9e35-06b820d35c7a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(3950), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6c2500ec-121a-45f6-a413-5922de6fd703") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(3955), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6936b26c-c89d-4e23-ac6e-36f76de015cb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(3960), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a9d3c4f6-d6c5-46c0-bf0e-7902aa17bc2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(3968), new TimeSpan(0, 3, 30, 0, 0)), new Guid("96fbc2df-f626-40d7-90d8-c9b4637687af") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(3973), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f37d1fe3-4e7a-4a2c-b29d-2fa9b3638af9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(3977), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e9398728-3e16-49f9-a017-4fa0be0d3f08") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(3989), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1de01c61-5190-4bbd-b974-3a738541c7d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(3994), new TimeSpan(0, 3, 30, 0, 0)), new Guid("523a5e9b-e5a2-4ff3-9ba7-e0500f20adb9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(3998), new TimeSpan(0, 3, 30, 0, 0)), new Guid("80babdf1-7855-49fe-aee5-24b65dd803e0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(4003), new TimeSpan(0, 3, 30, 0, 0)), new Guid("baf8e3f1-39cf-4f47-aa80-02ec3f954358") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(4007), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ae5d8bd9-26f1-47aa-95a2-b4c3d6156354") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(4014), new TimeSpan(0, 3, 30, 0, 0)), new Guid("37598e48-fa5f-4368-baf2-562c899d0eed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(4018), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2f4d1bc1-77e0-4574-81d6-8cf3280a860b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(5117), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c37e8ea7-b372-4779-9b70-e855291cd6bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(6789), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d374214c-ac63-405a-9e8b-863cad74c3b0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(6796), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ca9af160-6f98-41e3-9f1d-b21072ebb518") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(6799), new TimeSpan(0, 3, 30, 0, 0)), new Guid("629241df-75fa-4325-aa15-c6736028093b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(6801), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ffd62638-5f5f-42ad-b04b-ec11b2ee2874") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(6803), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1a3f64f5-6282-472f-9f25-001f8fe24034") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(6809), new TimeSpan(0, 3, 30, 0, 0)), new Guid("df680fa7-7854-4dc0-a8d4-79c6d3485570") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 3, 30, 0, 0)), new Guid("602dc43d-b20d-4540-b7c6-e8b15a8120d3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(8840), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e9c4918a-d1c8-4419-a639-36d2c255d7ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(9725), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cba097e4-1e80-4e0f-8542-f79d032c4ce5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 415, DateTimeKind.Unspecified).AddTicks(9857), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4bcf0093-3b72-4590-b76c-1d5961cc02dc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 416, DateTimeKind.Unspecified).AddTicks(1576), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6e825142-c27f-4bc7-9185-d70c976aff6e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 416, DateTimeKind.Unspecified).AddTicks(1860), new TimeSpan(0, 3, 30, 0, 0)), new Guid("84191dd9-ea3c-439a-9430-e3939894b550") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 416, DateTimeKind.Unspecified).AddTicks(1865), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ac9f12e7-b06a-461b-981b-7f57c6f75ba4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 416, DateTimeKind.Unspecified).AddTicks(1872), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a5819e44-c6f1-498a-81bd-ea91f0c464ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 416, DateTimeKind.Unspecified).AddTicks(1874), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ae2e9277-fb02-491d-8ef2-85f11a5d409e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 416, DateTimeKind.Unspecified).AddTicks(3015), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e0f3e75a-046f-4a93-a8c8-68c695e7d42e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 416, DateTimeKind.Unspecified).AddTicks(3020), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a45d2594-de26-4c6d-b433-7149eacf3f78") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 416, DateTimeKind.Unspecified).AddTicks(3022), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1eadef24-1cdc-4e4b-a3ec-53e8e5cbe237") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 416, DateTimeKind.Unspecified).AddTicks(3025), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fbea3ada-29b7-43d5-9b6a-1f4b04d4f46f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 416, DateTimeKind.Unspecified).AddTicks(5465), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9542094f-2ca3-4872-842f-45ff4437233b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 416, DateTimeKind.Unspecified).AddTicks(5489), new TimeSpan(0, 3, 30, 0, 0)), new Guid("67b23255-2b42-4e31-bf05-2d70535cc552") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 416, DateTimeKind.Unspecified).AddTicks(6897), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9152ef19-cdcf-4906-9362-c72a67bda95a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 416, DateTimeKind.Unspecified).AddTicks(6905), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2033c3ee-dbb0-41b6-87b1-a22fc89db4b9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 416, DateTimeKind.Unspecified).AddTicks(6907), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a69babe3-f2f5-4e00-9711-f3f86ac63593") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 416, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9e48486e-0acc-446c-8768-6a089810fbe5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 412, DateTimeKind.Unspecified).AddTicks(6975), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4fb8d186-214d-4be8-9026-094ceee9a614") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 412, DateTimeKind.Unspecified).AddTicks(7394), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9370fc26-dd04-4587-b29b-a5f2b105b487") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 412, DateTimeKind.Unspecified).AddTicks(7472), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9f21ca9b-4c26-4072-8b0d-69e817f922f8") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 412, DateTimeKind.Unspecified).AddTicks(7481), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4d7d5f4f-2948-4bd1-bc2e-2598400c04ad") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 412, DateTimeKind.Unspecified).AddTicks(7485), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d41794c4-0b9c-4641-b544-1a8703cbd860") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 412, DateTimeKind.Unspecified).AddTicks(9121), new TimeSpan(0, 3, 30, 0, 0)), new Guid("010b8391-4d10-4b85-a37d-d5f489dc0ab1") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 412, DateTimeKind.Unspecified).AddTicks(9334), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5dd43ade-b490-46f6-b70f-30ab3eea9ae8") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 413, DateTimeKind.Unspecified).AddTicks(1360), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dfa54f8d-2a55-45d2-b72f-6bf94bf6e202") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 413, DateTimeKind.Unspecified).AddTicks(1566), new TimeSpan(0, 3, 30, 0, 0)), new Guid("87ad28fc-6f24-482b-8bfa-7e2127db1280") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 413, DateTimeKind.Unspecified).AddTicks(1571), new TimeSpan(0, 3, 30, 0, 0)), new Guid("896e4b8e-5d94-4bc6-afe6-48ebcc6450ea") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 413, DateTimeKind.Unspecified).AddTicks(1574), new TimeSpan(0, 3, 30, 0, 0)), new Guid("755ffad3-b3d7-498a-b828-cc9cdca48853") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 413, DateTimeKind.Unspecified).AddTicks(2637), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f90c9521-0611-4be2-91d1-f57776b2b85c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 411, DateTimeKind.Unspecified).AddTicks(7732), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8e4477f9-3f13-46d4-ac74-8f08a7d08698") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 411, DateTimeKind.Unspecified).AddTicks(8471), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e9370546-2457-4299-a7be-4d5d88ec1fc7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 412, DateTimeKind.Unspecified).AddTicks(1883), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4382d50a-7503-44a3-b56d-edd08fa563ba") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 412, DateTimeKind.Unspecified).AddTicks(2976), new TimeSpan(0, 3, 30, 0, 0)), new Guid("821fd0ba-ea9d-4e95-94aa-31ad2263f772") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 412, DateTimeKind.Unspecified).AddTicks(2992), new TimeSpan(0, 3, 30, 0, 0)), new Guid("78a94c25-cd16-4167-afaa-676a6be26946") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 412, DateTimeKind.Unspecified).AddTicks(3946), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8e767542-afb8-448d-bd46-637af1f7c647") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 412, DateTimeKind.Unspecified).AddTicks(3953), new TimeSpan(0, 3, 30, 0, 0)), new Guid("058c87c3-80ed-4476-82c0-d7149e052322") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 412, DateTimeKind.Unspecified).AddTicks(4779), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0841a95f-4cae-4332-8f81-20870ccd074f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 412, DateTimeKind.Unspecified).AddTicks(4785), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a2776f5-804e-488f-b6ce-6385f2555e8c") });

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_Created",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_EnableRecord",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_ERPCode",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_FifthId",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_FirstId",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_FourthId",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_LastModified",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_Name",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_SecondId",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_ThirdId",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "ThirdId",
                descending: new bool[0]);
        }
    }
}
