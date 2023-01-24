using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options) 
        {

        
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        //some default data seeding into the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
                    ShortName="IND"
                },
                new Country
                {
                    Id = 2,
                    Name="China",
                    ShortName="CH"
                },
                new Country
                {
                    Id = 3,
                    Name="United States of America",
                    ShortName="USA"
                }
                ) ;
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Novotel",
                    Address="Hyderabad",
                    CountryId=1,
                    Rating=4.5

                },
                new Hotel
                {
                    Id = 2,
                    Name="Comfort Suites",
                    Address="George Town",
                    CountryId=3,
                    Rating= 4
                },
                new Hotel { 
                    Id = 3,
                    Name="Grand Palldium",
                    Address = "Nassaua",
                    CountryId=2,
                    Rating = 4.3
                }
                );
        }
    }
}
