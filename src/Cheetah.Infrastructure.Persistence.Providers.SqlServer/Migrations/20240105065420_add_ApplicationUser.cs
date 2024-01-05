using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class add_ApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 485, DateTimeKind.Unspecified).AddTicks(9651), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 64, DateTimeKind.Unspecified).AddTicks(9999), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a93d996a-2c6c-423d-ac18-f6f00c215f4e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d4b6dcc9-0162-4756-a6b7-b723cfde0695"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 485, DateTimeKind.Unspecified).AddTicks(9121), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 64, DateTimeKind.Unspecified).AddTicks(9605), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 485, DateTimeKind.Unspecified).AddTicks(2562), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 64, DateTimeKind.Unspecified).AddTicks(4038), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("2d41c668-cfdf-43c6-a7be-691dcec975a7"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a259f670-0e45-4113-84d4-14cf4d19235c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 485, DateTimeKind.Unspecified).AddTicks(2183), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 64, DateTimeKind.Unspecified).AddTicks(3771), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 484, DateTimeKind.Unspecified).AddTicks(7186), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 63, DateTimeKind.Unspecified).AddTicks(9508), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("7c65f02f-599a-4d7f-858e-82036495d4a5"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("68925cc8-40c9-4781-b7f7-ad408004d2bc"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 484, DateTimeKind.Unspecified).AddTicks(6756), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 63, DateTimeKind.Unspecified).AddTicks(9121), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Endorsement",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 484, DateTimeKind.Unspecified).AddTicks(667), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 63, DateTimeKind.Unspecified).AddTicks(3843), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Endorsement",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a111cc73-8595-494e-af8a-6604ca47ef65"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5cda0b1a-38f8-48ff-9a6b-9990812d43e0"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Endorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 484, DateTimeKind.Unspecified).AddTicks(185), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 63, DateTimeKind.Unspecified).AddTicks(3417), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 483, DateTimeKind.Unspecified).AddTicks(3321), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 62, DateTimeKind.Unspecified).AddTicks(7528), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("09c5da5c-5076-42ca-a5f1-77d292232b55"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("efe491e8-33ea-4b2d-8e48-4e6e5ddf161d"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 483, DateTimeKind.Unspecified).AddTicks(2759), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 62, DateTimeKind.Unspecified).AddTicks(7069), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 482, DateTimeKind.Unspecified).AddTicks(5392), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 62, DateTimeKind.Unspecified).AddTicks(675), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a8d42752-e00b-4478-abad-ad43695c7a85"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f931aaa0-fd9a-4db0-9da7-89e80f569c2c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 482, DateTimeKind.Unspecified).AddTicks(4862), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 62, DateTimeKind.Unspecified).AddTicks(276), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 481, DateTimeKind.Unspecified).AddTicks(8282), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 61, DateTimeKind.Unspecified).AddTicks(1796), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b1d51b71-056a-4543-8967-d30cd9e3a0eb"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a757e115-5378-40b3-ae54-a456680121a2"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 481, DateTimeKind.Unspecified).AddTicks(7892), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 61, DateTimeKind.Unspecified).AddTicks(1530), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 481, DateTimeKind.Unspecified).AddTicks(3130), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 60, DateTimeKind.Unspecified).AddTicks(7542), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c73f307b-5477-422d-9ce1-fe29ceb0e413"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("156dd855-ed89-41b2-a1df-c0114ecf3c18"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 481, DateTimeKind.Unspecified).AddTicks(2801), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 60, DateTimeKind.Unspecified).AddTicks(7267), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 480, DateTimeKind.Unspecified).AddTicks(7848), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 60, DateTimeKind.Unspecified).AddTicks(3270), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c7fae702-d14f-4fbe-9178-756a517099a7"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("441bf4ce-4c39-443f-ada8-79c6227a786c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 480, DateTimeKind.Unspecified).AddTicks(7506), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 60, DateTimeKind.Unspecified).AddTicks(2949), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 480, DateTimeKind.Unspecified).AddTicks(2030), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 59, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("ca3a9006-528c-4eac-a779-83c22a451a16"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("5a6ea714-470a-4879-84fa-8fde6e6e9f4e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 480, DateTimeKind.Unspecified).AddTicks(1668), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 59, DateTimeKind.Unspecified).AddTicks(8108), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 479, DateTimeKind.Unspecified).AddTicks(5365), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 59, DateTimeKind.Unspecified).AddTicks(4040), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("974c7822-49ce-4952-a4b5-bd42332055d9"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b044bf48-e4ce-4400-9c87-95a2e8238e38"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 479, DateTimeKind.Unspecified).AddTicks(4938), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 59, DateTimeKind.Unspecified).AddTicks(3745), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 478, DateTimeKind.Unspecified).AddTicks(9587), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 58, DateTimeKind.Unspecified).AddTicks(9377), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("28045822-90b3-4f5f-a1cb-3ba7e6225fb5"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("03e4398b-798e-4cff-a0a7-05ce9b2425c9"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 478, DateTimeKind.Unspecified).AddTicks(9191), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 58, DateTimeKind.Unspecified).AddTicks(9047), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 478, DateTimeKind.Unspecified).AddTicks(4444), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 58, DateTimeKind.Unspecified).AddTicks(5103), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("6ed158be-4fbb-4210-9284-29cf582789f0"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c8de1eda-3f71-4772-a24c-0bcd84ea3725"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 478, DateTimeKind.Unspecified).AddTicks(4017), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 58, DateTimeKind.Unspecified).AddTicks(4833), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 477, DateTimeKind.Unspecified).AddTicks(9247), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 58, DateTimeKind.Unspecified).AddTicks(782), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f1e61168-3a9b-4efd-91b7-927290834d26"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("315ab37b-108e-483c-94ee-0f53c780d81a"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 477, DateTimeKind.Unspecified).AddTicks(8915), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 58, DateTimeKind.Unspecified).AddTicks(513), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 477, DateTimeKind.Unspecified).AddTicks(4163), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 57, DateTimeKind.Unspecified).AddTicks(6551), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("14c64b7b-5a2e-4c1f-acf7-ed8526814b70"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c9770757-851a-4abb-84f8-ff0d206c0802"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 477, DateTimeKind.Unspecified).AddTicks(3823), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 57, DateTimeKind.Unspecified).AddTicks(6278), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 476, DateTimeKind.Unspecified).AddTicks(8851), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 57, DateTimeKind.Unspecified).AddTicks(1989), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("6d99c0b1-b8ae-41f9-a6d6-28762dcef54c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("45d5dc10-b8e5-4974-8da9-0088fcb6c9e2"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 476, DateTimeKind.Unspecified).AddTicks(8402), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 57, DateTimeKind.Unspecified).AddTicks(1610), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 476, DateTimeKind.Unspecified).AddTicks(2924), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 56, DateTimeKind.Unspecified).AddTicks(7121), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d684ceac-1cb7-4f90-98bc-5494bab30e01"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f8d40bb3-64eb-4982-a1bd-b71b7a3ca458"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 476, DateTimeKind.Unspecified).AddTicks(2468), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 56, DateTimeKind.Unspecified).AddTicks(6738), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 475, DateTimeKind.Unspecified).AddTicks(7513), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 56, DateTimeKind.Unspecified).AddTicks(2500), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d25f3af3-4811-46d1-84bf-ed5829119a6e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a0840e6d-792e-4e55-967b-757121f131c9"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 475, DateTimeKind.Unspecified).AddTicks(7004), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 56, DateTimeKind.Unspecified).AddTicks(2152), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 656, DateTimeKind.Unspecified).AddTicks(7629), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4a0eb535-128e-435d-9d96-f0f3b7fbb10c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 656, DateTimeKind.Unspecified).AddTicks(7644), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6228bb4a-3777-4e7e-8328-066b2fb3c83c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 656, DateTimeKind.Unspecified).AddTicks(7647), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d8dd1c8a-c7bb-4212-8b05-9cc29372addc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 656, DateTimeKind.Unspecified).AddTicks(7650), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cbcdcea7-e774-4f24-848b-bbc085494038") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 656, DateTimeKind.Unspecified).AddTicks(7653), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4996d858-f922-4e79-9969-83be6ba1bce8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 658, DateTimeKind.Unspecified).AddTicks(9962), new TimeSpan(0, 3, 30, 0, 0)), new Guid("33ddab95-eb30-4249-a44a-1d8d8b51f4e0") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1060), new TimeSpan(0, 3, 30, 0, 0)), new Guid("537b76e5-c2ac-487f-989b-9d08fa6185b1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1197), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ab7fb52e-016b-4014-81fa-6c88f5ca2b5b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1220), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5e0a67c4-91fe-464f-a45c-9ae71253ac62") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1242), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2f6e2056-f019-44f4-9648-483a7daba521") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1260), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1fb96116-c674-4db2-8cac-18f5971e5e95") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1281), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3808826b-8824-4614-a836-409907fe64d1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1357), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d357a6ed-ffca-4be1-91d9-76cab925e0f3") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1380), new TimeSpan(0, 3, 30, 0, 0)), new Guid("44f67aed-d897-49bb-b785-aa62e86c7ae7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1399), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fef79da8-5658-4ba9-96ac-4d0134ee0f56") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1424), new TimeSpan(0, 3, 30, 0, 0)), new Guid("39655b4d-e6a0-4ba9-85b2-484aad270110") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1442), new TimeSpan(0, 3, 30, 0, 0)), new Guid("35d56d4d-c040-4402-ad82-cbb0162aa5ff") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1459), new TimeSpan(0, 3, 30, 0, 0)), new Guid("134345d5-2b85-4d5a-b6e7-df4582fa6a96") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1508), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6d18719d-b5ee-4ffc-a7fd-57528d5c1a65") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1598), new TimeSpan(0, 3, 30, 0, 0)), new Guid("00660e2e-6d9c-48f3-a7fe-299126da87f9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1619), new TimeSpan(0, 3, 30, 0, 0)), new Guid("07aae384-7000-4582-a322-ed6fc0b06291") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1637), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a0bf791f-1bcb-4463-9116-393c3202ddca") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1655), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f53be520-3f44-49b0-951b-6cb1982934e1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1685), new TimeSpan(0, 3, 30, 0, 0)), new Guid("335a629e-dfab-444b-b9ec-4a6d5f11b36c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(1702), new TimeSpan(0, 3, 30, 0, 0)), new Guid("42c21d76-6601-4786-a66c-3e7f53074833") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 662, DateTimeKind.Unspecified).AddTicks(6101), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a87cdfa0-21b2-41b2-95fc-31b20c09953f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 663, DateTimeKind.Unspecified).AddTicks(2379), new TimeSpan(0, 3, 30, 0, 0)), new Guid("00108949-82f3-42eb-a8e9-bb19e7849ee8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 663, DateTimeKind.Unspecified).AddTicks(2398), new TimeSpan(0, 3, 30, 0, 0)), new Guid("15a0b454-0725-496a-806f-645da915ac7c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 663, DateTimeKind.Unspecified).AddTicks(2403), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e5d92e26-c880-4315-939a-2d789474796a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 663, DateTimeKind.Unspecified).AddTicks(2407), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0cbdb86a-5cbe-4bd3-ae87-bafbc8329405") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 663, DateTimeKind.Unspecified).AddTicks(2410), new TimeSpan(0, 3, 30, 0, 0)), new Guid("251d096b-395e-43c6-93d8-72029998b5ef") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 663, DateTimeKind.Unspecified).AddTicks(2423), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2af9bac7-e233-4a68-9cc7-dd9982b96663") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 663, DateTimeKind.Unspecified).AddTicks(7904), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4a69f9d8-0d90-4848-9f5b-41521d195523") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 664, DateTimeKind.Unspecified).AddTicks(1886), new TimeSpan(0, 3, 30, 0, 0)), new Guid("44d9982b-c332-471e-b1dc-75eeee2d40a5") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 664, DateTimeKind.Unspecified).AddTicks(6399), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8f3cfd04-a3bf-4bc9-a831-be4b0a2c8f32") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 664, DateTimeKind.Unspecified).AddTicks(7089), new TimeSpan(0, 3, 30, 0, 0)), new Guid("74a7c385-36ab-4405-aae2-2f1f1e161dc9") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 665, DateTimeKind.Unspecified).AddTicks(5793), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5826e09b-4cf6-47fa-8cdb-8ebf7c842c0b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 665, DateTimeKind.Unspecified).AddTicks(7313), new TimeSpan(0, 3, 30, 0, 0)), new Guid("51435551-c286-45fa-a1c1-9219888b62b1") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 665, DateTimeKind.Unspecified).AddTicks(7500), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f1f6f823-c2ba-4361-a5ea-960d44a5aa05") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 665, DateTimeKind.Unspecified).AddTicks(7524), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0283df95-600a-424f-a8b7-4ddeaec9df3b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 665, DateTimeKind.Unspecified).AddTicks(7533), new TimeSpan(0, 3, 30, 0, 0)), new Guid("78946db3-f233-427d-99db-56aab92e3c35") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 666, DateTimeKind.Unspecified).AddTicks(3882), new TimeSpan(0, 3, 30, 0, 0)), new Guid("21b1d163-7e12-40c5-ab69-64d93581454c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 666, DateTimeKind.Unspecified).AddTicks(3921), new TimeSpan(0, 3, 30, 0, 0)), new Guid("fdf6b092-4bbc-48a1-960a-27533fdf5d43") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 666, DateTimeKind.Unspecified).AddTicks(3929), new TimeSpan(0, 3, 30, 0, 0)), new Guid("581ab79f-5a48-4772-a13c-150ce332e781") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 666, DateTimeKind.Unspecified).AddTicks(3935), new TimeSpan(0, 3, 30, 0, 0)), new Guid("537ba92b-61a8-4f00-b49d-a83a1f1088d4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 667, DateTimeKind.Unspecified).AddTicks(211), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6839c170-b550-405c-b10f-fa389aee254d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 667, DateTimeKind.Unspecified).AddTicks(254), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b7e1f7bc-3ba6-4c10-9f52-e7fb572a4707") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 667, DateTimeKind.Unspecified).AddTicks(274), new TimeSpan(0, 3, 30, 0, 0)), new Guid("156f5aae-560b-4064-a9ef-d3c9fcb3424e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 667, DateTimeKind.Unspecified).AddTicks(283), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a3860bd2-2da1-46d7-a8c7-273a28749d4d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 654, DateTimeKind.Unspecified).AddTicks(1073), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a765257e-33ad-46bf-9798-671299d6c064") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 654, DateTimeKind.Unspecified).AddTicks(4628), new TimeSpan(0, 3, 30, 0, 0)), new Guid("eff6714a-0b8d-4bbb-86c6-a7121ceb710d") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 654, DateTimeKind.Unspecified).AddTicks(4906), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ea3d8923-c735-46be-ae31-8ebe953eb896") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 654, DateTimeKind.Unspecified).AddTicks(4926), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4a10ff64-c811-4dae-af2f-d1229a4e9f21") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 654, DateTimeKind.Unspecified).AddTicks(4930), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1c103589-0fc6-41a9-9d3d-5714c68bf21c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 655, DateTimeKind.Unspecified).AddTicks(5092), new TimeSpan(0, 3, 30, 0, 0)), new Guid("80365c20-e9f4-44c4-86fe-b9afad228d05") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 655, DateTimeKind.Unspecified).AddTicks(5852), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c4bbd047-135a-407b-ae1b-8f922435097b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 656, DateTimeKind.Unspecified).AddTicks(771), new TimeSpan(0, 3, 30, 0, 0)), new Guid("cf38966e-5552-4086-ada0-9f7d9047031e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 656, DateTimeKind.Unspecified).AddTicks(1516), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2083249f-a54b-4338-83d3-1b242cf1a651") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 656, DateTimeKind.Unspecified).AddTicks(1529), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5f52d7e6-2f78-4bc7-8cb3-c7cab3520545") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 656, DateTimeKind.Unspecified).AddTicks(1533), new TimeSpan(0, 3, 30, 0, 0)), new Guid("15a785ac-3e36-47ae-a9ab-17cae73c318e") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 18, 656, DateTimeKind.Unspecified).AddTicks(4487), new TimeSpan(0, 3, 30, 0, 0)), new Guid("3a09592d-9561-4ac0-983d-9039e12b25f4") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 64, DateTimeKind.Unspecified).AddTicks(9999), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 485, DateTimeKind.Unspecified).AddTicks(9651), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("d4b6dcc9-0162-4756-a6b7-b723cfde0695"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a93d996a-2c6c-423d-ac18-f6f00c215f4e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_WorkItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 64, DateTimeKind.Unspecified).AddTicks(9605), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 485, DateTimeKind.Unspecified).AddTicks(9121), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 64, DateTimeKind.Unspecified).AddTicks(4038), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 485, DateTimeKind.Unspecified).AddTicks(2562), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a259f670-0e45-4113-84d4-14cf4d19235c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("2d41c668-cfdf-43c6-a7be-691dcec975a7"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Scenario",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 64, DateTimeKind.Unspecified).AddTicks(3771), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 485, DateTimeKind.Unspecified).AddTicks(2183), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 63, DateTimeKind.Unspecified).AddTicks(9508), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 484, DateTimeKind.Unspecified).AddTicks(7186), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("68925cc8-40c9-4781-b7f7-ad408004d2bc"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("7c65f02f-599a-4d7f-858e-82036495d4a5"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_EndorsementItem",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 63, DateTimeKind.Unspecified).AddTicks(9121), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 484, DateTimeKind.Unspecified).AddTicks(6756), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Endorsement",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 63, DateTimeKind.Unspecified).AddTicks(3843), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 484, DateTimeKind.Unspecified).AddTicks(667), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Endorsement",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5cda0b1a-38f8-48ff-9a6b-9990812d43e0"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a111cc73-8595-494e-af8a-6604ca47ef65"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Endorsement",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 63, DateTimeKind.Unspecified).AddTicks(3417), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 484, DateTimeKind.Unspecified).AddTicks(185), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 62, DateTimeKind.Unspecified).AddTicks(7528), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 483, DateTimeKind.Unspecified).AddTicks(3321), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("efe491e8-33ea-4b2d-8e48-4e6e5ddf161d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("09c5da5c-5076-42ca-a5f1-77d292232b55"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Condition",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 62, DateTimeKind.Unspecified).AddTicks(7069), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 483, DateTimeKind.Unspecified).AddTicks(2759), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 62, DateTimeKind.Unspecified).AddTicks(675), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 482, DateTimeKind.Unspecified).AddTicks(5392), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Case",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f931aaa0-fd9a-4db0-9da7-89e80f569c2c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("a8d42752-e00b-4478-abad-ad43695c7a85"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Case",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 62, DateTimeKind.Unspecified).AddTicks(276), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 482, DateTimeKind.Unspecified).AddTicks(4862), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 61, DateTimeKind.Unspecified).AddTicks(1796), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 481, DateTimeKind.Unspecified).AddTicks(8282), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Facts",
                table: "F_Attachment",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a757e115-5378-40b3-ae54-a456680121a2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("b1d51b71-056a-4543-8967-d30cd9e3a0eb"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Facts",
                table: "F_Attachment",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 61, DateTimeKind.Unspecified).AddTicks(1530), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 481, DateTimeKind.Unspecified).AddTicks(7892), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 60, DateTimeKind.Unspecified).AddTicks(7542), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 481, DateTimeKind.Unspecified).AddTicks(3130), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("156dd855-ed89-41b2-a1df-c0114ecf3c18"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c73f307b-5477-422d-9ce1-fe29ceb0e413"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 60, DateTimeKind.Unspecified).AddTicks(7267), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 481, DateTimeKind.Unspecified).AddTicks(2801), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 60, DateTimeKind.Unspecified).AddTicks(3270), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 480, DateTimeKind.Unspecified).AddTicks(7848), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("441bf4ce-4c39-443f-ada8-79c6227a786c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("c7fae702-d14f-4fbe-9178-756a517099a7"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 60, DateTimeKind.Unspecified).AddTicks(2949), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 480, DateTimeKind.Unspecified).AddTicks(7506), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 59, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 480, DateTimeKind.Unspecified).AddTicks(2030), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("5a6ea714-470a-4879-84fa-8fde6e6e9f4e"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("ca3a9006-528c-4eac-a779-83c22a451a16"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_TagType",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 59, DateTimeKind.Unspecified).AddTicks(8108), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 480, DateTimeKind.Unspecified).AddTicks(1668), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 59, DateTimeKind.Unspecified).AddTicks(4040), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 479, DateTimeKind.Unspecified).AddTicks(5365), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("b044bf48-e4ce-4400-9c87-95a2e8238e38"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("974c7822-49ce-4952-a4b5-bd42332055d9"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Tag",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 59, DateTimeKind.Unspecified).AddTicks(3745), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 479, DateTimeKind.Unspecified).AddTicks(4938), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 58, DateTimeKind.Unspecified).AddTicks(9377), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 478, DateTimeKind.Unspecified).AddTicks(9587), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Role",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("03e4398b-798e-4cff-a0a7-05ce9b2425c9"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("28045822-90b3-4f5f-a1cb-3ba7e6225fb5"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Role",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 58, DateTimeKind.Unspecified).AddTicks(9047), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 478, DateTimeKind.Unspecified).AddTicks(9191), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 58, DateTimeKind.Unspecified).AddTicks(5103), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 478, DateTimeKind.Unspecified).AddTicks(4444), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c8de1eda-3f71-4772-a24c-0bcd84ea3725"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("6ed158be-4fbb-4210-9284-29cf582789f0"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Process",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 58, DateTimeKind.Unspecified).AddTicks(4833), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 478, DateTimeKind.Unspecified).AddTicks(4017), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 58, DateTimeKind.Unspecified).AddTicks(782), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 477, DateTimeKind.Unspecified).AddTicks(9247), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Position",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("315ab37b-108e-483c-94ee-0f53c780d81a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("f1e61168-3a9b-4efd-91b7-927290834d26"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Position",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 58, DateTimeKind.Unspecified).AddTicks(513), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 477, DateTimeKind.Unspecified).AddTicks(8915), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 57, DateTimeKind.Unspecified).AddTicks(6551), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 477, DateTimeKind.Unspecified).AddTicks(4163), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("c9770757-851a-4abb-84f8-ff0d206c0802"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("14c64b7b-5a2e-4c1f-acf7-ed8526814b70"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Operand",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 57, DateTimeKind.Unspecified).AddTicks(6278), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 477, DateTimeKind.Unspecified).AddTicks(3823), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 57, DateTimeKind.Unspecified).AddTicks(1989), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 476, DateTimeKind.Unspecified).AddTicks(8851), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Location",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("45d5dc10-b8e5-4974-8da9-0088fcb6c9e2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("6d99c0b1-b8ae-41f9-a6d6-28762dcef54c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Location",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 57, DateTimeKind.Unspecified).AddTicks(1610), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 476, DateTimeKind.Unspecified).AddTicks(8402), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 56, DateTimeKind.Unspecified).AddTicks(7121), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 476, DateTimeKind.Unspecified).AddTicks(2924), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("f8d40bb3-64eb-4982-a1bd-b71b7a3ca458"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d684ceac-1cb7-4f90-98bc-5494bab30e01"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_Entity",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 56, DateTimeKind.Unspecified).AddTicks(6738), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 476, DateTimeKind.Unspecified).AddTicks(2468), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModified",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                rowVersion: true,
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 56, DateTimeKind.Unspecified).AddTicks(2500), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldRowVersion: true,
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 475, DateTimeKind.Unspecified).AddTicks(7513), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "GuidRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("a0840e6d-792e-4e55-967b-757121f131c9"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldDefaultValue: new Guid("d25f3af3-4811-46d1-84bf-ed5829119a6e"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "datetimeoffset",
                nullable: true,
                defaultValue: new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 30, 56, DateTimeKind.Unspecified).AddTicks(2152), new TimeSpan(0, 3, 30, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true,
                oldDefaultValue: new DateTimeOffset(new DateTime(2024, 1, 5, 10, 24, 19, 475, DateTimeKind.Unspecified).AddTicks(7004), new TimeSpan(0, 3, 30, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 415, DateTimeKind.Unspecified).AddTicks(6172), new TimeSpan(0, 3, 30, 0, 0)), new Guid("41733429-76f9-493c-8379-6f02cb5e8611") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 415, DateTimeKind.Unspecified).AddTicks(6191), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1b1101a9-2c2e-4938-a24a-bd307dc43bc7") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 415, DateTimeKind.Unspecified).AddTicks(6193), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4394690d-bee3-44f3-a61d-4933eeff7072") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 415, DateTimeKind.Unspecified).AddTicks(6196), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c8f74391-9154-433b-9778-66c188a722fe") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_CaseState",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 415, DateTimeKind.Unspecified).AddTicks(6199), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4a867262-1991-41da-a0ae-a525646abc34") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 417, DateTimeKind.Unspecified).AddTicks(4245), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e5d43be1-9c6c-4dee-8de2-259d9d0f7731") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1080), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6e9f316a-7a5e-4fb6-abc1-23b68e6ad773") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1124), new TimeSpan(0, 3, 30, 0, 0)), new Guid("325e690f-fa2e-4eaa-a009-0099c7f5a897") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1133), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f3e134c1-6aa6-442c-af23-8671b712037d") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1148), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1038807a-4325-4784-bad7-728326d32554") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1155), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ee055c76-e1a2-45e2-9187-239e70d51d8a") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1162), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e2ea24db-aab1-4377-b679-ac0a2aeea40f") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1197), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bfa552fe-68c4-4284-968b-35358ef7690b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1255), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f423d6f6-f09c-4ba0-8f35-6b083dd756a6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1263), new TimeSpan(0, 3, 30, 0, 0)), new Guid("643176d4-4d0c-4c3c-9516-043ae519b522") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1270), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d2da4484-dd87-4fb0-8c00-4a3071ff8a69") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1277), new TimeSpan(0, 3, 30, 0, 0)), new Guid("43503ac4-2071-4577-81cb-b64274101293") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1286), new TimeSpan(0, 3, 30, 0, 0)), new Guid("741456a8-7f12-4b0e-aec4-734344cd2823") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1307), new TimeSpan(0, 3, 30, 0, 0)), new Guid("db36ff3a-db73-4f65-ad17-bf2e57488f8e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1314), new TimeSpan(0, 3, 30, 0, 0)), new Guid("72517154-24b1-4589-b6b0-76daedc3ff3b") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1320), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6c763a1d-4b91-44be-aacc-e76b2629500c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1324), new TimeSpan(0, 3, 30, 0, 0)), new Guid("48a851a3-4b0c-43f7-8d1e-22d1e80c7550") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1329), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dea212c5-1138-445d-9780-566968fb7a83") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1336), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a2c4ae9-aedc-43e5-9cb9-292b9f7e1669") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Entity",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(1342), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7605be60-add7-4561-97f8-f650e95c8fa8") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Location",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(3391), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a62ef7ff-44ab-465b-89ad-23d32c1e83ee") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(6460), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8f686b01-5293-4331-a2a2-0c0bd55a10ea") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 3, 30, 0, 0)), new Guid("da5f2b20-048b-4b9d-bb54-ad8f2d282656") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(6474), new TimeSpan(0, 3, 30, 0, 0)), new Guid("bb4f7f35-46d7-458e-8e15-c7b42caa9137") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(6476), new TimeSpan(0, 3, 30, 0, 0)), new Guid("ee9039d3-291b-4695-acf6-3d851b43ab84") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(6479), new TimeSpan(0, 3, 30, 0, 0)), new Guid("b3fa2901-6317-4d39-976a-20e04b54cc61") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Operand",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(6481), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6fc0c55b-facb-4e28-86b0-d7d497c59fb6") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Position",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 419, DateTimeKind.Unspecified).AddTicks(9006), new TimeSpan(0, 3, 30, 0, 0)), new Guid("dc1a8a33-9258-466c-aa02-995e7e74fbc4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Process",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 420, DateTimeKind.Unspecified).AddTicks(669), new TimeSpan(0, 3, 30, 0, 0)), new Guid("aabd6435-40e4-4ef0-82b3-aa788d4c277e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 420, DateTimeKind.Unspecified).AddTicks(2610), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0fdc25c0-0cb7-481c-9198-320cec25ea00") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Role",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 420, DateTimeKind.Unspecified).AddTicks(2926), new TimeSpan(0, 3, 30, 0, 0)), new Guid("40561e07-c5db-49ac-ae54-8592c3b30e22") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 420, DateTimeKind.Unspecified).AddTicks(6393), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6823907a-63d4-4f8a-851c-d28116ec891e") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 420, DateTimeKind.Unspecified).AddTicks(7013), new TimeSpan(0, 3, 30, 0, 0)), new Guid("07153fc3-d9a1-4c88-bfe6-701794e69025") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 420, DateTimeKind.Unspecified).AddTicks(7021), new TimeSpan(0, 3, 30, 0, 0)), new Guid("4bf6d39c-0282-4742-8401-dd86426ac0b2") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 420, DateTimeKind.Unspecified).AddTicks(7025), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0979fc3d-a3e5-4811-9d4f-fd98a85f66da") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_Tag",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 420, DateTimeKind.Unspecified).AddTicks(7027), new TimeSpan(0, 3, 30, 0, 0)), new Guid("e01f9f02-dbbf-422e-beb5-9188df5424f4") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 420, DateTimeKind.Unspecified).AddTicks(9474), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0d7e41fc-a0ae-4267-96e2-78f871455c2c") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 420, DateTimeKind.Unspecified).AddTicks(9485), new TimeSpan(0, 3, 30, 0, 0)), new Guid("6092cb6c-ee1f-4aa7-82f9-45db3655f855") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 420, DateTimeKind.Unspecified).AddTicks(9488), new TimeSpan(0, 3, 30, 0, 0)), new Guid("49b71f57-848a-4d4b-b0a8-41325aa6e3cc") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_TagType",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 420, DateTimeKind.Unspecified).AddTicks(9490), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2a0ae95b-2a73-4bd4-b52f-275c42e2f009") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 421, DateTimeKind.Unspecified).AddTicks(1872), new TimeSpan(0, 3, 30, 0, 0)), new Guid("2b8ddd25-448c-4b14-a1c8-186fc30be287") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 421, DateTimeKind.Unspecified).AddTicks(1883), new TimeSpan(0, 3, 30, 0, 0)), new Guid("de3af763-73f7-411b-99da-022915fe45fb") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 421, DateTimeKind.Unspecified).AddTicks(1886), new TimeSpan(0, 3, 30, 0, 0)), new Guid("f12eeb64-0170-4248-a944-910952622e09") });

            migrationBuilder.UpdateData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 421, DateTimeKind.Unspecified).AddTicks(1888), new TimeSpan(0, 3, 30, 0, 0)), new Guid("23dc4b9a-74b5-4f6e-989a-3d137102e829") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 413, DateTimeKind.Unspecified).AddTicks(5085), new TimeSpan(0, 3, 30, 0, 0)), new Guid("652d4e1c-eb85-4607-b290-a9a9ea637f11") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 413, DateTimeKind.Unspecified).AddTicks(7570), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8ac357a0-2079-460c-b31a-2c023e9916f6") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 413, DateTimeKind.Unspecified).AddTicks(7804), new TimeSpan(0, 3, 30, 0, 0)), new Guid("0d549810-f322-4802-adc7-844f80f99c31") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 413, DateTimeKind.Unspecified).AddTicks(7813), new TimeSpan(0, 3, 30, 0, 0)), new Guid("908d72cc-3ad9-4dc5-8019-636935176429") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Condition",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 413, DateTimeKind.Unspecified).AddTicks(7817), new TimeSpan(0, 3, 30, 0, 0)), new Guid("c74adb98-73bd-4188-b640-bb7b19a3fae6") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 414, DateTimeKind.Unspecified).AddTicks(5526), new TimeSpan(0, 3, 30, 0, 0)), new Guid("8626dc50-f2c4-4680-9b4c-340ebca6d97f") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Endorsement",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 414, DateTimeKind.Unspecified).AddTicks(6223), new TimeSpan(0, 3, 30, 0, 0)), new Guid("63c444a1-b5f2-4ed2-afd1-73e7737b9f9b") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 415, DateTimeKind.Unspecified).AddTicks(270), new TimeSpan(0, 3, 30, 0, 0)), new Guid("7900c00a-59f7-4279-83ea-3bfc001b725f") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 415, DateTimeKind.Unspecified).AddTicks(945), new TimeSpan(0, 3, 30, 0, 0)), new Guid("a6ac39fb-be33-4743-8f16-23b2c13e9da7") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 415, DateTimeKind.Unspecified).AddTicks(955), new TimeSpan(0, 3, 30, 0, 0)), new Guid("d366ea77-ec3a-4dbc-99df-1c5a9244ec4c") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_EndorsementItem",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 415, DateTimeKind.Unspecified).AddTicks(958), new TimeSpan(0, 3, 30, 0, 0)), new Guid("5f099f7c-402b-4326-90d9-1c0e490178a3") });

            migrationBuilder.UpdateData(
                schema: "Facts",
                table: "F_Scenario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "GuidRecord" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 10, 32, 29, 415, DateTimeKind.Unspecified).AddTicks(3318), new TimeSpan(0, 3, 30, 0, 0)), new Guid("1beba63f-c345-4458-bafe-d8a9328dbd50") });
        }
    }
}
