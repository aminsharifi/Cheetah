using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess_SqlServer.Migrations
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
                    { 101L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(138), false, false, new Guid("c5442beb-9f94-4681-9bb3-1a1a82dea3f5"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(142), null, "نوع تگ‌ها(Dimentions)", null, 101L, "D_TagType", null },
                    { 102L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(225), false, false, new Guid("3a38ea9e-51a8-4990-ad9b-da5a43515b01"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(227), null, "موقعیت‌ها(Dimentions)", null, 102L, "D_Location", null },
                    { 103L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(238), false, false, new Guid("df12b8e5-f2b7-4dfa-b086-8724908440e9"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(240), null, "عملگرها(Dimentions)", null, 103L, "D_Operand", null },
                    { 104L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(255), false, false, new Guid("0722573c-1c04-459e-a21a-0a44a51138c5"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(258), null, "تگ‌ها(Dimentions)", null, 104L, "D_Tag", null },
                    { 105L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(270), true, false, new Guid("4dac6bd2-2727-4801-8dd9-428043b06e97"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(273), null, "سمت‌ها(Dimentions)", null, 105L, "D_Position", null },
                    { 106L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(285), false, false, new Guid("55f6e867-ece5-4096-826d-6f8b96f25a84"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(288), null, "وضعیت فرآیندها(Dimentions)", null, 106L, "D_ProcessState", null },
                    { 107L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(316), true, false, new Guid("08180064-576e-46f9-aa80-c3bc1d53c606"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(319), null, "فرآیند‌ها(Dimentions)", null, 107L, "D_Process", null },
                    { 108L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(329), true, false, new Guid("2ee58e82-56ae-4a68-8702-741548658d6a"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(331), null, "نقش‌ها(Dimentions)", null, 108L, "D_Role", null },
                    { 109L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(342), true, false, new Guid("e6e79c84-2469-4ccb-8cbb-f60efa38fae9"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(344), null, "کاربران(Dimentions)", null, 109L, "D_User", null },
                    { 112L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(357), false, false, new Guid("3a5647bf-9124-4552-980f-425b3e3db61c"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(359), null, "اطلاعات کاربرها(Facts)", null, 112L, "D_UserInformation", null },
                    { 200L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(370), false, false, new Guid("be13cdce-467b-4bb9-94c6-f905210934ed"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(372), null, "تمام تاییدها(Facts)", null, 200L, "F_Assignment", null },
                    { 201L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(386), false, false, new Guid("29aba381-b847-4955-b42b-3686895d4026"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(388), null, "تاییدهای جاری(Facts)", null, 201L, "F_Review", null },
                    { 202L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(401), false, false, new Guid("cc7f2b06-f23e-4d6f-9201-2ee7c83c2531"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(403), null, "ضمیمه‌ها(Facts)", null, 202L, "F_Attachment", null },
                    { 203L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(413), false, false, new Guid("9d9f3b07-1e4a-4b92-8b28-c878f8434b94"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(416), null, "لیست تخصیص‌ها(Facts)", null, 203L, "F_Endorsement", null },
                    { 204L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(426), false, false, new Guid("b0fcc9a3-e8b0-4d1a-a7fe-c48a8d2c530a"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(428), null, "لیست شرط‌ها(Facts)", null, 204L, "F_Condition", null },
                    { 205L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(494), true, false, new Guid("f8ef7607-3233-43ed-a944-49ab7ea77c31"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(497), null, "اطلاعات درخواست‌ها(Facts)", null, 205L, "F_Request", null },
                    { 206L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(510), true, false, new Guid("c8267e92-25b8-4c16-bffd-e8097ca86e6e"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(512), null, "سناریوها(Facts)", null, 206L, "F_Scenario", null },
                    { 300L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(523), false, false, new Guid("c25cfad9-b19c-4668-b34e-2c630dceab0f"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(526), null, "نقش-سمت(Links)", null, 300L, "L_RolePosition", null },
                    { 301L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(536), false, false, new Guid("722436ca-fc0d-4b2d-9c12-189fb89ba9d8"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(538), null, "فرآیند-سناریو(Links)", null, 301L, "L_ProcessScenario", null },
                    { 302L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(553), false, false, new Guid("608754e1-30c6-448f-a6a9-11c3014f87ea"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(556), null, "کاربر-موقعیت(Links)", null, 302L, "L_UserLocation", null },
                    { 303L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(565), false, false, new Guid("07c2a996-74e9-4b99-99f3-ef24a600c895"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(568), null, "کاربر-سمت(Links)", null, 303L, "L_UserPosition", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Location",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9349), false, new Guid("faebd74c-1513-4bf4-a6a8-bc16ae22c135"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9380), null, "تهران", null, 1L, "Tehran", null },
                    { 2L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9387), false, new Guid("08b1f6f3-257f-4f10-87a0-58530728a973"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9390), null, "فارس", null, 2L, "Fars", null },
                    { 3L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9395), false, new Guid("56273319-de43-49fa-87ec-914d7fe6c2c8"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9398), null, "اصفهان", null, 3L, "Esfahan", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9436), false, new Guid("00f23459-851d-46ae-9565-d1eab39d2954"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9439), null, "مساوی", null, 1L, "=", null },
                    { 2L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9445), false, new Guid("2390afe1-d919-49f3-a671-cca6294aec24"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9447), null, "مخالف", null, 2L, "!=", null },
                    { 3L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9453), false, new Guid("a11564da-072f-4fab-9831-5866d47565e2"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9455), null, "بزگتر از", null, 3L, ">", null },
                    { 4L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9460), false, new Guid("c86a2b21-9cf7-4d4b-89c2-46c871b7cdf7"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9463), null, "بزرگتر و مساوی", null, 4L, ">=", null },
                    { 5L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9468), false, new Guid("529bfa18-a6fa-413a-bca9-5fd4190f2b73"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9478), null, " کوچکتر از", null, 5L, "<", null },
                    { 6L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9546), false, new Guid("4f682fdb-36fb-421a-b8d8-3bb2d3d39628"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9549), null, "کوچکتر و مساوی", null, 6L, "<=", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local), false, new Guid("191ae578-a56d-4240-849e-964478117b97"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(3), null, "معاون دارویی", null, 1L, "PharmaceuticalDeputy", null },
                    { 2L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(9), false, new Guid("63c46d0a-5607-411b-9dc9-18be45ce3295"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(12), null, "معاون غذایی", null, 2L, "FMCGDeputy", null },
                    { 3L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(20), false, new Guid("5e92c5d3-cafe-4ef7-ae52-f6567953e87f"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(23), null, "کارشناس ارشد بازرگانی", null, 3L, "BusinessSeniorSpecialist", null },
                    { 4L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(28), false, new Guid("4a97c032-97ab-43b2-a09e-5087f16b043a"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(31), null, "کارشناس بازرگانی", null, 4L, "BusinessSpecialist", null },
                    { 5L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(40), false, new Guid("7202b4d1-b58d-45f4-af43-c6e1b732b4c3"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(42), null, "کارشناس ارشد فروش", null, 5L, "SalesSeniorSpecialist", null },
                    { 6L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(48), false, new Guid("92c6bfae-5ec0-4582-a73b-ce0b785d0d80"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(50), null, "کارشناس فروش", null, 6L, "SalesSpecialist", null },
                    { 7L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(55), false, new Guid("b98c366a-6e9c-41fa-be90-1794e9bf7cb8"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(58), null, "مدیر مرکز توزیع", null, 7L, "DistributionCenterManager", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Process",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PC_ERP", "PC_RemoveRequestorApproval", "PC_ShowSupport", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(8292), false, new Guid("77992f82-ef6d-48f2-8303-bfeb2a44ddaa"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(8384), true, true, true, null, "تعریف/اصلاح مشتری", null, 1L, "CustomerDefinition", null },
                    { 2L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(8447), false, new Guid("38061fdf-9c54-440b-990e-75a2fe1ea39e"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(8450), true, true, true, null, "مجوزهای موردی", null, 2L, "PolicyCenter", null },
                    { 3L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(8456), false, new Guid("e840fd0c-791c-4df5-9a03-54520d917f22"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(8480), true, true, true, null, "اعتباردهی مالی مشتری", null, 3L, "CustomerCredit", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_ProcessState",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9247), false, new Guid("56797386-ea26-418a-8505-5f6e10ec3eb9"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9254), null, "در دست بررسی", null, 1L, "Ongoing", null },
                    { 2L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9263), false, new Guid("c320ce7b-8e85-4034-bcc3-0e72a2eb05a7"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9265), null, "منتظر بازنگری", null, 2L, "Editing", null },
                    { 3L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9282), false, new Guid("e48cbaac-53f9-4d51-9136-2b5c3b8f818a"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9285), null, "کامل شده", null, 3L, "Completed", null },
                    { 4L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9290), false, new Guid("466d1d61-22a5-473a-8521-a899ebbfb10f"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9293), null, "ابطال شده", null, 4L, "Aborted", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "ROL_Independent" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9941), false, new Guid("0382053f-623b-4777-9d5d-2a5ff4d019e6"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9943), null, "معاونت دارویی", null, 1L, "PharmaceuticalDeputy", null, true },
                    { 2L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9950), false, new Guid("fb6d97ae-95ef-4a32-91f3-dad7d4eed009"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9953), null, "معاونت غذایی", null, 2L, "FMCGDeputy", null, true },
                    { 3L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9958), false, new Guid("ef310d5e-e862-4be1-9240-d90d55508e5b"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9960), null, "کارشناس بازرگانی", null, 3L, "BusinessSpecialist", null, true },
                    { 4L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9966), false, new Guid("37e40a00-87bf-4856-bef4-3ad8a91e2bf9"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9968), null, "کارشناس فروش", null, 4L, "SalesSpecialist", null, true },
                    { 5L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9974), false, new Guid("aa155948-092b-46ef-8705-7b6d3ec9eb8b"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9976), null, "مدیریت مرکز توزیع", null, 5L, "DistributionCenterManager", null, false }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagType",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9602), false, new Guid("83099107-786b-4366-9172-6e9a08d29072"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9606), null, "عددی", null, 1L, "Numberic", null },
                    { 2L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9612), false, new Guid("566d9eeb-2fa3-44a4-9d92-bb7cbc6d515f"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9614), null, "دودویی", null, 2L, "Boolean", null },
                    { 3L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9619), false, new Guid("6ce641a6-d1f2-4816-8c50-5abb65c18d7d"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9622), null, "تاریخ", null, 3L, "Date", null },
                    { 4L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9628), false, new Guid("6d36498f-3a3d-43b1-b585-4dfb6fe41c84"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9631), null, "حروف", null, 4L, "String", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "User_CreatedCasesSkipAssigRules", "User_DelegateEnabled", "User_DelegateId", "User_Domain", "User_EnabledForAssignation", "User_IDPersonel", "User_LDAPDescription", "User_UserInformationId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9897), false, new Guid("2ffab0ae-3130-4e37-a65f-108b32150195"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9900), null, "محمد شریفی", null, 1L, "m.sharifi", null, null, null, null, null, null, null, null, null },
                    { 2L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9911), false, new Guid("2148c9c9-ba66-42e4-964d-41ac3e2f35af"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9913), null, "امین شریفی", null, 2L, "a.sharifi", null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Scenario",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(621), false, new Guid("bad92484-1ba4-4e7e-9e18-28c62a951b52"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(624), null, "سناریو ستاد", null, 1L, "Head_Scenario3", null },
                    { 2L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(631), false, new Guid("32e2747b-aa53-4bc0-91f7-deacf03a53d9"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(633), null, "سناریو دارویی", null, 2L, "Med_Scenario", null },
                    { 3L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(638), false, new Guid("157f92e2-e8cb-4df2-96ba-1366bf4ff2c5"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(641), null, "سناریو مصرفی", null, 3L, "FMCG_Scenario", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "TG_TagTypeId" },
                values: new object[,]
                {
                    { 100L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9660), false, new Guid("84444808-3818-4e58-843d-cd47ece7f2ca"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9664), "عددی", "سهم شرکت", null, 100L, "OursShare", null, 1L },
                    { 101L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9671), false, new Guid("d2243931-34db-46b8-8077-0d32c26cd793"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9673), "عددی", "سهم دیگران", null, 101L, "OthersShare", null, 1L },
                    { 103L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9679), false, new Guid("6a3a72e7-77fa-4ed6-81f0-e5f571be1a4c"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9682), "عددی", "مبلغ", null, 103L, "Price", null, 1L },
                    { 200L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9691), false, new Guid("4d8cbc2f-35c5-4bd6-b88c-e91c7f8ace3d"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9694), "دودویی", "مخدر/ یخچالی", null, 200L, "Refrigerator", null, 2L },
                    { 201L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9699), false, new Guid("e3271940-7e32-4743-990a-393cb62946db"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9702), "پارامتریک", "تایید", null, 201L, "Approve", null, 2L },
                    { 202L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9707), false, new Guid("2a719afb-dd5a-48bb-8464-2c27749f6dfb"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9709), "پارامتریک", "عدم تایید", null, 202L, "Reject", null, 2L },
                    { 203L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9715), false, new Guid("4d49c2be-823b-40ba-b9df-9de091d3faa2"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9717), "پارامتریک", "بازنگری", null, 203L, "Revise", null, 2L },
                    { 204L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9723), false, new Guid("31dfada4-aacc-446f-8fde-1bba9aca2f7c"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9725), "پارامتریک", "دارویی", null, 204L, "Med", null, 2L },
                    { 205L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9816), false, new Guid("f4334e75-fa65-49de-a906-a9a50cbd7338"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9820), "پارامتریک", "مصرفی", null, 205L, "FMCG", null, 2L },
                    { 206L, new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9830), false, new Guid("96f78477-c7bc-4991-80d3-3ea3f7114d60"), new DateTime(2023, 6, 29, 11, 46, 11, 232, DateTimeKind.Local).AddTicks(9832), "پارامتریک", "کل", null, 206L, "General", null, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Endorsement",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "ED_RoleId", "ED_ScenarioId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(752), false, 5L, 3L, new Guid("65113256-808f-44b9-9302-d3037e83bb5c"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(755), null, "سناریو سه,مدیریت مرکز توزیع", null, 1L, "Med_Scenario,DistributionCenterManager", null },
                    { 2L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1147), false, 2L, 3L, new Guid("7cd7bf3f-458f-4fc9-96ac-b9e6ec9d4171"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1183), null, "سناریو سه,معاونت غذایی", null, 2L, "Strategy3,FMCGDeputy", null },
                    { 3L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1226), false, 1L, 2L, new Guid("eef19eee-7d87-4e6a-8b4a-1420dfe5a9d6"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1230), null, "سناریو دو,معاونت دارویی", null, 3L, "Strategy2,PharmaceuticalDeputy", null },
                    { 4L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1239), false, 2L, 1L, new Guid("380f07e1-5072-46e3-94bf-3d397552c274"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1243), null, "سناریو دارویی,معاونت دارویی", null, 4L, "Med_Scenario,PharmaceuticalDeputy", null }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_ProcessScenario",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1922), false, 1L, new Guid("a3eee8c3-0f6f-4fc7-bcff-e2ee3e523098"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1931), null, "تعریف/اصلاح مشتری-سناریو سه", null, 1L, "CustomerDefinition-Strategy3", 3L },
                    { 2L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1943), false, 1L, new Guid("fc0db104-4627-4e26-824f-f815a5dd13ac"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1950), null, "تعریف/اصلاح مشتری-سناریو یک", null, 2L, "CustomerDefinition-Strategy1", 1L },
                    { 3L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1985), false, 2L, new Guid("abb96cca-cd3c-4ba7-8a7d-b8e0fea5ba33"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2002), null, "مجوزهای موردی-سناریو یک", null, 3L, "PolicyCenter-Strategy1", 1L },
                    { 4L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2014), false, 1L, new Guid("ee59c1c7-3675-4577-b9c7-87b636e509f3"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2018), null, "تعریف/اصلاح مشتری-سناریو دو", null, 4L, "PolicyCenter-Strategy2", 2L },
                    { 5L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2026), false, 2L, new Guid("c92ae589-bace-4734-9dc8-30627857eb7c"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2029), null, "مجوزهای موردی-سناریو دو", null, 5L, "CustomerDefinition-Strategy2", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_RolePosition",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1616), false, 1L, new Guid("99188038-1e65-46b0-8e1d-277f533fcfd0"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1622), null, "معاونت دارویی-معاون دارویی", null, 1L, "PharmaceuticalDeputy-PharmaceuticalDeputy", 1L },
                    { 2L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1632), false, 2L, new Guid("ac8b21db-f349-4391-af42-f03d504802b7"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1636), null, "معاونت غذایی-معاون غذایی", null, 2L, "FMCGDeputy-FMCGDeputy", 2L },
                    { 3L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1645), false, 3L, new Guid("200b238d-3b47-4f9f-8e35-51bc481f6140"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1650), null, "کارشناس بازرگانی-کارشناس ارشد بازرگانی", null, 3L, "BusinessSpecialist-BusinessSeniorSpecialist", 3L },
                    { 4L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1658), false, 3L, new Guid("ada7644d-30a0-457f-968a-3b5112c54b23"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1662), null, "کارشناس بازرگانی-کارشناس بازرگانی", null, 4L, "BusinessSpecialist-BusinessSpecialist", 4L },
                    { 5L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1670), false, 4L, new Guid("e1cdc3d7-17d7-4ce8-8bd2-82146dab6452"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1674), null, "کارشناس فروش-کارشناس ارشد فروش", null, 5L, "SalesSpecialist-SalesSeniorSpecialist", 5L },
                    { 6L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1682), false, 4L, new Guid("0f61a07b-8050-46b2-bbe3-f3c8a336c2b4"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1685), null, "کارشناس فروش-کارشناس فروش", null, 6L, "SalesSpecialist-SalesSpecialist", 6L },
                    { 7L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1732), false, 5L, new Guid("884dbb5a-bad8-4aeb-83b8-2c1ef42bdfc6"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1749), null, "مدیریت مرکز توزیع-مدیر مرکز توزیع", null, 7L, "DistributionCenterManager-DistributionCenterManager", 7L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserLocation",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1487), false, 1L, new Guid("4186bfa9-6304-4656-8629-f81e7f6f6ef1"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1494), null, "محمد شریفی-تهران", null, 1L, "m.sharifi-Tehran", 1L },
                    { 2L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1510), false, 2L, new Guid("749f9751-975d-4175-8bab-d318739c2318"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1513), null, "امین شریفی-فارس", null, 2L, "a.sharifi-Fars", 2L },
                    { 3L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1532), false, 1L, new Guid("032cfe80-f51a-48a7-9e69-36dd99402a0e"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1536), null, "محمد شریفی-فارس", null, 3L, "m.sharifi-Fars", 2L },
                    { 4L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1554), false, 2L, new Guid("8ae44eb8-db18-4612-9507-632626c50884"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(1559), null, "امین شریفی-تهران", null, 4L, "a.sharifi-Tehran", 1L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserPosition",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2138), false, 1L, new Guid("8a66f3c1-0121-4b08-afb4-6f529d202267"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2145), null, "محمد شریفی-مدیر مرکز", null, 1L, "m.sharifi-PharmaceuticalDeputy", 7L },
                    { 2L, new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2166), false, 2L, new Guid("c688da53-6b81-42e4-98d4-278326c5168a"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(2170), null, "امین شریفی-معاون غذایی", null, 2L, "a.sharifi-FMCGDeputy", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "CD_EndorsementId", "CD_OperandId", "CD_RequestId", "CD_ScenarioId", "CD_TagId", "CD_Value", "CreateTimeRecord", "D_UserId", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, 2L, 3L, null, 1L, 100L, "0", new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(668), null, false, new Guid("deebb1b3-cc9b-46de-af77-8be79b6e1f54"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(671), null, "سناریو ستاد,سهم شرکت,بزگتر از,0", null, 1L, "Head_Scenario,OursShare,>,0", null },
                    { 2L, null, 1L, null, 2L, 204L, "1", new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(681), null, false, new Guid("a97b9c2a-861c-4fd4-93cb-1602e0e5ae30"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(683), null, "سناریو دارویی,دارویی,مساوی,1", null, 2L, "Med_Scenario,Med,=,1", null },
                    { 3L, null, 3L, null, 2L, 100L, "0", new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(690), null, false, new Guid("f8884711-2090-4533-a04b-e05e4cb9b909"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(692), null, "سناریو دارویی,سهم شرکت,بزگتر از,0", null, 3L, "Med_Scenario,OursShare,>,0", null },
                    { 4L, null, 1L, null, 3L, 205L, "1", new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(705), null, false, new Guid("7b7e665c-af45-46aa-8868-c1fd9adee890"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(707), null, "سناریو مصرفی,مصرفی,مساوی,1", null, 4L, "FMCG_Scenario,FMCG,=,1", null },
                    { 5L, null, 3L, null, 3L, 103L, "0", new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(714), null, false, new Guid("0e94e5fa-803d-4684-9bea-d66df8bcfe0d"), new DateTime(2023, 6, 29, 11, 46, 11, 233, DateTimeKind.Local).AddTicks(716), null, "سناریو مصرفی,مبلغ,بزگتر از,0", null, 5L, "FMCG_Scenario,Price,>,0", null }
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
