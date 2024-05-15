using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace la_mia_pizzeria_static.Migrations
{
    public partial class CreatePizzas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Pizzeria_PizzeriaId",
                table: "Pizzas");

            migrationBuilder.DropTable(
                name: "Pizzeria");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_PizzeriaId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "PizzeriaId",
                table: "Pizzas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PizzeriaId",
                table: "Pizzas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Pizzeria",
                columns: table => new
                {
                    PizzeriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzeria", x => x.PizzeriaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_PizzeriaId",
                table: "Pizzas",
                column: "PizzeriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Pizzeria_PizzeriaId",
                table: "Pizzas",
                column: "PizzeriaId",
                principalTable: "Pizzeria",
                principalColumn: "PizzeriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
