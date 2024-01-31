using System.ComponentModel.DataAnnotations;

namespace AirPort_API.Entities
{
    public class AirPlane
    {
        [Key]public int AirplaneId { get; set; }
        public string Company { get; set; }
        public int NumSeats { get; set; }
        public bool IsProper { get; set; }
    }
}
