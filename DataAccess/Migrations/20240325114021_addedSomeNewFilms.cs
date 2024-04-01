using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedSomeNewFilms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Universal City Studios LLC, doing business as Universal Pictures (informally as Universal Studios or simply Universal), is an American film production and distribution company owned by NBCUniversal, a division of Comcast. Founded in 1912 by Carl Laemmle, Mark Dintenfass, Charles O. Baumann, Adam Kessel, Pat Powers, William Swanson, David Horsley, Robert H. Cochrane, and Jules Brulatour, Universal is the oldest surviving film studio in the United States; the world's fifth oldest after Gaumont, Pathé, Titanus and Nordisk Film; and the oldest major film studio in scope of the cinema of the United States, best known as \"Hollywood\", in terms of the overall film market. Its studios are located in Universal City, California, and its corporate offices are located in New York City. In 1962, the studio was acquired by MCA, which was re-launched as NBCUniversal in 2004. The most commercially successful film series from Universal include Fast & Furious, Jurassic Park, and Despicable Me. Additionally, the studio's library includes many individual films such as Jaws and E.T. the Extraterrestrial, both of which became the highest-grossing films of all time during their initial releases. Universal Pictures is a member of the Motion Picture Association (MPA), and was one of the \"Little Three\" majors during Hollywood's golden age.");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Paramount Pictures Corporation is an American film and television production and distribution company and the namesake subsidiary of Paramount Global (Previously known as ViacomCBS). It is the sixth-oldest film studio in the world, the second-oldest film studio in the United States (behind Universal Pictures), and the sole member of the \"Big Five\" film studios located within the city limits of Los Angeles.[1] In 1916, film producer Adolph Zukor put 24 actors and actresses under contract and honored each with a star on the logo.[2] In 1967, the number of stars was reduced to 22 and their hidden meaning was dropped. In 2014, Paramount Pictures became the first major Hollywood studio to distribute all of its films in digital form only.[3] The company's headquarters and studios are located at 5555 Melrose Avenue, Hollywood, California.");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Netflix is an American subscription video on-demand over-the-top streaming service. The service primarily distributes original and acquired films and television shows from various genres, and it is available internationally in multiple languages. Launched on January 16, 2007, nearly a decade after Netflix, Inc. began its pioneering DVD‑by‑mail movie rental service, Netflix is the most-subscribed video on demand streaming media service, with 260.28 million paid memberships in more than 190 countries as of January 2024. By 2022, \"Netflix Original\" productions accounted for half of its library in the United States and the namesake company had ventured into other categories, such as video game publishing of mobile games via its flagship service. As of October 2023, Netflix is the 24th most-visited website in the world with 23.66% of its traffic coming from the United States, followed by the United Kingdom at 5.84% and Brazil at 5.64%.");

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Date", "Description", "Name" },
                values: new object[,]
                {
                    { 5, new DateOnly(1924, 1, 10), "Columbia Pictures Industries, Inc. is an American film production and distribution company that is a member of the Sony Pictures Motion Picture Group a division of Sony Pictures Entertainment, which is one of the Big Five studios and a subsidiary of the multinational conglomerate Sony.", "Columbia Pictures" },
                    { 6, new DateOnly(1935, 5, 31), "20th Century Studios, Inc. is an American film studio currently owned by the Walt Disney Studios, a division of Disney Entertainment, in turn a division of The Walt Disney Company. It is headquartered at the Fox Studio Lot in the Century City area of Los Angeles. Walt Disney Studios Motion Pictures distributes and markets the films produced by 20th Century Studios in theatrical markets.", "Twentieth Century Studios" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "CategoryId", "CompanyId", "ImageUrl", "Name", "Year" },
                values: new object[,]
                {
                    { 5, 4, 2, "https://m.media-amazon.com/images/M/MV5BNWI1NjkxM2MtOTU4My00YzQ5LTliNGMtNmFlM2U5NWM3MDY1XkEyXkFqcGdeQXVyNTUyMzE4Mzg@._V1_.jpg", "Transformers", 2007 },
                    { 2, 2, 5, "https://m.media-amazon.com/images/M/MV5BNGYzNDM0M2QtZDFkNy00OTI2LWIyNjctNjNhNDM5Zjk3NzU2XkEyXkFqcGdeQXVyNjQ3MDg0MTY@._V1_.jpg", "Ghost Busters", 2016 },
                    { 3, 2, 5, "https://m.media-amazon.com/images/M/MV5BNGE5MWJmZWYtN2ZlMi00ZjY1LTlhYTUtMzQ2Y2IxZWQyYTA2XkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_FMjpg_UX1000_.jpg", "Ghost Busters: Frozen Empire", 2024 },
                    { 4, 8, 6, "https://m.media-amazon.com/images/M/MV5BMTk2NDc2MDAxN15BMl5BanBnXkFtZTYwNDc1NDY2._V1_FMjpg_UX1000_.jpg", "The Transporter", 2002 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Universal City Studios LLC, doing business as Universal Pictures (informally as Universal Studios or simply Universal), is an American film production and distribution company owned by NBCUniversal, a division of Comcast. Founded in 1912 by Carl Laemmle, Mark Dintenfass, Charles O. Baumann, Adam Kessel, Pat Powers, William Swanson, David Horsley, Robert H. Cochrane, and Jules Brulatour, Universal is the oldest surviving film studio in the United States; the world's fifth oldest after Gaumont, Pathé, Titanus and Nordisk Film; and the oldest major film studio in scope of the cinema of the United States, best known as \"Hollywood\", in terms of the overall film market. Its studios are located in Universal City, California, and its corporate offices are located in New York City. In 1962, the studio was acquired by MCA, which was re-launched as NBCUniversal in 2004. The most commercially successful film series from Universal include Fast & Furious, Jurassic Park, and Despicable Me. Additionally, the studio's library includes many individual films such as Jaws and E.T. the Extraterrestrial, both of which became the highest-grossing films of all time during their initial releases. Universal Pictures is a member of the Motion Picture Association (MPA), and was one of the \"Little Three\" majors during Hollywood's golden age.[4]");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Paramount Pictures Corporation is an American film and television production and distribution company and the namesake subsidiary of Paramount Global (Previously known as ViacomCBS). It is the sixth-oldest film studio in the world, the second-oldest film studio in the United States (behind Universal Pictures), and the sole member of the \"Big Five\" film studios located within the city limits of Los Angeles.[1] In 1916, film producer Adolph Zukor put 24 actors and actresses under contract and honored each with a star on the logo.[2] In 1967, the number of stars was reduced to 22 and their hidden meaning was dropped. In 2014, Paramount Pictures became the first major Hollywood studio to distribute all of its films in digital form only.[3] The company's headquarters and studios are located at 5555 Melrose Avenue, Hollywood, California.[4]");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Netflix is an American subscription video on-demand over-the-top streaming service. The service primarily distributes original and acquired films and television shows from various genres, and it is available internationally in multiple languages.[6] Launched on January 16, 2007, nearly a decade after Netflix, Inc. began its pioneering DVD‑by‑mail movie rental service, Netflix is the most-subscribed video on demand streaming media service, with 260.28 million paid memberships in more than 190 countries as of January 2024.[5][7] By 2022, \"Netflix Original\" productions accounted for half of its library in the United States and the namesake company had ventured into other categories, such as video game publishing of mobile games via its flagship service. As of October 2023, Netflix is the 24th most-visited website in the world with 23.66% of its traffic coming from the United States, followed by the United Kingdom at 5.84% and Brazil at 5.64%.[8][9]");
        }
    }
}
