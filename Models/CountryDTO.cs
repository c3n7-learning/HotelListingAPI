using System.ComponentModel.DataAnnotations;


namespace HotelListing.Models
{
    public class CountryDTO
    {
        public int Id { get; set; }  // prop

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name is Too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Short Name is Too Long")]
        public string ShortName { get; set; }
    }

    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name is Too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Short Name is Too Long")]
        public string ShortName { get; set; }
    }

}

