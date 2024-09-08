using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_ApproveState : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ApproveState",
                schema: "Facts",
                table: "F_Condition",
                type: "bit",
                nullable: false,
                defaultValue: false)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(1568), new TimeSpan(0, 3, 30, 0, 0)), new Guid("18d6d824-fc4b-42e2-a430-3969aad0cd28") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(1578), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7349e284-f00e-4b3b-a0dc-0a3b0ab51d6c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(1581), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dfdb1dc9-a97c-470a-a4c2-b526cfbb4a7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(1583), new TimeSpan(0, 3, 30, 0, 0)), new Guid("102256a3-bb5b-4d58-a8e3-25f527cf289b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(1585), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f93df360-99ff-4c04-88b6-8f6f19fdca4d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(1587), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d0f20c24-49d9-400d-b121-5e0e54fc2543") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(8724), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d8ca6b30-039c-4062-b857-3febf8d9d851") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8686), new TimeSpan(0, 3, 30, 0, 0)), new Guid("895ee7f7-a8cf-450c-a7ec-af3aec4c29b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8710), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0f393d9b-a5ae-439a-8591-87094069800b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8716), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8adf873f-bd93-4295-8670-650f2fa981fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8722), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c098ef67-81b2-4462-a70b-b9966e2d5b78") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8728), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0bd36799-4fa2-4ad8-8411-764aa3efb89e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8743), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c916ab0e-9a7b-4d0b-a7c6-1832c2d40812") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8749), new TimeSpan(0, 3, 30, 0, 0)), new Guid("24722ef3-92ea-445e-93a6-8adcbb51c3ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8790), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6ea43a25-f5e1-4524-970e-36e1b7001e7c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8795), new TimeSpan(0, 3, 30, 0, 0)), new Guid("05d4d1dd-53a7-4f5c-b4d6-b171ef242f30") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8801), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a56b71cb-0d50-434a-8641-c6f3b1ed5533") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8806), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8073d40a-3ff4-43bb-92f9-30d451c19a9e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8811), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7f94655-f6a1-4431-a446-dedc142e766a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(8816), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1cd6f5db-da21-4892-aae0-7c501653e043") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 363, DateTimeKind.Unspecified).AddTicks(9359), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f87bc250-5c6e-42f8-9ec2-631383e4fd0a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(63), new TimeSpan(0, 3, 30, 0, 0)), new Guid("189dc905-fa7f-40d8-9707-11f160cd93f7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(80), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bfac27f3-872d-4bb8-9e07-91bffa5199fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(84), new TimeSpan(0, 3, 30, 0, 0)), new Guid("64bca20b-b323-46c3-8faf-995aaac32794") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(87), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dd606144-9255-4489-924a-4d06d87b1ee3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(89), new TimeSpan(0, 3, 30, 0, 0)), new Guid("696dfb5a-948a-499b-bcc5-c4a126acc802") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(92), new TimeSpan(0, 3, 30, 0, 0)), new Guid("80f385bc-c5db-4f48-b166-6fc4d88164da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 360, DateTimeKind.Unspecified).AddTicks(1460), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a1c609ba-9b0e-4aca-a990-999407f39426") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(2810), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b3ffa6ab-cd61-46db-bd8c-ebfe17ff664b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(6085), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4d01face-8a9d-4037-8239-5277d8968155") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(6092), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c4758189-5a7a-4e72-98bd-5250c83e3eaf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(6096), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3441dd7a-ebb6-4c23-984d-4b2880650f87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(6100), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b7b3a387-deb6-4c7b-98a2-f5cc49e89b6e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(6103), new TimeSpan(0, 3, 30, 0, 0)), new Guid("90608828-f109-40f9-9e3b-7e810604913f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(6107), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6dd79234-1a3b-4846-8fb3-e44c0fd38733") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(5144), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a4115f68-096b-40d5-97d8-ecd802d2ba90") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(5154), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e7a7b05c-9aed-489e-befc-dc36e48fe8a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(4021), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7cb07e6f-b488-4576-9e7d-e8de714eed06") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(4064), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b398e53a-74e2-43e2-bcfb-0dc416d1e267") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(4068), new TimeSpan(0, 3, 30, 0, 0)), new Guid("528ad336-2e18-4ae3-a5ef-c146dbe41d2f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 361, DateTimeKind.Unspecified).AddTicks(4070), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ef847b77-4f38-4a4b-9560-4b31bbf4f09d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 357, DateTimeKind.Unspecified).AddTicks(7045), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d007147f-1d9e-4e54-962f-c7dab946ebdf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 359, DateTimeKind.Unspecified).AddTicks(2270), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ef701aa7-e52b-416e-bcc8-c37af4dffbee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(2957), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2ed3fb1e-7c98-4c3d-bf1b-0f541880c372") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(2968), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b4ddaf55-9dde-4f3e-85f7-6f3de98e7fb3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(2971), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2cd78c77-90b1-4088-9d4c-7f35dca7596d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 364, DateTimeKind.Unspecified).AddTicks(2976), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7b2af249-6a27-42c1-a6bf-120c7303d6f5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "ApproveState", "Created", "DisplayName", "GuidRecord" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 360, DateTimeKind.Unspecified).AddTicks(9243), new TimeSpan(0, 3, 30, 0, 0)), "تایید", new Guid("c65bce9e-a302-4887-81be-0f809603b4db") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "ApproveState", "Created", "DisplayName", "GuidRecord" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(910), new TimeSpan(0, 3, 30, 0, 0)), "عدم تایید", new Guid("f15c747b-038f-4ab0-b33e-981a2b19f166") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "ApproveState", "Created", "DisplayName", "GuidRecord" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(920), new TimeSpan(0, 3, 30, 0, 0)), "بازنگری", new Guid("b716f571-f13d-4bc7-92e7-268259d11451") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "ApproveState", "Created", "DisplayName", "GuidRecord" },
                values: new object[] { false, new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 362, DateTimeKind.Unspecified).AddTicks(925), new TimeSpan(0, 3, 30, 0, 0)), "ارسال درخواست", new Guid("68612a05-7e61-45d3-960f-68f872f7b382") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 360, DateTimeKind.Unspecified).AddTicks(4786), new TimeSpan(0, 3, 30, 0, 0)), new Guid("df08b52b-8bf1-44c2-8fac-2878577184a2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 360, DateTimeKind.Unspecified).AddTicks(4799), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9aa357e6-0dad-44be-909d-d635165b388a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 360, DateTimeKind.Unspecified).AddTicks(3205), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7ec4eb83-99c9-4380-9dc1-0671bdeef221") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 360, DateTimeKind.Unspecified).AddTicks(6585), new TimeSpan(0, 3, 30, 0, 0)), new Guid("372fa555-cb2b-4106-ac4f-1b3f4e452a83") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 360, DateTimeKind.Unspecified).AddTicks(6973), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ee6071bf-8fcf-4a8c-9331-e92f32a247ec") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 8, 10, 22, 38, 360, DateTimeKind.Unspecified).AddTicks(190), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7c6357a6-7fdf-4bb8-b2eb-9f8b385ddce0") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApproveState",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(5036), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d351dd4b-87d6-43aa-a239-df1a706be089") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(5044), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bb1e95b8-4704-409a-acda-d26718a28441") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(5050), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a71c3d23-cd9d-4a91-9e02-b812289ba1e0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(5053), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4eb73060-402b-4b29-afbd-b4ac33410e70") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(5057), new TimeSpan(0, 3, 30, 0, 0)), new Guid("93d42d99-4d59-42ec-8cd9-8c32b5a79889") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(5060), new TimeSpan(0, 3, 30, 0, 0)), new Guid("75d041ab-f72a-4347-9bcb-275f75bed4a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 207, DateTimeKind.Unspecified).AddTicks(1939), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6059d615-052c-4fb5-ab2b-92e8077ceb6e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2105), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8bc9cdee-7cf7-4113-a693-f5fbb696e869") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2144), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ec5e93e9-0e1c-48dd-bf50-11faa7745c2e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2151), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0ac7c42b-0dcc-4436-ab34-e844ddb36b93") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2158), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f0df408f-e6cc-46ef-bbeb-51856ebcdf39") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2165), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9f734a55-4186-4ffb-8f1d-c35903cbcf13") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2170), new TimeSpan(0, 3, 30, 0, 0)), new Guid("16b9705b-b86d-46c1-a7cd-4a0facd3e31c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2176), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6ffcb3c2-fabb-41b3-ad9e-7dd2a4ce8775") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2190), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3372bfd6-04f1-48b4-be5b-df745851245e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2197), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f48a7477-ee13-4219-b3d5-3cac961dc709") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2202), new TimeSpan(0, 3, 30, 0, 0)), new Guid("33b498a4-d6a4-4840-b284-a14dc37fb97e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2207), new TimeSpan(0, 3, 30, 0, 0)), new Guid("834732cb-c1b6-491a-87a6-ce28defb152a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2212), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b5229c19-7451-4f88-95a1-45bba968a908") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2218), new TimeSpan(0, 3, 30, 0, 0)), new Guid("237b1c19-aa05-4de3-a588-37133d517f8a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(2771), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b6996865-e552-434e-ab0b-27ce2f174c44") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3098), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5760dc62-d5cb-4fc2-9c7b-3c16a04765da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3111), new TimeSpan(0, 3, 30, 0, 0)), new Guid("450d270a-15ac-44fa-9772-e619ebc6e156") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3119), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d6e2b91a-a1c1-4809-a16e-7776af5742e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3122), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e08d1554-bb53-4d34-a1d7-093a4eadf01e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3126), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fa20bc5c-57a5-40b1-9df1-0b819d7ea467") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3159), new TimeSpan(0, 3, 30, 0, 0)), new Guid("947cb0f3-b7fa-450d-bef3-7e49f8aaa1a3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 204, DateTimeKind.Unspecified).AddTicks(3182), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2f382ad2-bf96-4f94-964d-43f693964be3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(5636), new TimeSpan(0, 3, 30, 0, 0)), new Guid("259e45ab-c86c-4c22-a826-2709a53b9f13") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(9071), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b0c0d1fc-d875-457b-83d4-c57b050c0815") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(9079), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6c76acdf-997c-4a82-99a6-30b29b9747e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(9083), new TimeSpan(0, 3, 30, 0, 0)), new Guid("842b39f2-034d-495e-a2c1-6d03728bd39f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(9087), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9eb6194f-6f3f-4429-8487-1969a1985e2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(9091), new TimeSpan(0, 3, 30, 0, 0)), new Guid("65c95757-8ec3-4e8b-91bf-f534bc469baa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(9095), new TimeSpan(0, 3, 30, 0, 0)), new Guid("78df80f5-af1b-4c2c-960f-85711d64a74d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(8134), new TimeSpan(0, 3, 30, 0, 0)), new Guid("59e913a8-788d-4166-9067-27109c539ccd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(8140), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7249644f-ab65-44ca-81c0-85ef5eabcbb6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(6983), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2ca995b7-4f91-4235-bbd6-3e0409425d64") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(6992), new TimeSpan(0, 3, 30, 0, 0)), new Guid("722eccbe-bf55-40d5-b1aa-cba4a8b463ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(6995), new TimeSpan(0, 3, 30, 0, 0)), new Guid("77720ff4-4ca3-4d17-a333-371d1ab099d1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(6997), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4ddd77e3-69bf-48fc-a04f-0376d72435cb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 200, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7645731b-eacc-4152-bd1b-a22019acca1d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 203, DateTimeKind.Unspecified).AddTicks(4952), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f1723b4c-f0f6-433c-b7af-51882d2dc322") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(6560), new TimeSpan(0, 3, 30, 0, 0)), new Guid("52b20f7f-a2b5-4d75-96c4-c065b71aad39") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(6570), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2bfbb440-b83a-4b1e-bfa3-20936c80d006") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(6573), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5e8bbe52-108b-48f9-9d30-be97c899573f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 208, DateTimeKind.Unspecified).AddTicks(6602), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5b586d56-97c7-4fc0-a7c4-b8aa56ad994e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "DisplayName", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 205, DateTimeKind.Unspecified).AddTicks(1935), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی Approve است.", new Guid("b9490f77-e3b1-430a-a22b-bd859b8f5408") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "DisplayName", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3931), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی Reject است.", new Guid("b741fcde-27cb-4a7b-9e9f-5fb8caa91b16") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "DisplayName", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3939), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی Revise است.", new Guid("bb10f06a-cc75-4b8c-8f90-d19f7b1d2320") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "DisplayName", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 206, DateTimeKind.Unspecified).AddTicks(3944), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی SendRequest است.", new Guid("9c678e93-e63a-4fd1-96fa-37b6ba058d3b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 204, DateTimeKind.Unspecified).AddTicks(6695), new TimeSpan(0, 3, 30, 0, 0)), new Guid("520674c2-371c-4f7e-bf0c-5e5d53b5b547") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Form",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 204, DateTimeKind.Unspecified).AddTicks(6702), new TimeSpan(0, 3, 30, 0, 0)), new Guid("041b1afd-0dff-4e6c-aea7-a9f1826d7166") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 204, DateTimeKind.Unspecified).AddTicks(5254), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8483fe1c-3371-4bce-9e55-b0bbf5185352") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 204, DateTimeKind.Unspecified).AddTicks(8609), new TimeSpan(0, 3, 30, 0, 0)), new Guid("be32664b-2d6d-4ac3-8bbc-286ad63c341b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 204, DateTimeKind.Unspecified).AddTicks(9053), new TimeSpan(0, 3, 30, 0, 0)), new Guid("96b37113-6b1d-454f-ae7e-8f64b7b1f591") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 26, 15, 36, 38, 204, DateTimeKind.Unspecified).AddTicks(1701), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a763d0e6-5e57-4c09-ba7b-7e697df20aa3") });
        }
    }
}
