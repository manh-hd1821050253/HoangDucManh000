using Microsoft.EntityFrameworkCore.Migrations;

namespace HoangDucManh000.Migrations
{
    public partial class InitialCreatee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HDM0000",
                columns: table => new
                {
                    HDMId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HDMName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HDMGender = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HDM0000", x => x.HDMId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HDM0000");
        }
    }
}
