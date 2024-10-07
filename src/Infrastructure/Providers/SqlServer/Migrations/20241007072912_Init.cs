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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    Read = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    Create = table.Column<bool>(type: "bit", nullable: true),
                    Update = table.Column<bool>(type: "bit", nullable: true),
                    Delete = table.Column<bool>(type: "bit", nullable: true),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true, comment: "ID of this record in ERP"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "By which user has it been updated?"),
                    CreatedBy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Created by what user?"),
                    TagId = table.Column<long>(type: "bigint", nullable: true),
                    OperandId = table.Column<long>(type: "bigint", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckValidation = table.Column<bool>(type: "bit", nullable: true)
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "The unique key of each record")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L, comment: "The sort index of the record"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "English name of each record"),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "The localized name of each record"),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: "", comment: "Additional description of each record"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "GETDATE()", comment: "Record creation date"),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "The date the record was last updated"),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "NEWSEQUENTIALID ()", comment: "Unique GUID identifier"),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    EnableRecord = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1", comment: "Active status of the record"),
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
                    { 1L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(7951), new TimeSpan(0, 3, 30, 0, 0)), "مقداردهی اولیه", -1L, true, new Guid("d7032a3b-d9ac-4701-aae1-2e22211a020d"), null, "Initializing", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(7960), new TimeSpan(0, 3, 30, 0, 0)), "در دست بررسی", -2L, true, new Guid("6d879e41-7df2-4d72-8c95-4f44f6563703"), null, "Ongoing", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(7962), new TimeSpan(0, 3, 30, 0, 0)), "منتظر بازنگری", -3L, true, new Guid("27a86bbd-1ebd-402a-ba5c-2854f534313d"), null, "Editing", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(7965), new TimeSpan(0, 3, 30, 0, 0)), "تایید شده", -4L, true, new Guid("49a3d537-5643-40af-80d4-8d0a01e8bbda"), null, "Approved", 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(7967), new TimeSpan(0, 3, 30, 0, 0)), "عدم تایید", -5L, true, new Guid("39c1fa7d-d156-479a-9b5f-d72742cb8cce"), null, "Rejected", 5L },
                    { 6L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(7973), new TimeSpan(0, 3, 30, 0, 0)), "ابطال شده", -6L, true, new Guid("5d5ff4f0-fef8-4431-9f01-759955b65c4c"), null, "Aborted", 6L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "Create", "Created", "Delete", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "Read", "SortIndex", "Sync", "Update" },
                values: new object[,]
                {
                    { 101L, false, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 134, DateTimeKind.Unspecified).AddTicks(5257), new TimeSpan(0, 3, 30, 0, 0)), false, "نوع تگ‌ها(Dimentions)", 101L, true, new Guid("15f4dd2e-2038-49e6-8fb2-95fdcb91722d"), null, "D_TagType", false, 101L, false, false },
                    { 102L, false, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5045), new TimeSpan(0, 3, 30, 0, 0)), false, "عملگرها(Dimentions)", 102L, true, new Guid("a96b32d9-c56b-4376-8e51-e66201dbfc5e"), null, "D_Operand", false, 102L, false, false },
                    { 103L, false, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5069), new TimeSpan(0, 3, 30, 0, 0)), false, "تگ‌ها(Dimentions)", 103L, true, new Guid("ced536be-ca0e-4042-aa05-2c806ae60053"), null, "D_Tag", false, 103L, false, false },
                    { 104L, false, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5076), new TimeSpan(0, 3, 30, 0, 0)), false, "وضعیت فرآیندها(Dimentions)", 104L, true, new Guid("a9882209-a4c1-4720-8a0a-065c05041441"), null, "D_CaseState", false, 104L, false, false },
                    { 105L, false, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5125), new TimeSpan(0, 3, 30, 0, 0)), false, "فرآیند‌ها(Dimentions)", 105L, true, new Guid("de852528-20fc-48f5-8b6d-0859d1f1e62b"), null, "D_Process", true, 105L, false, false },
                    { 106L, false, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5132), new TimeSpan(0, 3, 30, 0, 0)), false, "کاربران(Dimentions)", 106L, true, new Guid("b813dfe1-c43c-45d1-a663-3ecc0a08d6ca"), null, "D_User", false, 106L, false, false },
                    { 107L, false, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5137), new TimeSpan(0, 3, 30, 0, 0)), false, "اطلاعات کاربرها(Dimentions)", 107L, true, new Guid("3845093e-9279-4b94-8338-122229136910"), null, "D_UserInformation", false, 107L, false, false },
                    { 108L, false, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5143), new TimeSpan(0, 3, 30, 0, 0)), false, "تمام تاییدها(Facts)", 108L, true, new Guid("81fcba51-805b-4c80-a48d-fb966b1b03d7"), null, "F_WorkItem", false, 108L, false, false },
                    { 109L, false, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5149), new TimeSpan(0, 3, 30, 0, 0)), false, "ضمیمه‌ها(Facts)", 109L, true, new Guid("c8ebaf03-bfdd-4fba-8a19-de96b42a0ce6"), null, "F_Attachment", false, 109L, false, false },
                    { 110L, false, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5154), new TimeSpan(0, 3, 30, 0, 0)), false, "لیست تخصیص‌ها(Facts)", 110L, true, new Guid("36a0e1f0-8187-4867-80ee-2fa4bc98d19a"), null, "F_Task", false, 110L, false, false },
                    { 111L, false, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5159), new TimeSpan(0, 3, 30, 0, 0)), false, "لیست شرط‌ها(Facts)", 111L, true, new Guid("7d93e299-e320-406a-bd51-b2bb3cdacf01"), null, "F_Condition", true, 111L, false, false },
                    { 112L, false, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5164), new TimeSpan(0, 3, 30, 0, 0)), false, "اطلاعات درخواست‌ها(Dimentions)", 112L, true, new Guid("461ee0c6-7cd7-4c40-8323-224bc65405d3"), null, "F_Case", false, 112L, false, false },
                    { 113L, false, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5170), new TimeSpan(0, 3, 30, 0, 0)), false, "سناریوها(Dimentions)", 113L, true, new Guid("631936cb-406a-446f-804a-7e035b69f48f"), null, "F_Scenario", true, 113L, false, false },
                    { 114L, false, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5175), new TimeSpan(0, 3, 30, 0, 0)), false, "سناریوها(Links)", 114L, true, new Guid("192418aa-cda8-44d7-b66d-561f0b0d3659"), null, "L_ProcessScenario", false, 114L, false, false },
                    { 115L, false, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(5706), new TimeSpan(0, 3, 30, 0, 0)), false, "فرم‌ها(Facts)", 115L, true, new Guid("3a7a5404-0832-4401-bcef-44411a32012c"), null, "F_Form", false, 115L, true, false }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(6764), new TimeSpan(0, 3, 30, 0, 0)), "مساوی", -1L, true, new Guid("dd9ba2a1-1644-49b9-8267-9032cfcaef13"), null, "Equals", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(6771), new TimeSpan(0, 3, 30, 0, 0)), "مخالف", -2L, true, new Guid("981fc85d-aef7-4a03-b1f5-d33449b5c66d"), null, "NotEquals", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(6774), new TimeSpan(0, 3, 30, 0, 0)), "بزگتر از", -3L, true, new Guid("2545a5c2-7d26-4a7c-9b92-15b101c4ca9c"), null, "Greater", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(6776), new TimeSpan(0, 3, 30, 0, 0)), "بزرگتر و مساوی", -4L, true, new Guid("766b7f0c-af97-4ffc-aef0-09dc3e239371"), null, "EqualAndGreater", 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(6779), new TimeSpan(0, 3, 30, 0, 0)), "کوچکتر از", -5L, true, new Guid("985a716e-9ea2-41bc-a5ea-ad6071ea8d79"), null, "LessThan", 5L },
                    { 6L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(6785), new TimeSpan(0, 3, 30, 0, 0)), "کوچکتر و مساوی", -6L, true, new Guid("57d5605d-f662-4323-819e-5a0090aed43d"), null, "LessThanOrEqual", 6L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Process",
                columns: new[] { "Id", "Created", "DisplayName", "ERP", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "RemoveRequestorApproval", "ShowSupport", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 131, DateTimeKind.Unspecified).AddTicks(9077), new TimeSpan(0, 3, 30, 0, 0)), "فرآیند نمونه", true, -1L, true, new Guid("986a6579-91e6-41cd-acd4-5949c4b368fc"), null, "SampleProcess", true, true, 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagCategory",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(2133), new TimeSpan(0, 3, 30, 0, 0)), "Performer", -1L, true, new Guid("56e19bb2-800f-4448-b019-45a71ba3ee2c"), null, "Performer", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(2139), new TimeSpan(0, 3, 30, 0, 0)), "Action", -2L, true, new Guid("0258f05d-4214-4a3d-982b-5dfcbbf04209"), null, "Action", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagType",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(1099), new TimeSpan(0, 3, 30, 0, 0)), "عددی", -1L, true, new Guid("5987416a-1f69-4c94-af1f-b136d8fff6e1"), null, "Numberic", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(1111), new TimeSpan(0, 3, 30, 0, 0)), "دودویی", -2L, true, new Guid("b5db99df-12ef-4796-85da-b5e2a9b8a843"), null, "Boolean", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(1114), new TimeSpan(0, 3, 30, 0, 0)), "دودویی", -3L, true, new Guid("65dc9cd2-a7ae-49af-b6aa-82cf456b23fb"), null, "Date", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(1117), new TimeSpan(0, 3, 30, 0, 0)), "حروف", -4L, true, new Guid("b4da6d9b-bb91-4bbf-a586-b195012c6e0d"), null, "String", 4L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "Id", "Core", "Created", "DelegateId", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "IDPersonel", "LDAPDescription", "LastModified", "Name", "Parent_Id", "SortIndex", "UserInformationId" },
                values: new object[,]
                {
                    { 1L, null, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 129, DateTimeKind.Unspecified).AddTicks(9735), new TimeSpan(0, 3, 30, 0, 0)), null, "محمد شریفی", -1L, true, new Guid("186ab049-b2be-4fb4-be77-c57ad35c271c"), null, null, null, "m.sharifi", null, 1L, null },
                    { 2L, null, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 131, DateTimeKind.Unspecified).AddTicks(3855), new TimeSpan(0, 3, 30, 0, 0)), null, "امین شریفی", -2L, true, new Guid("7c2fa0ed-d48b-44a9-ae7d-314485ef82cd"), null, null, null, "a.sharifi", null, 2L, null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(9249), new TimeSpan(0, 3, 30, 0, 0)), "صندوق ورودی", -1L, true, new Guid("fbb55e88-d001-4392-b894-b0f3fa1f3829"), null, "Inbox", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(9254), new TimeSpan(0, 3, 30, 0, 0)), "ارسال شده", -2L, true, new Guid("89c64a88-f104-43de-965c-1d3b6acf748c"), null, "Sent", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(9257), new TimeSpan(0, 3, 30, 0, 0)), "خروج", -3L, true, new Guid("3b9eb652-c2dc-426e-bacb-782024359821"), null, "Exit", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 135, DateTimeKind.Unspecified).AddTicks(9260), new TimeSpan(0, 3, 30, 0, 0)), "آینده", -4L, true, new Guid("bbf8c05b-19ac-4fbf-8ce6-727e17a90bf9"), null, "Future", 4L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Form",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 132, DateTimeKind.Unspecified).AddTicks(2002), new TimeSpan(0, 3, 30, 0, 0)), "اقدام کارشناسی", -1L, true, new Guid("944ef1d8-d8fc-49b3-9e7b-c7c6b29838b2"), null, "ExpertForm", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 132, DateTimeKind.Unspecified).AddTicks(2009), new TimeSpan(0, 3, 30, 0, 0)), "بررسی درخواست", -2L, true, new Guid("3d3452b6-2f01-44b4-8564-fd1d0f8ca926"), null, "ReviewForm", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Scenario",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 132, DateTimeKind.Unspecified).AddTicks(658), new TimeSpan(0, 3, 30, 0, 0)), "سناریو نمونه", -1L, true, new Guid("9e48f8b5-b90a-4a65-8c57-a8b2a4b79d76"), null, "SampleScenario", 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "Created", "Description", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "SortIndex", "TagCategoryId", "TagTypeId" },
                values: new object[,]
                {
                    { 4L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(23), new TimeSpan(0, 3, 30, 0, 0)), "حروف", "موقعیت", -4L, true, new Guid("c3add4ef-5f5c-4308-9a36-6af4718cbc90"), null, "Location", 4L, 1L, 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(2969), new TimeSpan(0, 3, 30, 0, 0)), "حروف", "نقش", -5L, true, new Guid("d0e28dfd-b30c-485c-a535-dadb0c13fd66"), null, "Role", 5L, 1L, 4L },
                    { 6L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(2977), new TimeSpan(0, 3, 30, 0, 0)), "حروف", "سمت", -6L, true, new Guid("c80e5ad6-4ae3-4e1a-8050-2f7548798417"), null, "Position", 6L, 1L, 4L },
                    { 7L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 3, 30, 0, 0)), "حروف", "مدیر این پرسنل", -7L, true, new Guid("5f667832-107b-4216-97ef-b0c43227bddf"), null, "Employees", 7L, 1L, 4L },
                    { 8L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 3, 30, 0, 0)), "عددی", "مبلغ", -8L, true, new Guid("ecbaf29d-0741-4909-8939-4fccd15314a8"), null, "Price", 8L, 2L, 1L },
                    { 12L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(2992), new TimeSpan(0, 3, 30, 0, 0)), "حروف", "وضعیت بررسی", -12L, true, new Guid("d906e7b3-6df9-4456-b6f0-5091fdb73d79"), null, "ReviewState", 12L, 2L, 4L },
                    { 13L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(2995), new TimeSpan(0, 3, 30, 0, 0)), "حروف", "حرفه", -13L, true, new Guid("7b27fc8c-ef0b-4bc9-8b51-d0b7bd1c0384"), null, "Skill", 13L, 1L, 4L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Task",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "FormId", "GuidRecord", "LastModified", "Name", "ScenarioId", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 132, DateTimeKind.Unspecified).AddTicks(3784), new TimeSpan(0, 3, 30, 0, 0)), "ثبت درخواست", -1L, true, null, new Guid("147a7319-8bd6-4a27-96f3-ff7c1c9cdc16"), null, "Sample_Scenario_Requestor", 1L, 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 132, DateTimeKind.Unspecified).AddTicks(4176), new TimeSpan(0, 3, 30, 0, 0)), "بررسی درخواست", -2L, true, null, new Guid("c9fd909b-4843-4c80-b143-735fc9145256"), null, "Sample_Scenario_RequestorManager", 1L, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_ProcessScenario",
                columns: new[] { "Id", "Created", "DisplayName", "ERPCode", "EnableRecord", "FifthId", "FirstId", "FourthId", "GuidRecord", "LastModified", "Name", "SecondId", "SortIndex", "ThirdId" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 131, DateTimeKind.Unspecified).AddTicks(7984), new TimeSpan(0, 3, 30, 0, 0)), "فرآیند نمونه-سناریو نمونه", -1L, true, null, 1L, null, new Guid("519b988a-8689-4fc8-a197-61710bbfeb8d"), null, "SampleProcess_SampleScenario", 1L, 1L, null });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "CheckValidation", "Created", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModified", "Name", "OperandId", "SortIndex", "TagId", "Value" },
                values: new object[,]
                {
                    { 20L, null, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 132, DateTimeKind.Unspecified).AddTicks(6488), new TimeSpan(0, 3, 30, 0, 0)), "تایید", -20L, true, new Guid("c9eb3805-90a4-426e-9a9d-6e5dd120320d"), null, "ReviewState = Approve", 1L, 20L, 12L, "Approve" },
                    { 21L, null, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(7390), new TimeSpan(0, 3, 30, 0, 0)), "عدم تایید", -21L, true, new Guid("82e7cd27-6a57-4b26-af92-bfeb4e66df4b"), null, "ReviewState = Reject", 1L, 21L, 12L, "Reject" },
                    { 22L, null, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(7396), new TimeSpan(0, 3, 30, 0, 0)), "بازنگری", -22L, true, new Guid("0cbfe76c-33a5-46eb-90a7-fd6ab6c39e59"), null, "ReviewState = Revise", 1L, 22L, 12L, "Revise" },
                    { 23L, null, new DateTimeOffset(new DateTime(2024, 10, 7, 10, 59, 11, 133, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, 3, 30, 0, 0)), "ارسال درخواست", -23L, true, new Guid("4fea65d5-f566-4e25-9ae6-8d699877508a"), null, "ReviewState = SendRequest", 1L, 23L, 12L, "SendRequest" }
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
                name: "IX_D_Entity_Read",
                schema: "Dimentions",
                table: "D_Entity",
                column: "Read");

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
                name: "IX_L_TaskCondition_Created",
                schema: "Links",
                table: "L_TaskCondition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_EnableRecord",
                schema: "Links",
                table: "L_TaskCondition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_ERPCode",
                schema: "Links",
                table: "L_TaskCondition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_FifthId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "FifthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_FirstId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_FourthId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "FourthId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_LastModified",
                schema: "Links",
                table: "L_TaskCondition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_Name",
                schema: "Links",
                table: "L_TaskCondition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_SecondId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_TaskCondition_ThirdId",
                schema: "Links",
                table: "L_TaskCondition",
                column: "ThirdId",
                descending: new bool[0]);

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
