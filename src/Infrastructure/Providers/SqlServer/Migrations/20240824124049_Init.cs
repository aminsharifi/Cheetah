using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Dimentions");

            migrationBuilder.EnsureSchema(
                name: "Facts");

            migrationBuilder.EnsureSchema(
                name: "Links");

            migrationBuilder.CreateTable(
                name: "D_CaseState",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_CaseState", x => x.Id);
                },
                comment: "State of the case");

            migrationBuilder.CreateTable(
                name: "D_Entity",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    Display = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    Sync = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Entity", x => x.Id);
                },
                comment: "Table's name in the Cheetah");

            migrationBuilder.CreateTable(
                name: "D_Operand",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Operand", x => x.Id);
                },
                comment: "Operand name, like equal, greater, etc.");

            migrationBuilder.CreateTable(
                name: "D_Process",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    ERP = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    RemoveRequestorApproval = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ShowSupport = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Process", x => x.Id);
                },
                comment: "The name of the processes that the admin enters");

            migrationBuilder.CreateTable(
                name: "D_TagCategory",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_TagCategory", x => x.Id);
                },
                comment: "Action, Performer");

            migrationBuilder.CreateTable(
                name: "D_TagType",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_TagType", x => x.Id);
                },
                comment: "Numeric, Text, Date, binary");

            migrationBuilder.CreateTable(
                name: "D_UserInformation",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NotifByEmail = table.Column<bool>(type: "bit", nullable: true),
                    NotifByMessenger = table.Column<bool>(type: "bit", nullable: true),
                    NotifByCell = table.Column<bool>(type: "bit", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactMessenger = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactCell = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserPicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NationalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InternalPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(215)", maxLength: 215, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_UserInformation", x => x.Id);
                },
                comment: "Additional user information");

            migrationBuilder.CreateTable(
                name: "D_WorkItemState",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_WorkItemState", x => x.Id);
                },
                comment: "State of the WorkItem");

            migrationBuilder.CreateTable(
                name: "F_Flow",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    CaseStateId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Flow", x => x.Id);
                },
                comment: "Flow of BPMN for transferring between tasks");

            migrationBuilder.CreateTable(
                name: "F_Form",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Form", x => x.Id);
                },
                comment: "Entitiy for forms");

            migrationBuilder.CreateTable(
                name: "F_Scenario",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Scenario", x => x.Id);
                },
                comment: "Scenario of processes");

            migrationBuilder.CreateTable(
                name: "D_Tag",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    TagTypeId = table.Column<long>(type: "bigint", nullable: true),
                    TagCategoryId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Tag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Tag_D_TagCategory_TagCategoryId",
                        column: x => x.TagCategoryId,
                        principalSchema: "Dimentions",
                        principalTable: "D_TagCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_D_Tag_D_TagType_TagTypeId",
                        column: x => x.TagTypeId,
                        principalSchema: "Dimentions",
                        principalTable: "D_TagType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Entities like position, role, etc.");

            migrationBuilder.CreateTable(
                name: "D_User",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    Core = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    EnabledForAssignation = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    DelegateEnabled = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    CreatedCasesSkipAssigRules = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    IDPersonel = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LDAPDescription = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DelegateId = table.Column<long>(type: "bigint", nullable: true),
                    UserInformationId = table.Column<long>(type: "bigint", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_User_D_UserInformation_UserInformationId",
                        column: x => x.UserInformationId,
                        principalSchema: "Dimentions",
                        principalTable: "D_UserInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_User_D_User_DelegateId",
                        column: x => x.DelegateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_D_User_D_User_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                },
                comment: "Cheetah's user");

            migrationBuilder.CreateTable(
                name: "F_Task",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    ScenarioId = table.Column<long>(type: "bigint", nullable: true),
                    FormId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Task_F_Form_FormId",
                        column: x => x.FormId,
                        principalSchema: "Facts",
                        principalTable: "F_Form",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Task_F_Scenario_ScenarioId",
                        column: x => x.ScenarioId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Entities like position, role, etc.");

            migrationBuilder.CreateTable(
                name: "L_ProcessScenario",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true)
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_L_ProcessScenario_F_Scenario_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Related scenarios of each flow");

            migrationBuilder.CreateTable(
                name: "F_Condition",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    TagId = table.Column<long>(type: "bigint", nullable: true),
                    OperandId = table.Column<long>(type: "bigint", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Condition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Condition_D_Operand_OperandId",
                        column: x => x.OperandId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Operand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Condition_D_Tag_TagId",
                        column: x => x.TagId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Condition of each tag");

            migrationBuilder.CreateTable(
                name: "F_Case",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    RequestorId = table.Column<long>(type: "bigint", nullable: true),
                    CreatorId = table.Column<long>(type: "bigint", nullable: true),
                    CaseStateId = table.Column<long>(type: "bigint", nullable: true),
                    ProcessId = table.Column<long>(type: "bigint", nullable: true),
                    SelectedScenarioId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Case", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Case_D_CaseState_CaseStateId",
                        column: x => x.CaseStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_CaseState",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Case_D_Process_ProcessId",
                        column: x => x.ProcessId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Process",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Case_D_User_CreatorId",
                        column: x => x.CreatorId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Case_D_User_RequestorId",
                        column: x => x.RequestorId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_Case_F_Scenario_SelectedScenarioId",
                        column: x => x.SelectedScenarioId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Each request create one record in this table");

            migrationBuilder.CreateTable(
                name: "L_FlowTask",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_FlowTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_FlowTask_F_Flow_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Flow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_L_FlowTask_F_Task_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Exit tasks of each flow");

            migrationBuilder.CreateTable(
                name: "L_TaskFlow",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_TaskFlow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_TaskFlow_F_Flow_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Flow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_L_TaskFlow_F_Task_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Exit flows of each task");

            migrationBuilder.CreateTable(
                name: "L_FlowCondition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_FlowCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_FlowCondition_F_Condition_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_L_FlowCondition_F_Flow_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Flow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Conditionals of each flow");

            migrationBuilder.CreateTable(
                name: "L_ScenarioCondition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_ScenarioCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_ScenarioCondition_F_Condition_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_L_ScenarioCondition_F_Scenario_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Conditionals of each scenario");

            migrationBuilder.CreateTable(
                name: "L_TaskCondition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_TaskCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_TaskCondition_F_Condition_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_L_TaskCondition_F_Task_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Conditionals of each task");

            migrationBuilder.CreateTable(
                name: "L_UserCondition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserCondition_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_L_UserCondition_F_Condition_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Conditionals of each user");

            migrationBuilder.CreateTable(
                name: "F_WorkItem",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    TaskId = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    CaseId = table.Column<long>(type: "bigint", nullable: true),
                    WorkItemStateId = table.Column<long>(type: "bigint", nullable: true),
                    F_CaseId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_WorkItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_WorkItem_D_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_WorkItem_D_WorkItemState_WorkItemStateId",
                        column: x => x.WorkItemStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_WorkItemState",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_WorkItem_F_Case_CaseId",
                        column: x => x.CaseId,
                        principalSchema: "Facts",
                        principalTable: "F_Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_F_WorkItem_F_Case_F_CaseId",
                        column: x => x.F_CaseId,
                        principalSchema: "Facts",
                        principalTable: "F_Case",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_WorkItem_F_Task_TaskId",
                        column: x => x.TaskId,
                        principalSchema: "Facts",
                        principalTable: "F_Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Numeric, Text, Date, binary");

            migrationBuilder.CreateTable(
                name: "L_CaseCondition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_CaseCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_CaseCondition_F_Case_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_L_CaseCondition_F_Condition_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Conditions of each case for selecting correct scenario");

            migrationBuilder.CreateTable(
                name: "L_CaseTaskUser",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true),
                    TaskId = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_CaseTaskUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_CaseTaskUser_D_User_ThirdId",
                        column: x => x.ThirdId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_L_CaseTaskUser_D_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_CaseTaskUser_F_Case_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_L_CaseTaskUser_F_Task_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_L_CaseTaskUser_F_Task_TaskId",
                        column: x => x.TaskId,
                        principalSchema: "Facts",
                        principalTable: "F_Task",
                        principalColumn: "Id");
                },
                comment: "Manual choosing performer");

            migrationBuilder.CreateTable(
                name: "L_WorkItemCondition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    ThirdId = table.Column<long>(type: "bigint", nullable: true),
                    FourthId = table.Column<long>(type: "bigint", nullable: true),
                    FifthId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_WorkItemCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_WorkItemCondition_F_Condition_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_L_WorkItemCondition_F_WorkItem_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_WorkItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Conditionals of each workitem");

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_CaseState",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(7760), new TimeSpan(0, 3, 30, 0, 0)), "مقداردهی اولیه", -1L, true, new Guid("199425b8-3be0-4198-948d-f82a86b237b7"), null, "Initializing", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(7767), new TimeSpan(0, 3, 30, 0, 0)), "در دست بررسی", -2L, true, new Guid("5ce726b4-cf1d-4a62-a109-3c688a67336c"), null, "Ongoing", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(7773), new TimeSpan(0, 3, 30, 0, 0)), "منتظر بازنگری", -3L, true, new Guid("47bbcf71-dd44-4cd8-9ed8-d1543299ef5c"), null, "Editing", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(7776), new TimeSpan(0, 3, 30, 0, 0)), "تایید شده", -4L, true, new Guid("3298d0be-1805-4274-9445-0791ab9dbd81"), null, "Approved", 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(7779), new TimeSpan(0, 3, 30, 0, 0)), "عدم تایید", -5L, true, new Guid("30b30a49-904b-45b7-b527-d94f499df44e"), null, "Rejected", 5L },
                    { 6L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(7781), new TimeSpan(0, 3, 30, 0, 0)), "ابطال شده", -6L, true, new Guid("afc2b62e-7154-404e-9f15-2a1f11671082"), null, "Aborted", 6L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "Created", "Display", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex", "Sync" },
                values: new object[,]
                {
                    { 101L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 526, DateTimeKind.Unspecified).AddTicks(9950), new TimeSpan(0, 3, 30, 0, 0)), false, "نوع تگ‌ها(Dimentions)", 101L, true, new Guid("155acce7-e65c-4e07-84f0-aa2e545c7e81"), null, "D_TagType", 101L, false },
                    { 102L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, 3, 30, 0, 0)), false, "عملگرها(Dimentions)", 102L, true, new Guid("c6ab833c-b31f-47c9-b1fd-2be3e13d9e46"), null, "D_Operand", 102L, false },
                    { 103L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(646), new TimeSpan(0, 3, 30, 0, 0)), false, "تگ‌ها(Dimentions)", 103L, true, new Guid("3b6eb1c5-318e-4e3f-baf1-680ee15b6aef"), null, "D_Tag", 103L, false },
                    { 104L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(653), new TimeSpan(0, 3, 30, 0, 0)), false, "وضعیت فرآیندها(Dimentions)", 104L, true, new Guid("bad065fb-8841-420f-ae43-cf631f4f7452"), null, "D_CaseState", 104L, false },
                    { 105L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(659), new TimeSpan(0, 3, 30, 0, 0)), true, "فرآیند‌ها(Dimentions)", 105L, true, new Guid("150886c5-690a-475e-8398-76ebe2f2bd27"), null, "D_Process", 105L, false },
                    { 106L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(676), new TimeSpan(0, 3, 30, 0, 0)), false, "کاربران(Dimentions)", 106L, true, new Guid("38801330-4554-4960-a594-f4911792904a"), null, "D_User", 106L, false },
                    { 107L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(687), new TimeSpan(0, 3, 30, 0, 0)), false, "اطلاعات کاربرها(Dimentions)", 107L, true, new Guid("f254c00f-b1df-4c7c-b8ac-1829bd4e7372"), null, "D_UserInformation", 107L, false },
                    { 108L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(730), new TimeSpan(0, 3, 30, 0, 0)), false, "تمام تاییدها(Facts)", 108L, true, new Guid("be0795a2-b94d-46ad-9566-0c8aa6ff89a9"), null, "F_WorkItem", 108L, false },
                    { 109L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(736), new TimeSpan(0, 3, 30, 0, 0)), false, "ضمیمه‌ها(Facts)", 109L, true, new Guid("99c0e965-5161-46c6-b1c4-3f7e1071938d"), null, "F_Attachment", 109L, false },
                    { 110L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(741), new TimeSpan(0, 3, 30, 0, 0)), false, "لیست تخصیص‌ها(Facts)", 110L, true, new Guid("ab67ac09-186c-4d34-bb75-e7a228bfbddc"), null, "F_Task", 110L, false },
                    { 111L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(746), new TimeSpan(0, 3, 30, 0, 0)), true, "لیست شرط‌ها(Facts)", 111L, true, new Guid("0967c20f-2d84-4b9d-9f20-a67be72decaf"), null, "F_Condition", 111L, false },
                    { 112L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(751), new TimeSpan(0, 3, 30, 0, 0)), false, "اطلاعات درخواست‌ها(Dimentions)", 112L, true, new Guid("6e5fa109-d619-473d-ad23-82918faccca0"), null, "F_Case", 112L, false },
                    { 113L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(756), new TimeSpan(0, 3, 30, 0, 0)), true, "سناریوها(Dimentions)", 113L, true, new Guid("b8b6ff63-899d-4b54-9d3e-97c000ecb0a4"), null, "F_Scenario", 113L, false },
                    { 114L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(761), new TimeSpan(0, 3, 30, 0, 0)), false, "سناریوها(Links)", 114L, true, new Guid("fa34b8b4-4122-4c49-baa7-60957819f5e1"), null, "L_ProcessScenario", 114L, false },
                    { 115L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 528, DateTimeKind.Unspecified).AddTicks(1377), new TimeSpan(0, 3, 30, 0, 0)), false, "فرم‌ها(Facts)", 115L, true, new Guid("7b08d904-59df-428f-b94a-b08485840ad8"), null, "F_Form", 115L, true }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(1332), new TimeSpan(0, 3, 30, 0, 0)), "مساوی", -1L, true, new Guid("05c36914-130f-42ae-b425-6c3d3ab3af0f"), null, "Equals", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(1374), new TimeSpan(0, 3, 30, 0, 0)), "مخالف", -2L, true, new Guid("e0c85958-047f-494d-82e9-d89ce82bbeaf"), null, "NotEquals", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(1377), new TimeSpan(0, 3, 30, 0, 0)), "بزگتر از", -3L, true, new Guid("2d9ca666-7a74-45e1-9f8a-28584aee355d"), null, "Greater", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(1380), new TimeSpan(0, 3, 30, 0, 0)), "بزرگتر و مساوی", -4L, true, new Guid("ba55c9ab-f06b-4741-b6d5-34c040d5cb00"), null, "EqualAndGreater", 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(1382), new TimeSpan(0, 3, 30, 0, 0)), "کوچکتر از", -5L, true, new Guid("83b1a046-b0b2-4c79-80f2-11083644c16f"), null, "LessThan", 5L },
                    { 6L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(1385), new TimeSpan(0, 3, 30, 0, 0)), "کوچکتر و مساوی", -6L, true, new Guid("13b18793-0af0-43bd-9ca8-cc2f83df71e2"), null, "LessThanOrEqual", 6L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Process",
                columns: new[] { "Id", "Created", "DisplayName", "ERP", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "RemoveRequestorApproval", "ShowSupport", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 523, DateTimeKind.Unspecified).AddTicks(765), new TimeSpan(0, 3, 30, 0, 0)), "فرآیند نمونه", true, -1L, true, new Guid("cc64cf34-2f09-41ca-aebd-710498d59096"), null, "SampleProcess", true, true, 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagCategory",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(6141), new TimeSpan(0, 3, 30, 0, 0)), "Performer", -1L, true, new Guid("88754cf6-ce75-4f17-a551-99a86107d189"), null, "Performer", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(6146), new TimeSpan(0, 3, 30, 0, 0)), "Action", -2L, true, new Guid("d1aea205-eeb0-4bf0-b1e6-97366b2964bc"), null, "Action", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagType",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(4882), new TimeSpan(0, 3, 30, 0, 0)), "عددی", -1L, true, new Guid("34e2d8e4-8b93-47e4-85e3-2ce8ffb73d81"), null, "Numberic", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(4895), new TimeSpan(0, 3, 30, 0, 0)), "دودویی", -2L, true, new Guid("a73bb95b-9666-460e-b420-4c38c1a8a075"), null, "Boolean", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(4899), new TimeSpan(0, 3, 30, 0, 0)), "دودویی", -3L, true, new Guid("8b2b38a3-600a-495f-9c3c-0a3377373e48"), null, "Date", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(4910), new TimeSpan(0, 3, 30, 0, 0)), "حروف", -4L, true, new Guid("fbc57390-283e-478a-aa7f-3eb104c2ca27"), null, "String", 4L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "Id", "Core", "Created", "DelegateId", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "IDPersonel", "LDAPDescription", "LastModified", "Name", "Parent_Id", "SortIndex", "UserInformationId" },
                values: new object[,]
                {
                    { 1L, null, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 526, DateTimeKind.Unspecified).AddTicks(2146), new TimeSpan(0, 3, 30, 0, 0)), null, "محمد شریفی", -1L, true, new Guid("1029b5fa-f21f-4460-a897-4a49076e7205"), null, null, null, "m.sharifi", null, 1L, null },
                    { 2L, null, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 526, DateTimeKind.Unspecified).AddTicks(2172), new TimeSpan(0, 3, 30, 0, 0)), null, "امین شریفی", -2L, true, new Guid("b3bdb4b0-f5f6-4c84-ac9c-0a87b224e303"), null, null, null, "a.sharifi", null, 2L, null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(9143), new TimeSpan(0, 3, 30, 0, 0)), "صندوق ورودی", -1L, true, new Guid("2d6c5c58-cb6f-4a96-a498-d8ef1ffbaf70"), null, "Inbox", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(9148), new TimeSpan(0, 3, 30, 0, 0)), "ارسال شده", -2L, true, new Guid("ba66c74d-da43-42e8-aa40-98d38c17f91e"), null, "Sent", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(9150), new TimeSpan(0, 3, 30, 0, 0)), "خروج", -3L, true, new Guid("018d6bea-b4ef-48c0-901a-6a1dbfca362f"), null, "Exit", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(9153), new TimeSpan(0, 3, 30, 0, 0)), "آینده", -4L, true, new Guid("94b1bf9f-4043-4103-997d-b3297b0f20e0"), null, "Future", 4L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Form",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(3286), new TimeSpan(0, 3, 30, 0, 0)), "اقدام کارشناسی", -1L, true, new Guid("69993e19-812f-4034-a5c3-3cf2f8a8dee8"), null, "ExpertForm", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(3292), new TimeSpan(0, 3, 30, 0, 0)), "بررسی درخواست", -2L, true, new Guid("73339f28-ffd3-4fd9-b4fd-ee121daf2c33"), null, "ReviewForm", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Scenario",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 523, DateTimeKind.Unspecified).AddTicks(4103), new TimeSpan(0, 3, 30, 0, 0)), "سناریو نمونه", -1L, true, new Guid("87053da0-62c3-40a6-8e07-c4001f89ffae"), null, "SampleScenario", 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "Created", "Description", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex", "TagCategoryId", "TagTypeId" },
                values: new object[,]
                {
                    { 4L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(3583), new TimeSpan(0, 3, 30, 0, 0)), "حروف", "موقعیت", -4L, true, new Guid("e586ff1d-ddac-45b9-bcb2-bf150bdfd01e"), null, "Location", 4L, 1L, 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(7237), new TimeSpan(0, 3, 30, 0, 0)), "حروف", "نقش", -5L, true, new Guid("8b4f8644-2e2a-48ba-bf5d-4ff42ee14868"), null, "Role", 5L, 1L, 4L },
                    { 6L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(7248), new TimeSpan(0, 3, 30, 0, 0)), "حروف", "سمت", -6L, true, new Guid("9ad2484e-482a-45bc-9681-7e740dad0b07"), null, "Position", 6L, 1L, 4L },
                    { 7L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(7252), new TimeSpan(0, 3, 30, 0, 0)), "حروف", "مدیر این پرسنل", -7L, true, new Guid("eddb0081-3956-476f-a57c-d36ae7c27636"), null, "Employees", 7L, 1L, 4L },
                    { 8L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(7256), new TimeSpan(0, 3, 30, 0, 0)), "عددی", "مبلغ", -8L, true, new Guid("702ddb79-f8df-4aa6-9b71-3da15349d0d8"), null, "Price", 8L, 2L, 1L },
                    { 12L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 3, 30, 0, 0)), "حروف", "وضعیت بررسی", -12L, true, new Guid("6da03d2d-d7c6-4d28-aa73-39ddddd478e1"), null, "ReviewState", 12L, 2L, 4L },
                    { 13L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 524, DateTimeKind.Unspecified).AddTicks(7267), new TimeSpan(0, 3, 30, 0, 0)), "حروف", "حرفه", -13L, true, new Guid("bbc774fc-31e5-4233-b7c5-9b0b982ec7df"), null, "Skill", 13L, 1L, 4L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Task",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "FormId", "GuidRecord", "LastModified", "Name", "ScenarioId", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(5274), new TimeSpan(0, 3, 30, 0, 0)), "ثبت درخواست", -1L, true, null, new Guid("7b81a94b-9c28-4d2f-bb92-8d14fe81220d"), null, "Sample_Scenario_Requestor", 1L, 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(5820), new TimeSpan(0, 3, 30, 0, 0)), "بررسی درخواست", -2L, true, null, new Guid("f86204f4-6b3a-4453-87b5-cd01c7f80e0d"), null, "Sample_Scenario_RequestorManager", 1L, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_ProcessScenario",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "FifthId", "FirstId", "FourthId", "GuidRecord", "LastModified", "Name", "SecondId", "SortIndex", "ThirdId" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 521, DateTimeKind.Unspecified).AddTicks(6405), new TimeSpan(0, 3, 30, 0, 0)), "فرآیند نمونه-سناریو نمونه", -1L, true, null, 1L, null, new Guid("0d8a62a9-bb23-4446-b93d-0041e9ee0151"), null, "SampleProcess_SampleScenario", 1L, 1L, null });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "OperandId", "SortIndex", "TagId", "Value" },
                values: new object[,]
                {
                    { 20L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 523, DateTimeKind.Unspecified).AddTicks(9859), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی Approve است.", -20L, true, new Guid("84bd44a5-54e5-4749-88a8-f9b1ef6e82f4"), null, "ReviewState = Approve", 1L, 20L, 12L, "Approve" },
                    { 21L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(2154), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی Reject است.", -21L, true, new Guid("ae5ea875-e7a2-48cb-a63b-281cd57427bf"), null, "ReviewState = Reject", 1L, 21L, 12L, "Reject" },
                    { 22L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(2163), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی Revise است.", -22L, true, new Guid("4be83c6c-9ae4-4e27-8476-d03395497c30"), null, "ReviewState = Revise", 1L, 22L, 12L, "Revise" },
                    { 23L, new DateTimeOffset(new DateTime(2024, 8, 24, 16, 10, 48, 525, DateTimeKind.Unspecified).AddTicks(2168), new TimeSpan(0, 3, 30, 0, 0)), "وضعیت بررسی مساوی SendRequest است.", -23L, true, new Guid("bac20e48-701e-4065-a90f-33b02b97cf52"), null, "ReviewState = SendRequest", 1L, 23L, 12L, "SendRequest" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_Created",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_EnableRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_ERPCode",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_LastModified",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_Name",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_Created",
                schema: "Dimentions",
                table: "D_Entity",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_Display",
                schema: "Dimentions",
                table: "D_Entity",
                column: "Display");

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_EnableRecord",
                schema: "Dimentions",
                table: "D_Entity",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_ERPCode",
                schema: "Dimentions",
                table: "D_Entity",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_LastModified",
                schema: "Dimentions",
                table: "D_Entity",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_Name",
                schema: "Dimentions",
                table: "D_Entity",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_Created",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_EnableRecord",
                schema: "Dimentions",
                table: "D_Operand",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_ERPCode",
                schema: "Dimentions",
                table: "D_Operand",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_LastModified",
                schema: "Dimentions",
                table: "D_Operand",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_Name",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_Created",
                schema: "Dimentions",
                table: "D_Process",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_EnableRecord",
                schema: "Dimentions",
                table: "D_Process",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_ERPCode",
                schema: "Dimentions",
                table: "D_Process",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_LastModified",
                schema: "Dimentions",
                table: "D_Process",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_Name",
                schema: "Dimentions",
                table: "D_Process",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_Created",
                schema: "Dimentions",
                table: "D_Tag",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_EnableRecord",
                schema: "Dimentions",
                table: "D_Tag",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_ERPCode",
                schema: "Dimentions",
                table: "D_Tag",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_LastModified",
                schema: "Dimentions",
                table: "D_Tag",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_Name",
                schema: "Dimentions",
                table: "D_Tag",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_TagCategoryId",
                schema: "Dimentions",
                table: "D_Tag",
                column: "TagCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag",
                column: "TagTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_D_TagCategory_Created",
                schema: "Dimentions",
                table: "D_TagCategory",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagCategory_EnableRecord",
                schema: "Dimentions",
                table: "D_TagCategory",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagCategory_ERPCode",
                schema: "Dimentions",
                table: "D_TagCategory",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagCategory_LastModified",
                schema: "Dimentions",
                table: "D_TagCategory",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagCategory_Name",
                schema: "Dimentions",
                table: "D_TagCategory",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_Created",
                schema: "Dimentions",
                table: "D_TagType",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_EnableRecord",
                schema: "Dimentions",
                table: "D_TagType",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_ERPCode",
                schema: "Dimentions",
                table: "D_TagType",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_LastModified",
                schema: "Dimentions",
                table: "D_TagType",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_Name",
                schema: "Dimentions",
                table: "D_TagType",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_Created",
                schema: "Dimentions",
                table: "D_User",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_DelegateId",
                schema: "Dimentions",
                table: "D_User",
                column: "DelegateId",
                unique: true,
                filter: "[DelegateId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_EnableRecord",
                schema: "Dimentions",
                table: "D_User",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_ERPCode",
                schema: "Dimentions",
                table: "D_User",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_LastModified",
                schema: "Dimentions",
                table: "D_User",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_Name",
                schema: "Dimentions",
                table: "D_User",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_Parent_Id",
                schema: "Dimentions",
                table: "D_User",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_UserInformationId",
                schema: "Dimentions",
                table: "D_User",
                column: "UserInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_EnableRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_ERPCode",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_LastModified",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_Name",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_EnableRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_ERPCode",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_LastModified",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_Name",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_CaseStateId",
                schema: "Facts",
                table: "F_Case",
                column: "CaseStateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_Created",
                schema: "Facts",
                table: "F_Case",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_CreatorId",
                schema: "Facts",
                table: "F_Case",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_EnableRecord",
                schema: "Facts",
                table: "F_Case",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_ERPCode",
                schema: "Facts",
                table: "F_Case",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_LastModified",
                schema: "Facts",
                table: "F_Case",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_Name",
                schema: "Facts",
                table: "F_Case",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_ProcessId",
                schema: "Facts",
                table: "F_Case",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_RequestorId",
                schema: "Facts",
                table: "F_Case",
                column: "RequestorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_SelectedScenarioId",
                schema: "Facts",
                table: "F_Case",
                column: "SelectedScenarioId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_Created",
                schema: "Facts",
                table: "F_Condition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_EnableRecord",
                schema: "Facts",
                table: "F_Condition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_ERPCode",
                schema: "Facts",
                table: "F_Condition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_LastModified",
                schema: "Facts",
                table: "F_Condition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_Name",
                schema: "Facts",
                table: "F_Condition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_OperandId",
                schema: "Facts",
                table: "F_Condition",
                column: "OperandId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_TagId",
                schema: "Facts",
                table: "F_Condition",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Flow_Created",
                schema: "Facts",
                table: "F_Flow",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Flow_EnableRecord",
                schema: "Facts",
                table: "F_Flow",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Flow_ERPCode",
                schema: "Facts",
                table: "F_Flow",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Flow_LastModified",
                schema: "Facts",
                table: "F_Flow",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Flow_Name",
                schema: "Facts",
                table: "F_Flow",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Form_Created",
                schema: "Facts",
                table: "F_Form",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Form_EnableRecord",
                schema: "Facts",
                table: "F_Form",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Form_ERPCode",
                schema: "Facts",
                table: "F_Form",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Form_LastModified",
                schema: "Facts",
                table: "F_Form",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Form_Name",
                schema: "Facts",
                table: "F_Form",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_Created",
                schema: "Facts",
                table: "F_Scenario",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_EnableRecord",
                schema: "Facts",
                table: "F_Scenario",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_ERPCode",
                schema: "Facts",
                table: "F_Scenario",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_LastModified",
                schema: "Facts",
                table: "F_Scenario",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_Name",
                schema: "Facts",
                table: "F_Scenario",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Task_Created",
                schema: "Facts",
                table: "F_Task",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Task_EnableRecord",
                schema: "Facts",
                table: "F_Task",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Task_ERPCode",
                schema: "Facts",
                table: "F_Task",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Task_FormId",
                schema: "Facts",
                table: "F_Task",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Task_LastModified",
                schema: "Facts",
                table: "F_Task",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Task_Name",
                schema: "Facts",
                table: "F_Task",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Task_ScenarioId",
                schema: "Facts",
                table: "F_Task",
                column: "ScenarioId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_CaseId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_Created",
                schema: "Facts",
                table: "F_WorkItem",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_EnableRecord",
                schema: "Facts",
                table: "F_WorkItem",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_ERPCode",
                schema: "Facts",
                table: "F_WorkItem",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_F_CaseId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "F_CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_LastModified",
                schema: "Facts",
                table: "F_WorkItem",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_Name",
                schema: "Facts",
                table: "F_WorkItem",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_TaskId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_UserId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_WorkItemStateId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "WorkItemStateId");

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_Created",
                schema: "Links",
                table: "L_CaseCondition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_EnableRecord",
                schema: "Links",
                table: "L_CaseCondition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_ERPCode",
                schema: "Links",
                table: "L_CaseCondition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_FifthId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_FirstId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_FourthId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_LastModified",
                schema: "Links",
                table: "L_CaseCondition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_Name",
                schema: "Links",
                table: "L_CaseCondition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_SecondId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseCondition_ThirdId",
                schema: "Links",
                table: "L_CaseCondition",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_Created",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_EnableRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_ERPCode",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_FifthId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_FirstId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_FourthId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_LastModified",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_Name",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_SecondId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_TaskId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_ThirdId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_CaseTaskUser_UserId",
                schema: "Links",
                table: "L_CaseTaskUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_Created",
                schema: "Links",
                table: "L_FlowCondition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_EnableRecord",
                schema: "Links",
                table: "L_FlowCondition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_ERPCode",
                schema: "Links",
                table: "L_FlowCondition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_FifthId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_FirstId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_FourthId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_LastModified",
                schema: "Links",
                table: "L_FlowCondition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_Name",
                schema: "Links",
                table: "L_FlowCondition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_SecondId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowCondition_ThirdId",
                schema: "Links",
                table: "L_FlowCondition",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_Created",
                schema: "Links",
                table: "L_FlowTask",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_EnableRecord",
                schema: "Links",
                table: "L_FlowTask",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_ERPCode",
                schema: "Links",
                table: "L_FlowTask",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_FifthId",
                schema: "Links",
                table: "L_FlowTask",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_FirstId",
                schema: "Links",
                table: "L_FlowTask",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_FourthId",
                schema: "Links",
                table: "L_FlowTask",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_LastModified",
                schema: "Links",
                table: "L_FlowTask",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_Name",
                schema: "Links",
                table: "L_FlowTask",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_SecondId",
                schema: "Links",
                table: "L_FlowTask",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_FlowTask_ThirdId",
                schema: "Links",
                table: "L_FlowTask",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_Created",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_EnableRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_ERPCode",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_FifthId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_FirstId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_FourthId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_LastModified",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_Name",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_SecondId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_ThirdId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_Created",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_EnableRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_ERPCode",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_FifthId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_FirstId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_FourthId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_LastModified",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_Name",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_SecondId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ScenarioCondition_ThirdId",
                schema: "Links",
                table: "L_ScenarioCondition",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_FirstId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "FirstId");

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_SecondId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "SecondId");

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_Created",
                schema: "Links",
                table: "L_TaskFlow",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_EnableRecord",
                schema: "Links",
                table: "L_TaskFlow",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_ERPCode",
                schema: "Links",
                table: "L_TaskFlow",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_FifthId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_FirstId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_FourthId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_LastModified",
                schema: "Links",
                table: "L_TaskFlow",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_Name",
                schema: "Links",
                table: "L_TaskFlow",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_SecondId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskFlow_ThirdId",
                schema: "Links",
                table: "L_TaskFlow",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_Created",
                schema: "Links",
                table: "L_UserCondition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_EnableRecord",
                schema: "Links",
                table: "L_UserCondition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_ERPCode",
                schema: "Links",
                table: "L_UserCondition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_FifthId",
                schema: "Links",
                table: "L_UserCondition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_FirstId",
                schema: "Links",
                table: "L_UserCondition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_FourthId",
                schema: "Links",
                table: "L_UserCondition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_LastModified",
                schema: "Links",
                table: "L_UserCondition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_Name",
                schema: "Links",
                table: "L_UserCondition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_SecondId",
                schema: "Links",
                table: "L_UserCondition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserCondition_ThirdId",
                schema: "Links",
                table: "L_UserCondition",
                column: "ThirdId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_Created",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_EnableRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_ERPCode",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_FifthId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_FirstId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_FourthId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_LastModified",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_Name",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_SecondId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_WorkItemCondition_ThirdId",
                schema: "Links",
                table: "L_WorkItemCondition",
                column: "ThirdId",
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "D_Entity",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "L_CaseCondition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_CaseTaskUser",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_FlowCondition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_FlowTask",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_ProcessScenario",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_ScenarioCondition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_TaskCondition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_TaskFlow",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_UserCondition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_WorkItemCondition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "F_Flow",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_Condition",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_WorkItem",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_Operand",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Tag",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_WorkItemState",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Case",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_Task",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_TagCategory",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_TagType",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_CaseState",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Process",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_User",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Form",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_Scenario",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_UserInformation",
                schema: "Dimentions");
        }
    }
}
