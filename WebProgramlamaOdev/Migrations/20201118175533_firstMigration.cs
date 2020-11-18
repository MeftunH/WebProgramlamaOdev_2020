using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgramlamaOdev.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "POKEMON_ABILITY",
                columns: table => new
                {
                    POKEMON_ABILITY_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POKEMON_ABILITY", x => x.POKEMON_ABILITY_ID);
                });

            migrationBuilder.CreateTable(
                name: "POKEMON_STAT",
                columns: table => new
                {
                    POKEMON_STAT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STAT_VALUE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POKEMON_STAT", x => x.POKEMON_STAT_ID);
                });

            migrationBuilder.CreateTable(
                name: "POKEMON_TYPE",
                columns: table => new
                {
                    POKEMON_TYPE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POKEMON_TYPE", x => x.POKEMON_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "POKEMON_WEAKNESS",
                columns: table => new
                {
                    POKEMON_WEAKNESS_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POKEMON_WEAKNESS", x => x.POKEMON_WEAKNESS_ID);
                });

            migrationBuilder.CreateTable(
                name: "USER_POKEMON",
                columns: table => new
                {
                    USER_POKEMON_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CREATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_POKEMON", x => x.USER_POKEMON_ID);
                });

            migrationBuilder.CreateTable(
                name: "USER_WISHLIST",
                columns: table => new
                {
                    USER_WISH_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CREATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_WISHLIST", x => x.USER_WISH_ID);
                });

            migrationBuilder.CreateTable(
                name: "ABILITY",
                columns: table => new
                {
                    ABILITY_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABILITY_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ABILITY_DESC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PokemonAbilityPOKEMON_ABILITY_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABILITY", x => x.ABILITY_ID);
                    table.ForeignKey(
                        name: "FK_ABILITY_POKEMON_ABILITY_PokemonAbilityPOKEMON_ABILITY_ID",
                        column: x => x.PokemonAbilityPOKEMON_ABILITY_ID,
                        principalTable: "POKEMON_ABILITY",
                        principalColumn: "POKEMON_ABILITY_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "STAT",
                columns: table => new
                {
                    STAT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STAT_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PokemonStatPOKEMON_STAT_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STAT", x => x.STAT_ID);
                    table.ForeignKey(
                        name: "FK_STAT_POKEMON_STAT_PokemonStatPOKEMON_STAT_ID",
                        column: x => x.PokemonStatPOKEMON_STAT_ID,
                        principalTable: "POKEMON_STAT",
                        principalColumn: "POKEMON_STAT_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TYPE",
                columns: table => new
                {
                    TYPE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TYPE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PokemonTypePOKEMON_TYPE_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TYPE", x => x.TYPE_ID);
                    table.ForeignKey(
                        name: "FK_TYPE_POKEMON_TYPE_PokemonTypePOKEMON_TYPE_ID",
                        column: x => x.PokemonTypePOKEMON_TYPE_ID,
                        principalTable: "POKEMON_TYPE",
                        principalColumn: "POKEMON_TYPE_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WEAKNESS",
                columns: table => new
                {
                    WEAKNESS_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WEAKNESS_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PokemonWeaknessPOKEMON_WEAKNESS_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WEAKNESS", x => x.WEAKNESS_ID);
                    table.ForeignKey(
                        name: "FK_WEAKNESS_POKEMON_WEAKNESS_PokemonWeaknessPOKEMON_WEAKNESS_ID",
                        column: x => x.PokemonWeaknessPOKEMON_WEAKNESS_ID,
                        principalTable: "POKEMON_WEAKNESS",
                        principalColumn: "POKEMON_WEAKNESS_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "POKEMON",
                columns: table => new
                {
                    POKEMON_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    POKEMON_HEIGHT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POKEMON_WEIGHT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POKEMON_CATEGORY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POKEMON_IMG_URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POKEMON_PRICE = table.Column<int>(type: "int", nullable: false),
                    PokemonAbilityPOKEMON_ABILITY_ID = table.Column<int>(type: "int", nullable: true),
                    PokemonStatPOKEMON_STAT_ID = table.Column<int>(type: "int", nullable: true),
                    PokemonTypePOKEMON_TYPE_ID = table.Column<int>(type: "int", nullable: true),
                    PokemonWeaknessPOKEMON_WEAKNESS_ID = table.Column<int>(type: "int", nullable: true),
                    UserPokemonUSER_POKEMON_ID = table.Column<int>(type: "int", nullable: true),
                    UserWishlistUSER_WISH_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POKEMON", x => x.POKEMON_ID);
                    table.ForeignKey(
                        name: "FK_POKEMON_POKEMON_ABILITY_PokemonAbilityPOKEMON_ABILITY_ID",
                        column: x => x.PokemonAbilityPOKEMON_ABILITY_ID,
                        principalTable: "POKEMON_ABILITY",
                        principalColumn: "POKEMON_ABILITY_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_POKEMON_POKEMON_STAT_PokemonStatPOKEMON_STAT_ID",
                        column: x => x.PokemonStatPOKEMON_STAT_ID,
                        principalTable: "POKEMON_STAT",
                        principalColumn: "POKEMON_STAT_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_POKEMON_POKEMON_TYPE_PokemonTypePOKEMON_TYPE_ID",
                        column: x => x.PokemonTypePOKEMON_TYPE_ID,
                        principalTable: "POKEMON_TYPE",
                        principalColumn: "POKEMON_TYPE_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_POKEMON_POKEMON_WEAKNESS_PokemonWeaknessPOKEMON_WEAKNESS_ID",
                        column: x => x.PokemonWeaknessPOKEMON_WEAKNESS_ID,
                        principalTable: "POKEMON_WEAKNESS",
                        principalColumn: "POKEMON_WEAKNESS_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_POKEMON_USER_POKEMON_UserPokemonUSER_POKEMON_ID",
                        column: x => x.UserPokemonUSER_POKEMON_ID,
                        principalTable: "USER_POKEMON",
                        principalColumn: "USER_POKEMON_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_POKEMON_USER_WISHLIST_UserWishlistUSER_WISH_ID",
                        column: x => x.UserWishlistUSER_WISH_ID,
                        principalTable: "USER_WISHLIST",
                        principalColumn: "USER_WISH_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "USER",
                columns: table => new
                {
                    USER_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USER_MAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USER_PASSWORD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USER_ABOUT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USER_BIRTHDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    USER_BALANCE = table.Column<int>(type: "int", nullable: false),
                    USER_ISADMIN = table.Column<bool>(type: "bit", nullable: false),
                    UserPokemonUSER_POKEMON_ID = table.Column<int>(type: "int", nullable: true),
                    UserWishlistUSER_WISH_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.USER_ID);
                    table.ForeignKey(
                        name: "FK_USER_USER_POKEMON_UserPokemonUSER_POKEMON_ID",
                        column: x => x.UserPokemonUSER_POKEMON_ID,
                        principalTable: "USER_POKEMON",
                        principalColumn: "USER_POKEMON_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_USER_USER_WISHLIST_UserWishlistUSER_WISH_ID",
                        column: x => x.UserWishlistUSER_WISH_ID,
                        principalTable: "USER_WISHLIST",
                        principalColumn: "USER_WISH_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ABILITY_PokemonAbilityPOKEMON_ABILITY_ID",
                table: "ABILITY",
                column: "PokemonAbilityPOKEMON_ABILITY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_PokemonAbilityPOKEMON_ABILITY_ID",
                table: "POKEMON",
                column: "PokemonAbilityPOKEMON_ABILITY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_PokemonStatPOKEMON_STAT_ID",
                table: "POKEMON",
                column: "PokemonStatPOKEMON_STAT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_PokemonTypePOKEMON_TYPE_ID",
                table: "POKEMON",
                column: "PokemonTypePOKEMON_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_PokemonWeaknessPOKEMON_WEAKNESS_ID",
                table: "POKEMON",
                column: "PokemonWeaknessPOKEMON_WEAKNESS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_UserPokemonUSER_POKEMON_ID",
                table: "POKEMON",
                column: "UserPokemonUSER_POKEMON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_UserWishlistUSER_WISH_ID",
                table: "POKEMON",
                column: "UserWishlistUSER_WISH_ID");

            migrationBuilder.CreateIndex(
                name: "IX_STAT_PokemonStatPOKEMON_STAT_ID",
                table: "STAT",
                column: "PokemonStatPOKEMON_STAT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TYPE_PokemonTypePOKEMON_TYPE_ID",
                table: "TYPE",
                column: "PokemonTypePOKEMON_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_UserPokemonUSER_POKEMON_ID",
                table: "USER",
                column: "UserPokemonUSER_POKEMON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_UserWishlistUSER_WISH_ID",
                table: "USER",
                column: "UserWishlistUSER_WISH_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WEAKNESS_PokemonWeaknessPOKEMON_WEAKNESS_ID",
                table: "WEAKNESS",
                column: "PokemonWeaknessPOKEMON_WEAKNESS_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ABILITY");

            migrationBuilder.DropTable(
                name: "POKEMON");

            migrationBuilder.DropTable(
                name: "STAT");

            migrationBuilder.DropTable(
                name: "TYPE");

            migrationBuilder.DropTable(
                name: "USER");

            migrationBuilder.DropTable(
                name: "WEAKNESS");

            migrationBuilder.DropTable(
                name: "POKEMON_ABILITY");

            migrationBuilder.DropTable(
                name: "POKEMON_STAT");

            migrationBuilder.DropTable(
                name: "POKEMON_TYPE");

            migrationBuilder.DropTable(
                name: "USER_POKEMON");

            migrationBuilder.DropTable(
                name: "USER_WISHLIST");

            migrationBuilder.DropTable(
                name: "POKEMON_WEAKNESS");
        }
    }
}
