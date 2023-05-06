using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Edit_Review : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_Tag_D_TagType_TG_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_F_AllReview_F_Review_AAP_Current_ReviewId",
                schema: "Facts",
                table: "F_AllReview");

            migrationBuilder.DropForeignKey(
                name: "FK_F_AllReview_F_Review_AAP_Last_ReviewId",
                schema: "Facts",
                table: "F_AllReview");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Request_F_AllReview_RI_AllApproveId",
                schema: "Facts",
                table: "F_Request");

            migrationBuilder.RenameColumn(
                name: "RI_AllApproveId",
                schema: "Facts",
                table: "F_Request",
                newName: "RI_AllReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Request_RI_AllApproveId",
                schema: "Facts",
                table: "F_Request",
                newName: "IX_F_Request_RI_AllReviewId");

            migrationBuilder.RenameColumn(
                name: "AAP_Last_ReviewId",
                schema: "Facts",
                table: "F_AllReview",
                newName: "AR_Last_ReviewId");

            migrationBuilder.RenameColumn(
                name: "AAP_Current_ReviewId",
                schema: "Facts",
                table: "F_AllReview",
                newName: "AR_Current_ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_F_AllReview_AAP_Last_ReviewId",
                schema: "Facts",
                table: "F_AllReview",
                newName: "IX_F_AllReview_AR_Last_ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_F_AllReview_AAP_Current_ReviewId",
                schema: "Facts",
                table: "F_AllReview",
                newName: "IX_F_AllReview_AR_Current_ReviewId");

            migrationBuilder.AlterColumn<long>(
                name: "TG_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1984), new Guid("d8fcc775-cf37-4b41-a076-a7faeca12891") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2050), new Guid("dfbe223b-8e50-4716-8dc3-18d4c712c223") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2066), new Guid("4cef0636-5090-42fe-9ee8-7b8dac2cd5f0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2078), new Guid("6d193b98-f4eb-4e28-9917-f9a38849ee73") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2092), new Guid("8803df6e-00e5-456b-aeca-5157b9b71491") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2104), new Guid("34400374-897d-4bec-ac1e-0cc40b4b923a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2126), new Guid("b919e635-a19c-49da-8881-523c24630d46") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2138), new Guid("c988f147-ee70-472d-888d-cfaf1f135ba0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2152), new Guid("8617a428-9317-44a5-ada0-dde8584e566e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2234), new Guid("950fb0ae-e137-483d-9c57-cfb607f906ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2249), new Guid("ef1d20e5-6ad5-4515-9878-17b25e73cf8c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2261), new Guid("b6b5871b-a772-43a8-93ef-a57384f6b504") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2273), new Guid("84676081-4feb-4919-8004-047e41a275fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2284), new Guid("3bbac42f-a5ac-41fb-9988-34b93edd0072") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2302), new Guid("ba2c452d-09ba-4a01-b17f-2ceca30d437a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2335), new Guid("7e5260b5-0b4e-42ce-a16c-5d2529385ac8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2347), new Guid("8ee6ea43-d0e2-4246-925b-6566226a9975") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2359), new Guid("c7e09896-e717-4fd4-9dc8-637225838587") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2370), new Guid("c2e9cd34-e4a6-4cab-b52f-62ba90fa2bc0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2382), new Guid("b57ccd74-6a3a-41be-b202-06fd0694f1a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2396), new Guid("20428972-6c6d-4c1e-896a-a2577493a7ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(687), new Guid("7a854d01-c3b6-42c7-9503-d64a6e71cf92") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(727), new Guid("b8362bc4-658a-4b58-91b8-e83bc380ec0a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(735), new Guid("10bf6560-2219-4e9e-bc7e-a66fa756b852") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(775), new Guid("767d1a72-89c5-4af8-9a7e-c1bea2eeefae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(784), new Guid("6ac6c447-908d-44ce-bfdc-9625a7acd9fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(792), new Guid("440fa866-786e-44ad-99e9-e18853674f2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(800), new Guid("74a062d3-5089-447a-9e58-2f666727982f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(808), new Guid("c8cb1281-7e76-43a6-bc61-ec89a46ae6b5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(871), new Guid("6c5941c6-30bc-40f2-af23-e42e34360874") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1478), new Guid("14643019-34a0-4a15-ac8d-57efa7cda235") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1488), new Guid("a563fd76-5de1-4f46-937f-7ef6b25d37ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1496), new Guid("dbbf1ac3-13f3-491b-acc0-846b698ecc1b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1504), new Guid("c4206dbb-bf84-4458-bd29-67a91f639038") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1513), new Guid("058ab526-37ae-497c-86e2-71d8a77129be") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1524), new Guid("110edec9-0bda-44bd-84cd-fc3b4df332cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1850), new Guid("d10e1aa5-505a-4fe9-84c7-0ba5cea34e44") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(10), new Guid("1f2c8bc1-d284-411b-9c3c-d8c5c51ebdc7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(139), new Guid("76766c0b-477c-45ac-ad04-608365efa804") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(195), new Guid("dc75e7f3-c2e8-4d81-aa96-a167c8e01dc7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(612), new Guid("8c3bf0b3-8fbb-4274-b119-27bad931508c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(627), new Guid("c5897b3c-7d0b-4f32-a410-29c60a511c19") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(640), new Guid("39c0a3ba-53c7-46d5-84dc-0bd021bc2df8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(648), new Guid("7050751e-111a-4e94-8c84-c89e0d8d907f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1366), new Guid("1c9f8038-4447-4443-b3b6-b53010f028b8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1376), new Guid("ca371fff-596a-4f1e-bf37-12b37f063b67") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1388), new Guid("dc3f5727-7107-4e7b-b755-74a4785618a8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1396), new Guid("32353f26-7dd3-4930-bbb8-12094ec7d2ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1405), new Guid("e810d703-1cca-4bef-af98-66c25053cd24") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1104), new Guid("a11b5381-6e33-451b-8ef8-820eaff7c7c8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1116), new Guid("8f7c9633-05bf-4922-a6ef-c4af6aefec0a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1124), new Guid("12f36fc0-a36b-4fba-a093-a179d8223835") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1133), new Guid("5e8d9aa8-2019-41d6-871e-c5e4a6c1cba8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1141), new Guid("6bbd5636-1816-4bdc-b782-4b500da948f6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1150), new Guid("fd150c0e-0438-4598-8535-23f2fc4bb03f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1161), new Guid("33a68766-d91c-4d2b-92d3-7b35b96a3059") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1170), new Guid("9b15c62f-d76b-471b-a46e-a2b212e02631") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1188), new Guid("bf7fe823-ec32-4395-a685-c5b8a2bae160") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1197), new Guid("419695fa-feca-491c-9e09-0e6a353f3deb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(929), new Guid("ec03ef31-19ca-47dc-b3de-3da6660bbae7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(938), new Guid("efca8d6a-7f17-49f8-b168-c8a5c34641fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(949), new Guid("bdbf9779-b9bd-4707-8895-31afa74d1632") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(958), new Guid("f0f6d951-c048-439e-8d4b-6c4181b6bdf8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1321), new Guid("82ce6287-76b0-418f-9e96-8648df53bf4d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(1331), new Guid("24d404e9-bf4a-43e0-9d58-bdc02004b94d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2553), new Guid("1ed6e22b-3272-4023-9fbb-a2181fb5f139") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2566), new Guid("083243af-f317-4947-bd73-88ae649bc730") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2575), new Guid("0a2f2c24-4adf-4f96-a68e-36a2a1c8b4f3") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2584), new Guid("1ffb757b-7ddf-4979-b2ac-43d84adef6da") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2596), new Guid("db94dcb0-4674-4a49-9ee9-8d5ffa340820") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2632), new Guid("9c01a0f4-d317-47ca-ae40-fa56c8c7cae2") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2646), new Guid("ab4573c9-f16e-423d-b396-e7fc7fa98239") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2655), new Guid("87996053-9742-42b3-9213-2d75fd3f72d1") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2664), new Guid("28b85f65-dcff-49b6-9077-321fe8db540c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2456), new Guid("2137875b-a08c-4745-94ce-4d3b3b981148") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2509), new Guid("782e0669-113a-4790-b906-ba34a1affd9e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2519), new Guid("f9afe6b2-2e96-4ce3-9ae5-2c82307847fc") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2842), new Guid("e28dd09b-5758-4c7a-ad42-320a725d7323") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2892), new Guid("9ee099f9-bbde-4538-ac30-14e9500b6b80") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2901), new Guid("c99e5f86-cc40-4b75-80f0-41d54517e357") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2909), new Guid("e443275b-8b45-4561-8613-2376cdc0c459") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2921), new Guid("6072dab5-eadf-4949-9ec3-0c0854d45497") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2736), new Guid("79c3845d-4c44-4377-8d12-67bdc5a88fcd") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2745), new Guid("d6990995-df04-457b-8363-1cfdcc9249cf") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2753), new Guid("bb5bfbdc-f1ae-48e9-b06b-729a1c3fb7b7") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2764), new Guid("6d613c64-fd77-4df7-af09-af5ffc366155") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2773), new Guid("e63b1e3b-5026-4be7-905a-1aa30332a0eb") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2782), new Guid("3ecf1b67-78a9-41f3-9243-7b89ebef95ed") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2791), new Guid("58621270-1391-49ab-a8d4-4d2e7de474b2") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2698), new Guid("ff9b6010-74bc-4b6b-b71a-0bdcbed65285") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 13, 47, 0, 799, DateTimeKind.Local).AddTicks(2710), new Guid("b471493c-b15d-4396-975d-f8a3412868f1") });

            migrationBuilder.AddForeignKey(
                name: "FK_D_Tag_D_TagType_TG_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag",
                column: "TG_TagTypeId",
                principalSchema: "Dimentions",
                principalTable: "D_TagType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_AllReview_F_Review_AR_Current_ReviewId",
                schema: "Facts",
                table: "F_AllReview",
                column: "AR_Current_ReviewId",
                principalSchema: "Facts",
                principalTable: "F_Review",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_AllReview_F_Review_AR_Last_ReviewId",
                schema: "Facts",
                table: "F_AllReview",
                column: "AR_Last_ReviewId",
                principalSchema: "Facts",
                principalTable: "F_Review",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Request_F_AllReview_RI_AllReviewId",
                schema: "Facts",
                table: "F_Request",
                column: "RI_AllReviewId",
                principalSchema: "Facts",
                principalTable: "F_AllReview",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_D_Tag_D_TagType_TG_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_F_AllReview_F_Review_AR_Current_ReviewId",
                schema: "Facts",
                table: "F_AllReview");

            migrationBuilder.DropForeignKey(
                name: "FK_F_AllReview_F_Review_AR_Last_ReviewId",
                schema: "Facts",
                table: "F_AllReview");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Request_F_AllReview_RI_AllReviewId",
                schema: "Facts",
                table: "F_Request");

            migrationBuilder.RenameColumn(
                name: "RI_AllReviewId",
                schema: "Facts",
                table: "F_Request",
                newName: "RI_AllApproveId");

            migrationBuilder.RenameIndex(
                name: "IX_F_Request_RI_AllReviewId",
                schema: "Facts",
                table: "F_Request",
                newName: "IX_F_Request_RI_AllApproveId");

            migrationBuilder.RenameColumn(
                name: "AR_Last_ReviewId",
                schema: "Facts",
                table: "F_AllReview",
                newName: "AAP_Last_ReviewId");

            migrationBuilder.RenameColumn(
                name: "AR_Current_ReviewId",
                schema: "Facts",
                table: "F_AllReview",
                newName: "AAP_Current_ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_F_AllReview_AR_Last_ReviewId",
                schema: "Facts",
                table: "F_AllReview",
                newName: "IX_F_AllReview_AAP_Last_ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_F_AllReview_AR_Current_ReviewId",
                schema: "Facts",
                table: "F_AllReview",
                newName: "IX_F_AllReview_AAP_Current_ReviewId");

            migrationBuilder.AlterColumn<long>(
                name: "TG_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2989), new Guid("5b5c3bde-1cec-45d3-889b-316ba6aae890") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3057), new Guid("3eaf8dd5-7959-4cdb-a759-415df5fdc030") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3071), new Guid("33e5ca9f-71a5-4463-bd19-8ab0341563f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3083), new Guid("e2420fc7-3f1d-4fb8-b103-5abe83f15dd4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3134), new Guid("8d7d8370-04f8-4256-89a4-9fd1518e068f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3151), new Guid("ddc81066-83bd-4e4b-9a3f-ed91ffb4f987") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3163), new Guid("2882d4f0-1933-4d32-923e-439ef5c87d0f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3175), new Guid("82d5ff8d-c16a-4c3a-aa8b-6801e9d4d04b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3186), new Guid("2f20166f-a111-4ab9-9d32-bb4887260fd8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3201), new Guid("3804f496-eeeb-429f-8db5-6976716a7337") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3224), new Guid("51967193-6583-4aff-b475-4d5a8e8f3c8a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3236), new Guid("f475bd6e-f63d-4dbb-a931-651a1ce3be19") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3247), new Guid("f1c0b03c-9684-4c59-b830-be78f30338da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3267), new Guid("21bdb587-0b71-4788-9604-4d7717b53aad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3281), new Guid("b5cac494-e195-4d36-818a-f81906c9f9d5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3310), new Guid("10429029-9fd8-4cf3-812f-92a815c1d35d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3322), new Guid("b2557215-bd66-4612-91ff-da1152f4f520") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3336), new Guid("3eb8d1a7-4321-45b8-880c-5d96d978e39d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3348), new Guid("7b330965-e75a-4171-a768-96be1d3f9029") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3398), new Guid("96fc22c1-6cc5-43f9-86c5-8d4cce6cee2a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3413), new Guid("aacdbf56-56b2-4a68-aeaa-01a40562299b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2189), new Guid("9f7a022e-0d96-46fa-bb32-44e92f17ddcc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2235), new Guid("e0c5099a-eca6-4e44-89cc-86d5ff6f87fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2244), new Guid("3acaeb54-2a8e-4a18-bb92-008df17d894a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2373), new Guid("09bd0d9c-16c5-4bd1-a1be-d8b12da81722") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2385), new Guid("f79e58f7-8ce7-4c52-94a7-b5d5eb80dd6f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2393), new Guid("d0fd70b9-649b-478a-a8f4-a6772c8b23d4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2409), new Guid("6b967d92-2491-4eb6-85fd-e9fd7d3055b1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2417), new Guid("df681d20-0001-4764-938d-50dd281977fb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2490), new Guid("32ace0b1-358d-4c96-968f-238dd5d2512a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2905), new Guid("1a40b296-32fe-4222-86fa-f2f9df44a283") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2915), new Guid("b8dde870-744d-4426-a740-d9ef91ec8819") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2924), new Guid("3a4789cf-77de-473c-a751-73b7b235dc75") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2931), new Guid("636eb702-e0f3-4282-a975-bcca416f0c3b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2939), new Guid("8a0871e7-fd60-4e46-9e15-0d5a94da6d6f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2946), new Guid("e7696a66-9e6f-413d-a8dd-afd07a67794a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2954), new Guid("96358dca-8149-4828-b864-3b9aaa42cc4d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(1557), new Guid("88560a35-aeb9-45ee-b399-68e739fbd377") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(1696), new Guid("49070f46-640b-489c-a69c-9088ed58323d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(1705), new Guid("a48aa6b7-ff50-47c4-bc01-539701fe6dc3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2084), new Guid("0b005990-4407-469a-8585-0e08a2c5048b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2098), new Guid("168ef5ea-4e89-454e-b836-6013228861b0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2140), new Guid("a913935f-b017-4647-9be3-ee2094940c5b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2149), new Guid("eba9a8b7-9200-417d-b6c6-544913e8cfbb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2831), new Guid("ac316d27-65eb-4611-b50a-9f682e0afb1c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2842), new Guid("dab85a84-3d83-455d-af04-99511ac248c8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2850), new Guid("d8c10c81-3465-4f9e-9b7a-d35a795845c9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2858), new Guid("338a6b28-ca9e-46cb-a113-0aa3f112528a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2865), new Guid("ac36ddfa-e270-4efd-8141-c89e5ffa1204") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2612), new Guid("0b8a7570-26fa-40d0-a9f8-b8b2d046cbd8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2627), new Guid("21d5ed79-baf9-4f2b-97d1-eec056f544f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2635), new Guid("12891713-5fa5-4b45-ac7b-fb5d5c9f1748") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2643), new Guid("69067839-42d8-4ade-915c-4d68f7966e17") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2651), new Guid("722171bb-0ca7-4cbc-982d-f38a4ea142d0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2658), new Guid("77427036-b4c8-4e90-a219-928d25bdfad8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2668), new Guid("3333becf-08dd-4ffd-89fc-1931c7f70d0d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2676), new Guid("231fa6a5-55a3-4314-b4e7-aad4d3161e8f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2684), new Guid("d40b8498-4215-4682-befc-11bc6ac34fcb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2694), new Guid("c3511315-89b9-455c-99d5-799aaf387a8d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2556), new Guid("52cbdd06-918d-4867-85a8-d92ca0a6c5b1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2566), new Guid("b9489be7-da1c-48b2-afe7-00362a4c7373") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2573), new Guid("27cbf214-3dc1-4178-96f0-6672c1ee5750") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2581), new Guid("cc20b8a4-954f-4d8a-bed2-cd1dce2a0ebb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2745), new Guid("2508d175-f130-4ad3-8339-eb2c920c4dfc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(2755), new Guid("c31f1edc-a146-4b0e-a02c-3e95ef6d61e5") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3525), new Guid("a65f991f-a53f-4032-bed1-bc2d7523e705") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3543), new Guid("76a495af-94ae-4c73-a80e-f975dcaf6613") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3554), new Guid("fd4372a1-e47e-444c-b739-bb43f22a1e9a") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3563), new Guid("424843e9-9b0b-4e2f-947c-49ad35b7975b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3617), new Guid("32e279d4-0009-4838-b5bb-2891f9369b2c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(4501), new Guid("04759dd1-a3d9-4646-bb1c-0d7a3025bc72") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(4587), new Guid("96f39cec-1cd0-4d1d-921a-84030094542f") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(4597), new Guid("08b7b51b-eb02-4cdd-9139-762cee499e71") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(4605), new Guid("e219a4be-4b48-4120-8493-f3fae5f482c3") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3474), new Guid("e7dd5980-586c-4fad-80ad-95a0edf7f134") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3484), new Guid("2711fbef-f866-48e7-84ed-782ea09725ff") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(3492), new Guid("77f77d37-23c2-411c-a1b9-0b12615468be") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5318), new Guid("833f8fca-43d8-404f-9a87-d03f0a5f454b") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5329), new Guid("69fd4678-a3c1-4c63-94c4-3163cb9e4305") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5336), new Guid("8145e514-19de-4222-9ea9-2fae8aea84bc") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5344), new Guid("d5e1b174-6440-45bd-bc13-4cc400fb30db") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5351), new Guid("68689508-36ab-4db6-8826-5d1bfd3a3566") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(4840), new Guid("51899518-7884-4e1c-b800-64f1661beb0c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(4999), new Guid("b63cf637-463b-4dbe-af7c-2af3323289a3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5048), new Guid("405f2607-790c-4c81-8532-e03d0e6f172f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5073), new Guid("a7f2ad5d-6597-4a28-b568-f2d82d7b195e") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5087), new Guid("f1ed4c6b-444f-474e-ab35-1dab8578f212") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5150), new Guid("e9315fec-7b70-46d6-9aa9-9cc7e5434bd2") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(5182), new Guid("a2f2b797-02d0-46c7-aa69-c66f36ec01cd") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(4786), new Guid("1be4f137-f79c-4405-9c0c-a50b4a01bda9") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 5, 6, 12, 38, 24, 130, DateTimeKind.Local).AddTicks(4797), new Guid("c9cd85a7-06b2-4e29-8954-430a5c90426d") });

            migrationBuilder.AddForeignKey(
                name: "FK_D_Tag_D_TagType_TG_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag",
                column: "TG_TagTypeId",
                principalSchema: "Dimentions",
                principalTable: "D_TagType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_F_AllReview_F_Review_AAP_Current_ReviewId",
                schema: "Facts",
                table: "F_AllReview",
                column: "AAP_Current_ReviewId",
                principalSchema: "Facts",
                principalTable: "F_Review",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_AllReview_F_Review_AAP_Last_ReviewId",
                schema: "Facts",
                table: "F_AllReview",
                column: "AAP_Last_ReviewId",
                principalSchema: "Facts",
                principalTable: "F_Review",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Request_F_AllReview_RI_AllApproveId",
                schema: "Facts",
                table: "F_Request",
                column: "RI_AllApproveId",
                principalSchema: "Facts",
                principalTable: "F_AllReview",
                principalColumn: "Id");
        }
    }
}
