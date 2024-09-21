using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountHolderList.Migrations
{
    /// <inheritdoc />
    public partial class _13th : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankAccountId",
                table: "AccountHolder");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BankAccountId",
                table: "AccountHolder",
                type: "int",
                nullable: true);
        }
    }
}
