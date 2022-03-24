using Microsoft.EntityFrameworkCore.Migrations;

namespace RehberApi.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rehbers_Iletisims_IletisimId",
                table: "Rehbers");

            migrationBuilder.DropIndex(
                name: "IX_Rehbers_IletisimId",
                table: "Rehbers");

            migrationBuilder.DropColumn(
                name: "IletisimId",
                table: "Rehbers");

            migrationBuilder.AddColumn<int>(
                name: "CurrentUUID",
                table: "Iletisims",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Iletisims_CurrentUUID",
                table: "Iletisims",
                column: "CurrentUUID");

            migrationBuilder.AddForeignKey(
                name: "FK_Iletisims_Rehbers_CurrentUUID",
                table: "Iletisims",
                column: "CurrentUUID",
                principalTable: "Rehbers",
                principalColumn: "UUID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Iletisims_Rehbers_CurrentUUID",
                table: "Iletisims");

            migrationBuilder.DropIndex(
                name: "IX_Iletisims_CurrentUUID",
                table: "Iletisims");

            migrationBuilder.DropColumn(
                name: "CurrentUUID",
                table: "Iletisims");

            migrationBuilder.AddColumn<int>(
                name: "IletisimId",
                table: "Rehbers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rehbers_IletisimId",
                table: "Rehbers",
                column: "IletisimId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rehbers_Iletisims_IletisimId",
                table: "Rehbers",
                column: "IletisimId",
                principalTable: "Iletisims",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
