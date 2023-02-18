using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheetahDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SUserInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "User_S_UserInformationIdRecord",
                schema: "Systems",
                table: "S_User",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "S_UserInformation",
                schema: "Systems",
                columns: table => new
                {
                    IdRecord = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserNotifByEmail = table.Column<bool>(name: "User_NotifByEmail", type: "bit", nullable: true),
                    UserNotifByMessenger = table.Column<bool>(name: "User_NotifByMessenger", type: "bit", nullable: true),
                    UserNotifByCell = table.Column<bool>(name: "User_NotifByCell", type: "bit", nullable: true),
                    UserContactEmail = table.Column<string>(name: "User_ContactEmail", type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserContactMessenger = table.Column<string>(name: "User_ContactMessenger", type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserContactCell = table.Column<string>(name: "User_ContactCell", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserUserPicture = table.Column<byte[]>(name: "User_UserPicture", type: "varbinary(max)", nullable: true),
                    UserNationalCode = table.Column<string>(name: "User_NationalCode", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserBirthdate = table.Column<DateTime>(name: "User_Birthdate", type: "datetime2", nullable: true),
                    UserInternalPhone = table.Column<string>(name: "User_InternalPhone", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserAddress = table.Column<string>(name: "User_Address", type: "nvarchar(512)", maxLength: 512, nullable: true),
                    UserRegistrationNumber = table.Column<string>(name: "User_RegistrationNumber", type: "nvarchar(215)", maxLength: 215, nullable: true),
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
                    table.PrimaryKey("PK_S_UserInformation", x => x.IdRecord);
                });

            migrationBuilder.CreateIndex(
                name: "IX_S_User_User_S_UserInformationIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_S_UserInformationIdRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_S_User_S_UserInformation_User_S_UserInformationIdRecord",
                schema: "Systems",
                table: "S_User",
                column: "User_S_UserInformationIdRecord",
                principalSchema: "Systems",
                principalTable: "S_UserInformation",
                principalColumn: "IdRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_S_User_S_UserInformation_User_S_UserInformationIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropTable(
                name: "S_UserInformation",
                schema: "Systems");

            migrationBuilder.DropIndex(
                name: "IX_S_User_User_S_UserInformationIdRecord",
                schema: "Systems",
                table: "S_User");

            migrationBuilder.DropColumn(
                name: "User_S_UserInformationIdRecord",
                schema: "Systems",
                table: "S_User");
        }
    }
}
