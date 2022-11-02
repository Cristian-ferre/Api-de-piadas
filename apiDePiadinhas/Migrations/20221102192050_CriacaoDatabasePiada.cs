using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiDePiadinhas.Migrations
{
    public partial class CriacaoDatabasePiada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Piadas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Resp = table.Column<string>(type: "text", nullable:true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piadas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Piadas");
        }
    }
}
