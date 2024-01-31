using AirPort_API.Entities;
using System.ComponentModel.DataAnnotations;

namespace Airport_solidApi.Models
{
    public class FlightPostModel
    {
        public string Destination { get; set; }
        public string SourceLand { get; set; }
        public double Cost { get; set; }
        public DateTime TakeingOffTime { get; set; }
        public int AirplaneID { get; set; }
        
    }
}
