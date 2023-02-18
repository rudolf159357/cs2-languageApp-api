using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cs2_languageApp_api.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "english",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Word = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Translation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_english", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "german",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Word = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Translation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_german", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "hungarian",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Word = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Translation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hungarian", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "english",
                columns: new[] { "Id", "Translation", "Word" },
                values: new object[,]
                {
                    { 1, "auto", "car" },
                    { 2, "kocka", "cube" }
                });

            migrationBuilder.InsertData(
                table: "german",
                columns: new[] { "Id", "Translation", "Word" },
                values: new object[,]
                {
                    { 1, "hospital", "krankenwagen" },
                    { 2, "sister", "schwester" }
                });

            migrationBuilder.InsertData(
                table: "hungarian",
                columns: new[] { "Id", "Translation", "Word" },
                values: new object[,]
                {
                    { 1, "sorry", "bocsanot" },
                    { 2, "hallo", "Szia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "english");

            migrationBuilder.DropTable(
                name: "german");

            migrationBuilder.DropTable(
                name: "hungarian");
        }
    }
}
