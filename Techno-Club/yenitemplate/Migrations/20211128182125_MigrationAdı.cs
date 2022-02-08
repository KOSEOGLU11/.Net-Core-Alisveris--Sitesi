using Microsoft.EntityFrameworkCore.Migrations;

namespace yenitemplate.Migrations
{
    public partial class MigrationAdı : Migration
    {
        private object nullable;

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GuestResponses",
                columns: table => new
                {
                    email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(500)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestResponses", x => x.email);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuestResponses");
        }
    }
}
