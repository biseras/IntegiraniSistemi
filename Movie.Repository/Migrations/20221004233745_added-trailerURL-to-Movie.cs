using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie.Web.Data.Migrations
{
    public partial class addedtrailerURLtoMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "trailerURL",
                table: "Films",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "trailerURL",
                table: "Films");
        }
    }
}
