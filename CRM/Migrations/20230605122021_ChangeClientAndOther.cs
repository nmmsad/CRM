using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.Migrations
{
    /// <inheritdoc />
    public partial class ChangeClientAndOther : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdStaff",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "TgUsername",
                table: "UserTg",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "TgId",
                table: "UserTg",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Fio",
                table: "User",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Role",
                newName: "RoleName");

            migrationBuilder.RenameColumn(
                name: "Fio",
                table: "CliesntsHistory",
                newName: "TimeJob");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Client",
                newName: "WhatsAppContact");

            migrationBuilder.RenameColumn(
                name: "CarDescription",
                table: "Client",
                newName: "UserName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RequestTime",
                table: "UserTg",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<bool>(
                name: "IsRequest",
                table: "UserTg",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "CliesntsHistory",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarName",
                table: "Client",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TgContact",
                table: "Client",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "CliesntsHistory");

            migrationBuilder.DropColumn(
                name: "CarName",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "TgContact",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "UserTg",
                newName: "TgId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserTg",
                newName: "TgUsername");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "User",
                newName: "Fio");

            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "Role",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "TimeJob",
                table: "CliesntsHistory",
                newName: "Fio");

            migrationBuilder.RenameColumn(
                name: "WhatsAppContact",
                table: "Client",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Client",
                newName: "CarDescription");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RequestTime",
                table: "UserTg",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsRequest",
                table: "UserTg",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdStaff",
                table: "Client",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber",
                table: "Client",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Client",
                type: "integer",
                nullable: true);
        }
    }
}
