using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess_Npgsql.Migrations
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
                    { 101L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1336), false, false, new Guid("99329262-9653-4b85-9ab5-ddde966609fc"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1342), null, "نوع تگ‌ها(Dimentions)", null, 101L, "D_TagType", null },
                    { 102L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1472), false, false, new Guid("db1f0af1-91d6-41bf-a03a-f8dff4284b6a"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1478), null, "موقعیت‌ها(Dimentions)", null, 102L, "D_Location", null },
                    { 103L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1500), false, false, new Guid("b28dcc45-4bc0-4cf1-ab98-f3730bd406f0"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1505), null, "عملگرها(Dimentions)", null, 103L, "D_Operand", null },
                    { 104L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1522), false, false, new Guid("04f4794b-f199-41dc-a74f-90fef1189bab"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1526), null, "تگ‌ها(Dimentions)", null, 104L, "D_Tag", null },
                    { 105L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1542), true, false, new Guid("453e623f-51e5-46a6-8705-987b6035660f"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1546), null, "سمت‌ها(Dimentions)", null, 105L, "D_Position", null },
                    { 106L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1562), false, false, new Guid("e289b6cb-4e0e-4cef-bd7a-b3979781711f"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1566), null, "وضعیت فرآیندها(Dimentions)", null, 106L, "D_ProcessState", null },
                    { 107L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1632), true, false, new Guid("f65e96e9-68de-4543-a7a1-b6e04c7c31e3"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1636), null, "فرآیند‌ها(Dimentions)", null, 107L, "D_Process", null },
                    { 108L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1652), true, false, new Guid("6f298172-7e99-4054-b954-be61fedd9df5"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1656), null, "نقش‌ها(Dimentions)", null, 108L, "D_Role", null },
                    { 109L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1669), true, false, new Guid("a5cadce6-32ac-4518-b903-573a16e895bc"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1673), null, "کاربران(Dimentions)", null, 109L, "D_User", null },
                    { 112L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1695), false, false, new Guid("b21b003b-3c3e-4596-a906-dc565b93a969"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1700), null, "اطلاعات کاربرها(Facts)", null, 112L, "D_UserInformation", null },
                    { 200L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1800), false, false, new Guid("095befb1-c0f2-44a5-bab7-dcc284126985"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1809), null, "تمام تاییدها(Facts)", null, 200L, "F_Assignment", null },
                    { 201L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1829), false, false, new Guid("945da781-1da6-4aaa-9fa2-c400c3cd81bd"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1833), null, "تاییدهای جاری(Facts)", null, 201L, "F_Review", null },
                    { 202L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1849), false, false, new Guid("17ccb8b1-e4f9-4cff-8e7c-4f83701ecbf0"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1853), null, "ضمیمه‌ها(Facts)", null, 202L, "F_Attachment", null },
                    { 203L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1868), false, false, new Guid("02a8b98e-a48a-4d4e-8d3c-4136e6c4926e"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1873), null, "لیست تخصیص‌ها(Facts)", null, 203L, "F_Endorsement", null },
                    { 204L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1899), false, false, new Guid("257d48ad-2ddc-44ac-adcc-e03fd0ae388c"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1903), null, "لیست شرط‌ها(Facts)", null, 204L, "F_Condition", null },
                    { 205L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1927), true, false, new Guid("48b6c761-821d-40f3-8783-fa8df691df0f"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1932), null, "اطلاعات درخواست‌ها(Facts)", null, 205L, "F_Request", null },
                    { 206L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1949), true, false, new Guid("a1adc763-e716-4cd4-a003-9015a894fbbc"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1953), null, "سناریوها(Facts)", null, 206L, "F_Scenario", null },
                    { 300L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1968), false, false, new Guid("02765909-8faa-47e9-becf-2a51b77cfe40"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1972), null, "نقش-سمت(Links)", null, 300L, "L_RolePosition", null },
                    { 301L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1988), false, false, new Guid("235f7b01-dc6d-43d2-b415-fa1050618e76"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1993), null, "فرآیند-سناریو(Links)", null, 301L, "L_ProcessScenario", null },
                    { 302L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2007), false, false, new Guid("2b42c589-ff06-47e4-ae7b-61e172601302"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2011), null, "کاربر-موقعیت(Links)", null, 302L, "L_UserLocation", null },
                    { 303L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2026), false, false, new Guid("b328cc60-a43a-4f7a-85d6-37997b0113c3"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2030), null, "کاربر-سمت(Links)", null, 303L, "L_UserPosition", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Location",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5506), false, new Guid("a46915f9-03d9-464a-8149-85ae4b723b19"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5549), null, "تهران", null, 1L, "Tehran", null },
                    { 2L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5561), false, new Guid("8bc7ad04-f440-4846-b972-e4941a071ee1"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5564), null, "فارس", null, 2L, "Fars", null },
                    { 3L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5572), false, new Guid("b80b6bb3-e20d-4744-8b2f-ae3baf17b037"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5577), null, "اصفهان", null, 3L, "Esfahan", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5645), false, new Guid("8945e79f-258c-4f3a-875e-0127307246c6"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5651), null, "مساوی", null, 1L, "=", null },
                    { 2L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5661), false, new Guid("28e16d72-9203-4dac-a906-c196fa1ec2c3"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5665), null, "مخالف", null, 2L, "!=", null },
                    { 3L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5674), false, new Guid("0377fb2a-6081-4a37-8bcd-7c7c1d2180c1"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5678), null, "بزگتر از", null, 3L, ">", null },
                    { 4L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5687), false, new Guid("107ee155-6bfa-4c47-baac-c549e667286f"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5691), null, "بزرگتر و مساوی", null, 4L, ">=", null },
                    { 5L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5701), false, new Guid("c9c7a502-28f2-4f1f-8a7c-5a0dc28384f4"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5713), null, " کوچکتر از", null, 5L, "<", null },
                    { 6L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5795), false, new Guid("37376697-3e29-4f85-b2ca-c227cb35a29b"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5800), null, "کوچکتر و مساوی", null, 6L, "<=", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1027), false, new Guid("68c87c21-0b08-4e8b-87a5-7b7b36e257da"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1033), null, "معاون دارویی", null, 1L, "PharmaceuticalDeputy", null },
                    { 2L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1187), false, new Guid("0a954d4e-baa5-4872-8174-178f3d607a93"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1193), null, "معاون غذایی", null, 2L, "FMCGDeputy", null },
                    { 3L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1204), false, new Guid("189153f5-4682-4963-977d-a6e6239b4f86"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1208), null, "کارشناس ارشد بازرگانی", null, 3L, "BusinessSeniorSpecialist", null },
                    { 4L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1216), false, new Guid("6050db4b-68aa-4950-bd85-70fad8ee6503"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1219), null, "کارشناس بازرگانی", null, 4L, "BusinessSpecialist", null },
                    { 5L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1228), false, new Guid("3238326a-b9e2-424c-8a42-6fca7feb78dd"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1231), null, "کارشناس ارشد فروش", null, 5L, "SalesSeniorSpecialist", null },
                    { 6L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1245), false, new Guid("8b6aa025-2109-4c03-b87b-ac01c48c91fe"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1249), null, "کارشناس فروش", null, 6L, "SalesSpecialist", null },
                    { 7L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1258), false, new Guid("1b1453d8-eebe-47f1-834f-9c5c18f6d96c"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(1261), null, "مدیر مرکز توزیع", null, 7L, "DistributionCenterManager", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Process",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PC_ERP", "PC_RemoveRequestorApproval", "PC_ShowSupport", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(4486), false, new Guid("5a53539a-7a1a-4208-8bfd-446d3acb5d8d"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(4591), true, true, true, null, "تعریف/اصلاح مشتری", null, 1L, "CustomerDefinition", null },
                    { 2L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(4664), false, new Guid("6670a473-9550-4ec4-b3d1-e28bb8462faa"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(4668), true, true, true, null, "مجوزهای موردی", null, 2L, "PolicyCenter", null },
                    { 3L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(4694), false, new Guid("76b3ed1b-3da3-40d8-bdee-af9b71ee5d34"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(4727), true, true, true, null, "اعتباردهی مالی مشتری", null, 3L, "CustomerCredit", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_ProcessState",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5356), false, new Guid("39a7f2e7-72c2-4ffa-9f5c-cb3856e0b622"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5378), null, "در دست بررسی", null, 1L, "Ongoing", null },
                    { 2L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5394), false, new Guid("740187ac-586a-49fe-a17b-3775a8962ea7"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5398), null, "منتظر بازنگری", null, 2L, "Editing", null },
                    { 3L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5423), false, new Guid("003cdff6-486d-4d51-b540-62efc56589fa"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5427), null, "کامل شده", null, 3L, "Completed", null },
                    { 4L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5436), false, new Guid("3aa98e3f-6209-46d9-8b82-4a3c69321977"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5440), null, "ابطال شده", null, 4L, "Aborted", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "ROL_Independent" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(767), false, new Guid("1de2eafc-e36e-47f4-93a7-a2b628e70fc1"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(818), null, "معاونت دارویی", null, 1L, "PharmaceuticalDeputy", null, true },
                    { 2L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(855), false, new Guid("80c9897b-24db-499c-b2cc-2dd17afb6f58"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(859), null, "معاونت غذایی", null, 2L, "FMCGDeputy", null, true },
                    { 3L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(883), false, new Guid("e9df4739-b1b1-4410-a1ec-a33372f7e71c"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(888), null, "کارشناس بازرگانی", null, 3L, "BusinessSpecialist", null, true },
                    { 4L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(898), false, new Guid("412df39f-23d5-4f6c-ab53-d8c92d482758"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(902), null, "کارشناس فروش", null, 4L, "SalesSpecialist", null, true },
                    { 5L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(909), false, new Guid("2e302fd5-896d-41e1-831e-248de2b87c48"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(912), null, "مدیریت مرکز توزیع", null, 5L, "DistributionCenterManager", null, false }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagType",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5895), false, new Guid("d31213b0-d159-4e55-9628-251ec9baadb0"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5902), null, "عددی", null, 1L, "Numberic", null },
                    { 2L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5913), false, new Guid("32f1650c-4eb5-4405-b818-78f6b9e5aff6"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5917), null, "دودویی", null, 2L, "Boolean", null },
                    { 3L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5933), false, new Guid("35e59b9f-01e8-4b1f-8cc6-4ee69152a5a0"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(5938), null, "تاریخ", null, 3L, "Date", null },
                    { 4L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6054), false, new Guid("94d4d208-3dc3-4378-bd34-551507cda328"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6060), null, "حروف", null, 4L, "String", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "User_CreatedCasesSkipAssigRules", "User_DelegateEnabled", "User_DelegateId", "User_Domain", "User_EnabledForAssignation", "User_IDPersonel", "User_LDAPDescription", "User_UserInformationId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6764), false, new Guid("d5f49d6b-5eed-42cb-ae30-df6cde4c9042"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6792), null, "محمد شریفی", null, 1L, "m.sharifi", null, null, null, null, null, null, null, null, null },
                    { 2L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6816), false, new Guid("71895ac9-ec05-4aec-8a58-16ce08ec0ab6"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6834), null, "امین شریفی", null, 2L, "a.sharifi", null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Scenario",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2157), false, new Guid("1bf489d7-a52a-4df4-8dc3-078a7b30c650"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2165), null, "سناریو ستاد", null, 1L, "Head_Scenario3", null },
                    { 2L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2183), false, new Guid("a1c9c18b-58d3-435e-a2d9-c66c36dee889"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2188), null, "سناریو دارویی", null, 2L, "Med_Scenario", null },
                    { 3L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2196), false, new Guid("8b98977c-a7ad-414c-b520-7e25601cf280"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2200), null, "سناریو مصرفی", null, 3L, "FMCG_Scenario", null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id", "TG_TagTypeId" },
                values: new object[,]
                {
                    { 100L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6123), false, new Guid("e7e8a05a-a87c-437d-97bb-eaefbb39b386"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6129), "عددی", "سهم شرکت", null, 100L, "OursShare", null, 1L },
                    { 101L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6138), false, new Guid("d743147f-1225-4b37-b2a0-c0a0236bb7f1"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6142), "عددی", "سهم دیگران", null, 101L, "OthersShare", null, 1L },
                    { 103L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6150), false, new Guid("49300346-f629-4826-abaf-a6398ee8fdef"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6153), "عددی", "مبلغ", null, 103L, "Price", null, 1L },
                    { 200L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6161), false, new Guid("3426cc52-76fb-4a74-80fb-ad014142cf18"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6165), "دودویی", "مخدر/ یخچالی", null, 200L, "Refrigerator", null, 2L },
                    { 201L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6172), false, new Guid("a04f27f4-344a-446e-9840-0bbc7abae244"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6177), "پارامتریک", "تایید", null, 201L, "Approve", null, 2L },
                    { 202L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6189), false, new Guid("989c4a7c-068e-4c07-9608-89b82d6e305f"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6194), "پارامتریک", "عدم تایید", null, 202L, "Reject", null, 2L },
                    { 203L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6209), false, new Guid("b63a7efb-f081-4c67-a254-f6542d7c52bd"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6213), "پارامتریک", "بازنگری", null, 203L, "Revise", null, 2L },
                    { 204L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6220), false, new Guid("b6ed7004-bbe6-496b-816b-e289ab9ff246"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6223), "پارامتریک", "دارویی", null, 204L, "Med", null, 2L },
                    { 205L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6232), false, new Guid("1997f084-6be7-4ccf-b0d6-02ba58cd3c3e"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6237), "پارامتریک", "مصرفی", null, 205L, "FMCG", null, 2L },
                    { 206L, new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6244), false, new Guid("5a27b90a-abab-45a5-ba49-cec30251febf"), new DateTime(2023, 6, 29, 11, 47, 3, 219, DateTimeKind.Local).AddTicks(6248), "پارامتریک", "کل", null, 206L, "General", null, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Endorsement",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "ED_RoleId", "ED_ScenarioId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2491), false, 5L, 3L, new Guid("230db678-414a-4e75-9c22-ee18bee33561"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2498), null, "سناریو سه,مدیریت مرکز توزیع", null, 1L, "Med_Scenario,DistributionCenterManager", null },
                    { 2L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2519), false, 2L, 3L, new Guid("3b1ea165-2135-4557-8552-968c1bab3f02"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2524), null, "سناریو سه,معاونت غذایی", null, 2L, "Strategy3,FMCGDeputy", null },
                    { 3L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2534), false, 1L, 2L, new Guid("00d375f1-3e7b-4d23-99df-e00c01f0d5ca"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2538), null, "سناریو دو,معاونت دارویی", null, 3L, "Strategy2,PharmaceuticalDeputy", null },
                    { 4L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2548), false, 2L, 1L, new Guid("cb6dc7a8-500d-4597-8a6c-d5de5809f511"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2552), null, "سناریو دارویی,معاونت دارویی", null, 4L, "Med_Scenario,PharmaceuticalDeputy", null }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_ProcessScenario",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2898), false, 1L, new Guid("d27c492b-0190-460c-9063-cbfa67922b18"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2905), null, "تعریف/اصلاح مشتری-سناریو سه", null, 1L, "CustomerDefinition-Strategy3", 3L },
                    { 2L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2917), false, 1L, new Guid("32de67a9-4550-4fb8-aaee-71d6c1fa54f7"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2920), null, "تعریف/اصلاح مشتری-سناریو یک", null, 2L, "CustomerDefinition-Strategy1", 1L },
                    { 3L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2933), false, 2L, new Guid("8b37fe2c-4f2b-497f-ad72-dd0ef4a2096b"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2937), null, "مجوزهای موردی-سناریو یک", null, 3L, "PolicyCenter-Strategy1", 1L },
                    { 4L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2946), false, 1L, new Guid("4a961cfe-370c-4163-8f0a-7d5b7966aba6"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2951), null, "تعریف/اصلاح مشتری-سناریو دو", null, 4L, "PolicyCenter-Strategy2", 2L },
                    { 5L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2960), false, 2L, new Guid("8746d6a0-1f4a-4186-900c-a49c23f79d40"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2964), null, "مجوزهای موردی-سناریو دو", null, 5L, "CustomerDefinition-Strategy2", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_RolePosition",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2718), false, 1L, new Guid("a9a2d6fd-c051-4334-bacc-df0419ae1847"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2723), null, "معاونت دارویی-معاون دارویی", null, 1L, "PharmaceuticalDeputy-PharmaceuticalDeputy", 1L },
                    { 2L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2740), false, 2L, new Guid("99dc0b3a-c1e9-4088-8bf7-a5147674bfa2"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2745), null, "معاونت غذایی-معاون غذایی", null, 2L, "FMCGDeputy-FMCGDeputy", 2L },
                    { 3L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2754), false, 3L, new Guid("78126fa0-8fb8-4e9d-8953-f52d47be80f8"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2759), null, "کارشناس بازرگانی-کارشناس ارشد بازرگانی", null, 3L, "BusinessSpecialist-BusinessSeniorSpecialist", 3L },
                    { 4L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2767), false, 3L, new Guid("5dcffd41-4ad2-4756-b3cd-6deea850143c"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2770), null, "کارشناس بازرگانی-کارشناس بازرگانی", null, 4L, "BusinessSpecialist-BusinessSpecialist", 4L },
                    { 5L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2779), false, 4L, new Guid("6e49751f-cdfe-4587-b1a8-daa7d0d37e3a"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2783), null, "کارشناس فروش-کارشناس ارشد فروش", null, 5L, "SalesSpecialist-SalesSeniorSpecialist", 5L },
                    { 6L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2791), false, 4L, new Guid("e86bb222-8b70-4357-98c9-6bac8073e54d"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2796), null, "کارشناس فروش-کارشناس فروش", null, 6L, "SalesSpecialist-SalesSpecialist", 6L },
                    { 7L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2805), false, 5L, new Guid("de7556af-fb46-4c9e-b158-bbfaa005a603"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2809), null, "مدیریت مرکز توزیع-مدیر مرکز توزیع", null, 7L, "DistributionCenterManager-DistributionCenterManager", 7L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserLocation",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2621), false, 1L, new Guid("b02a5a38-ccfc-4381-b0d9-72fcc6721528"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2628), null, "محمد شریفی-تهران", null, 1L, "m.sharifi-Tehran", 1L },
                    { 2L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2639), false, 2L, new Guid("5ec3c69a-a423-49fb-bbb9-00a8563bb318"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2642), null, "امین شریفی-فارس", null, 2L, "a.sharifi-Fars", 2L },
                    { 3L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2651), false, 1L, new Guid("ebef591e-1158-4c90-9d29-ab76399f1013"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2654), null, "محمد شریفی-فارس", null, 3L, "m.sharifi-Fars", 2L },
                    { 4L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2663), false, 2L, new Guid("989efee8-fb62-4a33-8996-a98c66e8c3d4"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2666), null, "امین شریفی-تهران", null, 4L, "a.sharifi-Tehran", 1L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserPosition",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(3414), false, 1L, new Guid("331fd0c1-288e-4682-934b-ec42eabb4918"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(3442), null, "محمد شریفی-مدیر مرکز", null, 1L, "m.sharifi-PharmaceuticalDeputy", 7L },
                    { 2L, new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(3464), false, 2L, new Guid("77f61e79-66e8-4d2f-9ed3-7691a04d99e6"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(3469), null, "امین شریفی-معاون غذایی", null, 2L, "a.sharifi-FMCGDeputy", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "CD_EndorsementId", "CD_OperandId", "CD_RequestId", "CD_ScenarioId", "CD_TagId", "CD_Value", "CreateTimeRecord", "D_UserId", "DsblRecord", "GuidRecord", "LastUpdatedRecord", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[,]
                {
                    { 1L, 2L, 3L, null, 1L, 100L, "0", new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2333), null, false, new Guid("4bff66df-5609-4222-812c-a6bd2580e0ae"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2341), null, "سناریو ستاد,سهم شرکت,بزگتر از,0", null, 1L, "Head_Scenario,OursShare,>,0", null },
                    { 2L, null, 1L, null, 2L, 204L, "1", new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2356), null, false, new Guid("586dc1c9-9043-4d26-9d8b-8be657e2a747"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2360), null, "سناریو دارویی,دارویی,مساوی,1", null, 2L, "Med_Scenario,Med,=,1", null },
                    { 3L, null, 3L, null, 2L, 100L, "0", new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2372), null, false, new Guid("8c83b00a-b341-4c94-9d65-35e4db46dd37"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2376), null, "سناریو دارویی,سهم شرکت,بزگتر از,0", null, 3L, "Med_Scenario,OursShare,>,0", null },
                    { 4L, null, 1L, null, 3L, 205L, "1", new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2385), null, false, new Guid("b2606619-0475-478d-8859-eb9ae3b6e843"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2389), null, "سناریو مصرفی,مصرفی,مساوی,1", null, 4L, "FMCG_Scenario,FMCG,=,1", null },
                    { 5L, null, 3L, null, 3L, 103L, "0", new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2400), null, false, new Guid("d9c64c57-83fe-41b9-8a12-a3b5b0587124"), new DateTime(2023, 6, 29, 11, 47, 3, 220, DateTimeKind.Local).AddTicks(2403), null, "سناریو مصرفی,مبلغ,بزگتر از,0", null, 5L, "FMCG_Scenario,Price,>,0", null }
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
