using Microsoft.EntityFrameworkCore.Migrations;

namespace RehberApi.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Iletisims_Rehbers_RehberlerUUID",
                table: "Iletisims");

            migrationBuilder.DropIndex(
                name: "IX_Iletisims_RehberlerUUID",
                table: "Iletisims");

            migrationBuilder.DropColumn(
                name: "RehberlerUUID",
                table: "Iletisims");

            migrationBuilder.AddColumn<int>(
                name: "IletisimID",
                table: "Rehbers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rehbers_IletisimID",
                table: "Rehbers",
                column: "IletisimID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rehbers_Iletisims_IletisimID",
                table: "Rehbers",
                column: "IletisimID",
                principalTable: "Iletisims",
                principalColumn: "IletisimID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rehbers_Iletisims_IletisimID",
                table: "Rehbers");

            migrationBuilder.DropIndex(
                name: "IX_Rehbers_IletisimID",
                table: "Rehbers");

            migrationBuilder.DropColumn(
                name: "IletisimID",
                table: "Rehbers");

            migrationBuilder.AddColumn<int>(
                name: "RehberlerUUID",
                table: "Iletisims",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Iletisims_RehberlerUUID",
                table: "Iletisims",
                column: "RehberlerUUID");

            migrationBuilder.AddForeignKey(
                name: "FK_Iletisims_Rehbers_RehberlerUUID",
                table: "Iletisims",
                column: "RehberlerUUID",
                principalTable: "Rehbers",
                principalColumn: "UUID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
