using Labb3_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb3_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasData(
                    new Person()
                    {
                        Id = 1,
                        Name = "Oliver Rodin",
                        Address = "Lyckovägen 11",
                        Email = "oliver@oliver.com",
                        PhoneNumber = 010999301
                    },
                    new Person()
                    {
                        Id = 2,
                        Name = "Amina Eliasson",
                        Address = "Glada gatan 3",
                        Email = "amina@amina.com",
                        PhoneNumber = 010765342
                    },
                    new Person()
                    {
                        Id = 3,
                        Name = "Fredrik Nilsson",
                        Address = "Happy Street 13",
                        Email = "fredrik@fredrik.com",
                        PhoneNumber = 010946371
                    },
                    new Person()
                    {
                        Id = 4,
                        Name = "Sofie Johansen",
                        Address = "Tjärnvägen 1",
                        Email = "sofie@sofie.com",
                        PhoneNumber = 010761301
                    }
                );
            modelBuilder.Entity<Interest>()
                .HasData(
                    new Interest()
                    {
                        Id = 1,
                        Title = "Movies",
                        Description = "Love all kind of movies from Action to love comedies."
                    },
                    new Interest()
                    {
                        Id = 2,
                        Title = "Traveling",
                        Description = "Get a rush every time i have the chance to explore our beautiful mother earth!"
                    },
                    new Interest()
                    {
                        Id = 3,
                        Title = "Cooking",
                        Description = "The feeling of cooking food for families and friends is Fantastic!"
                    },
                    new Interest()
                    {
                        Id = 4,
                        Title = "Books",
                        Description = "Read books i like therapy, it emphasize your soul!"
                    },
                    new Interest()
                    {
                        Id = 5,
                        Title = "Gravel-biking",
                        Description = "Its a great way of training and discover your surroundings."
                    },
                    new Interest()
                    {
                        Id = 6,
                        Title = "Photographing",
                        Description = "Its a nice way to express your aesthetic mind."
                    },
                    new Interest()
                    {
                        Id = 7,
                        Title = "Backpacks",
                        Description = "Everybody need a backpack and you cant have to many!"
                    }
                );

            modelBuilder.Entity<Link>()
                .HasData(
                    new Link()
                    {
                        Id = 1,
                        Url = "https://en.wikipedia.org/wiki/History_of_film",
                        InterestId = 1,
                        PersonId = 4
                    },
                    new Link()
                    {
                        Id = 2,
                        Url = "https://www.imdb.com/",
                        InterestId = 1,
                        PersonId = 3
                    },
                    new Link()
                    {
                        Id = 3,
                        Url = "https://www.tripadvisor.com/",
                        InterestId = 2,
                        PersonId = 3
                    },
                    new Link()
                    {
                        Id = 4,
                        Url = "https://www.airbnb.com/",
                        InterestId = 2,
                        PersonId = 3
                    },
                    new Link()
                    {
                        Id = 5,
                        Url = "https://www.thefork.com/",
                        InterestId = 3,
                        PersonId = 2
                    },
                    new Link()
                    {
                        Id = 6,
                        Url = "https://12fwd.com/",
                        InterestId = 3,
                        PersonId = 2
                    },
                    new Link()
                    {
                        Id = 7,
                        Url = "https://wordery.com/",
                        InterestId = 4,
                        PersonId = 4
                    },
                    new Link()
                    {
                        Id = 8,
                        Url = "https://harappa.education/harappa-diaries/importance-of-reading/",
                        InterestId = 4,
                        PersonId = 3
                    },
                    new Link()
                    {
                        Id = 9,
                        Url = "https://www.bikeradar.com/features/routes-and-rides/what-is-gravel-riding/",
                        InterestId = 5,
                        PersonId = 1
                    },
                    new Link()
                    {
                        Id = 10,
                        Url = "https://www.canyon.com/sv-se/gravel-bikes/bike-packing/grizl/al/",
                        InterestId = 5,
                        PersonId = 1,
                    },
                    new Link()
                    {
                        Id = 11,
                        Url = "https://www.borrowlenses.com/blog/photography-tips/",
                        InterestId = 6,
                        PersonId = 2
                    },
                    new Link()
                    {
                        Id = 12,
                        Url =
                            "https://www.digitalcameraworld.com/tutorials/147-photography-techniques-tips-and-tricks-for-taking-pictures-of-anything",
                        InterestId = 6,
                        PersonId = 2
                    },
                    new Link()
                    {
                        Id = 13,
                        Url = "https://www.carryology.com/",
                        InterestId = 7,
                        PersonId = 1
                    },
                    new Link()
                    {
                        Id = 14,
                        Url = "https://rushfaster.com.au/",
                        InterestId = 7,
                        PersonId = 1
                    }
                );

            modelBuilder.Entity<Person>()
                .HasMany(i => i.Interests)
                .WithMany(p => p.Persons)
                .UsingEntity<Dictionary<string, object>>(
                    "PersonInterest",
                    x => x.HasOne<Interest>().WithMany().HasForeignKey("InterestId"),
                    y => y.HasOne<Person>().WithMany().HasForeignKey("PersonId"),
                    xy =>
                    {
                        xy.HasKey("PersonId", "InterestId");
                        xy.HasData(
                            new { PersonId = 1, InterestId = 5 },
                            new { PersonId = 1, InterestId = 7 },
                            new { PersonId = 2, InterestId = 6 },
                            new { PersonId = 2, InterestId = 3 },
                            new { PersonId = 3, InterestId = 1 },
                            new { PersonId = 3, InterestId = 2 },
                            new { PersonId = 3, InterestId = 4 },
                            new { PersonId = 4, InterestId = 1 },
                            new { PersonId = 4, InterestId = 4 }
                        );

                    });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Link> Links { get; set; }
    }
}
