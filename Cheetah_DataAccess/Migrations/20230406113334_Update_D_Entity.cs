using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDEntity : Migration
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
                values: new object[] { 1L, new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1338), new Guid("54a78092-9fe5-40c4-92e6-1bc9ecb664ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 2L, new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1385), new Guid("2581916a-12cb-4ebc-8a0b-fa82703592cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 1L, new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1395), new Guid("2e489483-fff7-4603-bdb3-344c0b7c7d65") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2594), new Guid("d97b3388-7ecc-4991-aa76-5bb30fa2e263"), "واحدها(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2627), new Guid("4554626b-f978-4b73-8e16-3b362fe4d8fc"), "نوع فیلد(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2638), new Guid("cfe1562c-3db0-4a8c-9ba9-a3b009d42f20"), "موقعیت ها(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2676), new Guid("52e9bf5b-effc-42bf-8c09-02de244e04a1"), "عملگرها(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2693), new Guid("0214fea6-251d-4f96-8536-5ea70d59874d"), "لیست پارامترها(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2704), new Guid("4d80248c-8365-451a-b187-ab570dc85091"), "نوع پارامتر(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2714), new Guid("94644e52-4148-46fc-a10d-e2731227aef9"), "سمت ها(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2725), new Guid("c9810d02-bc97-4f84-a347-1c79f2348c14"), "تاییدات فرآیندی(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2735), new Guid("ec3a0a68-c3ca-431f-9811-13d5531a9a34"), "وضعیت فرآیند(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2746), new Guid("95cbfc98-39d5-4a07-8382-c387ad3b804f"), "عنوان درخواست(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2756), new Guid("e8b25718-3099-4f14-b1ae-fe87de985453"), "نقش ها(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2787), new Guid("a5ec0837-e650-4be7-8872-7bc8758353be"), "حرفه ها(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2801), new Guid("cb87e9d8-c256-45d1-97d4-25c6463a95e1"), "زیرعنوان(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2811), new Guid("46702992-b2cc-44d9-9b7a-18ff692fbb84"), "نوع واحد(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2821), new Guid("4c1d986f-268a-4656-bb7f-fa0b1944deef"), "کاربران(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2832), new Guid("b800133f-3f1a-4d80-bbf9-4a97beca08cc"), "تاییدها(Facts)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2842), new Guid("991fb45b-625c-47d5-bf95-1eb438bfcaf6"), "تایید(Facts)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2851), new Guid("a322d318-fe02-481b-b2f7-dfc756a9fc9e"), "ضمیمه ها(Facts)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2861), new Guid("79984a1d-55be-4869-9802-98b8ba3f6a5f"), "لیست سمت ها(Facts)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2871), new Guid("70b1be8c-f96e-4c6a-911b-ed0a438514b2"), "لیست پارامترها(Facts)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2885), new Guid("6e48577e-8b13-41f4-8b5e-510881d2da8b"), "اطلاعات درخواست ها(Facts)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2895), new Guid("f78369f5-fecc-44a6-88fb-fe280e0673a7"), "اطلاعات کاربران(Facts)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2905), new Guid("527f8aa2-0754-4dae-98ba-b661151dbba3"), "نقش-سمت(Links)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2915), new Guid("8804d213-65a6-4f5f-815b-7a694cacbbe1"), "کاربر-واحدها(Links)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2925), new Guid("5c96f6d4-5bd2-46d8-b468-5e803394225a"), "کاربر-موقعیت(Links)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2936), new Guid("2757dc91-5335-4b8b-9c94-a03fa9e990ca"), "کاربر-موقعیت‌های مرتبط(Links)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2946), new Guid("bf7e81e8-600c-4aa4-8bd2-e529480c6f23"), "کاربر-نقش(Links)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2968), new Guid("9354f3cf-92bb-49e4-a5c4-dc212aa1567c"), "کاربر-حرفه(Links)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1441), new Guid("59281723-2a5a-47e5-b49f-b989dc8a0579") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1451), new Guid("025b9012-7cb9-41c6-b662-bf9c7be9b44c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1477), new Guid("dd5b9abd-1d07-4c57-aaf2-023b43ad48e8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1824), new Guid("61f43420-d9b6-4f8b-8c5c-a660486da14c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1934), new Guid("f4dec16e-ae1a-493a-a08b-d4e7bbab6447") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1943), new Guid("cffc3aec-482f-4e0d-92d5-71c4e77358d9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1951), new Guid("fe954ad5-02c1-412a-b574-6c203ebb077f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1960), new Guid("7d1be286-611e-486c-bb0a-d3608c898efe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1970), new Guid("f98dafa1-30b8-481b-a148-df1abe9f02ea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(1977), new Guid("b3b4aba3-5b83-4690-938b-9710516b86e7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2119), new Guid("e03e6b2d-174d-44d9-a457-7c15f0dee840") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2161), new Guid("41412c6b-7574-4980-9e91-8a4641e206af") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2193), new Guid("f97c8a22-e014-4887-809f-6f5860377793") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2204), new Guid("0dc9660f-65fa-461d-8fc4-2ebcd12a0e8c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2216), new Guid("94ddb4ea-3fa7-4703-87eb-e900b0d32e8b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2227), new Guid("5831c612-045a-4920-a654-7a9c8a861da4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2239), new Guid("6b72325b-5768-4f5f-89d6-427c43a2582d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2250), new Guid("563d65e9-f60e-42e8-beb2-a9fa2f529d64") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2267), new Guid("3da1f8b0-1b90-419a-81ae-35bf9421e2d6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2330), new Guid("c66eebea-7778-4f29-b41a-33fab4181835") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(621), new Guid("d80d816b-9c6f-44bf-9c9f-c8813edd37b0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(793), new Guid("75d8dcbe-4713-43ec-843c-73685ca53d3d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2494), new Guid("820f4449-8ff8-4bed-8824-c10c1438ce99") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 3, 33, 376, DateTimeKind.Local).AddTicks(2529), new Guid("db573c5d-39c9-40e7-8e20-76327e3f1b9d") });
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
                values: new object[] { 0L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3010), new Guid("be277094-f315-4e68-adbe-a775358a53ed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 0L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3074), new Guid("3c49c7be-ac60-405f-8d62-bb03e5a1d361") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 0L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3082), new Guid("3cd3c2c3-a9f6-49e1-9217-6dfeb4f41493") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3665), new Guid("07468aed-e29d-4b01-93fd-eeda110db42f"), "واحدها" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3674), new Guid("727298b8-70a6-4854-9f9c-a8a22ba66adb"), "نوع فیلد" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3681), new Guid("cb050c4d-4704-4029-b230-0b8d6bb9221a"), "موقعیت ها" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3693), new Guid("28da8223-86ef-44c5-8aa8-fcd3d4dcdd27"), "عملگرها" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3701), new Guid("e327b503-766d-40be-a66b-a0d161372514"), "لیست پارامترها" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3708), new Guid("fe0ba81f-a179-4a2a-92f6-1b20616dddbb"), "نوع پارامتر" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3716), new Guid("17039c77-0dd6-47dc-9e22-9c7852f47bce"), "سمت ها" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3727), new Guid("0a93b246-8297-4d9d-8f96-29944a381f29"), "تاییدات فرآیندی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3735), new Guid("ab48df2f-79c2-497d-8469-ab148f533cbe"), "وضعیت فرآیند" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3783), new Guid("2844dd48-3d84-400f-908f-daf8eed5d1ad"), "عنوان درخواست" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3793), new Guid("46cc6f9f-baf1-492f-8366-9f17cab3dad4"), "نقش ها" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3800), new Guid("f8389512-03d2-46a3-affd-3d21e6bf8c5b"), "حرفه ها" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3808), new Guid("721b5bcb-d568-4ab4-92c7-d8a8333de3a8"), "زیرعنوان" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3817), new Guid("0ad67aac-4880-4ced-9f0e-d078fbfa30fb"), "نوع واحد" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3825), new Guid("be13c9b8-050b-4d9d-91fd-8240a8cf397b"), "کاربران" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3835), new Guid("e643035c-362a-48ca-9acc-c4b389abb32e"), "تاییدها" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3843), new Guid("539b9887-a385-4f30-bd40-1a125dfd1073"), "تایید" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3850), new Guid("2e668518-b3cf-436e-8904-f9889fbd69e8"), "ضمیمه ها" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3858), new Guid("f7990768-4e09-42ad-80ca-5a5a3d666550"), "لیست سمت ها" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3865), new Guid("655c022b-4f78-4424-bd6c-15bf8f443136"), "لیست پارامترها" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3872), new Guid("4e5eed2c-f3c8-4cb1-acd2-20590e0ed079"), "اطلاعات درخواست ها" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3880), new Guid("fd038b2b-f4e5-4044-865e-5d155b0a8459"), "اطلاعات کاربران" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3887), new Guid("b85a401f-882c-4896-ae52-ec1eb114da45"), "نقش-سمت" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3898), new Guid("acd7f1ef-4c93-45f2-8e14-2edf60bc04a6"), "کاربر-واحدها" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3905), new Guid("6f87c984-c98e-4d4d-8b67-93432e52a1b2"), "کاربر-موقعیت" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3912), new Guid("deb4c9ee-f265-4dcd-b818-871890fc9064"), "کاربر-موقعیت‌های مرتبط" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3920), new Guid("880be3a4-3757-4efa-a73e-307df58424a7"), "کاربر-نقش" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3927), new Guid("f2b02546-264b-4a6d-811c-f20c4ec81f84"), "کاربر-حرفه" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3134), new Guid("2cb87b58-daea-4193-bca1-c15db137876a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3143), new Guid("19b3fabc-0b0b-4409-83fb-0f866acb60da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3150), new Guid("d8f4b1c6-8661-4f55-bdb3-c67f48ab4aee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3204), new Guid("0ec59bfe-cec9-4fc7-8fd5-589718f59925") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3246), new Guid("d35d57b2-fe01-47e7-ae89-09b5566c3639") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3262), new Guid("efa1616c-3d27-4f41-baa7-ac2beb545348") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3270), new Guid("f6fffa9f-d4a7-42b4-8d8c-ab20462d4989") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3278), new Guid("8d9e37a8-9cda-4dd3-b44a-e0a70716b906") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3286), new Guid("f2c370db-1d8a-4d4a-9152-0c83807278f0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3294), new Guid("cd6ae0a5-0c0b-4cda-8ea5-fab1a091dc82") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3497), new Guid("c976d938-5566-407b-9f98-2ef22129ac7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3510), new Guid("8133cf5b-f334-4fc5-8cf0-b81f4894d833") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3518), new Guid("4668e780-6821-4568-ba26-146b912522da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3530), new Guid("613ed38d-e0ad-4a4f-88e7-facd7698928e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3538), new Guid("370a38d0-df33-4a67-9980-ff4b13f31087") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3545), new Guid("e611e7a0-4b4a-4acd-8027-b70488fca049") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3553), new Guid("9181e886-fb05-406d-b8f4-4387d2e8c9a7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3561), new Guid("4afef59e-9f1f-442a-a9c9-3af389c0326d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3568), new Guid("f8a90a5d-a10e-48db-9f65-4bc6b3393c21") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3576), new Guid("10c548ae-9996-4d25-a86e-1abcf1fce9c5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(2139), new Guid("5a6fd786-da37-483a-9448-2682fb3df6f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_UnitType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(2292), new Guid("f1bfe496-c3b4-4850-a75e-a56f4724c250") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3621), new Guid("3417920b-3b31-45a1-a7da-848ac5999d5f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3636), new Guid("a8a40adc-bd84-46dc-9dcf-5fc856b63b98") });
        }
    }
}
