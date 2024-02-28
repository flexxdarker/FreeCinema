using BusinessLogic.Entities;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder builder)
        {
            builder.Entity<Company>().HasData(new[]
            {
                new Company() {Id = 1, Name = "Universal Pictures", Date = new DateOnly(1912, 04, 30), Description = "Universal City Studios LLC, doing business as Universal Pictures (informally as Universal Studios or simply Universal), is an American film production and distribution company owned by NBCUniversal, a division of Comcast. Founded in 1912 by Carl Laemmle, Mark Dintenfass, Charles O. Baumann, Adam Kessel, Pat Powers, William Swanson, David Horsley, Robert H. Cochrane, and Jules Brulatour, Universal is the oldest surviving film studio in the United States; the world's fifth oldest after Gaumont, Pathé, Titanus and Nordisk Film; and the oldest major film studio in scope of the cinema of the United States, best known as \"Hollywood\", in terms of the overall film market. Its studios are located in Universal City, California, and its corporate offices are located in New York City. In 1962, the studio was acquired by MCA, which was re-launched as NBCUniversal in 2004. The most commercially successful film series from Universal include Fast & Furious, Jurassic Park, and Despicable Me. Additionally, the studio's library includes many individual films such as Jaws and E.T. the Extraterrestrial, both of which became the highest-grossing films of all time during their initial releases. Universal Pictures is a member of the Motion Picture Association (MPA), and was one of the \"Little Three\" majors during Hollywood's golden age.[4]"},
                new Company() {Id = 2, Name = "Paramount Pictures", Date = new DateOnly(1912, 05, 8), Description = "Paramount Pictures Corporation is an American film and television production and distribution company and the namesake subsidiary of Paramount Global (Previously known as ViacomCBS). It is the sixth-oldest film studio in the world, the second-oldest film studio in the United States (behind Universal Pictures), and the sole member of the \"Big Five\" film studios located within the city limits of Los Angeles.[1] In 1916, film producer Adolph Zukor put 24 actors and actresses under contract and honored each with a star on the logo.[2] In 1967, the number of stars was reduced to 22 and their hidden meaning was dropped. In 2014, Paramount Pictures became the first major Hollywood studio to distribute all of its films in digital form only.[3] The company's headquarters and studios are located at 5555 Melrose Avenue, Hollywood, California.[4]"},
                new Company() {Id = 3, Name = "Warner Bros", Date = new DateOnly(1923, 04, 4), Description = "WARNER BROS. is a fully integrated entertainment company and a global leader in the creation, production, distribution, licensing and marketing of all forms of entertainment. A Warner Bros. Discovery company, the Studio is home to one of the most successful collections of brands in the world and stands at the forefront of every aspect of the entertainment industry, from feature film, television, digital and home entertainment production and worldwide distribution to DVD and Blu-ray, animation, comic books, videogames, and product and brand licensing. The company’s vast library, one of the most prestigious and valuable in the world, consists of more than 145,000 hours of programming, including 12,500 feature films and 2,400 television programs comprised of more than 150,000 individual episodes."},
                new Company() {Id = 4, Name = "Netflix", Date = new DateOnly(1997, 08, 29), Description = "Netflix is an American subscription video on-demand over-the-top streaming service. The service primarily distributes original and acquired films and television shows from various genres, and it is available internationally in multiple languages.[6] Launched on January 16, 2007, nearly a decade after Netflix, Inc. began its pioneering DVD‑by‑mail movie rental service, Netflix is the most-subscribed video on demand streaming media service, with 260.28 million paid memberships in more than 190 countries as of January 2024.[5][7] By 2022, \"Netflix Original\" productions accounted for half of its library in the United States and the namesake company had ventured into other categories, such as video game publishing of mobile games via its flagship service. As of October 2023, Netflix is the 24th most-visited website in the world with 23.66% of its traffic coming from the United States, followed by the United Kingdom at 5.84% and Brazil at 5.64%.[8][9]"}
            });
            builder.Entity<Category>().HasData(new[]
            {
                new Category() {Id = (int)Categories.Fantasy, Name = "Fantasy"},
                new Category() {Id = (int)Categories.Horror, Name = "Horror"},
                new Category() {Id = (int)Categories.Comedy, Name = "Comedy"},
                new Category() {Id = (int)Categories.Thriller, Name = "Thriller"},
                new Category() {Id = (int)Categories.Romance, Name = "Romance"},
                new Category() {Id = (int)Categories.Action, Name = "Action"},
                new Category() {Id = (int)Categories.Drama, Name = "Drama"},
                new Category() {Id = (int)Categories.Mystery, Name = "Mystery"},
                new Category() {Id = (int)Categories.Other, Name = "Other"}
            });
            builder.Entity<Film>().HasData(new[]
            {
                new Film() {Id = 1, Name = "Fast&Furious", CategoryId = (int)Categories.Action, CinemaHallId = 1, CompanyId = 1, Year = 2001}
            });
        }
    }
}
