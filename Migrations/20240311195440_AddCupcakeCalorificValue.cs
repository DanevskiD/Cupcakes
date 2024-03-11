using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cupcakes.Migrations
{
    public partial class AddCupcakeCalorificValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CalorificValue",
                table: "Cupcakes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Cupcakes",
                keyColumn: "CupcakeId",
                keyValue: 1,
                column: "CalorificValue",
                value: 355);

            migrationBuilder.UpdateData(
                table: "Cupcakes",
                keyColumn: "CupcakeId",
                keyValue: 2,
                column: "CalorificValue",
                value: 195);

            migrationBuilder.UpdateData(
                table: "Cupcakes",
                keyColumn: "CupcakeId",
                keyValue: 3,
                column: "CalorificValue",
                value: 295);

            migrationBuilder.UpdateData(
                table: "Cupcakes",
                keyColumn: "CupcakeId",
                keyValue: 4,
                column: "CalorificValue",
                value: 360);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CalorificValue",
                table: "Cupcakes");
        }
    }
}
