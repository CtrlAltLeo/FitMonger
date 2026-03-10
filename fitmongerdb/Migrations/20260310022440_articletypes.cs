using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fitmongerdb.Migrations
{
    /// <inheritdoc />
    public partial class articletypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleTypes_BodyRegions_BodyRegionID",
                table: "ArticleTypes");

            migrationBuilder.AlterColumn<int>(
                name: "BodyRegionID",
                table: "ArticleTypes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "ArticleTypes",
                columns: new[] { "ArticleTypeID", "BodyRegionID", "Name" },
                values: new object[,]
                {
                    { 1, 2, "Shirt" },
                    { 2, 3, "Pants" },
                    { 3, 4, "Shoes" },
                    { 4, 1, "Hat" },
                    { 5, 5, "Gloves" },
                    { 6, 6, "Scarf" },
                    { 7, 7, "Jacket" },
                    { 8, 8, "Socks" },
                    { 9, 9, "Watch" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleTypes_BodyRegions_BodyRegionID",
                table: "ArticleTypes",
                column: "BodyRegionID",
                principalTable: "BodyRegions",
                principalColumn: "BodyRegionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleTypes_BodyRegions_BodyRegionID",
                table: "ArticleTypes");

            migrationBuilder.DeleteData(
                table: "ArticleTypes",
                keyColumn: "ArticleTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ArticleTypes",
                keyColumn: "ArticleTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ArticleTypes",
                keyColumn: "ArticleTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ArticleTypes",
                keyColumn: "ArticleTypeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ArticleTypes",
                keyColumn: "ArticleTypeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ArticleTypes",
                keyColumn: "ArticleTypeID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ArticleTypes",
                keyColumn: "ArticleTypeID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ArticleTypes",
                keyColumn: "ArticleTypeID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ArticleTypes",
                keyColumn: "ArticleTypeID",
                keyValue: 9);

            migrationBuilder.AlterColumn<int>(
                name: "BodyRegionID",
                table: "ArticleTypes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleTypes_BodyRegions_BodyRegionID",
                table: "ArticleTypes",
                column: "BodyRegionID",
                principalTable: "BodyRegions",
                principalColumn: "BodyRegionID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
