using Microsoft.EntityFrameworkCore.Migrations;

namespace RehberApi.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Iletisims_Rehbers_CurrentUUID",
                table: "Iletisims");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentUUID",
                table: "Iletisims",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Iletisims_Rehbers_CurrentUUID",
                table: "Iletisims",
                column: "CurrentUUID",
                principalTable: "Rehbers",
                principalColumn: "UUID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Iletisims_Rehbers_CurrentUUID",
                table: "Iletisims");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentUUID",
                table: "Iletisims",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Iletisims_Rehbers_CurrentUUID",
                table: "Iletisims",
                column: "CurrentUUID",
                principalTable: "Rehbers",
                principalColumn: "UUID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
