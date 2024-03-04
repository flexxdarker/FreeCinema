﻿// <auto-generated />
using System;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(CinemaDbContext))]
    [Migration("20240304180205_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusinessLogic.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("BusinessLogic.Entities.Cinema_Hall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FilmId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.ToTable("Cinema_Hall");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = ""
                        });
                });

            modelBuilder.Entity("BusinessLogic.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Company");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateOnly(1912, 4, 30),
                            Description = "Universal City Studios LLC, doing business as Universal Pictures (informally as Universal Studios or simply Universal), is an American film production and distribution company owned by NBCUniversal, a division of Comcast. Founded in 1912 by Carl Laemmle, Mark Dintenfass, Charles O. Baumann, Adam Kessel, Pat Powers, William Swanson, David Horsley, Robert H. Cochrane, and Jules Brulatour, Universal is the oldest surviving film studio in the United States; the world's fifth oldest after Gaumont, Pathé, Titanus and Nordisk Film; and the oldest major film studio in scope of the cinema of the United States, best known as \"Hollywood\", in terms of the overall film market. Its studios are located in Universal City, California, and its corporate offices are located in New York City. In 1962, the studio was acquired by MCA, which was re-launched as NBCUniversal in 2004. The most commercially successful film series from Universal include Fast & Furious, Jurassic Park, and Despicable Me. Additionally, the studio's library includes many individual films such as Jaws and E.T. the Extraterrestrial, both of which became the highest-grossing films of all time during their initial releases. Universal Pictures is a member of the Motion Picture Association (MPA), and was one of the \"Little Three\" majors during Hollywood's golden age.[4]",
                            Name = "Universal Pictures"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateOnly(1912, 5, 8),
                            Description = "Paramount Pictures Corporation is an American film and television production and distribution company and the namesake subsidiary of Paramount Global (Previously known as ViacomCBS). It is the sixth-oldest film studio in the world, the second-oldest film studio in the United States (behind Universal Pictures), and the sole member of the \"Big Five\" film studios located within the city limits of Los Angeles.[1] In 1916, film producer Adolph Zukor put 24 actors and actresses under contract and honored each with a star on the logo.[2] In 1967, the number of stars was reduced to 22 and their hidden meaning was dropped. In 2014, Paramount Pictures became the first major Hollywood studio to distribute all of its films in digital form only.[3] The company's headquarters and studios are located at 5555 Melrose Avenue, Hollywood, California.[4]",
                            Name = "Paramount Pictures"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateOnly(1923, 4, 4),
                            Description = "WARNER BROS. is a fully integrated entertainment company and a global leader in the creation, production, distribution, licensing and marketing of all forms of entertainment. A Warner Bros. Discovery company, the Studio is home to one of the most successful collections of brands in the world and stands at the forefront of every aspect of the entertainment industry, from feature film, television, digital and home entertainment production and worldwide distribution to DVD and Blu-ray, animation, comic books, videogames, and product and brand licensing. The company’s vast library, one of the most prestigious and valuable in the world, consists of more than 145,000 hours of programming, including 12,500 feature films and 2,400 television programs comprised of more than 150,000 individual episodes.",
                            Name = "Warner Bros"
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateOnly(1997, 8, 29),
                            Description = "Netflix is an American subscription video on-demand over-the-top streaming service. The service primarily distributes original and acquired films and television shows from various genres, and it is available internationally in multiple languages.[6] Launched on January 16, 2007, nearly a decade after Netflix, Inc. began its pioneering DVD‑by‑mail movie rental service, Netflix is the most-subscribed video on demand streaming media service, with 260.28 million paid memberships in more than 190 countries as of January 2024.[5][7] By 2022, \"Netflix Original\" productions accounted for half of its library in the United States and the namesake company had ventured into other categories, such as video game publishing of mobile games via its flagship service. As of October 2023, Netflix is the 24th most-visited website in the world with 23.66% of its traffic coming from the United States, followed by the United Kingdom at 5.84% and Brazil at 5.64%.[8][9]",
                            Name = "Netflix"
                        });
                });

            modelBuilder.Entity("BusinessLogic.Entities.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cinema_HallId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Cinema_HallId");

                    b.ToTable("Place");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cinema_HallId = 1,
                            Number = 1
                        },
                        new
                        {
                            Id = 2,
                            Cinema_HallId = 1,
                            Number = 2
                        },
                        new
                        {
                            Id = 4,
                            Cinema_HallId = 1,
                            Number = 4
                        },
                        new
                        {
                            Id = 3,
                            Cinema_HallId = 1,
                            Number = 3
                        },
                        new
                        {
                            Id = 5,
                            Cinema_HallId = 1,
                            Number = 5
                        },
                        new
                        {
                            Id = 6,
                            Cinema_HallId = 1,
                            Number = 6
                        },
                        new
                        {
                            Id = 7,
                            Cinema_HallId = 1,
                            Number = 7
                        },
                        new
                        {
                            Id = 8,
                            Cinema_HallId = 1,
                            Number = 8
                        },
                        new
                        {
                            Id = 9,
                            Cinema_HallId = 1,
                            Number = 9
                        },
                        new
                        {
                            Id = 10,
                            Cinema_HallId = 1,
                            Number = 10
                        },
                        new
                        {
                            Id = 11,
                            Cinema_HallId = 1,
                            Number = 11
                        },
                        new
                        {
                            Id = 12,
                            Cinema_HallId = 1,
                            Number = 12
                        },
                        new
                        {
                            Id = 13,
                            Cinema_HallId = 1,
                            Number = 13
                        },
                        new
                        {
                            Id = 14,
                            Cinema_HallId = 1,
                            Number = 14
                        },
                        new
                        {
                            Id = 15,
                            Cinema_HallId = 1,
                            Number = 15
                        },
                        new
                        {
                            Id = 16,
                            Cinema_HallId = 1,
                            Number = 16
                        },
                        new
                        {
                            Id = 17,
                            Cinema_HallId = 1,
                            Number = 17
                        },
                        new
                        {
                            Id = 18,
                            Cinema_HallId = 1,
                            Number = 18
                        },
                        new
                        {
                            Id = 19,
                            Cinema_HallId = 1,
                            Number = 19
                        },
                        new
                        {
                            Id = 20,
                            Cinema_HallId = 1,
                            Number = 20
                        },
                        new
                        {
                            Id = 21,
                            Cinema_HallId = 1,
                            Number = 21
                        },
                        new
                        {
                            Id = 22,
                            Cinema_HallId = 1,
                            Number = 22
                        },
                        new
                        {
                            Id = 23,
                            Cinema_HallId = 1,
                            Number = 23
                        },
                        new
                        {
                            Id = 24,
                            Cinema_HallId = 1,
                            Number = 24
                        },
                        new
                        {
                            Id = 25,
                            Cinema_HallId = 1,
                            Number = 25
                        },
                        new
                        {
                            Id = 26,
                            Cinema_HallId = 1,
                            Number = 26
                        },
                        new
                        {
                            Id = 27,
                            Cinema_HallId = 1,
                            Number = 27
                        },
                        new
                        {
                            Id = 28,
                            Cinema_HallId = 1,
                            Number = 28
                        },
                        new
                        {
                            Id = 29,
                            Cinema_HallId = 1,
                            Number = 29
                        },
                        new
                        {
                            Id = 30,
                            Cinema_HallId = 1,
                            Number = 30
                        });
                });

            modelBuilder.Entity("BusinessLogic.Entities.Sessions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cinema_HallId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Cinema_HallId");

                    b.HasIndex("FilmId");

                    b.ToTable("Sessions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cinema_HallId = 1,
                            DateTime = new DateTime(2024, 3, 15, 19, 20, 59, 0, DateTimeKind.Unspecified),
                            FilmId = 1
                        });
                });

            modelBuilder.Entity("BusinessLogic.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("Film");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CompanyId = 5,
                            Name = "Fast&Furious",
                            Year = 2001,
                            imageUrl = "https://wallpaperaccess.com/full/1494975.jpg"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BusinessLogic.Entities.Cinema_Hall", b =>
                {
                    b.HasOne("DataAccess.Entities.Film", null)
                        .WithMany("Halls")
                        .HasForeignKey("FilmId");
                });

            modelBuilder.Entity("BusinessLogic.Entities.Place", b =>
                {
                    b.HasOne("BusinessLogic.Entities.Cinema_Hall", "Hall")
                        .WithMany("Places")
                        .HasForeignKey("Cinema_HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hall");
                });

            modelBuilder.Entity("BusinessLogic.Entities.Sessions", b =>
                {
                    b.HasOne("BusinessLogic.Entities.Cinema_Hall", "Cinema_Hall")
                        .WithMany()
                        .HasForeignKey("Cinema_HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema_Hall");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("DataAccess.Entities.Film", b =>
                {
                    b.HasOne("BusinessLogic.Entities.Category", "Category")
                        .WithMany("Films")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessLogic.Entities.Company", "Company")
                        .WithMany("Films")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessLogic.Entities.User", null)
                        .WithMany("Films")
                        .HasForeignKey("UserId");

                    b.Navigation("Category");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BusinessLogic.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BusinessLogic.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessLogic.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BusinessLogic.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusinessLogic.Entities.Category", b =>
                {
                    b.Navigation("Films");
                });

            modelBuilder.Entity("BusinessLogic.Entities.Cinema_Hall", b =>
                {
                    b.Navigation("Places");
                });

            modelBuilder.Entity("BusinessLogic.Entities.Company", b =>
                {
                    b.Navigation("Films");
                });

            modelBuilder.Entity("BusinessLogic.Entities.User", b =>
                {
                    b.Navigation("Films");
                });

            modelBuilder.Entity("DataAccess.Entities.Film", b =>
                {
                    b.Navigation("Halls");
                });
#pragma warning restore 612, 618
        }
    }
}
