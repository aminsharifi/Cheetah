using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class delete_condidates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_User_F_Assignment_F_AssignmentId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Assignment_F_Review_PRM_ReviewId",
                schema: "Facts",
                table: "F_Assignment");

            migrationBuilder.DropIndex(
                name: "IX_F_Review_APV_AssignmentId",
                schema: "Facts",
                table: "F_Review");

            migrationBuilder.DropIndex(
                name: "IX_F_Assignment_PRM_ReviewId",
                schema: "Facts",
                table: "F_Assignment");

            migrationBuilder.DropIndex(
                name: "IX_D_User_F_AssignmentId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.DropColumn(
                name: "F_AssignmentId",
                schema: "Dimentions",
                table: "D_User");

            migrationBuilder.CreateTable(
                name: "L_UserAssignment",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: true),
                    PIndex = table.Column<long>(type: "bigint", nullable: true),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: false),
                    SecondId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserAssignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserAssignment_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_UserAssignment_F_Assignment_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Assignment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9543), new Guid("340bb41d-8660-4fc5-beb8-57d30e533407") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9699), new Guid("d6745d2f-7a25-4121-bdeb-98a64fc48de9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9724), new Guid("dc5065fb-32f5-419e-b48b-ccb2e305919b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9734), new Guid("2c7463d5-1df2-4552-9c8e-c28a1e63d39a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9743), new Guid("0ec09bd4-aad0-4957-a777-d909e02b4cbd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9952), new Guid("15505db4-2762-4e10-a2b8-73cc03bdd611") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9961), new Guid("f64bca87-28c2-4990-8f1d-075dd2a947a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9971), new Guid("5b26d318-2efe-4a23-a1ff-224227cac25e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9979), new Guid("ea3540b6-1f58-45a0-86c2-6395682bc0ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9988), new Guid("fc2b2fed-b615-4b5b-9708-8b467709ed39") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9996), new Guid("b7b05d3d-d578-4f21-b4ae-dc284e89f2ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(7), new Guid("9d6631f5-a735-465b-9d7f-6a4223cb3e71") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(15), new Guid("0ddb95b8-5d9b-4817-9fdd-7a116ea044a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(24), new Guid("0a5b5a70-c41a-48ae-bbc5-dcf68094dd9a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(32), new Guid("44f02015-b565-4c56-8ed0-25525cd57d83") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(41), new Guid("b2563cf6-d51c-4ad7-86cc-e74dc5039903") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(50), new Guid("e703d569-47ce-4d5f-96c8-5a03b41e81bb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(73), new Guid("af77b81e-3baa-4806-99cb-dcda0c8cb71a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(82), new Guid("12297d03-2239-4485-a7e2-3a39acf349c7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(93), new Guid("f75ee6c6-6afd-4380-bcc7-e8101cc73683") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(101), new Guid("e0f28276-4f02-46b6-a962-3bc2ccbdd0e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9171), new Guid("224bc97c-7939-4758-ab4f-df3eeeee1574") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9186), new Guid("d6610b67-3286-42cb-a911-46ca55386b44") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9191), new Guid("6230f6d2-7ca8-4f61-84c8-bec156d0c695") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9216), new Guid("32317caf-9e6e-48dd-8172-fb769acbb4a0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9222), new Guid("ba500f37-f464-44dc-ab44-2c4dd13c2e69") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9226), new Guid("5d491f9e-1e7a-46a4-8e98-4d61328c3332") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9231), new Guid("a570c4e6-9719-4f0f-91ca-3e997475dab6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9236), new Guid("aa5d0936-4bd4-4471-a3db-887df0cf20a7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9243), new Guid("70425704-aa6b-4d81-97f0-b211ddf62614") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9484), new Guid("fc563e7c-0c2c-42c0-b794-df16684c6a11") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9490), new Guid("5ced93ef-3734-43c7-9db9-aa2bcdea4ef5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9496), new Guid("ed20d510-d613-43ec-a56c-34fb51e07053") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9501), new Guid("5f676e16-cc50-4669-8839-06964e3746c5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9506), new Guid("d74b3441-4b8d-4ccb-b17d-7183a9d43887") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9511), new Guid("348aedb3-8fdb-4cf8-b292-afc7ede04c70") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9516), new Guid("4fe8c23c-efff-4767-abb7-326f613f6145") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(8738), new Guid("dfe7ed00-e5ff-4680-a3cd-af373ade1e85") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(8846), new Guid("0ead6b37-9274-45b5-a453-163c82f7ac7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(8852), new Guid("e3c49255-6ae2-45a6-84c1-56bafa08c021") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9105), new Guid("8a042d20-3f67-4ea3-9e3c-ee9493638bee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9112), new Guid("9f2e23c5-4038-4ffb-8bfe-7bf9b79a7f6a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9118), new Guid("d99295dd-6015-4406-9457-3ac3af2f51e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9123), new Guid("7b05f2fc-e840-49f5-9e45-3c314adf7dda") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9436), new Guid("286dde8c-145c-4f33-9f65-a7c9f51f0d02") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9442), new Guid("04ee8744-8364-4e05-aa3a-786071683cdc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9449), new Guid("6db64eab-4e5c-426b-a6a5-67b6232e9cf2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9453), new Guid("77b04aae-b7f2-4c39-b949-5437b802496c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9459), new Guid("d821c918-fc5c-48f0-b4dc-0d10ba12b78d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9316), new Guid("dbd26723-4161-40ef-8038-e1bc28cf91ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9321), new Guid("f16d4589-16aa-4d40-adc5-d759c9065678") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9326), new Guid("afc430f0-ca64-400f-9c48-87e00c4a9f9b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9333), new Guid("b10d5f72-bbf2-4c85-b117-5b6ca02360bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9338), new Guid("673f3c34-9cf8-49f8-92e7-99a803c4798b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9343), new Guid("46abebc8-c99f-4c24-9acd-3855a75195ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9350), new Guid("246e0295-90d2-43cd-8c7a-679effe80fd2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9355), new Guid("ce6eab60-05fe-4100-914f-2753b4323191") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9360), new Guid("c628ceca-7eb4-4ae9-88da-5cf6df181b35") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9365), new Guid("35f53640-4fa5-4544-9815-0e322fb6fd25") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9277), new Guid("8716c345-f2e0-4b82-b9d3-224fff6c0575") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9283), new Guid("e95f7c05-5e3d-4e4d-ae02-17a5d9a95e2e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9287), new Guid("a66bfe33-2fc6-4202-94ce-d13aba62e679") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9292), new Guid("8cc2913e-665c-4e14-9e74-2f0204d37fa7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9395), new Guid("cec5d728-2521-42e3-894d-2af6bf4c6d55") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 206, DateTimeKind.Local).AddTicks(9414), new Guid("fe70954f-5687-49f8-b7b9-83d80616ecbb") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(221), new Guid("438915c2-7a59-444c-a196-97b6d0800529") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(231), new Guid("04d85de4-8aee-4393-9dd2-2776a75fea3d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(238), new Guid("fb6a71f1-48e3-4fab-95f9-16d315866735") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(245), new Guid("f68e96d5-84b4-4f6e-8f59-55a043977edf") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(251), new Guid("7a479107-fb69-4008-af27-e32229dfc94b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(276), new Guid("1678c4db-4712-40f4-b9ba-73bb5af63f41") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(284), new Guid("41bb6e43-8c84-4bee-bb67-2943ddb6a36d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(297), new Guid("07073b84-2da2-4b34-90ec-0d04e70e1de8") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(306), new Guid("ac682558-0819-420e-83bf-2c20eb33fa4c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(182), new Guid("b616b0cd-0a01-48c2-a110-02d91a6bd8a0") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(189), new Guid("3fc9c67f-aca3-4db2-ac69-3fcfbcccedc9") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(194), new Guid("8c260d26-e710-4ed4-ad37-b6a30d24e9ff") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(430), new Guid("042d8c37-6719-4457-86d3-8fe70f2e8703") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(438), new Guid("4f959080-163d-4645-88e2-e6da4db7dbf1") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(442), new Guid("b752c7d6-ed97-48e2-8923-dda6ae32c808") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(447), new Guid("5113ccbc-c38f-4a1a-8332-480f1d116267") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(452), new Guid("f4514a6a-3fe1-4c6b-b075-7e69f04647f5") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(367), new Guid("b6ba4e7d-0c42-44fd-8c76-269d54f0eede") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(373), new Guid("4b6df5c5-a6d5-4c9b-8592-8167b69c3cfb") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(378), new Guid("a8543314-bec6-4e82-80ba-d2035a45e26b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(382), new Guid("26647a60-400a-420f-b0e4-15f522b1b75d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(389), new Guid("a814c069-f35f-4cb8-97bc-b96b16646387") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(394), new Guid("e0386d43-9d8c-4959-af78-744de0938f07") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(399), new Guid("d622c065-57bc-4ebc-bd72-6a4246c2db07") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(335), new Guid("82d1c9aa-4bc7-42ab-89da-cbb0ef4b4a07") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(342), new Guid("d95e8273-b480-4d6e-85f9-0919689269a4") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(474), new Guid("79c2779c-fce8-4b77-a5df-fd1f6a3cc346") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 41, 42, 207, DateTimeKind.Local).AddTicks(480), new Guid("e4649dd7-ae6c-450a-8195-2f6ed4250f89") });

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_APV_AssignmentId",
                schema: "Facts",
                table: "F_Review",
                column: "APV_AssignmentId",
                unique: true,
                filter: "[APV_AssignmentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_CreateTimeRecord",
                schema: "Links",
                table: "L_UserAssignment",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_DsblRecord",
                schema: "Links",
                table: "L_UserAssignment",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_FirstId",
                schema: "Links",
                table: "L_UserAssignment",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_LastUpdatedRecord",
                schema: "Links",
                table: "L_UserAssignment",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_PCode",
                schema: "Links",
                table: "L_UserAssignment",
                column: "PCode",
                unique: true,
                descending: new bool[0],
                filter: "[PCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_PERPCode",
                schema: "Links",
                table: "L_UserAssignment",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_PIndex",
                schema: "Links",
                table: "L_UserAssignment",
                column: "PIndex",
                unique: true,
                descending: new bool[0],
                filter: "[PIndex] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_PName",
                schema: "Links",
                table: "L_UserAssignment",
                column: "PName",
                unique: true,
                descending: new bool[0],
                filter: "[PName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_UserAssignment_SecondId",
                schema: "Links",
                table: "L_UserAssignment",
                column: "SecondId",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "L_UserAssignment",
                schema: "Links");

            migrationBuilder.DropIndex(
                name: "IX_F_Review_APV_AssignmentId",
                schema: "Facts",
                table: "F_Review");

            migrationBuilder.AddColumn<long>(
                name: "F_AssignmentId",
                schema: "Dimentions",
                table: "D_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4700), new Guid("6f541730-e5e9-4bb9-a297-76a08db5ea0a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4767), new Guid("9a2ed79e-9527-49ee-bcc2-b80af7916200") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4781), new Guid("6e955044-2b4e-4537-ba8e-a7cf8734c713") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4797), new Guid("fdd002c1-b2cf-4f00-9ee9-f6dbdd05f5a0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4897), new Guid("081c33a1-ccff-48a0-b00b-042054e26a88") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4917), new Guid("c869500f-f88a-479f-9bc2-b41eec76346b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4930), new Guid("59afddb0-e0e5-41e7-b0d9-5f801d3e0537") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4943), new Guid("4eff096a-690a-4f24-9b10-e8481928366f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4955), new Guid("2f03defe-a320-4b1d-b710-745f00420855") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4970), new Guid("b659f356-53c1-4c0b-b877-6d825c1d142a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4983), new Guid("62939f2b-5223-4e3b-b14d-f8a69fcde681") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5001), new Guid("7d53ce0c-f0be-4dab-bde5-1ad22b1c5013") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5012), new Guid("d57ffdc0-cf62-485e-9cb5-a31576954ee6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5025), new Guid("eda901db-f780-484c-bdeb-005f40c6bba0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5037), new Guid("631c2378-d0fb-482e-9a01-db98a072a445") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5058), new Guid("04a02718-f88d-4b52-ae97-7956ddbcd76f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5071), new Guid("2200ea08-7630-46e5-a45c-805525c5ce52") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5084), new Guid("2f0cf5b4-de3e-4427-914f-2f19c2ea1bdc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5096), new Guid("c454998b-1c0f-49cc-87cd-0b8b4df101a6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5148), new Guid("1c5cb345-4364-4bee-9147-62c0ed811fc7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5167), new Guid("3195fc0a-e600-46c4-b009-819f857487f5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3884), new Guid("f68a3307-3b88-4802-8305-f2505c1f0687") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3922), new Guid("b56076a9-2e75-4a50-ba23-1ca3fcc36889") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3930), new Guid("f09eb99e-0f73-47ff-b162-1fd30681bb12") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4028), new Guid("348a5e16-27ce-4eef-b52c-1fcbf4d7dc9a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4039), new Guid("779d4d55-3432-42a0-afb8-e6752622da6d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4048), new Guid("a8b0381d-f3f5-4735-8899-7f6afbf5cfb1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4062), new Guid("dc8d6053-808b-4aed-bf52-03d01e3cf8fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4070), new Guid("079ee751-6e38-4951-b027-01c807df7813") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4141), new Guid("2e3863a8-28b7-4aec-b594-6a47e4b8fccd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4603), new Guid("3469a256-fa8b-45a3-b375-de9452f4c569") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4614), new Guid("5415fbd3-a33f-48f0-b789-8e890227f1d0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4625), new Guid("2e50b7d4-aa18-42cd-9722-52fc8f3331e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4633), new Guid("e16d394c-b879-43fb-ad99-ce977961b402") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4643), new Guid("5ce2fb58-6190-42cb-a8da-772a047fe14e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4651), new Guid("340e2a7c-fa23-4cd9-83ed-9e9724bcf23f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4659), new Guid("d1ef36f7-49c0-4d4c-b211-6dc96990b07d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3190), new Guid("1c250876-7391-40d5-a397-31005c9daf08") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3329), new Guid("596062f0-71fd-4c35-b00c-0eeb8617aab7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3339), new Guid("76097811-7ec9-4815-91cf-1611753047ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3773), new Guid("f087cdba-36a1-430a-9430-7224597b6abf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3789), new Guid("e48e9d1d-0a71-4f28-a4e5-ef59c084682e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3811), new Guid("decb3e8a-30e9-40bf-8b64-7870ad29bbcb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(3819), new Guid("48d33df7-20ed-4b2a-b562-e1c34ce3b775") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4530), new Guid("baa7cfe2-859e-49eb-80f7-2ebe399370ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4542), new Guid("832eb17f-2907-4e84-98f6-aaeba80aef55") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4551), new Guid("5d84d5d0-ffd4-4cb8-acda-973e1675c68d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4559), new Guid("f6091525-1336-4038-865d-29e80216ec3e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4567), new Guid("c21e564f-03df-475e-804c-c55ea6db32df") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4259), new Guid("06f50370-a840-43c0-8b38-e329f310fdc1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4269), new Guid("eab959b6-a861-4b80-b5e6-ba4f1f150014") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4278), new Guid("addd2d07-c988-4b35-accf-af19207049b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4291), new Guid("6bbd680b-8bd0-4e95-9fed-d0c476d907ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4304), new Guid("75f4034f-dfc4-483a-a81a-85a6761047fc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4313), new Guid("f62360cb-b4db-494b-bc9d-59f46740bf64") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4322), new Guid("71c1120d-9012-44c1-8031-8836ae476806") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4330), new Guid("6d260619-4efb-4366-9fb6-351f74c4d8bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4340), new Guid("3755f3b5-3e5b-46cb-aa30-d844be0fcd11") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4349), new Guid("8ca20c22-55af-4a27-b896-8be0b22e2805") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4200), new Guid("91c09e7d-4fb6-4945-b4e1-a0cd96063cc5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4210), new Guid("6e36fd2d-7cf5-4528-bd09-340033b2cd8a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4217), new Guid("ba10db8e-1440-4143-98e2-48cc8e183d15") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4225), new Guid("2925afae-e1ac-421a-a857-3ea4aff15e27") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "F_AssignmentId", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4405), null, new Guid("8b6d2b8e-77ba-4195-bd50-c4b2fcc42c62") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "F_AssignmentId", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(4418), null, new Guid("4a6740e6-5cb3-483f-bdce-a385c1fd4d94") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5288), new Guid("177bd54d-ec9d-4034-ba45-50bc19d690c2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5301), new Guid("43d96bb8-3885-4b30-8507-227136167afa") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5310), new Guid("21cc1ac7-2a97-4716-9698-b6ecc16e0899") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5322), new Guid("3a63ca2d-e782-4f5b-a1aa-ff0e619ee562") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5331), new Guid("2ff36702-ff30-4559-83d9-144bef48eaae") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5370), new Guid("311d1027-0550-4acc-be42-c31887b97a8d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5383), new Guid("0366b21d-81c9-4f95-ae45-a14aede4d8d3") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5392), new Guid("2667affc-eb14-4bb6-a8e6-dcb72180e65c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5411), new Guid("65b399d0-9dd9-4f7a-8329-bb45ef52bc73") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5232), new Guid("9779193b-752e-4382-8037-a2c6c013923e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5243), new Guid("9caac6cd-ba50-4a4c-ac81-226e5928aada") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5252), new Guid("d61d4863-f452-4f50-bfb8-bacc11f32ec5") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5733), new Guid("0d434d09-915e-431e-be2f-1ecc7968dc6e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5746), new Guid("3017e7ea-86ef-4ca7-88b4-5fcaf4dc17f7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5756), new Guid("18a9b074-93fa-42af-b239-32a3666b3fc6") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5765), new Guid("085278ca-ff97-4aef-abbd-109cfea7d09b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5773), new Guid("3da0f6e7-1af2-4aea-a336-f349145d8aac") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5617), new Guid("520a43e3-811c-4baf-9679-ac8fc4e08437") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5630), new Guid("aa48ca9d-f6d0-4651-ac5f-3038ae837db3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5641), new Guid("1de90d60-f956-4c62-8c7d-5d90fa51d3f1") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5650), new Guid("90857bd9-9d33-4479-9d38-a4359a407449") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5658), new Guid("a7f69fa7-9786-481c-9e5d-8dadd031ccc4") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5666), new Guid("7251776d-4675-4a43-a7a8-c1568b773390") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5675), new Guid("0eed8bd6-fe7a-46a8-ae56-4129d6b2dd6c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5520), new Guid("fe356d88-2a5c-4a53-9e4e-2131c9ca619a") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5570), new Guid("061e6a24-1bae-4893-91b5-0c43b30bb0ea") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5807), new Guid("253feeb0-ac50-42da-8d6a-2fabe2bd9b79") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 27, 53, 355, DateTimeKind.Local).AddTicks(5817), new Guid("e6df4da3-7807-40aa-ab30-9d067d5410c0") });

            migrationBuilder.CreateIndex(
                name: "IX_F_Review_APV_AssignmentId",
                schema: "Facts",
                table: "F_Review",
                column: "APV_AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Assignment_PRM_ReviewId",
                schema: "Facts",
                table: "F_Assignment",
                column: "PRM_ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_F_AssignmentId",
                schema: "Dimentions",
                table: "D_User",
                column: "F_AssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_D_User_F_Assignment_F_AssignmentId",
                schema: "Dimentions",
                table: "D_User",
                column: "F_AssignmentId",
                principalSchema: "Facts",
                principalTable: "F_Assignment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Assignment_F_Review_PRM_ReviewId",
                schema: "Facts",
                table: "F_Assignment",
                column: "PRM_ReviewId",
                principalSchema: "Facts",
                principalTable: "F_Review",
                principalColumn: "Id");
        }
    }
}
