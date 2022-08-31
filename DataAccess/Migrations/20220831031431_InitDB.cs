using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeaconInfo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    msg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gmac = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeaconInfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SensorInfo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<int>(type: "int", nullable: false),
                    dmac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rssi = table.Column<int>(type: "int", nullable: false),
                    ver = table.Column<int>(type: "int", nullable: false),
                    vbatt = table.Column<int>(type: "int", nullable: false),
                    temp = table.Column<double>(type: "float", nullable: false),
                    humidty = table.Column<double>(type: "float", nullable: false),
                    x0 = table.Column<int>(type: "int", nullable: false),
                    y0 = table.Column<int>(type: "int", nullable: false),
                    z0 = table.Column<int>(type: "int", nullable: false),
                    data1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uuid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    majorID = table.Column<int>(type: "int", nullable: true),
                    minorID = table.Column<int>(type: "int", nullable: true),
                    refpower = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensorInfo", x => x.id);
                    table.ForeignKey(
                        name: "FK_SensorInfo_BeaconInfo_id",
                        column: x => x.id,
                        principalTable: "BeaconInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SensorInfo");

            migrationBuilder.DropTable(
                name: "BeaconInfo");
        }
    }
}
