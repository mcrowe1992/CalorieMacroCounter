using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calorie_Macro_Counter.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedQuantity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "FoodItems");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "FoodItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
