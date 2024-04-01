using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class pp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Films_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Films_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CinemaHalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinemaHalls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CinemaHalls_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Row = table.Column<int>(type: "int", nullable: false),
                    CinemaHallId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Places_CinemaHalls_CinemaHallId",
                        column: x => x.CinemaHallId,
                        principalTable: "CinemaHalls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    CinemaHallId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_CinemaHalls_CinemaHallId",
                        column: x => x.CinemaHallId,
                        principalTable: "CinemaHalls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sessions_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlacePrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsReserved = table.Column<bool>(type: "bit", nullable: false),
                    SessionId = table.Column<int>(type: "int", nullable: false),
                    PlaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacePrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlacePrices_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlacePrices_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Comedy" },
                    { 3, "Drama" },
                    { 4, "Fantasy" },
                    { 5, "Horror" },
                    { 6, "Mystery" },
                    { 7, "Romance" },
                    { 8, "Thriller" },
                    { 9, "Other" }
                });

            migrationBuilder.InsertData(
                table: "CinemaHalls",
                columns: new[] { "Id", "FilmId", "Name" },
                values: new object[] { 1, null, "First Hall" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Date", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateOnly(1912, 4, 30), "Universal City Studios LLC, doing business as Universal Pictures (informally as Universal Studios or simply Universal), is an American film production and distribution company owned by NBCUniversal, a division of Comcast. Founded in 1912 by Carl Laemmle, Mark Dintenfass, Charles O. Baumann, Adam Kessel, Pat Powers, William Swanson, David Horsley, Robert H. Cochrane, and Jules Brulatour, Universal is the oldest surviving film studio in the United States; the world's fifth oldest after Gaumont, Pathé, Titanus and Nordisk Film; and the oldest major film studio in scope of the cinema of the United States, best known as \"Hollywood\", in terms of the overall film market. Its studios are located in Universal City, California, and its corporate offices are located in New York City. In 1962, the studio was acquired by MCA, which was re-launched as NBCUniversal in 2004. The most commercially successful film series from Universal include Fast & Furious, Jurassic Park, and Despicable Me. Additionally, the studio's library includes many individual films such as Jaws and E.T. the Extraterrestrial, both of which became the highest-grossing films of all time during their initial releases. Universal Pictures is a member of the Motion Picture Association (MPA), and was one of the \"Little Three\" majors during Hollywood's golden age.[4]", "Universal Pictures" },
                    { 2, new DateOnly(1912, 5, 8), "Paramount Pictures Corporation is an American film and television production and distribution company and the namesake subsidiary of Paramount Global (Previously known as ViacomCBS). It is the sixth-oldest film studio in the world, the second-oldest film studio in the United States (behind Universal Pictures), and the sole member of the \"Big Five\" film studios located within the city limits of Los Angeles.[1] In 1916, film producer Adolph Zukor put 24 actors and actresses under contract and honored each with a star on the logo.[2] In 1967, the number of stars was reduced to 22 and their hidden meaning was dropped. In 2014, Paramount Pictures became the first major Hollywood studio to distribute all of its films in digital form only.[3] The company's headquarters and studios are located at 5555 Melrose Avenue, Hollywood, California.[4]", "Paramount Pictures" },
                    { 3, new DateOnly(1923, 4, 4), "WARNER BROS. is a fully integrated entertainment company and a global leader in the creation, production, distribution, licensing and marketing of all forms of entertainment. A Warner Bros. Discovery company, the Studio is home to one of the most successful collections of brands in the world and stands at the forefront of every aspect of the entertainment industry, from feature film, television, digital and home entertainment production and worldwide distribution to DVD and Blu-ray, animation, comic books, videogames, and product and brand licensing. The company’s vast library, one of the most prestigious and valuable in the world, consists of more than 145,000 hours of programming, including 12,500 feature films and 2,400 television programs comprised of more than 150,000 individual episodes.", "Warner Bros" },
                    { 4, new DateOnly(1997, 8, 29), "Netflix is an American subscription video on-demand over-the-top streaming service. The service primarily distributes original and acquired films and television shows from various genres, and it is available internationally in multiple languages.[6] Launched on January 16, 2007, nearly a decade after Netflix, Inc. began its pioneering DVD‑by‑mail movie rental service, Netflix is the most-subscribed video on demand streaming media service, with 260.28 million paid memberships in more than 190 countries as of January 2024.[5][7] By 2022, \"Netflix Original\" productions accounted for half of its library in the United States and the namesake company had ventured into other categories, such as video game publishing of mobile games via its flagship service. As of October 2023, Netflix is the 24th most-visited website in the world with 23.66% of its traffic coming from the United States, followed by the United Kingdom at 5.84% and Brazil at 5.64%.[8][9]", "Netflix" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "CategoryId", "CompanyId", "ImageUrl", "Name", "Year" },
                values: new object[] { 1, 1, 1, "https://wallpaperaccess.com/full/1494975.jpg", "Fast&Furious", 2001 });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "CinemaHallId", "Number", "Row" },
                values: new object[,]
                {
                    { 1, 1, 1, 0 },
                    { 2, 1, 2, 0 },
                    { 3, 1, 3, 0 },
                    { 4, 1, 4, 0 },
                    { 5, 1, 5, 0 },
                    { 6, 1, 6, 0 },
                    { 7, 1, 7, 0 },
                    { 8, 1, 8, 0 },
                    { 9, 1, 9, 0 },
                    { 10, 1, 10, 0 },
                    { 11, 1, 11, 0 },
                    { 12, 1, 12, 0 },
                    { 13, 1, 13, 0 },
                    { 14, 1, 14, 0 },
                    { 15, 1, 15, 0 },
                    { 16, 1, 16, 0 },
                    { 17, 1, 17, 0 },
                    { 18, 1, 18, 0 },
                    { 19, 1, 19, 0 },
                    { 20, 1, 20, 0 },
                    { 21, 1, 21, 0 },
                    { 22, 1, 22, 0 },
                    { 23, 1, 23, 0 },
                    { 24, 1, 24, 0 },
                    { 25, 1, 25, 0 },
                    { 26, 1, 26, 0 },
                    { 27, 1, 27, 0 },
                    { 28, 1, 28, 0 },
                    { 29, 1, 29, 0 },
                    { 30, 1, 30, 0 }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "CinemaHallId", "DateTime", "FilmId" },
                values: new object[] { 1, 1, new DateTime(2024, 3, 15, 19, 20, 59, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "PlacePrices",
                columns: new[] { "Id", "IsReserved", "PlaceId", "Price", "SessionId" },
                values: new object[,]
                {
                    { 1, false, 1, 150m, 1 },
                    { 2, false, 2, 150m, 1 },
                    { 3, false, 3, 150m, 1 },
                    { 4, false, 4, 150m, 1 },
                    { 5, false, 5, 150m, 1 },
                    { 6, false, 6, 150m, 1 },
                    { 7, false, 7, 150m, 1 },
                    { 8, false, 8, 150m, 1 },
                    { 9, false, 9, 150m, 1 },
                    { 10, false, 10, 150m, 1 },
                    { 11, false, 11, 150m, 1 },
                    { 12, false, 12, 150m, 1 },
                    { 13, false, 13, 150m, 1 },
                    { 14, false, 14, 150m, 1 },
                    { 15, false, 15, 150m, 1 },
                    { 16, false, 16, 150m, 1 },
                    { 17, false, 17, 150m, 1 },
                    { 18, false, 18, 150m, 1 },
                    { 19, false, 19, 150m, 1 },
                    { 20, false, 20, 150m, 1 },
                    { 21, false, 21, 150m, 1 },
                    { 22, false, 22, 150m, 1 },
                    { 23, false, 23, 150m, 1 },
                    { 24, false, 24, 150m, 1 },
                    { 25, false, 25, 150m, 1 },
                    { 26, false, 26, 150m, 1 },
                    { 27, false, 27, 150m, 1 },
                    { 28, false, 28, 150m, 1 },
                    { 29, false, 29, 150m, 1 },
                    { 30, false, 30, 150m, 1 }
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
                name: "IX_CinemaHalls_FilmId",
                table: "CinemaHalls",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_CategoryId",
                table: "Films",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_CompanyId",
                table: "Films",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacePrices_PlaceId",
                table: "PlacePrices",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacePrices_SessionId",
                table: "PlacePrices",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Places_CinemaHallId",
                table: "Places",
                column: "CinemaHallId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_CinemaHallId",
                table: "Sessions",
                column: "CinemaHallId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_FilmId",
                table: "Sessions",
                column: "FilmId");
        }

        /// <inheritdoc />
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
                name: "PlacePrices");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CinemaHalls");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
