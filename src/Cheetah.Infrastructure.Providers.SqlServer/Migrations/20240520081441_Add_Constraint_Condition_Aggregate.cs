using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_Constraint_Condition_Aggregate : Migration
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
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(319), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3acef13b-ff80-4d68-ada1-3af32830af8a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(325), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dafa2075-d19b-4aaf-b0ea-9a78508a4ea7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(332), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7165d9fe-e5b2-4671-bd60-e5bfb2ebe1ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(335), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0b0f21f8-ca7d-4949-9c0f-8a5e67c2d2c7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(363), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a762f929-aadd-44a9-80ca-ba40043c0d70") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(366), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4ecee1f0-8531-455e-9432-d3779c5fe7c3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 482, DateTimeKind.Unspecified).AddTicks(4028), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8d714507-1b8f-4efc-8cf0-bae86fe935c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4332), new TimeSpan(0, 3, 30, 0, 0)), new Guid("691ab8d9-5b8c-47ad-80dc-40d934c22586") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4361), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7c2ba860-ae81-48f7-8aec-174905ff6441") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4367), new TimeSpan(0, 3, 30, 0, 0)), new Guid("be94f789-35d8-48b7-a936-bd9be02f80da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4372), new TimeSpan(0, 3, 30, 0, 0)), new Guid("384a6ea0-1f83-4990-98a6-0ba46dce3903") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4441), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5a57971c-43e6-4b3f-acc4-b3a138d73a73") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4446), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9c56586d-eda4-410c-af41-29baa1f3fedf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4452), new TimeSpan(0, 3, 30, 0, 0)), new Guid("237a71f3-6b13-446a-81f7-69369ae75965") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4457), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d6304fce-9f9e-4a83-8754-049628a0b68c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4462), new TimeSpan(0, 3, 30, 0, 0)), new Guid("177d9ef1-28ff-4af3-becb-498e389f228f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4466), new TimeSpan(0, 3, 30, 0, 0)), new Guid("db3a238d-c52c-4f9e-a292-b569f56aeb45") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4471), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4ea04046-a5e4-4a2f-8c2f-c5a988d0324e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4475), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c34e1806-84c9-424a-b8b9-631d2f08a36d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 483, DateTimeKind.Unspecified).AddTicks(4481), new TimeSpan(0, 3, 30, 0, 0)), new Guid("00c79700-c60e-49fc-b378-a1aa38342ed7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(5833), new TimeSpan(0, 3, 30, 0, 0)), new Guid("28e0b53e-e30f-4b6b-a45e-d78952f9817d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(5844), new TimeSpan(0, 3, 30, 0, 0)), new Guid("be780752-41f1-4fc5-a841-94e5901f1035") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(5847), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0e80bed5-5a17-4780-add7-fb3763921fbc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(5850), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2abf0db2-acc8-47fd-84d8-3488c3604559") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(5852), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aeda43e7-b99c-4005-8a08-9a636862985b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(5859), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cad4ead5-5154-41f4-ab18-ca7cfabc50eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 478, DateTimeKind.Unspecified).AddTicks(8798), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b034d8f6-a26f-4fea-8b98-88b54c82f998") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 479, DateTimeKind.Unspecified).AddTicks(9510), new TimeSpan(0, 3, 30, 0, 0)), new Guid("278b5c84-dbb4-4807-b02c-696882cf48b7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(1909), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9130cdc5-0aef-4853-b292-b2e2b74d5d97") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(1914), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ac6ff255-7c40-4ebc-98f4-cc1e8147e0f1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(1947), new TimeSpan(0, 3, 30, 0, 0)), new Guid("68aef45e-3b96-4b5a-9c5c-e71398160d44") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(1953), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0047ca24-ed17-49be-a23f-a4ed99980408") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(1957), new TimeSpan(0, 3, 30, 0, 0)), new Guid("47c4968c-4fe1-4823-b608-1ccadadc085c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(1960), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2854af21-67cd-4ea6-8894-42b2d912831f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(1754), new TimeSpan(0, 3, 30, 0, 0)), new Guid("20821f26-9642-4e27-b7b6-23f9a456e3c6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(1763), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6d860aeb-c5bb-44b4-bd3b-2e723c7a4ecb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(620), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f250c5e4-713f-4ba2-901d-34c328000c6d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(635), new TimeSpan(0, 3, 30, 0, 0)), new Guid("abdbd173-cb8e-45db-954a-a81380a3cbbe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(638), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5d99c68c-1983-4481-9f9d-21fe77c6599d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(640), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd6d70a0-9a08-455f-8cdd-5ef141b42a8f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(4549), new TimeSpan(0, 3, 30, 0, 0)), new Guid("16184429-c20d-4eb2-8dd9-01b0507dc3f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(4575), new TimeSpan(0, 3, 30, 0, 0)), new Guid("54183d65-0d0e-49a7-b6f4-6812a5f1d919") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(1609), new TimeSpan(0, 3, 30, 0, 0)), new Guid("459bfa13-47a7-4168-9038-3e1a821cd396") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(1620), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aa3ce758-b758-4dc7-87a5-93c215afc39f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(1622), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cd70da2f-6da7-449f-bc37-7864e663ecb3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 481, DateTimeKind.Unspecified).AddTicks(1624), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a1b37e0-1437-4ba8-94ba-563e19d8f314") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 479, DateTimeKind.Unspecified).AddTicks(6099), new TimeSpan(0, 3, 30, 0, 0)), new Guid("71483239-5d1e-4edf-99f4-f562012d2135") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(6215), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ca0a2e57-e1c7-4414-ae57-aff405d65444") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(6221), new TimeSpan(0, 3, 30, 0, 0)), new Guid("efed98ea-672e-4ffe-acd5-e81b44a42284") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(6225), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d5a75ca9-5b7c-48bb-a23c-5cf803ecc048") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 479, DateTimeKind.Unspecified).AddTicks(364), new TimeSpan(0, 3, 30, 0, 0)), new Guid("83ffb95f-ec42-41ff-b754-baeca60b0846") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(8502), new TimeSpan(0, 3, 30, 0, 0)), new Guid("43c90797-14f2-4808-9686-b15ff99f6de7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 480, DateTimeKind.Unspecified).AddTicks(8693), new TimeSpan(0, 3, 30, 0, 0)), new Guid("057da293-600c-445d-9171-f11dfdb1fe15") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 44, 40, 467, DateTimeKind.Unspecified).AddTicks(8598), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2b7f815b-b352-48f8-b0e4-4fee7542b66d") });
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
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(6977), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fce7f25b-062e-4162-b110-d634dc6960a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(6989), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d962e0fb-95d6-4935-ac78-3a31bcb8ca87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(6992), new TimeSpan(0, 3, 30, 0, 0)), new Guid("672b37d4-b9c5-4539-98b3-b78641cacdaa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(6994), new TimeSpan(0, 3, 30, 0, 0)), new Guid("71fbb56a-6971-4fd5-8541-d81c7a9c6f66") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(7001), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4749874c-ac3f-442b-a94a-bcd8bcc0a886") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(7004), new TimeSpan(0, 3, 30, 0, 0)), new Guid("70719537-c6c8-4ecc-9d3f-e7b4ff3d0239") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 348, DateTimeKind.Unspecified).AddTicks(8866), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c1432627-ff4d-4893-829a-5b6ac739c62a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9678), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f80ea019-d9aa-41df-8728-82f7723f4ed1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9705), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ccc95834-b6b3-4d18-b09a-93aee1b1dc81") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9721), new TimeSpan(0, 3, 30, 0, 0)), new Guid("07fdff72-c591-43a3-ae16-6c6bf1cf133c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9729), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ae2aa31a-161c-49c5-9c0a-b8cc7fd0d543") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9734), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2ce05771-3e3a-41f1-a43f-b8d42aa9c62f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9744), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f69c8ea9-d9e6-494b-b493-0d5648598771") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9750), new TimeSpan(0, 3, 30, 0, 0)), new Guid("99863305-e302-4e9a-863e-115f62f1dbb8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9756), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cb6506c6-9ea0-4df6-980d-c42395ce2a93") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9760), new TimeSpan(0, 3, 30, 0, 0)), new Guid("003f0f14-e6ca-4512-b37d-6afa0ebc6e8b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9765), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a135387c-09de-4a7e-b991-bfc42dad0d1d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9770), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dcf289ef-9935-4ec5-b861-5928c34441c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9774), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5497d429-43bd-4b16-826f-8e9f4e44f157") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 349, DateTimeKind.Unspecified).AddTicks(9778), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1f022f4b-8c0a-4dd8-babe-1052611b86fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2495), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f1a56ea5-71bc-426c-8342-e049d9041224") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2507), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5f45575c-586a-4d3d-a0f8-894160241d25") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2510), new TimeSpan(0, 3, 30, 0, 0)), new Guid("04072300-400b-4971-a442-bbd16661f593") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2513), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3f0855d2-0398-447f-891c-f9a2ca32a21d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2515), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7017c2bd-dfe1-40e5-8822-9d53e7659ce7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2517), new TimeSpan(0, 3, 30, 0, 0)), new Guid("35e75d6b-6625-4a21-8676-f627f1a79f50") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 345, DateTimeKind.Unspecified).AddTicks(3392), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0408cb88-a370-46dc-abd9-235b5ea85f4f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(5893), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a765ade2-93be-4c01-9cc8-9fd22e315aab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(8655), new TimeSpan(0, 3, 30, 0, 0)), new Guid("99be2a1a-f73c-49a7-bb31-89373fdc9880") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(8659), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b8f6ce0d-0e36-48e0-a540-782dc189bcb6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(8662), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9ba7babf-ef17-4961-beb2-c930f0647ef1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(8665), new TimeSpan(0, 3, 30, 0, 0)), new Guid("30584350-d1ee-4aed-b5db-7f2bb2d9e06b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(8669), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2f2485f3-34c4-44c2-9482-ea5fd70c8c11") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(8675), new TimeSpan(0, 3, 30, 0, 0)), new Guid("145d0dbe-06ec-4a91-9879-1bc9b6fb06ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(8533), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7a44bdf0-e5e1-4798-9834-d1a17481737e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(8538), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5a485583-aa44-431a-ac0b-f9aa3b22a954") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(7392), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ed0c0448-2968-4f58-bb6c-ba9aac3a9968") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(7407), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4f4a617a-fa3d-4cc9-9616-fe226676496f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(7410), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ad9a0c97-b5f7-4df0-8f93-aeb16d59ff8a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(7422), new TimeSpan(0, 3, 30, 0, 0)), new Guid("12991509-0080-4d59-99b5-0681daaf531a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 348, DateTimeKind.Unspecified).AddTicks(983), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9a23d219-2c0e-465a-bba2-e3f0f2383dd5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 348, DateTimeKind.Unspecified).AddTicks(1015), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fc56b753-e01a-4293-ae29-ef3352fb396c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(8158), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ba8309da-36d4-4e20-ae02-a3c89a1afd07") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(8164), new TimeSpan(0, 3, 30, 0, 0)), new Guid("48641316-25cc-4c1d-961a-0469a3109b65") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(8166), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ee7ff13c-1248-4967-8d64-80e5429c423d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(8169), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fac50aa6-e02d-4d01-b416-ab252da9a9a1") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 346, DateTimeKind.Unspecified).AddTicks(1074), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2b52f98f-3ae1-4a04-816d-6422ad247517") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2857), new TimeSpan(0, 3, 30, 0, 0)), new Guid("98bb95d0-1001-45bf-9fe4-8ba48e78a878") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2867), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b9ce1c31-1553-45b3-864a-a2a3aa0d84b5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(2871), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7262c68-2d0c-4bba-8c33-f51d33e7c130") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 345, DateTimeKind.Unspecified).AddTicks(4965), new TimeSpan(0, 3, 30, 0, 0)), new Guid("661a4f02-578f-45ea-bb52-f9be86939ad6") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(5082), new TimeSpan(0, 3, 30, 0, 0)), new Guid("57d11719-2062-4cf1-90e4-092a20409935") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 347, DateTimeKind.Unspecified).AddTicks(5259), new TimeSpan(0, 3, 30, 0, 0)), new Guid("32aa36b3-1dd0-48d1-a4aa-0ad284e39ed2") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 11, 22, 32, 342, DateTimeKind.Unspecified).AddTicks(9983), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a4a44f30-b90c-4c27-bf88-7654131b15f7") });
        }
    }
}
