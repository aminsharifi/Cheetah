using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EditTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "L_Process_Strategy",
                schema: "Links");

            migrationBuilder.DropColumn(
                name: "RI_IsCancelled",
                schema: "Facts",
                table: "F_Request");

            migrationBuilder.DropColumn(
                name: "RI_PE_Level",
                schema: "Facts",
                table: "F_Request");

            migrationBuilder.DropColumn(
                name: "RI_RequestFinishDate",
                schema: "Facts",
                table: "F_Request");

            migrationBuilder.RenameColumn(
                name: "PN_ShowSupport",
                schema: "Dimentions",
                table: "D_Process",
                newName: "PC_ShowSupport");

            migrationBuilder.RenameColumn(
                name: "PN_RemoveRequestorApproval",
                schema: "Dimentions",
                table: "D_Process",
                newName: "PC_RemoveRequestorApproval");

            migrationBuilder.RenameColumn(
                name: "PN_ERP",
                schema: "Dimentions",
                table: "D_Process",
                newName: "PC_ERP");

            migrationBuilder.AlterColumn<string>(
                name: "CD_Value",
                schema: "Facts",
                table: "F_Condition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "L_ProcessScenario",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: false),
                    SecondId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_ProcessScenario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_ProcessScenario_D_Process_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Process",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_ProcessScenario_F_Scenario_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4494), new Guid("cc2b2025-a38f-4f02-9dff-08fbd3327613") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4672), new Guid("b66591b6-298f-4285-8f86-499950983b46") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4685), new Guid("f1a81718-5bfb-4259-acd3-f85f441dfeb4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4697), new Guid("af80ec89-9a59-4593-8316-2ccd70d441f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4709), new Guid("4e299214-abf1-4d7a-8bde-b6850d3d46ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4721), new Guid("af4e126e-ad0e-435d-b125-b1a6c41ec61a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4739), new Guid("8e084f37-a50e-4927-8bb0-7fd512a61670") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4752), new Guid("1f4cda9d-79a2-4ffe-8945-d66ec4777896") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4763), new Guid("14a5b92b-ecbc-429b-9bce-4d5a41511e36") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4891), new Guid("6e161a01-cba1-495b-943a-cdcad48defb2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4908), new Guid("018ad093-bbb2-4c19-9ab6-585bf8007177") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4920), new Guid("36bee525-e83f-451f-96a1-3033211b3a45") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4934), new Guid("2afce260-43bb-4f90-bbe8-67be1d2ce5f3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4946), new Guid("fb15af21-283d-4a42-9978-36e72a3f7620") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4961), new Guid("39486825-e4fc-4762-89c5-b477bd616160") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4990), new Guid("90e32538-8af8-42a2-aa9f-123d194e7619") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5002), new Guid("281ebb6b-c055-4c7d-9024-0cca7ae5f696") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5014), new Guid("eb3a721b-dadc-42a1-9b2b-cb9964bbfefc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PName" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5027), new Guid("91bead6f-6cfd-4b9b-913c-f75ef20759f9"), "L_ProcessScenario" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5039), new Guid("f4e70d47-748e-4868-9317-3c180a1b806d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5051), new Guid("d3b3d5eb-8653-4641-874a-0b451458ac25") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3240), new Guid("e7c34b95-5a02-4c12-88d7-31610096f569") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3272), new Guid("242e3501-d82c-4622-9628-790437c6c4b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3279), new Guid("66222177-d3d7-4ee6-a474-277ec09d0a5f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3321), new Guid("937f38c5-4b6e-464c-aa00-45a344095a44") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3330), new Guid("89a54d29-cd13-4676-81e5-14dd1ae22267") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3340), new Guid("43b3ae66-9c6c-4f82-94fb-cf57db77eff1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3348), new Guid("3ae9a00e-0fad-479d-aaa9-b4aa1067db40") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3356), new Guid("0510f15e-a541-426c-ac0a-967eaab42279") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3422), new Guid("8d5471f6-84d9-4e83-b6c2-a423829bc7d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4319), new Guid("3756535f-0b2e-409a-89c6-ee8750f16880") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4400), new Guid("8ebb3331-90bd-4190-b47f-e2aedd6d2fdd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4410), new Guid("7478a4ca-715b-4a29-9829-bd3130ac4c55") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4418), new Guid("00b29a8b-ceb6-47ca-bf3f-f5cc3363a7bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4427), new Guid("246418f0-4a8b-499e-af9b-109e31b5a9fb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4439), new Guid("5c7daae4-35dd-4f61-94ec-30bf5972908b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4448), new Guid("535b4896-2f03-4726-bc10-6b622a6c715d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(2529), new Guid("f554db6d-14e5-43fc-b20c-815278f0261f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(2678), new Guid("22f9dc09-53a5-41cf-a9a4-838fc6980e3c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(2705), new Guid("56d3b0ea-fa03-4c69-9b6f-1e923c53621d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3168), new Guid("b13aac8a-12fc-4bb3-b804-95e49a467a7a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3182), new Guid("73503c98-0a49-40bd-8864-b30aefda325d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3195), new Guid("73cfcd3e-5be4-4e8c-94a3-5ed47e664e1c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3204), new Guid("4cf3e0d1-78ac-48ff-a171-02249122bbe9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4246), new Guid("2f1b669c-91c4-4525-a39e-577a14679b13") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4258), new Guid("8a1f48c4-fcef-40f5-ac5c-28eb1589aea9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4271), new Guid("65bc5477-7de0-4bf2-87ca-3e7e77518513") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4280), new Guid("1effd2d9-9928-4978-96f5-f7c170de4447") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4288), new Guid("e746424b-694e-4149-ad13-c9e5e0cc3d6b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3590), new Guid("c93ca8e3-4f8e-44c2-b46b-feb244532543") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3600), new Guid("ea27e1d2-14bc-4ae2-b0c8-36ef52c8e2e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3609), new Guid("3ff06613-b2a8-47bb-b6ce-5758eb4e40fa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3617), new Guid("545defe7-6be8-4e6f-ae3b-e4d578506dab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3625), new Guid("ac117280-c86a-4188-8b99-ed386c901068") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3635), new Guid("07b10b04-7e2a-437c-a820-87b48d9bc009") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3647), new Guid("adf22e6c-f3c7-420b-a7c5-31535679f6ba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3656), new Guid("1895fff2-372d-4f9c-a3e1-5aaadb060ace") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3665), new Guid("fb5fea6f-9393-4603-8283-80f5711b727e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3673), new Guid("d2a1ff31-89bb-4f20-a8b3-da90c17c55ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3479), new Guid("a5a68a83-a818-40c4-a984-48c1dc71f8bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3487), new Guid("2b45c40c-58d9-43e5-b2c3-0e3b25f4396e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3499), new Guid("176da24c-c62c-4694-b09c-adb570eebaf7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(3507), new Guid("b6533246-878a-4f31-81dc-8f6dff5bd827") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4174), new Guid("7e9b10fa-94e8-49a2-b990-4a055187d2ea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(4202), new Guid("f0cf9d02-0d27-441f-8ea3-627a404c75eb") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5213), new Guid("6fbe0332-b0c9-4083-b6b5-1ce043164fdb") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5232), new Guid("7b1a554a-ed72-4bef-896c-55466ba8240b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5241), new Guid("55d7c9d1-3624-42d3-9102-4b24e66201ec") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5250), new Guid("8c2312c7-aabd-4f85-849a-dffaeff93762") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5258), new Guid("16a98964-db36-48fc-8d99-a29fac955521") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5294), new Guid("28cd6d4e-9049-4841-8d18-0c98667bb0a4") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5307), new Guid("95463b8e-4192-4951-8dc6-c11d626538bd") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5317), new Guid("976bee14-e229-4866-bf4f-ef1d38b8c02e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5325), new Guid("8def8bd3-f789-4159-b604-5162f2a54d73") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5113), new Guid("262f91dc-a30d-405b-8810-9a924269a328") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5127), new Guid("6165dcc7-0b73-4a20-b646-825082d600ed") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5178), new Guid("4321ee8c-befc-4d2d-a7f5-2731ccf1345d") });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_ProcessScenario",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5511), false, 1L, new Guid("3c94e573-b638-402f-9ae4-8c2251eb1f60"), 1L, null, "تعریف/اصلاح مشتری-راهبرد سه", null, 1L, "CustomerDefinition-Strategy3", 3L },
                    { 2L, new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5521), false, 1L, new Guid("3a95221f-a42a-404d-b698-8de3be985694"), 2L, null, "تعریف/اصلاح مشتری-راهبرد یک", null, 2L, "CustomerDefinition-Strategy1", 1L },
                    { 3L, new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5529), false, 2L, new Guid("ea72bdaf-938b-44f8-8196-3ae65291da28"), 3L, null, "مجوزهای موردی-راهبرد یک", null, 3L, "PolicyCenter-Strategy1", 1L },
                    { 4L, new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5537), false, 1L, new Guid("78a0f4b7-9aac-457c-908e-026d12b9dd5d"), 4L, null, "تعریف/اصلاح مشتری-راهبرد دو", null, 4L, "PolicyCenter-Strategy2", 2L },
                    { 5L, new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5589), false, 2L, new Guid("c38e78a8-3434-4bfa-9123-29a70f27a9bf"), 5L, null, "مجوزهای موردی-راهبرد دو", null, 5L, "CustomerDefinition-Strategy2", 2L }
                });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5398), new Guid("e2b46398-7ffc-4d2b-b6fb-f3b225bb294d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5409), new Guid("47955120-d079-4675-ab82-2e9220102e91") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5418), new Guid("a2a1c80c-0faf-4f3e-8e42-bad014527658") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5430), new Guid("cec64666-978d-4425-8541-b6ca8914c095") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5438), new Guid("75a1b9e0-8495-470f-906c-28c6f85abef7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5447), new Guid("0721253f-8d56-484d-9959-82e4fc1c216f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5455), new Guid("e2f87739-5050-463b-8620-656393647882") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5359), new Guid("69f699ed-b98e-4c17-bce8-ce1d9f2474b3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 8, 15, 24, 6, 793, DateTimeKind.Local).AddTicks(5370), new Guid("43feb089-410f-44b6-a138-108c07022dee") });

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_CreateTimeRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_DsblRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_FirstId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_LastUpdatedRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_PCode",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_PERPCode",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_PIndex",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_PName",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_SecondId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "SecondId",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "L_ProcessScenario",
                schema: "Links");

            migrationBuilder.RenameColumn(
                name: "PC_ShowSupport",
                schema: "Dimentions",
                table: "D_Process",
                newName: "PN_ShowSupport");

            migrationBuilder.RenameColumn(
                name: "PC_RemoveRequestorApproval",
                schema: "Dimentions",
                table: "D_Process",
                newName: "PN_RemoveRequestorApproval");

            migrationBuilder.RenameColumn(
                name: "PC_ERP",
                schema: "Dimentions",
                table: "D_Process",
                newName: "PN_ERP");

            migrationBuilder.AddColumn<bool>(
                name: "RI_IsCancelled",
                schema: "Facts",
                table: "F_Request",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 101);

            migrationBuilder.AddColumn<byte>(
                name: "RI_PE_Level",
                schema: "Facts",
                table: "F_Request",
                type: "tinyint",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 103);

            migrationBuilder.AddColumn<DateTime>(
                name: "RI_RequestFinishDate",
                schema: "Facts",
                table: "F_Request",
                type: "datetime2",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 105);

            migrationBuilder.AlterColumn<string>(
                name: "CD_Value",
                schema: "Facts",
                table: "F_Condition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "L_Process_Strategy",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: false),
                    SecondId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_Process_Strategy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_Process_Strategy_D_Process_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Process",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_L_Process_Strategy_F_Scenario_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6179), new Guid("6ea563a3-5197-42cb-8842-c7ad522e3454") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6264), new Guid("3a45ac19-eb96-4340-af85-1a17e0d6064f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6281), new Guid("84371d1e-7a07-4b29-917a-0f49a80b9bec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6294), new Guid("f96e80dd-4bb9-4441-94e6-e979155f37ec") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6309), new Guid("101c0614-ffaf-451c-a837-36f7d2d18876") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6321), new Guid("0474f6c7-832e-4f61-bc56-f28f0101f3c0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6334), new Guid("69ae50cf-433d-494f-b99f-322581818be2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6346), new Guid("aaf44fed-2c8d-46be-a9d7-19affce331dc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6359), new Guid("341ae56b-5d5a-46e0-a9d4-db69b04a5b70") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6461), new Guid("9519aba0-d051-4ca8-b2a9-4ba9bba3469b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6481), new Guid("0ddf4b85-eeea-4bbb-9021-2cc94a3a09a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6495), new Guid("03c27e4e-88fd-44b8-8bbc-f10063104dbf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6507), new Guid("0698e45d-1d20-4849-a04b-bb72bcfc1498") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6519), new Guid("54f6e130-c4c1-480a-9ce8-259ef7c4a60c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6532), new Guid("dc38f2b7-fdc9-4b09-b0cd-f7b7b2fba490") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6564), new Guid("c9bca721-44b1-4191-869a-bfc598f2bce9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6577), new Guid("4a9e2737-4f22-4036-adf1-dadeb5b6e2bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6595), new Guid("6db673bc-b5c1-4aba-b14c-9cd0857b8604") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PName" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6608), new Guid("24538636-e6b9-402a-b161-9b69e92f2092"), "L_Process_Strategy" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6620), new Guid("4b62eb59-6e09-4ee3-9926-cb0f84f9dd27") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6633), new Guid("a91fde53-33dd-49e0-887d-cd80df21ee43") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5380), new Guid("bf9dc4e8-8149-4ee6-b5ad-abece1e03b49") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5424), new Guid("857bb484-e1d4-4fb3-a20f-2f109e65bf23") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5432), new Guid("16ed6b9c-adbe-4540-b33a-f8c380220927") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5474), new Guid("06e4099d-aa7b-4b57-bf51-158770af2cce") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5484), new Guid("071785e3-03e3-48b1-b15b-535391c74de2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5492), new Guid("8db3155b-03d0-4071-b360-b255cb61dbf7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5510), new Guid("7fbf1de2-2deb-4006-a751-983477f21bdc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5519), new Guid("cfd4cbc9-3fa8-4666-b298-be7f13242369") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5588), new Guid("e129e444-0bae-4b8a-9e29-e1a24585823f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6079), new Guid("7f13839f-0057-460f-ab43-c265813757af") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6090), new Guid("382da151-cb17-452d-a368-d829396d5840") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6099), new Guid("e56b09bb-80a8-4db9-99bb-2e8efc5536ba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6110), new Guid("bc8e549a-7f65-449d-a50c-80cca29e1dfc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6118), new Guid("1a892697-dfaa-4cfb-82ee-c3a34441f47d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6126), new Guid("279cb621-3506-420d-9fb5-c5f768c408e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6134), new Guid("955d16c4-88df-45e6-a562-66e9780fcbb9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(4752), new Guid("88a79015-6556-467e-b6cc-d7fb2c367b1f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(4906), new Guid("ef29cdac-23d8-44d8-b896-08611adc98e2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(4916), new Guid("59bc0c87-dc1a-4de1-937b-9bde36b31c16") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5275), new Guid("098c5a68-97a2-4175-bfb3-30d8309aeb75") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5290), new Guid("ab1b788d-97dc-4c0d-9b67-60d06046f88e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5328), new Guid("13caae10-6dc9-49fa-8445-ddf3e9f5d31a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5338), new Guid("ee748a89-848a-41fa-a3f2-708e0ddafd32") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5967), new Guid("9db3f7d2-04fb-4b84-9d68-f14aa035d459") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5977), new Guid("71ddd80e-b832-4bc2-8bc7-43bbaac8a284") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5986), new Guid("2f12ceb8-cdac-422b-98cb-ee035f0fd650") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5994), new Guid("9c34f1e3-a4e0-489d-99c3-c73e12af447a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6002), new Guid("17193c13-7290-4235-894e-c1c43abf71c1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5769), new Guid("0e19bf72-f189-4e27-b939-77fd2cdd9d7d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5784), new Guid("c7c4954e-8ca9-4cb3-bfb1-74f0a3660962") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5793), new Guid("50948b25-134c-4732-9687-41bbaf6c242e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5803), new Guid("fdcc21f1-a26d-4ab8-a320-1c582ef7613f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5811), new Guid("44f91ce4-5828-4af3-9c31-aa63eff0cdad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5819), new Guid("1148b799-4760-4603-aaa1-73f06638ba31") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5828), new Guid("3b1af4d2-4d13-4ed0-9d2a-eff0cff09c09") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5837), new Guid("b31e8011-4e95-466d-aacd-b5913b78d45b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5845), new Guid("2181fa2e-5370-44ae-9ec5-9dc203a50307") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5856), new Guid("20b1d467-f569-4cb1-acbe-e4edcb85d898") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5653), new Guid("b4b52de0-d592-4caf-a03a-d74c8c6190aa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5664), new Guid("37ed04b6-e144-4b5a-a698-ae7d17a76452") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5672), new Guid("dfd762a2-c2a9-409e-8aad-c1a80f280427") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5730), new Guid("002b453c-5b28-4bfb-a206-ed26a2cedfd2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5918), new Guid("41bd4d7b-34a6-4a57-884b-39c8f7699e6d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(5930), new Guid("6ec3c951-c05e-485e-a270-54ea519e85de") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6797), new Guid("f23051f6-a389-4984-ba29-f194a3fc6a27") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6814), new Guid("d7cce165-cfde-42e6-8378-f7b75ca3445f") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6823), new Guid("ea5d465d-fcb6-4fd3-a067-b4c6e7bb9d27") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6833), new Guid("7d39838d-1224-4124-9eaa-89a987ac86de") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6841), new Guid("997bad2f-29a7-42b6-8efc-a22d895099ee") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6885), new Guid("bd78b3cd-5402-457d-9f67-a0191ba0e9f4") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6905), new Guid("b04eb2b3-1270-4a35-ad84-25cb1d08b7f2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6914), new Guid("88b925dd-277c-462d-baea-db4e2d0aa78a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6922), new Guid("53656e5e-2c6b-4bf0-a15b-927d96fea4fa") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6698), new Guid("ff49fc1b-3119-4862-bd26-e069e00df281") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6751), new Guid("7e0e858b-6bd9-4e19-a48e-afcc7b971341") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(6760), new Guid("d4710041-a711-4ea6-8b04-d80917281278") });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_Process_Strategy",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "FirstId", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "SecondId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(7193), false, 1L, new Guid("eb018e47-9bc8-4ad0-9691-fde83cbdc001"), 1L, null, "تعریف/اصلاح مشتری-راهبرد سه", null, 1L, "CustomerDefinition-Strategy3", 3L },
                    { 2L, new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(7204), false, 1L, new Guid("ffb10161-edb6-489b-9fce-01bebacfe1fd"), 2L, null, "تعریف/اصلاح مشتری-راهبرد یک", null, 2L, "CustomerDefinition-Strategy1", 1L },
                    { 3L, new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(7253), false, 2L, new Guid("810ea91e-777a-4b43-9b75-fa0009eca599"), 3L, null, "مجوزهای موردی-راهبرد یک", null, 3L, "PolicyCenter-Strategy1", 1L },
                    { 4L, new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(7264), false, 1L, new Guid("82e284fb-7f2b-473c-ae7e-39cc18daef61"), 4L, null, "تعریف/اصلاح مشتری-راهبرد دو", null, 4L, "PolicyCenter-Strategy2", 2L },
                    { 5L, new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(7272), false, 2L, new Guid("81eb7aa9-1eac-4ced-9ad2-1a50601c9724"), 5L, null, "مجوزهای موردی-راهبرد دو", null, 5L, "CustomerDefinition-Strategy2", 2L }
                });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(7075), new Guid("4c523263-ce81-4fd2-9682-34558c1133dd") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(7084), new Guid("fa6ddde6-8303-4832-b60d-07fc663dbc3e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(7094), new Guid("8e63af26-0f01-42db-a60a-96570cc30955") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(7103), new Guid("91f7573d-be80-47f8-a42b-6bcc71059721") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(7111), new Guid("d188e2cb-cafd-478e-8fef-8839760ad4d4") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(7119), new Guid("48e8d22c-6b5f-4b71-9d83-713b488ebb8c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(7130), new Guid("ab4cc72c-7191-45ac-a563-769d525c46d5") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(7028), new Guid("a1ebe181-699c-41a3-8e07-61e2e0a4d81d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 7, 14, 47, 19, 730, DateTimeKind.Local).AddTicks(7040), new Guid("6b195674-bdd3-4069-9a59-ddd010943fb2") });

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_CreateTimeRecord",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_DsblRecord",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_FirstId",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_LastUpdatedRecord",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_PCode",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_PERPCode",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_PIndex",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_PName",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_Process_Strategy_SecondId",
                schema: "Links",
                table: "L_Process_Strategy",
                column: "SecondId",
                descending: new bool[0]);
        }
    }
}
