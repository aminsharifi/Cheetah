using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_Constraint_Case_Aggregate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CaseId1",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "WorkItemStateId1",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CaseStateId1",
                schema: "Facts",
                table: "F_Case",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(307), new TimeSpan(0, 3, 30, 0, 0)), new Guid("99e7d0fb-792c-4d07-b47e-42853186cc3a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(312), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1fa24d4d-60a7-4918-bdd6-73e29409ae30") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(315), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d51c0471-f765-4c65-8ab8-c88ed3c74d3a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(317), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2d3a806f-fcb7-41cb-b245-82c85dc22a44") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(319), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a95ef306-514a-4841-88b5-849906b1f7ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(322), new TimeSpan(0, 3, 30, 0, 0)), new Guid("12b6aaf4-8461-4b6e-9201-6c70a4fa73c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 849, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 3, 30, 0, 0)), new Guid("55a21e02-d0b1-44d3-9bcb-babdd7f23f39") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2731), new TimeSpan(0, 3, 30, 0, 0)), new Guid("576224ac-e112-4761-9277-7d4b00165b91") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2763), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9bba22a3-daea-454b-be94-29f5d66cd33e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2769), new TimeSpan(0, 3, 30, 0, 0)), new Guid("47124546-a7ed-43ec-970d-4e0879349c9d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2775), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a70ec186-837e-4e00-8eb0-49d01492d617") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2780), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b1731b94-a494-4cc3-a1ce-f4eacc212d49") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 3, 30, 0, 0)), new Guid("765b261b-4d2a-4dce-bfd5-c5171f43dfd4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2803), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a05974aa-2453-4abc-877e-d3ab7160cb5d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2850), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3ba705fe-5410-4edc-b595-db3c2b65897a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2855), new TimeSpan(0, 3, 30, 0, 0)), new Guid("27d96b51-110b-4301-9fc6-71c65189ce47") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2862), new TimeSpan(0, 3, 30, 0, 0)), new Guid("81dcf5f6-18c6-4483-931b-2223024926b0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2867), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bf378260-dca1-461c-8b8c-ccbf81542130") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2871), new TimeSpan(0, 3, 30, 0, 0)), new Guid("44009a17-4d20-4f4e-a0ab-3e02f1eea81c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 850, DateTimeKind.Unspecified).AddTicks(2875), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8b364bdd-3fea-43f7-b598-c150614eeb1d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(5936), new TimeSpan(0, 3, 30, 0, 0)), new Guid("943282b0-c0d9-4b53-af2b-730805de5328") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(5952), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6fa9a516-5bcc-4655-bc01-d71e23d26918") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(5955), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2983cbf1-2f66-48bc-b256-b36c36432815") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(5987), new TimeSpan(0, 3, 30, 0, 0)), new Guid("af4f4c77-acf3-4570-b527-51e4d409a1ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(5990), new TimeSpan(0, 3, 30, 0, 0)), new Guid("564b88c8-100a-448b-b342-6fd746919b7a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(5993), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f7d978e0-fb93-4217-ad4e-14ebdbb68e70") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 845, DateTimeKind.Unspecified).AddTicks(9257), new TimeSpan(0, 3, 30, 0, 0)), new Guid("67efd6ea-defe-4b3b-b805-aa0b60bb631b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 846, DateTimeKind.Unspecified).AddTicks(9655), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a75389d4-c66c-4611-b01c-434d0c74984d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(2049), new TimeSpan(0, 3, 30, 0, 0)), new Guid("834aaea0-80a8-4303-9cb6-f466c897c9f5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(2053), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a671d15-556a-4e48-975b-0a275f05b949") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(2056), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fd99c6e7-ff95-4f0b-921b-af4593f9d4f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(2059), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f1c66125-b1ac-4635-b115-081886c1c2e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(2062), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ec3cca46-c1af-48ba-82a4-fc1defd2d819") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(2065), new TimeSpan(0, 3, 30, 0, 0)), new Guid("84dd2abc-13b2-4749-b1c8-62df59ab566b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(1923), new TimeSpan(0, 3, 30, 0, 0)), new Guid("82ec57ae-4506-46de-a5c7-3980f1910b47") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(1934), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0cf82eba-be97-470f-98e3-0968aab23abb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(895), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f1d44ffa-3c4e-4373-b383-ba960d19996c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(906), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5b656430-8e46-4367-9e0a-50adfc4c45bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(909), new TimeSpan(0, 3, 30, 0, 0)), new Guid("28b728f4-5d96-43a2-884f-7ed109fc5cb4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(911), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a23f9574-9c0c-46bf-9b9f-53c8d66c909c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(4429), new TimeSpan(0, 3, 30, 0, 0)), new Guid("85d1980c-c9b2-43e5-a823-6449f89dac0e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(4456), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6b43d4b5-a851-4d23-88c6-e60b1b78ed3f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(1623), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b99c5449-49ff-4798-ad5d-0720cbb7db75") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(1632), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8966aa45-3156-4a4c-a172-d62ae9fa9514") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(1635), new TimeSpan(0, 3, 30, 0, 0)), new Guid("683eede4-393d-4db0-a52a-c5eda238e76e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 848, DateTimeKind.Unspecified).AddTicks(1637), new TimeSpan(0, 3, 30, 0, 0)), new Guid("06caa1c0-24b8-400c-bfef-a7cacaef115c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 846, DateTimeKind.Unspecified).AddTicks(6352), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eb376c06-e931-4d0b-bad9-26937c28bf51") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(6327), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b2b7d5ca-070b-4265-a942-bd1a22e11a23") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(6332), new TimeSpan(0, 3, 30, 0, 0)), new Guid("70fc33f2-f3de-434b-a32d-3a2988013114") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(6336), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bd840bf4-fb52-4e1f-a1f5-6b21dcc5c30a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 846, DateTimeKind.Unspecified).AddTicks(775), new TimeSpan(0, 3, 30, 0, 0)), new Guid("344606d8-9def-405f-860d-215cd9c7ffcc") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(8494), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0ae737d4-ecf9-4af8-8714-84ffd10e9376") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 847, DateTimeKind.Unspecified).AddTicks(8700), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e26a4368-013d-4396-a102-849c02cc39de") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 12, 41, 844, DateTimeKind.Unspecified).AddTicks(3526), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6530b630-9cd2-484a-94c6-20ebe987dee6") });

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_CaseId1",
                schema: "Facts",
                table: "F_WorkItem",
                column: "CaseId1");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_TaskId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_UserId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_WorkItemStateId1",
                schema: "Facts",
                table: "F_WorkItem",
                column: "WorkItemStateId1");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_CaseStateId1",
                schema: "Facts",
                table: "F_Case",
                column: "CaseStateId1");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_CreatorId",
                schema: "Facts",
                table: "F_Case",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_ProcessId",
                schema: "Facts",
                table: "F_Case",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_RequestorId",
                schema: "Facts",
                table: "F_Case",
                column: "RequestorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_SelectedScenarioId",
                schema: "Facts",
                table: "F_Case",
                column: "SelectedScenarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_CaseState_CaseStateId1",
                schema: "Facts",
                table: "F_Case",
                column: "CaseStateId1",
                principalSchema: "Dimentions",
                principalTable: "D_CaseState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_Process_ProcessId",
                schema: "Facts",
                table: "F_Case",
                column: "ProcessId",
                principalSchema: "Dimentions",
                principalTable: "D_Process",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_User_CreatorId",
                schema: "Facts",
                table: "F_Case",
                column: "CreatorId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_D_User_RequestorId",
                schema: "Facts",
                table: "F_Case",
                column: "RequestorId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_F_Scenario_SelectedScenarioId",
                schema: "Facts",
                table: "F_Case",
                column: "SelectedScenarioId",
                principalSchema: "Facts",
                principalTable: "F_Scenario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_D_User_UserId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "UserId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_D_WorkItemState_WorkItemStateId1",
                schema: "Facts",
                table: "F_WorkItem",
                column: "WorkItemStateId1",
                principalSchema: "Dimentions",
                principalTable: "D_WorkItemState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_F_Case_CaseId1",
                schema: "Facts",
                table: "F_WorkItem",
                column: "CaseId1",
                principalSchema: "Facts",
                principalTable: "F_Case",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_F_Task_TaskId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "TaskId",
                principalSchema: "Facts",
                principalTable: "F_Task",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_CaseState_CaseStateId1",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_Process_ProcessId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_User_CreatorId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_User_RequestorId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_F_Scenario_SelectedScenarioId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_D_User_UserId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_D_WorkItemState_WorkItemStateId1",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_F_Case_CaseId1",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_F_Task_TaskId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropIndex(
                name: "IX_F_WorkItem_CaseId1",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropIndex(
                name: "IX_F_WorkItem_TaskId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropIndex(
                name: "IX_F_WorkItem_UserId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropIndex(
                name: "IX_F_WorkItem_WorkItemStateId1",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropIndex(
                name: "IX_F_Case_CaseStateId1",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropIndex(
                name: "IX_F_Case_CreatorId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropIndex(
                name: "IX_F_Case_ProcessId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropIndex(
                name: "IX_F_Case_RequestorId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropIndex(
                name: "IX_F_Case_SelectedScenarioId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropColumn(
                name: "CaseId1",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropColumn(
                name: "WorkItemStateId1",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropColumn(
                name: "CaseStateId1",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(3949), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9834fc29-00ca-41e4-8825-39535727b74c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(3965), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1f295e54-708b-41c5-b5f9-ac6e6116892e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(3968), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3137a024-ccd9-4189-894a-330a1b5096f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(3970), new TimeSpan(0, 3, 30, 0, 0)), new Guid("47ca22d5-3014-43de-b106-16ba9463d3a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(3973), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f72b37e3-378b-45eb-955d-e137ed7d7f6a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(3975), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6d66418f-c168-4aeb-a639-de6af357fa99") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 438, DateTimeKind.Unspecified).AddTicks(6235), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1f969a4a-3246-4692-96bb-0211e5dbb41f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6829), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1eb79c97-b2f5-4c9c-9a5a-a5954d42e26b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6856), new TimeSpan(0, 3, 30, 0, 0)), new Guid("26834f8e-b80c-4e0a-9d2e-5c5d256c918c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6862), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd206cc2-3a2f-4968-bb77-eda27ddeea6c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6868), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9404f290-9beb-4ebe-afe2-78f431223258") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6873), new TimeSpan(0, 3, 30, 0, 0)), new Guid("58952886-0463-46b4-ba8d-b07c526d0123") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6887), new TimeSpan(0, 3, 30, 0, 0)), new Guid("13c0d38f-66a5-4141-9db4-1723708fe683") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 3, 30, 0, 0)), new Guid("17a6da1b-c128-4a01-95a0-8a97e1af2e20") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6907), new TimeSpan(0, 3, 30, 0, 0)), new Guid("06786388-35c8-4b8a-954e-9debe9085bdf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6911), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9ecb348d-c19b-450c-951d-45fda8de0148") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6915), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b01ea2d0-81d6-43ff-8fb0-6421a811cfc9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f00f0922-e7f1-422d-bbe6-aa45021f704a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a1758675-6d84-4e71-9773-5203492fad32") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 439, DateTimeKind.Unspecified).AddTicks(6975), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f4cdb446-82bf-4f35-ad1a-a20cfff2d9ea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9550), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5994e635-d5d1-4c62-aa8b-ac4f3575776f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9561), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c5cf9ebf-6237-46db-9e2b-37feee0220f5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9564), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d136dae8-26ec-48b3-8016-2646aaaac6fb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9566), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5bb2960b-723d-4e18-a184-21089ca053c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9572), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a6762072-3e79-4d50-b21a-63c20baa71bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9574), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e66268c6-77b2-448b-8aad-a8f569c11d45") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 435, DateTimeKind.Unspecified).AddTicks(3047), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2cee06d2-e81a-4547-93b0-dc7b5a3aaab8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(3426), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a9c3ec5-cefe-452b-8884-4e6b546e9166") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(5743), new TimeSpan(0, 3, 30, 0, 0)), new Guid("95e14b5b-9bb3-45ca-860f-25fe52a3326e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(5748), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fe5c147d-3f8f-410a-bbf6-3fa179f252e7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(5754), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c7171374-b8d5-4765-9c0f-260bbfd1f82e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(5758), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ed6a4415-e9c0-4e4a-a08f-ef6150103771") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(5761), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f1e87c8c-9dcb-436a-b1a1-d1e094f5ee82") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(5764), new TimeSpan(0, 3, 30, 0, 0)), new Guid("60ee9dc5-454b-4cfc-b364-b8269dfbc378") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(5621), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e80c0701-b6c3-474a-b7de-23d11b258cf2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(5629), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d559ef7f-0fe9-4c71-8bf8-f083eb35ff93") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(4515), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7bac6619-0470-4d76-bf39-1c1fe232e699") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(4520), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6d332c87-685b-413b-bedc-d9da910a8a12") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(4522), new TimeSpan(0, 3, 30, 0, 0)), new Guid("014eaa9e-ae74-44b1-9df2-39504074bbda") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(4525), new TimeSpan(0, 3, 30, 0, 0)), new Guid("81a2ec7f-0735-407b-92f2-220a185d707f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(8007), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c1e86d61-eb5e-46b7-8060-912060983c3c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(8060), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c7c8ef6d-4960-4d4a-8c91-ac86f41d1f78") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(5171), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ba1ea0d9-54f8-45e2-9fb5-51681a9a2089") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(5176), new TimeSpan(0, 3, 30, 0, 0)), new Guid("04a622b5-3598-40c5-b924-30993eb9bb1b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(5178), new TimeSpan(0, 3, 30, 0, 0)), new Guid("765b9dd6-b942-48c5-a3fb-94ed59c32166") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(5184), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ab2dad4b-1dd5-4137-91a6-40cc7de311d5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(41), new TimeSpan(0, 3, 30, 0, 0)), new Guid("22016b97-1534-48d5-8913-d9adcd6b4df1") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9933), new TimeSpan(0, 3, 30, 0, 0)), new Guid("264666c2-5523-4987-bd47-641557241c8f") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9939), new TimeSpan(0, 3, 30, 0, 0)), new Guid("69f1c605-48c8-45aa-b273-58baa083e0f0") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 436, DateTimeKind.Unspecified).AddTicks(9942), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b38e63bf-65ce-4f30-abbe-2d0d24e95b80") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 435, DateTimeKind.Unspecified).AddTicks(4631), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1e9db4d0-642e-41d4-90f6-5be8095d5bd4") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a5a9668d-6577-475b-be7b-64e2d1e2b37d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 437, DateTimeKind.Unspecified).AddTicks(2181), new TimeSpan(0, 3, 30, 0, 0)), new Guid("79c8338b-331f-4219-ba98-34237bc8437c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 56, 49, 433, DateTimeKind.Unspecified).AddTicks(4884), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b9682847-ef73-42ab-9ded-cfb5a73014c1") });
        }
    }
}
