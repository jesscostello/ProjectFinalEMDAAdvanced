using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectFinalEMDAAdvanced.Migrations
{
    public partial class eventsfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Events");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Events",
                nullable: true);
        }
    }
}
