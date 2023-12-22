using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorShop.Migrations
{
    /// <inheritdoc />
    public partial class addAndSeedCategoryAndItemTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Fruits and Vegetables" },
                    { 2, 2, "Meats and Dairies" },
                    { 3, 3, "Beverage" },
                    { 4, 4, "Cleaning Products" },
                    { 5, 5, "Toiletries" },
                    { 6, 6, "Frozen Food" },
                    { 7, 7, "Pets" },
                    { 8, 8, "Electronics" },
                    { 9, 9, "Toys" },
                    { 10, 10, "Vegan" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean at.", "Apple", 2.0, 30 },
                    { 2, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean at.", "Banana (bunch)", 7.0, 15 },
                    { 3, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean at.", "Ground beef - 1kg", 30.0, 10 },
                    { 4, 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean at.", "Detergent", 1.8999999999999999, 30 },
                    { 5, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean at.", "Coke soda - 350ml", 4.5, 60 },
                    { 6, 9, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean at.", "Toy car", 29.899999999999999, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
