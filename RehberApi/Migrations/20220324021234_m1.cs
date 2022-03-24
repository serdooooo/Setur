using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RehberApi.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rehbers",
                columns: table => new
                {
                    UUID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    Soyad = table.Column<string>(type: "text", nullable: true),
                    Firma = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rehbers", x => x.UUID);
                });

            migrationBuilder.CreateTable(
                name: "Iletisims",
                columns: table => new
                {
                    IletisimID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Telefon = table.Column<string>(type: "text", nullable: true),
                    Mail = table.Column<string>(type: "text", nullable: true),
                    Konum = table.Column<string>(type: "text", nullable: true),
                    RehberlerUUID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisims", x => x.IletisimID);
                    table.ForeignKey(
                        name: "FK_Iletisims_Rehbers_RehberlerUUID",
                        column: x => x.RehberlerUUID,
                        principalTable: "Rehbers",
                        principalColumn: "UUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Iletisims_RehberlerUUID",
                table: "Iletisims",
                column: "RehberlerUUID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iletisims");

            migrationBuilder.DropTable(
                name: "Rehbers");
        }
    }
}
