using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initials2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 1L, new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1017), new Guid("380dd3e2-9e16-4821-b8e4-f18d0857c9b9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 2L, new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1066), new Guid("483267ff-eca8-4a11-8c40-d72706be69e6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 1L, new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1074), new Guid("df695455-7d93-4efe-ae55-d1e968e364e0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1118), new Guid("88b0d2c3-ff68-485c-b215-1d8b294dff08") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1129), new Guid("9669955d-fbb4-4b57-a425-fa6b97d46043") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1150), new Guid("36600db4-3fea-4ddf-9265-1d844e51ad63") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1237), new Guid("f3aa9ca9-a698-4422-9d71-751d9140b07d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1279), new Guid("bd254c53-e9dc-4a10-92bd-22a9e630148e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1289), new Guid("9814dfc2-cd93-42eb-9311-e456e7758af1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1297), new Guid("016b4ab7-7453-4a82-9eb9-efa640889032") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1305), new Guid("ed772d5b-c0cd-4405-ad28-df6ae28738d6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1312), new Guid("707b7857-bea2-461f-a2dd-24f4a9fbaab0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1320), new Guid("3e0f27f9-7379-420e-a884-aff39b10f3ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1448), new Guid("3dd61c27-c051-4c2c-9dd6-863cb05e4f2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1464), new Guid("2a895dfb-b20f-4a7c-a65e-455dc7192e97") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1472), new Guid("8f9eacae-3c13-44fe-a293-40f8723688c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1480), new Guid("7650b46c-72fa-42ef-b6ff-aad33be71994") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1488), new Guid("496b6d75-7d84-4f64-a1a9-0a3ad48d339e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1496), new Guid("cd82543d-7a5f-4e8a-a800-1a48fe3c9558") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1504), new Guid("d0963b17-4f2f-4387-98f9-4d1335e0066c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1512), new Guid("b87aef14-66db-41dd-8cf9-3fe520e84fdd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1520), new Guid("592fec7f-3b01-48a0-8194-f9fd45c56716") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1530), new Guid("d2552c09-6d5e-4054-b73b-9bc49c92702d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(385), new Guid("5e5049a2-b188-4810-957d-03c14e3dbcbc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(538), new Guid("286a6fa5-9632-406f-b94e-4a9a8cc172da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1572), new Guid("40c0e6fb-508a-43ba-af32-a5afd2f5035d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1583), new Guid("8b60e790-13f5-493c-bdf5-fb779005a7a0") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 0L, new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(8717), new Guid("01d81f2b-3d02-4339-9495-c1a759a452b1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 0L, new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(8761), new Guid("b191e89e-d860-4e82-a412-dea27f666e3f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 0L, new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(8790), new Guid("6d71eb02-6cad-41d2-bbc0-c0defe132688") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(9772), new Guid("a660f433-5828-4956-b9a4-65f598c61713") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(9897), new Guid("5648141d-6a32-4d46-9a39-21af80b6b009") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(9935), new Guid("4cb60d1a-6982-4bea-bb02-d193bf6ceaf1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(9991), new Guid("0f5cf115-cb4c-4462-bef2-c21f88cb67c3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(138), new Guid("38d9969a-8922-402d-8a45-621fad7fad10") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(148), new Guid("e2f81c46-0769-4de1-ae04-8da6b5bcaf3f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(156), new Guid("4af3c481-0517-4d29-817b-2fbffe7efa91") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(172), new Guid("99fb4270-6d42-491e-bb02-8a8d4066bf07") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(180), new Guid("8b1ae490-81c9-4d51-9a37-1d84a720ae8d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(187), new Guid("b184ff41-78c8-42d9-bfae-adb21ff357ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(304), new Guid("5919e329-914a-49e2-96b0-3e57a9b713f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(316), new Guid("89f48784-a8b2-4fdd-9c67-0f811f9c0a02") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(324), new Guid("840ab42a-373f-4ca6-86c7-e86d204c26c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(332), new Guid("901aab6a-c620-4f74-b753-2bdfcfce020b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(339), new Guid("5a2a47d0-d771-4638-9fae-6f425377fa5b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(350), new Guid("0f2f965d-8722-4317-b98f-df12a86e3a83") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(358), new Guid("f9f6362c-31cc-47ce-a275-374c32bd6742") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(366), new Guid("23de8749-2b3b-4d3e-9ece-30055b4b30e2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(373), new Guid("766f536f-07be-4515-8fe9-3a38771cf79d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(381), new Guid("699f5d6a-e0c5-4378-8e02-25863b0e9e1c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(8076), new Guid("82fe32a1-7c64-4745-8427-7fb9dcda50b3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 728, DateTimeKind.Local).AddTicks(8227), new Guid("715c312f-d990-44f3-a454-94a0c93362b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(451), new Guid("708a824d-0de1-40c2-87bc-7801d6f4f15b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 26, 40, 729, DateTimeKind.Local).AddTicks(461), new Guid("bc36613e-b83d-4a2e-a0cf-e16addf5c4dc") });
        }
    }
}
