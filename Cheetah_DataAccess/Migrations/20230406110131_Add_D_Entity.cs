using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddDEntity : Migration
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
                values: new object[] { 1L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3010), new Guid("be277094-f315-4e68-adbe-a775358a53ed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 2L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3074), new Guid("3c49c7be-ac60-405f-8d62-bb03e5a1d361") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 1L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3082), new Guid("3cd3c2c3-a9f6-49e1-9217-6dfeb4f41493") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3665), false, new Guid("07468aed-e29d-4b01-93fd-eeda110db42f"), 1L, null, "واحدها", null, 1L, "D_Area", null },
                    { 2L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3674), false, new Guid("727298b8-70a6-4854-9f9c-a8a22ba66adb"), 2L, null, "نوع فیلد", null, 2L, "D_FieldType", null },
                    { 3L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3681), false, new Guid("cb050c4d-4704-4029-b230-0b8d6bb9221a"), 3L, null, "موقعیت ها", null, 3L, "D_Location", null },
                    { 4L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3693), false, new Guid("28da8223-86ef-44c5-8aa8-fcd3d4dcdd27"), 4L, null, "عملگرها", null, 4L, "D_Operand", null },
                    { 5L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3701), false, new Guid("e327b503-766d-40be-a66b-a0d161372514"), 5L, null, "لیست پارامترها", null, 5L, "D_ParameterList", null },
                    { 6L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3708), false, new Guid("fe0ba81f-a179-4a2a-92f6-1b20616dddbb"), 6L, null, "نوع پارامتر", null, 6L, "D_ParameterType", null },
                    { 7L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3716), false, new Guid("17039c77-0dd6-47dc-9e22-9c7852f47bce"), 7L, null, "سمت ها", null, 7L, "D_Position", null },
                    { 8L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3727), false, new Guid("0a93b246-8297-4d9d-8f96-29944a381f29"), 8L, null, "تاییدات فرآیندی", null, 8L, "D_ProcessEndorsement", null },
                    { 9L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3735), false, new Guid("ab48df2f-79c2-497d-8469-ab148f533cbe"), 9L, null, "وضعیت فرآیند", null, 9L, "D_ProcessState", null },
                    { 10L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3783), false, new Guid("2844dd48-3d84-400f-908f-daf8eed5d1ad"), 10L, null, "عنوان درخواست", null, 10L, "D_RequestTitle", null },
                    { 11L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3793), false, new Guid("46cc6f9f-baf1-492f-8366-9f17cab3dad4"), 11L, null, "نقش ها", null, 11L, "D_Role", null },
                    { 12L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3800), false, new Guid("f8389512-03d2-46a3-affd-3d21e6bf8c5b"), 12L, null, "حرفه ها", null, 12L, "D_Skill", null },
                    { 13L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3808), false, new Guid("721b5bcb-d568-4ab4-92c7-d8a8333de3a8"), 13L, null, "زیرعنوان", null, 13L, "D_SubRequestTitle", null },
                    { 14L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3817), false, new Guid("0ad67aac-4880-4ced-9f0e-d078fbfa30fb"), 14L, null, "نوع واحد", null, 14L, "D_UnitType", null },
                    { 15L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3825), false, new Guid("be13c9b8-050b-4d9d-91fd-8240a8cf397b"), 15L, null, "کاربران", null, 15L, "D_User", null },
                    { 16L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3835), false, new Guid("e643035c-362a-48ca-9acc-c4b389abb32e"), 16L, null, "تاییدها", null, 16L, "F_AllApprove", null },
                    { 17L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3843), false, new Guid("539b9887-a385-4f30-bd40-1a125dfd1073"), 17L, null, "تایید", null, 17L, "F_Approve", null },
                    { 18L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3850), false, new Guid("2e668518-b3cf-436e-8904-f9889fbd69e8"), 18L, null, "ضمیمه ها", null, 18L, "F_Attachment", null },
                    { 19L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3858), false, new Guid("f7990768-4e09-42ad-80ca-5a5a3d666550"), 19L, null, "لیست سمت ها", null, 19L, "F_EndorsementPosition", null },
                    { 20L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3865), false, new Guid("655c022b-4f78-4424-bd6c-15bf8f443136"), 20L, null, "لیست پارامترها", null, 20L, "F_ListOfParameter", null },
                    { 21L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3872), false, new Guid("4e5eed2c-f3c8-4cb1-acd2-20590e0ed079"), 21L, null, "اطلاعات درخواست ها", null, 21L, "F_RequestInformation", null },
                    { 22L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3880), false, new Guid("fd038b2b-f4e5-4044-865e-5d155b0a8459"), 22L, null, "اطلاعات کاربران", null, 22L, "F_UserInformation", null },
                    { 23L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3887), false, new Guid("b85a401f-882c-4896-ae52-ec1eb114da45"), 23L, null, "نقش-سمت", null, 23L, "L_RolePosition", null },
                    { 24L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3898), false, new Guid("acd7f1ef-4c93-45f2-8e14-2edf60bc04a6"), 24L, null, "کاربر-واحدها", null, 24L, "L_UserArea", null },
                    { 25L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3905), false, new Guid("6f87c984-c98e-4d4d-8b67-93432e52a1b2"), 25L, null, "کاربر-موقعیت", null, 25L, "L_UserLocation", null },
                    { 26L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3912), false, new Guid("deb4c9ee-f265-4dcd-b818-871890fc9064"), 26L, null, "کاربر-موقعیت‌های مرتبط", null, 26L, "L_UserRelatedLocation", null },
                    { 27L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3920), false, new Guid("880be3a4-3757-4efa-a73e-307df58424a7"), 27L, null, "کاربر-نقش", null, 27L, "L_UserRole", null },
                    { 28L, new DateTime(2023, 4, 6, 15, 31, 30, 948, DateTimeKind.Local).AddTicks(3927), false, new Guid("f2b02546-264b-4a6d-811c-f20c4ec81f84"), 28L, null, "کاربر-حرفه", null, 28L, "L_UserSkill", null }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 0L, new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1017), new Guid("380dd3e2-9e16-4821-b8e4-f18d0857c9b9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 0L, new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1066), new Guid("483267ff-eca8-4a11-8c40-d72706be69e6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Area_UnitTypeId", "CreateTimeRecord", "GuidRecord" },
                values: new object[] { 0L, new DateTime(2023, 4, 6, 14, 29, 27, 739, DateTimeKind.Local).AddTicks(1074), new Guid("df695455-7d93-4efe-ae55-d1e968e364e0") });

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
    }
}
