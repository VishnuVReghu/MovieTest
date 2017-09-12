namespace HomeCinema.Data.Migrations
{
    using HomeCinema.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HomeCinemaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HomeCinemaContext context)
        {
            //  create genres
            context.GenreSet.AddOrUpdate(g => g.Name, GenerateGenres());

            // create movies
            //context.MovieSet.AddOrUpdate(m => m.Title, GenerateMovies());

            //// create stocks
            context.StockSet.AddOrUpdate(GenerateStocks());

            // create customers
            context.CustomerSet.AddOrUpdate(GenerateCustomers());

            // create roles
            context.RoleSet.AddOrUpdate(r => r.Name, GenerateRoles());

            // username: chsakell, password: homecinema
            context.UserSet.AddOrUpdate(u => u.Email, new User[]{
                new User()
                {
                    Email="chsakells.blog@gmail.com",
                    Username="chsakell",
                    HashedPassword ="XwAQoiq84p1RUzhAyPfaMDKVgSwnn80NCtsE8dNv3XI=",
                    Salt = "mNKLRbEFCH8y1xIyTXP4qA==",
                    IsLocked = false,
                    DateCreated = DateTime.Now
                },
                new User()
                {
                    Email="criss@gmail.com",
                    Username="criss",
                    HashedPassword ="XwAQoiq84p1RUzhAyPfaMDKVgSwnn80NCtsE8dNv3XI=",
                    Salt = "mNKLRbEFCH8y1xIyTXP4qA==",
                    IsLocked = false,
                    DateCreated = DateTime.Now
                }
            });

            // // create user-admin for chsakell
            context.UserRoleSet.AddOrUpdate(new UserRole[] {
                new UserRole() {
                    RoleId = 1, // admin
                    UserId = 1  // chsakell
                }
            });
        }

        private Genre[] GenerateGenres()
        {
            Genre[] genres = new Genre[] {
                new Genre() { Name = "Comedy" },
                new Genre() { Name = "Sci-fi" },
                new Genre() { Name = "Action" },
                new Genre() { Name = "Horror" },
                new Genre() { Name = "Romance" },
                new Genre() { Name = "Comedy" },
                new Genre() { Name = "Crime" },
            };

            return genres;
        }
        private Movie[] GenerateMovies()
        {
            Movie[] movies = new Movie[] {
                new Movie()
                {   Title="Minions",
                    Description = "Minions Stuart, Kevin and Bob are recruited by Scarlet Overkill.",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10)
                },
                new Movie()
                {   Title="Ted 2",
                    Description = "Newlywed couple Ted and Tami-Lynn want to have a baby.",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10)
                },
                new Movie()
                {   Title="Trainwreck",
                    Description = "Having thought that monogamy was never possible.",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10)
                },
                new Movie()
                {   Title="Inside Out",
                    Description = "After young Riley is uprooted from her Midwest life",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10)
                },
                new Movie()
                {   Title="Home",
                    Description = "Oh, an alien on the run from his own people, lands on Earth and makes.",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10)
                },
                new Movie()
                {   Title="Batman v Superman: Dawn of Justice",
                    Description = "Fearing the actions of a god-like Super Hero left unchecked, Gotham.",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10)
                },
                new Movie()
                {   Title="Ant-Man",
                    Description = "Armed with a super-suit with the astonishing ability to shrink in scale.",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10)
                },
                new Movie()
                {   Title="Jurassic World",
                    Description = "A new theme park is built on the original site of Jurassic Park.",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10)
                },
                new Movie()
                {   Title="Fantastic Four",
                    Description = "Four young outsiders teleport to an alternate.",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10)
                },
                new Movie()
                {   Title="Mad Max: Fury Road",
                    Description = "In a stark desert landscape where humanity is broken, two rebels just might be able to restore order:",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10)
                },
                new Movie()
                {   Title="True Detective",
                    Description = "An anthology series in which police investigations unearth the personal and professional secrets.",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10)
                },
                new Movie()
                {   Title="The Longest Ride",
                    Description = "After an automobile crash, the lives of a young couple intertwine with a much older man.",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10)
                },
                new Movie()
                {   Title="The Walking Dead",
                    Description = "Sheriff's Deputy Rick Grimes leads a group of survivors in a world overrun by zombies.",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10)
                },
                new Movie()
                {   Title="Southpaw",
                    Description = "Boxer Billy Hope turns to trainer Tick Willis to help him get his life back on track",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10)
                },
                new Movie()
                {   Title="Specter",
                    Description = "A cryptic message from Bond's past sends him on a trail to uncover a sinister organization.",
                    State="Completed",
                    CreatedDate= new DateTime(2015, 7, 10),
                    ModifiedDate=new DateTime(2015, 7, 10)
                },
            };

            return movies;
        }
        private Stock[] GenerateStocks()
        {
            List<Stock> stocks = new List<Stock>();

            for (int i = 1; i <= 15; i++)
            {
                // Three stocks for each movie
                for (int j = 0; j < 3; j++)
                {
                    Stock stock = new Stock()
                    {
                        //MovieId = i,
                        UniqueKey = Guid.NewGuid(),
                        IsAvailable = true
                    };
                    stocks.Add(stock);
                }
            }

            return stocks.ToArray();
        }
        private Customer[] GenerateCustomers()
        {
            List<Customer> _customers = new List<Customer>();

            // Create 100 customers
            for (int i = 0; i < 100; i++)
            {
                Customer customer = new Customer()
                {
                    FirstName = MockData.Person.FirstName(),
                    LastName = MockData.Person.Surname(),
                    IdentityCard = Guid.NewGuid().ToString(),
                    UniqueKey = Guid.NewGuid(),
                    Email = MockData.Internet.Email(),
                    DateOfBirth = new DateTime(1985, 10, 20).AddMonths(i).AddDays(10),
                    RegistrationDate = DateTime.Now.AddDays(i),
                    Mobile = "1234567890"
                };

                _customers.Add(customer);
            }

            return _customers.ToArray();
        }
        private Role[] GenerateRoles()
        {
            Role[] _roles = new Role[]{
                new Role()
                {
                    Name="Admin"
                }
            };

            return _roles;
        }
        /*private Rental[] GenerateRentals()
        {
            for (int i = 1; i <= 45; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Random r = new Random();
                    int customerId = r.Next(1, 99);
                    Rental _rental = new Rental()
                    {
                        CustomerId = 1,
                        StockId = 1,
                        Status = "Returned",
                        RentalDate = DateTime.Now.AddDays(j),
                        ReturnedDate = DateTime.Now.AddDays(j + 1)
                    };
                    _rentals.Add(_rental);
                }
            }
            //return _rentals.ToArray();
        }*/
    }
}