using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class cleanup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RT_AnotherRequester",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.DropColumn(
                name: "RT_CheckList",
                schema: "Dimentions",
                table: "D_RequestTitle");

            migrationBuilder.AlterColumn<bool>(
                name: "RT_RemoveRequestorApproval",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 102)
                .OldAnnotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<bool>(
                name: "RT_ERP",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 101)
                .OldAnnotation("Relational:ColumnOrder", 102);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(476), new Guid("b971fd1a-1c0f-443c-8898-5eb184458f45") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(631), new Guid("84f7befc-bb38-4b18-995f-1f0aaa102d2c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(641), new Guid("c0c3b5fd-2647-40b3-bf7e-78307492699d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(672), new Guid("7b94ecd7-12e7-46e4-8ac2-98b6070fb284") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(1647), new Guid("0160dd1b-63f1-4dd7-b2eb-da7d8e72b5f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(1693), new Guid("2eb68ffd-05ab-40c8-9f86-62b1ab7ca0fb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(1701), new Guid("9710be75-a3e8-4788-bcef-38a4c8c4e39c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(5587), new Guid("4148eb9a-3405-4cdd-b867-4660e08b0a77") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(6757), new Guid("1b9fbefb-469e-43e3-99b0-69768899ca9f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(6799), new Guid("b949eca3-3438-4e9c-b536-62a4fc763110") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(6811), new Guid("d9e5295b-82eb-4317-9083-baa2dd390ba7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(6824), new Guid("ca3fbdf2-88d3-4131-bc15-996a0510f8d4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(6837), new Guid("fe2b4494-4a75-4504-b535-3bd36a06940f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(6855), new Guid("01aaedbb-6077-4d2f-b637-351927944356") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(6870), new Guid("ed00aa8c-16ba-4cca-8416-c5df4a9dc96b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(6882), new Guid("2da76755-5e54-415a-a785-1acf6e9751ea"), "وضعیت فرآیندها(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(6894), new Guid("8cedac3e-4c06-4642-9fdc-923b4ff06afd"), "عنوان درخواست‌ها(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(6907), new Guid("3ca3ac5d-b856-4b32-80af-65973875fab5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(6920), new Guid("6fdb3f4a-caa4-47bc-a9f9-a870e8c45185") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(7370), new Guid("8ec8456e-1f94-4dea-bec2-f86efe0e1441") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(7384), new Guid("f468a5b2-5b8c-4d4b-a44a-72eb2b0f0a57") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(7401), new Guid("964e936e-f049-4b25-97d3-bb98efcc5ac7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(7433), new Guid("93d81ab0-21fe-4638-9e22-efd98b854569") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(7445), new Guid("f3b26d22-32b8-48af-aef8-b12406f0c95c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(7457), new Guid("aac2ae47-e7ef-4eb7-926d-339d56ca7cff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(7469), new Guid("1a381155-3dfe-4cde-99f3-fe235fbf54bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(7482), new Guid("a9eb423d-9def-4dbf-9f89-df7679579801") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(7494), new Guid("730604b9-d8a6-4f4c-89dd-7f4f34b2ef4e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(7506), new Guid("2ead8dce-a022-45e9-8e58-0b1124509aee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(7522), new Guid("2e759462-7345-4412-b7a8-a3d91fa4f4ea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(7536), new Guid("8a98ddde-087c-458c-8ffb-b522c0d58513") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 304L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(7923), new Guid("7e749b35-d6ef-4aaa-8235-df2203ef21bb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(3046), new Guid("42b3aefe-b015-488a-9b90-ef6ddb43a021") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(3056), new Guid("478f6a3c-ce7e-4dc7-93da-f78d4aa48dc9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(3064), new Guid("65864d0c-4677-4eab-82e5-4afb01e37d9c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(3474), new Guid("3f50e9bc-79f7-4ffb-a3d5-6052e5cdc7c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(3481), new Guid("bfd310de-12e6-4c2c-89d8-4e627a95f3d2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(2420), new Guid("59ca667a-a8b0-493d-9a68-832f176b8622") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(2932), new Guid("8bbdb6a7-b997-43f1-be2d-b0602ca9f7a6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(2948), new Guid("1567478a-1ce3-4547-b61e-5adf2dbd75ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(3573), new Guid("29616e0d-de3c-4837-a00d-ba4de6601dce") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(3583), new Guid("ed4825c3-e02a-42c3-bb46-0d48a19d9eb3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(3597), new Guid("e552bdb4-173e-40df-8cb2-d55f4b64a4fc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(3605), new Guid("379e2de3-cb38-4139-b065-d05aa16eec0e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(3614), new Guid("fdc5cf1b-c4bd-4031-8e92-bd82ba5491db") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(3621), new Guid("a4d128b8-bf87-4ddb-bfa5-d417f56828a8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4235), new Guid("48754ea2-e738-4232-849e-1797debb0c7f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4245), new Guid("bb8b8527-05d5-4416-a7f9-d80e289ae9d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4253), new Guid("20396eec-7f9b-4d4c-9871-b3669cd258b9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4261), new Guid("029ba36f-e818-469a-9d91-e429f7814c95") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4292), new Guid("0ceea65a-9821-40d4-b6ce-ae4a2eb51ef2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4300), new Guid("8ab282de-cf84-451f-b591-fb7b9c2e5fad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4312), new Guid("0d72dd76-751c-4279-9dc1-35bbe928c7ba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4319), new Guid("fb9b607f-453b-4a0c-9e69-5ce933837705") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4330), new Guid("9d176d61-dfcc-43c3-909c-c51c0acbe2da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4591), new Guid("548127a5-d8f8-4bf4-94ef-dfc2a1020067") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(3660), new Guid("b733c479-fc73-419b-9e25-1c74104ac143") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(3672), new Guid("b0c9d397-e72c-4411-92f9-7fe7ebd81d08") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4107), new Guid("46ce2559-7fcd-4d08-b41f-760304bb8265") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4128), new Guid("727360ad-107d-46fc-8723-b43162e2e1e7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4141), new Guid("bd7f7cf5-a5aa-4e7e-a169-9442bb7d7660") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4149), new Guid("6283390a-4384-418d-bd17-f11452ce36a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(5430), new Guid("8a51a37f-4a23-46f4-a83e-e765360d10fb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(5460), new Guid("e705afd1-6227-4447-b429-871036cbc882") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(5467), new Guid("36c42b8d-b8cd-43bf-b994-237e741b9048") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(5475), new Guid("34251473-c87e-4fbd-b338-59ae4190ff28") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(5485), new Guid("ba43fc0b-3ca4-48b0-bbdc-7e2343ff9aac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(5520), new Guid("48b0bf3e-0e1e-4695-a00a-6f8047482f47") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(5528), new Guid("a4e50d97-f47f-41c5-8144-4aa13775d136") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(2353), new Guid("c844e688-9335-4197-8715-6e4ab609d64f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(2363), new Guid("a5acad43-b760-4629-a48c-7ca6034b8812") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(2370), new Guid("dde31ba3-1cc6-45be-937b-c4cdc4a62802") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(2378), new Guid("2a80ecca-314d-4b51-9afe-75c08e304273") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription", "RT_ERP", "RT_RemoveRequestorApproval", "RT_ShowSupport" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(2179), new Guid("a73fcf53-de29-4638-9333-fd5e7ca87377"), "الگوی یک", true, true, true });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription", "RT_ERP", "RT_EndorsementPatternId", "RT_RemoveRequestorApproval", "RT_ShowSupport" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(2264), new Guid("5a6a28fd-07f7-425e-baa2-80fe31bbebee"), "الگوی دو", true, 2L, true, true });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription", "RT_ERP", "RT_EndorsementPatternId", "RT_RemoveRequestorApproval", "RT_ShowSupport" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(2273), new Guid("e8f62109-a358-400c-9bb7-adcb6b687487"), "الگوی دو", true, 2L, true, true });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4896), new Guid("52459a70-1ad7-4095-bce3-bfa71cd14e3a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4906), new Guid("2e51a1f3-3489-4cf7-9451-cc49fac032bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4920), new Guid("918c73ae-23dd-432b-a620-bf6d04393d88") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4929), new Guid("4531c36f-bd0b-4b12-b82a-ea68d1bc7c2f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4937), new Guid("78a03552-6974-4084-8017-65126ff79cf2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4852), new Guid("159475a1-bd33-487c-94a9-f5f6331de4b3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(4862), new Guid("3acf8bf2-8d12-4c60-936f-f321ea25edba") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(8586), new Guid("597d4df4-6c08-4581-96e1-389c11462e92") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(8614), new Guid("a88225c8-b710-4aa5-8cb8-c60835f74b8b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(8621), new Guid("bd39e75b-28d6-4e83-9612-8f827bc77563") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(8635), new Guid("a32bf1bd-aa89-491c-b9d1-592852984f3b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(8642), new Guid("2048acc4-943d-4da1-81ef-8a85673e1260") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(8650), new Guid("d0a0f0c1-d2ab-4f37-8dfc-edfd23377aa1") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(8660), new Guid("52939735-ceb2-40e8-805c-f97c55c3f768") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(8754), new Guid("506122ce-4955-441d-8544-47c86a2b81e3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(8764), new Guid("7ee7cb3a-b034-423a-bbda-1f676ce9e8eb") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(8771), new Guid("40c02aea-5569-45f1-b17f-bb940a261d2e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(8779), new Guid("940e7e41-6d27-4de7-8033-17a70bcb59cc") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(8103), new Guid("cc659400-5c7d-47f1-86ea-1264415c616a") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 48, 22, 730, DateTimeKind.Local).AddTicks(8136), new Guid("0cc538f3-d626-47c8-b9e3-8c617c054959") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "RT_RemoveRequestorApproval",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 104)
                .OldAnnotation("Relational:ColumnOrder", 102);

            migrationBuilder.AlterColumn<bool>(
                name: "RT_ERP",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 102)
                .OldAnnotation("Relational:ColumnOrder", 101);

            migrationBuilder.AddColumn<bool>(
                name: "RT_AnotherRequester",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.AddColumn<bool>(
                name: "RT_CheckList",
                schema: "Dimentions",
                table: "D_RequestTitle",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 101);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 463, DateTimeKind.Local).AddTicks(8968), new Guid("dc347abe-3b35-47be-b540-0f7a1c1d588c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 463, DateTimeKind.Local).AddTicks(9166), new Guid("0f97e3e1-95f7-46b8-984a-2f651d33fff7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 463, DateTimeKind.Local).AddTicks(9198), new Guid("50c50ea1-12ca-48e0-9374-e8546264c463") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 463, DateTimeKind.Local).AddTicks(9256), new Guid("506fbe02-4664-4723-b9eb-ec458cfb7a9c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(523), new Guid("e1001fb9-7b11-4ecd-a7ba-a62bfc427993") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(609), new Guid("5849051c-a884-4cf0-8a57-6a9efab921c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(621), new Guid("797bff19-7c53-4b56-b4d2-d3b15c123d22") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2195), new Guid("e12a78a3-8d71-4d5c-9219-129a02f60d00") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2584), new Guid("0dce6928-57a4-48e5-b398-a89af9076c36") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2614), new Guid("3f3df689-8946-4f92-9cc4-d619e6adf8b0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2626), new Guid("7c9d698b-c532-45b2-a9c3-1abb64e869f7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2641), new Guid("c852963a-db86-44f6-a7dc-c7f11238892e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2653), new Guid("0327c4b6-b3ef-425f-8354-845fbf70bccf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2677), new Guid("5c8639d6-3346-478c-9f14-53a2bd78a0f0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2690), new Guid("8922e7c6-4cda-4f0f-bb02-61ae6ad9bcce") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2702), new Guid("76370b08-64c6-41d6-a285-ea6e5082670f"), "وضعیت فرآیند(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2714), new Guid("8b377ff7-eea0-455d-abfa-a7dd03b4d9d0"), "عنوان درخواست(Dimentions)" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2729), new Guid("ceea188c-2db9-44bd-b67b-a190f8fbe0bb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2742), new Guid("a8d91327-d708-49f1-b31a-aeae3d338745") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2757), new Guid("b65aaafd-33eb-45ad-8689-ec9ead8c2240") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2769), new Guid("4a78a4d7-e2f1-49ff-92c7-41538e73d055") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2782), new Guid("32a33e1f-bb8e-4bdc-9a10-b89f15ca381f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2806), new Guid("936eca65-adad-4cf6-ad08-48e5916049f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2819), new Guid("fec22c56-05cf-4f54-94ae-4d9bd6f918ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2832), new Guid("95d86378-4710-4c46-8ecc-4e24205937bd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2847), new Guid("c4f57b84-5a59-48f4-9eb8-4c68f8548fdc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2860), new Guid("23f124f3-22df-4b14-a0a5-6b7965cf0267") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2874), new Guid("e59870cf-a12a-40f0-bfff-c8a26f0dc676") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2896), new Guid("781016fa-ebfd-4b75-8bcb-90cf020a5f9d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2910), new Guid("48b6d65a-6e5c-4424-902f-11aab67842eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2923), new Guid("ed3fcefe-0bda-4512-952d-8be6f6732468") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 304L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2935), new Guid("eb4087f2-70ba-48d3-b522-112522b10d6a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1260), new Guid("3c28f1a9-fb73-4ff3-9d2b-afda1f85c037") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1274), new Guid("5bcd8044-beb9-49db-bc0e-43d369bc20b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1284), new Guid("2c0df146-79cd-4797-ab71-ef04548b660c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1300), new Guid("0b2eb987-7d0f-4d05-b890-18a004f22cb4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1311), new Guid("a9b215f2-9674-47b3-a301-6dcb2634bfa2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1024), new Guid("09c71890-dc74-432f-897a-e49cad68fd45") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1191), new Guid("f6768a92-3e14-4863-a627-e22659a2a598") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1204), new Guid("a372215b-4de1-434c-bc01-6a9e61a7d5b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1372), new Guid("add87c31-7a8b-4af6-8208-19bb0f8b6959") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1385), new Guid("8f2cc5bd-3a03-430b-8add-860476401a80") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1395), new Guid("194a5415-db67-4649-a331-540c9af9d5d4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1410), new Guid("c46aefe7-48d4-4a33-bee4-a4e64af2c0ac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1423), new Guid("2e0535f6-6fab-449d-b61e-f4254e4c5a33") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1436), new Guid("349987c9-d917-41f5-acd1-0475667b38a4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1765), new Guid("8bd43df2-535f-4bc2-b98b-e6a85f506507") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1805), new Guid("9e30895c-7882-4df6-8af0-f68edf19e6f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1818), new Guid("b0b9f080-3a2c-4820-8134-1d6cd65fbbd3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1826), new Guid("96382338-8e5f-449b-8ea7-4836d9b239bb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1835), new Guid("3bb98a07-8f84-4bca-8ba7-39bdd2ecccf3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1843), new Guid("90bf739a-c459-4add-b7d4-dd779ae42f4b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1851), new Guid("c239e71b-029a-4911-991d-f7fedda87454") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1859), new Guid("be9e0023-ed99-4fe1-9c3f-c4a1bad77381") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1867), new Guid("8dd70bb2-3f82-4faa-b92c-c626beae99d1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1875), new Guid("54961313-180b-481e-ba4d-f834506fcb66") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1496), new Guid("b3205890-08c2-4827-a6db-1ea32c2499ed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1536), new Guid("9735cd2b-92c9-48bf-938b-57777393d264") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1568), new Guid("39d10ef7-706d-47b5-9b92-f658377f2ac0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1579), new Guid("1158b417-7bb3-42a8-ab15-859c3bedbcbb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1589), new Guid("f89b5a7b-afc7-448a-a2fb-1cb5b1138b08") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1605), new Guid("ddfa493f-81e8-4363-98a2-1217d14b9fec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2105), new Guid("587244b1-5a14-49e2-b771-d8f6b8a96d45") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2118), new Guid("91f1469a-7154-49ea-8789-01c4b3dc441b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2126), new Guid("f32b4b23-e535-47db-a148-04621caa5948") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2134), new Guid("930c170d-4206-4214-ba3a-61a15e8f0235") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2141), new Guid("abc86d08-b97e-4480-90af-f3d863ffe915") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2149), new Guid("9096407f-0ff5-4921-a230-208d663281da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2157), new Guid("743b4669-3a2d-4391-955d-1a37f8201746") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(902), new Guid("109a7c9f-99eb-452c-a279-c46d333db4ed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(918), new Guid("86b6e09e-2a8f-4aab-8d41-e20818c19626") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(941), new Guid("13a116c1-c11f-409e-902b-a4b915f698b0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(961), new Guid("d8b72325-8ae8-4f83-90e3-7d4a61783051") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription", "RT_AnotherRequester", "RT_CheckList", "RT_ERP", "RT_RemoveRequestorApproval", "RT_ShowSupport" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(753), new Guid("1de7d765-12b6-4d7b-bc7f-d7b2cbface1e"), null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription", "RT_AnotherRequester", "RT_CheckList", "RT_ERP", "RT_EndorsementPatternId", "RT_RemoveRequestorApproval", "RT_ShowSupport" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(826), new Guid("f610aecd-dd76-4f0c-bfd9-34c00869c736"), null, null, null, null, 1L, null, null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDescription", "RT_AnotherRequester", "RT_CheckList", "RT_ERP", "RT_EndorsementPatternId", "RT_RemoveRequestorApproval", "RT_ShowSupport" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(839), new Guid("fbab72ae-baae-4173-9111-e650adcf7d96"), null, null, null, null, 1L, null, null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2011), new Guid("38655bf9-c8b9-41fe-a243-3dd214a41487") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2021), new Guid("a5356e44-4651-4af0-b770-a98edd850405") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2045), new Guid("9fccb0be-b954-4171-860c-e97ad83c3cb0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2054), new Guid("89094149-6277-4d70-b563-83017afdf65d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(2062), new Guid("4813f801-0cb3-4989-81fc-8eca89ce5d5c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1968), new Guid("58330b31-26d0-49f2-8c7b-61ad359db3ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(1979), new Guid("de21821f-5067-4ff0-8341-00320f730913") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3074), new Guid("4bd675c8-e335-4d04-b4f2-63482a2ce649") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3084), new Guid("b3e61af7-543b-44ad-adff-0966f961a7e5") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3092), new Guid("5766bc20-52f0-403a-860c-86e54308a2b5") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3099), new Guid("811f348e-c12c-41b4-b8e4-9c7d06315068") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3107), new Guid("4399b964-b3b5-4fcb-adce-02055a9f498e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3115), new Guid("a1969e30-7c89-4bdf-9dac-1d3e46a36733") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3123), new Guid("e86b9d71-3070-44cd-ab9a-7b8b84ae5cf3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3536), new Guid("1d39aa70-6a03-42d1-8153-16bd8551114c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3610), new Guid("9d7a7e51-33db-437e-9019-3ccbdc7cf672") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3627), new Guid("2dedf1a7-4df3-4a49-b8d3-d7b50b4cad4d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3640), new Guid("179301fe-e2d3-494c-9a63-340a90eb737d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3018), new Guid("bf6a1b7b-e35d-42c8-8901-9129bf923472") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 46, 32, 464, DateTimeKind.Local).AddTicks(3032), new Guid("b4dcbdce-49f4-4a82-b072-042eceba1969") });
        }
    }
}
