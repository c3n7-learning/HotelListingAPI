using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }


        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Kenya",
                    ShortName = "KE"
                }
                ,
                new Country
                {
                    Id = 2,
                    Name = "Tanzania",
                    ShortName = "TZ"
                }, new Country
                {
                    Id = 3,
                    Name = "Uganda",
                    ShortName = "UG"
                }
            );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Safari Park",
                    Address = "Nairobi",
                    Rating = 4.5,
                    CountryId = 1
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Kyamatu",
                    Address = "Kampala",
                    Rating = 2.4,
                    CountryId = 3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Do Do Mjini",
                    Address = "Dar Es Salaam",
                    Rating = 4.4,
                    CountryId = 2
                }
            );
        }
    }
}
