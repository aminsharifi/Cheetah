using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUserInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User_Address",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_Birthdate",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_ContactCell",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_ContactEmail",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_ContactMessenger",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_FirstName",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_InternalPhone",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_LastName",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_NationalCode",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_NotifByCell",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_NotifByEmail",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_NotifByMessenger",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_OfflineForms",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_OvertimeCost",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_RegistrationNumber",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_Temp_IDPersonel",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_UserPicture",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_UserStartPage",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.RenameColumn(
                name: "User_UserPicture",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "UI_UserPicture");

            migrationBuilder.RenameColumn(
                name: "User_RegistrationNumber",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "UI_RegistrationNumber");

            migrationBuilder.RenameColumn(
                name: "User_NotifByMessenger",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "UI_NotifByMessenger");

            migrationBuilder.RenameColumn(
                name: "User_NotifByEmail",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "UI_NotifByEmail");

            migrationBuilder.RenameColumn(
                name: "User_NotifByCell",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "UI_NotifByCell");

            migrationBuilder.RenameColumn(
                name: "User_NationalCode",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "UI_NationalCode");

            migrationBuilder.RenameColumn(
                name: "User_InternalPhone",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "UI_LastName");

            migrationBuilder.RenameColumn(
                name: "User_ContactMessenger",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "UI_ContactMessenger");

            migrationBuilder.RenameColumn(
                name: "User_ContactEmail",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "UI_ContactEmail");

            migrationBuilder.RenameColumn(
                name: "User_ContactCell",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "UI_ContactCell");

            migrationBuilder.RenameColumn(
                name: "User_Birthdate",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "UI_Birthdate");

            migrationBuilder.RenameColumn(
                name: "User_Address",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "UI_Address");

            migrationBuilder.AddColumn<string>(
                name: "UI_FirstName",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UI_InternalPhone",
                schema: "Systems",
                table: "S_UserInformation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UI_FirstName",
                schema: "Systems",
                table: "S_UserInformation");

            migrationBuilder.DropColumn(
                name: "UI_InternalPhone",
                schema: "Systems",
                table: "S_UserInformation");

            migrationBuilder.RenameColumn(
                name: "UI_UserPicture",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "User_UserPicture");

            migrationBuilder.RenameColumn(
                name: "UI_RegistrationNumber",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "User_RegistrationNumber");

            migrationBuilder.RenameColumn(
                name: "UI_NotifByMessenger",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "User_NotifByMessenger");

            migrationBuilder.RenameColumn(
                name: "UI_NotifByEmail",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "User_NotifByEmail");

            migrationBuilder.RenameColumn(
                name: "UI_NotifByCell",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "User_NotifByCell");

            migrationBuilder.RenameColumn(
                name: "UI_NationalCode",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "User_NationalCode");

            migrationBuilder.RenameColumn(
                name: "UI_LastName",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "User_InternalPhone");

            migrationBuilder.RenameColumn(
                name: "UI_ContactMessenger",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "User_ContactMessenger");

            migrationBuilder.RenameColumn(
                name: "UI_ContactEmail",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "User_ContactEmail");

            migrationBuilder.RenameColumn(
                name: "UI_ContactCell",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "User_ContactCell");

            migrationBuilder.RenameColumn(
                name: "UI_Birthdate",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "User_Birthdate");

            migrationBuilder.RenameColumn(
                name: "UI_Address",
                schema: "Systems",
                table: "S_UserInformation",
                newName: "User_Address");

            migrationBuilder.AddColumn<string>(
                name: "User_Address",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "User_Birthdate",
                schema: "Systems",
                table: "S_User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_ContactCell",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_ContactEmail",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_ContactMessenger",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_FirstName",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_InternalPhone",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_LastName",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_NationalCode",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "User_NotifByCell",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "User_NotifByEmail",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "User_NotifByMessenger",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "User_OfflineForms",
                schema: "Systems",
                table: "S_User",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "User_OvertimeCost",
                schema: "Systems",
                table: "S_User",
                type: "money",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_RegistrationNumber",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(215)",
                maxLength: 215,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_Temp_IDPersonel",
                schema: "Systems",
                table: "S_User",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "User_UserPicture",
                schema: "Systems",
                table: "S_User",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "User_UserStartPage",
                schema: "Systems",
                table: "S_User",
                type: "int",
                nullable: true);
        }
    }
}
