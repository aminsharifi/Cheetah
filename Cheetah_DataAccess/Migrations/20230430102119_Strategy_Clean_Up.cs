using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Strategy_Clean_Up : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Endorsement_D_Strategy_ED_EndorsementPatternId",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.RenameColumn(
                name: "ED_EndorsementPatternId",
                schema: "Facts",
                table: "F_Endorsement",
                newName: "ED_StrategyId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Endorsement_ED_EndorsementPatternId",
                schema: "Facts",
                table: "F_Endorsement",
                newName: "IX_F_Endorsement_ED_StrategyId");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9864), new Guid("9156a654-4c9e-4c75-8323-c284f6a4e9cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(28), new Guid("5e035fa1-0520-43d7-8dfb-e6d272497e9a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(40), new Guid("1b28810c-5ba4-48d2-ac4b-31c6831ff90c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(48), new Guid("05968480-df9d-465c-b892-8ef360586a5b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(66), new Guid("dbd2dd77-37c1-4bfd-82cc-a76c11a3ca24") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(74), new Guid("66b6849e-18b3-4376-a333-5c07a50cbe87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(88), new Guid("a4e76a28-a3fe-4f40-838b-31b1adcf39e7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(96), new Guid("cdfb0ab3-bb43-438a-9342-9f7c6cf6c5d3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(103), new Guid("2795204d-6ab5-4766-aee3-3fe8a58a992d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(111), new Guid("1a299009-9ccf-4b38-aa08-76e2067270d2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(118), new Guid("55a65425-9d83-4d84-8c93-662a45321e75") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(125), new Guid("1cd7e938-627f-4ad9-8dbd-ca49c9f8cf69") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(133), new Guid("92ca3efc-d891-4993-8879-76b4f35ccd46") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(140), new Guid("c75d5ba3-dd13-4051-85c0-0af652fd2dc3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(151), new Guid("67c7934d-627d-42ca-90a0-a13bdddcd8de") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(158), new Guid("13ee19bd-bdec-4448-bee3-6eea0b693b40") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(165), new Guid("6636e0a8-0ef6-4807-a9c2-a56e54b25752") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(173), new Guid("da1b38f6-05eb-43fd-9e34-0db5685dcd92") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(180), new Guid("3bd78b9c-cbd8-4f9d-9725-ac3b400c4652") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(197), new Guid("b6d56b09-3cfd-4ea8-9de7-0996b540d788") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(204), new Guid("1b50b6d9-79c9-4135-a829-c64c4d4e5052") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9499), new Guid("fe0dc441-8c29-4d6f-9d68-2177129a09d7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9505), new Guid("1569ce43-13d7-4bdf-b203-513b56d1373c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9510), new Guid("e14b54c5-3c53-48f1-be98-ee98ff7aa6ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9544), new Guid("22fa59a6-96eb-4c27-9f07-c6b5e6b5242c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9550), new Guid("875ad7d2-520e-4b23-ac9e-7d78d7d9e593") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9554), new Guid("3f1a26d2-3234-49f2-a164-04edc0341259") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9560), new Guid("55430d32-d9de-4777-8e0b-1d284f55feae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9565), new Guid("7633cd7e-964d-4fd8-8a2c-144f0317261e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9570), new Guid("1313519f-7f0d-4aa1-8376-5156f188dd97") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9806), new Guid("0a957375-b43a-4e0a-b52e-2636c22269cd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9812), new Guid("667a1ac1-54a8-43c1-9e99-ae6ae9e7b50c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9817), new Guid("19ec7a6e-e6cd-4431-ae38-13b99ea304b9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9822), new Guid("e63a50bf-0dea-4623-a303-e55f59e9cd7e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9827), new Guid("5b99d612-cb75-473b-84b9-b5a9d028cfd6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9834), new Guid("30ee7847-4271-474a-8d5d-41fa1e6fde0c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9839), new Guid("ff27a99c-824f-4f7f-97e3-10a96e297117") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9396), new Guid("2c33c0fe-ba73-454c-ad68-33e9bf10dc59") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9404), new Guid("35ecd2f6-bac3-4222-9e06-03e63fed2fe4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9425), new Guid("9d3f530d-31a0-4f53-a340-9505e5f65cde") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9454), new Guid("8c6df0d4-43d0-462c-9816-938d055a8870") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9460), new Guid("065215ab-990b-4610-a8f4-5b0d813e95cb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9465), new Guid("2eb598b2-f4ce-4f69-857a-04b433499b38") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9469), new Guid("52fbb607-cab5-4526-96ac-cae13954c387") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9755), new Guid("b6c06f7b-28ba-40ee-a528-efcf9bfd52c1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9762), new Guid("a6efc71a-896e-4e73-ab1a-821392fa84cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9770), new Guid("7070eb2c-6460-46ef-be80-a12c4fecc224") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9775), new Guid("b76b25c3-3b10-4cac-bf6c-8711b4234694") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9780), new Guid("bea96631-14f8-4339-85a1-2823c576bf7f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Strategy",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9023), new Guid("22275c86-0a8b-4354-aa05-dfbecc8b6474") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Strategy",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9129), new Guid("fe4b5182-54fa-4216-a6c5-7b24379b7398") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Strategy",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9136), new Guid("80de9855-4f4e-4084-b04f-14f1e9831fec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9644), new Guid("a41d89bb-30ad-49c1-a3af-2a118aad1f08") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9650), new Guid("ad966ae9-cdef-4e21-8144-aaf76eb6abb3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9655), new Guid("9e9d47be-180d-4d45-817f-4d7538d3367d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9660), new Guid("8a5d8974-225e-410a-8982-3fa855d0a23d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9665), new Guid("8b8ea4d9-0a2d-4b2a-b8ff-9eca4b384f73") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9670), new Guid("09a0b381-6964-4c9d-8058-cd2917fcdc69") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9679), new Guid("ef491901-6963-409f-86ff-99a0ad856676") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9684), new Guid("63cf2c90-26a1-449e-b112-fd1de3d1c34a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9688), new Guid("8ae14432-813d-48fe-9548-6f21e027a6ea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9693), new Guid("5e6866a3-a5a4-4c95-b2ce-4e6d2774b74f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9602), new Guid("04e65cba-a51a-4896-82f5-6ea23aecb94d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9609), new Guid("e36becc0-fa26-4c0c-9bce-9fa3bebaeed1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9617), new Guid("21c5dec2-cf10-4dc7-8524-5e59dac6c284") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9621), new Guid("7428ccd8-720f-40f3-bcdf-85ed3d121bc3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9719), new Guid("2340e984-9cb9-48e8-a4fb-e6a578c15e6e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 994, DateTimeKind.Local).AddTicks(9726), new Guid("65ea3ca1-84cf-4fe6-875f-c5dd8fa9180f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(348), new Guid("da5eea0b-4fbd-4ca1-b6b8-80d9e1ae06d3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(354), new Guid("11d66408-00ad-4829-ab16-58e618b557df") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(359), new Guid("3862e347-ed21-4e59-99e0-aba5b4ba85f9") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(363), new Guid("80e21e6d-dee1-4d77-803d-f3dd9afe9b6e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(284), new Guid("0c2d3402-8f78-4bb5-9694-03a5626e056d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(290), new Guid("d52f4033-2747-43d3-811b-c5208a4ea7f0") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(295), new Guid("aeec70a2-59b1-481f-a5ec-e20a039e4c78") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(299), new Guid("a37b8c6a-cf48-4f8f-9139-911d402570f5") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(304), new Guid("5a3c2cbe-132e-45de-b0e4-8decb89a5fda") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(309), new Guid("a9e83579-4f7c-4ff5-8fcf-f46d855f9e12") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(314), new Guid("a1cc8d83-b486-435c-9c77-7877bcc4924e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(253), new Guid("ea6a0bc2-9a55-4557-9125-4e551ac4256c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 51, 18, 995, DateTimeKind.Local).AddTicks(263), new Guid("93f2794a-4ff6-4ffc-bfc6-0e19c3a635f5") });

            migrationBuilder.AddForeignKey(
                name: "FK_F_Endorsement_D_Strategy_ED_StrategyId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ED_StrategyId",
                principalSchema: "Dimentions",
                principalTable: "D_Strategy",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Endorsement_D_Strategy_ED_StrategyId",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.RenameColumn(
                name: "ED_StrategyId",
                schema: "Facts",
                table: "F_Endorsement",
                newName: "ED_EndorsementPatternId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Endorsement_ED_StrategyId",
                schema: "Facts",
                table: "F_Endorsement",
                newName: "IX_F_Endorsement_ED_EndorsementPatternId");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7609), new Guid("7249e775-e035-4d10-8154-5d24833b1964") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7752), new Guid("e8421b1b-8771-4c65-a758-e091ee49c387") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7764), new Guid("d4624cc1-57aa-4305-beff-291482d92acb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7773), new Guid("8ea939a6-a26c-4d41-bdd6-3548a07974cd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7782), new Guid("a3bc34f0-07c4-4328-8639-965c2868e7cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7793), new Guid("6e1939bd-73ee-4846-b910-533ea42d14c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7811), new Guid("1742a65d-f88f-43f6-b37d-bcd3126332b9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7820), new Guid("f08470f3-c705-4b1d-b615-091ed4f7f665") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7829), new Guid("ed70a572-a807-4d20-8b41-a79cd0e750fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7837), new Guid("3319ffed-762c-4499-937f-9ecf3d78a80d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7845), new Guid("5a13abf1-9565-435f-8509-69f859d6ccb7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7855), new Guid("753bbd8e-6766-4a12-b763-11e2a1ac2839") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7863), new Guid("bde5a9dc-332c-4667-833d-d38f42bb0251") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7874), new Guid("ebcef44c-b495-440a-b2cf-6df6a4f6c23c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7883), new Guid("05b034b2-a85d-4ca4-9a30-882c76da8a6c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7897), new Guid("9d01376c-3651-4509-ab6c-d3600dad7c78") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7905), new Guid("1bec83b9-5af2-4d51-9b56-c0b2d7e47b08") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7914), new Guid("c0f03d62-b57b-4431-96ba-28a80314e3bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7922), new Guid("4e56839f-589b-4446-943e-08aca86d4196") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7931), new Guid("179c974e-f3b1-489d-ad32-005af9f05695") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7939), new Guid("a8e892e3-de25-4edd-8c93-830c22ee8bc2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7130), new Guid("2c0cf95b-f39e-4ad2-907e-d9854ec9ec7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7136), new Guid("290275e5-b3a7-44a7-be0e-776110cb9869") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7144), new Guid("33beeb40-6b05-4fbf-b974-c671e23f80b2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7172), new Guid("e7b9335a-822f-40d1-ae3a-b8e907ac4e66") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7179), new Guid("c0f019e4-097b-403e-b65e-dbc87653e0aa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7229), new Guid("eacc9673-b072-47d6-9ab2-49d196a53723") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7237), new Guid("82fc611e-0d61-401a-a8b8-08c1f25d7f76") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7252), new Guid("455e6220-9cf1-4eac-aa3c-a4783cf85d7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7257), new Guid("8190dc88-b262-460f-bec7-611b3a3cf32b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7548), new Guid("d8e542e8-d0c8-4b01-ad53-8e9c246a435a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7555), new Guid("66643644-3ac5-45aa-a6c2-70b7f7c8ed86") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7561), new Guid("a17b4d86-3333-4c3a-acd2-ccb4873fd3d0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7566), new Guid("bccd50c8-d911-4f6f-9307-298231dc3c2e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7573), new Guid("f22cfc81-3c7b-4710-8f38-561aabe9c986") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7579), new Guid("75bfa9db-c96b-45db-a3c4-c4d2e52a217e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7584), new Guid("3f7b2dd2-9812-4cf1-89ed-ae295a3fc95d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(6986), new Guid("d9bfd27a-2b53-45b3-8dd3-c69a4af99020") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7012), new Guid("48b7ea4f-787a-4567-ad14-67faf45dac9d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7025), new Guid("59f9c3eb-2d65-4048-9705-b9e3001c5077") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7054), new Guid("9a7be939-968c-4297-8b90-9099d942bd14") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7061), new Guid("e5f12e38-08d1-4d8e-89ea-651184855000") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7093), new Guid("0e500ad9-a953-4795-87e5-1bf94d9ac5ed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7098), new Guid("e386bc9e-dbfe-4a47-8c27-0c7273eabd6d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7482), new Guid("70115c42-fed3-4ffa-a4ba-d5a01a4f4763") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7491), new Guid("58ae7606-e3e7-46d8-bc34-2ff126e45ada") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7496), new Guid("80e60973-27e0-488a-af2a-35400ce929fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7513), new Guid("6915141e-1138-40c2-a7f7-11f0c0dd72a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7518), new Guid("37b38021-7434-45fd-9780-631b50032ae6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Strategy",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(6628), new Guid("291d0398-9b75-4b02-acf2-5fe68492f32a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Strategy",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(6749), new Guid("afae6bf4-cf6b-496b-a080-553ad9aa74b1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Strategy",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(6756), new Guid("85400b36-b6bd-4b47-b2c7-fbfa89d71075") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7342), new Guid("61e8e643-f0a8-49ae-85be-bb7e2032f0ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7352), new Guid("99af643a-f315-4b82-9ad2-8107d1c1edad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7357), new Guid("f5d9fa9b-a784-420f-88d7-dfcb2bf730c3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7362), new Guid("ccfe7b49-802f-4b51-983d-ddfe1db0fd11") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7368), new Guid("7e6381a4-9339-4c05-8fea-5468ee4eff5b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7375), new Guid("6d376906-c116-473c-a4da-d17e37e13f0c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7387), new Guid("e98e8152-e771-436a-87f7-764267e57cf3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7403), new Guid("a5c2b5d8-e665-4b35-a1e8-3868af607713") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7408), new Guid("976e2051-d719-4771-bb4e-9e42276242f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7414), new Guid("32412266-2d06-42c5-b292-a5478a3bb9c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7296), new Guid("a6226016-9b40-4c43-8dfb-9948242de8c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7305), new Guid("cd41bfd8-636a-421b-83e4-8ca43c5cb420") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7311), new Guid("0fde8920-87c1-4a15-a7eb-826efdc17cd4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7316), new Guid("ceb22d8e-2672-4b9d-aee4-29ff1848b69d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7444), new Guid("24be8b18-cf07-4dd2-8dfd-52c0169a7564") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7451), new Guid("c6b7875d-23c6-48b7-adf2-cf2bca5c865a") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8103), new Guid("6331899c-46e2-480c-97b2-9855c08476ee") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8109), new Guid("b92504b8-8edc-44ee-9282-41df17fe3884") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8114), new Guid("3d63a396-5c29-4e2a-bd33-29b94d8b1069") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8119), new Guid("17d5940f-3a11-454e-9543-dfd8763c3cf9") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8034), new Guid("5c714f01-18a9-43fb-8a6e-50ec076bdb0f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8040), new Guid("47e83962-2a3b-4ee0-b4ac-c0dd5575368f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8045), new Guid("bf1abe36-8d6f-4940-80b5-92b2fe61be62") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8050), new Guid("08491315-220d-4515-ad6b-6a3afc4fc07d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8055), new Guid("80265e98-d5fd-436a-a56e-6c21a7d7064f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8060), new Guid("b3145bb6-c21a-46b8-abde-b2d75e4b4a27") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8068), new Guid("30f933f5-d0f1-4fae-a869-55b42575d3a0") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8000), new Guid("acd8cb5d-4b17-47ef-987d-26c1ae658457") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8008), new Guid("82f70abc-7640-4971-9777-ca16c141d2bc") });

            migrationBuilder.AddForeignKey(
                name: "FK_F_Endorsement_D_Strategy_ED_EndorsementPatternId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ED_EndorsementPatternId",
                principalSchema: "Dimentions",
                principalTable: "D_Strategy",
                principalColumn: "Id");
        }
    }
}
