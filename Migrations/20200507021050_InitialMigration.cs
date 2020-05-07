using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreSpaceApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false),
                    Designation = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Constelation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constelation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exoplanet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false),
                    Eponyn = table.Column<string>(type: "varchar(200)", nullable: false),
                    Star = table.Column<string>(type: "varchar(20)", nullable: false),
                    Mass = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PerioDays = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    YearDiscover = table.Column<int>(type: "varchar(20)", nullable: false),
                    Distance = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exoplanet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Galaxy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "varchar(40)", nullable: false),
                    Constelation = table.Column<string>(type: "varchar(30)", nullable: false),
                    OriginName = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galaxy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false),
                    Parent = table.Column<string>(type: "varchar(20)", nullable: false),
                    Numeral = table.Column<string>(type: "varchar(20)", nullable: false),
                    RadiusKm = table.Column<string>(type: "varchar(20)", nullable: false),
                    YearDiscover = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false),
                    DiameterKm = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SizeRelative = table.Column<string>(type: "varchar(30)", nullable: false),
                    SunDistance = table.Column<string>(type: "varchar(30)", nullable: false),
                    MassKg = table.Column<string>(type: "varchar(20)", nullable: false),
                    Moons = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Star",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "varchar(30)", nullable: false),
                    Constelation = table.Column<string>(type: "varchar(30)", nullable: false),
                    RightType = table.Column<string>(type: "varchar(15)", nullable: false),
                    ApparentMo = table.Column<string>(type: "varchar(15)", nullable: false),
                    SpectralGyr = table.Column<string>(type: "varchar(15)", nullable: false),
                    Mass = table.Column<string>(type: "varchar(15)", nullable: false),
                    Temperature = table.Column<string>(type: "varchar(15)", nullable: false),
                    Age = table.Column<string>(type: "varchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Star", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comet");

            migrationBuilder.DropTable(
                name: "Constelation");

            migrationBuilder.DropTable(
                name: "Exoplanet");

            migrationBuilder.DropTable(
                name: "Galaxy");

            migrationBuilder.DropTable(
                name: "Moon");

            migrationBuilder.DropTable(
                name: "Planet");

            migrationBuilder.DropTable(
                name: "Star");
        }
    }
}
