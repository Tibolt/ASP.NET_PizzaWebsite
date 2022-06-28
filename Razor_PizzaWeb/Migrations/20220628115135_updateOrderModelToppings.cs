using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Razor_PizzaWeb.Migrations
{
    public partial class updateOrderModelToppings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cheese",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Ham",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Mushroom",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "SalamiPeperoni",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "TomatoSauce",
                table: "PizzaOrders");

            migrationBuilder.DropColumn(
                name: "Tuna",
                table: "PizzaOrders");

            migrationBuilder.AddColumn<string>(
                name: "Toppings",
                table: "PizzaOrders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Toppings",
                table: "PizzaOrders");

            migrationBuilder.AddColumn<bool>(
                name: "Cheese",
                table: "PizzaOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ham",
                table: "PizzaOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Mushroom",
                table: "PizzaOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SalamiPeperoni",
                table: "PizzaOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TomatoSauce",
                table: "PizzaOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Tuna",
                table: "PizzaOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
