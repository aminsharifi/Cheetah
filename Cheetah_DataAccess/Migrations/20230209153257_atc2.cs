using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class atc2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Role",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Role",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_OrgPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_OrgPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Location",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Location",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Area",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Area",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_UserActionGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_UserAction",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_UserAction",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_RequestType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_RequestType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_RequestTitle",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ProcessState",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_PositionOrg",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ParameterType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ParameterList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_UserActionsProcess",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_RequestInformation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_CurrentPE",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_CallWebService",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_CallWebService",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_Approve",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_Approve",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_Attachment",
                schema: "Masters");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Role");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Role");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_OrgPosition");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_OrgPosition");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Location");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Systems",
                table: "S_Area");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Systems",
                table: "S_Area");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_UserActionGroup");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_UserActionGroup");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_UserAction");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_UserAction");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_SubRequestTitle");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_RequestType");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_RequestType");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_RequestTitle");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ProcessState");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ProcessState");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ProcessEndorsement");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_PositionOrg");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ParameterType");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ParameterType");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Parameters",
                table: "P_ParameterList");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_UserActionsProcess");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_UserActionsProcess");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_RequestInformation");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_CurrentPE");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_CurrentPE");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_CallWebService");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_CallWebService");

            migrationBuilder.DropColumn(
                name: "CreateTimeRecord",
                schema: "Masters",
                table: "M_Approve");

            migrationBuilder.DropColumn(
                name: "LastUpdatedRecord",
                schema: "Masters",
                table: "M_Approve");
        }
    }
}
