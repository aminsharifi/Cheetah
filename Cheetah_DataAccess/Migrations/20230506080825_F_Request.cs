using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class F_Request : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Attachment_F_Approve_F_ApproveId",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_F_RequestInformation_F_RequestInformationId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Current_ApproveId",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Last_ApproveId",
                schema: "Facts",
                table: "F_AllApprove");

            migrationBuilder.DropTable(
                name: "F_RequestInformation",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_Approve",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_AllApprove",
                schema: "Facts");

            migrationBuilder.RenameColumn(
                name: "F_RequestInformationId",
                schema: "Facts",
                table: "F_Condition",
                newName: "F_RequestId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Condition_F_RequestInformationId",
                schema: "Facts",
                table: "F_Condition",
                newName: "IX_F_Condition_F_RequestId");

            migrationBuilder.RenameColumn(
                name: "F_ApproveId",
                schema: "Facts",
                table: "F_Attachment",
                newName: "F_ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Attachment_F_ApproveId",
                schema: "Facts",
                table: "F_Attachment",
                newName: "IX_F_Attachment_F_ReviewId");

            migrationBuilder.CreateTable(
                name: "F_AllReview",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    AAP_Current_ReviewId = table.Column<long>(type: "bigint", nullable: true),
                    AAP_Last_ReviewId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_AllReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_AllReview_F_AllReview_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_AllReview",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Request",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    RI_ERPID = table.Column<long>(type: "bigint", nullable: true),
                    RI_IsCancelled = table.Column<bool>(type: "bit", nullable: true),
                    IsTest = table.Column<bool>(type: "bit", nullable: true),
                    RI_PE_Level = table.Column<byte>(type: "tinyint", nullable: true),
                    RI_RequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RI_RequestFinishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RI_RequestorId = table.Column<long>(type: "bigint", nullable: true),
                    RI_CreatorId = table.Column<long>(type: "bigint", nullable: true),
                    RI_AllApproveId = table.Column<long>(type: "bigint", nullable: true),
                    RI_ProcessStateId = table.Column<long>(type: "bigint", nullable: true),
                    RI_ProcessId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Request_D_ProcessState_RI_ProcessStateId",
                        column: x => x.RI_ProcessStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Request_D_Process_RI_ProcessId",
                        column: x => x.RI_ProcessId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Process",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Request_D_User_RI_CreatorId",
                        column: x => x.RI_CreatorId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Request_D_User_RI_RequestorId",
                        column: x => x.RI_RequestorId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Request_F_AllReview_RI_AllApproveId",
                        column: x => x.RI_AllApproveId,
                        principalSchema: "Facts",
                        principalTable: "F_AllReview",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Request_F_Request_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_Request",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Review",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    APV_UserInChargeId = table.Column<long>(type: "bigint", nullable: true),
                    APV_EndorsementId = table.Column<long>(type: "bigint", nullable: true),
                    APV_NeedReviewId = table.Column<long>(type: "bigint", nullable: true),
                    APV_ReviewId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Review_D_User_APV_UserInChargeId",
                        column: x => x.APV_UserInChargeId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Review_F_AllReview_APV_NeedReviewId",
                        column: x => x.APV_NeedReviewId,
                        principalSchema: "Facts",
                        principalTable: "F_AllReview",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Review_F_AllReview_APV_ReviewId",
                        column: x => x.APV_ReviewId,
                        principalSchema: "Facts",
                        principalTable: "F_AllReview",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Review_F_Endorsement_APV_EndorsementId",
                        column: x => x.APV_EndorsementId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Review_F_Review_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_Review",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2989), new Guid("5b5c3bde-1cec-45d3-889b-316ba6aae890") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3057), new Guid("3eaf8dd5-7959-4cdb-a759-415df5fdc030") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3071), new Guid("33e5ca9f-71a5-4463-bd19-8ab0341563f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3083), new Guid("e2420fc7-3f1d-4fb8-b103-5abe83f15dd4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3134), new Guid("8d7d8370-04f8-4256-89a4-9fd1518e068f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3151), new Guid("ddc81066-83bd-4e4b-9a3f-ed91ffb4f987") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3163), new Guid("2882d4f0-1933-4d32-923e-439ef5c87d0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3175), new Guid("82d5ff8d-c16a-4c3a-aa8b-6801e9d4d04b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3186), new Guid("2f20166f-a111-4ab9-9d32-bb4887260fd8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3201), new Guid("3804f496-eeeb-429f-8db5-6976716a7337") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PName" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3224), new Guid("51967193-6583-4aff-b475-4d5a8e8f3c8a"), "F_AllReview" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PName" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3236), new Guid("f475bd6e-f63d-4dbb-a931-651a1ce3be19"), "F_Review" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3247), new Guid("f1c0b03c-9684-4c59-b830-be78f30338da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3267), new Guid("21bdb587-0b71-4788-9604-4d7717b53aad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3281), new Guid("b5cac494-e195-4d36-818a-f81906c9f9d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PName" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3310), new Guid("10429029-9fd8-4cf3-812f-92a815c1d35d"), "F_Request" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3322), new Guid("b2557215-bd66-4612-91ff-da1152f4f520") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3336), new Guid("3eb8d1a7-4321-45b8-880c-5d96d978e39d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3348), new Guid("7b330965-e75a-4171-a768-96be1d3f9029") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3398), new Guid("96fc22c1-6cc5-43f9-86c5-8d4cce6cee2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3413), new Guid("aacdbf56-56b2-4a68-aeaa-01a40562299b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2189), new Guid("9f7a022e-0d96-46fa-bb32-44e92f17ddcc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2235), new Guid("e0c5099a-eca6-4e44-89cc-86d5ff6f87fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2244), new Guid("3acaeb54-2a8e-4a18-bb92-008df17d894a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2373), new Guid("09bd0d9c-16c5-4bd1-a1be-d8b12da81722") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2385), new Guid("f79e58f7-8ce7-4c52-94a7-b5d5eb80dd6f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2393), new Guid("d0fd70b9-649b-478a-a8f4-a6772c8b23d4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2409), new Guid("6b967d92-2491-4eb6-85fd-e9fd7d3055b1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2417), new Guid("df681d20-0001-4764-938d-50dd281977fb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2490), new Guid("32ace0b1-358d-4c96-968f-238dd5d2512a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2905), new Guid("1a40b296-32fe-4222-86fa-f2f9df44a283") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2915), new Guid("b8dde870-744d-4426-a740-d9ef91ec8819") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2924), new Guid("3a4789cf-77de-473c-a751-73b7b235dc75") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2931), new Guid("636eb702-e0f3-4282-a975-bcca416f0c3b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2939), new Guid("8a0871e7-fd60-4e46-9e15-0d5a94da6d6f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2946), new Guid("e7696a66-9e6f-413d-a8dd-afd07a67794a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2954), new Guid("96358dca-8149-4828-b864-3b9aaa42cc4d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(1557), new Guid("88560a35-aeb9-45ee-b399-68e739fbd377") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(1696), new Guid("49070f46-640b-489c-a69c-9088ed58323d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(1705), new Guid("a48aa6b7-ff50-47c4-bc01-539701fe6dc3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2084), new Guid("0b005990-4407-469a-8585-0e08a2c5048b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2098), new Guid("168ef5ea-4e89-454e-b836-6013228861b0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2140), new Guid("a913935f-b017-4647-9be3-ee2094940c5b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2149), new Guid("eba9a8b7-9200-417d-b6c6-544913e8cfbb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2831), new Guid("ac316d27-65eb-4611-b50a-9f682e0afb1c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2842), new Guid("dab85a84-3d83-455d-af04-99511ac248c8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2850), new Guid("d8c10c81-3465-4f9e-9b7a-d35a795845c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2858), new Guid("338a6b28-ca9e-46cb-a113-0aa3f112528a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2865), new Guid("ac36ddfa-e270-4efd-8141-c89e5ffa1204") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2612), new Guid("0b8a7570-26fa-40d0-a9f8-b8b2d046cbd8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2627), new Guid("21d5ed79-baf9-4f2b-97d1-eec056f544f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2635), new Guid("12891713-5fa5-4b45-ac7b-fb5d5c9f1748") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2643), new Guid("69067839-42d8-4ade-915c-4d68f7966e17") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2651), new Guid("722171bb-0ca7-4cbc-982d-f38a4ea142d0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2658), new Guid("77427036-b4c8-4e90-a219-928d25bdfad8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2668), new Guid("3333becf-08dd-4ffd-89fc-1931c7f70d0d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2676), new Guid("231fa6a5-55a3-4314-b4e7-aad4d3161e8f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2684), new Guid("d40b8498-4215-4682-befc-11bc6ac34fcb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2694), new Guid("c3511315-89b9-455c-99d5-799aaf387a8d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2556), new Guid("52cbdd06-918d-4867-85a8-d92ca0a6c5b1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2566), new Guid("b9489be7-da1c-48b2-afe7-00362a4c7373") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2573), new Guid("27cbf214-3dc1-4178-96f0-6672c1ee5750") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2581), new Guid("cc20b8a4-954f-4d8a-bed2-cd1dce2a0ebb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2745), new Guid("2508d175-f130-4ad3-8339-eb2c920c4dfc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2755), new Guid("c31f1edc-a146-4b0e-a02c-3e95ef6d61e5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3525), new Guid("a65f991f-a53f-4032-bed1-bc2d7523e705") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3543), new Guid("76a495af-94ae-4c73-a80e-f975dcaf6613") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3554), new Guid("fd4372a1-e47e-444c-b739-bb43f22a1e9a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3563), new Guid("424843e9-9b0b-4e2f-947c-49ad35b7975b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3617), new Guid("32e279d4-0009-4838-b5bb-2891f9369b2c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(4501), new Guid("04759dd1-a3d9-4646-bb1c-0d7a3025bc72") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(4587), new Guid("96f39cec-1cd0-4d1d-921a-84030094542f") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(4597), new Guid("08b7b51b-eb02-4cdd-9139-762cee499e71") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(4605), new Guid("e219a4be-4b48-4120-8493-f3fae5f482c3") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3474), new Guid("e7dd5980-586c-4fad-80ad-95a0edf7f134") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3484), new Guid("2711fbef-f866-48e7-84ed-782ea09725ff") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3492), new Guid("77f77d37-23c2-411c-a1b9-0b12615468be") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5318), new Guid("833f8fca-43d8-404f-9a87-d03f0a5f454b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5329), new Guid("69fd4678-a3c1-4c63-94c4-3163cb9e4305") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5336), new Guid("8145e514-19de-4222-9ea9-2fae8aea84bc") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5344), new Guid("d5e1b174-6440-45bd-bc13-4cc400fb30db") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5351), new Guid("68689508-36ab-4db6-8826-5d1bfd3a3566") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(4840), new Guid("51899518-7884-4e1c-b800-64f1661beb0c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(4999), new Guid("b63cf637-463b-4dbe-af7c-2af3323289a3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5048), new Guid("405f2607-790c-4c81-8532-e03d0e6f172f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5073), new Guid("a7f2ad5d-6597-4a28-b568-f2d82d7b195e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5087), new Guid("f1ed4c6b-444f-474e-ab35-1dab8578f212") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5150), new Guid("e9315fec-7b70-46d6-9aa9-9cc7e5434bd2") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5182), new Guid("a2f2b797-02d0-46c7-aa69-c66f36ec01cd") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(4786), new Guid("1be4f137-f79c-4405-9c0c-a50b4a01bda9") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(4797), new Guid("c9cd85a7-06b2-4e29-8954-430a5c90426d") });

            migrationBuilder.CreateIndex(
                name: "IX_F_AllReview_AAP_Current_ReviewId",
                schema: "Facts",
                table: "F_AllReview",
                column: "AAP_Current_ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllReview_AAP_Last_ReviewId",
                schema: "Facts",
                table: "F_AllReview",
                column: "AAP_Last_ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllReview_CreateTimeRecord",
                schema: "Facts",
                table: "F_AllReview",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllReview_DsblRecord",
                schema: "Facts",
                table: "F_AllReview",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllReview_LastUpdatedRecord",
                schema: "Facts",
                table: "F_AllReview",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllReview_Parent_Id",
                schema: "Facts",
                table: "F_AllReview",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllReview_PCode",
                schema: "Facts",
                table: "F_AllReview",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllReview_PERPCode",
                schema: "Facts",
                table: "F_AllReview",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllReview_PIndex",
                schema: "Facts",
                table: "F_AllReview",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllReview_PName",
                schema: "Facts",
                table: "F_AllReview",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_CreateTimeRecord",
                schema: "Facts",
                table: "F_Request",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_DsblRecord",
                schema: "Facts",
                table: "F_Request",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Request",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_Parent_Id",
                schema: "Facts",
                table: "F_Request",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_PCode",
                schema: "Facts",
                table: "F_Request",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_PERPCode",
                schema: "Facts",
                table: "F_Request",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_PIndex",
                schema: "Facts",
                table: "F_Request",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_PName",
                schema: "Facts",
                table: "F_Request",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_RI_AllApproveId",
                schema: "Facts",
                table: "F_Request",
                column: "RI_AllApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_RI_CreatorId",
                schema: "Facts",
                table: "F_Request",
                column: "RI_CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_RI_ProcessId",
                schema: "Facts",
                table: "F_Request",
                column: "RI_ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_RI_ProcessStateId",
                schema: "Facts",
                table: "F_Request",
                column: "RI_ProcessStateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Request_RI_RequestorId",
                schema: "Facts",
                table: "F_Request",
                column: "RI_RequestorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_APV_EndorsementId",
                schema: "Facts",
                table: "F_Review",
                column: "APV_EndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_APV_NeedReviewId",
                schema: "Facts",
                table: "F_Review",
                column: "APV_NeedReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_APV_ReviewId",
                schema: "Facts",
                table: "F_Review",
                column: "APV_ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_APV_UserInChargeId",
                schema: "Facts",
                table: "F_Review",
                column: "APV_UserInChargeId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_CreateTimeRecord",
                schema: "Facts",
                table: "F_Review",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_DsblRecord",
                schema: "Facts",
                table: "F_Review",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Review",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_Parent_Id",
                schema: "Facts",
                table: "F_Review",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_PCode",
                schema: "Facts",
                table: "F_Review",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_PERPCode",
                schema: "Facts",
                table: "F_Review",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_PIndex",
                schema: "Facts",
                table: "F_Review",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_PName",
                schema: "Facts",
                table: "F_Review",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_F_Attachment_F_Review_F_ReviewId",
                schema: "Facts",
                table: "F_Attachment",
                column: "F_ReviewId",
                principalSchema: "Facts",
                principalTable: "F_Review",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_F_Request_F_RequestId",
                schema: "Facts",
                table: "F_Condition",
                column: "F_RequestId",
                principalSchema: "Facts",
                principalTable: "F_Request",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_AllReview_F_Review_AAP_Current_ReviewId",
                schema: "Facts",
                table: "F_AllReview",
                column: "AAP_Current_ReviewId",
                principalSchema: "Facts",
                principalTable: "F_Review",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_AllReview_F_Review_AAP_Last_ReviewId",
                schema: "Facts",
                table: "F_AllReview",
                column: "AAP_Last_ReviewId",
                principalSchema: "Facts",
                principalTable: "F_Review",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Attachment_F_Review_F_ReviewId",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_F_Request_F_RequestId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_AllReview_F_Review_AAP_Current_ReviewId",
                schema: "Facts",
                table: "F_AllReview");

            migrationBuilder.DropForeignKey(
                name: "FK_F_AllReview_F_Review_AAP_Last_ReviewId",
                schema: "Facts",
                table: "F_AllReview");

            migrationBuilder.DropTable(
                name: "F_Request",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_Review",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_AllReview",
                schema: "Facts");

            migrationBuilder.RenameColumn(
                name: "F_RequestId",
                schema: "Facts",
                table: "F_Condition",
                newName: "F_RequestInformationId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Condition_F_RequestId",
                schema: "Facts",
                table: "F_Condition",
                newName: "IX_F_Condition_F_RequestInformationId");

            migrationBuilder.RenameColumn(
                name: "F_ReviewId",
                schema: "Facts",
                table: "F_Attachment",
                newName: "F_ApproveId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Attachment_F_ReviewId",
                schema: "Facts",
                table: "F_Attachment",
                newName: "IX_F_Attachment_F_ApproveId");

            migrationBuilder.CreateTable(
                name: "F_AllApprove",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    AAP_Current_ApproveId = table.Column<long>(type: "bigint", nullable: true),
                    AAP_Last_ApproveId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_AllApprove", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_AllApprove_F_AllApprove_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_AllApprove",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Approve",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    APV_UserInChargeId = table.Column<long>(type: "bigint", nullable: true),
                    APV_EndorsementId = table.Column<long>(type: "bigint", nullable: true),
                    APV_NeedApproveId = table.Column<long>(type: "bigint", nullable: true),
                    APV_ApproveId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Approve", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Approve_D_User_APV_UserInChargeId",
                        column: x => x.APV_UserInChargeId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Approve_F_AllApprove_APV_ApproveId",
                        column: x => x.APV_ApproveId,
                        principalSchema: "Facts",
                        principalTable: "F_AllApprove",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Approve_F_AllApprove_APV_NeedApproveId",
                        column: x => x.APV_NeedApproveId,
                        principalSchema: "Facts",
                        principalTable: "F_AllApprove",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Approve_F_Approve_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_Approve",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Approve_F_Endorsement_APV_EndorsementId",
                        column: x => x.APV_EndorsementId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_RequestInformation",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true),
                    RI_ERPID = table.Column<long>(type: "bigint", nullable: true),
                    RI_IsCancelled = table.Column<bool>(type: "bit", nullable: true),
                    IsTest = table.Column<bool>(type: "bit", nullable: true),
                    RI_PE_Level = table.Column<byte>(type: "tinyint", nullable: true),
                    RI_RequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RI_RequestFinishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RI_RequestorId = table.Column<long>(type: "bigint", nullable: true),
                    RI_CreatorId = table.Column<long>(type: "bigint", nullable: true),
                    RI_AllApproveId = table.Column<long>(type: "bigint", nullable: true),
                    RI_ProcessStateId = table.Column<long>(type: "bigint", nullable: true),
                    RI_RequestTitleId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_RequestInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_ProcessState_RI_ProcessStateId",
                        column: x => x.RI_ProcessStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_ProcessState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_Process_RI_RequestTitleId",
                        column: x => x.RI_RequestTitleId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Process",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_User_RI_CreatorId",
                        column: x => x.RI_CreatorId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_D_User_RI_RequestorId",
                        column: x => x.RI_RequestorId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_F_AllApprove_RI_AllApproveId",
                        column: x => x.RI_AllApproveId,
                        principalSchema: "Facts",
                        principalTable: "F_AllApprove",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_RequestInformation_F_RequestInformation_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Facts",
                        principalTable: "F_RequestInformation",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(2696), new Guid("796d43d2-a6c5-478b-9e9a-207e3ee42700") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(2811), new Guid("8e0749cc-6a10-4b52-99b7-12ccd1fb6cd5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(2825), new Guid("cd694a99-8ab8-4c92-82af-7c489442ffb9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3002), new Guid("4425a82b-5ed4-4106-8e00-ab0c9e34c3ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3022), new Guid("d9db2d5c-8edb-47e1-8411-b41642e6e9d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3040), new Guid("c3483c99-0f42-490d-96ed-9ebc5f020cb9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3055), new Guid("b1dde37e-a066-4369-9bbc-dc371e4b9ba9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3067), new Guid("692a6d1c-99dd-4d7f-b9ea-4886947b09cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3084), new Guid("9c365199-0068-4a5b-9a4d-ed5f6d831f55") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3097), new Guid("0bac833b-c626-48d0-9a10-57b202814f6d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PName" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3110), new Guid("a66b2faf-55fd-41b3-8372-46aeb4b6d689"), "F_AllApprove" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PName" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3123), new Guid("44204c2f-6a42-417b-b1b8-1fa5fd8702bb"), "F_Approve" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3136), new Guid("8ceb5e63-2f5a-47ad-8fff-e945a0c98d48") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3153), new Guid("4353a5df-0fb3-40df-8fad-41748f355e8b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3167), new Guid("9d2e148a-221b-4e90-ab4c-71125bf0888a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PName" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3203), new Guid("ca98b4cb-3974-406a-94e8-b9109eb2fe8b"), "F_RequestInformation" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3218), new Guid("daa2cace-cb74-4fda-a433-307a77c72cf1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3230), new Guid("1481aca5-903c-497f-8f1a-6889e23fd1ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3243), new Guid("1c81c16a-a52d-4b83-ad69-0f592c508f3e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3310), new Guid("fd07abcf-6160-4e39-bcad-e3a4e4cd5254") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3325), new Guid("8011e2ad-7452-4fa5-966e-8e2d4a1dab66") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(465), new Guid("86d5e2c2-6741-489d-8f06-1caa619da61c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(798), new Guid("4e222d8e-3f00-475c-8152-84675a3cb1ed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(827), new Guid("1f31a0a2-b848-4446-820e-1ed19f7a3e2d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(885), new Guid("9a1e4eba-cd3e-4c6c-ba07-abc327e7d855") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(895), new Guid("b52dd977-4733-49e4-9171-7a327562aa44") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(903), new Guid("c631595a-8ca7-4b83-b330-d23da55bc3d4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(914), new Guid("a53ce2a5-76b4-435c-b0df-7469fa5bfff0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(921), new Guid("b40586d1-2b6f-4724-9df6-bbb61a5846e6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(1010), new Guid("fd6ef983-6cca-4459-8181-a3df36ee83cb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(2581), new Guid("dec4a094-f1ac-4b57-92e3-b3c5cd0330e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(2594), new Guid("1ee89c58-6013-4463-ab17-122b37109021") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(2603), new Guid("11f12b17-e3c7-4840-87e3-75aedf4a3c37") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(2612), new Guid("75fc82c7-1e5c-4310-a4ae-d8231a54ad34") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(2625), new Guid("d220b3c3-cca4-4e74-adc0-570d08517170") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(2632), new Guid("25ce8533-62d4-4ce4-ac19-74bd75b4b34d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(2641), new Guid("94871c5d-e8c7-4c8d-bdd2-439a47a001b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 963, DateTimeKind.Local).AddTicks(8151), new Guid("a946cc7e-75fd-4cba-b876-5c0469ec6bf0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 963, DateTimeKind.Local).AddTicks(8324), new Guid("681935c1-7d53-4f30-b37b-7aaca25cf823") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 963, DateTimeKind.Local).AddTicks(8337), new Guid("ba40f28f-3a7f-489f-8461-64d80b55bc59") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(175), new Guid("44fe53c4-04c0-4846-b101-7e527cabbf0a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(329), new Guid("dc2dcd5c-ffba-41ab-943a-a25fb5c5b21c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(369), new Guid("168d0148-395a-4b8b-8dcf-d60136cc7122") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(376), new Guid("57cf76a3-250c-4490-8228-11a4bd72d0ac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(2441), new Guid("c28c0111-c0a3-4965-b29f-e04858c34118") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(2474), new Guid("0ce93aa6-67b5-4dc2-8a43-6a66d901447f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(2487), new Guid("afb6efa1-feb2-4a7b-adfe-6fafdb8cafba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(2496), new Guid("6c50f1fd-bc53-4ccb-9709-8c129a3756d3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(2505), new Guid("d7cf4fe7-2c9c-4993-aec0-e17911a13a5e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(1154), new Guid("664bcaa4-9644-41ca-8890-86f75fb4d2ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(1165), new Guid("56ad3583-f695-4ab8-985e-6dd41f96ea7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(1174), new Guid("342ed24d-7b41-427e-bd4a-e149212f59a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(1183), new Guid("c00e50f0-89f0-4554-9c75-f94ea79128fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(1191), new Guid("cb7e4d20-4835-400c-800e-a5dd3a9f5ccf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(1201), new Guid("3d12537d-58bc-4a53-a6e7-e7bdfcd5e167") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(1208), new Guid("ea3d53ff-8260-4dee-ab1e-fc9ca3dd04c7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(1216), new Guid("78c778dc-6e8e-4f76-a53c-d1bba462d26a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(1227), new Guid("a30862a4-bccd-429d-bf56-79744a2a35d3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(1236), new Guid("25f5f79c-bcfc-44d5-b6ef-0f4844609356") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(1083), new Guid("5310982d-f454-4a83-819b-508a37927427") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(1098), new Guid("0304811d-2e95-455d-a8d3-122003f2be20") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(1107), new Guid("972328e3-2a5c-4a38-9dbe-0ef7a5978a8e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(1114), new Guid("51d06804-6ea6-4011-8bc2-b590501de357") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(1375), new Guid("8dbaf1c2-c677-4a6d-9a9f-c6b1a3183ec6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(2013), new Guid("fe701e55-e715-417f-8f51-9145f4cd2879") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3463), new Guid("8ef70bb2-7a6b-43d6-86be-ce1d3048b6c4") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3480), new Guid("176bca4c-a514-46b5-83d0-4ab639d79869") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3492), new Guid("d8e41a94-6f54-4aef-bc0e-0177b6a30141") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3501), new Guid("6b9af8c5-cf0d-4cfb-acf6-0d3394fe34ee") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3511), new Guid("bcd21793-7c54-4818-80bb-551624c55d29") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3557), new Guid("273a90ef-fbc4-4642-b055-b7f0dbe8f039") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3568), new Guid("338b9498-52b9-4c75-bbca-628444ed320f") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3581), new Guid("24f92583-6122-4885-94ba-85c10ea5dac5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3593), new Guid("27b44769-95f4-46f8-a8ee-89c69a1b3bdc") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3403), new Guid("da4f7cc0-4469-40f7-bdc3-2bdda153a9c7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3413), new Guid("07f525bf-c0ca-4c51-a3e6-e93905c4d483") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3421), new Guid("b34e17bf-6fd3-4fca-88bc-86b12c060c54") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(4002), new Guid("83ebafbe-27f0-4e0e-a16b-55baaf6092cb") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(4062), new Guid("f06227ec-a9b8-4230-adbc-77684b3cacdc") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(4087), new Guid("302a52d1-d8cb-4d9a-800f-d7adac4c3247") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(4114), new Guid("16be4f68-1f5b-4484-81d5-2b54e3a93bc5") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(4142), new Guid("eba58679-7318-4bb6-8ee5-53ad8e6e8e72") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3745), new Guid("62f6eb78-23c2-49b9-bc77-0a8959fb1743") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3781), new Guid("885afee4-44a3-4018-a741-9ef05c502784") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3795), new Guid("a4a70f74-8916-4c45-8309-f8e6c4e57a91") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3801), new Guid("363bc84b-a59f-4d74-bc3c-3180c94efb7b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3807), new Guid("513f65a8-6f45-4bd3-ae22-90d4755b3abf") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3813), new Guid("7030afed-b2b5-4217-a764-092a47c51574") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3825), new Guid("ec96eb31-ce90-4026-8691-6c2765dd8c5e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3639), new Guid("ed050296-3f90-4bd5-a5e1-978097c5f1a3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 11, 3, 965, DateTimeKind.Local).AddTicks(3652), new Guid("e91bbc03-2c25-4d2a-b987-c4d8002c0926") });

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_AAP_Current_ApproveId",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Current_ApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_AAP_Last_ApproveId",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Last_ApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_CreateTimeRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_DsblRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_LastUpdatedRecord",
                schema: "Facts",
                table: "F_AllApprove",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_Parent_Id",
                schema: "Facts",
                table: "F_AllApprove",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PCode",
                schema: "Facts",
                table: "F_AllApprove",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PERPCode",
                schema: "Facts",
                table: "F_AllApprove",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PIndex",
                schema: "Facts",
                table: "F_AllApprove",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_AllApprove_PName",
                schema: "Facts",
                table: "F_AllApprove",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_APV_ApproveId",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_ApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_APV_EndorsementId",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_EndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_APV_NeedApproveId",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_NeedApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_APV_UserInChargeId",
                schema: "Facts",
                table: "F_Approve",
                column: "APV_UserInChargeId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_CreateTimeRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_DsblRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_LastUpdatedRecord",
                schema: "Facts",
                table: "F_Approve",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_Parent_Id",
                schema: "Facts",
                table: "F_Approve",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PCode",
                schema: "Facts",
                table: "F_Approve",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PERPCode",
                schema: "Facts",
                table: "F_Approve",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PIndex",
                schema: "Facts",
                table: "F_Approve",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Approve_PName",
                schema: "Facts",
                table: "F_Approve",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_CreateTimeRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_DsblRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_LastUpdatedRecord",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_Parent_Id",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PCode",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PERPCode",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PIndex",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_PName",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_AllApproveId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_AllApproveId");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_CreatorId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_ProcessStateId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_ProcessStateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_RequestorId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_RequestorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_RequestInformation_RI_RequestTitleId",
                schema: "Facts",
                table: "F_RequestInformation",
                column: "RI_RequestTitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Attachment_F_Approve_F_ApproveId",
                schema: "Facts",
                table: "F_Attachment",
                column: "F_ApproveId",
                principalSchema: "Facts",
                principalTable: "F_Approve",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_F_RequestInformation_F_RequestInformationId",
                schema: "Facts",
                table: "F_Condition",
                column: "F_RequestInformationId",
                principalSchema: "Facts",
                principalTable: "F_RequestInformation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Current_ApproveId",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Current_ApproveId",
                principalSchema: "Facts",
                principalTable: "F_Approve",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_AllApprove_F_Approve_AAP_Last_ApproveId",
                schema: "Facts",
                table: "F_AllApprove",
                column: "AAP_Last_ApproveId",
                principalSchema: "Facts",
                principalTable: "F_Approve",
                principalColumn: "Id");
        }
    }
}
