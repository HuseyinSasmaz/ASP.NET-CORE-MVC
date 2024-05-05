using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeziRehberim.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RehberID",
                table: "Yorumlars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RehberID",
                table: "GidilecekYerlers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlars_RehberID",
                table: "Yorumlars",
                column: "RehberID");

            migrationBuilder.CreateIndex(
                name: "IX_GidilecekYerlers_RehberID",
                table: "GidilecekYerlers",
                column: "RehberID");

            migrationBuilder.AddForeignKey(
                name: "FK_GidilecekYerlers_Rehbers_RehberID",
                table: "GidilecekYerlers",
                column: "RehberID",
                principalTable: "Rehbers",
                principalColumn: "RehberID");

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlars_Rehbers_RehberID",
                table: "Yorumlars",
                column: "RehberID",
                principalTable: "Rehbers",
                principalColumn: "RehberID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GidilecekYerlers_Rehbers_RehberID",
                table: "GidilecekYerlers");

            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlars_Rehbers_RehberID",
                table: "Yorumlars");

            migrationBuilder.DropIndex(
                name: "IX_Yorumlars_RehberID",
                table: "Yorumlars");

            migrationBuilder.DropIndex(
                name: "IX_GidilecekYerlers_RehberID",
                table: "GidilecekYerlers");

            migrationBuilder.DropColumn(
                name: "RehberID",
                table: "Yorumlars");

            migrationBuilder.DropColumn(
                name: "RehberID",
                table: "GidilecekYerlers");
        }
    }
}
