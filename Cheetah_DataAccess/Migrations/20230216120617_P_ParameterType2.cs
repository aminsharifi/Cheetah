using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PParameterType2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_PersonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ParameterList_P_ProcessEndorsement_P_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_P_FieldType_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropForeignKey(
                name: "FK_P_ProcessEndorsement_P_Operand_PT_P_OperandIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_P_ProcessEndorsement_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_P_ProcessEndorsement_PT_P_OperandIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropIndex(
                name: "IX_P_ParameterList_P_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropIndex(
                name: "IX_M_RequestInformation_RI_PersonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "PT_P_OperandIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "P_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropColumn(
                name: "IdWorkItem",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_Address",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_Attachment",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_CurrentUserNames",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_ERPBranchs",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_ERPKindID",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_OutputVar1",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_OutputVar2",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_OutputVar3",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_OutputVar4",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_OutputVar5",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_People",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_PersonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_RequestID",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_RequestNumber",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_RequestSubject",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_TaskName",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_UserNameCreator",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "RI_ValidUserAction",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.AddColumn<long>(
                name: "PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "M_ListOfParameter",
                schema: "Masters",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FloatValue = table.Column<float>(type: "real", nullable: true),
                    BooleanValue = table.Column<bool>(type: "bit", nullable: true),
                    StringValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOPPParameterListIdRecord = table.Column<long>(name: "LOP_P_ParameterListIdRecord", type: "bigint", nullable: true),
                    LOPPParameterTypeIdRecord = table.Column<long>(name: "LOP_P_ParameterTypeIdRecord", type: "bigint", nullable: true),
                    PTPOperandIdRecord = table.Column<long>(name: "PT_P_OperandIdRecord", type: "bigint", nullable: true),
                    MRequestInformationIdRecord = table.Column<long>(name: "M_RequestInformationIdRecord", type: "bigint", nullable: true),
                    PProcessEndorsementIdRecord = table.Column<long>(name: "P_ProcessEndorsementIdRecord", type: "bigint", nullable: true),
                    CreateTimeRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedRecord = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DsblRecord = table.Column<bool>(type: "bit", nullable: true),
                    PCode = table.Column<long>(type: "bigint", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIndex = table.Column<long>(type: "bigint", nullable: false),
                    PERPCode = table.Column<long>(type: "bigint", nullable: true),
                    PDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PCost = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_ListOfParameter", x => x.IdRecord);
                    table.ForeignKey(
                        name: "FK_M_ListOfParameter_M_RequestInformation_M_RequestInformationIdRecord",
                        column: x => x.MRequestInformationIdRecord,
                        principalSchema: "Masters",
                        principalTable: "M_RequestInformation",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_ListOfParameter_P_Operand_PT_P_OperandIdRecord",
                        column: x => x.PTPOperandIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_Operand",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_ListOfParameter_P_ParameterList_LOP_P_ParameterListIdRecord",
                        column: x => x.LOPPParameterListIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_ParameterList",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_ListOfParameter_P_ParameterType_LOP_P_ParameterTypeIdRecord",
                        column: x => x.LOPPParameterTypeIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_ParameterType",
                        principalColumn: "IdRecord");
                    table.ForeignKey(
                        name: "FK_M_ListOfParameter_P_ProcessEndorsement_P_ProcessEndorsementIdRecord",
                        column: x => x.PProcessEndorsementIdRecord,
                        principalSchema: "Parameters",
                        principalTable: "P_ProcessEndorsement",
                        principalColumn: "IdRecord");
                });

            migrationBuilder.CreateIndex(
                name: "IX_P_ParameterType_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                column: "PT_P_FieldTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_ListOfParameter_LOP_P_ParameterListIdRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                column: "LOP_P_ParameterListIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_ListOfParameter_LOP_P_ParameterTypeIdRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                column: "LOP_P_ParameterTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_ListOfParameter_M_RequestInformationIdRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                column: "M_RequestInformationIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_ListOfParameter_P_ProcessEndorsementIdRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                column: "P_ProcessEndorsementIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_ListOfParameter_PT_P_OperandIdRecord",
                schema: "Masters",
                table: "M_ListOfParameter",
                column: "PT_P_OperandIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ParameterType_P_FieldType_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                column: "PT_P_FieldTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_FieldType",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_P_ParameterType_P_FieldType_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType");

            migrationBuilder.DropTable(
                name: "M_ListOfParameter",
                schema: "Masters");

            migrationBuilder.DropIndex(
                name: "IX_P_ParameterType_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType");

            migrationBuilder.DropColumn(
                name: "PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ParameterType");

            migrationBuilder.AddColumn<long>(
                name: "PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PT_P_OperandIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "P_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdWorkItem",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_Address",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "RI_Attachment",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_CurrentUserNames",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_ERPBranchs",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_ERPKindID",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_OutputVar1",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_OutputVar2",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_OutputVar3",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_OutputVar4",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_OutputVar5",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_People",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RI_PersonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RI_RequestID",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_RequestNumber",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_RequestSubject",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_TaskName",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_UserNameCreator",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RI_ValidUserAction",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_P_ProcessEndorsement_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PT_P_FieldTypeIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_ProcessEndorsement_PT_P_OperandIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PT_P_OperandIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_P_ParameterList_P_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                column: "P_ProcessEndorsementIdRecord");

            migrationBuilder.CreateIndex(
                name: "IX_M_RequestInformation_RI_PersonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_PersonIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_M_RequestInformation_S_User_RI_PersonIdRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                column: "RI_PersonIdRecord",
                principalSchema: "Systems",
                principalTable: "S_User",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ParameterList_P_ProcessEndorsement_P_ProcessEndorsementIdRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                column: "P_ProcessEndorsementIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_ProcessEndorsement",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ProcessEndorsement_P_FieldType_PT_P_FieldTypeIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PT_P_FieldTypeIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_FieldType",
                principalColumn: "IdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_P_ProcessEndorsement_P_Operand_PT_P_OperandIdRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                column: "PT_P_OperandIdRecord",
                principalSchema: "Parameters",
                principalTable: "P_Operand",
                principalColumn: "IdRecord");
        }
    }
}
