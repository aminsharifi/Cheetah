using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cheetah.Infrastructure.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class cleanup5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Task",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Form",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ColorId",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 104)
                .OldAnnotation("Relational:ColumnOrder", 100);

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Case",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_TagCategory",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Color",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "1",
                oldComment: "Active status of the record");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_WorkItemCondition",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_UserCondition",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_TaskFlow",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_TaskCondition",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_ScenarioCondition",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_FlowTask",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_FlowCondition",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_CaseTaskUser",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Links",
                table: "L_CaseCondition",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_WorkItem",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Task",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Scenario",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Form",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Flow",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Condition",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<long>(
                name: "ColorId",
                schema: "Facts",
                table: "F_Condition",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 100)
                .OldAnnotation("Relational:ColumnOrder", 104);

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Facts",
                table: "F_Case",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_User",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_TagType",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_TagCategory",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Tag",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Process",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Operand",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Entity",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_Color",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                type: "bit",
                nullable: false,
                defaultValueSql: "1",
                comment: "Active status of the record",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Active status of the record");
        }
    }
}
