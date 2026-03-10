using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fitmongerdb.Migrations
{
    /// <inheritdoc />
    public partial class bodyregion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BodyRegions",
                columns: new[] { "BodyRegionID", "Name" },
                values: new object[,]
                {
                    { 1, "Head" },
                    { 2, "Torso" },
                    { 3, "Legs" },
                    { 4, "Feet" },
                    { 5, "Arms" },
                    { 6, "Neck" },
                    { 7, "Upper Torso" },
                    { 8, "Shins" },
                    { 9, "Wrist" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BodyRegions",
                keyColumn: "BodyRegionID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BodyRegions",
                keyColumn: "BodyRegionID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BodyRegions",
                keyColumn: "BodyRegionID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BodyRegions",
                keyColumn: "BodyRegionID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BodyRegions",
                keyColumn: "BodyRegionID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BodyRegions",
                keyColumn: "BodyRegionID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BodyRegions",
                keyColumn: "BodyRegionID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BodyRegions",
                keyColumn: "BodyRegionID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BodyRegions",
                keyColumn: "BodyRegionID",
                keyValue: 9);
        }
    }
}
