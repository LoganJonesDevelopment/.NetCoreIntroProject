using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreIntroProject.Migrations
{
    public partial class seedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Snowboards", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Goggles", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Bindings", null });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsDealOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 1, 1, "https://cdn.shopify.com/s/files/1/0257/8209/products/drinkwatersnowboards3_large.jpg?v=1538422318", "https://cdn.shopify.com/s/files/1/0257/8209/products/drinkwatersnowboards3_large.jpg?v=1538422318", true, true, "2019 Edition - V-Rocker Burton Board.", "Burton Board", 12.95m, "Awesome Burton Board" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsDealOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 2, 2, "https://images.evo.com/imgp/700/119214/515639/smith-squad-xl-goggles-.jpg", "https://images.evo.com/imgp/700/119214/515639/smith-squad-xl-goggles-.jpg", true, false, "Best goggles of 2019 for wind/snow resistance, and glare reduction. ", "Smith Squad Goggles", 18.95m, "Smith Squad Snowboard Goggles" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsDealOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 3, 2, "https://summitsports.scene7.com/is/image/SummitSports/573741_573741_1?$600$", "https://summitsports.scene7.com/is/image/SummitSports/573741_573741_1?$600$", true, false, "Flexible and Secure.", "Burton Bindings", 18.95m, "Awesome Burton Bindings" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
