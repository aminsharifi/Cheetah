using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class cleanup : Migration
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
                defaultValue: new Guid("f498886d-96f8-4ea8-a839-b54756324c60"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("367d8311-d041-4d27-b06a-f2abbdd6ccf4"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 22, DateTimeKind.Unspecified).AddTicks(2974), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("8018dcc9-0c16-4c50-b3a3-26a5f8e57cd5"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 21, DateTimeKind.Unspecified).AddTicks(9534), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("5c3700fc-0151-44cd-9846-6be9849ec0a3"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 21, DateTimeKind.Unspecified).AddTicks(6090), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("6fde79d2-021f-4179-a147-e3dc45e9b575"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 21, DateTimeKind.Unspecified).AddTicks(2592), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d542aaf7-98bd-46f4-bfcc-8c33d415883e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d8c6e23a-9974-4636-acec-5c8c00bdd715"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 794, DateTimeKind.Unspecified).AddTicks(814), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 20, DateTimeKind.Unspecified).AddTicks(9142), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("bc5a134c-45d3-4409-b04d-f531c183c234"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 20, DateTimeKind.Unspecified).AddTicks(5691), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("5dbdbfa9-b453-4ed6-9511-76498e7f2483"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 20, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("9bcad471-a25d-430a-bb18-649b8ac3c575"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 19, DateTimeKind.Unspecified).AddTicks(8942), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("3a724e28-3db2-440c-be16-128950cf8be9"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 19, DateTimeKind.Unspecified).AddTicks(6308), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("0a91ba09-3d96-4125-bd6f-863581d4323c"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 19, DateTimeKind.Unspecified).AddTicks(3664), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("c3735f88-593d-4b6b-b581-c3ee4997590d"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 19, DateTimeKind.Unspecified).AddTicks(494), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("d84b8837-0f46-4fdc-a0d3-acea3c675478"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 18, DateTimeKind.Unspecified).AddTicks(6945), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("f9dc3ac1-8f60-4484-af76-7c818cd0892d"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 18, DateTimeKind.Unspecified).AddTicks(3792), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("2b9519aa-6ed3-47d9-94e9-d3736601b317"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 18, DateTimeKind.Unspecified).AddTicks(552), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("0cd4a6d7-7d71-4f1c-9880-9fe61956260b"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 17, DateTimeKind.Unspecified).AddTicks(8037), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("04163d6a-3472-4d6d-bfce-185e4311f960"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 17, DateTimeKind.Unspecified).AddTicks(6205), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("2fba6724-421e-4df2-8aec-15244b80376f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 17, DateTimeKind.Unspecified).AddTicks(3771), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("bb3f5fbc-83c4-4025-974c-c2e03120763f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 17, DateTimeKind.Unspecified).AddTicks(895), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("5e23276d-f71c-4c46-8a9d-c4ca725ef6bf"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 16, DateTimeKind.Unspecified).AddTicks(8947), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("b7844b7c-f670-4e79-ae16-824ae395a339"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 16, DateTimeKind.Unspecified).AddTicks(6332), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("80c3075d-c1f6-424e-b8ed-f6e1a313a254"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 16, DateTimeKind.Unspecified).AddTicks(4498), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("d822d114-adfd-4f4e-a1ea-25235240c347"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 16, DateTimeKind.Unspecified).AddTicks(2017), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("ba37ca72-7255-42da-87c2-19e27ead4603"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 16, DateTimeKind.Unspecified).AddTicks(154), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("24650267-616f-444e-b4fe-9f2fa05876cb"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 15, DateTimeKind.Unspecified).AddTicks(7604), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("586a60a2-b206-4a75-b244-a0e2d35cb6bb"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 15, DateTimeKind.Unspecified).AddTicks(4929), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("6837b55b-db14-4e44-a1af-7dde6ba34232"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 15, DateTimeKind.Unspecified).AddTicks(2786), new TimeSpan(0, 3, 30, 0, 0)));

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
                defaultValue: new Guid("367d8311-d041-4d27-b06a-f2abbdd6ccf4"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 22, DateTimeKind.Unspecified).AddTicks(2974), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("8018dcc9-0c16-4c50-b3a3-26a5f8e57cd5"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 21, DateTimeKind.Unspecified).AddTicks(9534), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("5c3700fc-0151-44cd-9846-6be9849ec0a3"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 21, DateTimeKind.Unspecified).AddTicks(6090), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("6fde79d2-021f-4179-a147-e3dc45e9b575"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 21, DateTimeKind.Unspecified).AddTicks(2592), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 794, DateTimeKind.Unspecified).AddTicks(3057), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d8c6e23a-9974-4636-acec-5c8c00bdd715"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d542aaf7-98bd-46f4-bfcc-8c33d415883e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 20, DateTimeKind.Unspecified).AddTicks(9142), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 5, 4, 30, 794, DateTimeKind.Unspecified).AddTicks(814), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("bc5a134c-45d3-4409-b04d-f531c183c234"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 20, DateTimeKind.Unspecified).AddTicks(5691), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("5dbdbfa9-b453-4ed6-9511-76498e7f2483"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 20, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("9bcad471-a25d-430a-bb18-649b8ac3c575"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 19, DateTimeKind.Unspecified).AddTicks(8942), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("3a724e28-3db2-440c-be16-128950cf8be9"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 19, DateTimeKind.Unspecified).AddTicks(6308), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("0a91ba09-3d96-4125-bd6f-863581d4323c"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 19, DateTimeKind.Unspecified).AddTicks(3664), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("c3735f88-593d-4b6b-b581-c3ee4997590d"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 19, DateTimeKind.Unspecified).AddTicks(494), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("d84b8837-0f46-4fdc-a0d3-acea3c675478"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 18, DateTimeKind.Unspecified).AddTicks(6945), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("f9dc3ac1-8f60-4484-af76-7c818cd0892d"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 18, DateTimeKind.Unspecified).AddTicks(3792), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("2b9519aa-6ed3-47d9-94e9-d3736601b317"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 18, DateTimeKind.Unspecified).AddTicks(552), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("0cd4a6d7-7d71-4f1c-9880-9fe61956260b"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 17, DateTimeKind.Unspecified).AddTicks(8037), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("04163d6a-3472-4d6d-bfce-185e4311f960"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 17, DateTimeKind.Unspecified).AddTicks(6205), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("2fba6724-421e-4df2-8aec-15244b80376f"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 17, DateTimeKind.Unspecified).AddTicks(3771), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("bb3f5fbc-83c4-4025-974c-c2e03120763f"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 17, DateTimeKind.Unspecified).AddTicks(895), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("5e23276d-f71c-4c46-8a9d-c4ca725ef6bf"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 16, DateTimeKind.Unspecified).AddTicks(8947), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("b7844b7c-f670-4e79-ae16-824ae395a339"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 16, DateTimeKind.Unspecified).AddTicks(6332), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("80c3075d-c1f6-424e-b8ed-f6e1a313a254"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 16, DateTimeKind.Unspecified).AddTicks(4498), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("d822d114-adfd-4f4e-a1ea-25235240c347"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 16, DateTimeKind.Unspecified).AddTicks(2017), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("ba37ca72-7255-42da-87c2-19e27ead4603"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 16, DateTimeKind.Unspecified).AddTicks(154), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("24650267-616f-444e-b4fe-9f2fa05876cb"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 15, DateTimeKind.Unspecified).AddTicks(7604), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("586a60a2-b206-4a75-b244-a0e2d35cb6bb"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 15, DateTimeKind.Unspecified).AddTicks(4929), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("6837b55b-db14-4e44-a1af-7dde6ba34232"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 15, DateTimeKind.Unspecified).AddTicks(2786), new TimeSpan(0, 3, 30, 0, 0)),
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
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 533, DateTimeKind.Unspecified).AddTicks(5326), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e3c80f1a-4e79-4e82-9a4c-eff40958a8f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 533, DateTimeKind.Unspecified).AddTicks(5382), new TimeSpan(0, 3, 30, 0, 0)), new Guid("762d87a0-f6c4-495b-a6b8-5dc347ab1218") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 533, DateTimeKind.Unspecified).AddTicks(5387), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d5f2d52d-476d-4f2f-afa2-29729319c4dc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 533, DateTimeKind.Unspecified).AddTicks(5390), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b6439f08-ef2f-4329-84e2-c9ec56b2bc0d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 533, DateTimeKind.Unspecified).AddTicks(5392), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d799cbf2-5303-469e-a29d-169bc24956fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 534, DateTimeKind.Unspecified).AddTicks(7342), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3507465b-b10f-454e-91ff-2998382552d3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(90), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fab68177-8006-494a-963e-27b5caa0fbaf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(133), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1a7f8609-4dc6-418d-a2f3-22a0e4051a1f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(156), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fc6a9438-5f7d-41df-bec9-f6701f8c313a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(164), new TimeSpan(0, 3, 30, 0, 0)), new Guid("11994fa3-bbdc-4807-95ae-b55f66192770") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(171), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9ef79b4c-487b-4c50-b4ec-1b1deac08a6a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(178), new TimeSpan(0, 3, 30, 0, 0)), new Guid("736a1792-5087-4210-ba7a-01c390fa640f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(185), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ccc0ee54-f83a-4a30-a028-1933e44ca6dc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(190), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8be2aa66-f0a5-4c80-a68c-427b6abbd3ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(206), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f28188f5-a69a-437a-9f3c-504be627abc5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(216), new TimeSpan(0, 3, 30, 0, 0)), new Guid("34fa7e09-75d1-4e45-abda-5d9434c0343a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(260), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0777c865-623b-447d-aeab-95e80dc70457") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(266), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a3b42857-b505-4b23-90d8-c97976f3a762") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(273), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a57d60bc-000e-454f-9001-94ef88ff3e16") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(280), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f515c16e-6c5d-44fc-89e2-6526ba75b770") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(287), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8ca9609c-05bf-4ce5-be96-395d22d1c380") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(294), new TimeSpan(0, 3, 30, 0, 0)), new Guid("27f3c791-c176-4802-9bc2-ab1cf621e8a8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f58340cf-942d-483f-80d9-c31b662fbdc7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(307), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0d04c050-8fcc-4403-950b-c2b95142da36") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(314), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e7ca6f25-2289-43f5-b3f9-296f77b90f19") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(2128), new TimeSpan(0, 3, 30, 0, 0)), new Guid("48d11d8d-cf94-465f-9539-4003ea241815") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(4573), new TimeSpan(0, 3, 30, 0, 0)), new Guid("86036bb1-a065-41b2-9b14-37697a307576") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(4583), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4774ee75-99bb-4441-b1a2-fe912257e174") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(4586), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b7114145-583b-40fb-8d45-85ee4dce7ec9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(4589), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b7bf4415-36bb-40f7-a171-4b3f78098739") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(4592), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7353d49b-4d18-418e-8b59-4a53c23e69da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(4599), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f3949be9-4ed3-4401-a62e-b8d7673040bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(7398), new TimeSpan(0, 3, 30, 0, 0)), new Guid("41128533-3e02-4327-bd4a-3f683aa409ac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(8490), new TimeSpan(0, 3, 30, 0, 0)), new Guid("da6b9bd4-0f23-42c5-b9dd-71ad639c1929") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(9701), new TimeSpan(0, 3, 30, 0, 0)), new Guid("521c28be-4f09-47b3-91a2-bfa7724cfb7d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 536, DateTimeKind.Unspecified).AddTicks(9948), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3a264a0e-0d52-4700-a2b9-6329979fb229") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 537, DateTimeKind.Unspecified).AddTicks(2023), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9c9edc94-1d5d-45fa-a76c-9c01938b3598") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 537, DateTimeKind.Unspecified).AddTicks(2320), new TimeSpan(0, 3, 30, 0, 0)), new Guid("62bf38d1-8c3a-45c6-aff6-da4e42a18d76") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 537, DateTimeKind.Unspecified).AddTicks(2325), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eb2d1722-e261-4ecd-9e98-7b3b3721880d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 537, DateTimeKind.Unspecified).AddTicks(2329), new TimeSpan(0, 3, 30, 0, 0)), new Guid("27d8f32a-66be-4ab7-bf76-779c7693bd4a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 537, DateTimeKind.Unspecified).AddTicks(2332), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4376e548-ff5b-4eab-b2a5-3cd4b5245e6b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 537, DateTimeKind.Unspecified).AddTicks(3767), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5d89f2a8-d045-47cc-ac1f-cc02a6b04d66") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 537, DateTimeKind.Unspecified).AddTicks(3773), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2bab857d-c8fa-4864-ab7a-da50b378c398") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 537, DateTimeKind.Unspecified).AddTicks(3781), new TimeSpan(0, 3, 30, 0, 0)), new Guid("418a2eda-fbbb-44d2-bb7f-05227dab1985") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 537, DateTimeKind.Unspecified).AddTicks(3784), new TimeSpan(0, 3, 30, 0, 0)), new Guid("62268256-4bbe-45ce-b454-468f89dac378") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 537, DateTimeKind.Unspecified).AddTicks(6815), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d3f9b525-8b84-4074-bfb6-2a0bd086dc73") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 537, DateTimeKind.Unspecified).AddTicks(6848), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4f8b4587-7305-4078-9bb6-96c024221c6e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 537, DateTimeKind.Unspecified).AddTicks(8620), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e86537ae-6424-4ed9-92bd-25dc1785ad46") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 537, DateTimeKind.Unspecified).AddTicks(8627), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b8e22794-e0c1-4517-8477-06307de853c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 537, DateTimeKind.Unspecified).AddTicks(8630), new TimeSpan(0, 3, 30, 0, 0)), new Guid("954eec2b-6e2b-46cb-9e28-69ad9fc9f676") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 537, DateTimeKind.Unspecified).AddTicks(8633), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1ef9eec7-2772-4197-b7c3-4671eab5b13b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 532, DateTimeKind.Unspecified).AddTicks(6211), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e6ce3f0a-a8b4-4783-9886-9cf64a8f3dc9") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 532, DateTimeKind.Unspecified).AddTicks(6825), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2e61bdf2-8bf1-4d8d-82ab-cac99db7265e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 532, DateTimeKind.Unspecified).AddTicks(6921), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d4305e2a-895d-4acc-8753-94bdaf2d1269") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 532, DateTimeKind.Unspecified).AddTicks(6932), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3a0fa5b9-ad59-4923-af59-57a5f41b1a15") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 532, DateTimeKind.Unspecified).AddTicks(6985), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7d1dfe08-2367-4364-ae08-b8b11f1ba379") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 532, DateTimeKind.Unspecified).AddTicks(9051), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8d381ae9-80c7-4320-928c-23e9f0304867") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 532, DateTimeKind.Unspecified).AddTicks(9331), new TimeSpan(0, 3, 30, 0, 0)), new Guid("14abfd36-35d6-4564-9fd6-f8fba5ac03fb") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 533, DateTimeKind.Unspecified).AddTicks(1888), new TimeSpan(0, 3, 30, 0, 0)), new Guid("37e59658-7a46-47c7-8bd2-b0f30bddccfd") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 533, DateTimeKind.Unspecified).AddTicks(2242), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fe3f7dfd-f540-4ea3-be1f-982c715d3f84") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 533, DateTimeKind.Unspecified).AddTicks(2249), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1648acaa-9ec4-4f9b-9f05-81fe54573888") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 533, DateTimeKind.Unspecified).AddTicks(2254), new TimeSpan(0, 3, 30, 0, 0)), new Guid("066640c1-211e-40ff-867b-89d1885415cd") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 533, DateTimeKind.Unspecified).AddTicks(3604), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1ba99dea-7b13-4b32-acd4-e31520b7e26c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 531, DateTimeKind.Unspecified).AddTicks(2846), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ada5820a-1f43-4aea-be99-0d9934deb18f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 531, DateTimeKind.Unspecified).AddTicks(4148), new TimeSpan(0, 3, 30, 0, 0)), new Guid("091082cf-0c0f-4696-9dcc-a47d15c69f2c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 531, DateTimeKind.Unspecified).AddTicks(9024), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4c0d7287-a4f9-4e01-a201-ad98f011f256") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 532, DateTimeKind.Unspecified).AddTicks(608), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0712ca90-d607-42bb-8258-4d3b6157ba4b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 532, DateTimeKind.Unspecified).AddTicks(631), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c4c2635e-9d9c-4d3c-9e4f-323477d75f16") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 532, DateTimeKind.Unspecified).AddTicks(1885), new TimeSpan(0, 3, 30, 0, 0)), new Guid("adc894ed-f7fa-4d8d-814e-d7d274982cb6") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 532, DateTimeKind.Unspecified).AddTicks(1896), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0a5a1026-8928-4cf5-910a-c2dcf9c9d376") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 532, DateTimeKind.Unspecified).AddTicks(3598), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e6f459bd-a846-4cfe-9994-bbeb7feeb413") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 48, 532, DateTimeKind.Unspecified).AddTicks(3608), new TimeSpan(0, 3, 30, 0, 0)), new Guid("056a52dd-cdab-4dea-93b9-b1717c95e586") });
        }
    }
}
