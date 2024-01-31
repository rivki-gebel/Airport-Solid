using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort_API.Entities
{
    public class Flight
    {        
        [Key] public int FlightId { get; set; }
        public List<Passanger> Passengers { get; set; } 
        public string Destination { get; set;}
        public string SourceLand { get; set;}
        public double Cost { get; set; }
        public DateTime TakeingOffTime { get; set; }
        public int AirplaneID { get; set; }
        public AirPlane Airplane { get; set; }

        public Flight()
        {
            Passengers = new List<Passanger>();
        }

    }
}
