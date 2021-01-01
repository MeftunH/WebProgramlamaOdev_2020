using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProje.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "USER_ISADMIN",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "USER_MAIL",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "USER_NAME",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "USER_PASSWORD",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "USER_ABOUT",
                table: "AspNetUsers",
                type: "nvarchar(400)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "USER_ABOUT",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "USER_ISADMIN",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "USER_MAIL",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "USER_NAME",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "USER_PASSWORD",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
           
        }
    }
}
