using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelListing.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {

        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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