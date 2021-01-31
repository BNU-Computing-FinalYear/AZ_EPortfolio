using Microsoft.EntityFrameworkCore.Migrations;

namespace AZ_EPortfolio.Data.Migrations
{
    public partial class RenamedUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Portfolios");

            migrationBuilder.AddColumn<string>(
                name: "UserKey",
                table: "Portfolios",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserKey",
                table: "Portfolios");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Portfolios",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");
        }
    }
}
