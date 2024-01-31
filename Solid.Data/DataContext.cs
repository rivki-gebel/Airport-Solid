using AirPort_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace AirPort_API
{
    public class DataContext:DbContext
    {
        public DbSet<AirPlane> airplaneList { get; set; }
        public DbSet<Flight> flightsList { get; set; }
        public DbSet<Passanger> passangersList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=last");           
          
        }
      
    }
}
