using AirPort_API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AirPort_API
{
    public class DataContext:DbContext
    {
        private readonly IConfiguration _configuration;

        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<AirPlane> airplaneList { get; set; }
        public DbSet<Flight> flightsList { get; set; }
        public DbSet<Passanger> passangersList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration["DbConnectionString"]);           
          
        }
      
    }
}
