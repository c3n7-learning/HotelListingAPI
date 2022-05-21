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
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {

        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                    Id = 1,
                    Name = "Kenya",
                    ShortName = "KE"
                },
                new Country
                {
                    Id = 2,
                    Name = "Tanzania",
                    ShortName = "TZ"
                },
                new Country
                {
                    Id = 3,
                    Name = "Uganda",
                    ShortName = "UG"
                }
            );
        }
    }
}