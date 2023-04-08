using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Change_DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_EndorsementPosition_D_Position_UP_PositionOrgId",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.RenameColumn(
                name: "UP_PositionOrgId",
                schema: "Facts",
                table: "F_EndorsementPosition",
                newName: "UP_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_F_EndorsementPosition_UP_PositionOrgId",
                schema: "Facts",
                table: "F_EndorsementPosition",
                newName: "IX_F_EndorsementPosition_UP_RoleId");

            migrationBuilder.RenameColumn(
                name: "PSO_Independent_Location",
                schema: "Dimentions",
                table: "D_Position",
                newName: "PSO_Independent");

            migrationBuilder.AddColumn<long>(
                name: "D_PositionId",
                schema: "Links",
                table: "L_UserRole",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(4904), new Guid("24747454-0e71-4233-b1fd-33fb9bc684fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(4920), new Guid("420c5667-42e7-4541-9e84-fc2013220e47") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(4952), new Guid("4762f0a4-6780-4b8c-8970-926a8567634e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(4961), new Guid("a5d48bf7-7a2b-4ff0-b621-4540a821812d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5883), new Guid("d40cb603-f537-4394-b60a-24a0258691e2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6118), new Guid("18da25be-11dd-4305-9c91-5f901cc69581") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6137), new Guid("8419adae-daf5-4c06-9aa2-fb75cfce0377") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6151), new Guid("07696eee-7697-421d-8669-f1a9c70d9764") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6163), new Guid("1263b2e1-723e-4365-9cd5-789bf7cbcb4f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6175), new Guid("5bb940c4-df22-4b41-8eb9-46cf02b5e044") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6188), new Guid("810c854d-aae6-4c7f-b60e-52fc82420ceb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6207), new Guid("61003fcb-3b51-4e24-b7d3-c38965efc5cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6220), new Guid("90f4d122-904d-4d5f-9aef-8ecb1179d122") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6233), new Guid("149e5343-843e-47ba-89ce-caf765275247") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6247), new Guid("629c47e6-d74a-4d33-9e5d-1f6f0b41c0a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6259), new Guid("cc50808d-75e9-490a-b134-3fc8dae0b85e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6271), new Guid("c2d1135d-de75-457c-a7bf-2758210b82ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6283), new Guid("48b34b08-61a2-4429-9026-221c82d94966") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6304), new Guid("731a3df7-c850-41a1-b8b4-bfc41ee7a663") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6329), new Guid("0cf045b9-a26b-45e3-acb4-87d76818f887") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6341), new Guid("9aed5c42-dda6-47b7-8d53-3317dd551df8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6352), new Guid("b32c53b3-dfdc-41a9-a256-f2ccf48aca79") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6364), new Guid("39b54d15-2585-4baf-bbb5-333113e0c3cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6376), new Guid("5cce1d45-7423-4b44-8d01-c3a61badc6cb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6388), new Guid("baec47e8-1368-4882-9d5b-24d6b30fdf5d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6630), new Guid("39a62427-c95d-4af2-a67d-4491746fe210") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6657), new Guid("9715d98a-4959-4f6d-92d5-450b6e366af1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6675), new Guid("865b0e40-08e6-4e9f-9747-cc6944b7ab89") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6687), new Guid("8a9020d2-a627-456e-9dae-cc2c9ad12afe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6700), new Guid("bf515837-309b-41a5-ab47-22f648d5c9da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6713), new Guid("d7fef6dc-bf8b-4ab1-a298-83513ed14f0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(6724), new Guid("f82cebdf-dc2b-4fdf-bd57-64d436610b1d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5099), new Guid("6175ecf9-d56d-4045-888f-d16a01284e21") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5108), new Guid("670240d5-e66d-43b8-8bf3-35c1875940e2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5115), new Guid("cd2c5e07-4a6e-41a2-82ea-38643309abdd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5127), new Guid("32cba0e9-9df2-48a8-b761-de0ff81e7154") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5012), new Guid("d0f0d642-41ae-4de2-af92-568aee45dbe1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5052), new Guid("934cecec-edf3-48eb-9b5d-3d24a9f8016b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5059), new Guid("149a0613-140a-4427-b7f1-69c1fa2788c0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5164), new Guid("dc940afb-7c02-4cf5-a73e-dc4b911541c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5284), new Guid("6f8776fd-c52f-49f2-b5e2-472fbab3f8e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5293), new Guid("d5ee53af-17d2-4d9a-8c93-4dbd2c22fc2b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5301), new Guid("30c9a08e-09b9-4040-9af9-f8ee63fc13fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5308), new Guid("a30472b5-3edd-4bd2-bdec-cce0a45d1dc1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5316), new Guid("5e729bca-fabe-4a13-b325-65dc2a8c9871") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5361), new Guid("ee5e9374-11e0-4cde-bc1b-c6f18d8b03b1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5374), new Guid("73876be5-0006-4ca4-83ba-bad23d50c7e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5382), new Guid("1d104f77-bee6-4b33-9592-5f6174f46ec8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5389), new Guid("0a795761-b3f0-43df-a71f-0b6ae4494caf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5397), new Guid("e6037e40-ee4e-437a-82f4-72a083429ee4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5404), new Guid("d2f9ae1c-f5a0-49d5-91df-92b855458c93") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5412), new Guid("37dcf670-a3b8-4345-afdb-ae063d60d8e6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5420), new Guid("3e92c48a-f017-4cc1-a083-19e743707519") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5428), new Guid("31ee6e0b-cc54-4c21-aafe-e1c555badb7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5439), new Guid("4a76e5b5-0ad3-4b0f-b271-5311b3441802") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5780), new Guid("7299df42-6de0-4a43-a23c-7305ae8af2c1"), "معاون دارویی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5791), new Guid("c0503a9b-8e1c-43dd-b117-399e0af71185"), "معاون غذایی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5799), new Guid("4ecb09a4-95d4-4129-89ad-d6d27c688db0"), "کارشناس ارشد بازرگانی", "BusinessSeniorSpecialist" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5807), new Guid("8ac21161-7da6-405e-bd61-a6b1cac87e6f"), "کارشناس بازرگانی", "BusinessSpecialist" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName", "PSO_Independent" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5815), new Guid("2c510408-b190-434a-8007-12dd9b664d01"), "کارشناس ارشد فروش", "SalesSeniorSpecialist", true });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "PSO_Independent", "Parent_Id" },
                values: new object[,]
                {
                    { 6L, new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5824), false, new Guid("da5f2f53-3b4e-451c-9193-b0e841890b32"), 6L, null, "کارشناس فروش", null, 6L, "SalesSpecialist", true, null },
                    { 7L, new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5836), false, new Guid("f4662974-ce84-45eb-a196-05a42ba25429"), 7L, null, "مدیر مرکز توزیع", null, 7L, "DistributionCenterManager", false, null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5685), false, new Guid("5ea3540d-8f70-437e-8854-e0bbd8a0e52d"), 1L, null, "معاونت دارویی", null, 1L, "PharmaceuticalDeputy", null },
                    { 2L, new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5694), false, new Guid("16fe2d82-541b-4c25-b80f-fe27f4fed95f"), 2L, null, "معاونت غذایی", null, 2L, "FMCGDeputy", null },
                    { 3L, new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5702), false, new Guid("80a53490-d670-4c39-850d-389a393d98be"), 3L, null, "کارشناس بازرگانی", null, 3L, "BusinessSpecialist", null },
                    { 4L, new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5713), false, new Guid("4d8a4db5-12ff-482e-b3fe-f80ea7253f07"), 4L, null, "کارشناس فروش", null, 4L, "SalesSpecialist", null },
                    { 5L, new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5721), false, new Guid("01e92d75-b372-4403-8103-6d70f2b615be"), 5L, null, "مدیریت مرکز توزیع", null, 5L, "DistributionCenterManager", null }
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(4331), new Guid("27ae765d-98c8-41ca-9a45-20cbde0c7691") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(4479), new Guid("2babc751-ab36-497f-b8e1-50b61b6b4af2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(4488), new Guid("c318e76f-4bee-4e56-858a-2927284b18be") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5568), new Guid("3851c92f-10d4-4314-a584-5f7bdc846459") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5580), new Guid("922eb61e-dea4-48e6-bf77-1394190d3dd8") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5634), new Guid("95507873-47d6-4b81-85e3-6398e1d3b73b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 15, 40, 36, 554, DateTimeKind.Local).AddTicks(5644), new Guid("7fe82c02-b566-4fce-9d9a-fb3b02824912") });

            migrationBuilder.CreateIndex(
                name: "IX_L_UserRole_D_PositionId",
                schema: "Links",
                table: "L_UserRole",
                column: "D_PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_PSO_Independent",
                schema: "Dimentions",
                table: "D_Position",
                column: "PSO_Independent",
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_F_EndorsementPosition_D_Role_UP_RoleId",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "UP_RoleId",
                principalSchema: "Dimentions",
                principalTable: "D_Role",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_UserRole_D_Position_D_PositionId",
                schema: "Links",
                table: "L_UserRole",
                column: "D_PositionId",
                principalSchema: "Dimentions",
                principalTable: "D_Position",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_EndorsementPosition_D_Role_UP_RoleId",
                schema: "Facts",
                table: "F_EndorsementPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_L_UserRole_D_Position_D_PositionId",
                schema: "Links",
                table: "L_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_L_UserRole_D_PositionId",
                schema: "Links",
                table: "L_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_PSO_Independent",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DropColumn(
                name: "D_PositionId",
                schema: "Links",
                table: "L_UserRole");

            migrationBuilder.RenameColumn(
                name: "UP_RoleId",
                schema: "Facts",
                table: "F_EndorsementPosition",
                newName: "UP_PositionOrgId");

            migrationBuilder.RenameIndex(
                name: "IX_F_EndorsementPosition_UP_RoleId",
                schema: "Facts",
                table: "F_EndorsementPosition",
                newName: "IX_F_EndorsementPosition_UP_PositionOrgId");

            migrationBuilder.RenameColumn(
                name: "PSO_Independent",
                schema: "Dimentions",
                table: "D_Position",
                newName: "PSO_Independent_Location");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2227), new Guid("af9050a4-8850-473f-8043-9f5638783fe4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2245), new Guid("2bec77d9-a4b6-4504-a310-a2a02c8ca2b1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2292), new Guid("381d8fb1-d0d9-4ee2-ac1e-2b3a02b9ce8d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2300), new Guid("a476b02a-0724-4063-94ce-2e93545a232a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3042), new Guid("f82c6377-8764-4021-9a9f-45be898e0e5c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3349), new Guid("19763c8d-d825-4230-aee7-ffa6a4784697") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3368), new Guid("5471fdc8-fd31-48d6-9f67-fd27ed817828") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3380), new Guid("bf9ff09e-797d-4ba5-962c-4134f9e9f731") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3396), new Guid("7c068c51-efda-443f-a9c9-8584fdb9b02f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3408), new Guid("29b7e821-913c-4e90-9c29-01a667130552") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3420), new Guid("8adad282-ccca-4032-a85a-164d80e839f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3432), new Guid("3dce1678-b121-4499-874d-eb03361af691") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3446), new Guid("55049574-6c6b-4984-a1f5-0f8bac21e0ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3458), new Guid("7e95dc72-daf6-453b-b048-90a0b2989a62") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3469), new Guid("fa6aa8b5-07f6-446e-848a-3531586cb4f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3492), new Guid("e350d373-a361-4631-929c-d81535c1f977") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3510), new Guid("cd79ec99-58f6-4530-8573-d2aa74d931e5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3522), new Guid("17d0aba4-3ca8-4aa3-855c-cc0537c917f1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3534), new Guid("7a106c6f-9009-49be-be8b-d5ea0fec700d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3554), new Guid("5517fc79-2801-43d1-815b-5639c0a2e727") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3566), new Guid("75733aed-26ae-4ddb-9249-622792d235b7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3577), new Guid("72f389df-b0fa-491e-b2f4-e85c9fbfea9b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3588), new Guid("fec9e4ff-c672-4545-b105-c359da86073c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3600), new Guid("c48c2b39-2018-417f-8e46-3b4759cd34f1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3615), new Guid("7af140c6-eb21-4cfb-8f3f-2b9f617ccb7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3627), new Guid("360e1c40-6342-4200-a54e-bb92becee588") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3639), new Guid("e144189b-a281-4a29-a0de-09915e60485f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3651), new Guid("e2464413-f44c-4d3c-b6f5-2207d695f903") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3663), new Guid("e6da19e3-ae43-4cdf-95e6-6497ee4dfa01") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3674), new Guid("9e47a18d-1c9d-4325-8b2b-b241b241cd8d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3687), new Guid("10aa81f8-7206-4803-ae78-09b37f946c1e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3707), new Guid("185d1658-809a-447e-bbb4-342273178688") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2474), new Guid("4c50d4ab-7b06-48fb-88d7-62cc8fa64dee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2488), new Guid("097173d0-b0f6-4098-990f-bf0a2d0e1976") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2496), new Guid("e3754ebf-ae34-45ad-9488-1ad456a4ca18") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2504), new Guid("25c8ba28-ccbd-4967-967e-bc58bc08df0e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2392), new Guid("74f3a395-c4dc-45af-bf09-80db77e82003") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2430), new Guid("f9880c9f-a1e0-4b8c-b033-d18efc8d2aa0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2438), new Guid("1e5bd01d-dd28-43d1-b03a-9b0181a0eefc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2538), new Guid("ad1a7ed7-b260-4203-8691-cebdec17fd95") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2625), new Guid("5dcaf849-3421-4744-854d-aa1d4b3a2e18") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2634), new Guid("b3e025f2-310e-498e-aec1-f25ab1311d55") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2641), new Guid("7f2580d0-b26b-4eea-b6a9-d2c901ddaaac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2673), new Guid("0ade1d50-a950-45d4-a1e7-ae58f5883acb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2685), new Guid("961cc03a-eed6-4af2-aaa2-568ce1e800fb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2738), new Guid("015aa8ba-e3e5-4d0d-9b87-9818f082a904") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2748), new Guid("95fa717c-1fe2-4a15-aa94-a6db59812097") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2756), new Guid("b0b8ff6d-88e5-49b0-b83c-656c601f0f05") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2764), new Guid("e7be3fd7-ee7d-4b6e-aea2-36cc779dc742") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2772), new Guid("78a35cb3-5102-48a5-9fcb-b9088749b6f1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2784), new Guid("bcbfd82f-b0a2-462d-9b4b-9ca4948a3134") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2792), new Guid("59442b0a-bf8f-4191-b3e1-cb8c22bd5bf1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2803), new Guid("620c25b5-b77c-4d97-9943-935689819d96") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2811), new Guid("9e3bfa69-daf1-4ece-8708-8921a68cd67a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2818), new Guid("c7d2d245-ed06-4cbf-ab76-50c1b8c38fca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2957), new Guid("b29907c2-9e6a-48a9-84cb-37ff0c689310"), "معاونت دارویی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2970), new Guid("ec96a0d7-28b1-473c-a499-68188787b045"), "معاونت غذایی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2989), new Guid("0c13791c-520d-4bbd-ac82-9a6eec468513"), "کارشناس بازرگانی", "Businessُpecialist" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2997), new Guid("6c534972-8139-4934-be1b-a30d39fe5f4d"), "کارشناس فروش", "SalesSpecialist" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName", "PSO_Independent_Location" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(3006), new Guid("adec484b-2fa1-4e4e-a048-90be7e3edee2"), "مدیر مرکز توزیع", "DistributionCenterManager", false });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(1115), new Guid("43f3f047-2e27-43f2-ad8b-0a591ef6d977") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(1307), new Guid("cd5ef267-2610-45da-9819-6fcf8e2444e7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(1318), new Guid("d34eed56-bbbc-4d73-9ad4-f9122fc6f90f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2871), new Guid("bfe1ee43-87e4-4ba9-82d6-22c9d7a9b2c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2882), new Guid("22eaf178-31fd-4f5b-bcb3-846dd5218866") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2918), new Guid("b92716dd-d907-4a0b-8fba-3f405b6b6bc7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 22, 12, 889, DateTimeKind.Local).AddTicks(2927), new Guid("c75b5253-40ea-4f72-9349-11bd6ba2012e") });

            migrationBuilder.AddForeignKey(
                name: "FK_F_EndorsementPosition_D_Position_UP_PositionOrgId",
                schema: "Facts",
                table: "F_EndorsementPosition",
                column: "UP_PositionOrgId",
                principalSchema: "Dimentions",
                principalTable: "D_Position",
                principalColumn: "Id");
        }
    }
}
