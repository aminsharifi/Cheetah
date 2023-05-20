using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RQT_Finished : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RQT_RequestDate",
                schema: "Facts",
                table: "F_Request");

            migrationBuilder.AddColumn<bool>(
                name: "RQT_Finished",
                schema: "Facts",
                table: "F_Request",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5982), new Guid("2fbd4038-1007-4bd9-9679-27be68a13e4a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6050), new Guid("a2fdab31-6fb6-4bf9-9415-2a6b74f280a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6059), new Guid("61a53560-d6ab-4ebc-be87-c53434b340b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6070), new Guid("591cf5b8-ed46-47d2-ab7c-2c6fa6f694be") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6078), new Guid("c27acdcd-0650-41c0-a07c-20e636cafa12") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6091), new Guid("e6ffd74b-3723-4af1-8194-69c83e95d90b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6099), new Guid("d52f95cb-f8eb-42fe-97e7-b899663010c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6108), new Guid("2c23152b-c518-44fd-974d-75e9547499e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6116), new Guid("a41fb451-e705-4429-90e8-91be31ccfeae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6129), new Guid("75b973be-18c7-4071-aa5d-5ab248e19099") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6138), new Guid("05b5d5e4-78af-4bb2-bfe9-9cbea13d535e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6147), new Guid("7fd47e25-48d0-4d78-8b67-6ac08c1962a3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6155), new Guid("b3d469a7-f009-4f8b-a8e2-3402c8b7f9c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6165), new Guid("65120f57-6f1e-43b1-8e6e-fe38c5b382c1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6232), new Guid("1c9863f2-2b97-4367-b050-34ddf6601623") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6251), new Guid("3a30487a-6b83-4f27-bef2-50f8f3158b63") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6260), new Guid("15a12751-18dd-44dd-91fa-2c9d9bc49bae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6268), new Guid("174a76f5-d857-45f9-bb8d-4382f9b317b5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6276), new Guid("df546648-64a2-4a8d-878e-ed7e94197eb4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6285), new Guid("6b7fbb90-e1ca-4bad-8fdb-e66bb935789d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6293), new Guid("ac1ab4be-5976-4983-891a-cd474b9f6a9f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5410), new Guid("1c0c024d-c53b-4553-a3ca-4efc247bd128") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5440), new Guid("e395ffac-48ef-4842-a39b-26097ea4a181") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5448), new Guid("13bc64ac-b3e1-4cbd-ae3d-f40bbdabcfb0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5491), new Guid("a4727336-f1eb-466f-8847-33b2491ec0c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5498), new Guid("9f657584-4779-4bc8-b6cf-244ec71fff02") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5504), new Guid("6aaada82-a09f-4dab-abba-454c415cff7e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5510), new Guid("417f491f-1cdb-4725-8ce1-29419a59636f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5515), new Guid("20ed3ac8-418b-4f99-98a7-d3ac8a1b19a0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5570), new Guid("5fcbc303-e787-41ce-9406-d4ed82aed127") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5886), new Guid("9a50e363-08b3-48ec-b5cb-cfb1b04cd0a9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5893), new Guid("216d46c8-71d8-4c2e-8765-0468f708a9be") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5900), new Guid("190a0746-0297-4615-b493-8c52a2ce1f81") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5906), new Guid("c5142423-6858-4396-a69b-a292837f9e7f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5913), new Guid("12ea1441-d448-42e6-ba89-2390013453ff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5918), new Guid("5db51a26-8624-489e-b283-590efb07978a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5924), new Guid("05aed38c-d1cc-46d9-8667-7fce0c1583d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(4737), new Guid("8b21af07-c32c-4b52-ab10-69ae05a4fe84") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(4872), new Guid("73109a94-95ab-4393-8e78-d614203b3394") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(4879), new Guid("379c20c8-e9c5-4cd1-9fea-63785c8b2e2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5307), new Guid("befb93cf-6b49-4fbf-b891-964b13e9d5c8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5354), new Guid("80c5cced-670d-4d16-baa7-676c2a070f2d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5367), new Guid("457c5474-9388-43ea-a29d-b79871138739") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5372), new Guid("999c9b10-b867-42c8-993a-387e80822c42") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5833), new Guid("565c66f7-f4ac-4010-a75e-36bb0faf9d66") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5842), new Guid("4668a17c-934f-4e88-b4c9-16245e0aff33") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5847), new Guid("baead5c4-612c-4252-9d20-edc19a1938f1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5853), new Guid("7a4217f5-455a-4a7e-b675-b6db2e52bbf2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5858), new Guid("e9a1ad2e-a0d1-4556-9665-6172728ea379") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5662), new Guid("ab54fdfc-9702-4c14-a7a8-2c25165ed33e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5671), new Guid("a3fe2b87-ae4c-4948-ab29-d8118bdf9a5c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5676), new Guid("e0e19cc0-4baa-4292-b2c0-e2976c4ae023") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5682), new Guid("df9d82d0-2514-4358-b1d4-c5e630d9ee2f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5687), new Guid("da91040e-062f-40a5-bb19-a37048aea21f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5694), new Guid("9525a796-4a28-41ca-8632-e745a4819b43") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5700), new Guid("0082aed7-318d-4e4a-87e5-a222d31f66d4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5705), new Guid("2891d4aa-6b2f-41ec-9186-9b3b6b620a4b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5739), new Guid("c0ddec99-e03a-4a72-ae24-965c21861b6f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5746), new Guid("3c6e423c-1dae-40ab-995e-c37052e31f9d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5614), new Guid("96b28d22-2c52-447b-980c-584dcb6fbc8f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5623), new Guid("cdb1272b-6627-4be4-981b-cb00ff5a61c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5628), new Guid("fb414441-cdab-4314-ab2c-aab5943c9802") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5633), new Guid("a1734676-dcd5-47b4-b063-5996c866c96c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5796), new Guid("01d5d452-364a-47f8-88e3-86483fb31595") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(5803), new Guid("3229161d-fe09-4a0a-89c2-3967ec5ae765") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6377), new Guid("44e418dd-13f9-4203-ae36-b4f1e23628bf") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6387), new Guid("bfb534d1-f372-47cf-a6f7-ccf40c9d3d59") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6393), new Guid("f1dab07f-8755-4667-8323-00253f7741c3") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6399), new Guid("c47bb503-9760-43d0-9ed4-25395e5aa5fd") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6405), new Guid("3d38f39e-9fe9-42b2-8cfb-354fe52053b3") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6468), new Guid("85fe37cd-2afd-4b5e-8114-389a1190cf7d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6477), new Guid("d8f9fb95-36b6-497b-a2fa-c0bfe5b18efc") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6482), new Guid("71865b17-ccf6-49d7-a688-c92f9d816896") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6488), new Guid("4e735279-e10c-4822-a971-64b24f6f1406") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6339), new Guid("09aab6a4-fbdd-4b94-bb49-509335fc0224") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6347), new Guid("5174f084-c8e4-485b-ae61-4e7da3c221e9") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6353), new Guid("6c11161a-73c8-49c7-a5a0-6d81787a845c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6644), new Guid("46f25f8d-c7f0-40cf-8955-da4f27d6b7dd") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6653), new Guid("1da5e3a6-6daf-41ee-b553-f293db3cf960") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6658), new Guid("0aa46bfe-ae3f-408f-b459-8c2052642b2f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6664), new Guid("dfffe424-da59-477d-a4ba-4e265bf0dc63") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6669), new Guid("664f5ec3-2597-4805-9a0a-58e99adb2a55") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6573), new Guid("d717770e-7632-4c51-972e-98a9b9657a6d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6579), new Guid("a859b9db-f3b2-4cf3-8fee-94ba2eb02173") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6585), new Guid("c6d8ac89-9265-49b6-8105-e9408dbed433") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6590), new Guid("7f604510-7f1c-4a5d-b85a-1d9715eb0057") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6595), new Guid("2d15d8bc-f2a5-4d4f-8e4b-e44a4fe4999c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6601), new Guid("0bacfb30-7be8-4120-bf2f-36bf125fa77e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6607), new Guid("b6c0fbda-644b-4be7-9009-62ba6695d145") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6522), new Guid("9bf45dc7-f10b-4dd7-9967-3c19047f1b0f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6530), new Guid("60959903-122e-45cd-aec0-ac31a5378a2e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6537), new Guid("2f22d979-2d7a-46fc-872e-90074d609b3e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6543), new Guid("ab20452e-b35e-4e51-a7dc-b6f62bb4f8f6") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6691), new Guid("23356649-8846-4f1b-b9bc-060cf40009d0") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 36, 4, 416, DateTimeKind.Local).AddTicks(6698), new Guid("6a2b7c1d-706d-4713-aa2c-cbbe5cc6a825") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RQT_Finished",
                schema: "Facts",
                table: "F_Request");

            migrationBuilder.AddColumn<DateTime>(
                name: "RQT_RequestDate",
                schema: "Facts",
                table: "F_Request",
                type: "datetime2",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 104);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6823), new Guid("9f95dbf3-5673-469b-9e8b-da04a44af3ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6886), new Guid("75cec514-77cb-41cb-865f-9688af256023") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6925), new Guid("0bf6ed13-7a03-4a04-85e7-9881d2a2c017") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6938), new Guid("b073cb00-deef-4644-88ca-6f93abf46d0c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6948), new Guid("4d03d7ff-0885-4064-bd99-2732afd127c1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6958), new Guid("7d47917b-2699-4c64-a2b4-587970256c2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6967), new Guid("a52e7189-2a4f-4c20-96ab-85675a8b08b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6976), new Guid("b06c3f73-f37a-402e-9ca3-54a47face8e7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6986), new Guid("c0e34310-8224-40c3-bb75-c65a1b93503f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6995), new Guid("cc0b42ef-ab2f-48d2-8528-4a638e97f79b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7004), new Guid("c8451351-be2e-494c-a71a-ed142bf18a60") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7014), new Guid("a7f86032-535a-4781-b068-81b114a22c0b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7022), new Guid("9fbcba16-8328-4b89-ae9b-08caa2d5bc51") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7032), new Guid("4134d74e-134d-4c2b-a248-d9028747a289") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7041), new Guid("a12c1a18-f87c-471f-9536-c3e6dbe1737b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7058), new Guid("aac7327a-24f3-4d1e-9582-c502d75303ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7066), new Guid("890e3867-70e8-4c9a-a101-d97e67b6b451") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7103), new Guid("c1550d95-81dd-40c2-bdf6-a3d3ddb0ac9e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7112), new Guid("a0ca0109-874b-4762-8d95-7791ea4dc335") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7121), new Guid("ae41532a-bba2-4a3e-b738-5e1faa59d163") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7129), new Guid("3d01ab43-dbe7-4582-b77e-3d5581f848ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(5920), new Guid("9a62fdb0-4ed9-49b8-bf46-f575c90aed45") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6264), new Guid("6ed77fd1-44a5-483d-9f71-b58b175ecb94") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6277), new Guid("d160a7d7-207a-474a-80ec-d6c8a987f91d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6355), new Guid("0ea0fa9d-c1e4-469a-8dd3-28b9b8e6fa85") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6362), new Guid("edde2d7b-bc47-4174-a914-7a9c9039e22f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6367), new Guid("24376fc2-6d42-4233-8b04-948ac84c1c22") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6372), new Guid("3d71ec94-5cff-4cd1-a7ed-7ba38248a314") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6378), new Guid("d8776557-22b4-43a6-acdf-ef26eb194f29") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6433), new Guid("50ab4362-d6de-416b-b0d2-f43b0d0639a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6758), new Guid("7133250c-a983-450d-8197-e800b503dcc2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6766), new Guid("36dde516-cd48-47a1-8128-8b02d4b3c726") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6771), new Guid("1eaae548-0f8e-4863-8f43-6ca0a0acb878") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6777), new Guid("0b4700d1-4fed-4672-ae0a-1f88a114a68b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6784), new Guid("d010c086-960e-4a58-9846-f61266e5042b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6790), new Guid("e0486927-fcce-434c-919c-b92d52c7fc8d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6795), new Guid("baaf4d06-18c7-4c92-8d0e-0823c9abfa67") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(5343), new Guid("b495635b-1efc-49c0-a873-732446586c6c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(5466), new Guid("bb17862b-9928-46a9-9b04-338701244701") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(5474), new Guid("e85646f9-c239-407c-921a-6b1d2a49c7df") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(5859), new Guid("df612215-7b4a-4731-8788-03721772b670") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(5870), new Guid("11b3c278-92ac-4514-ad1e-642163ada0f7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(5877), new Guid("92ed0b12-3c01-412c-a547-3debbe794657") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(5884), new Guid("768fcdcc-3dbf-4d40-9631-355fdb8b743b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6699), new Guid("f6f4c23f-a37e-4105-b733-6dd7d174032d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6711), new Guid("7fc19abd-6047-4420-a4b5-e2c0f7113e24") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6716), new Guid("e93ab328-6bdd-4b80-a4d5-4ba2cc1257d0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6722), new Guid("c894aa6a-c0c2-49f9-8aa4-78b91c85def2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6728), new Guid("34da1cac-b14c-45e2-a44c-f48a952173af") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6529), new Guid("b985258a-33c0-4c75-9a47-addc53cf18e0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6537), new Guid("069f3762-dc9d-44d6-bbec-3d66132de188") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6543), new Guid("4c6e1b66-e90e-47bf-abdd-2ac5ec9e10ba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6548), new Guid("196701a7-ac1d-4a6f-a172-4da6c6a95493") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6554), new Guid("302cc414-03e3-4229-9a7d-0e042d6f506d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6561), new Guid("515ba672-6ca5-4a4a-867f-a3d1bede85ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6567), new Guid("cfd8da08-7ba5-4b07-a5e4-6f5b855357d2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6572), new Guid("cbc6f892-8309-4680-9583-9b38b0ed62e0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6578), new Guid("a2dfa47c-13db-4650-be28-9c12f9cc1784") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6585), new Guid("c9ce1f9e-a09d-4120-bb30-ed90d45324aa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6480), new Guid("6cfa49df-039e-4fef-9555-15f1ad1a1ab1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6490), new Guid("183a96b0-5c67-4266-a9b5-19d890ae5ac5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6495), new Guid("3643f231-52bb-405b-9133-e3e5e034f667") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6500), new Guid("a4787b9f-978b-4826-972b-217029b88c0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6661), new Guid("f92906ea-fb02-437a-b7bf-ccac5a03751f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(6670), new Guid("7816930f-81f3-41ee-adb5-a3c97a3acd1e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7234), new Guid("4b103b7d-fa26-44bb-b50e-2d9c2db1822e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7245), new Guid("827c9537-65ea-4430-9eb1-9b244f2c0868") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7252), new Guid("bf535121-1c2b-452a-b4f3-ca85dc34c3a4") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7259), new Guid("6eac3907-a9ce-477f-a027-3b322f4b0948") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7265), new Guid("56198fa5-8520-4383-a8c6-6d77a93611f7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7299), new Guid("ce176b99-a9a8-405b-8507-dad5a60789f8") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7309), new Guid("00a6f54f-10f5-4f37-9d78-61fe1203ccf1") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7315), new Guid("195f2c60-4f2c-403e-a13a-ca77d3f144d6") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7351), new Guid("b53ee6c8-ef47-42f4-b4d5-b57c818f3ace") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7185), new Guid("e30aa1d4-3ff2-46f8-b979-6b54494e1b9a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7195), new Guid("1b3c39ed-719d-48c2-b56e-e09a75bfa6d8") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7201), new Guid("3dc05b51-edb2-4354-8fcd-e403d891469f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7535), new Guid("a6de3a55-daac-46d0-9d6f-4c5fc8c08db6") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7544), new Guid("d603eca8-7190-48eb-a97e-53ccd9c5b465") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7550), new Guid("385970da-26ac-4d69-a620-2411e3484bd6") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7555), new Guid("48daccb4-01fa-4325-ac94-2661718e316f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7560), new Guid("2fc16a77-ac57-4e7d-8278-c2bf8fd89af7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7432), new Guid("c06d28fa-9985-45d8-85b8-b6f4c8c95dcb") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7440), new Guid("6c9bb073-c20a-44d9-9324-85f2a6aec2eb") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7446), new Guid("d3f69593-899f-42fc-af56-a67a96e47b0c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7451), new Guid("a8c8d6ab-fe4c-4fe8-8902-7f2fe16657e1") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7456), new Guid("f7fe2620-2c60-4afa-ad16-2ade01762e4b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7463), new Guid("73a48fc9-52e1-4497-979c-4a211daa75e1") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7468), new Guid("019be514-3806-4225-acb5-1661b04c6977") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7385), new Guid("5e8f3538-21ec-497e-9a80-cb8bbc0f867e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7394), new Guid("e2f35806-af79-46b7-b772-5b49f01dee13") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7401), new Guid("d7b6a23b-2465-4ae6-843f-fd3d013eaeaa") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7406), new Guid("d2a3728c-7b76-42fb-9248-61e16473112c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7589), new Guid("42184a85-d8a1-460f-a7dc-ca49d38f7088") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 44, 2, 738, DateTimeKind.Local).AddTicks(7596), new Guid("2ed40349-0244-40c3-aedc-9d9410eb4af7") });
        }
    }
}
