using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Restrict_ReverseDeleteBehavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(2708), new TimeSpan(0, 3, 30, 0, 0)), new Guid("12c58cf0-2331-4eea-90f3-5bf9b7fef5c6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(2713), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3e989fee-811d-4ff9-b077-1819a514e646") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(2715), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3840f055-a00f-4d83-8a49-f1094d25a895") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(2718), new TimeSpan(0, 3, 30, 0, 0)), new Guid("016c5c1b-c18c-4bad-9a29-2d318b08feae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(2721), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e94aafa0-d32d-4fff-8ee4-ea65a21f4510") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(2723), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0a467784-aa7d-4eb8-afa8-678fe8426beb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 67, DateTimeKind.Unspecified).AddTicks(3447), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ad784990-0f71-4b5a-aa49-31f201cbb28a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3123), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2dd7ec68-8924-4527-812b-50eee30b4ba2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3148), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b38b14b9-a9d0-4114-a625-05ca9f81c975") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3160), new TimeSpan(0, 3, 30, 0, 0)), new Guid("499dc4ac-c0de-4e14-ae41-513a0c8603fc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3167), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9e337e54-b1a1-428d-bc93-87d739e7e876") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3172), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7d50ac3c-40a9-4bbf-90b2-bfdff9d6a604") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3177), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ab65ce69-0a88-41ba-91cb-4fb24141062e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3192), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fe97e466-facb-4276-95d7-62d0704b98fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3197), new TimeSpan(0, 3, 30, 0, 0)), new Guid("98e37f76-3bba-4f5e-a3b1-12402176d7a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3201), new TimeSpan(0, 3, 30, 0, 0)), new Guid("79aaad94-fbfc-43eb-aff9-7bad86c229ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3205), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8608dede-dc3c-4081-b50b-ca755fe8d143") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3212), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a1d0dd0f-789f-4b36-b4ab-bd6f9e51f401") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3254), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a8df8080-284d-4be2-982d-e8ebced72f36") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 68, DateTimeKind.Unspecified).AddTicks(3259), new TimeSpan(0, 3, 30, 0, 0)), new Guid("236ebfcc-71e5-4e54-9fa4-8dd205d76567") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ece65cd0-9fb4-4c32-9b13-c2058eac4287") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8600), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a05cc128-86d1-4f73-8257-9f2efdd39940") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8606), new TimeSpan(0, 3, 30, 0, 0)), new Guid("be76510a-37d2-421b-a9b4-303a5d60e4c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8608), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b9dc4649-c5ad-4c57-90b4-d9cd2aecf405") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8611), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eb740d10-86fe-43fd-ae0c-2678cbc74a80") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8613), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8f3b63a9-d411-419b-ad9b-f8131a692060") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 64, DateTimeKind.Unspecified).AddTicks(2784), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2863786c-7966-44a3-a2d9-125680cb3a7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(2793), new TimeSpan(0, 3, 30, 0, 0)), new Guid("acc61bf4-1c9e-4147-b968-5c642d0dc458") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(4996), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ea15f296-0087-49a7-904b-86088c15dddb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(5001), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6ad6b8ea-ee84-4eaa-91d2-b749d0f87e9d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(5005), new TimeSpan(0, 3, 30, 0, 0)), new Guid("50d3b452-c813-4149-9ed3-0e76496a902a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(5008), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0a86ee54-5a4d-48a5-8c8e-89bfcd260232") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(5011), new TimeSpan(0, 3, 30, 0, 0)), new Guid("59503374-2777-4fd0-ad36-75d796fb0706") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(5014), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9f52fd3f-95ee-4ef5-8d9d-47b5b68c7655") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(4874), new TimeSpan(0, 3, 30, 0, 0)), new Guid("54d93f73-6961-44f2-8f03-bd571e67096d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(4879), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9e89a8e8-0343-411c-b4be-d628b2343cb4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(3865), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3ff5aed0-7039-40b9-b621-3f68f50b4145") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(3871), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1d62b481-11dd-459a-8afd-7e766de4b2d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(3874), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3785b160-d98b-4e82-bba7-08f6367311fc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(3876), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c83bf3ce-5822-4ef9-8ea9-b898f27641c5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(6419), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ef6f86e5-ada7-4db9-8ce7-6d3202b66dfa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(6438), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e52f00ad-1c5e-4c1f-8c8f-c28d3c2fab88") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(3788), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5ba0c969-7360-4a7a-9a9c-b7de615978de") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(3796), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b3d0faed-83dd-4b52-a0a9-e9eefbfb83e3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(3799), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1c2ae80f-7163-4513-bb80-bc572eedb81d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(3801), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e4c36a9c-e018-4a0d-8f04-a37afa65a0b6") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 64, DateTimeKind.Unspecified).AddTicks(9559), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f8eb9bb0-bc62-4851-8ef2-a2814c221dc9") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8940), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3894a4c8-089b-4c75-ab5a-5f227026c68e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8945), new TimeSpan(0, 3, 30, 0, 0)), new Guid("85f1c195-ba69-49a8-81ee-7e83cb522b69") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 65, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, 3, 30, 0, 0)), new Guid("674d0c44-1fdb-45c3-84fb-27726b1eab9b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 64, DateTimeKind.Unspecified).AddTicks(4294), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2be57608-4d14-4063-8f08-24e2e5e2916e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(941), new TimeSpan(0, 3, 30, 0, 0)), new Guid("26a3db3a-3cea-4ca1-a53f-9ee88c0952c7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 66, DateTimeKind.Unspecified).AddTicks(1121), new TimeSpan(0, 3, 30, 0, 0)), new Guid("69df16ce-6069-49e4-be04-103155784167") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 49, 4, 62, DateTimeKind.Unspecified).AddTicks(8224), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8069c563-c669-4006-b3e9-5a8a018790b2") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(8042), new TimeSpan(0, 3, 30, 0, 0)), new Guid("58e017aa-2cac-40cf-89bd-1e47004d54f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(8054), new TimeSpan(0, 3, 30, 0, 0)), new Guid("230ee93b-0389-492c-b3c4-2ad61408da7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 895, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 3, 30, 0, 0)), new Guid("998ec1c9-a1db-44b0-83f2-ea0aa780ec04") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 895, DateTimeKind.Unspecified).AddTicks(852), new TimeSpan(0, 3, 30, 0, 0)), new Guid("72216169-6a03-4076-b7a6-bfd6848f3815") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 895, DateTimeKind.Unspecified).AddTicks(864), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ce63b821-aa66-463d-96f2-5cf06074ef2f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 895, DateTimeKind.Unspecified).AddTicks(866), new TimeSpan(0, 3, 30, 0, 0)), new Guid("155aa2dc-d2a3-48e8-a996-ce343244729d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 897, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7381ced7-ca12-4e40-9c79-c67a14ab184b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8773), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd607075-820f-4c13-b0f9-efb98b71c5c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8807), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c37ef5c6-a163-45c1-be08-8275bc43b2e6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8815), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1265b8f6-fb58-43b3-b2f7-51d44b17fc22") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8822), new TimeSpan(0, 3, 30, 0, 0)), new Guid("432ec273-3e16-4728-a13a-f2d947820ab1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8858), new TimeSpan(0, 3, 30, 0, 0)), new Guid("583cb8a1-804e-4d85-8129-d233ecf4f118") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8865), new TimeSpan(0, 3, 30, 0, 0)), new Guid("66cb6f56-7541-4fa6-9cac-6936eb6582e2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8881), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a728bfaa-a798-48be-a0f3-5510e4efba84") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8895), new TimeSpan(0, 3, 30, 0, 0)), new Guid("708c7c9e-d33a-47fe-9f63-69091424455a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8901), new TimeSpan(0, 3, 30, 0, 0)), new Guid("05d6000a-54c9-4e72-aa58-7a6d5a572847") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8907), new TimeSpan(0, 3, 30, 0, 0)), new Guid("60a04b16-39b4-44b0-a8f1-47a238376be3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8913), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8f9a03fb-6424-4529-8cfd-4c46d47bc2ff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8918), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd2bdd79-850e-4ec2-adb3-80e5d69a212c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 898, DateTimeKind.Unspecified).AddTicks(8923), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1638068b-cf07-4de2-af67-387587c1c0f0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1221), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9a9e9ec7-a04f-419c-bd24-c943aaab8db7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1232), new TimeSpan(0, 3, 30, 0, 0)), new Guid("de531e42-8a33-4721-bb9e-580d0cb10a5d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1234), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eff4d685-6598-42b1-8097-db6b86f4264e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1237), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3491bef9-bbb8-4ac3-9288-ec85e30c5499") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1239), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3415cff6-f21e-4f59-9731-51bfa03e92a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1241), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b9083c5c-65ff-485c-88c3-2e0927dc7398") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 891, DateTimeKind.Unspecified).AddTicks(9952), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3d709c21-3260-413d-b5db-6fb7864ed6b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(5126), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bc1ec724-ce16-4fc8-b439-1fb0a2b03773") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(7295), new TimeSpan(0, 3, 30, 0, 0)), new Guid("61c1fdcc-c06a-4510-8901-b6523fc048d9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(7337), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f77cc4c7-501f-45fd-9af9-c2902a1dfd46") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(7341), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a9e52c96-274a-4618-a3d3-10ba5c896efa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(7344), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0c41c578-718b-4994-91cd-6ac3f2b31f00") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(7348), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f0cb4144-b05b-45f5-8c6b-26f7982dcb76") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(7354), new TimeSpan(0, 3, 30, 0, 0)), new Guid("90c62506-c7a1-46e5-b281-3f1ec068ba8e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(7182), new TimeSpan(0, 3, 30, 0, 0)), new Guid("40a2d399-c3a8-46f0-8201-a08cbcee7237") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(7186), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e18585f4-3824-421d-8fab-e116b46e8fa2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(6170), new TimeSpan(0, 3, 30, 0, 0)), new Guid("42cc5f08-bff4-4832-a873-4ccc349b2335") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(6176), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b90b68f3-1711-4664-bf6b-8725fbb32cc9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(6179), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dc8c9802-9711-4e27-8363-b54589d8ad44") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(6195), new TimeSpan(0, 3, 30, 0, 0)), new Guid("18a8d29f-bec9-4525-ac90-6a1e4da97859") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 896, DateTimeKind.Unspecified).AddTicks(2055), new TimeSpan(0, 3, 30, 0, 0)), new Guid("142a3fab-6d3e-455c-92e6-8f6200000282") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 896, DateTimeKind.Unspecified).AddTicks(2088), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3399b1e7-f35d-4912-a6a2-adc41e03d57c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 895, DateTimeKind.Unspecified).AddTicks(3458), new TimeSpan(0, 3, 30, 0, 0)), new Guid("57c2aacf-ef8f-4d0b-80d2-5d09f8b7d35a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 895, DateTimeKind.Unspecified).AddTicks(3471), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b84ebb7e-fdb8-49fc-839c-3c3002c4fbda") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 895, DateTimeKind.Unspecified).AddTicks(3473), new TimeSpan(0, 3, 30, 0, 0)), new Guid("90d57763-be1c-488d-bc35-6a22f1419878") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 895, DateTimeKind.Unspecified).AddTicks(3475), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4a2ef78b-caa0-4ea7-87e3-c5408a74ba9a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 893, DateTimeKind.Unspecified).AddTicks(1936), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a260d8aa-9c40-4eca-ad37-0e6765f5a448") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1591), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e46c9246-dab9-470d-9c35-b482e6b442d3") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1601), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b143965c-e719-4afa-a14e-ce259e63f16a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(1605), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cfc51243-34a8-4ca8-9fdd-a6c91783517d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 892, DateTimeKind.Unspecified).AddTicks(4671), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6521c623-dc0b-496b-bacd-9258a496a70b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(5359), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9ef50426-961d-44cc-abfe-44e066c898e5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 894, DateTimeKind.Unspecified).AddTicks(5699), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bbd7ffd7-24de-4f68-a811-968f78aa27e5") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 13, 23, 58, 890, DateTimeKind.Unspecified).AddTicks(2297), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e1a5a242-c1b0-462b-b543-1ef52248eca7") });
        }
    }
}
