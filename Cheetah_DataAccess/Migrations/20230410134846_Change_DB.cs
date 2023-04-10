using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Change_DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessEndorsement_D_ProcessState_PSE_ProcessStateId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessEndorsement_D_RequestTitle_PSE_RequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_D_ProcessEndorsement_PSE_ProcessStateId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PSE_ProcessStateId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.RenameColumn(
                name: "PSE_RequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "PSE_EndorsementPatternId");

            migrationBuilder.RenameIndex(
                name: "IX_D_ProcessEndorsement_PSE_RequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "IX_D_ProcessEndorsement_PSE_EndorsementPatternId");

            migrationBuilder.CreateTable(
                name: "D_EndorsementPattern",
                schema: "Dimentions",
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
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_EndorsementPattern", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_EndorsementPattern_D_EndorsementPattern_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_EndorsementPattern",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(4609), new Guid("84aac5a5-1a68-4319-968e-eda5ceb6fc6f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(4759), new Guid("7c62a314-9551-409f-b30d-9c8b5e93a166") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(4768), new Guid("0cdfbaed-7f90-474f-8e54-41ac51074f97") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(4796), new Guid("af04c50e-77b6-42ff-9303-fa0a35b6a920") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7218), new Guid("ebceeb73-d493-49d2-890a-5f5e1f9f16b9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7549), new Guid("0f8bc68b-7e67-4fb3-a73d-c4a0a563f95e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7573), new Guid("49728bc8-49f4-4582-9e71-aedb88aef75c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7586), new Guid("437890b5-979d-4096-9932-1ff3fec90570") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7599), new Guid("8c3a71c8-06cc-4f00-b028-f1c52cc989b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7627), new Guid("169a039d-dbf6-41e0-8510-21802e5368de") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7640), new Guid("2e710d60-fe92-4d2c-82e6-370c6569acb9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7652), new Guid("03438534-3302-426a-8242-bb701bc8283c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7664), new Guid("793a426f-c9da-43dd-a69d-cf64875dbc8e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7680), new Guid("788bfec3-461c-4727-9fce-9c46bfee3f78") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7696), new Guid("95681f92-fdb8-4241-85fd-5c94845cc491") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7708), new Guid("5ecd6b84-f962-4ea6-b364-3d1ad87e019a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7720), new Guid("6fe1d672-3533-4017-9a32-5b3019df040f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7735), new Guid("ee1a8bca-1e7d-4389-b55f-0ec0ad38b757") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7747), new Guid("d50c2db6-748a-477c-bcd5-4b0b0f7dc164") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7834), new Guid("f4d76f4b-e107-4735-b6e6-c0c330d1fdc7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7846), new Guid("081b7b67-c17c-4662-8164-955f799aa718") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7860), new Guid("31d6da21-a603-4b79-a77a-ff6902a895ab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7876), new Guid("ad1bcc35-1dae-4e1f-8fb0-24d04a90a3d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7888), new Guid("92154240-1105-46cf-8294-7fba80a2998f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7900), new Guid("eba4defe-4178-4e46-8f13-2ddfe663d75e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7923), new Guid("71996130-f7e4-4852-9fab-c1cf88e8ecce") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7937), new Guid("6086f4fa-7f01-4d47-9069-da9a76d87d3f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 304L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7952), new Guid("bb8b8cfd-befe-46a3-afe1-631af9d5e202") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6349), new Guid("b688524d-0796-41f1-95bf-a69d4c5d17de") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6516), new Guid("1b1e8395-226d-43d9-8bff-1de44d700534") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6530), new Guid("cd42a99e-a6f5-447a-b7a1-424f855245ac") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6538), new Guid("41c62130-d6ff-4cc5-af63-ff3a01fc3d5b") });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_FieldType",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[] { 5L, new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6546), false, new Guid("f5d6d1bc-0ef5-4613-911d-dabc3bca41ca"), 5L, null, "دودویی", null, 5L, "Boolean", null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6217), new Guid("ab4de927-b892-4abd-8e9e-6e5b4b718840") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6244), new Guid("94c0fa87-d4aa-469c-ae37-13fccaf3b5e5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6271), new Guid("4e152900-dc11-4bb1-9b97-8246cfea40b6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6663), new Guid("ce74054c-9b9d-439d-b7ae-43a836b0ad6a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6672), new Guid("0a87339e-f4ae-46a7-946c-d172e60203e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6704), new Guid("60e04166-027d-4bc8-8ed1-fca11573dd41") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6718), new Guid("53a35ad7-6f2d-4ed0-a5a8-fc818ebaa4d7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6726), new Guid("32ef0b93-cd7b-4c69-9f0e-9fb491b61b98") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6733), new Guid("d4ec1fe0-fbbe-4f00-a2b1-af51784ab721") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6829), new Guid("41573ff2-dfd0-4d14-9f93-f0bdd6d837ce") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6840), new Guid("c4ceda89-7f98-489c-b067-dd7f13285541") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6869), new Guid("2928ae73-b1d1-49c8-a38c-a95fcf456fdc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6881), new Guid("7cece7bd-490e-4ac8-be01-0ed7e4fa0160") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6889), new Guid("43fe23f4-9051-41fd-b485-a7ff09b8374f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6898), new Guid("bf33651a-ae16-4780-9797-e2699fb76a67") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6906), new Guid("76d4ed52-bf3c-4559-b672-d8f4d83ffeb0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6914), new Guid("da21c91d-cb8b-4e85-8373-106b0958389d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6922), new Guid("1e772993-209c-495a-a5fc-aa67803b444b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6929), new Guid("58c6cc30-715c-4412-833e-fcae275619fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6775), new Guid("ceb348cd-aaf7-4f33-a0ec-1d10954c81c3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6785), new Guid("fa673966-0be3-485c-90a7-1a79d02f2ccf"), "اقدام‌های فرآیندی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6792), new Guid("cd3239d3-5b0d-4587-8f2f-b0459212d5af") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7118), new Guid("fd3d47d8-44c8-4c71-bef1-d2f7e139ea2c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7131), new Guid("d6b93e75-7241-49b6-a171-ab25e2da0582") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7139), new Guid("056fb997-0584-4569-8020-17ec4637ac0c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7147), new Guid("2e616e66-3088-465e-a218-99297ac1c929") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7154), new Guid("4eb633bb-ff3a-4143-b86c-7d3ebe7b5b75") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7163), new Guid("85b28c0b-2b66-4bc3-98d9-61b225bd741b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7171), new Guid("e09623fa-5c2f-434a-9904-6d9242ff3712") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6077), new Guid("5e7a2d9e-f0a5-4465-b7ff-fe6fd05e9e0e"), "در دست بررسی", "Ongoing" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6133), new Guid("bd197d5a-0d79-424f-a577-97823530d838"), "منتظر بازنگری", "Editing" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6142), new Guid("34f16fb2-cc00-47ec-809c-c4671d5bfd73"), "کامل شده", "Completed" });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_ProcessState",
                columns: new[] { "Id", "CreateTimeRecord", "DsblRecord", "GuidRecord", "PCode", "PDescription", "PDisplayName", "PERPCode", "PIndex", "PName", "Parent_Id" },
                values: new object[] { 4L, new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6153), false, new Guid("e5c52e28-418c-4cc9-b7f9-f5e9e7851014"), 4L, null, "ابطال شده", null, 4L, "Aborted", null });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(5794), new Guid("36abbb97-f682-4bb3-a987-024db5d751f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(5926), new Guid("73d393df-17a4-4b02-8700-c88a8e46ae8c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(5994), new Guid("0f046dad-894e-4bb2-b2de-ab93aff03541") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7032), new Guid("d090f76b-fcc3-49ed-9d06-5a0b643aa03b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7052), new Guid("20976d46-3ada-43fc-aadc-f97f03485bde") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7060), new Guid("ad00f5cc-7e20-421d-be18-d95b112f5d1e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7068), new Guid("fd305e20-362d-4137-b2cb-e44490d9ad93") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(7076), new Guid("26d4a90d-da63-4694-9fb1-b6b89172d7ba") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6986), new Guid("b2a1c977-906b-4706-8f98-708f1d97ee5a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(6998), new Guid("cea53a7e-6933-4830-af65-0b76a6e68510") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(8083), new Guid("7f762638-0d66-4c88-a947-6f35c42fc22b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(8092), new Guid("187e0520-a9ec-4d0d-8747-87c90273fc62") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(8100), new Guid("5457540a-f813-4f8a-841f-87df4d273a0e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(8107), new Guid("7da82863-76ee-4cce-aab3-d4f7163c8ee2") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(8115), new Guid("06a85239-7f9d-40e7-858c-eb49cb5e6119") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(8123), new Guid("38ff5261-bd78-4ea0-876a-20ad07a250a3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "FirstId", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(8131), 5L, new Guid("793b2968-cfc7-4ffa-a2c8-995738324a6b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(8161), new Guid("47e19958-8a04-4ea6-a46f-9a5c2078dff2") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(8173), new Guid("bdf90df8-ac35-4bc6-9c1c-099a546029a2") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(8181), new Guid("3bd0c897-fb0a-4038-bc07-053b31b0e2f9") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(8189), new Guid("7bfed4c7-7cb1-48a1-aa48-0a7b4011c7a5") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(8032), new Guid("d15ef75e-426c-496a-b098-2135a39d44cd") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 18, 45, 54, DateTimeKind.Local).AddTicks(8045), new Guid("33c1b128-117d-45bd-9d87-09fdc9050247") });

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_CreateTimeRecord",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "CreateTimeRecord",
                unique: true,
                descending: new bool[0],
                filter: "[CreateTimeRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_DsblRecord",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "DsblRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_LastUpdatedRecord",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "LastUpdatedRecord",
                unique: true,
                descending: new bool[0],
                filter: "[LastUpdatedRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_Parent_Id",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "Parent_Id",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_PCode",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "PCode",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_PERPCode",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "PERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_PIndex",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "PIndex",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_EndorsementPattern_PName",
                schema: "Dimentions",
                table: "D_EndorsementPattern",
                column: "PName",
                unique: true,
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_D_ProcessEndorsement_D_EndorsementPattern_PSE_EndorsementPatternId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_EndorsementPatternId",
                principalSchema: "Dimentions",
                principalTable: "D_EndorsementPattern",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_ProcessEndorsement_D_EndorsementPattern_PSE_EndorsementPatternId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement");

            migrationBuilder.DropTable(
                name: "D_EndorsementPattern",
                schema: "Dimentions");

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.RenameColumn(
                name: "PSE_EndorsementPatternId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "PSE_RequestTitleId");

            migrationBuilder.RenameIndex(
                name: "IX_D_ProcessEndorsement_PSE_EndorsementPatternId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                newName: "IX_D_ProcessEndorsement_PSE_RequestTitleId");

            migrationBuilder.AddColumn<long>(
                name: "PSE_ProcessStateId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6086), new Guid("d38c326d-f6aa-4cf0-90f2-3ba112cbafbd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6237), new Guid("74b582e7-2ad8-41fb-bd1a-1d83a986d070") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6245), new Guid("820eebdd-58e2-45a4-91ad-2a667c2f41e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Area",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6279), new Guid("b4a5576e-80b3-478f-ac3d-a6595108edad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7890), new Guid("e1b0caa7-4f6d-425a-8cdf-32c0a85ea5e4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8158), new Guid("053f0ca5-8a7b-4320-82a3-46acc315ea2b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8178), new Guid("7bc8a75c-573e-4977-b6ff-35231253b3d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8238), new Guid("a92de4d6-7105-4ab4-b946-54e5b44deea5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8255), new Guid("59f927d3-e8f9-4df4-a3f0-e199d3f6ab65") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8273), new Guid("d1837c09-9bcb-4c9a-9d39-bc82db35ac0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8285), new Guid("612f60a4-fa82-4531-bb2a-d842e13c00f8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8299), new Guid("ce74b10a-44ce-45a2-a220-934156b551fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8311), new Guid("e32fecf6-ea63-4605-84a5-3b4ccfe31c7a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8323), new Guid("4407faae-f0be-4b7f-b58e-728d2497d8ff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8337), new Guid("06300986-588c-431e-90b6-ad3e8f130500") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8350), new Guid("806251de-fa22-4592-8c2d-ab54b3c8bdcb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8362), new Guid("9f7b8e38-fb97-43e4-8588-78f4c702e447") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8377), new Guid("04544191-71f7-4c63-988d-1317bf5fcb66") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8390), new Guid("261fd432-3630-42e0-9087-511512ee2925") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8415), new Guid("33e59f4a-9f69-4ad2-9cdb-01d8769fb45d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8428), new Guid("5765f5f0-b834-43b6-967a-dcf3586968cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8439), new Guid("645c3c10-d571-48bf-a0d5-45b1060ba62b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8454), new Guid("227fcea5-c41d-4c0e-a7ac-e1ba96b7d6d2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8551), new Guid("91be60fc-161c-49db-b00a-45df7079cc3a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8564), new Guid("5489b4ae-dcc3-46d0-a410-2ae41a360a7a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8580), new Guid("e7e8b891-465f-45b7-8037-723acce3f478") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8592), new Guid("747ef774-0276-44fd-955d-4bdabc91c593") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 304L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8605), new Guid("17a06c29-653f-4a0f-b33f-4b13db0a71ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7045), new Guid("ac2649fa-02fd-4c56-bd2a-d3a13e88e51e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7056), new Guid("653d09e7-8f38-4ef8-bdb2-034cd0802395") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7169), new Guid("44768d6e-9489-4bc2-b269-af996ecce65b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_FieldType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7178), new Guid("d3872de7-2a18-4cc0-97f4-61ebb39df732") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6982), new Guid("ae07d785-0ed2-42ce-8879-cc5cb4add084") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6992), new Guid("9574fdb7-b132-4d48-9964-1c3f62fdc2a0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7001), new Guid("c39b47f3-5898-45dd-be19-4d87065df0e6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7275), new Guid("92190e1c-f84a-43f2-8b06-101a3457d6cd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7286), new Guid("19620bc7-856a-4fdf-8067-f1e13313d34e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7293), new Guid("ea9be265-a148-45a1-90dc-8e41aa3717fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7302), new Guid("0a66712c-ec2e-458c-853a-fdca336c44bc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7309), new Guid("f61019d5-b092-43d5-900a-e50217002d15") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7317), new Guid("ac5ac734-1e82-42e6-8576-c2be76eb5364") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7414), new Guid("82c72495-240e-43e4-9bb8-1659780c7d8b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7424), new Guid("00f47034-a6c7-4af8-b526-5d41bab612b4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7433), new Guid("2fa54be8-f37e-489b-b8b2-82ecdf4f3ba6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7446), new Guid("c6681869-5329-43bb-a95a-db6e30727945") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7471), new Guid("70b59178-c49b-42b5-88c9-ab1e0d328850") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7482), new Guid("d0add361-09b3-43bb-a5a1-6c341c85cc9f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7491), new Guid("ea0bc1d9-f49f-4247-b78b-304defa504d8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7500), new Guid("47131c7f-fd4e-422b-8d87-ca971872e257") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7507), new Guid("f6925604-6dd6-4167-9c74-f797bd14f4df") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterList",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7515), new Guid("65cb0f61-e6e3-439c-b8ca-2b77556a8ce0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7366), new Guid("7fad5778-49d8-4bdf-8563-94c18f62a153") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7378), new Guid("6662e39b-861c-4b02-ae19-18b7425bfb93"), "اقدام های فرآیندی" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ParameterType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7386), new Guid("061bc64a-c653-4a16-ae2f-a3af089e6e1f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7804), new Guid("c26a475e-5394-41a6-baaf-5405b192bfbf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7814), new Guid("7ee485a1-296b-4643-9fbf-8a50298470f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7821), new Guid("c5a96960-6f0d-4f59-927c-410244dcf0f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7830), new Guid("d5a18943-032c-4235-9d2b-2dbd08031d6b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7842), new Guid("a77d74cf-2101-430d-83cd-48b843c2518a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7851), new Guid("76a33fdd-3064-4cda-8230-f60ebab1ecc6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7860), new Guid("b91fa67f-78e9-40fe-ba28-b4d72748601f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6895), new Guid("792e9790-68da-4e2a-bd9f-e0a617a9d946"), "در حال اجرا", "Running" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6934), new Guid("acc12f18-3d60-47ca-9886-e61ee35a67c1"), "کامل شده", "Completed" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6943), new Guid("f9da13b9-e05d-4eb7-93b6-63900cfabe49"), "ابطال شده", "Aborted" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6789), new Guid("0eb98eea-39e7-470b-ac01-2fea04c04a23") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6825), new Guid("3198e9bf-9256-4514-be47-610988c0a427") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_RequestTitle",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(6833), new Guid("c69f3d6b-5caa-451c-9528-ad130a04ae13") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7719), new Guid("2ed3213a-790f-4aef-9c83-bbfb058cf7ce") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7736), new Guid("953d4578-9848-4110-909f-2b1e190f6410") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7744), new Guid("6f66af5c-ed0d-48a8-8e72-87a05791eecb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7753), new Guid("9550ddf4-cb62-4534-b766-fc0273665fb5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7761), new Guid("bf30681b-ac0f-4bdc-bfc8-31d0af088d5a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7622), new Guid("46435ae5-7234-45a6-a868-93f366a8db8c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(7631), new Guid("c4ca451f-9679-4fc0-abf0-f24b312f1486") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8735), new Guid("47f91f94-e8dd-42e8-99a4-3cbbf528f0d2") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8745), new Guid("de416578-6be6-4c66-97c3-cd432f5e072b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8753), new Guid("6e96e42b-9e87-436f-93c6-464da86ddfdb") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8765), new Guid("eece7b48-ece3-4ed3-8feb-d7038ffaf611") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8773), new Guid("e5fd1237-6bdb-4af0-ba89-66b3290cd083") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8782), new Guid("ee851d18-ecb6-4b08-8cbc-be604476aa44") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "FirstId", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8789), 4L, new Guid("071d988b-5b01-4c88-bc33-1efbf820c919") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8823), new Guid("5396da45-3eed-47d4-b04d-e579c655ea6d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8832), new Guid("97840008-8b86-4f28-8bd6-beb03a3118d9") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8841), new Guid("10ff2dc7-3dfd-4604-a1e3-4ba89308e938") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserArea",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8848), new Guid("ec57f7c2-e40e-429e-bb4a-874d2a36f139") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8684), new Guid("bc923314-4996-4b9d-af0a-4e0b49edfbfe") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 10, 14, 58, 21, 167, DateTimeKind.Local).AddTicks(8697), new Guid("708071b0-6d5e-4fae-96f2-1b86462a8fa8") });

            migrationBuilder.CreateIndex(
                name: "IX_D_ProcessEndorsement_PSE_ProcessStateId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_ProcessStateId");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ProcessEndorsement_D_ProcessState_PSE_ProcessStateId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_ProcessStateId",
                principalSchema: "Dimentions",
                principalTable: "D_ProcessState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_D_ProcessEndorsement_D_RequestTitle_PSE_RequestTitleId",
                schema: "Dimentions",
                table: "D_ProcessEndorsement",
                column: "PSE_RequestTitleId",
                principalSchema: "Dimentions",
                principalTable: "D_RequestTitle",
                principalColumn: "Id");
        }
    }
}
