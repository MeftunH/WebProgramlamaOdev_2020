using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProje.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ABILITY",
                columns: table => new
                {
                    ABILITY_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABILITY_NAME = table.Column<string>(nullable: true),
                    ABILITY_DESC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABILITY", x => x.ABILITY_ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    USER_ABOUT = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    USER_BIRTHDATE = table.Column<DateTime>(nullable: true),
                    Imgurl = table.Column<string>(nullable: true),
                    USER_BALANCE = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "POKEMON",
                columns: table => new
                {
                    POKEMON_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    POKEMON_NAME = table.Column<string>(nullable: true),
                    POKEMON_HEIGHT = table.Column<string>(nullable: true),
                    POKEMON_WEIGHT = table.Column<string>(nullable: true),
                    POKEMON_CATEGORY = table.Column<string>(nullable: true),
                    POKEMON_IMG_URL = table.Column<string>(nullable: true),
                    POKEMON_PRICE = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POKEMON", x => x.POKEMON_ID);
                });

            migrationBuilder.CreateTable(
                name: "STAT",
                columns: table => new
                {
                    STAT_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STAT_NAME = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STAT", x => x.STAT_ID);
                });

            migrationBuilder.CreateTable(
                name: "TYPE",
                columns: table => new
                {
                    TYPE_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TYPE_NAME = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TYPE", x => x.TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "WEAKNESS",
                columns: table => new
                {
                    WEAKNESS_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WEAKNESS_NAME = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WEAKNESS", x => x.WEAKNESS_ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "POKEMON_ABILITY",
                columns: table => new
                {
                    POKEMON_ABILITY_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    POKEMON_ID = table.Column<int>(nullable: false),
                    ABILITY_ID = table.Column<int>(nullable: false)
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
                name: "USER_POKEMON",
                columns: table => new
                {
                    USER_POKEMON_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<string>(nullable: true),
                    POKEMON_ID = table.Column<int>(nullable: false),
                    CREATION_DATE = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_POKEMON", x => x.USER_POKEMON_ID);
                    table.ForeignKey(
                        name: "FK_USER_POKEMON_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_USER_POKEMON_POKEMON_POKEMON_ID",
                        column: x => x.POKEMON_ID,
                        principalTable: "POKEMON",
                        principalColumn: "POKEMON_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "USER_WISHLIST",
                columns: table => new
                {
                    USER_WISH_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    POKEMON_ID = table.Column<int>(nullable: false),
                    Id = table.Column<string>(nullable: true),
                    CREATION_DATE = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_WISHLIST", x => x.USER_WISH_ID);
                    table.ForeignKey(
                        name: "FK_USER_WISHLIST_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_USER_WISHLIST_POKEMON_POKEMON_ID",
                        column: x => x.POKEMON_ID,
                        principalTable: "POKEMON",
                        principalColumn: "POKEMON_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "POKEMON_STAT",
                columns: table => new
                {
                    POKEMON_STAT_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    POKEMON_ID = table.Column<int>(nullable: false),
                    STAT_ID = table.Column<int>(nullable: false),
                    STAT_VALUE = table.Column<int>(nullable: false)
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
                    POKEMON_TYPE_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    POKEMON_ID = table.Column<int>(nullable: false),
                    TYPE_ID = table.Column<int>(nullable: false)
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
                name: "POKEMON_WEAKNESS",
                columns: table => new
                {
                    POKEMON_WEAKNESS_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    POKEMON_ID = table.Column<int>(nullable: false),
                    WEAKNESS_ID = table.Column<int>(nullable: false)
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_ABILITY_ABILITY_ID",
                table: "POKEMON_ABILITY",
                column: "ABILITY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_ABILITY_POKEMON_ID",
                table: "POKEMON_ABILITY",
                column: "POKEMON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_STAT_POKEMON_ID",
                table: "POKEMON_STAT",
                column: "POKEMON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_STAT_STAT_ID",
                table: "POKEMON_STAT",
                column: "STAT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_TYPE_POKEMON_ID",
                table: "POKEMON_TYPE",
                column: "POKEMON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_TYPE_TYPE_ID",
                table: "POKEMON_TYPE",
                column: "TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_WEAKNESS_POKEMON_ID",
                table: "POKEMON_WEAKNESS",
                column: "POKEMON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POKEMON_WEAKNESS_WEAKNESS_ID",
                table: "POKEMON_WEAKNESS",
                column: "WEAKNESS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_POKEMON_Id",
                table: "USER_POKEMON",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_USER_POKEMON_POKEMON_ID",
                table: "USER_POKEMON",
                column: "POKEMON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_WISHLIST_Id",
                table: "USER_WISHLIST",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_USER_WISHLIST_POKEMON_ID",
                table: "USER_WISHLIST",
                column: "POKEMON_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ABILITY");

            migrationBuilder.DropTable(
                name: "STAT");

            migrationBuilder.DropTable(
                name: "TYPE");

            migrationBuilder.DropTable(
                name: "WEAKNESS");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "POKEMON");
        }
    }
}
