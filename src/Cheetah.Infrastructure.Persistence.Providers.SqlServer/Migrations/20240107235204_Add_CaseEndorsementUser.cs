using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_CaseEndorsementUser : Migration
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
                defaultValue: new Guid("d132b4e3-0736-4d66-8160-ccbf2b06db0a"),
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
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 379, DateTimeKind.Unspecified).AddTicks(4144), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 72, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_UserPosition",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_UserPosition",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_UserPosition",
                type: "bigint",
                nullable: true);

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
                oldDefaultValue: new Guid("7bb7859d-6a20-4666-9c7c-01ab1980a0bd"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 72, DateTimeKind.Unspecified).AddTicks(3148), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_UserLocation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_UserLocation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_UserLocation",
                type: "bigint",
                nullable: true);

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
                oldDefaultValue: new Guid("2fb713f9-febc-4c24-bf1f-4d5aad7d903f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 71, DateTimeKind.Unspecified).AddTicks(9723), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_RolePosition",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_RolePosition",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_RolePosition",
                type: "bigint",
                nullable: true);

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
                oldDefaultValue: new Guid("f28c1ad9-a50b-46fb-b8f5-aa31d9fed13d"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 71, DateTimeKind.Unspecified).AddTicks(6257), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bigint",
                nullable: true);

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
                oldDefaultValue: new Guid("70313024-72df-4ae2-84e0-b39f6db0ca06"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 71, DateTimeKind.Unspecified).AddTicks(2703), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_EndorsementUser",
                type: "bigint",
                nullable: true);

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
                oldDefaultValue: new Guid("9bdb5c42-7e0b-4b9e-860a-ca5e974c09af"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 70, DateTimeKind.Unspecified).AddTicks(8987), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<long>(
                name: "FifthId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FourthId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ThirdId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                type: "bigint",
                nullable: true);

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
                oldDefaultValue: new Guid("30f1508d-f527-4f89-a0c9-3686c285d667"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 70, DateTimeKind.Unspecified).AddTicks(6384), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("e745e3ce-4dfc-4551-8b90-8351364aff54"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 70, DateTimeKind.Unspecified).AddTicks(3703), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("e39b1b9f-b8ac-4c44-a162-59e87c8295e6"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 70, DateTimeKind.Unspecified).AddTicks(393), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("bfd38f2c-dff6-4713-a09c-3875c35551b5"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 69, DateTimeKind.Unspecified).AddTicks(7917), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("5ed855ac-e0d9-42b8-a644-83a31ceea0ee"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 69, DateTimeKind.Unspecified).AddTicks(5061), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("2634be80-fa87-488a-bc42-8d2b1aba3caf"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 69, DateTimeKind.Unspecified).AddTicks(1219), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("923a663c-2fc7-47e2-877f-5ad20dee2e5a"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 68, DateTimeKind.Unspecified).AddTicks(8152), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("2e3434cc-b2c3-4aab-9bb4-789b056b071c"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 68, DateTimeKind.Unspecified).AddTicks(5916), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("4acca7ad-de8e-4d66-857c-397cf89e4690"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 68, DateTimeKind.Unspecified).AddTicks(3892), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("c4d793b0-9dde-4743-a902-1b04aaaf83a2"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 68, DateTimeKind.Unspecified).AddTicks(1210), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("a100f063-0b4f-4698-b53f-b1bb6c18585b"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 67, DateTimeKind.Unspecified).AddTicks(8582), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("93bdf80b-9bd7-4416-a038-1ec17a1e3396"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 67, DateTimeKind.Unspecified).AddTicks(6364), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("c368e6cd-c48b-4156-84bd-4270930dd180"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 67, DateTimeKind.Unspecified).AddTicks(4003), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("2288200e-de94-4d0e-8735-28a25ee3e25e"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 67, DateTimeKind.Unspecified).AddTicks(1915), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("2cdcaf2f-3510-40ba-9ccd-e836a7d3328f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 66, DateTimeKind.Unspecified).AddTicks(9630), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("72b6d54e-d3c0-46bb-a90c-1b1793018fe7"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 66, DateTimeKind.Unspecified).AddTicks(7149), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("5f016f2e-1bfc-4133-8085-8b6d1b4dcf6b"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 66, DateTimeKind.Unspecified).AddTicks(4900), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("131d4f2c-67be-426a-b92f-f36a625a7a11"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 66, DateTimeKind.Unspecified).AddTicks(2517), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("300ff3d6-7a74-48f5-814e-e684a690562c"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 17, 65, DateTimeKind.Unspecified).AddTicks(9929), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.CreateTable(
                name: "L_CaseEndorsementUser",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 378, DateTimeKind.Unspecified).AddTicks(3483), new TimeSpan(0, 3, 30, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("8380f04d-2a75-4e82-9c8e-1af26cbbf54f")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_CaseEndorsementUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_CaseEndorsementUser_D_User_ThirdId",
                        column: x => x.ThirdId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_CaseEndorsementUser_F_Case_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Case",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_CaseEndorsementUser_F_Endorsement_SecondId",
                        column: x => x.SecondId,
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
                columns: new[] { "Created", "FifthId", "FourthId", "GuidRecord", "ThirdId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 27, DateTimeKind.Unspecified).AddTicks(4981), new TimeSpan(0, 3, 30, 0, 0)), null, null, new Guid("9234ff5c-fbd8-4732-83db-0a0d885df03a"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "FifthId", "FourthId", "GuidRecord", "ThirdId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 27, DateTimeKind.Unspecified).AddTicks(5747), new TimeSpan(0, 3, 30, 0, 0)), null, null, new Guid("2c399dc2-122d-4828-9164-7dcfcc23994b"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "FifthId", "FourthId", "GuidRecord", "ThirdId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 27, DateTimeKind.Unspecified).AddTicks(9200), new TimeSpan(0, 3, 30, 0, 0)), null, null, new Guid("a3dc2061-1a4b-436d-a969-6753b9db1586"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "FifthId", "FourthId", "GuidRecord", "ThirdId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(406), new TimeSpan(0, 3, 30, 0, 0)), null, null, new Guid("e918252c-e0a3-4885-bfdb-27cb0215740d"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "FifthId", "FourthId", "GuidRecord", "ThirdId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(414), new TimeSpan(0, 3, 30, 0, 0)), null, null, new Guid("bb759170-8700-4010-b86a-5f5dc0e722c6"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "FifthId", "FourthId", "GuidRecord", "ThirdId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(1366), new TimeSpan(0, 3, 30, 0, 0)), null, null, new Guid("1f3d4c03-c9ee-43e5-9f5b-8f520682ede6"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "FifthId", "FourthId", "GuidRecord", "ThirdId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(1372), new TimeSpan(0, 3, 30, 0, 0)), null, null, new Guid("ff28905e-d3fa-43e8-a865-6077c7d4197a"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "FifthId", "FourthId", "GuidRecord", "ThirdId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(2259), new TimeSpan(0, 3, 30, 0, 0)), null, null, new Guid("acf69f8a-b9ee-466b-afac-b48ec658b133"), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "FifthId", "FourthId", "GuidRecord", "ThirdId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 28, DateTimeKind.Unspecified).AddTicks(2265), new TimeSpan(0, 3, 30, 0, 0)), null, null, new Guid("02e93e2d-2340-47b5-9c39-14f97c058271"), null });

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseEndorsementUser_Created",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseEndorsementUser_EnableRecord",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseEndorsementUser_ERPCode",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseEndorsementUser_FirstId",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseEndorsementUser_LastModified",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseEndorsementUser_Name",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseEndorsementUser_SecondId",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseEndorsementUser_ThirdId",
                schema: "Links",
                table: "L_CaseEndorsementUser",
                column: "ThirdId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "L_CaseEndorsementUser",
                schema: "Links");

            migrationBuilder.DropColumn(
                name: "FifthId",
                schema: "Links",
                table: "L_UserPosition");

            migrationBuilder.DropColumn(
                name: "FourthId",
                schema: "Links",
                table: "L_UserPosition");

            migrationBuilder.DropColumn(
                name: "ThirdId",
                schema: "Links",
                table: "L_UserPosition");

            migrationBuilder.DropColumn(
                name: "FifthId",
                schema: "Links",
                table: "L_UserLocation");

            migrationBuilder.DropColumn(
                name: "FourthId",
                schema: "Links",
                table: "L_UserLocation");

            migrationBuilder.DropColumn(
                name: "ThirdId",
                schema: "Links",
                table: "L_UserLocation");

            migrationBuilder.DropColumn(
                name: "FifthId",
                schema: "Links",
                table: "L_RolePosition");

            migrationBuilder.DropColumn(
                name: "FourthId",
                schema: "Links",
                table: "L_RolePosition");

            migrationBuilder.DropColumn(
                name: "ThirdId",
                schema: "Links",
                table: "L_RolePosition");

            migrationBuilder.DropColumn(
                name: "FifthId",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropColumn(
                name: "FourthId",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropColumn(
                name: "ThirdId",
                schema: "Links",
                table: "L_ProcessScenario");

            migrationBuilder.DropColumn(
                name: "FifthId",
                schema: "Links",
                table: "L_EndorsementUser");

            migrationBuilder.DropColumn(
                name: "FourthId",
                schema: "Links",
                table: "L_EndorsementUser");

            migrationBuilder.DropColumn(
                name: "ThirdId",
                schema: "Links",
                table: "L_EndorsementUser");

            migrationBuilder.DropColumn(
                name: "FifthId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement");

            migrationBuilder.DropColumn(
                name: "FourthId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement");

            migrationBuilder.DropColumn(
                name: "ThirdId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement");

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
                oldDefaultValue: new Guid("d132b4e3-0736-4d66-8160-ccbf2b06db0a"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 379, DateTimeKind.Unspecified).AddTicks(4144), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("0d15b584-369f-4746-9b52-807706b3f6ae"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 379, DateTimeKind.Unspecified).AddTicks(2452), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("8bb456af-fb9f-47da-a1a0-0dfa9f17ceea"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 379, DateTimeKind.Unspecified).AddTicks(323), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("be48a8e7-4f9e-4497-9376-84be795f9671"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 378, DateTimeKind.Unspecified).AddTicks(8645), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("cd778da3-3c95-49f7-b703-2fa55487053d"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 378, DateTimeKind.Unspecified).AddTicks(6916), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("63364ee5-c525-48f3-8239-cb6326949a6b"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 378, DateTimeKind.Unspecified).AddTicks(5227), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("5b602f75-bb5d-4136-8b74-cee904e93038"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 378, DateTimeKind.Unspecified).AddTicks(1583), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("ac937d16-97dd-435f-b64f-b62c499829a4"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 377, DateTimeKind.Unspecified).AddTicks(9745), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("0dd9e704-1dbe-41fc-9d33-4c496a6fa4ef"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 377, DateTimeKind.Unspecified).AddTicks(8266), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("ad78964a-575c-4cb1-88a2-a08825ff729b"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 377, DateTimeKind.Unspecified).AddTicks(6141), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("e247ac3b-bfaf-47a0-8dea-03e31e46c318"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 377, DateTimeKind.Unspecified).AddTicks(1340), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("c0d563f6-2e2e-4130-affc-12bbf0f642da"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(9096), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("3cdd93b3-4911-4fb6-a66b-e84b8c49a409"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(7165), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("10a2f5e8-fdd8-4d0f-819f-2e43cc46ddbf"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(5825), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("b7c0071d-42f8-4121-afee-aa8eb94c311f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(4504), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("7d89ac6e-a0e4-4038-9400-cebfa971fc6f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(3009), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("fb5b18a8-1b02-46c3-b02c-89ade28a6f4e"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(1434), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("6a02b69b-7a28-4a96-b3aa-276cc06a30ab"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 376, DateTimeKind.Unspecified).AddTicks(80), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("4675eefe-7d91-44cb-ad24-456fa5b00ffb"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(8686), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("a11c1476-9c65-422d-9481-627583a71a5a"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(7379), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("9f9bc1c0-04c1-4226-adc2-593441178478"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(6074), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("c1f8dd35-be3a-4ac3-a96d-507f343295ad"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(4745), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("68689257-481f-40b9-ab71-723faa8e61f1"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(3290), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("2e099922-63f1-44a8-a07d-92bca8ee707f"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(1835), new TimeSpan(0, 3, 30, 0, 0)));

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
                oldDefaultValue: new Guid("8313e78e-832b-4763-9585-c0b02051eaff"));

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
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 8, 3, 22, 3, 375, DateTimeKind.Unspecified).AddTicks(319), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f9108182-367a-41e2-9e62-b0aa3cbcc905") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(5738), new TimeSpan(0, 3, 30, 0, 0)), new Guid("266f7606-ec3d-4b72-bcb7-339bdd29eaa5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(5742), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a8c8cb75-3cb8-49d8-986d-13389b790da2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(5749), new TimeSpan(0, 3, 30, 0, 0)), new Guid("309c409f-01ad-4000-a754-95a5b7b5401a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(5752), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b57a3178-5b0f-40a5-a980-6297b2996ddd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 590, DateTimeKind.Unspecified).AddTicks(8430), new TimeSpan(0, 3, 30, 0, 0)), new Guid("798ce64d-14d6-4e82-b1a3-8645cd49d659") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1625), new TimeSpan(0, 3, 30, 0, 0)), new Guid("efb1ecbc-6579-4f25-841e-e887074cd462") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1666), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fe5f34e0-cb5c-4356-a2e0-ab1860cfbd65") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1673), new TimeSpan(0, 3, 30, 0, 0)), new Guid("65042e36-89a0-4dc0-af61-508f085d68f5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1681), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aeab6e51-e46b-46bd-96ef-a87160c1b625") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1689), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c0ef0af5-8c18-4bdd-ba4a-87b3d9a3bc42") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1703), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5d9defe0-3b90-4067-bd04-964280131363") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1711), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3dcdd953-8142-40d8-a4ea-0d9c8c739e5b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1718), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0d63c734-c1f3-47e6-b101-edaefe4d1e77") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1736), new TimeSpan(0, 3, 30, 0, 0)), new Guid("763ddb36-894a-4c11-9231-3dd83557084a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1741), new TimeSpan(0, 3, 30, 0, 0)), new Guid("069af2ea-2e43-45a9-9d29-7e8719a0cba5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1749), new TimeSpan(0, 3, 30, 0, 0)), new Guid("edaf8998-b439-4f42-85a6-fe4176139aea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1753), new TimeSpan(0, 3, 30, 0, 0)), new Guid("19e34c1c-57c5-4f1f-b5f3-24b2d72cac9c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1759), new TimeSpan(0, 3, 30, 0, 0)), new Guid("351a1a73-c778-4077-84f4-6c7ea83d2d01") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1816), new TimeSpan(0, 3, 30, 0, 0)), new Guid("70240b8b-6946-43fa-b77c-aeb421ca216d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1822), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a7cad31e-560f-4058-9344-e9db0aec9fef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1826), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8cdaca47-5316-4a58-b370-85177e2770ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1830), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f3589560-277d-4ccc-9172-30bd750eb3b0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1837), new TimeSpan(0, 3, 30, 0, 0)), new Guid("171be1d0-59be-4aa2-b792-43a308262fd1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(1842), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d48b0d02-3a98-4901-8877-a6fd9cf3bbe1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(3085), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2bd0adb9-c5d8-4191-aeda-2865fa6326ce") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(4705), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9cb0a26d-bc86-415b-a7e4-57e674c557ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(4714), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bf3cbbbd-84b2-4c65-88b6-4b85d28e39c5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(4717), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f8163bf6-b0fd-4628-8a8b-9c67d2652f1b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(4719), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d0ce55ca-7e1d-455a-811c-038189a8ffe5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(4722), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ea841fc4-40f2-4d2b-a9ef-7302cef0ddbd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(4724), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cf203154-663c-4a7e-8901-150ffac8a7a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(6150), new TimeSpan(0, 3, 30, 0, 0)), new Guid("374ec259-80a3-415d-920f-0c84b0d01465") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(7049), new TimeSpan(0, 3, 30, 0, 0)), new Guid("819ea863-5d6e-4a0b-8394-685c3934542b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(8036), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7e756677-3794-416e-b732-d569c2a42462") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 592, DateTimeKind.Unspecified).AddTicks(8211), new TimeSpan(0, 3, 30, 0, 0)), new Guid("994338ed-75cc-424a-83b3-66ea6add5040") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(2262), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7392d63-7962-4aed-a670-b730cbdd79ba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(2590), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0333970e-1fa7-4b5b-9395-299094c25d55") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(2643), new TimeSpan(0, 3, 30, 0, 0)), new Guid("05f17533-edaf-419c-87ee-d80743996511") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(2647), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f319139a-e512-410d-ab71-2b3b1390cc52") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(2650), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cf900550-686c-4cc4-be7d-54e8c01211cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(4180), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e1265bf6-1fd7-4473-a3e0-245abd3f86d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(4187), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f7571f97-8cd1-4f1c-b692-aa31ca9cbc11") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(4196), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dbc06fe1-fff4-4f6d-a0de-f3721d9497d6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(4199), new TimeSpan(0, 3, 30, 0, 0)), new Guid("932fb04a-ccbc-49cb-98df-7c188a87da7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(7353), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b57bea2f-ff33-421b-a6b2-82a5a62355c5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(7387), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8a7b284b-9a18-41be-b509-8ad226920a84") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(8879), new TimeSpan(0, 3, 30, 0, 0)), new Guid("51b2ab6e-e11e-47e6-93e6-29b6db61712c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(8886), new TimeSpan(0, 3, 30, 0, 0)), new Guid("55ee115d-67f2-455b-b3d0-8dd046d12e5c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(8890), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e7de6388-ec5a-4474-bff5-e745620f269c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 593, DateTimeKind.Unspecified).AddTicks(8893), new TimeSpan(0, 3, 30, 0, 0)), new Guid("27f384cc-d066-47ff-945f-24c03b716162") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(6854), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1c2e9b1e-3f6d-4576-a3d4-66a86077fcca") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(7380), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c48a46ec-5573-4ac8-98ee-1664fbec5717") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(7475), new TimeSpan(0, 3, 30, 0, 0)), new Guid("46887efe-643f-427a-bef7-f77fbab518a6") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(7481), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a9186b61-7089-4994-b867-17c529d87bdd") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(7485), new TimeSpan(0, 3, 30, 0, 0)), new Guid("45c5e89b-4259-4a49-b34b-5323337317bc") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(9698), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ca82751e-e456-4a9c-b681-b2abcabab236") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(9982), new TimeSpan(0, 3, 30, 0, 0)), new Guid("79dec0bc-9731-4cfc-9892-20579e5296ff") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(2523), new TimeSpan(0, 3, 30, 0, 0)), new Guid("48da475b-1c0f-440a-a2e2-f48f239ee277") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(2793), new TimeSpan(0, 3, 30, 0, 0)), new Guid("48ee6aac-a83c-4753-a737-44677cc9305e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(2800), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c446eee4-2c75-4f8e-991b-e2b8354ccffe") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(2805), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f53f7a69-5301-43c1-a8cc-d76159f81205") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 589, DateTimeKind.Unspecified).AddTicks(4082), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9f5db529-a25c-4196-98da-fb0fe44a4e0c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 587, DateTimeKind.Unspecified).AddTicks(3562), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c8a61584-f543-4cbe-b496-1c479183721f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 587, DateTimeKind.Unspecified).AddTicks(4498), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cdddc528-6a8d-41da-9b45-12b8c4dc2d9c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 587, DateTimeKind.Unspecified).AddTicks(9163), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ca7661cf-e324-4832-bce4-54cf7d0505c2") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(505), new TimeSpan(0, 3, 30, 0, 0)), new Guid("57b3a290-8c29-4438-b81a-4c40ecbacc90") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(514), new TimeSpan(0, 3, 30, 0, 0)), new Guid("370b2b22-5dc8-42f6-a0b7-31838e84eded") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(1572), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dc43f014-5e99-484d-81a4-3e435003c979") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(1580), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d5415bc8-670f-4124-bde9-2d29e18e2798") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(4232), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6e298123-b4f3-4e97-9499-39039f329a02") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 23, 6, 16, 588, DateTimeKind.Unspecified).AddTicks(4251), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0c5ed780-b451-419e-84fc-e57f55f8952e") });
        }
    }
}
