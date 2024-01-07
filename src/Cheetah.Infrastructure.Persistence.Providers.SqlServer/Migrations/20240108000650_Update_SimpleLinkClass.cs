using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Update_SimpleLinkClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_L_CaseEndorsementUser_ThirdId",
                schema: "Links",
                table: "L_CaseEndorsementUser");

            migrationBuilder.AlterColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_UserPosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 102);

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
                oldDefaultValue: new Guid("d132b4e3-0736-4d66-8160-ccbf2b06db0a"));

            migrationBuilder.AlterColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_UserPosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_UserPosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 104);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 379, DateTimeKind.Unspecified).AddTicks(4144), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_UserLocation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 102);

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
                oldDefaultValue: new Guid("0d15b584-369f-4746-9b52-807706b3f6ae"));

            migrationBuilder.AlterColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_UserLocation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_UserLocation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 104);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 379, DateTimeKind.Unspecified).AddTicks(2452), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_RolePosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 102);

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
                oldDefaultValue: new Guid("8bb456af-fb9f-47da-a1a0-0dfa9f17ceea"));

            migrationBuilder.AlterColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_RolePosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_RolePosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 104);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 379, DateTimeKind.Unspecified).AddTicks(323), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 102);

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
                oldDefaultValue: new Guid("be48a8e7-4f9e-4497-9376-84be795f9671"));

            migrationBuilder.AlterColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 104);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 378, DateTimeKind.Unspecified).AddTicks(8645), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 102);

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
                oldDefaultValue: new Guid("cd778da3-3c95-49f7-b703-2fa55487053d"));

            migrationBuilder.AlterColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 104);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 378, DateTimeKind.Unspecified).AddTicks(6916), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 102);

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
                oldDefaultValue: new Guid("63364ee5-c525-48f3-8239-cb6326949a6b"));

            migrationBuilder.AlterColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 104);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 378, DateTimeKind.Unspecified).AddTicks(5227), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 102);

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
                oldDefaultValue: new Guid("8380f04d-2a75-4e82-9c8e-1af26cbbf54f"));

            migrationBuilder.AlterColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 104);

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 378, DateTimeKind.Unspecified).AddTicks(3483), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("5b602f75-bb5d-4136-8b74-cee904e93038"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 378, DateTimeKind.Unspecified).AddTicks(1583), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("ac937d16-97dd-435f-b64f-b62c499829a4"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 377, DateTimeKind.Unspecified).AddTicks(9745), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("0dd9e704-1dbe-41fc-9d33-4c496a6fa4ef"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 377, DateTimeKind.Unspecified).AddTicks(8266), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("ad78964a-575c-4cb1-88a2-a08825ff729b"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 377, DateTimeKind.Unspecified).AddTicks(6141), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("e247ac3b-bfaf-47a0-8dea-03e31e46c318"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 377, DateTimeKind.Unspecified).AddTicks(1340), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("c0d563f6-2e2e-4130-affc-12bbf0f642da"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(9096), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("3cdd93b3-4911-4fb6-a66b-e84b8c49a409"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(7165), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("10a2f5e8-fdd8-4d0f-819f-2e43cc46ddbf"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(5825), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("b7c0071d-42f8-4121-afee-aa8eb94c311f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(4504), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("7d89ac6e-a0e4-4038-9400-cebfa971fc6f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(3009), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("fb5b18a8-1b02-46c3-b02c-89ade28a6f4e"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(1434), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("6a02b69b-7a28-4a96-b3aa-276cc06a30ab"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(80), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("4675eefe-7d91-44cb-ad24-456fa5b00ffb"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(8686), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("a11c1476-9c65-422d-9481-627583a71a5a"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(7379), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("9f9bc1c0-04c1-4226-adc2-593441178478"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(6074), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("c1f8dd35-be3a-4ac3-a96d-507f343295ad"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(4745), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("68689257-481f-40b9-ab71-723faa8e61f1"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(3290), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("2e099922-63f1-44a8-a07d-92bca8ee707f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(1835), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("8313e78e-832b-4763-9585-c0b02051eaff"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(319), new TimeSpan(0, 3, 30, 0, 0)));

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

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_FifthId",
                schema: "Links",
                table: "L_UserPosition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_FourthId",
                schema: "Links",
                table: "L_UserPosition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_ThirdId",
                schema: "Links",
                table: "L_UserPosition",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_FifthId",
                schema: "Links",
                table: "L_UserLocation",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_FourthId",
                schema: "Links",
                table: "L_UserLocation",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_ThirdId",
                schema: "Links",
                table: "L_UserLocation",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_FifthId",
                schema: "Links",
                table: "L_RolePosition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_FourthId",
                schema: "Links",
                table: "L_RolePosition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_ThirdId",
                schema: "Links",
                table: "L_RolePosition",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_FifthId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_FourthId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_ThirdId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_FifthId",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_FourthId",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_ThirdId",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_FifthId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_FourthId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_ThirdId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseEndorsementUser_FifthId",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseEndorsementUser_FourthId",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseEndorsementUser_ThirdId",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                column: "ThirdId",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_L_UserPosition_FifthId",
                schema: "Links",
                table: "L_UserPosition");

            migrationBuilder.DropIndex(
                name: "IX_L_UserPosition_FourthId",
                schema: "Links",
                table: "L_UserPosition");

            migrationBuilder.DropIndex(
                name: "IX_L_UserPosition_ThirdId",
                schema: "Links",
                table: "L_UserPosition");

            migrationBuilder.DropIndex(
                name: "IX_L_UserLocation_FifthId",
                schema: "Links",
                table: "L_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_L_UserLocation_FourthId",
                schema: "Links",
                table: "L_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_L_UserLocation_ThirdId",
                schema: "Links",
                table: "L_UserLocation");

            migrationBuilder.DropIndex(
                name: "IX_L_RolePosition_FifthId",
                schema: "Links",
                table: "L_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_L_RolePosition_FourthId",
                schema: "Links",
                table: "L_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_L_RolePosition_ThirdId",
                schema: "Links",
                table: "L_RolePosition");

            migrationBuilder.DropIndex(
                name: "IX_L_ProcessScenario_FifthId",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropIndex(
                name: "IX_L_ProcessScenario_FourthId",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropIndex(
                name: "IX_L_ProcessScenario_ThirdId",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropIndex(
                name: "IX_L_EndorsementUser_FifthId",
                schema: "Links",
                table: "L_EndorsementUser");

            migrationBuilder.DropIndex(
                name: "IX_L_EndorsementUser_FourthId",
                schema: "Links",
                table: "L_EndorsementUser");

            migrationBuilder.DropIndex(
                name: "IX_L_EndorsementUser_ThirdId",
                schema: "Links",
                table: "L_EndorsementUser");

            migrationBuilder.DropIndex(
                name: "IX_L_EndorsementItemEndorsement_FifthId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_L_EndorsementItemEndorsement_FourthId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_L_EndorsementItemEndorsement_ThirdId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_L_CaseEndorsementUser_FifthId",
                schema: "Links",
                table: "L_CaseEndorsementUser");

            migrationBuilder.DropIndex(
                name: "IX_L_CaseEndorsementUser_FourthId",
                schema: "Links",
                table: "L_CaseEndorsementUser");

            migrationBuilder.DropIndex(
                name: "IX_L_CaseEndorsementUser_ThirdId",
                schema: "Links",
                table: "L_CaseEndorsementUser");

            migrationBuilder.AlterColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_UserPosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserPosition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d132b4e3-0736-4d66-8160-ccbf2b06db0a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("367d8311-d041-4d27-b06a-f2abbdd6ccf4"));

            migrationBuilder.AlterColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_UserPosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_UserPosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserPosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 379, DateTimeKind.Unspecified).AddTicks(4144), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 22, DateTimeKind.Unspecified).AddTicks(2974), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_UserLocation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_UserLocation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("0d15b584-369f-4746-9b52-807706b3f6ae"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("8018dcc9-0c16-4c50-b3a3-26a5f8e57cd5"));

            migrationBuilder.AlterColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_UserLocation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_UserLocation",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_UserLocation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 379, DateTimeKind.Unspecified).AddTicks(2452), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 21, DateTimeKind.Unspecified).AddTicks(9534), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_RolePosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_RolePosition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8bb456af-fb9f-47da-a1a0-0dfa9f17ceea"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5c3700fc-0151-44cd-9846-6be9849ec0a3"));

            migrationBuilder.AlterColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_RolePosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_RolePosition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_RolePosition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 379, DateTimeKind.Unspecified).AddTicks(323), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 21, DateTimeKind.Unspecified).AddTicks(6090), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("be48a8e7-4f9e-4497-9376-84be795f9671"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("6fde79d2-021f-4179-a147-e3dc45e9b575"));

            migrationBuilder.AlterColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 378, DateTimeKind.Unspecified).AddTicks(8645), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 21, DateTimeKind.Unspecified).AddTicks(2592), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("cd778da3-3c95-49f7-b703-2fa55487053d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d8c6e23a-9974-4636-acec-5c8c00bdd715"));

            migrationBuilder.AlterColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 378, DateTimeKind.Unspecified).AddTicks(6916), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 20, DateTimeKind.Unspecified).AddTicks(9142), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("63364ee5-c525-48f3-8239-cb6326949a6b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("bc5a134c-45d3-4409-b04d-f531c183c234"));

            migrationBuilder.AlterColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 378, DateTimeKind.Unspecified).AddTicks(5227), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 36, 49, 20, DateTimeKind.Unspecified).AddTicks(5691), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("8380f04d-2a75-4e82-9c8e-1af26cbbf54f"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5dbdbfa9-b453-4ed6-9511-76498e7f2483"));

            migrationBuilder.AlterColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 103);

            migrationBuilder.AlterColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 378, DateTimeKind.Unspecified).AddTicks(3483), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("5b602f75-bb5d-4136-8b74-cee904e93038"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 378, DateTimeKind.Unspecified).AddTicks(1583), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("ac937d16-97dd-435f-b64f-b62c499829a4"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 377, DateTimeKind.Unspecified).AddTicks(9745), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("0dd9e704-1dbe-41fc-9d33-4c496a6fa4ef"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 377, DateTimeKind.Unspecified).AddTicks(8266), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("ad78964a-575c-4cb1-88a2-a08825ff729b"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 377, DateTimeKind.Unspecified).AddTicks(6141), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("e247ac3b-bfaf-47a0-8dea-03e31e46c318"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 377, DateTimeKind.Unspecified).AddTicks(1340), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("c0d563f6-2e2e-4130-affc-12bbf0f642da"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(9096), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("3cdd93b3-4911-4fb6-a66b-e84b8c49a409"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(7165), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("10a2f5e8-fdd8-4d0f-819f-2e43cc46ddbf"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(5825), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("b7c0071d-42f8-4121-afee-aa8eb94c311f"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(4504), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("7d89ac6e-a0e4-4038-9400-cebfa971fc6f"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(3009), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("fb5b18a8-1b02-46c3-b02c-89ade28a6f4e"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(1434), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("6a02b69b-7a28-4a96-b3aa-276cc06a30ab"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(80), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("4675eefe-7d91-44cb-ad24-456fa5b00ffb"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(8686), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("a11c1476-9c65-422d-9481-627583a71a5a"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(7379), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("9f9bc1c0-04c1-4226-adc2-593441178478"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(6074), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("c1f8dd35-be3a-4ac3-a96d-507f343295ad"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(4745), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("68689257-481f-40b9-ab71-723faa8e61f1"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(3290), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("2e099922-63f1-44a8-a07d-92bca8ee707f"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(1835), new TimeSpan(0, 3, 30, 0, 0)),
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
                defaultValue: new Guid("8313e78e-832b-4763-9585-c0b02051eaff"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(319), new TimeSpan(0, 3, 30, 0, 0)),
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
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 29, DateTimeKind.Unspecified).AddTicks(1896), new TimeSpan(0, 3, 30, 0, 0)), new Guid("755bf84c-dead-45fb-b93f-b74363bf000d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 29, DateTimeKind.Unspecified).AddTicks(1901), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ab06b039-9660-44cd-94c6-31c76719dc7d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 29, DateTimeKind.Unspecified).AddTicks(1904), new TimeSpan(0, 3, 30, 0, 0)), new Guid("261dfd55-b2f6-4734-b82f-9a5807366e00") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 29, DateTimeKind.Unspecified).AddTicks(1906), new TimeSpan(0, 3, 30, 0, 0)), new Guid("29fab242-d40d-4458-9116-0f5c4742b3f0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 29, DateTimeKind.Unspecified).AddTicks(1909), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fb8fdc13-aaac-43a2-8cef-ae109082d7eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 30, DateTimeKind.Unspecified).AddTicks(2233), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d4a07ce7-cf09-4d8c-a97c-bd55131b8fdf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2049), new TimeSpan(0, 3, 30, 0, 0)), new Guid("26207bb6-a56e-492e-8ad4-9137f416c312") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2085), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f39aa16e-983a-416d-bee6-77d9df1e6c7c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2092), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3f81c38a-fbd4-4172-82fc-9874e4893f52") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2097), new TimeSpan(0, 3, 30, 0, 0)), new Guid("74b62b4b-8b7f-4f75-a369-32a3d9119f8a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2102), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ade7a700-ca60-43ef-8be3-d490d680fc83") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2108), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d9dc8a4c-89b7-4dcb-84ce-640fdb3256ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2114), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ce344f20-e350-4527-9589-984489e342c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2127), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0ab6f8e0-236d-417b-871c-d45226f74210") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2134), new TimeSpan(0, 3, 30, 0, 0)), new Guid("664f30e4-f106-4326-87d8-07db6ad95ec9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2139), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8159bb2b-84e1-4f08-971c-eb0dab805a98") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2144), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b166054c-5fd5-4e15-af4c-524c62782ae1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2148), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4faceaec-7bdf-4169-b2c5-f8c080abdb93") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2153), new TimeSpan(0, 3, 30, 0, 0)), new Guid("24d07612-7a3f-44a1-9daa-9f27516a9681") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2158), new TimeSpan(0, 3, 30, 0, 0)), new Guid("12a4d270-10ac-469e-838a-107013b24b2c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2196), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f8046d0d-71a8-4d05-a799-ae53e2c2e00a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, 3, 30, 0, 0)), new Guid("74d5aef0-08ce-478a-b4bf-43fe53ce9a84") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2206), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9c484199-f215-4bd0-b1aa-596dcf4ae431") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2211), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e754f429-935a-4339-80bf-0f33b7273ccc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(2216), new TimeSpan(0, 3, 30, 0, 0)), new Guid("74e39681-24e2-417b-9f3a-b130ffebeede") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(3331), new TimeSpan(0, 3, 30, 0, 0)), new Guid("666d6fa1-8d00-4f7f-9372-161abb94c9a7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(5518), new TimeSpan(0, 3, 30, 0, 0)), new Guid("87c220c1-769a-4073-9946-3a63bcfbadca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(5525), new TimeSpan(0, 3, 30, 0, 0)), new Guid("43583285-5b64-4799-9052-c105e11fa2fb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(5528), new TimeSpan(0, 3, 30, 0, 0)), new Guid("683fc45e-8ce7-4ed0-9e68-5fa08c99063f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(5531), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ce223c64-6702-4e22-8152-29f804e51f70") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(5538), new TimeSpan(0, 3, 30, 0, 0)), new Guid("63500bf8-acc5-4537-b868-d88672ed39c8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(5541), new TimeSpan(0, 3, 30, 0, 0)), new Guid("33c6536e-8ddc-45af-95c0-894502cff8fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(7184), new TimeSpan(0, 3, 30, 0, 0)), new Guid("abcdbc3b-b7dc-4cce-be31-2d727763419a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(8052), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5531ea6b-c8ad-4ddc-a084-b126b967ff4c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(8997), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cc24ea70-ec2d-4394-bece-a3904cacacdb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 31, DateTimeKind.Unspecified).AddTicks(9148), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ec9e79f4-9e35-4533-8a80-c28584bfb308") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 32, DateTimeKind.Unspecified).AddTicks(889), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aa7ebf85-81f1-4944-a7c8-0513d25a34ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 32, DateTimeKind.Unspecified).AddTicks(1139), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b173fc3a-ec3f-475a-b71a-f997b1ccc569") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 32, DateTimeKind.Unspecified).AddTicks(1146), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8bd23f73-f10b-4fd8-8f01-e471aaacf0ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 32, DateTimeKind.Unspecified).AddTicks(1149), new TimeSpan(0, 3, 30, 0, 0)), new Guid("02416bf6-e9ca-4362-ba3b-9bdd894e91f0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 32, DateTimeKind.Unspecified).AddTicks(1180), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d3c376bd-a0b8-42dc-9b2f-db6bf095e7d9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 32, DateTimeKind.Unspecified).AddTicks(2387), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f633ec38-8665-4b38-abf5-da61278a71d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 32, DateTimeKind.Unspecified).AddTicks(2393), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1d94e5e2-6430-4b64-b9aa-9b2555add183") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 32, DateTimeKind.Unspecified).AddTicks(2395), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fe763d39-3a13-4391-aaf2-4d47adfe78c7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 32, DateTimeKind.Unspecified).AddTicks(2398), new TimeSpan(0, 3, 30, 0, 0)), new Guid("07e277df-bb24-4662-8abb-ad3b531cf17f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 32, DateTimeKind.Unspecified).AddTicks(4967), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b62d32e1-84c6-489e-bb22-6ea5f971a69e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 32, DateTimeKind.Unspecified).AddTicks(4992), new TimeSpan(0, 3, 30, 0, 0)), new Guid("01748f5a-ef23-4a26-a3a7-9a1bacba2a7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 32, DateTimeKind.Unspecified).AddTicks(6376), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cde9abe8-38fa-4cef-80e3-5d1e1cf28b8b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 32, DateTimeKind.Unspecified).AddTicks(6381), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a37c5fdb-e7dc-4e46-a0ef-85d886483d5c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 32, DateTimeKind.Unspecified).AddTicks(6384), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0ccb77b0-07e7-46bc-9ea9-0bd8f271ee69") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 32, DateTimeKind.Unspecified).AddTicks(6386), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4ebdc578-d16a-4eed-bde1-4452ae7bf744") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(4665), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cc5765ae-02a7-463e-b2d1-053202128d23") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(5106), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6bdeb86a-0662-4adb-a459-97d6a33937f0") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(5193), new TimeSpan(0, 3, 30, 0, 0)), new Guid("35f318a4-6dff-4a0a-af85-e91fd3eb40df") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(5198), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9864f093-4d59-4ad8-af5a-fe4b866433a5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(5201), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0c191e60-0b87-4358-8a0c-680faeda87dd") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(6875), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c687779a-79ad-4768-a036-24d4f70c776c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(7112), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ee10a142-7c56-4030-9c4d-03dab6cfa94a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(9239), new TimeSpan(0, 3, 30, 0, 0)), new Guid("442d0d70-355a-460c-87cd-421bbc184aea") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(9457), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6ef90dbd-a9bd-43b7-a659-acf4440d9522") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(9461), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d670e49e-c3cf-42f6-874c-c036ec429c18") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(9468), new TimeSpan(0, 3, 30, 0, 0)), new Guid("556c8c2d-ae4b-46f1-8edd-af5ab0ff52b7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 29, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 3, 30, 0, 0)), new Guid("14ecbca0-5ddc-4f0e-875e-ca794fa4f47a") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 27, DateTimeKind.Unspecified).AddTicks(4981), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9234ff5c-fbd8-4732-83db-0a0d885df03a") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 27, DateTimeKind.Unspecified).AddTicks(5747), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2c399dc2-122d-4828-9164-7dcfcc23994b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 27, DateTimeKind.Unspecified).AddTicks(9200), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a3dc2061-1a4b-436d-a969-6753b9db1586") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(406), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e918252c-e0a3-4885-bfdb-27cb0215740d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(414), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bb759170-8700-4010-b86a-5f5dc0e722c6") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(1366), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1f3d4c03-c9ee-43e5-9f5b-8f520682ede6") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(1372), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ff28905e-d3fa-43e8-a865-6077c7d4197a") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(2259), new TimeSpan(0, 3, 30, 0, 0)), new Guid("acf69f8a-b9ee-466b-afac-b48ec658b133") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(2265), new TimeSpan(0, 3, 30, 0, 0)), new Guid("02e93e2d-2340-47b5-9c39-14f97c058271") });

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseEndorsementUser_ThirdId",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                column: "ThirdId");
        }
    }
}
