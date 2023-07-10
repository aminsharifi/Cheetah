using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess_SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class workitemstate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_Entity_D_Entity_Parent_Id",
                schema: "Dimentions",
                table: "D_Entity");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Location_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Operand_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Position_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Process_D_Process_Parent_Id",
                schema: "Dimentions",
                table: "D_Process");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessState_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Role_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropForeignKey(
                name: "FK_D_Tag_D_Tag_Parent_Id",
                schema: "Dimentions",
                table: "D_Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_D_TagType_D_TagType_Parent_Id",
                schema: "Dimentions",
                table: "D_TagType");

            migrationBuilder.DropForeignKey(
                name: "FK_D_UserInformation_D_UserInformation_Parent_Id",
                schema: "Dimentions",
                table: "D_UserInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Attachment_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_F_Case_Parent_Id",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_F_Condition_Parent_Id",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Endorsement_F_Endorsement_Parent_Id",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Scenario_F_Scenario_Parent_Id",
                schema: "Facts",
                table: "F_Scenario");

            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_F_WorkItem_Parent_Id",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropIndex(
                name: "IX_F_WorkItem_Parent_Id",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropIndex(
                name: "IX_F_Scenario_Parent_Id",
                schema: "Facts",
                table: "F_Scenario");

            migrationBuilder.DropIndex(
                name: "IX_F_Endorsement_Parent_Id",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.DropIndex(
                name: "IX_F_Condition_Parent_Id",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropIndex(
                name: "IX_F_Case_DsblRecord",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropIndex(
                name: "IX_F_Case_Parent_Id",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropIndex(
                name: "IX_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropIndex(
                name: "IX_D_UserInformation_Parent_Id",
                schema: "Dimentions",
                table: "D_UserInformation");

            migrationBuilder.DropIndex(
                name: "IX_D_TagType_Parent_Id",
                schema: "Dimentions",
                table: "D_TagType");

            migrationBuilder.DropIndex(
                name: "IX_D_Tag_Parent_Id",
                schema: "Dimentions",
                table: "D_Tag");

            migrationBuilder.DropIndex(
                name: "IX_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropIndex(
                name: "IX_D_Process_Parent_Id",
                schema: "Dimentions",
                table: "D_Process");

            migrationBuilder.DropIndex(
                name: "IX_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropIndex(
                name: "IX_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropIndex(
                name: "IX_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropIndex(
                name: "IX_D_Entity_Parent_Id",
                schema: "Dimentions",
                table: "D_Entity");

            migrationBuilder.DropColumn(
                name: "Current",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_Scenario");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_Attachment");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_UserInformation");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_TagType");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Tag");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Role");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Process");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Position");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Operand");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Location");

            migrationBuilder.DropColumn(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Entity");

            migrationBuilder.RenameColumn(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_WorkItem",
                newName: "WorkItemStateId");

            migrationBuilder.AlterColumn<long>(
                name: "TagId",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<long>(
                name: "WorkItemStateId",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 105)
                .OldAnnotation("Relational:ColumnOrder", 50);

            migrationBuilder.CreateTable(
                name: "D_WorkItemState",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_WorkItemState", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9602), new Guid("91bca34f-9ac3-45d6-96dd-ab0633ca617e"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9647), new Guid("27435f60-8e66-41be-b5aa-545e2df0d431"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9648) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9654), new Guid("cc634621-5eee-45ae-a8e0-82796a46deba"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9654) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9659), new Guid("f3e5a7eb-6b32-48f3-94ab-adc41513356c"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9665), new Guid("ba224674-c37a-4954-bba9-a02f63b66815"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9670), new Guid("e11ae6a5-c4fa-4232-931c-3cefd52b3b8e"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9675), new Guid("a7133c14-ef3e-44c6-8f0d-3504476902e2"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9681), new Guid("f379f63d-141d-4df9-9d8c-665c853557c1"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9746), new Guid("997d1413-d8e1-4776-ae95-f46ac984a1b3"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9746) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9754), new Guid("a4dd5767-8869-4563-ab67-f05e8e587324"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9760), new Guid("ade19092-4ad9-4f1d-a7d8-95ad73ab2434"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9765), new Guid("1d4bbe9f-f073-4682-9adf-88eaace7c0d5"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9770), new Guid("e0254b3f-cb44-4dbf-868a-af0f63c69eed"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9776), new Guid("3fb11a4f-ad5c-4d6d-a0f1-4473fbd41432"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9781), new Guid("d9ff2401-592a-4047-b7f9-4786a8ffeccd"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9787), new Guid("4e4926bc-f0cf-4b58-94c5-33be6a8c5a5c"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9791), new Guid("26e16775-b100-425a-ae90-f3fabbcf02ff"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9798), new Guid("5d54ca84-cd5e-4bbc-82cf-60234e78f7c3"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9803), new Guid("5e6e9f8f-a6ba-4fe0-aeb3-4d891f22f332"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9808), new Guid("7dce7f26-c09f-494c-8355-d24e314bd35e"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9302), new Guid("c9fc0e80-72a8-4bac-9d73-dc50d0385fb1"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9305), new Guid("57d2021c-e34e-4832-a6d6-b17e5dafe737"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9308), new Guid("bfb62167-df98-49b7-ac5c-6d97f61e667f"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9328), new Guid("27084430-9410-4e51-b704-8d8c98051f5a"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9329) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9331), new Guid("b5d51020-e9b9-463c-9fb8-9fc949ff8580"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9333), new Guid("8929f524-ae7e-48cf-8cef-ef79a65f2052"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9338), new Guid("66c6d3fe-e7c5-434e-b3bb-fe4339ff9f89"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9340), new Guid("5e1783f1-b4ac-4688-87dd-8283cd0acba4"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9342), new Guid("7a9278a3-4eed-4d2f-bc19-f1e29eab09f7"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9559), new Guid("1c8826a5-96b5-4d53-ac42-270d93220d2a"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9562), new Guid("ff8e5069-c3d1-4f96-8878-b0a3a608901f"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9564), new Guid("f987dda4-97f2-4612-bbae-b841c176ddb6"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9566), new Guid("ac337b65-a67b-4f61-ae05-a14c0017069f"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9569), new Guid("3129e590-2b2a-4d6c-a4c8-62eecb0743bf"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9571), new Guid("94a80534-9d8b-464a-9dcb-d38b22bc6901"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9572) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9574), new Guid("a8de1e9d-8c0e-45e3-a0d2-08b050037c66"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(8941), new Guid("5b29ba9b-af97-4192-a2ad-275e48159493"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(8992), new Guid("7e42b9a4-2ee1-4323-9801-cc63dcc2b469"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9057), new Guid("d657a246-23b1-4dec-8bf7-8cf7aafd9d3c"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9257), new Guid("967c23c0-dce9-4fe8-943a-2e55adff1942"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9258) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9261), new Guid("5d1eee3f-9f02-4695-ac42-d1b168cbbb48"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9276), new Guid("4a6ec3ca-6f4e-4306-ab47-651a94a4f76c"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9277) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9279), new Guid("7cb1834c-f35a-43d4-bc12-377563a264f2"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9524), new Guid("16196dc4-1fd8-467b-859b-8b8904126c17"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9528), new Guid("de283490-ff95-40e2-b38c-5389f1ec6eef"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9531), new Guid("7b6b2d8b-1af7-4398-97ff-9c9002a3a664"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9533), new Guid("bcf869d9-30eb-4a00-b774-8b62b83f3d58"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9536), new Guid("2d4a0ded-1b2e-4e22-86b7-0cdefcdef428"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9397), new Guid("a64d6a22-ba61-41e9-a0c0-7084cd6cfd13"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9404), new Guid("16608285-8c78-49d7-8e95-5722e220d47d"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9407), new Guid("f7b35964-183b-4e61-a7c7-1208fd30bb38"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9409), new Guid("717735ef-4003-400a-bc02-787536d32df4"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9412), new Guid("3349a320-7da4-4214-9e54-95e16104c310"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9414), new Guid("a87e3467-479a-4228-9d1a-569a663527d0"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9417), new Guid("4259ba5d-839f-4a6d-bbe5-2f2da70fa422"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9419), new Guid("b463603f-9617-4d73-8532-2cd9ef23cee7"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9422), new Guid("bb398a17-3589-4f33-9479-52b0efc728e3"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9422) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9426), new Guid("292aa910-4159-400e-bb79-e2f5e7690274"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9373), new Guid("f4ea1508-da36-46d1-8f73-7553b04815e9"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9376), new Guid("5e229880-02d8-4a21-9e47-d1534a80a3f9"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9376) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9378), new Guid("32a8cde9-08a6-4208-aa1e-d13b4b5761bb"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9380), new Guid("c303a6da-a8aa-4b1b-bee3-c06ac54009bb"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9459), new Guid("1bedc796-90eb-4051-951f-cdb09127f25d"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9463), new Guid("08709384-35f5-4612-92f0-b533b59f8b58"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9877), new Guid("81d452c5-72a6-44b1-8f83-40ba235ff39d"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9883), new Guid("777bff41-9cb0-4fef-a42c-7eec57cbc64f"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9888), new Guid("a068247c-e2df-41de-aa2b-3c65079edb40"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9926), new Guid("24956208-19a7-4669-9a81-22f14545db1d"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9926) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9929), new Guid("e12ab7fc-cc75-46f2-aacb-c5f410a14680"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9953), new Guid("cbfb5fb5-1201-4e02-bf12-e46cf89667f5"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9957), new Guid("abef7a06-7ff9-4461-b203-41a35094927a"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9960), new Guid("870e17e8-42aa-4d7e-acca-d54196e3f48c"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9963), new Guid("a1bb2109-980b-42eb-af8a-9ba79f08349c"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9847), new Guid("3a1bd754-f1fd-405c-9e63-990139dd9e67"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9848) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9851), new Guid("ad6307fc-cdd4-4e6d-8887-1f0b81d67e94"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9854), new Guid("705af4b7-dd4c-4372-abb5-5826526b5f41"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(59), new Guid("982506d1-bb37-4b9c-80f2-1a59a5abf97a"), new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(63), new Guid("258aa16d-910e-448c-9153-493406ad4e05"), new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(65), new Guid("9f34ce9c-b779-423e-8050-f62da00acd8d"), new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(68), new Guid("3ca67893-a40d-4947-9ed8-be33ebf8ec4d"), new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(68) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(71), new Guid("35dd3f80-dccb-48cf-9081-f4605c928991"), new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(19), new Guid("5aa772a5-0cdd-4a89-bc04-ddda42558134"), new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(22), new Guid("182ef2d0-bd35-499a-878b-4dacdd1b6e8f"), new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(25), new Guid("e20a8cb9-469f-474b-b421-e038fd639eb4"), new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(26) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(28), new Guid("3c74ad56-7abc-4a6d-b0bd-67fa5d85840a"), new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(30), new Guid("b9cb5530-7a6d-43a6-aafb-2a5e04c3f21f"), new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(35), new Guid("9fb066a1-57d8-4ce5-b174-876d9a98ebe2"), new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(38), new Guid("0ad54bbb-4f94-40e9-b330-6e25452d5f27"), new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(38) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9987), new Guid("3f5f4e36-cb8c-452f-9ea1-c69bda657367"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9992), new Guid("bd8f9514-cb22-40cf-8194-67567129a823"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9996), new Guid("416ba399-b319-44bb-98b8-36652a76eccf"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9998), new Guid("8f6cc3e0-4514-4ae9-8143-b50845d8947a"), new DateTime(2023, 7, 10, 12, 41, 34, 536, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(93), new Guid("92d26a3f-4e4e-4439-ac8d-30d1f91b0391"), new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(98), new Guid("db0b7620-57e1-43f1-a46e-5d31048de6e6"), new DateTime(2023, 7, 10, 12, 41, 34, 537, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_WorkItemStateId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "WorkItemStateId");

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_DsblRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_ERPCode",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_Name",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "Name",
                unique: true,
                descending: new bool[0],
                filter: "[Name] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_D_WorkItemState_WorkItemStateId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "WorkItemStateId",
                principalSchema: "Dimentions",
                principalTable: "D_WorkItemState",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_WorkItem_D_WorkItemState_WorkItemStateId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.DropTable(
                name: "D_WorkItemState",
                schema: "Dimentions");

            migrationBuilder.DropIndex(
                name: "IX_F_WorkItem_WorkItemStateId",
                schema: "Facts",
                table: "F_WorkItem");

            migrationBuilder.RenameColumn(
                name: "WorkItemStateId",
                schema: "Facts",
                table: "F_WorkItem",
                newName: "Parent_Id");

            migrationBuilder.AlterColumn<long>(
                name: "TagId",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<long>(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 50)
                .OldAnnotation("Relational:ColumnOrder", 105);

            migrationBuilder.AddColumn<bool>(
                name: "Current",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 105);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_Scenario",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 50);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_Endorsement",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 50);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 50);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_Case",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 50);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 50);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 50);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_TagType",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 50);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Tag",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 50);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Role",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 50);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 50);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Process",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 50);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 50);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 50);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Location",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 50);

            migrationBuilder.AddColumn<long>(
                name: "Parent_Id",
                schema: "Dimentions",
                table: "D_Entity",
                type: "bigint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 50);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4697), new Guid("7e78bcc2-ca22-43bc-a14f-70aaeecea94c"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4698), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4744), new Guid("e0a48cf4-7201-4f75-8ad5-11ba28348dd6"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4744), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4749), new Guid("0904c363-3f3e-410d-ad1e-60bc85488bc6"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4750), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4755), new Guid("6227f4e8-de96-4fdb-bc7c-ccd87f5cc34e"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4756), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4761), new Guid("a84a6bc3-25d9-4926-91d7-eecd3c39bb23"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4762), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4830), new Guid("dcea122b-274b-41ba-8176-c0a70e999d3c"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4831), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4838), new Guid("efcd6647-dc1b-4827-8e4b-49db07cd9a42"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4838), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4846), new Guid("4af950c9-e438-441c-a71a-ac7712cf2ad4"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4846), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4852), new Guid("bf427735-64ce-4301-a523-f84af7f54f14"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4852), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4857), new Guid("80b2e04d-8379-4f05-8e91-9d1206d06295"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4857), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4864), new Guid("2089379b-220e-4361-9679-3febd1b51c99"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4864), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4869), new Guid("fee83096-bb47-4a0b-84b9-79fe943c82d8"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4870), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4875), new Guid("ddde0e18-ffe2-47ee-8972-711a8535c2ec"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4875), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4880), new Guid("4c56683c-ed2a-4c14-b4a9-5632736443d2"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4881), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4886), new Guid("a9f075ce-1eba-4a12-b32f-198374a25c1a"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4886), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4894), new Guid("37cb36f3-6d56-43a8-b930-142316df7382"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4894), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4900), new Guid("962dd10b-2358-45a6-b441-341b9f890f31"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4900), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4905), new Guid("6c2bc688-4789-41b4-9c5a-a3c89b32ca5c"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4905), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4911), new Guid("cf95de0d-565a-4420-977a-d7b66ea15328"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4911), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4916), new Guid("e1fee514-a82c-4a97-8a3d-d846a7ca3ccf"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4917), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4331), new Guid("3f9bcd4d-7b12-4c7b-9ad5-8df8d03195fa"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4332), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4334), new Guid("e241bcba-efa3-4cc6-b1af-5f832ba1d684"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4335), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4337), new Guid("fc27a7e3-067f-464a-bc2e-2f5352478c64"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4337), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4406), new Guid("0008ff75-236d-418a-8b33-00bed256240b"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4406), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4412), new Guid("c11f7fbd-f198-4e50-babf-1e410a164524"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4412), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4414), new Guid("bf68b41b-007d-4b4e-8c42-9ee95b20b42f"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4415), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4417), new Guid("f80a33f2-c30a-4cfa-b9c1-45e8caf15c05"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4417), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4419), new Guid("d0b2dfec-97f8-4ffe-931d-5c960bc11a4c"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4419), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4422), new Guid("630f7f37-4ed4-4114-b0b3-d10dccd14167"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4423), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4654), new Guid("2d7b23a4-80bf-4f60-a2d9-446d49dbed9d"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4655), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4658), new Guid("070eb1e8-b36c-4ce9-b179-9c30819f797d"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4658), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4660), new Guid("454c7165-4b6e-4656-beb8-2177bef0f023"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4661), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4663), new Guid("62d6c990-7b67-49e5-be93-abbe7d479ee3"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4664), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4666), new Guid("346c45f1-f642-4ac1-9bc0-36383f74f989"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4666), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4668), new Guid("bc682979-e48b-4738-9e9d-bfe44e8f6e46"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4669), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4673), new Guid("701e3ab9-e0b6-4940-b660-cbf72c52fa67"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4673), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4037), new Guid("24a21a9a-46e6-434f-9456-2124c245f4c4"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4053), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4087), new Guid("f6365af5-fa60-4da5-a367-797dc5aab768"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4088), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4090), new Guid("a585f0e9-712f-41fb-9119-61ef656fde21"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4091), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4295), new Guid("a38e9629-e24e-469c-bbaf-a19ba332e3eb"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4296), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4300), new Guid("4629301e-8b46-4a68-bd1c-60f9923ac209"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4301), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4303), new Guid("b18ca8e9-9f42-449e-b751-ee2a0a9e3735"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4303), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4305), new Guid("5d66d839-1443-4345-920f-f58d35aadd4a"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4305), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4613), new Guid("6a5e79a9-7da2-4bc3-b936-1723dae61412"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4613), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4616), new Guid("f8bb6bce-35c9-495b-a978-df94ea8c5548"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4617), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4619), new Guid("0331604b-b59b-4b31-aebc-c342bcd2ee87"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4620), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4624), new Guid("b202bf81-ca86-4c12-98e7-42cb70c7568b"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4625), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4628), new Guid("dce7f1a8-06e5-4b67-98a4-772b397f86f7"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4628), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4488), new Guid("93865aa4-6e21-4e90-a3fe-dae35b5c5b06"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4489), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4492), new Guid("602867ca-85c4-4a9f-9fcd-1ee9707362b1"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4493), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4496), new Guid("0ad0e701-a1d3-4f2c-a294-67f404d23698"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4496), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4498), new Guid("5f87d533-b0a1-4bb8-9361-77fcf57b1cc6"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4499), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4501), new Guid("d09142fb-556d-484f-a039-aa534c2152b3"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4502), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4504), new Guid("dfc7993a-dc36-4888-ac0c-6145aba6e2a3"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4504), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4507), new Guid("b3cf3646-f1a7-4c43-84d7-60e6470e6e82"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4507), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4511), new Guid("b99afb6d-a04a-4a09-b9c2-e727d4e87a57"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4512), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4514), new Guid("b5e984ce-c77b-4b29-a81e-52564295ce87"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4514), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4517), new Guid("950c8255-1b14-4397-ae74-8cf99045af18"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4517), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4454), new Guid("54f79a2b-5a56-4992-9006-b2a98f0e0359"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4454), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4457), new Guid("5f902432-3f1a-41bc-85f3-9affece01cc4"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4458), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4460), new Guid("732d1dad-5635-430f-a63b-18a89c2a872d"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4460), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4464), new Guid("d11e4742-9e57-4096-a345-47d40ca8576c"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4465), null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4543), new Guid("5f7c2a7e-f599-404f-bd18-4714a6b927b7"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4543) });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4546), new Guid("ce69fba5-96c2-49d2-a587-bc88f2f4789b"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4546) });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5028), new Guid("47341d46-eb56-4ad0-8a68-933d4f4c82bb"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5028), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5036), new Guid("e1105e6b-1a2e-419f-af73-e7e64023fc09"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5036), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5039), new Guid("42367457-cac4-47f7-9da1-1b4635bfaa74"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5040), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5042), new Guid("a7a0c349-6efb-4af3-a67f-33d17192cfd7"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5043), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5045), new Guid("c34850a3-4912-4fe1-af24-92981c0729c4"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5046), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5069), new Guid("87eee395-7c82-42f7-80ec-9eeb837a0e56"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5069), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5073), new Guid("e2ad9229-05c7-4936-9c49-ecc816a0df3d"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5074), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5076), new Guid("b5825fe9-0864-4c80-b5cd-0a157633c0da"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5077), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5082), new Guid("77286fda-7caa-497f-8280-1fdf51a8aa18"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5082), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4994), new Guid("e2109e8c-8e09-4425-944e-a47c5398ef9d"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4995), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4998), new Guid("53d36338-b5ec-4171-8f97-f7a7a2f68c60"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(4999), null });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord", "Parent_Id" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5001), new Guid("722940a4-d256-4ba8-818c-0ab300146013"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5001), null });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5225), new Guid("bd3dc3f2-aa1c-4602-b5ce-f267c5f06072"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5229), new Guid("b37e4a22-ff21-4b3b-b574-184f2125a218"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5231), new Guid("98daaab0-f097-426f-a796-a8cda0dfbb90"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5234), new Guid("4df770b5-94ba-48f3-bfff-227feac5c606"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_ProcessScenario",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5239), new Guid("1cde15d0-8373-4941-973f-6e82c9184696"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5140), new Guid("75e61570-23ea-46f0-a394-b5244dd2ca87"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5143), new Guid("adac8cad-d2c1-4761-b513-9470e8ec71c3"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5146), new Guid("96ceed5b-d82d-46af-a589-35c696cd9012"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5151), new Guid("e3a251eb-949b-4243-a152-b288f35bb966"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5193), new Guid("91063d60-2b3b-4cce-be9e-a7281dae66e1"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5196), new Guid("efa8ee8e-39a6-4701-aaf3-0bc1f6fc2e70"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5199), new Guid("831e0f62-1933-4db2-9269-0311cfd226b4"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5111), new Guid("77e43a2c-5f89-4955-8ab0-66e0bfc27f6e"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5115), new Guid("e96c9227-b911-4082-853a-c538a3122b67"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5117), new Guid("4ab4f1c4-b43e-4766-9131-5123efd98246"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5120), new Guid("2ef71d0a-9614-450c-aa3f-68686675d88c"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5262), new Guid("3956909a-594f-40b2-a7f4-7442473f6543"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserPosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "LastUpdatedRecord" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5265), new Guid("04f02903-eae4-4619-89be-c62c06c8d6fe"), new DateTime(2023, 7, 10, 11, 32, 6, 177, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_Parent_Id",
                schema: "Facts",
                table: "F_WorkItem",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_Parent_Id",
                schema: "Facts",
                table: "F_Scenario",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_Parent_Id",
                schema: "Facts",
                table: "F_Endorsement",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_Parent_Id",
                schema: "Facts",
                table: "F_Condition",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_DsblRecord",
                schema: "Facts",
                table: "F_Case",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_Parent_Id",
                schema: "Facts",
                table: "F_Case",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_Parent_Id",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_Parent_Id",
                schema: "Dimentions",
                table: "D_TagType",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_Parent_Id",
                schema: "Dimentions",
                table: "D_Tag",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_Parent_Id",
                schema: "Dimentions",
                table: "D_Process",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_Parent_Id",
                schema: "Dimentions",
                table: "D_Entity",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_D_Entity_D_Entity_Parent_Id",
                schema: "Dimentions",
                table: "D_Entity",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_Entity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Location_D_Location_Parent_Id",
                schema: "Dimentions",
                table: "D_Location",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Operand_D_Operand_Parent_Id",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_Operand",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Position_D_Position_Parent_Id",
                schema: "Dimentions",
                table: "D_Position",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_Position",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Process_D_Process_Parent_Id",
                schema: "Dimentions",
                table: "D_Process",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_Process",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ProcessState_D_ProcessState_Parent_Id",
                schema: "Dimentions",
                table: "D_ProcessState",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_ProcessState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Role_D_Role_Parent_Id",
                schema: "Dimentions",
                table: "D_Role",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_Role",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_Tag_D_Tag_Parent_Id",
                schema: "Dimentions",
                table: "D_Tag",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_Tag",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_TagType_D_TagType_Parent_Id",
                schema: "Dimentions",
                table: "D_TagType",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_TagType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_UserInformation_D_UserInformation_Parent_Id",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "Parent_Id",
                principalSchema: "Dimentions",
                principalTable: "D_UserInformation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Attachment_F_Attachment_Parent_Id",
                schema: "Facts",
                table: "F_Attachment",
                column: "Parent_Id",
                principalSchema: "Facts",
                principalTable: "F_Attachment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Case_F_Case_Parent_Id",
                schema: "Facts",
                table: "F_Case",
                column: "Parent_Id",
                principalSchema: "Facts",
                principalTable: "F_Case",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_F_Condition_Parent_Id",
                schema: "Facts",
                table: "F_Condition",
                column: "Parent_Id",
                principalSchema: "Facts",
                principalTable: "F_Condition",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Endorsement_F_Endorsement_Parent_Id",
                schema: "Facts",
                table: "F_Endorsement",
                column: "Parent_Id",
                principalSchema: "Facts",
                principalTable: "F_Endorsement",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Scenario_F_Scenario_Parent_Id",
                schema: "Facts",
                table: "F_Scenario",
                column: "Parent_Id",
                principalSchema: "Facts",
                principalTable: "F_Scenario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_WorkItem_F_WorkItem_Parent_Id",
                schema: "Facts",
                table: "F_WorkItem",
                column: "Parent_Id",
                principalSchema: "Facts",
                principalTable: "F_WorkItem",
                principalColumn: "Id");
        }
    }
}
