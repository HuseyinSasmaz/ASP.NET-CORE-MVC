using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeziRehberim.Migrations
{
    public partial class migrehberacıklama2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Acıklama2",
                table: "Rehbers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acıklama2",
                table: "Rehbers");
        }
    }
}
