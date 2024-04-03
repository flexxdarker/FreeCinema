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
                new Company() {Id = 1, Name = "Universal Pictures", Date = new DateOnly(1912, 04, 30), Description = "Universal City Studios LLC, doing business as Universal Pictures (informally as Universal Studios or simply Universal), is an American film production and distribution company owned by NBCUniversal, a division of Comcast. Founded in 1912 by Carl Laemmle, Mark Dintenfass, Charles O. Baumann, Adam Kessel, Pat Powers, William Swanson, David Horsley, Robert H. Cochrane, and Jules Brulatour, Universal is the oldest surviving film studio in the United States; the world's fifth oldest after Gaumont, Pathé, Titanus and Nordisk Film; and the oldest major film studio in scope of the cinema of the United States, best known as \"Hollywood\", in terms of the overall film market. Its studios are located in Universal City, California, and its corporate offices are located in New York City. In 1962, the studio was acquired by MCA, which was re-launched as NBCUniversal in 2004. The most commercially successful film series from Universal include Fast & Furious, Jurassic Park, and Despicable Me. Additionally, the studio's library includes many individual films such as Jaws and E.T. the Extraterrestrial, both of which became the highest-grossing films of all time during their initial releases. Universal Pictures is a member of the Motion Picture Association (MPA), and was one of the \"Little Three\" majors during Hollywood's golden age."},
                new Company() {Id = 2, Name = "Paramount Pictures", Date = new DateOnly(1912, 05, 8), Description = "Paramount Pictures Corporation is an American film and television production and distribution company and the namesake subsidiary of Paramount Global (Previously known as ViacomCBS). It is the sixth-oldest film studio in the world, the second-oldest film studio in the United States (behind Universal Pictures), and the sole member of the \"Big Five\" film studios located within the city limits of Los Angeles.[1] In 1916, film producer Adolph Zukor put 24 actors and actresses under contract and honored each with a star on the logo.[2] In 1967, the number of stars was reduced to 22 and their hidden meaning was dropped. In 2014, Paramount Pictures became the first major Hollywood studio to distribute all of its films in digital form only.[3] The company's headquarters and studios are located at 5555 Melrose Avenue, Hollywood, California."},
                new Company() {Id = 3, Name = "Warner Bros", Date = new DateOnly(1923, 04, 4), Description = "WARNER BROS. is a fully integrated entertainment company and a global leader in the creation, production, distribution, licensing and marketing of all forms of entertainment. A Warner Bros. Discovery company, the Studio is home to one of the most successful collections of brands in the world and stands at the forefront of every aspect of the entertainment industry, from feature film, television, digital and home entertainment production and worldwide distribution to DVD and Blu-ray, animation, comic books, videogames, and product and brand licensing. The company’s vast library, one of the most prestigious and valuable in the world, consists of more than 145,000 hours of programming, including 12,500 feature films and 2,400 television programs comprised of more than 150,000 individual episodes."},
                new Company() {Id = 4, Name = "Netflix", Date = new DateOnly(1997, 08, 29), Description = "Netflix is an American subscription video on-demand over-the-top streaming service. The service primarily distributes original and acquired films and television shows from various genres, and it is available internationally in multiple languages. Launched on January 16, 2007, nearly a decade after Netflix, Inc. began its pioneering DVD‑by‑mail movie rental service, Netflix is the most-subscribed video on demand streaming media service, with 260.28 million paid memberships in more than 190 countries as of January 2024. By 2022, \"Netflix Original\" productions accounted for half of its library in the United States and the namesake company had ventured into other categories, such as video game publishing of mobile games via its flagship service. As of October 2023, Netflix is the 24th most-visited website in the world with 23.66% of its traffic coming from the United States, followed by the United Kingdom at 5.84% and Brazil at 5.64%."},
                new Company() {Id = 5, Name = "Columbia Pictures", Date = new DateOnly(1924, 01, 10), Description = "Columbia Pictures Industries, Inc. is an American film production and distribution company that is a member of the Sony Pictures Motion Picture Group a division of Sony Pictures Entertainment, which is one of the Big Five studios and a subsidiary of the multinational conglomerate Sony."},
                new Company() {Id = 6, Name = "Twentieth Century Studios", Date = new DateOnly(1935, 05,31), Description = "20th Century Studios, Inc. is an American film studio currently owned by the Walt Disney Studios, a division of Disney Entertainment, in turn a division of The Walt Disney Company. It is headquartered at the Fox Studio Lot in the Century City area of Los Angeles. Walt Disney Studios Motion Pictures distributes and markets the films produced by 20th Century Studios in theatrical markets."}
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
                new Film() {Id = 1, Name = "Fast&Furious", CategoryId = (int)Categories.Action, CompanyId = 1, Year = 2001, ImageUrl = "https://wallpaperaccess.com/full/1494975.jpg"},
                new Film() {Id = 2, Name = "Ghost Busters", CategoryId = (int)Categories.Comedy, CompanyId = 5, Year = 2016, ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGYzNDM0M2QtZDFkNy00OTI2LWIyNjctNjNhNDM5Zjk3NzU2XkEyXkFqcGdeQXVyNjQ3MDg0MTY@._V1_.jpg"},
                new Film() {Id = 3, Name = "Ghost Busters: Frozen Empire", CategoryId = (int)Categories.Comedy, CompanyId = 5, Year = 2024, ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGE5MWJmZWYtN2ZlMi00ZjY1LTlhYTUtMzQ2Y2IxZWQyYTA2XkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_FMjpg_UX1000_.jpg"},
                new Film() {Id = 4, Name = "The Transporter", CategoryId = (int)Categories.Thriller, CompanyId = 6, Year = 2002, ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTk2NDc2MDAxN15BMl5BanBnXkFtZTYwNDc1NDY2._V1_FMjpg_UX1000_.jpg"},
                new Film() {Id = 5, Name = "Transformers", CategoryId = (int)Categories.Fantasy, CompanyId = 2, Year = 2007, ImageUrl = "https://m.media-amazon.com/images/M/MV5BNWI1NjkxM2MtOTU4My00YzQ5LTliNGMtNmFlM2U5NWM3MDY1XkEyXkFqcGdeQXVyNTUyMzE4Mzg@._V1_.jpg"}
            });
            builder.Entity<CinemaHall>().HasData(new[]
            {
                new CinemaHall {Id = 1, Name ="First Hall"}
            });
            builder.Entity<Place>().HasData(new[]
            {
                new Place() {Id = 1, CinemaHallId = 1, Number = 1}, new Place() {Id = 2, CinemaHallId = 1, Number = 2},
                new Place() {Id = 4, CinemaHallId = 1, Number = 4}, new Place() {Id = 3, CinemaHallId = 1, Number = 3},
                new Place() {Id = 5, CinemaHallId = 1, Number = 5}, new Place() {Id = 6, CinemaHallId = 1, Number = 6},
                new Place() {Id = 7, CinemaHallId = 1, Number = 7}, new Place() {Id = 8, CinemaHallId = 1, Number = 8},
                new Place() {Id = 9, CinemaHallId = 1, Number = 9}, new Place() {Id = 10, CinemaHallId = 1, Number = 10},
                new Place() {Id = 11, CinemaHallId = 1, Number = 11}, new Place() {Id = 12, CinemaHallId = 1, Number = 12},
                new Place() {Id = 13, CinemaHallId = 1, Number = 13}, new Place() {Id = 14, CinemaHallId = 1, Number = 14},
                new Place() {Id = 15, CinemaHallId = 1, Number = 15}, new Place() {Id = 16, CinemaHallId = 1, Number = 16},
                new Place() {Id = 17, CinemaHallId = 1, Number = 17}, new Place() {Id = 18, CinemaHallId = 1, Number = 18},
                new Place() {Id = 19, CinemaHallId = 1, Number = 19}, new Place() {Id = 20, CinemaHallId = 1, Number = 20},
                new Place() {Id = 21, CinemaHallId = 1, Number = 21}, new Place() {Id = 22, CinemaHallId = 1, Number = 22},
                new Place() {Id = 23, CinemaHallId = 1, Number = 23}, new Place() {Id = 24, CinemaHallId = 1, Number = 24},
                new Place() {Id = 25, CinemaHallId = 1, Number = 25}, new Place() {Id = 26, CinemaHallId = 1, Number = 26},
                new Place() {Id = 27, CinemaHallId = 1, Number = 27}, new Place() {Id = 28, CinemaHallId = 1, Number = 28},
                new Place() {Id = 29, CinemaHallId = 1, Number = 29}, new Place() {Id = 30, CinemaHallId = 1, Number = 30},
            });   
        }
    }
}
