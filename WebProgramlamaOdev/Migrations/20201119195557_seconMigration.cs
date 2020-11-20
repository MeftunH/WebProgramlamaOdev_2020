using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgramlamaOdev.Migrations
{
    public partial class seconMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ABILITY",
                columns: table => new
                {
                    ABILITY_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABILITY_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ABILITY_DESC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABILITY", x => x.ABILITY_ID);
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
                    POKEMON_PRICE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POKEMON", x => x.POKEMON_ID);
                });

            migrationBuilder.CreateTable(
                name: "STAT",
                columns: table => new
                {
                    STAT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STAT_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STAT", x => x.STAT_ID);
                });

            migrationBuilder.CreateTable(
                name: "TYPE",
                columns: table => new
                {
                    TYPE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TYPE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TYPE", x => x.TYPE_ID);
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
                    USER_ISADMIN = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.USER_ID);
                });

            migrationBuilder.CreateTable(
                name: "WEAKNESS",
                columns: table => new
                {
                    WEAKNESS_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WEAKNESS_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WEAKNESS", x => x.WEAKNESS_ID);
                });

            migrationBuilder.CreateTable(
                name: "POKEMON_ABILITY",
                columns: table => new
                {
                    POKEMON_ABILITY_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    POKEMON_ID = table.Column<int>(type: "int", nullable: false),
                    ABILITY_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POKEMON_ABILITY", x => x.POKEMON_ABILITY_ID);
                    table.ForeignKey(
                        name: "FK_POKEMON_ABILITY_ABILITY_ABILITY_ID",
                        column: x => x.ABILITY_ID,
                        principalTable: "ABILITY",
                        principalColumn: "ABILITY_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_POKEMON_ABILITY_POKEMON_POKEMON_ID",
                        column: x => x.POKEMON_ID,
                        principalTable: "POKEMON",
                        principalColumn: "POKEMON_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "POKEMON_STAT",
                columns: table => new
                {
                    POKEMON_STAT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    POKEMON_ID = table.Column<int>(type: "int", nullable: false),
                    STAT_ID = table.Column<int>(type: "int", nullable: false),
                    STAT_VALUE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POKEMON_STAT", x => x.POKEMON_STAT_ID);
                    table.ForeignKey(
                        name: "FK_POKEMON_STAT_POKEMON_POKEMON_ID",
                        column: x => x.POKEMON_ID,
                        principalTable: "POKEMON",
                        principalColumn: "POKEMON_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_POKEMON_STAT_STAT_STAT_ID",
                        column: x => x.STAT_ID,
                        principalTable: "STAT",
                        principalColumn: "STAT_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "POKEMON_TYPE",
                columns: table => new
                {
                    POKEMON_TYPE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    POKEMON_ID = table.Column<int>(type: "int", nullable: false),
                    TYPE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POKEMON_TYPE", x => x.POKEMON_TYPE_ID);
                    table.ForeignKey(
                        name: "FK_POKEMON_TYPE_POKEMON_POKEMON_ID",
                        column: x => x.POKEMON_ID,
                        principalTable: "POKEMON",
                        principalColumn: "POKEMON_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_POKEMON_TYPE_TYPE_TYPE_ID",
                        column: x => x.TYPE_ID,
                        principalTable: "TYPE",
                        principalColumn: "TYPE_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "USER_POKEMON",
                columns: table => new
                {
                    USER_POKEMON_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ID = table.Column<int>(type: "int", nullable: false),
                    POKEMON_ID = table.Column<int>(type: "int", nullable: false),
                    CREATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_POKEMON", x => x.USER_POKEMON_ID);
                    table.ForeignKey(
                        name: "FK_USER_POKEMON_POKEMON_POKEMON_ID",
                        column: x => x.POKEMON_ID,
                        principalTable: "POKEMON",
                        principalColumn: "POKEMON_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USER_POKEMON_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "USER",
                        principalColumn: "USER_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "USER_WISHLIST",
                columns: table => new
                {
                    USER_WISH_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    POKEMON_ID = table.Column<int>(type: "int", nullable: false),
                    USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_WISHLIST", x => x.USER_WISH_ID);
                    table.ForeignKey(
                        name: "FK_USER_WISHLIST_POKEMON_POKEMON_ID",
                        column: x => x.POKEMON_ID,
                        principalTable: "POKEMON",
                        principalColumn: "POKEMON_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USER_WISHLIST_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "USER",
                        principalColumn: "USER_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "POKEMON_WEAKNESS",
                columns: table => new
                {
                    POKEMON_WEAKNESS_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    POKEMON_ID = table.Column<int>(type: "int", nullable: false),
                    WEAKNESS_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POKEMON_WEAKNESS", x => x.POKEMON_WEAKNESS_ID);
                    table.ForeignKey(
                        name: "FK_POKEMON_WEAKNESS_POKEMON_POKEMON_ID",
                        column: x => x.POKEMON_ID,
                        principalTable: "POKEMON",
                        principalColumn: "POKEMON_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_POKEMON_WEAKNESS_WEAKNESS_WEAKNESS_ID",
                        column: x => x.WEAKNESS_ID,
                        principalTable: "WEAKNESS",
                        principalColumn: "WEAKNESS_ID",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_USER_WISHLIST_POKEMON_ID",
                table: "USER_WISHLIST",
                column: "POKEMON_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_USER_WISHLIST_USER_ID",
                table: "USER_WISHLIST",
                column: "USER_ID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "POKEMON_ABILITY");

            migrationBuilder.DropTable(
                name: "POKEMON_STAT");

            migrationBuilder.DropTable(
                name: "POKEMON_TYPE");

            migrationBuilder.DropTable(
                name: "POKEMON_WEAKNESS");

            migrationBuilder.DropTable(
                name: "USER_POKEMON");

            migrationBuilder.DropTable(
                name: "USER_WISHLIST");

            migrationBuilder.DropTable(
                name: "ABILITY");

            migrationBuilder.DropTable(
                name: "STAT");

            migrationBuilder.DropTable(
                name: "TYPE");

            migrationBuilder.DropTable(
                name: "WEAKNESS");

            migrationBuilder.DropTable(
                name: "POKEMON");

            migrationBuilder.DropTable(
                name: "USER");
        }
    }
}
