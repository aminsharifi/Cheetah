using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Add_Constraint_WorkItemCondition_CaseTaskUser : Migration
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
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(8371), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a6fa5350-c838-49c9-94f5-3a00cc8e2615") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(8380), new TimeSpan(0, 3, 30, 0, 0)), new Guid("03619895-701a-4290-88d5-c53fa71c21ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(8383), new TimeSpan(0, 3, 30, 0, 0)), new Guid("466146b8-d648-4047-bd6c-4fedbea9a88a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(8386), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e1ef2c1b-2aef-48f6-b920-2b5c43d8e5df") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(8388), new TimeSpan(0, 3, 30, 0, 0)), new Guid("46e3b742-4b3b-4141-a6a0-781bce694742") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(8395), new TimeSpan(0, 3, 30, 0, 0)), new Guid("32b16881-9b5d-437c-83d9-04f733cb07dd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 716, DateTimeKind.Unspecified).AddTicks(167), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b339f5c9-5bc3-4bb6-a057-1b6ed28779c7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 716, DateTimeKind.Unspecified).AddTicks(9973), new TimeSpan(0, 3, 30, 0, 0)), new Guid("67782b07-9f44-4910-9403-c8ff5ae33404") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 716, DateTimeKind.Unspecified).AddTicks(9998), new TimeSpan(0, 3, 30, 0, 0)), new Guid("34b1bd39-ff6f-4398-ba3a-8906e9e5ef2c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(4), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9789ba65-6dc7-4be6-8319-b71708b353a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(10), new TimeSpan(0, 3, 30, 0, 0)), new Guid("35b19a5f-0c13-4cc3-b496-ac04551b2f26") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(15), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a0fbb96f-9960-4ab4-a121-777a3fcbb821") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(31), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b0c9ac52-ad76-4b4a-8d69-abd4c06a98f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(36), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a18d34a0-ee0e-4524-89c8-bdb4e96d2c51") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(41), new TimeSpan(0, 3, 30, 0, 0)), new Guid("412beab5-97c8-4fb2-91e1-5542674065c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(47), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f9cb3a2a-517f-4b2c-b04b-68224af6832b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(52), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d7eb9de6-f7db-4433-9b78-fb3aac12d8a1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(90), new TimeSpan(0, 3, 30, 0, 0)), new Guid("741d130b-5282-4980-9c51-647f7ad99364") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(95), new TimeSpan(0, 3, 30, 0, 0)), new Guid("49b719a2-bd43-49a9-b86f-f6667577629f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 717, DateTimeKind.Unspecified).AddTicks(99), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7745e1b2-dbfd-4910-b275-dae52c5c2880") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(3988), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1f9828b4-6de3-4f93-9157-5b8edfa52e74") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(4000), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3960c784-b8c5-41a7-8a46-65c93aab1985") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(4002), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ce3bb274-d4c4-4116-ad53-03044b0e79ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(4004), new TimeSpan(0, 3, 30, 0, 0)), new Guid("840b4db8-c8f5-45ad-a784-908821db452c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(4007), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ac71722f-5ec8-432f-a8ad-44fc4f1eb8fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(4009), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1592327d-c66c-47b9-840a-b0640a692ef1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 712, DateTimeKind.Unspecified).AddTicks(6227), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5316b538-ffa9-4e51-935d-516584a48990") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 713, DateTimeKind.Unspecified).AddTicks(7144), new TimeSpan(0, 3, 30, 0, 0)), new Guid("53154d1e-f844-448b-9a17-286697d10764") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(126), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d583c8d7-e4a4-4826-9ae7-8e6cb3ec1558") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(131), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0bb40740-6a4d-47eb-b64f-9125465cbe17") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(134), new TimeSpan(0, 3, 30, 0, 0)), new Guid("99042731-0d40-498b-9be0-e4ffff9d2b70") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(138), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3646197a-951d-42e2-bc65-6180f54b5c2f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(141), new TimeSpan(0, 3, 30, 0, 0)), new Guid("919d654e-9dc5-4152-8f65-66ecd5bc86e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(144), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cdfe2168-bf63-45b2-87b4-1f6ee0a24106") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(8), new TimeSpan(0, 3, 30, 0, 0)), new Guid("71b69d07-3b9f-4843-9cf3-1ffc3b608ab8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(13), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c641d698-df5b-4659-9013-bdf88a75a296") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 713, DateTimeKind.Unspecified).AddTicks(8743), new TimeSpan(0, 3, 30, 0, 0)), new Guid("601ee9d6-6776-4bdb-b659-bb1f112a9313") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 713, DateTimeKind.Unspecified).AddTicks(8754), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c93361ae-4965-4425-809b-782e3d3998e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 713, DateTimeKind.Unspecified).AddTicks(8757), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c2b5ee3a-21c3-44d7-9122-c3d6ed818b01") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 713, DateTimeKind.Unspecified).AddTicks(8760), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6f41609f-2006-499e-9e4c-6d769ef6a82e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 715, DateTimeKind.Unspecified).AddTicks(2618), new TimeSpan(0, 3, 30, 0, 0)), new Guid("38f99caf-a79f-41d8-a789-1c4cd3b8babd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 715, DateTimeKind.Unspecified).AddTicks(2643), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ce496182-15e8-44ee-85c6-b07a847d7b34") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(9534), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4b12b52b-0609-4502-a328-04570408bac7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(9539), new TimeSpan(0, 3, 30, 0, 0)), new Guid("027b6066-d988-4a17-808f-cc3b38bed973") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(9542), new TimeSpan(0, 3, 30, 0, 0)), new Guid("76cf84c0-9eee-4510-9652-3d592a56cba9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(9575), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d3b629df-5686-45d5-9123-5e0f07676026") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 713, DateTimeKind.Unspecified).AddTicks(3015), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b2a698ef-e4ad-46a3-b025-ef9baedb3e57") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(4376), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c58db21a-ed57-48ab-9515-4d2977c55f83") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(4381), new TimeSpan(0, 3, 30, 0, 0)), new Guid("56d06faa-5dc4-4578-9402-2c443aab3fb8") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(4442), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3fc1287e-7ff4-4564-a371-9483eded473d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 712, DateTimeKind.Unspecified).AddTicks(7704), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d70bb6c5-2eeb-496a-932b-ac0fb73541b9") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(6538), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8779be99-4442-42ac-9cb2-fb05ddfe43e8") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 714, DateTimeKind.Unspecified).AddTicks(6715), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f42eae9b-b42b-4130-9285-bd71b01964cb") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 20, 10, 45, 48, 711, DateTimeKind.Unspecified).AddTicks(1251), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cb24558b-c636-4684-94ce-81a60ad678d7") });

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseTaskUser_D_User_ThirdId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "ThirdId",
                principalSchema: "Dimentions",
                principalTable: "D_User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_CaseTaskUser_F_Task_SecondId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Task",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_L_WorkItemCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "SecondId",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseTaskUser_D_User_ThirdId",
                schema: "Links",
                table: "L_CaseTaskUser");

            migrationBuilder.DropForeignKey(
                name: "FK_L_CaseTaskUser_F_Task_SecondId",
                schema: "Links",
                table: "L_CaseTaskUser");

            migrationBuilder.DropForeignKey(
                name: "FK_L_WorkItemCondition_F_Condition_SecondId",
                schema: "Links",
                table: "L_WorkItemCondition");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(9365), new TimeSpan(0, 3, 30, 0, 0)), new Guid("804b4127-9884-45ee-9b9d-95a74e357e72") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cb861eac-3fdf-44a3-8d66-68218bd6fa3e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(9373), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d37e1f52-f4f7-4e2d-a7c0-b9485d1bfa97") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(9376), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7417a5ad-e130-4764-a415-86871765252c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(9378), new TimeSpan(0, 3, 30, 0, 0)), new Guid("57092539-e83b-42bf-aff9-cf1d7be0b095") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(9386), new TimeSpan(0, 3, 30, 0, 0)), new Guid("39d3f601-34da-40a0-840f-f9e27d9f57eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 591, DateTimeKind.Unspecified).AddTicks(457), new TimeSpan(0, 3, 30, 0, 0)), new Guid("820b2b9a-706f-4eda-b69b-a0f3830ac239") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(968), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e5f546bb-e23d-4c7c-8af5-47e34bf54665") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(995), new TimeSpan(0, 3, 30, 0, 0)), new Guid("182b869b-9041-43b5-ab89-77ba4c102217") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1001), new TimeSpan(0, 3, 30, 0, 0)), new Guid("63e652b0-08ea-4430-89e1-43681fb897e8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1016), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f41fa2cd-6044-4883-92e7-2eb74c9980f0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1021), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0774f112-aeba-44ac-9eed-d457a39f1993") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1f9ef515-7287-43e5-8f41-4e418d08a2ea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1092), new TimeSpan(0, 3, 30, 0, 0)), new Guid("462eb57c-0a34-4902-ad97-543b326b2eac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1097), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fa9d3466-fd20-47e8-9248-27d91b54454d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1104), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b08a2600-c489-45ba-b6eb-ecdbf4ba7eb2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1108), new TimeSpan(0, 3, 30, 0, 0)), new Guid("91fd2330-44ab-47e8-8731-7037349c2ea2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1113), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1bf65536-375d-47d8-bc8f-e93536be4ee4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1117), new TimeSpan(0, 3, 30, 0, 0)), new Guid("620dd466-210f-43bd-a5d8-3b1115e6b12d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 592, DateTimeKind.Unspecified).AddTicks(1122), new TimeSpan(0, 3, 30, 0, 0)), new Guid("00f774f2-357c-4b81-93db-59b183d377bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5196), new TimeSpan(0, 3, 30, 0, 0)), new Guid("796e678d-e8a9-455d-bca0-dff1644d3dd4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5204), new TimeSpan(0, 3, 30, 0, 0)), new Guid("66233e61-c67a-4755-9912-c647baae8f74") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5206), new TimeSpan(0, 3, 30, 0, 0)), new Guid("956d7098-4a67-40d4-8b34-1d59d08ca562") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5209), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c6349e78-10a9-403f-8645-2c78dbd9916d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5211), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d77d16e6-547d-4e04-8284-1e2cac2542a6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5213), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6247e1ea-b1f4-4c09-b7e0-584dd1cef6d3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 587, DateTimeKind.Unspecified).AddTicks(8880), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5875cef3-3b54-4d35-9cec-ded35341b62f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 588, DateTimeKind.Unspecified).AddTicks(9018), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f790c6a3-6e0c-4c09-bb71-31bbed1d5e9f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(1519), new TimeSpan(0, 3, 30, 0, 0)), new Guid("556b65d7-0b86-4052-a49f-f278bee998e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(1524), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f98f3cf9-4d9c-47dd-a62b-05fd8d694bd2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(1527), new TimeSpan(0, 3, 30, 0, 0)), new Guid("49516a47-f988-4bb3-b13b-c92daec956d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(1531), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f9613209-63bc-4e7e-a208-8c233248023b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(1534), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bbdc2954-c262-4aaa-b576-e6d92c2be6c6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(1537), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c082ba50-1d85-4b13-83b3-6ff9edeecdfe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(1383), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e2a88ffc-7feb-4c41-bbed-27278ea8b594") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagCategory",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(1388), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e8efae4c-772f-4a8c-b713-1dbe9336151f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(219), new TimeSpan(0, 3, 30, 0, 0)), new Guid("556be316-5496-4de0-80e2-9ce74dc83475") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(225), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ec05e034-50ae-448f-8b45-4d81a3db7740") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(227), new TimeSpan(0, 3, 30, 0, 0)), new Guid("9c31345f-5450-4649-83bf-ba9ae112d2d3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(230), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1947a49c-6653-4439-a898-06e252e54f48") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 590, DateTimeKind.Unspecified).AddTicks(3390), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3e813f8e-785c-4e55-8820-2814cb3821d1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 590, DateTimeKind.Unspecified).AddTicks(3412), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7e40e740-d8bb-40c5-8bc9-3220a2fe5bbc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 590, DateTimeKind.Unspecified).AddTicks(543), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f96c270a-f914-4d38-b4ec-21f05705bbf4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 590, DateTimeKind.Unspecified).AddTicks(548), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b511976e-e08f-44f9-9943-30be71841beb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 590, DateTimeKind.Unspecified).AddTicks(550), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fa84a0ee-9e81-4775-b12a-3cb9877d09ca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 590, DateTimeKind.Unspecified).AddTicks(553), new TimeSpan(0, 3, 30, 0, 0)), new Guid("35eeacdb-9872-4a0c-a115-7e349468950d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 588, DateTimeKind.Unspecified).AddTicks(5760), new TimeSpan(0, 3, 30, 0, 0)), new Guid("373bc06a-9e53-4a5c-a4e3-057df0a8435c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5570), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7b08d445-4aab-4ac8-8243-b4676f11c52b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5576), new TimeSpan(0, 3, 30, 0, 0)), new Guid("abce97b2-2caa-4502-a430-4c31b9dc5cff") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(5582), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d6f4c853-31c4-4e5f-8cef-18078b94acc0") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 588, DateTimeKind.Unspecified).AddTicks(529), new TimeSpan(0, 3, 30, 0, 0)), new Guid("559e6ff3-0a32-45c1-9374-bb8dd35cd6d2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(7600), new TimeSpan(0, 3, 30, 0, 0)), new Guid("45c0236c-8ebe-4d29-b9fc-88648b6ed505") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Task",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 589, DateTimeKind.Unspecified).AddTicks(7795), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f16f3200-31dd-4ee3-98cb-de9f6f00e7c6") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 19, 19, 29, 40, 586, DateTimeKind.Unspecified).AddTicks(4374), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7b2ded92-fca7-4860-8a21-46aa59cf257a") });
        }
    }
}
