using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mapa.Migrations
{
    public partial class addtypepoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "typePoint",
                table: "Point",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "typePoint",
                table: "Point");
        }
    }
}
