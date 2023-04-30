using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Clean_Up : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7609), new Guid("7249e775-e035-4d10-8154-5d24833b1964") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7752), new Guid("e8421b1b-8771-4c65-a758-e091ee49c387") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7764), new Guid("d4624cc1-57aa-4305-beff-291482d92acb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7773), new Guid("8ea939a6-a26c-4d41-bdd6-3548a07974cd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7782), new Guid("a3bc34f0-07c4-4328-8639-965c2868e7cf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7793), new Guid("6e1939bd-73ee-4846-b910-533ea42d14c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7811), new Guid("1742a65d-f88f-43f6-b37d-bcd3126332b9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7820), new Guid("f08470f3-c705-4b1d-b615-091ed4f7f665") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7829), new Guid("ed70a572-a807-4d20-8b41-a79cd0e750fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7837), new Guid("3319ffed-762c-4499-937f-9ecf3d78a80d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7845), new Guid("5a13abf1-9565-435f-8509-69f859d6ccb7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7855), new Guid("753bbd8e-6766-4a12-b763-11e2a1ac2839") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7863), new Guid("bde5a9dc-332c-4667-833d-d38f42bb0251") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7874), new Guid("ebcef44c-b495-440a-b2cf-6df6a4f6c23c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7883), new Guid("05b034b2-a85d-4ca4-9a30-882c76da8a6c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7897), new Guid("9d01376c-3651-4509-ab6c-d3600dad7c78") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7905), new Guid("1bec83b9-5af2-4d51-9b56-c0b2d7e47b08") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7914), new Guid("c0f03d62-b57b-4431-96ba-28a80314e3bf") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7922), new Guid("4e56839f-589b-4446-943e-08aca86d4196") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7931), new Guid("179c974e-f3b1-489d-ad32-005af9f05695") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7939), new Guid("a8e892e3-de25-4edd-8c93-830c22ee8bc2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7130), new Guid("2c0cf95b-f39e-4ad2-907e-d9854ec9ec7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7136), new Guid("290275e5-b3a7-44a7-be0e-776110cb9869") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7144), new Guid("33beeb40-6b05-4fbf-b974-c671e23f80b2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7172), new Guid("e7b9335a-822f-40d1-ae3a-b8e907ac4e66") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7179), new Guid("c0f019e4-097b-403e-b65e-dbc87653e0aa") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7229), new Guid("eacc9673-b072-47d6-9ab2-49d196a53723") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7237), new Guid("82fc611e-0d61-401a-a8b8-08c1f25d7f76") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7252), new Guid("455e6220-9cf1-4eac-aa3c-a4783cf85d7b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7257), new Guid("8190dc88-b262-460f-bec7-611b3a3cf32b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7548), new Guid("d8e542e8-d0c8-4b01-ad53-8e9c246a435a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7555), new Guid("66643644-3ac5-45aa-a6c2-70b7f7c8ed86") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7561), new Guid("a17b4d86-3333-4c3a-acd2-ccb4873fd3d0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7566), new Guid("bccd50c8-d911-4f6f-9307-298231dc3c2e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7573), new Guid("f22cfc81-3c7b-4710-8f38-561aabe9c986") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7579), new Guid("75bfa9db-c96b-45db-a3c4-c4d2e52a217e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7584), new Guid("3f7b2dd2-9812-4cf1-89ed-ae295a3fc95d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(6986), new Guid("d9bfd27a-2b53-45b3-8dd3-c69a4af99020") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7012), new Guid("48b7ea4f-787a-4567-ad14-67faf45dac9d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7025), new Guid("59f9c3eb-2d65-4048-9705-b9e3001c5077") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7054), new Guid("9a7be939-968c-4297-8b90-9099d942bd14") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7061), new Guid("e5f12e38-08d1-4d8e-89ea-651184855000") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7093), new Guid("0e500ad9-a953-4795-87e5-1bf94d9ac5ed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7098), new Guid("e386bc9e-dbfe-4a47-8c27-0c7273eabd6d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7482), new Guid("70115c42-fed3-4ffa-a4ba-d5a01a4f4763") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7491), new Guid("58ae7606-e3e7-46d8-bc34-2ff126e45ada") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7496), new Guid("80e60973-27e0-488a-af2a-35400ce929fd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7513), new Guid("6915141e-1138-40c2-a7f7-11f0c0dd72a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7518), new Guid("37b38021-7434-45fd-9780-631b50032ae6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Strategy",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(6628), new Guid("291d0398-9b75-4b02-acf2-5fe68492f32a"), "راهبرد یک", "Strategy1" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Strategy",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(6749), new Guid("afae6bf4-cf6b-496b-a080-553ad9aa74b1"), "راهبرد دو", "Strategy2" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Strategy",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(6756), new Guid("85400b36-b6bd-4b47-b2c7-fbfa89d71075"), "راهبرد سه", "Strategy3" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7342), new Guid("61e8e643-f0a8-49ae-85be-bb7e2032f0ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7352), new Guid("99af643a-f315-4b82-9ad2-8107d1c1edad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7357), new Guid("f5d9fa9b-a784-420f-88d7-dfcb2bf730c3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7362), new Guid("ccfe7b49-802f-4b51-983d-ddfe1db0fd11") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7368), new Guid("7e6381a4-9339-4c05-8fea-5468ee4eff5b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7375), new Guid("6d376906-c116-473c-a4da-d17e37e13f0c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7387), new Guid("e98e8152-e771-436a-87f7-764267e57cf3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7403), new Guid("a5c2b5d8-e665-4b35-a1e8-3868af607713") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7408), new Guid("976e2051-d719-4771-bb4e-9e42276242f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7414), new Guid("32412266-2d06-42c5-b292-a5478a3bb9c2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7296), new Guid("a6226016-9b40-4c43-8dfb-9948242de8c4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7305), new Guid("cd41bfd8-636a-421b-83e4-8ca43c5cb420") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7311), new Guid("0fde8920-87c1-4a15-a7eb-826efdc17cd4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7316), new Guid("ceb22d8e-2672-4b9d-aee4-29ff1848b69d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7444), new Guid("24be8b18-cf07-4dd2-8dfd-52c0169a7564") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(7451), new Guid("c6b7875d-23c6-48b7-adf2-cf2bca5c865a") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8103), new Guid("6331899c-46e2-480c-97b2-9855c08476ee") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8109), new Guid("b92504b8-8edc-44ee-9282-41df17fe3884") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8114), new Guid("3d63a396-5c29-4e2a-bd33-29b94d8b1069") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8119), new Guid("17d5940f-3a11-454e-9543-dfd8763c3cf9") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8034), new Guid("5c714f01-18a9-43fb-8a6e-50ec076bdb0f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8040), new Guid("47e83962-2a3b-4ee0-b4ac-c0dd5575368f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8045), new Guid("bf1abe36-8d6f-4940-80b5-92b2fe61be62") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8050), new Guid("08491315-220d-4515-ad6b-6a3afc4fc07d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8055), new Guid("80265e98-d5fd-436a-a56e-6c21a7d7064f") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8060), new Guid("b3145bb6-c21a-46b8-abde-b2d75e4b4a27") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8068), new Guid("30f933f5-d0f1-4fae-a869-55b42575d3a0") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8000), new Guid("acd8cb5d-4b17-47ef-987d-26c1ae658457") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 14, 0, 44, 651, DateTimeKind.Local).AddTicks(8008), new Guid("82f70abc-7640-4971-9777-ca16c141d2bc") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9167), new Guid("9d8fd051-220b-496b-a694-47b4d15c0fab") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9388), new Guid("7dac1f8b-260a-4c85-9a27-3029945712d9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9408), new Guid("4bb85e9a-689f-4b41-a4a0-1934d9fd2906") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9419), new Guid("7c56927e-5ac4-4972-8f8f-ac1a78e83480") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9433), new Guid("bab7aa5c-0194-42ae-9a54-b667c4d65cef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9446), new Guid("c6ab375c-587d-4391-9c62-4639b69c7aef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9465), new Guid("15f3dfad-d18f-421a-a89b-5c5393c0dac6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9478), new Guid("3eea0dbc-161b-4af6-bcde-a216517be101") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9492), new Guid("b535b07d-04e2-45d5-bb09-3383bc2bb478") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9517), new Guid("4fcefdec-e89f-47e0-a9f0-25cfc9869dc0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9531), new Guid("fa2020b5-bf2a-4c58-9611-839301a8b312") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9544), new Guid("fc2577a3-33f0-467d-b693-6256123075ae") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9558), new Guid("82d17fda-27ec-4828-b2e6-b88890918c66") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9570), new Guid("078eaa24-c891-46e2-9f45-ffba6e4672f5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9587), new Guid("fdbb6e1a-bb19-4e7b-a9aa-776e113e2141") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9609), new Guid("28729a9c-b6ea-4f8c-8a02-3f8bb3ed9906") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9621), new Guid("fec61037-bdfa-4adf-8099-4e1071913e23") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9633), new Guid("66615571-8c83-4b09-b20e-1cad01ccfc3b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9643), new Guid("808d65cf-7238-4e25-98f5-899a879fc5be") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9655), new Guid("bcf5852d-fd05-43b7-b997-7d941770e688") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9670), new Guid("4bfc9ec2-bfcb-4396-983e-f91fe9da9013") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8289), new Guid("b9b36afe-b701-47ba-828c-167b9e988318") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8299), new Guid("e7224dde-d548-4a52-b02a-12e32adb5ad5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8308), new Guid("1cabec59-0666-4bb7-8b87-3b03f7f667ad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8354), new Guid("62f68c89-3d2d-410f-964b-5ab2e3d971dd") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8365), new Guid("654a1433-15ee-4e17-9d23-792b5a9bef0c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8542), new Guid("14b44762-6166-4993-bc35-bbd020e8d557") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8553), new Guid("c8372165-d44f-42ae-bd12-becb2ad547a7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8560), new Guid("b8c4c87e-76bf-4ae1-a9b4-e935c2789e4c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8569), new Guid("15219968-602c-4db1-879a-ebf3d4c92cad") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9052), new Guid("dd0bd028-d038-4091-adbe-66a7e37ff1eb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9075), new Guid("269524f2-2794-4d91-b35b-a100bdb99a75") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9083), new Guid("05de22c0-5823-450f-959c-33d2d9a4ef96") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9091), new Guid("718b1d3e-c7f9-43f6-8ca0-4d62423ce829") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9099), new Guid("00b222c0-7edc-48c6-8c39-b8207f93ccbe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9111), new Guid("bdfedf10-4b5e-48eb-9488-07df4f83a1ed") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9121), new Guid("30fa6404-abca-474d-8414-b641aa49928b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8096), new Guid("00a7f711-d101-4c31-b3a5-bb4299b00050") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8114), new Guid("302c6f12-eb2f-4866-97d3-2d8d816665c3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8144), new Guid("6b34b80e-fef2-485b-9ce4-60bf699d843c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8191), new Guid("955b7aba-ecf9-4b80-90df-e99085a1ebff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8201), new Guid("a09fcda5-00d0-4f3d-a92f-5e8c2ae96992") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8236), new Guid("c3830e9e-8d50-435b-870d-6742389a669d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_ProcessState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8243), new Guid("ed2ddbf0-aedd-4aba-b968-22ea98da4411") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8933), new Guid("ff45a365-269f-4ec4-ab54-791cf9e069f2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8945), new Guid("db1d3536-2e8d-4447-b3a9-a8628e3c22a2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8958), new Guid("5d4a1a92-1719-4612-93d0-3c403d90c773") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8966), new Guid("84771926-b22d-4383-8316-ad4261bc33f6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8975), new Guid("949b3bbb-8fac-4eb6-969e-cda377218d8d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Strategy",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(7379), new Guid("b85041e3-fa18-435a-a0e5-be2ae25980b7"), "الگوی یک", "Pattern1" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Strategy",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(7519), new Guid("82573fbb-2706-40fb-bb6d-387eb92c9158"), "الگوی دو", "Pattern2" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Strategy",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord", "PDisplayName", "PName" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(7531), new Guid("ad8da789-0fe1-4098-8a60-9263d29b22a3"), "الگوی سه", "Pattern3" });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8712), new Guid("04c25938-7866-46fa-ae82-f164a998b316") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8725), new Guid("d56594a1-d2ab-46fe-8bc7-41e5bc5a1830") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8733), new Guid("9dd7b9fa-b09b-41a8-9430-9abace772258") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8742), new Guid("1cb7f84f-5c3a-479a-893c-21c0e4ec072d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8752), new Guid("03331814-aa65-4881-afee-1627cbd22c87") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8761), new Guid("24181150-a8e2-447b-93d0-efb1337ddf08") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8777), new Guid("140c86c7-de19-437f-8d7d-aefb032bbf83") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8804), new Guid("9bd42d08-4087-4abc-804b-19b76f425f89") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8814), new Guid("4eb68fe6-5e8c-46d1-b89f-35b47f9ba338") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8824), new Guid("7a8bdaf9-69b4-4375-8f5f-c729aabc1569") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8625), new Guid("88e99c99-5782-4d78-877e-7167f9627c62") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8636), new Guid("720cd5e6-181a-4d38-956d-185555e89d35") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8650), new Guid("d993899a-0e0c-4e26-af10-45b4c710b925") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8669), new Guid("e951f72c-3f25-49b5-8c39-557009ac8ec9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8874), new Guid("68c54a5a-1082-4432-a20c-4d58d68fdded") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(8886), new Guid("1b4b2fa6-2a7d-4273-a4e0-9e077e2c1aca") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9924), new Guid("6e2b6d41-9d51-4a98-a4f0-aa382ec18035") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9934), new Guid("46d038f7-2eff-4c6e-aa6b-54388fec5f88") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9943), new Guid("0eafb234-4a2d-46af-a9c5-4607847b4442") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_Process_Strategy",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9949), new Guid("892c02f6-56e5-4aac-af40-40168fc36178") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9815), new Guid("faea98d1-f2c7-44b6-afd0-fe97c77f9c0d") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9824), new Guid("98848ab1-494d-40e6-a86e-74aa11c4bf76") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9840), new Guid("6154a43b-ec88-456a-a310-09c750fd22f9") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9848), new Guid("21bdc805-c2e4-4d56-b620-ea6fafde2bb6") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9856), new Guid("e1b25fb1-81be-4c66-a57e-e3b08914c69c") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9863), new Guid("13cb4df9-3235-423e-ba3e-7eea78735af3") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_RolePosition",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9869), new Guid("fc149227-d7c4-437d-a686-977ba42c6052") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9764), new Guid("e5a92884-5fe6-4520-a6d5-9dd0bf568b26") });

            migrationBuilder.UpdateData(
                schema: "Links",
                table: "L_UserLocation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateTimeRecord", "GuidRecord" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 56, 44, 259, DateTimeKind.Local).AddTicks(9779), new Guid("e253d41b-e002-414d-aa63-418473085856") });
        }
    }
}
