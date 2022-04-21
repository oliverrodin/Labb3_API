﻿// <auto-generated />
using Labb3_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb3_API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220421141331_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Labb3_API.Models.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Love all kind of movies from Action to love comedies.",
                            Title = "Movies"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Get a rush every time i have the chance to explore our beautiful mother earth!",
                            Title = "Traveling"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The feeling of cooking food for families and friends is Fantastic!",
                            Title = "Cooking"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Read books i like therapy, it emphasize your soul!",
                            Title = "Books"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Its a great way of training and discover your surroundings.",
                            Title = "Gravel-biking"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Its a nice way to express your aesthetic mind.",
                            Title = "Photographing"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Everybody need a backpack and you cant have to many!",
                            Title = "Backpacks"
                        });
                });

            modelBuilder.Entity("Labb3_API.Models.Link", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("InterestId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InterestId");

                    b.HasIndex("PersonId");

                    b.ToTable("Links");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InterestId = 1,
                            PersonId = 4,
                            Url = "https://en.wikipedia.org/wiki/History_of_film"
                        },
                        new
                        {
                            Id = 2,
                            InterestId = 1,
                            PersonId = 3,
                            Url = "https://www.imdb.com/"
                        },
                        new
                        {
                            Id = 3,
                            InterestId = 2,
                            PersonId = 3,
                            Url = "https://www.tripadvisor.com/"
                        },
                        new
                        {
                            Id = 4,
                            InterestId = 2,
                            PersonId = 3,
                            Url = "https://www.airbnb.com/"
                        },
                        new
                        {
                            Id = 5,
                            InterestId = 3,
                            PersonId = 2,
                            Url = "https://www.thefork.com/"
                        },
                        new
                        {
                            Id = 6,
                            InterestId = 3,
                            PersonId = 2,
                            Url = "https://12fwd.com/"
                        },
                        new
                        {
                            Id = 7,
                            InterestId = 4,
                            PersonId = 4,
                            Url = "https://wordery.com/"
                        },
                        new
                        {
                            Id = 8,
                            InterestId = 4,
                            PersonId = 3,
                            Url = "https://harappa.education/harappa-diaries/importance-of-reading/"
                        },
                        new
                        {
                            Id = 9,
                            InterestId = 5,
                            PersonId = 1,
                            Url = "https://www.bikeradar.com/features/routes-and-rides/what-is-gravel-riding/"
                        },
                        new
                        {
                            Id = 10,
                            InterestId = 5,
                            PersonId = 1,
                            Url = "https://www.canyon.com/sv-se/gravel-bikes/bike-packing/grizl/al/"
                        },
                        new
                        {
                            Id = 11,
                            InterestId = 6,
                            PersonId = 2,
                            Url = "https://www.borrowlenses.com/blog/photography-tips/"
                        },
                        new
                        {
                            Id = 12,
                            InterestId = 6,
                            PersonId = 2,
                            Url = "https://www.digitalcameraworld.com/tutorials/147-photography-techniques-tips-and-tricks-for-taking-pictures-of-anything"
                        },
                        new
                        {
                            Id = 13,
                            InterestId = 7,
                            PersonId = 1,
                            Url = "https://www.carryology.com/"
                        },
                        new
                        {
                            Id = 14,
                            InterestId = 7,
                            PersonId = 1,
                            Url = "https://rushfaster.com.au/"
                        });
                });

            modelBuilder.Entity("Labb3_API.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Lyckovägen 11",
                            Email = "oliver@oliver.com",
                            Name = "Oliver Rodin",
                            PhoneNumber = 10999301
                        },
                        new
                        {
                            Id = 2,
                            Address = "Glada gatan 3",
                            Email = "amina@amina.com",
                            Name = "Amina Eliasson",
                            PhoneNumber = 10765342
                        },
                        new
                        {
                            Id = 3,
                            Address = "Happy Street 13",
                            Email = "fredrik@fredrik.com",
                            Name = "Fredrik Nilsson",
                            PhoneNumber = 10946371
                        },
                        new
                        {
                            Id = 4,
                            Address = "Tjärnvägen 1",
                            Email = "sofie@sofie.com",
                            Name = "Sofie Johansen",
                            PhoneNumber = 10761301
                        });
                });

            modelBuilder.Entity("PersonInterest", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("InterestId")
                        .HasColumnType("int");

                    b.HasKey("PersonId", "InterestId");

                    b.HasIndex("InterestId");

                    b.ToTable("PersonInterest");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            InterestId = 5
                        },
                        new
                        {
                            PersonId = 1,
                            InterestId = 7
                        },
                        new
                        {
                            PersonId = 2,
                            InterestId = 6
                        },
                        new
                        {
                            PersonId = 2,
                            InterestId = 3
                        },
                        new
                        {
                            PersonId = 3,
                            InterestId = 1
                        },
                        new
                        {
                            PersonId = 3,
                            InterestId = 2
                        },
                        new
                        {
                            PersonId = 3,
                            InterestId = 4
                        },
                        new
                        {
                            PersonId = 4,
                            InterestId = 1
                        },
                        new
                        {
                            PersonId = 4,
                            InterestId = 4
                        });
                });

            modelBuilder.Entity("Labb3_API.Models.Link", b =>
                {
                    b.HasOne("Labb3_API.Models.Interest", "Interest")
                        .WithMany("Links")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb3_API.Models.Person", "Person")
                        .WithMany("Links")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interest");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("PersonInterest", b =>
                {
                    b.HasOne("Labb3_API.Models.Interest", null)
                        .WithMany()
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb3_API.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Labb3_API.Models.Interest", b =>
                {
                    b.Navigation("Links");
                });

            modelBuilder.Entity("Labb3_API.Models.Person", b =>
                {
                    b.Navigation("Links");
                });
#pragma warning restore 612, 618
        }
    }
}
