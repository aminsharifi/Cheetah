using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "CreateTimeRecord", "Display", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 101L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3419), false, false, new Guid("56f0cc29-72f7-40c8-8b24-9df665051a54"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3424), null, "نوع تگ‌ها(Dimentions)", null, 101L, "D_TagType", null },
                    { 102L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3535), false, false, new Guid("e3e3638f-2ff1-4310-a767-c68445d66da5"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3540), null, "موقعیت‌ها(Dimentions)", null, 102L, "D_Location", null },
                    { 103L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3562), false, false, new Guid("cd6bc4fe-22c9-4ea9-b2bb-0f37ce32d41c"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3567), null, "عملگرها(Dimentions)", null, 103L, "D_Operand", null },
                    { 104L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3583), false, false, new Guid("cd2ed379-5a45-4c07-8da7-2660e1b9bd31"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3589), null, "تگ‌ها(Dimentions)", null, 104L, "D_Tag", null },
                    { 105L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3607), true, false, new Guid("db8f5a38-4544-491e-b876-2118fcaa0a29"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3612), null, "سمت‌ها(Dimentions)", null, 105L, "D_Position", null },
                    { 106L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3629), false, false, new Guid("cff83396-6f0a-488f-8c2e-173d96df3229"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3633), null, "وضعیت فرآیندها(Dimentions)", null, 106L, "D_ProcessState", null },
                    { 107L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3687), true, false, new Guid("03a9cf99-0359-4a26-a7b8-667eddf0639f"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3691), null, "فرآیند‌ها(Dimentions)", null, 107L, "D_Process", null },
                    { 108L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3709), true, false, new Guid("0a521834-9b4d-429c-b4b2-d800d7a2cca8"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3714), null, "نقش‌ها(Dimentions)", null, 108L, "D_Role", null },
                    { 109L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3805), true, false, new Guid("e31e3ada-1674-4d08-8f45-27d0d8b2aecb"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3811), null, "کاربران(Dimentions)", null, 109L, "D_User", null },
                    { 112L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3843), false, false, new Guid("ff49eb8d-fa11-4c4c-b1ba-2c956e2718a3"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3848), null, "اطلاعات کاربرها(Facts)", null, 112L, "D_UserInformation", null },
                    { 200L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3866), false, false, new Guid("495f5f21-9c9a-4daa-be38-9ea594febf68"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3871), null, "تمام تاییدها(Facts)", null, 200L, "F_Assignment", null },
                    { 201L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3887), false, false, new Guid("98df2eb7-13e6-450d-ab85-2911c931f920"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3892), null, "تاییدهای جاری(Facts)", null, 201L, "F_Review", null },
                    { 202L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3908), false, false, new Guid("2b873548-08b8-49c9-90f4-174625e177a0"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3913), null, "ضمیمه‌ها(Facts)", null, 202L, "F_Attachment", null },
                    { 203L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3928), false, false, new Guid("e5b53f80-32da-45a8-812b-c682b7fe6ab3"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3933), null, "لیست تخصیص‌ها(Facts)", null, 203L, "F_Endorsement", null },
                    { 204L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3954), false, false, new Guid("61b154ec-6d89-49e1-9ef1-d11873009089"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3959), null, "لیست شرط‌ها(Facts)", null, 204L, "F_Condition", null },
                    { 205L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3998), true, false, new Guid("97452e5a-d2f1-42f8-90b0-e886d43d2318"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(4003), null, "اطلاعات درخواست‌ها(Facts)", null, 205L, "F_Request", null },
                    { 206L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(4023), true, false, new Guid("1f69f15f-6941-40c2-82d2-e74558005f37"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(4027), null, "سناریوها(Facts)", null, 206L, "F_Scenario", null },
                    { 300L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(4041), false, false, new Guid("09e89731-4167-4610-940a-11fb1510c861"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(4045), null, "نقش-سمت(Links)", null, 300L, "L_RolePosition", null },
                    { 301L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(4060), false, false, new Guid("2227e3db-0e61-4dde-bf5c-0d905ee10e4b"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(4065), null, "فرآیند-سناریو(Links)", null, 301L, "L_ProcessScenario", null },
                    { 302L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(4081), false, false, new Guid("48d56f8c-79b5-4468-acb8-2661d6312fd8"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(4084), null, "کاربر-موقعیت(Links)", null, 302L, "L_UserLocation", null },
                    { 303L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(4102), false, false, new Guid("68e17e20-ffb5-4146-80aa-34101ed37f24"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(4105), null, "کاربر-سمت(Links)", null, 303L, "L_UserPosition", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Location",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2253), false, new Guid("f6adcfd0-1876-48eb-bb9b-ea530a5dcedd"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2288), null, "تهران", null, 1L, "Tehran", null },
                    { 2L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2298), false, new Guid("c2e32ba6-f5ad-4771-8d46-906b0c27c015"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2302), null, "فارس", null, 2L, "Fars", null },
                    { 3L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2310), false, new Guid("16c46d34-267c-4cbc-999a-e526f08411f2"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2314), null, "اصفهان", null, 3L, "Esfahan", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2373), false, new Guid("5ca602a5-d716-47c3-bcef-387a25895ce3"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2379), null, "مساوی", null, 1L, "=", null },
                    { 2L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2389), false, new Guid("fa76a028-b53e-403e-b44a-2b6151eeb999"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2393), null, "مخالف", null, 2L, "!=", null },
                    { 3L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2402), false, new Guid("8afc40fb-08e8-452f-aed1-60bafa79b0b2"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2406), null, "بزگتر از", null, 3L, ">", null },
                    { 4L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2416), false, new Guid("2fdda993-1ec8-43af-ba91-94a1c5d01406"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2421), null, "بزرگتر و مساوی", null, 4L, ">=", null },
                    { 5L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2430), false, new Guid("04141ac7-9e81-4c2d-aa63-d5a57f6a1d07"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2448), null, " کوچکتر از", null, 5L, "<", null },
                    { 6L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2523), false, new Guid("7ece58ff-774c-4cc6-bda1-ea3f0469da45"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2529), null, "کوچکتر و مساوی", null, 6L, "<=", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3277), false, new Guid("235e87e0-d224-4b0e-81a2-50ab51e001ec"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3282), null, "معاون دارویی", null, 1L, "PharmaceuticalDeputy", null },
                    { 2L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3292), false, new Guid("7150086d-d8e7-4f6b-88ea-b265088bdd6f"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3297), null, "معاون غذایی", null, 2L, "FMCGDeputy", null },
                    { 3L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3306), false, new Guid("46596afe-18dd-4f88-8a12-be706395166f"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3311), null, "کارشناس ارشد بازرگانی", null, 3L, "BusinessSeniorSpecialist", null },
                    { 4L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3320), false, new Guid("d4961298-e5f8-4fa9-bccb-59837b519a0b"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3325), null, "کارشناس بازرگانی", null, 4L, "BusinessSpecialist", null },
                    { 5L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3334), false, new Guid("82bb2f40-b9eb-4f94-974c-271165e8a4e2"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3339), null, "کارشناس ارشد فروش", null, 5L, "SalesSeniorSpecialist", null },
                    { 6L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3354), false, new Guid("4e24f833-eeb1-45a9-bc07-ca17c7b8e596"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3358), null, "کارشناس فروش", null, 6L, "SalesSpecialist", null },
                    { 7L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3368), false, new Guid("4b999fb7-2890-49d5-9328-81f8781eb5a2"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3373), null, "مدیر مرکز توزیع", null, 7L, "DistributionCenterManager", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Process",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PC_ERP", "PC_RemoveRequestorApproval", "PC_ShowSupport", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(1192), false, new Guid("c58b2d18-b5f7-41d7-aa19-908f6fc55bc9"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(1314), true, true, true, null, "تعریف/اصلاح مشتری", null, 1L, "CustomerDefinition", null },
                    { 2L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(1411), false, new Guid("e7cac075-e246-4b99-bf6b-71ab17939536"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(1418), true, true, true, null, "مجوزهای موردی", null, 2L, "PolicyCenter", null },
                    { 3L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(1453), false, new Guid("3b2ae5f2-9666-4291-8543-ec796c358481"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(1486), true, true, true, null, "اعتباردهی مالی مشتری", null, 3L, "CustomerCredit", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_ProcessState",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2117), false, new Guid("867f1728-c917-48fa-8400-13a4b4419810"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2130), null, "در دست بررسی", null, 1L, "Ongoing", null },
                    { 2L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2144), false, new Guid("fc94a9c3-f41c-47e4-bb5e-add111f88a1d"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2148), null, "منتظر بازنگری", null, 2L, "Editing", null },
                    { 3L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2172), false, new Guid("87ef4697-9407-4600-b3cc-35f90c67cccb"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2177), null, "کامل شده", null, 3L, "Completed", null },
                    { 4L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2186), false, new Guid("a6192051-14e0-4f05-ac0e-4e4d64f25797"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2191), null, "ابطال شده", null, 4L, "Aborted", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "ROL_Independent" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3084), false, new Guid("3ffb8a40-4996-452d-9694-205cc67b9193"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3089), null, "معاونت دارویی", null, 1L, "PharmaceuticalDeputy", null, true },
                    { 2L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3098), false, new Guid("0f9ed14b-23a6-41f9-abd3-066b704caab6"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3104), null, "معاونت غذایی", null, 2L, "FMCGDeputy", null, true },
                    { 3L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3120), false, new Guid("99a21bb8-1fb7-42c5-bf63-f6f56fd96cf2"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3124), null, "کارشناس بازرگانی", null, 3L, "BusinessSpecialist", null, true },
                    { 4L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3133), false, new Guid("f0b5efc6-f24f-4771-89c4-332d81e53ddc"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3138), null, "کارشناس فروش", null, 4L, "SalesSpecialist", null, true },
                    { 5L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3217), false, new Guid("768fa5a1-f46a-4ad1-8a3e-5052ae25fe72"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3223), null, "مدیریت مرکز توزیع", null, 5L, "DistributionCenterManager", null, false }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagType",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2702), false, new Guid("f21a37f1-24f5-46ba-960a-750719a48fe2"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2709), null, "عددی", null, 1L, "Numberic", null },
                    { 2L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2718), false, new Guid("bc78fff8-3af5-4097-895c-0f1413b6985b"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2722), null, "دودویی", null, 2L, "Boolean", null },
                    { 3L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2736), false, new Guid("64d4784d-24a8-46a2-864e-161d5f694cf5"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2741), null, "تاریخ", null, 3L, "Date", null },
                    { 4L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2749), false, new Guid("5b05007b-0262-41cc-9b1b-3f965de6b5c0"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2754), null, "حروف", null, 4L, "String", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "User_CreatedCasesSkipAssigRules", "User_DelegateEnabled", "User_DelegateId", "User_Domain", "User_EnabledForAssignation", "User_IDPersonel", "User_LDAPDescription", "User_UserInformationId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3019), false, new Guid("e3342b21-a73a-433f-8cb1-a4bbe941fb1b"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3025), null, "محمد شریفی", null, 1L, "m.sharifi", null, null, null, null, null, null, null, null, null },
                    { 2L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3036), false, new Guid("3ce58079-34dd-40bc-a270-dd2a0707e439"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(3041), null, "امین شریفی", null, 2L, "a.sharifi", null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Scenario",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(4195), false, new Guid("9a428ab2-ebbe-4e89-ba4e-30268224e88b"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(4200), null, "سناریو ستاد", null, 1L, "Head_Scenario3", null },
                    { 2L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(4322), false, new Guid("2cd9b636-af22-4617-bbb9-0f86757688d9"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5300), null, "سناریو دارویی", null, 2L, "Med_Scenario", null },
                    { 3L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5357), false, new Guid("f97651da-6bf5-4d39-9a7c-cfe9c3a87ba0"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5363), null, "سناریو مصرفی", null, 3L, "FMCG_Scenario", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "TG_TagTypeId" },
                values: new object[,]
                {
                    { 100L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2808), false, new Guid("970dcbf5-26a4-4625-acac-739f21c69fb2"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2813), "عددی", "سهم شرکت", null, 100L, "OursShare", null, 1L },
                    { 101L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2824), false, new Guid("b54e9fbb-3cce-48a4-a3d9-8eafd9d08a56"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2829), "عددی", "سهم دیگران", null, 101L, "OthersShare", null, 1L },
                    { 103L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2838), false, new Guid("61e22070-50a5-4304-b039-a9f55aeec3e8"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2842), "عددی", "مبلغ", null, 103L, "Price", null, 1L },
                    { 200L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2851), false, new Guid("ca3f4567-9c60-4013-8b44-92edaa553303"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2856), "دودویی", "مخدر/ یخچالی", null, 200L, "Refrigerator", null, 2L },
                    { 201L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2868), false, new Guid("d45ca872-5196-4d9f-ba77-463da821c7d5"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2873), "پارامتریک", "تایید", null, 201L, "Approve", null, 2L },
                    { 202L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2882), false, new Guid("db85b969-0ea8-4322-b4e3-bf082a640abf"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2887), "پارامتریک", "عدم تایید", null, 202L, "Reject", null, 2L },
                    { 203L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2903), false, new Guid("19934b48-64b9-46fd-952f-8391f68e1b88"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2907), "پارامتریک", "بازنگری", null, 203L, "Revise", null, 2L },
                    { 204L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2916), false, new Guid("69b09965-a3e2-478a-bd4d-58f693b16652"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2921), "پارامتریک", "دارویی", null, 204L, "Med", null, 2L },
                    { 205L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2929), false, new Guid("1e6c8bf4-7cfb-41ee-a4c3-5b67893e4356"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2934), "پارامتریک", "مصرفی", null, 205L, "FMCG", null, 2L },
                    { 206L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2943), false, new Guid("a1b41318-4bef-426a-8825-365a946871da"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(2948), "پارامتریک", "کل", null, 206L, "General", null, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Endorsement",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "ED_RoleId", "ED_ScenarioId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5633), false, 5L, 3L, new Guid("65b04ba2-97c5-4d3f-87f9-18770b0df145"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5639), null, "سناریو سه,مدیریت مرکز توزیع", null, 1L, "Med_Scenario,DistributionCenterManager", null },
                    { 2L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5661), false, 2L, 3L, new Guid("74a8160f-bc17-4676-a55f-4f55d4d48653"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5666), null, "سناریو سه,معاونت غذایی", null, 2L, "Strategy3,FMCGDeputy", null },
                    { 3L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5677), false, 1L, 2L, new Guid("77b090eb-5ab3-4ac7-b416-752255444cde"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5682), null, "سناریو دو,معاونت دارویی", null, 3L, "Strategy2,PharmaceuticalDeputy", null },
                    { 4L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5694), false, 2L, 1L, new Guid("2004fe23-2ed2-4452-a9af-ab022175a037"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5698), null, "سناریو دارویی,معاونت دارویی", null, 4L, "Med_Scenario,PharmaceuticalDeputy", null }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_ProcessScenario",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(6028), false, 1L, new Guid("e7de464e-254c-4a9b-9cd6-2b33a30280b8"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(6034), null, "تعریف/اصلاح مشتری-سناریو سه", null, 1L, "CustomerDefinition-Strategy3", 3L },
                    { 2L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(6260), false, 1L, new Guid("550777f6-f3f8-40b7-9b31-fa3b8eb9c9b2"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(6267), null, "تعریف/اصلاح مشتری-سناریو یک", null, 2L, "CustomerDefinition-Strategy1", 1L },
                    { 3L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(6284), false, 2L, new Guid("84980cc9-2da3-4931-9c46-26526bd07a3c"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(6289), null, "مجوزهای موردی-سناریو یک", null, 3L, "PolicyCenter-Strategy1", 1L },
                    { 4L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(6299), false, 1L, new Guid("2fcc9de4-5349-4e7a-a49d-2e80b0cba903"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(6303), null, "تعریف/اصلاح مشتری-سناریو دو", null, 4L, "PolicyCenter-Strategy2", 2L },
                    { 5L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(6312), false, 2L, new Guid("15540f27-8dcc-4722-9b75-cbf9d1e3b93d"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(6317), null, "مجوزهای موردی-سناریو دو", null, 5L, "CustomerDefinition-Strategy2", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_RolePosition",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5846), false, 1L, new Guid("c8a94a9d-a9bd-463d-a12f-3bb43b1ee1ef"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5851), null, "معاونت دارویی-معاون دارویی", null, 1L, "PharmaceuticalDeputy-PharmaceuticalDeputy", 1L },
                    { 2L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5867), false, 2L, new Guid("d55a2025-9bb6-416e-b091-abb52e6048de"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5871), null, "معاونت غذایی-معاون غذایی", null, 2L, "FMCGDeputy-FMCGDeputy", 2L },
                    { 3L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5880), false, 3L, new Guid("e14c9300-2c16-4c7a-9669-e77855988d3c"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5884), null, "کارشناس بازرگانی-کارشناس ارشد بازرگانی", null, 3L, "BusinessSpecialist-BusinessSeniorSpecialist", 3L },
                    { 4L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5894), false, 3L, new Guid("0e9b89d5-0df7-4d48-aa46-d431edd5b311"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5899), null, "کارشناس بازرگانی-کارشناس بازرگانی", null, 4L, "BusinessSpecialist-BusinessSpecialist", 4L },
                    { 5L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5908), false, 4L, new Guid("c0e5269b-e49c-4190-8257-5f9dfacee0ed"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5913), null, "کارشناس فروش-کارشناس ارشد فروش", null, 5L, "SalesSpecialist-SalesSeniorSpecialist", 5L },
                    { 6L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5922), false, 4L, new Guid("ea42d06a-a56a-4fc3-9b2e-14b32052355c"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5927), null, "کارشناس فروش-کارشناس فروش", null, 6L, "SalesSpecialist-SalesSpecialist", 6L },
                    { 7L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5936), false, 5L, new Guid("9ea2ae0c-f6e7-4ebb-a0a6-b0e28faa1ac1"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5940), null, "مدیریت مرکز توزیع-مدیر مرکز توزیع", null, 7L, "DistributionCenterManager-DistributionCenterManager", 7L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserLocation",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5757), false, 1L, new Guid("8d45d5c0-fc8a-427c-a022-46fc6bdbdc13"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5762), null, "محمد شریفی-تهران", null, 1L, "m.sharifi-Tehran", 1L },
                    { 2L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5776), false, 2L, new Guid("4a9ca60c-e411-4c56-bb70-477f8fccb506"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5780), null, "امین شریفی-فارس", null, 2L, "a.sharifi-Fars", 2L },
                    { 3L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5789), false, 1L, new Guid("8a49f42f-314c-4899-9494-390aa85cd5db"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5794), null, "محمد شریفی-فارس", null, 3L, "m.sharifi-Fars", 2L },
                    { 4L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5803), false, 2L, new Guid("378ceead-1d86-4112-befa-f918df049355"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5807), null, "امین شریفی-تهران", null, 4L, "a.sharifi-Tehran", 1L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserPosition",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(6371), false, 1L, new Guid("9bc14f0c-0758-4e50-a54c-0bb5f28c63f4"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(6377), null, "محمد شریفی-مدیر مرکز", null, 1L, "m.sharifi-PharmaceuticalDeputy", 7L },
                    { 2L, new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(6386), false, 2L, new Guid("84f4a13c-404b-4f73-af61-d33ccdb9dbf7"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(6391), null, "امین شریفی-معاون غذایی", null, 2L, "a.sharifi-FMCGDeputy", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "CD_EndorsementId", "CD_OperandId", "CD_RequestId", "CD_ScenarioId", "CD_TagId", "CD_Value", "CreateTimeRecord", "D_UserId", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, 2L, 3L, null, 1L, 100L, "0", new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5501), null, false, new Guid("67ffbaad-a5f0-4989-8031-8b0beee686df"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5508), null, "سناریو ستاد,سهم شرکت,بزگتر از,0", null, 1L, "Head_Scenario,OursShare,>,0", null },
                    { 2L, null, 1L, null, 2L, 204L, "1", new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5522), null, false, new Guid("96dbc6d7-d093-4cf9-9ef6-c96e4ae86df4"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5525), null, "سناریو دارویی,دارویی,مساوی,1", null, 2L, "Med_Scenario,Med,=,1", null },
                    { 3L, null, 3L, null, 2L, 100L, "0", new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5542), null, false, new Guid("4e89dd0c-e74e-4add-b7c5-a3c00f14a0cd"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5546), null, "سناریو دارویی,سهم شرکت,بزگتر از,0", null, 3L, "Med_Scenario,OursShare,>,0", null },
                    { 4L, null, 1L, null, 3L, 205L, "1", new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5555), null, false, new Guid("7334453a-4322-4ec8-991d-5ba8162fdeb9"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5559), null, "سناریو مصرفی,مصرفی,مساوی,1", null, 4L, "FMCG_Scenario,FMCG,=,1", null },
                    { 5L, null, 3L, null, 3L, 103L, "0", new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5569), null, false, new Guid("4d149846-bd7a-49fe-ad59-45569044c14c"), new DateTime(2023, 6, 28, 23, 36, 21, 900, DateTimeKind.Local).AddTicks(5573), null, "سناریو مصرفی,مبلغ,بزگتر از,0", null, 5L, "FMCG_Scenario,Price,>,0", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L);

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
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L);

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

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
