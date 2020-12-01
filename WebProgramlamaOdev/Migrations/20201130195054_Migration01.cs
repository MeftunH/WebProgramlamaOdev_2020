using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgramlamaOdev.Migrations
{
    public partial class Migration01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_USER_WISHLIST_POKEMON_ID",
                table: "USER_WISHLIST");

            migrationBuilder.DropIndex(
                name: "IX_USER_WISHLIST_USER_ID",
                table: "USER_WISHLIST");

            migrationBuilder.DropIndex(
                name: "IX_USER_POKEMON_POKEMON_ID",
                table: "USER_POKEMON");

            migrationBuilder.DropIndex(
                name: "IX_USER_POKEMON_USER_ID",
                table: "USER_POKEMON");

            migrationBuilder.DropIndex(
                name: "IX_POKEMON_WEAKNESS_POKEMON_ID",
                table: "POKEMON_WEAKNESS");

            migrationBuilder.DropIndex(
                name: "IX_POKEMON_WEAKNESS_WEAKNESS_ID",
                table: "POKEMON_WEAKNESS");

            migrationBuilder.DropIndex(
                name: "IX_POKEMON_TYPE_POKEMON_ID",
                table: "POKEMON_TYPE");

            migrationBuilder.DropIndex(
                name: "IX_POKEMON_TYPE_TYPE_ID",
                table: "POKEMON_TYPE");

            migrationBuilder.DropIndex(
                name: "IX_POKEMON_STAT_POKEMON_ID",
                table: "POKEMON_STAT");

            migrationBuilder.DropIndex(
                name: "IX_POKEMON_STAT_STAT_ID",
                table: "POKEMON_STAT");

            migrationBuilder.DropIndex(
                name: "IX_POKEMON_ABILITY_ABILITY_ID",
                table: "POKEMON_ABILITY");

            migrationBuilder.DropIndex(
                name: "IX_POKEMON_ABILITY_POKEMON_ID",
                table: "POKEMON_ABILITY");

            migrationBuilder.CreateIndex(
                name: "IX_USER_WISHLIST_POKEMON_ID",
                table: "USER_WISHLIST",
                column: "POKEMON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_WISHLIST_USER_ID",
                table: "USER_WISHLIST",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_POKEMON_POKEMON_ID",
                table: "USER_POKEMON",
                column: "POKEMON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_POKEMON_USER_ID",
                table: "USER_POKEMON",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_WEAKNESS_POKEMON_ID",
                table: "POKEMON_WEAKNESS",
                column: "POKEMON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_WEAKNESS_WEAKNESS_ID",
                table: "POKEMON_WEAKNESS",
                column: "WEAKNESS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_TYPE_POKEMON_ID",
                table: "POKEMON_TYPE",
                column: "POKEMON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_TYPE_TYPE_ID",
                table: "POKEMON_TYPE",
                column: "TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_STAT_POKEMON_ID",
                table: "POKEMON_STAT",
                column: "POKEMON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_STAT_STAT_ID",
                table: "POKEMON_STAT",
                column: "STAT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_ABILITY_ABILITY_ID",
                table: "POKEMON_ABILITY",
                column: "ABILITY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_ABILITY_POKEMON_ID",
                table: "POKEMON_ABILITY",
                column: "POKEMON_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_USER_WISHLIST_POKEMON_ID",
                table: "USER_WISHLIST");

            migrationBuilder.DropIndex(
                name: "IX_USER_WISHLIST_USER_ID",
                table: "USER_WISHLIST");

            migrationBuilder.DropIndex(
                name: "IX_USER_POKEMON_POKEMON_ID",
                table: "USER_POKEMON");

            migrationBuilder.DropIndex(
                name: "IX_USER_POKEMON_USER_ID",
                table: "USER_POKEMON");

            migrationBuilder.DropIndex(
                name: "IX_POKEMON_WEAKNESS_POKEMON_ID",
                table: "POKEMON_WEAKNESS");

            migrationBuilder.DropIndex(
                name: "IX_POKEMON_WEAKNESS_WEAKNESS_ID",
                table: "POKEMON_WEAKNESS");

            migrationBuilder.DropIndex(
                name: "IX_POKEMON_TYPE_POKEMON_ID",
                table: "POKEMON_TYPE");

            migrationBuilder.DropIndex(
                name: "IX_POKEMON_TYPE_TYPE_ID",
                table: "POKEMON_TYPE");

            migrationBuilder.DropIndex(
                name: "IX_POKEMON_STAT_POKEMON_ID",
                table: "POKEMON_STAT");

            migrationBuilder.DropIndex(
                name: "IX_POKEMON_STAT_STAT_ID",
                table: "POKEMON_STAT");

            migrationBuilder.DropIndex(
                name: "IX_POKEMON_ABILITY_ABILITY_ID",
                table: "POKEMON_ABILITY");

            migrationBuilder.DropIndex(
                name: "IX_POKEMON_ABILITY_POKEMON_ID",
                table: "POKEMON_ABILITY");

            migrationBuilder.CreateIndex(
                name: "IX_USER_WISHLIST_POKEMON_ID",
                table: "USER_WISHLIST",
                column: "POKEMON_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_USER_WISHLIST_USER_ID",
                table: "USER_WISHLIST",
                column: "USER_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_USER_POKEMON_POKEMON_ID",
                table: "USER_POKEMON",
                column: "POKEMON_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_USER_POKEMON_USER_ID",
                table: "USER_POKEMON",
                column: "USER_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_WEAKNESS_POKEMON_ID",
                table: "POKEMON_WEAKNESS",
                column: "POKEMON_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_WEAKNESS_WEAKNESS_ID",
                table: "POKEMON_WEAKNESS",
                column: "WEAKNESS_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_TYPE_POKEMON_ID",
                table: "POKEMON_TYPE",
                column: "POKEMON_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_TYPE_TYPE_ID",
                table: "POKEMON_TYPE",
                column: "TYPE_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_STAT_POKEMON_ID",
                table: "POKEMON_STAT",
                column: "POKEMON_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_STAT_STAT_ID",
                table: "POKEMON_STAT",
                column: "STAT_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_ABILITY_ABILITY_ID",
                table: "POKEMON_ABILITY",
                column: "ABILITY_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_ABILITY_POKEMON_ID",
                table: "POKEMON_ABILITY",
                column: "POKEMON_ID",
                unique: true);
        }
    }
}
