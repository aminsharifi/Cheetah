using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_ERPCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3272), 1L, new Guid("eb5c18d5-22d2-44f8-8d78-9c7bc0d68304") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3278), 2L, new Guid("6a9a7c02-3dd6-4557-af9c-d69d54768db9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3280), 3L, new Guid("d11dca2b-6833-4ee9-a22e-f13e0e696ad6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3283), 4L, new Guid("6b95428a-0bc4-473b-8ade-3bcc1c96bbfc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3285), 5L, new Guid("c006a7a8-4bf6-4236-99e7-c47d393a518d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3638), 101L, new Guid("b178ad9a-6d73-4d6f-b921-67f84f5a282e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3684), 102L, new Guid("14e33cd9-60e2-43a7-9ecc-59838e13eb23") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3690), 103L, new Guid("172f45c8-6ec8-48e4-9829-aa068622f99b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3696), 104L, new Guid("0c1da910-4782-4b85-9fa0-fa3b88138fc5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3703), 105L, new Guid("158c05a8-611e-42f9-9a33-204af7b7fb1d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3709), 106L, new Guid("7c4da448-ac73-418d-b3b7-2e7a208d12f3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3714), 107L, new Guid("5e831a8f-97ea-4364-9237-e2dc40ff0ecf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3720), 108L, new Guid("4d4019ed-3255-4876-8b02-6a334dda0c44") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3726), 109L, new Guid("21800e26-da76-41b9-919e-b61ddb685e54") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3733), 112L, new Guid("e78eddf4-afb3-41fe-9d14-f84baee481da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3739), 200L, new Guid("a3736511-9622-4082-8a64-b3481eb9b94a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3744), 202L, new Guid("f1c57d60-77e2-4b94-be40-161ada78e95c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3749), 203L, new Guid("8bbb66ef-63b9-4a38-9bae-493b975b7152") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3755), 204L, new Guid("8803458a-3f79-4ff9-b35c-c6e28c793b6d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3830), 205L, new Guid("4110f831-074b-4e4b-b27e-45885fb5d3fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3847), 206L, new Guid("039161cc-07f1-419e-a55d-9d237b86dc93") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3853), 300L, new Guid("0fed3614-f266-47eb-8d1a-f17c12b7c340") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3860), 301L, new Guid("9eb4e329-7ce7-4069-ac13-f46b624e4369") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3865), 302L, new Guid("f26b3ad1-13d2-4daf-b2dc-a84e9adc731c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3871), 303L, new Guid("85d6ede6-173a-4ed0-9597-dd17d5fdebbc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3360), 1L, new Guid("af7d5e08-d6fe-42aa-86ea-b805dde08465") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3380), 1L, new Guid("7b86af53-e38f-4d69-8d2c-05963a67d880") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3383), 2L, new Guid("4751bd0e-e256-45c5-8e60-fbf45397a0d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3385), 3L, new Guid("db20de06-d640-41c4-915d-9c384785b6fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3388), 4L, new Guid("e9e7c320-fbf0-441d-acc1-5cbb76246992") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3390), 5L, new Guid("7b2e7add-0980-4bc9-b6f0-183713dbd421") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3396), 6L, new Guid("cdc7813c-6bd7-4a47-9544-d7afdeb73f82") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3616), 1L, new Guid("5065225c-89b8-4612-a4cb-77a83e1f43b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3032), 1L, new Guid("dbfaf9a3-95b9-434f-b8c8-d7e182cd5420") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3560), 100L, new Guid("4b850aa4-8725-4132-a324-40e03131af27") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3573), 101L, new Guid("5a257b82-738c-4a08-ae0e-fd29524478b2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3452), new Guid("6e86a791-2785-4985-b2d3-99a97dfd783b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3456), 201L, new Guid("0ebd4509-bb94-4557-98da-ae801ad0fab7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3459), 202L, new Guid("2d75109a-b17f-4998-9d7e-19f4575c415f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3464), 203L, new Guid("9dc7e837-c72b-4042-9ef9-35c1c0cebd1a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3467), 301L, new Guid("826dcdc2-22be-43b3-b632-6cfcf87e5a7f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3422), 1L, new Guid("bbff05a5-1446-4587-bf60-d645cefb3ac4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3424), 2L, new Guid("6e458e23-2670-428a-b08e-8acf5043598a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3427), 3L, new Guid("3e2d67da-05d5-4817-8c80-acf11b21a4db") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3429), 4L, new Guid("0075514f-c78c-4c93-8533-e45e00e8b765") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3493), 1L, new Guid("36f80c6b-c0c7-4128-8db0-ae7d83cfff94") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3536), 2L, new Guid("62d263ad-93c6-4946-803a-80e1489ecb75") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3315), 1L, new Guid("7f4142e6-30eb-4cd6-acf7-8c9bcaa4e74d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3317), 2L, new Guid("0340d26f-b5e8-4746-9f7d-47133af7dc05") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3332), 3L, new Guid("be34c596-1fc2-4353-8076-527f11ead872") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3335), 4L, new Guid("31a9b9b1-05a7-4166-aa32-8ba46c55791c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(4008), 1L, new Guid("cb00bc34-c012-4f45-b823-2fa36a69d938") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(4013), 2L, new Guid("31f2358e-441b-4e21-8f41-f5952f3839e8") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(4016), 3L, new Guid("2143c8c8-1c73-471e-b6fa-be2dd1015f4a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(4019), 4L, new Guid("8f729218-d2a7-4fd9-ab54-15a394984f61") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(4058), 5L, new Guid("ce7f5479-9b39-48df-8651-916ea41e247a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3944), 1L, new Guid("9799dc68-21fd-4d18-ab83-9c32c69c9453") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3949), 2L, new Guid("13f2ee15-a684-4450-9b34-d8ac9a399c22") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3972), 1L, new Guid("aa133a08-e31e-4d6c-b2b6-34d445188354") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3976), 2L, new Guid("0a08aa3f-1d18-4ea3-ac0f-492579ecb07b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3982), 3L, new Guid("fdde6c80-9059-48eb-b875-1774e4667513") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3985), 4L, new Guid("c6067e27-e8f3-4622-a8f9-025643eba868") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(3916), 1L, new Guid("494615fc-9ed2-413d-ac2f-060ee747870c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(4203), 1L, new Guid("2de215ce-a1c5-4bba-b361-d0007a929478") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(4206), 2L, new Guid("98bad67b-6902-4e63-acd0-3e94b7e16488") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(4158), 1L, new Guid("dc440a53-4bf3-4a91-9f5f-1e5f472d0a17") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(4130), 1L, new Guid("6eebab22-4fe4-45f5-a414-01360024e52a") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(4133), 2L, new Guid("a2128144-1776-40a6-a22c-b520968a7d3b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(4100), 1L, new Guid("670c6cfb-92d4-480f-9ac3-04f79d0e4d7b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(4107), 2L, new Guid("869342af-8a1c-47ee-a1e0-7db9c7de567d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(4177), 1L, new Guid("adf95478-d0d5-4466-830a-7cd077318f5a") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 20, 28, 303, DateTimeKind.Local).AddTicks(4180), 2L, new Guid("8ffe8ed5-c2cb-45f9-8843-3de7b8d0916e") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2214), null, new Guid("54f45a6d-8da5-4161-a718-3d9e1f8db26e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2218), null, new Guid("3e8ff3e7-cccf-423a-8572-0cf1a8dcb020") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2220), null, new Guid("c16d5e9b-10d3-4dc3-938c-d071db5de912") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2222), null, new Guid("7dc2532c-42ee-47fa-9ff0-a2c5bab88895") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2224), null, new Guid("4f977004-5371-436d-9327-23e73cbcfac6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2591), null, new Guid("91546a56-4f87-4003-8087-ff55d29d8f8e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2640), null, new Guid("e6de87f2-bd9e-4bfd-917a-35099feed129") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2646), null, new Guid("e0d5f14d-fd1a-4208-ab60-4e2770f51c45") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2652), null, new Guid("37a51bf9-c208-40ac-bda5-3baa091c139d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2658), null, new Guid("de09caea-a8cd-48d1-833a-611f30f037cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2663), null, new Guid("5fd21199-1371-400e-90ef-8e6f584d9576") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2668), null, new Guid("f4cae591-546e-469e-a6cb-55d8cd06402b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2673), null, new Guid("60109540-86de-4781-a64f-4d019015b57b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2681), null, new Guid("2c006af2-20f1-4855-b607-60d5bf74eb12") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2686), null, new Guid("7005a371-2279-4840-a315-21920cdf1610") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2767), null, new Guid("86278405-e2e9-4d87-877e-bf2d06dc52e5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2775), null, new Guid("2c6cb023-bb37-4307-b2dc-95183d65de9b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2781), null, new Guid("e81adf2f-3288-4164-b0f2-5a08c49954f3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2786), null, new Guid("dc400367-b7c1-451c-95fa-9671d8ff311d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2791), null, new Guid("5cf1a1ca-eeec-41d4-851e-d450433cde23") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2800), null, new Guid("ba4d2e8a-f9b9-4889-8a49-19f53493c9aa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2808), null, new Guid("be160f68-e9c4-47b4-918b-648c40307c69") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2812), null, new Guid("30651f28-c713-40f5-8a77-fa05ff8a912e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2817), null, new Guid("aecf1c3b-0a6d-477e-aeee-eed0d139340c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2823), null, new Guid("20fa206d-daac-4384-91ae-dcc6755d16b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2305), null, new Guid("18571eec-27d8-4292-b587-287c17ab5802") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2323), null, new Guid("068be901-acf8-47e5-9fc5-8b0bb3fc7715") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2326), null, new Guid("f7c1d87a-826f-43d8-9c7d-9d4526511373") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2329), null, new Guid("e02ed417-9126-4a97-86ae-29aea479abe3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2331), null, new Guid("3e4e2057-fda6-47e1-bd05-65f8869c5a3b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2340), null, new Guid("5bdd2aac-032d-41b5-8113-b8d36cf3263f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2342), null, new Guid("31255e35-0c96-47b7-81db-f8df83288022") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2566), null, new Guid("924f7f26-6ea6-4002-9a05-a9286a052dd8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(1915), null, new Guid("856e3d5c-c0ee-45b1-95ce-6e8faedc6d43") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2521), null, new Guid("616c71c1-9b6d-449c-b487-647f5b043fb4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2530), null, new Guid("419c3262-462b-4c2a-81d2-14bf076b76e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2403), new Guid("f66e94b6-87bf-4878-9953-d2950d6cf0ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2409), null, new Guid("1dc5ecfa-aa9b-4575-88dd-af7138bf12fc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2458), null, new Guid("20e23279-6caa-4461-8919-363396a11988") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2461), null, new Guid("af8490ca-f879-4ed3-ae58-efa0024711b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2463), null, new Guid("8ca0e148-722f-4d58-a8e1-005a22e0fcc0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2373), null, new Guid("3a8e8acd-f7ea-4999-8b7b-4e0f4e16a840") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2375), null, new Guid("3f82d8af-cde7-4fd5-b1b4-8d3566f1d67a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2378), null, new Guid("b64069fd-4117-4c06-8bc5-4a9a3cd16d59") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2380), null, new Guid("c87a1a43-ebcc-445a-9bf8-d421f0807d37") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2492), null, new Guid("8e06e50e-166e-4303-b8e6-cd7c7440c048") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2496), null, new Guid("0082e474-a413-4e0c-b0db-6d8e8467b8cd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2259), null, new Guid("ca879edb-9720-4e81-a3d2-4e77f6871f16") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2272), null, new Guid("4b7adc66-b186-42a7-bee6-07adb5285244") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2275), null, new Guid("c2fa4b64-bfdf-4f03-9608-6695ed1789c8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2277), null, new Guid("3f443e32-6b99-4f1c-bc80-6e8787f9cf52") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3006), null, new Guid("3d1e22cf-f58c-4303-8101-5f5815e4753d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3013), null, new Guid("ba78e33c-b7c3-4591-bc92-77e32d303e64") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3016), null, new Guid("c276e0c8-53d5-44e2-8f12-c424dec011f7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3019), null, new Guid("e977ec66-627c-4b89-b8b4-a9222814f001") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3021), null, new Guid("68e224fc-e14d-4fdd-b5d9-4d63e1928726") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2897), null, new Guid("37010a00-26d3-48a7-ab7f-0fb861eeb6eb") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2901), null, new Guid("f50f8fb7-a5f6-419d-bc25-08d06bdbe275") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2929), null, new Guid("3a76c8ad-0c57-4177-afbe-cd153bc9d98b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2937), null, new Guid("c5681637-42a6-4501-a50f-dbceabff7fb9") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2939), null, new Guid("6aeb8245-a5f0-492b-af09-2847e2ecda6b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2941), null, new Guid("8727c7dc-0b62-4b97-ac4f-756cbbe3947c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(2871), null, new Guid("54496abf-2c18-4780-bda8-4e42f1d96478") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3170), null, new Guid("8de1eecd-5163-4184-b076-2cf82e7561cc") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3176), null, new Guid("63f7e25b-1ba3-499a-9f07-6ee598a04176") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3126), null, new Guid("e1de4067-cdbd-4dec-b58c-84afa4739c79") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3100), null, new Guid("2369579c-b54e-4cab-b244-ea4537b3e851") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3103), null, new Guid("b3ae78b2-b921-4328-ac70-5b657bb3039f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3076), null, new Guid("9f83e371-1996-43f3-8cce-2cc11f3447cb") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3080), null, new Guid("5256871e-569d-40cb-b919-a3cf821e5375") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3146), null, new Guid("49340d70-d265-450b-9b06-d3a48ed9766d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "ERPCode", "GuidRecord" },
                values: new object[] { new DateTime(2023, 10, 8, 11, 55, 17, 848, DateTimeKind.Local).AddTicks(3149), null, new Guid("0a1d9b02-91de-4bfa-bbbb-132ca188ca4b") });
        }
    }
}
