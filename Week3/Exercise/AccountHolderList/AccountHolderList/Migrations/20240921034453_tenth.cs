using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountHolderList.Migrations
{
    /// <inheritdoc />
    public partial class tenth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HolderId",
                table: "BankAccount");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "AccountHolder",
                newName: "BankAccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BankAccountId",
                table: "AccountHolder",
                newName: "AccountId");

            migrationBuilder.AddColumn<int>(
                name: "HolderId",
                table: "BankAccount",
                type: "int",
                nullable: true);
        }
    }
}
