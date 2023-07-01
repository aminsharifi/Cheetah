using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class IdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "IU_UserId",
                table: "AspNetUsers",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 101);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6394), new Guid("ca17a0f6-da8a-4263-a4ec-ef5e194f7fbc"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6439), new Guid("36fd2965-eaf7-437b-a6b9-df29b010380b"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6446), new Guid("7a4f48fc-dfda-40bd-9911-437e152da905"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6452), new Guid("81ddc864-d80c-49df-a807-c9a42ec968a7"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6458), new Guid("5453940e-c5a2-4370-ae8c-ccc17a2ab021"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6463), new Guid("aac40a76-6c93-4672-92d0-517eefc33a70"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6471), new Guid("a041475e-1448-4c68-8b8b-59c0d09a0961"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6477), new Guid("beb36dc6-5bd0-4900-b674-9af285907a5a"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6482), new Guid("c668c632-f9b6-423d-bbea-e925d05927c2"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6487), new Guid("0327421f-ea8f-4c38-837c-fbf92510f720"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6493), new Guid("b55f15b6-5dd0-4a08-bf39-68f7c74afa2f"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6538), new Guid("00ded53f-cf03-44f7-88db-f6c14ac812f1"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6538) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6544), new Guid("f5145194-ccc2-4232-bc3e-f48e283a6f09"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6549), new Guid("b6ca0f20-1453-4b17-b5df-a58852fa15f4"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6557), new Guid("61da703b-ba9b-41a1-bbea-d832645e17c1"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6566), new Guid("38d7620a-4ded-4a88-98e9-14ebccb05ff3"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6566) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6572), new Guid("62f33878-0466-4b68-a605-d0af2d17898b"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6577), new Guid("b3080eef-11ff-4cac-ab11-2cb12b53e2aa"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6582), new Guid("814cf57e-c7c9-472a-bbe7-413f44850d58"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6588), new Guid("f02c875f-513b-434b-867d-81fa0520efaa"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6593), new Guid("96ce1e6f-1374-474a-b324-a3dbbcec0375"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5969), new Guid("dc36b20f-d308-4f7d-b96b-c09086fe2ae9"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5972), new Guid("b06310fe-5893-489b-b60d-37efc77961ff"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5975), new Guid("e53e7de2-9de2-4b56-b3f1-506c64fb383b"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6006), new Guid("20c21138-5784-49fa-8ede-461bc7e2af9b"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6010), new Guid("0aece1dc-6c2e-4f74-8c0b-5d00642df822"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6013), new Guid("e376e6a6-037b-4207-9c36-e1d783daa4f1"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6014) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6016), new Guid("b2abfd07-504c-4ca8-849c-b2b20e3fa8c7"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6018), new Guid("4125a3d7-f350-4b99-8b5b-b34eea8cdba9"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6049), new Guid("66597926-062e-4dde-abe6-1dc1e309da84"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6289), new Guid("4bcab3ce-7d97-406b-9c75-6022c945163d"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6289) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6292), new Guid("df0f8db5-13ba-4228-bff9-58bb4d62a6cc"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6331), new Guid("0904284a-10e0-478c-9ae2-ae34e2c250b9"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6334), new Guid("e80b00ad-21dd-41a2-a04e-bc88c501cac2"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6337), new Guid("cf1cc6fa-2bfd-4801-b538-90b524533cef"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6342), new Guid("98219431-797b-40c7-9f55-5e1aa008bace"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6344), new Guid("568b5f9e-d4ca-4ea0-90b8-747a98b07ba2"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5552), new Guid("724ad620-2d03-4f87-b28c-e30cf5ca0b91"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5599), new Guid("8302ce6d-e9c2-4194-9e5b-886b2bc0cb42"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5615), new Guid("c9534106-614f-48de-8ae6-cd9c08903cd5"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5615) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5934), new Guid("9b8099e4-8b90-4c1c-85b4-5c15ed1a5332"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5939), new Guid("e9296af1-d93a-4143-90ba-d5bd0fa41e6f"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5941), new Guid("3b367148-d3c8-4434-b4a2-fa5429ac1490"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5942) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5944), new Guid("6de20d64-c308-4cac-a5b9-29363bbfea51"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6253), new Guid("50765b0e-513d-4184-ae95-7accd54d9995"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6256), new Guid("1c11d33f-6e83-4321-ab19-eae04e99bbaa"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6261), new Guid("8caf4a90-eea5-4ca6-92f0-e57775122949"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6263), new Guid("87a5a89c-a712-4914-98c9-7b67935c94be"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6266), new Guid("79e36e9c-7940-421a-b56e-0ee35675c341"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6158), new Guid("9e61ecda-4f4b-4b74-9ca5-098752bbe226"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6162), new Guid("ac33a431-9b1a-454f-8a22-6e724fdc621d"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6162) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6165), new Guid("5175f497-1790-421e-8f74-b442254c0f09"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6168), new Guid("489c8b38-50aa-4b85-b6f4-517015d75f12"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6171), new Guid("26431bbe-8dcf-4a00-93b1-555c84c11f24"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6174), new Guid("fa734347-fc15-4b16-bce4-a5758d70c19a"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6179), new Guid("dc883924-a550-486b-b07d-5cc460ba2bb8"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6182), new Guid("4d600a70-743a-40df-bc8b-21d126230bbb"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6182) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6184), new Guid("78c864e7-102a-49a3-b530-5b3e369de8b0"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6187), new Guid("47fe522a-10ae-4017-a811-209e438bab94"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6085), new Guid("d22197ce-dc3a-4316-b443-978e38ef477e"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6089), new Guid("44e7eccc-5277-4c30-87f7-d8d577a64ebf"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6094), new Guid("50eaaa76-c1ba-4d68-9456-b48b0a4c00cc"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6094) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6096), new Guid("e4369bed-e699-4705-b97a-59549d399fa1"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6226), new Guid("7504472c-8165-4317-a2fb-c332164f97e4"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6230), new Guid("3117a5fc-822e-45f7-bdf1-d101d2184910"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6665), new Guid("5cf651ab-c7e2-4e76-a871-49d83e733db1"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6665) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6712), new Guid("7e4650a3-fa60-4e93-9627-e3f95b42fccc"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6716), new Guid("3810adc9-5e2d-43df-bf46-32ce3f9b2b3a"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6719), new Guid("09d2a507-e23d-4ffd-9f56-054852a5bb6b"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6722), new Guid("3af786a4-4b08-435d-94cb-7feb682e0149"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6749), new Guid("cc536c87-10f4-4d2d-92de-03174476d751"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6757), new Guid("430db985-9c4d-4f36-9a60-f3cd9604fa5f"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6760), new Guid("cbc194b5-8a94-4c3c-9a76-b17129ebdf1f"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6765), new Guid("2fa3f0fc-3db5-468f-b41e-818b510c29df"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6636), new Guid("9f2a373b-b0f4-4b13-b201-24f54572dc14"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6643), new Guid("e48cad9b-a075-4bf4-8d24-3dc83c5ae463"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6645), new Guid("f0446fd3-5b11-4b3d-bd82-751e8ccb9d3e"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6881), new Guid("c32f23da-3885-454f-bcb8-573f02162a9d"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6884), new Guid("7a55f374-87ba-4a9f-880c-2672db7ffb79"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6889), new Guid("5a1281c8-b0bb-4e05-86da-58053a54c4b4"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6889) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6892), new Guid("87f0c6f3-43f1-4842-b956-64b83e6831ec"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6894), new Guid("e9d44c80-a167-4acc-a14a-9b54fb0caaf5"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6822), new Guid("6e7b1f5b-b0a1-4893-9a32-8c60f99af4cb"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6827), new Guid("8b17dc1b-c837-4f9e-ab98-abdbf97f354a"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6830), new Guid("378e837f-98a5-4224-ad7c-74b94b9d06db"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6832), new Guid("81a7b597-2b52-4bad-a42a-4a6120222bd9"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6835), new Guid("020024d4-2b6d-4160-9833-86cbcfbe2952"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6838), new Guid("5e1aa69a-1035-4c50-8e70-c5b224ce2852"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6838) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6840), new Guid("6d5f7acb-cf20-4fac-86cf-44adff8e1d63"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6791), new Guid("15519e5f-4621-4d17-a80a-74325080c442"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6795), new Guid("e4f4356d-9693-4421-8df7-f06628c2720a"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6798), new Guid("3235ee56-f91a-4690-a93e-cea48eb3d239"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6801), new Guid("481f5e50-84e2-4d32-be61-2d0e073fa8ab"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6912), new Guid("8deea504-0c86-41c8-8ac3-e4ab2e5db3b8"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6953), new Guid("eb7cf0c1-a456-4c29-a2b7-ae95b0c4595a"), new DateTime(2023, 7, 1, 12, 52, 47, 547, DateTimeKind.Local).AddTicks(6954) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_IU_UserId",
                table: "AspNetUsers",
                column: "IU_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_D_User_IU_UserId",
                table: "AspNetUsers",
                column: "IU_UserId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_D_User_IU_UserId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_IU_UserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IU_UserId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(138), new Guid("c5442beb-9f94-4681-9bb3-1a1a82dea3f5"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(225), new Guid("3a38ea9e-51a8-4990-ad9b-da5a43515b01"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(238), new Guid("df12b8e5-f2b7-4dfa-b086-8724908440e9"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(255), new Guid("0722573c-1c04-459e-a21a-0a44a51138c5"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(258) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(270), new Guid("4dac6bd2-2727-4801-8dd9-428043b06e97"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(285), new Guid("55f6e867-ece5-4096-826d-6f8b96f25a84"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(316), new Guid("08180064-576e-46f9-aa80-c3bc1d53c606"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(329), new Guid("2ee58e82-56ae-4a68-8702-741548658d6a"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(342), new Guid("e6e79c84-2469-4ccb-8cbb-f60efa38fae9"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(357), new Guid("3a5647bf-9124-4552-980f-425b3e3db61c"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(359) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(370), new Guid("be13cdce-467b-4bb9-94c6-f905210934ed"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(386), new Guid("29aba381-b847-4955-b42b-3686895d4026"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(388) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(401), new Guid("cc7f2b06-f23e-4d6f-9201-2ee7c83c2531"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(413), new Guid("9d9f3b07-1e4a-4b92-8b28-c878f8434b94"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(416) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(426), new Guid("b0fcc9a3-e8b0-4d1a-a7fe-c48a8d2c530a"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(428) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(494), new Guid("f8ef7607-3233-43ed-a944-49ab7ea77c31"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(510), new Guid("c8267e92-25b8-4c16-bffd-e8097ca86e6e"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(523), new Guid("c25cfad9-b19c-4668-b34e-2c630dceab0f"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(526) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(536), new Guid("722436ca-fc0d-4b2d-9c12-189fb89ba9d8"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(553), new Guid("608754e1-30c6-448f-a6a9-11c3014f87ea"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(556) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(565), new Guid("07c2a996-74e9-4b99-99f3-ef24a600c895"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9349), new Guid("faebd74c-1513-4bf4-a6a8-bc16ae22c135"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9387), new Guid("08b1f6f3-257f-4f10-87a0-58530728a973"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9390) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9395), new Guid("56273319-de43-49fa-87ec-914d7fe6c2c8"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9436), new Guid("00f23459-851d-46ae-9565-d1eab39d2954"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9445), new Guid("2390afe1-d919-49f3-a671-cca6294aec24"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9453), new Guid("a11564da-072f-4fab-9831-5866d47565e2"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9455) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9460), new Guid("c86a2b21-9cf7-4d4b-89c2-46c871b7cdf7"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9468), new Guid("529bfa18-a6fa-413a-bca9-5fd4190f2b73"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9478) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9546), new Guid("4f682fdb-36fb-421a-b8d8-3bb2d3d39628"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9549) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local), new Guid("191ae578-a56d-4240-849e-964478117b97"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(9), new Guid("63c46d0a-5607-411b-9dc9-18be45ce3295"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(20), new Guid("5e92c5d3-cafe-4ef7-ae52-f6567953e87f"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(28), new Guid("4a97c032-97ab-43b2-a09e-5087f16b043a"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(40), new Guid("7202b4d1-b58d-45f4-af43-c6e1b732b4c3"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(48), new Guid("92c6bfae-5ec0-4582-a73b-ce0b785d0d80"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(55), new Guid("b98c366a-6e9c-41fa-be90-1794e9bf7cb8"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(8292), new Guid("77992f82-ef6d-48f2-8303-bfeb2a44ddaa"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(8447), new Guid("38061fdf-9c54-440b-990e-75a2fe1ea39e"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(8456), new Guid("e840fd0c-791c-4df5-9a03-54520d917f22"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9247), new Guid("56797386-ea26-418a-8505-5f6e10ec3eb9"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9263), new Guid("c320ce7b-8e85-4034-bcc3-0e72a2eb05a7"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9282), new Guid("e48cbaac-53f9-4d51-9136-2b5c3b8f818a"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9290), new Guid("466d1d61-22a5-473a-8521-a899ebbfb10f"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9941), new Guid("0382053f-623b-4777-9d5d-2a5ff4d019e6"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9950), new Guid("fb6d97ae-95ef-4a32-91f3-dad7d4eed009"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9958), new Guid("ef310d5e-e862-4be1-9240-d90d55508e5b"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9966), new Guid("37e40a00-87bf-4856-bef4-3ad8a91e2bf9"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9974), new Guid("aa155948-092b-46ef-8705-7b6d3ec9eb8b"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9660), new Guid("84444808-3818-4e58-843d-cd47ece7f2ca"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9671), new Guid("d2243931-34db-46b8-8077-0d32c26cd793"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9679), new Guid("6a3a72e7-77fa-4ed6-81f0-e5f571be1a4c"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9691), new Guid("4d8cbc2f-35c5-4bd6-b88c-e91c7f8ace3d"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9699), new Guid("e3271940-7e32-4743-990a-393cb62946db"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9707), new Guid("2a719afb-dd5a-48bb-8464-2c27749f6dfb"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9715), new Guid("4d49c2be-823b-40ba-b9df-9de091d3faa2"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9717) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9723), new Guid("31dfada4-aacc-446f-8fde-1bba9aca2f7c"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9816), new Guid("f4334e75-fa65-49de-a906-a9a50cbd7338"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9830), new Guid("96f78477-c7bc-4991-80d3-3ea3f7114d60"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9602), new Guid("83099107-786b-4366-9172-6e9a08d29072"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9606) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9612), new Guid("566d9eeb-2fa3-44a4-9d92-bb7cbc6d515f"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9619), new Guid("6ce641a6-d1f2-4816-8c50-5abb65c18d7d"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9622) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9628), new Guid("6d36498f-3a3d-43b1-b585-4dfb6fe41c84"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9897), new Guid("2ffab0ae-3130-4e37-a65f-108b32150195"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9911), new Guid("2148c9c9-ba66-42e4-964d-41ac3e2f35af"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(668), new Guid("deebb1b3-cc9b-46de-af77-8be79b6e1f54"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(681), new Guid("a97b9c2a-861c-4fd4-93cb-1602e0e5ae30"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(690), new Guid("f8884711-2090-4533-a04b-e05e4cb9b909"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(705), new Guid("7b7e665c-af45-46aa-8868-c1fd9adee890"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(714), new Guid("0e94e5fa-803d-4684-9bea-d66df8bcfe0d"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(752), new Guid("65113256-808f-44b9-9302-d3037e83bb5c"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(755) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1147), new Guid("7cd7bf3f-458f-4fc9-96ac-b9e6ec9d4171"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1226), new Guid("eef19eee-7d87-4e6a-8b4a-1420dfe5a9d6"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1239), new Guid("380f07e1-5072-46e3-94bf-3d397552c274"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1243) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(621), new Guid("bad92484-1ba4-4e7e-9e18-28c62a951b52"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(631), new Guid("32e2747b-aa53-4bc0-91f7-deacf03a53d9"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(633) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(638), new Guid("157f92e2-e8cb-4df2-96ba-1366bf4ff2c5"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1922), new Guid("a3eee8c3-0f6f-4fc7-bcff-e2ee3e523098"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1943), new Guid("fc0db104-4627-4e26-824f-f815a5dd13ac"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1985), new Guid("abb96cca-cd3c-4ba7-8a7d-b8e0fea5ba33"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2014), new Guid("ee59c1c7-3675-4577-b9c7-87b636e509f3"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2026), new Guid("c92ae589-bace-4734-9dc8-30627857eb7c"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1616), new Guid("99188038-1e65-46b0-8e1d-277f533fcfd0"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1632), new Guid("ac8b21db-f349-4391-af42-f03d504802b7"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1645), new Guid("200b238d-3b47-4f9f-8e35-51bc481f6140"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1650) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1658), new Guid("ada7644d-30a0-457f-968a-3b5112c54b23"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1670), new Guid("e1cdc3d7-17d7-4ce8-8bd2-82146dab6452"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1682), new Guid("0f61a07b-8050-46b2-bbe3-f3c8a336c2b4"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1685) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1732), new Guid("884dbb5a-bad8-4aeb-83b8-2c1ef42bdfc6"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1749) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1487), new Guid("4186bfa9-6304-4656-8629-f81e7f6f6ef1"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1510), new Guid("749f9751-975d-4175-8bab-d318739c2318"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1532), new Guid("032cfe80-f51a-48a7-9e69-36dd99402a0e"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1554), new Guid("8ae44eb8-db18-4612-9507-632626c50884"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2138), new Guid("8a66f3c1-0121-4b08-afb4-6f529d202267"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2166), new Guid("c688da53-6b81-42e4-98d4-278326c5168a"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2170) });
        }
    }
}
