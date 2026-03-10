using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace fitmongerdb.Migrations
{
    /// <inheritdoc />
    public partial class article : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BodyRegions",
                columns: table => new
                {
                    BodyRegionID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyRegions", x => x.BodyRegionID);
                });

            migrationBuilder.CreateTable(
                name: "ArticleTypes",
                columns: table => new
                {
                    ArticleTypeID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    BodyRegionID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleTypes", x => x.ArticleTypeID);
                    table.ForeignKey(
                        name: "FK_ArticleTypes_BodyRegions_BodyRegionID",
                        column: x => x.BodyRegionID,
                        principalTable: "BodyRegions",
                        principalColumn: "BodyRegionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DateAquired = table.Column<DateOnly>(type: "date", nullable: false),
                    DateLastWorn = table.Column<DateOnly>(type: "date", nullable: true),
                    ArticleTypeID = table.Column<int>(type: "integer", nullable: false),
                    Size = table.Column<char>(type: "character(1)", nullable: true),
                    Material = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleID);
                    table.ForeignKey(
                        name: "FK_Articles_ArticleTypes_ArticleTypeID",
                        column: x => x.ArticleTypeID,
                        principalTable: "ArticleTypes",
                        principalColumn: "ArticleTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleTypeID",
                table: "Articles",
                column: "ArticleTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTypes_BodyRegionID",
                table: "ArticleTypes",
                column: "BodyRegionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "ArticleTypes");

            migrationBuilder.DropTable(
                name: "BodyRegions");
        }
    }
}
