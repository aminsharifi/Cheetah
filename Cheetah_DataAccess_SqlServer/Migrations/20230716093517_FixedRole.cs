using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class FixedRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FixedRole",
                schema: "Dimentions",
                table: "D_Role",
                type: "bit",
                nullable: false,
                defaultValue: false)
                .Annotation("Relational:ColumnOrder", 101);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6930), new Guid("a44ac962-6ffc-493b-abed-29f10072e100"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6936), new Guid("0caca726-3596-4377-a673-402ed70de9e5"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6938), new Guid("f62f752b-4b0b-46e7-9fac-8bbbd8a19d27"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6954), new Guid("bb626d0b-c1ea-455b-8840-2e779ae497c8"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6955) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7385), new Guid("fc9e708f-e585-48eb-8fbe-059d0714ad43"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7434), new Guid("fc056bac-838f-4853-865f-cc293155123f"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7441), new Guid("3a73835d-db16-44cf-89a6-56e50476c64f"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7448), new Guid("19e9ebd4-d505-464c-928c-1a9d208801e4"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7448) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7454), new Guid("387f38b5-8722-4d9e-afd3-570893b4a637"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7459), new Guid("b8709abf-bea9-488d-83e8-d4f110b6cc9e"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7465), new Guid("c995dee3-42c1-4242-94ec-e6f7ec76bde3"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7469), new Guid("3b7e6e8e-154d-450d-b325-c21163786055"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7474), new Guid("a0044f16-2f0f-4289-bd98-bad28452e134"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7479), new Guid("a9576818-fa60-4b4f-b9b6-9a349b4d4dc2"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7484), new Guid("4fdfd62a-5dd8-4f19-b387-5e1551e655de"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7491), new Guid("9bcb64e6-252e-4e98-816c-68d9fafa470f"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7497), new Guid("83d6aed8-b0ac-4ca7-b5ea-fa12bdca8124"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7574), new Guid("b840416e-1a45-4653-bac4-2eda7677aa5c"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7574) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7581), new Guid("4b96b784-6cba-464e-98e3-e24b9f1a762c"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7581) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7586), new Guid("4798313e-b334-490e-82fe-7a7efd253704"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7591), new Guid("25e568ce-7c0b-4ab5-b900-25661f08decf"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7595), new Guid("ac05beaa-d77a-4cae-94b5-de25c9b0f11f"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7600), new Guid("c31a6aba-060c-4461-b585-3edc3697c1f4"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7608), new Guid("9626d502-88b9-4757-84eb-5559eca2b7f2"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7608) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7025), new Guid("edfe824b-e318-4221-9264-72020903aab4"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7028), new Guid("1187b390-7886-44e7-bc61-5fd9bfc48913"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7033), new Guid("e95d44eb-d4f4-4627-8bac-7cf6218d6b04"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7052), new Guid("1bde7333-1a8d-44ac-b23d-c9263f118638"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7055), new Guid("d48f0153-f375-4149-a710-e5cab5485dbc"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7057), new Guid("60227466-ba05-4a5e-bf73-fa37c360bbdf"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7100), new Guid("bd081cfb-3bcf-4186-bb9d-4a495e7c8986"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7103), new Guid("cb85302e-613a-404e-847e-b4f56999c6ad"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7105), new Guid("38a434da-b662-441b-ad8e-5b5939f86d7d"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7342), new Guid("c4adfec2-ec27-4d0d-b4e8-16f7f27f9c3e"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7346), new Guid("f63b5de2-8890-4e03-a2d2-2c51ba8c35cd"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7351), new Guid("462fb31b-4e93-4295-96b5-d5c5bb353101"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7354), new Guid("f865a1fa-a21b-4405-a700-d30b2cae81fd"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7356), new Guid("d7984fe8-86da-484f-8a88-df1c058c2906"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7357) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7360), new Guid("0963594d-1eee-4e38-9f64-40decda3802e"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7362), new Guid("8ff0bc54-ef45-47f2-8c8c-c79926ead19d"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7363) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6623), new Guid("530eb64d-3d52-4be0-8290-390f1ba3f1d7"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6682), new Guid("7bc70877-c598-4e18-a085-f8ed1d8a3f89"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6683) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6685), new Guid("544e499b-ef1e-4785-9e27-9b56e4f56feb"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6686) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "FixedRole", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7264), false, new Guid("7e72888b-ab01-4e2f-b6b2-b276aec48c96"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "FixedRole", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7270), false, new Guid("9988dbe9-7dec-4643-b08b-4e54fc3508be"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "FixedRole", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7273), false, new Guid("7bcef196-1914-4c34-9dc7-eeeeccd4f494"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "FixedRole", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7275), false, new Guid("905f04e3-921a-43e5-a2bd-bdf74530c437"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "FixedRole", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7278), false, new Guid("66ddea9f-33ca-4aed-a3b3-fc2142e15066"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "Id", "CreateTimeRecord", "Description", "DisplayName", "DsblRecord", "ERPCode", "FixedRole", "GuidRecord", "Independent", "LastUpdatedRecord", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 100L, new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7281), null, "درخواست کننده", false, null, true, new Guid("f0dc8695-3df7-4667-96af-37c8524a3eda"), false, new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7281), "Requestor", 100L },
                    { 101L, new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7283), null, "مدیر درخواست کننده", false, null, true, new Guid("245c8947-8272-4b66-97b5-85538fc2ec56"), false, new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7284), "RequestorManager", 101L }
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7177), new Guid("38c7a466-79a1-47d3-9a27-6d1bacb96cbc"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7182), new Guid("8868a09f-144f-4465-9999-e21d98a59d42"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7183) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7185), new Guid("badfda6c-1f34-402f-b554-09e1be050b9d"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7187), new Guid("687d28d5-47fe-496e-9b2c-8b6373d7a209"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7190), new Guid("6dfb279d-fc32-4bf4-98cd-c0a83f9dd111"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7195), new Guid("cb30853b-1a2f-469b-ae5f-2cdcfe1882ec"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7197), new Guid("6cdceac1-6a0e-4340-a6cd-f34657f15669"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7200), new Guid("4fb380fa-014c-41ab-a137-196562feeece"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7203), new Guid("6cbeb282-0e3a-40d8-aff6-e5716c13d6e2"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7205), new Guid("9b506ceb-97d1-424b-8dba-1d16a2f64cd7"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7139), new Guid("e531e6c6-439b-4381-bf02-dc879b64708b"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7139) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7145), new Guid("bf74b33e-fadb-4aed-b3bf-2d5d84ae0dce"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7147), new Guid("f06eb347-037c-4955-be8e-6de42df41d8d"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7149), new Guid("7d4bd0bd-57b9-42d9-a785-840bd4cb053f"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7234), new Guid("4daafe0f-f574-4fd1-81f1-a3052082c4ba"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7237), new Guid("ffd1394e-ab8d-4721-92cb-ce11263ec2ef"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6985), new Guid("3ad8e1a4-e509-4139-a13e-6a9b90052cff"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6988), new Guid("5f857606-319d-41be-9347-22720c3e8d6c"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6990), new Guid("1d78a1bd-a10b-4045-9245-c51f08f8f1b9"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6993), new Guid("13621085-cdb6-4297-93c6-26ea2000e80d"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6995), new Guid("3cf471e6-660a-40dd-8e29-9cefddcc434e"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7676), new Guid("e94c15a4-e6d3-498a-9ae4-e64f29b91e24"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7682), new Guid("76dcb08b-c1eb-4b9a-ab74-2cad47ce71d3"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7685), new Guid("39b49312-dd7b-4eff-824f-9bc51937fbb5"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7688), new Guid("32ba2466-454c-436f-8eb4-899f5dfb54b2"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7694), new Guid("b06ef74f-b802-421c-ac96-5e35b8991449"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7694) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7715), new Guid("58679a07-de1e-43a9-afed-1e6cdecc90a4"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7719), new Guid("af0bf40d-b7d2-4e20-87ef-b8554bc39f7f"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7722), new Guid("c5b2e46e-5026-4820-8e2b-7b298011fcf4"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7724), new Guid("6de92cb9-77b9-44f7-be2a-45ed1e03490a"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7647), new Guid("f97e8397-c754-46c1-a185-146f1213b0ec"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7650), new Guid("73474b0f-1cfb-406a-97c9-58e20362dfcd"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7653), new Guid("f14f7556-d0f7-4bb2-b599-4c90f8340af7"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7864), new Guid("16b443cf-6936-4be8-9d67-87cbd632b0c6"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7868), new Guid("08f85e51-d0fb-4148-a00d-6d6317897bf5"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7870), new Guid("8b608481-e7ea-4e25-84f1-2eb100f90a73"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7873), new Guid("3793f80b-0ef7-4e59-b025-5c9afb33f537"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7875), new Guid("5df878d5-90a8-4073-bcc2-f3b6ac408860"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7823), new Guid("636a15f8-c811-495d-a6e3-89ef281f04a1"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7826), new Guid("c57da287-9001-424e-bfab-861d544a1598"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7829), new Guid("6639c240-bf70-4b8b-8a68-b0f88873fb2f"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7831), new Guid("a9e62a6b-50b5-4e3b-bb1b-afb1f2aa5b07"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7834), new Guid("bdedb85f-1d93-487c-be92-2618ed9153b7"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7837), new Guid("c835a932-2cff-4dcd-97d7-39d42b06409c"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7839), new Guid("8c6e411c-2ef3-43d6-9deb-50e0c2d15d9b"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7787), new Guid("0adbbffb-97c2-464c-9a95-7c83404d069e"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7792), new Guid("76719ceb-3da9-4df7-9a6c-c105c45535b0"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7795), new Guid("313b7bdc-e673-427f-873d-5f7ab2ae1eeb"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7800), new Guid("c02c3554-d093-43f6-9d77-af1c32155693"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7898), new Guid("0d2f6c91-f48c-48fd-af0a-b61451662ff5"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7901), new Guid("4a12311a-9b1d-4b3f-a72e-268d80274ee1"), new DateTime(2023, 7, 16, 13, 5, 16, 258, DateTimeKind.Local).AddTicks(7901) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DropColumn(
                name: "FixedRole",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8827), new Guid("987f089b-5897-4ec4-b330-a78e877f2f44"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8842), new Guid("7ecb1c3d-1b58-42f0-bdc8-cf2205f09334"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8845), new Guid("fcda8d5a-2382-4420-a00b-b2c5742970e2"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8847), new Guid("f1b6ec76-ef20-4070-9532-b59c19b0d9c6"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9254), new Guid("4b03633d-3cd8-43a5-859c-fb48abad1cb7"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9295), new Guid("e3846a46-59e7-40c5-8f0e-aed92ec35ab9"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9296) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9301), new Guid("42a257e6-7e45-48ec-bf87-c7d496ec0203"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9309), new Guid("355035c1-02c9-4d95-b899-a736bb003747"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9316), new Guid("2ff50fee-c285-4397-9921-99bd03e6df5c"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9321), new Guid("8f1e6da7-dd97-433e-95b0-c2b0443a0aa6"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9327), new Guid("5ba2ab16-74fa-4219-866d-47ad7a3b3943"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9332), new Guid("89b81e3e-825f-4f24-8e7c-af8cea5a6a75"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9337), new Guid("1c2fb9cb-2dc4-4f00-bfd4-d5f2065232c5"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9343), new Guid("2e7fa003-a035-4cf0-b9ca-cb6f866c5397"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9349), new Guid("d9638123-1fb9-497c-9339-bee916bf998f"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9357), new Guid("14862b70-8c64-43b3-8ffb-3fbb114031c3"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9362), new Guid("cf448cbc-57fd-4a19-be00-b8cb4e134d99"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9367), new Guid("82161cca-f461-4089-b145-de0f547939a8"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9372), new Guid("e668342f-e647-4664-80fb-cd9244a4290f"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9440), new Guid("fc339916-a5b4-4c09-9a92-03aa0c3832bb"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9440) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9447), new Guid("334e1432-0e66-4744-b94f-4f7323722116"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9452), new Guid("30e53385-c51a-4b00-969a-8d0a18f15570"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9458), new Guid("75f4cdc6-1ff7-4f6a-9546-4033c593be93"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9466), new Guid("9d0082ba-9eb4-46a5-9aa7-155ca5444659"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9466) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8914), new Guid("287e0a6d-802a-4938-ad5a-c3712f11639d"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8918), new Guid("077d8728-521a-4751-8b15-991086313a1e"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8921), new Guid("67dd1cd4-16a2-4fb0-bb84-63f64439880c"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8940), new Guid("71cada4b-e19b-405f-a537-091cd51b3ffc"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8943), new Guid("737303ff-b1e6-40ca-8278-853a560fe292"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8945), new Guid("0189be6a-ff8a-4355-abfe-15758722e6ad"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8947), new Guid("1735dcab-b977-423e-b748-38f859fd7158"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8950), new Guid("8018a45b-5238-4d38-b6cd-767e4a65405a"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9015), new Guid("ac7ea85b-6545-4f07-b122-e22c8a075cf0"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9175), new Guid("88cd8d68-f1a8-470d-a993-c18899f71212"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9177), new Guid("0826dae9-cf13-40a3-82c1-7289f27870f0"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9182), new Guid("999acc74-ab2f-40c4-8adb-afba3a8190cc"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9223), new Guid("cdd5bf0a-4d1c-4308-b127-745d37411feb"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9226), new Guid("b4da10d6-d51d-4a96-aa8e-082cbbec26f3"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9229), new Guid("9697615c-f93e-4c31-8708-e0b0c9f2008d"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9232), new Guid("c9ce6815-4849-4188-b75c-f762866db458"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8567), new Guid("a0af0fc7-8e3a-4658-bde0-a50f39f7a00b"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8615), new Guid("fa721d5c-8101-486f-b626-63ea71e8c79c"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8618), new Guid("bc801f95-7a4f-41d1-b02c-99580d07fda3"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9143), new Guid("aa59a8aa-d175-4c75-96f7-571fcf98ebea"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9146), new Guid("d9f03a76-0893-4aa2-a33b-c0b8db3df72d"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9149), new Guid("1ed9278c-c501-45b2-a6b1-1b00bf60965a"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9152), new Guid("b7199767-48ae-4a9a-854a-29984d088a5f"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9155), new Guid("2e112793-3322-4b35-8f24-f319fb88d505"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9067), new Guid("ed724af5-6e5b-42af-ac43-15eba188a5af"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9067) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9070), new Guid("a67240e1-cb60-4e5e-9e91-e2c74000b760"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9073), new Guid("44bee986-dd3f-4140-a1bf-3426beedbdd1"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9078), new Guid("80925a33-8bed-4fad-8c49-9a10b589b665"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9078) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9080), new Guid("cfc94fc5-ca68-4717-9f14-e5fe6db4630d"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9083), new Guid("5f3d6f14-6aa7-430a-9cc5-874ad9204704"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9086), new Guid("6c614301-940b-4a43-bbd2-2b6cb9949434"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9088), new Guid("70ca33a2-b7ec-4772-9a56-32e318216315"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9091), new Guid("cf5ef45c-1a8e-4ecc-9a08-866cec6ee892"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9094), new Guid("e7e70b65-7303-4e5e-9410-a570b6e454fa"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9045), new Guid("2ddf18ed-b758-4cf2-95f6-6bdc5609793f"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9048), new Guid("378ea968-57b7-477f-9331-d82e4dd866e0"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9050), new Guid("0fc89a85-3115-4086-976c-761b760445fd"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9053), new Guid("e0916af9-33f5-4adf-84a6-ccbac535ae15"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9118), new Guid("20e0b0ca-2fe1-4571-857e-eb7e624d27fd"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9123), new Guid("23ad0422-c29c-4bf9-989a-bae7d43fe5d3"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8875), new Guid("5c362e7c-ab3d-44bf-be33-8a409c6f4ca0"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8877), new Guid("8be5bc18-1533-405f-b674-e86329714255"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8881), new Guid("2768dfb5-0c3d-4560-b86d-afd47f760679"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8883), new Guid("86a375bb-e183-45e4-9f08-a9df61fa0cf6"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8885), new Guid("946e087e-7f63-42fe-a5c4-96b1d60f70de"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9533), new Guid("6fcf2f50-d93b-4340-b6bc-20cb33797ecb"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9540), new Guid("0fb5885d-0ffa-45ed-8bb2-89834aaaae5e"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9543), new Guid("1f9cbb90-9bb7-4bdf-8cac-9c04624f6210"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9546), new Guid("bb234a96-40f4-4571-96c2-fedf730f7e2b"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9552), new Guid("7320693a-bb72-4726-807e-31f67f1ac92b"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9574), new Guid("d5746a8e-0694-4daf-8fbb-3f3da6f2345f"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9578), new Guid("23124d72-9d11-4749-a684-9407b8c61237"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9581), new Guid("46680f62-de83-49ca-951e-42411fcd87bc"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9581) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9584), new Guid("ea33b23e-a5cb-4a83-a5d2-b2a1ba386145"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9584) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9508), new Guid("cfe9b08f-5847-4335-aa1a-7f016a365036"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9511), new Guid("06678728-310c-4560-8b04-a354a87224f2"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9514), new Guid("390b718b-9a48-45b1-a426-48b30ecbe8d1"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9724), new Guid("6b5cf4cb-f26a-4044-bb48-68f2d7a026f8"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9727), new Guid("d62477fa-0da3-481c-9548-d2fa288d970f"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9730), new Guid("06d01b98-585f-4e72-be65-75f622dcdbda"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9732), new Guid("03f7048b-f0b7-4d08-b17a-7c87f368f51b"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9735), new Guid("ac032b67-e60a-4537-96ff-c7716d1bb3c8"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9680), new Guid("09a2bdbd-ed7c-4e29-9e0c-db7d585cdd7c"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9684), new Guid("23a782f3-5fbd-4523-9aaa-97c6f97c3294"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9687), new Guid("4f479140-aae1-4c22-b3be-e1864e8e7b83"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9689), new Guid("177bdf0c-ed44-42fb-922c-eb19954694e8"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9692), new Guid("5f624d38-a73c-4e4c-a3d5-921fc9ac63a9"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9696), new Guid("e2d808ad-1918-4190-92fd-5e6c790cceac"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9698), new Guid("1274cdfa-5b6c-4a55-a2bc-684f1e55586f"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9608), new Guid("839c1526-26ce-43ed-955c-f133b1991159"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9609) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9612), new Guid("951c869b-db4f-47cb-b38b-8ed412fdb019"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9613) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9615), new Guid("c415277c-a9b8-436a-a36d-6ee33ab5ba17"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9620), new Guid("41f95e4e-a048-4267-8f13-2351fed8dbe2"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9754), new Guid("8a874634-b103-430f-9817-4a4bc195c703"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9758), new Guid("67e47ad4-4f98-4b24-a34a-26f62650d96f"), new DateTime(2023, 7, 10, 15, 27, 50, 648, DateTimeKind.Local).AddTicks(9758) });
        }
    }
}
